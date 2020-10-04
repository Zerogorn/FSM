using Managers.Factory;
using Managers.GunsManger.Item;
using Managers.GunsManger.Obj;
using UnityEngine;

namespace Managers.GunsManger.Factory
{
    public sealed class GunsFactory: IGunsFactory
    {
        private readonly GeneratorFactory<GunsObj> _gunsObj;

        public GunsFactory()
        {
            _gunsObj = new GeneratorFactory<GunsObj>();
        }

        public void Initialization()
        {
            _gunsObj.Initialization();
        }

        public IItemView CreateRandomItem(Transform container)
        {
            var index = Random.Range(0, _gunsObj.Obj.ItemViews.Count);
            var newItem = Object.Instantiate(_gunsObj.Obj.ItemViews[index], container);
            newItem.gameObject.SetActive(true);

            return newItem;
        }
    }
}