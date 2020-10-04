using Fsm;
using Managers.FinderManger.View;
using Uit.Ai.Components;
using UnityEngine;

namespace Uit.Ai.Behavior
{
    public sealed class RunFormMouse : BaseBehavior
    {
        private Rotation _rotation;
        
        public RunFormMouse(IFsmController fsmController, IFinderController finderController)
            : base(fsmController, finderController)
        {
            _rotation = new Rotation();
        }

        public override void Execute()
        {
            Rotation();
            Move();
        }

        private void Rotation()
        {
            var position = FinderController.GetPosition();
            var target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            FinderController.SetRotation(_rotation.RotateFrom(target, position));
        }

        private void Move()
        {
            FinderController.MoveForward(FinderController.Configuration.RunSpeed);
        }
    }
}