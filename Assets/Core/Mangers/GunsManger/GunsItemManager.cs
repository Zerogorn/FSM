using Managers.ContainerManger;
using Managers.ContainerManger.Controllers;
using Managers.GunsManger.Item;
using Managers.GunsManger.Model;
using Managers.GunsManger.Service;
using UniRx;
using UnityEngine;

namespace Managers.GunsManger
{
    public sealed class GunsItemManager : IGunsItemManager
    {
        private const int MAX_ITEMS = 5;

        private IContainerManger _containerManger;
        private IGunsModel _gunsModel;
        private IGunGeneratorService _gunGeneratorService;

        private Transform _container;

        public GunsItemManager(IContainerManger containerManger, IGunsModel gunsModel, IGunGeneratorService gunGeneratorService)
        {
            _containerManger = containerManger;
            _gunsModel = gunsModel;
            _gunGeneratorService = gunGeneratorService;
        }

        public void CreateGuns()
        {
            _container = _containerManger.GetContainer<GunContainer>();

            Observable.EveryUpdate().Subscribe(_ =>
            {
                if (_gunsModel.CountItem() < MAX_ITEMS)
                {
                    _gunGeneratorService.CreateNewItem(_container);
                }
            });
        }

        public Vector2 GetNearestItemPosition(Vector2 fromPoint)
        {
            return _gunsModel.GetNearestItem(fromPoint);
        }

        public void RemoveGun(IItemView item)
        {
            _gunGeneratorService.DestroyItem(item);
        }
    }
}