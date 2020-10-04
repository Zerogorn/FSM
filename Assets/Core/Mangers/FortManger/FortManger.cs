using Managers.ContainerManger;
using Managers.ContainerManger.Controllers;
using Managers.FortManger.Factory;
using Managers.FortManger.Item;
using UnityEngine;

namespace Managers.FortManger
{
    public sealed class FortManger : IFortManger
    {
        private IContainerManger _containerManger;
        private IFortFactory _factory;

        private Transform _container;
        private IFortView _fortView;

        public FortManger(IContainerManger containerManger, IFortFactory factory)
        {
            _containerManger = containerManger;
            _factory = factory;
        }

        public void CreateFort()
        {
            _container = _containerManger.GetContainer<FortContainer>();

            _fortView = _factory.CreateFort(_container);
        }

        public Vector2 GetFortPosition()
        {
            return _fortView.GetPosition();
        }
    }
}