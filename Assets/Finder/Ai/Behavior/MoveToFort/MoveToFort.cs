using Core;
using Fsm;
using Managers.FinderManger.View;
using Managers.FortManger;
using Uit.Ai.Components;

namespace Uit.Ai.Behavior.Base
{
    public sealed class MoveToFort : BaseBehavior
    {
        private Move _move;
        private Rotation _rotate;

        public MoveToFort(IFsmController fsmController, IFinderController finderController)
            : base(fsmController, finderController)
        {
            _move = new Move();
            _rotate = new Rotation();
        }

        private IFortManger _fortManger => ContextProvider.Instance.FortManger;

        public override void Execute()
        {
            SetRotation();
            MoveTo();
        }

        private void SetRotation()
        {
            var unitPosition = FinderController.GetPosition();
            var target = _fortManger.GetFortPosition();

            FinderController.SetRotation(_rotate.RotateTo(unitPosition, target));
        }

        private void MoveTo()
        {
            var unitPosition = FinderController.GetPosition();
            var target = _fortManger.GetFortPosition();

            FinderController.SetPosition(_move.MoveTo(unitPosition, target, FinderController.Configuration.ReturnSpeed));
        }
    }
}