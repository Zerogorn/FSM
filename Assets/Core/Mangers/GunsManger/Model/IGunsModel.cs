using Managers.GunsManger.Item;
using UnityEngine;

namespace Managers.GunsManger.Model
{
    public interface IGunsModel
    {
        void Add(IItemView itemView);
        void Remove(IItemView itemView);
        Vector2 GetNearestItem(Vector2 fromPoint);
        int CountItem();
    }
}