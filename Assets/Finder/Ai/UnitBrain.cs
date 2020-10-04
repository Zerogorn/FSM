using System;
using Fsm;
using Fsm.Behavior.interfaces;
using Fsm.Data;
using Fsm.Extension;
using Managers.FinderManger.View;
using Uit.Ai.Behavior;
using Uit.Ai.Behavior.Base;
using Uit.Ai.Behavior.MovToItem;
using UniRx;

namespace Finder.Ai
{
    public sealed class UnitBrain : IDisposable
    {
        private readonly CompositeDisposable _compositeDisposable;
        private readonly IFsmController _fsmController;
        private readonly IFinderController _finderController;

        public UnitBrain(IFinderController finderController)
        {
            _compositeDisposable = new CompositeDisposable();
            _fsmController = new FsmController();
            _finderController = finderController;
        }

        public void Initialization<TBehavior>()
            where TBehavior : IBehavior
        {
            AddBehaviors();
            Subscribe();

            _fsmController.SetDefaultBehavior<TBehavior>();
        }

        private void AddBehaviors()
        {
            new BehaviorData(new MoveValidator(_finderController, _fsmController), new MoveToTarget(_fsmController, _finderController))
                .AddBehaviorDataToFsmController<MoveToTarget>(_fsmController);

            new BehaviorData(new MoveToFortValidator(_finderController, _fsmController), new MoveToFort(_fsmController, _finderController))
                .AddBehaviorDataToFsmController<MoveToFort>(_fsmController);

            new BehaviorData(new RunFormMouseValidator(_finderController, _fsmController), new RunFormMouse(_fsmController, _finderController))
                .AddBehaviorDataToFsmController<RunFormMouse>(_fsmController);
        }

        private void Subscribe()
        {
            Observable.EveryUpdate().Subscribe(_ => _fsmController.Execute()).AddTo(_compositeDisposable);
        }

        public void Dispose()
        {
            _compositeDisposable?.Dispose();
        }
    }
}