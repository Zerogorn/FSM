using Fsm;
using Managers.FinderManger.View;
using Uit.Ai.Behavior.MovToItem;
using Uit.Ai.Validators;
using UnityEngine;

namespace Uit.Ai.Behavior.Base
{
    public class MoveToFortValidator : ValidatorBase
    {
        public MoveToFortValidator(IFinderController finderController, IFsmController fsmController)
            : base(finderController, fsmController)
        {
        }

        public override void IsValid()
        {
            if (!FinderController.HasItem())
            {
                FsmController.PopBehavior<MoveToFort>();
                FsmController.PushBehavior<MoveToTarget>();
            }
            else if (RunFromMouse())
            {
                FsmController.PushBehavior<RunFormMouse>();
            }
        }

        private bool RunFromMouse()
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var distanceToMouse = Vector2.Distance(FinderController.GetPosition(), mousePosition);

            return distanceToMouse < FinderController.Configuration.RunDistance;
        }
    }
}