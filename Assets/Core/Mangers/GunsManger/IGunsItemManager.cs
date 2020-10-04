using Managers.GunsManger.Item;
using UnityEngine;

namespace Managers.GunsManger
{
    public interface IGunsItemManager
    {
        Vector2 GetNearestItemPosition(Vector2 fromPoint);
        void CreateGuns();
        void RemoveGun(IItemView item);
    }
}