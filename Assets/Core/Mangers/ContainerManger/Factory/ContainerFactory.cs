using UnityEngine;
using UnityEngine.Rendering;

namespace Managers.ContainerManger.Factory
{
    public sealed class ContainerFactory : IContainerFactory
    {
        public Transform Create(string name, int layerOrder)
        {
            var container = new GameObject(name).transform;
            container.transform.position = Vector3.zero;

            var sortingGroup = container.gameObject.AddComponent<SortingGroup>();
            sortingGroup.sortingOrder = layerOrder;

            return container;
        }
    }
}