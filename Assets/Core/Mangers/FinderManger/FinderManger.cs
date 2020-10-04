using Finder.Ai;
using Managers.ContainerManger;
using Managers.ContainerManger.Controllers;
using Managers.FinderManger.Factory;
using Uit.Ai.Behavior.MovToItem;
using UnityEngine;

namespace Managers.FinderManger
{
    public sealed class FinderManger : IFinderManger
    {
        private IContainerManger _containerManger;
        private IFinderFactory _finderFactory;

        private Transform _container;

        public FinderManger(IContainerManger containerManger, IFinderFactory finderFactory)
        {
            _containerManger = containerManger;
            _finderFactory = finderFactory;
        }

        public void CreateFinder()
        {
            _container = _containerManger.GetContainer<FindersContainer>();

            var finderController = _finderFactory.Create(_container);
            var finderBrain = new UnitBrain(finderController);
            finderBrain.Initialization<MoveToTarget>();
        }
    }
}