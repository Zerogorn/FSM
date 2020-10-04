using Fsm;
using Managers.FinderManger.View;
using Uit.Ai.Behavior.Base;
using Uit.Ai.Validators;

namespace Uit.Ai.Behavior.MovToItem
{
    public sealed class MoveValidator : ValidatorBase
    {
        public MoveValidator(IFinderController finderController, IFsmController fsmController)
            : base(finderController, fsmController)
        {
        }

        public override void IsValid()
        {
            if (FinderController.HasItem())
            {
                FsmController.PopBehavior<MoveToTarget>();
                FsmController.PushBehavior<MoveToFort>();
            }
        }
    }
}