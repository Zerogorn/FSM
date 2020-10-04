using Core;
using Fsm;
using Managers.FinderManger.View;
using Managers.GunsManger;
using Uit.Ai.Components;

namespace Uit.Ai.Behavior.MovToItem
{
    public sealed class MoveToTarget : BaseBehavior
    {
        private Move _move;
        private Rotation _rotate;

        public MoveToTarget(IFsmController fsmController, IFinderController finderController)
            : base(fsmController, finderController)
        {
            _move = new Move();
            _rotate = new Rotation();
        }

        private IGunsItemManager _gunsItemManager => ContextProvider.Instance.GunsItemManager;

        public override void Execute()
        {
            SetRotation();
            MoveToGun();
        }

        private void SetRotation()
        {
            var unitPosition = FinderController.GetPosition();
            var target = _gunsItemManager.GetNearestItemPosition(unitPosition);

            FinderController.SetRotation(_rotate.RotateTo(unitPosition, target));
        }

        private void MoveToGun()
        {
            var unitPosition = FinderController.GetPosition();
            var target = _gunsItemManager.GetNearestItemPosition(unitPosition);

            FinderController.SetPosition(_move.MoveTo(unitPosition, target, FinderController.Configuration.MoveSpeed));
        }
    }
}