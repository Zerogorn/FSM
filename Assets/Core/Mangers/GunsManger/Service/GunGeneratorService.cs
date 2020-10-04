using Managers.GunsManger.Factory;
using Managers.GunsManger.Item;
using Managers.GunsManger.Model;
using UnityEngine;

namespace Managers.GunsManger.Service
{
    public sealed class GunGeneratorService : IGunGeneratorService
    {
        private IGunsFactory _gunsFactory;
        private IGunsModel _gunsModel;

        public GunGeneratorService(IGunsFactory gunsFactory, IGunsModel gunsModel)
        {
            _gunsFactory = gunsFactory;
            _gunsModel = gunsModel;
        }

        public void CreateNewItem(Transform container)
        {
            var newItem = _gunsFactory.CreateRandomItem(container);
            SetPosition(newItem);
            _gunsModel.Add(newItem);
        }

        public void DestroyItem(IItemView item)
        {
            _gunsModel.Remove(item);
            item.Destroy();
        }

        private void SetPosition(IItemView item)
        {
            var x = Random.Range(0, Camera.main.pixelWidth);
            var y = Random.Range(0, Camera.main.pixelHeight);
            var position = Camera.main.ScreenToWorldPoint(new Vector2(x, y));
            
            item.SetPosition(position);
        }                              
    }
}