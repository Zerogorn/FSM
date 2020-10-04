using System;
using Fsm;
using Fsm.Behavior.interfaces;
using Managers.FinderManger.View;

namespace Uit.Ai.Behavior
{
    public abstract class BaseBehavior : IBehavior
    {
        protected IFsmController FsmController { get; }
        protected IFinderController FinderController { get;}

        protected BaseBehavior(IFsmController fsmController, IFinderController finderController)
        {
            FsmController = fsmController;
            FinderController = finderController;
        }

        public virtual void Dispose()
        {
            
        }

        public virtual void Execute()
        {
            
        }
    }
}