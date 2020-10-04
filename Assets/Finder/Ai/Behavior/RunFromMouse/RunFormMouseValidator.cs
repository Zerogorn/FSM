using Fsm;
using Managers.FinderManger.View;
using Uit.Ai.Validators;
using UnityEngine;

namespace Uit.Ai.Behavior
{
    public sealed class RunFormMouseValidator : ValidatorBase
    {
        public RunFormMouseValidator(IFinderController finderController, IFsmController fsmController)
            : base(finderController, fsmController)
        {
        }

        public override void IsValid()
        {
            if (!RunFromMouse())
            {
                FsmController.PopBehavior<RunFormMouse>();
            }
        }

        private bool RunFromMouse()
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var distanceToMouse = Vector2.Distance(FinderController.GetPosition(), mousePosition);

            return distanceToMouse < FinderController.Configuration.RunDistance * 2;
        }
    }
}