using System;
using System.Collections.Generic;
using Core.Mangers.ContainerManger.Containers;
using Managers.ContainerManger.Factory;
using UnityEngine;

namespace Managers.ContainerManger
{
    public sealed class ContainerManger : IContainerManger
    {
        private Dictionary<Type, Transform> _containers;

        private IContainerFactory _containerFactory;

        public Transform GetContainer<TContainer>()
        {
            return _containers[typeof(TContainer)];
        }

        public ContainerManger(IContainerFactory containerFactory)
        {
            _containers = new Dictionary<Type, Transform>();
            _containerFactory = containerFactory;
        }

        public void Add<TContainer>(int layerOrder)
             where TContainer : MonoBehaviour, IContainers
        {
            var type = typeof(TContainer);
            _containers.Add(type, _containerFactory.Create(type.Name, layerOrder));
        }
    }
}
