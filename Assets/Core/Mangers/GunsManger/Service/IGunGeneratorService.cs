using Managers.GunsManger.Item;
using UnityEngine;

namespace Managers.GunsManger.Service
{
    public interface IGunGeneratorService
    {
        void CreateNewItem(Transform container);
        void DestroyItem(IItemView item);
    }
}