using Managers.Factory;
using Managers.FinderManger.Obj;
using Managers.FinderManger.View;
using UnityEngine;

namespace Managers.FinderManger.Factory
{
    public sealed class FinderFactory : IFinderFactory
    {
        private GeneratorFactory<FinderObj> _finderObjFactory;

        public FinderFactory()
        {
            _finderObjFactory = new GeneratorFactory<FinderObj>();
        }

        public void Initialization()
        {
            _finderObjFactory.Initialization();
        }

        public IFinderController Create(Transform container)
        {
            var newItem = Object.Instantiate(_finderObjFactory.Obj.FinderController, container);
            newItem.Initialization(_finderObjFactory.Obj.Configuration);
            newItem.gameObject.SetActive(true);

            return newItem;
        }
    }
}