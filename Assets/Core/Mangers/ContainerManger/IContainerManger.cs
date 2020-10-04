using Core.Mangers.ContainerManger.Containers;
using UnityEngine;

namespace Managers.ContainerManger
{
    public interface IContainerManger
    {
        void Add<TContainer>(int layerOrder)
            where TContainer : MonoBehaviour, IContainers;
        Transform GetContainer<TType>();
    }
}