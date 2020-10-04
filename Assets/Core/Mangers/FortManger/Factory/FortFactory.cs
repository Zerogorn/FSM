using Managers.Factory;
using Managers.FortManger.Item;
using Managers.FortManger.Obj;
using UnityEngine;

namespace Managers.FortManger.Factory
{
    public sealed class FortFactory : IFortFactory
    {
        private readonly GeneratorFactory<FortObj> _fort;

        public FortFactory()
        {
            _fort = new GeneratorFactory<FortObj>();
        }

        public void Initialization()
        {
            _fort.Initialization();
        }

        public IFortView CreateFort(Transform container)
        {
            var newItem = Object.Instantiate(_fort.Obj.FortView, container);
            newItem.gameObject.SetActive(true);

            return newItem;
        }
    }
}