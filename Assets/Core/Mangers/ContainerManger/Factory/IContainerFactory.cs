using UnityEngine;

namespace Managers.ContainerManger.Factory
{
    public interface IContainerFactory
    {
        Transform Create(string name, int layerOrder);
    }
}