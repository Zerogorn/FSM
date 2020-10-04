using Fsm;
using Managers.FinderManger.View;

namespace Uit.Ai.Validators
{
    public abstract class ValidatorBase : IValidator
    {
        protected IFinderController FinderController { get; }
        protected IFsmController FsmController { get; }

        protected ValidatorBase(IFinderController finderController, IFsmController fsmController)
        {
            FinderController = finderController;
            FsmController = fsmController;
        }

        public abstract void IsValid();
    }
}