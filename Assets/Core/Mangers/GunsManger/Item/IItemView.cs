using UnityEngine;

namespace Managers.GunsManger.Item
{
    public interface IItemView
    {
        Vector2 GetPosition();
        void SetPosition(Vector2 position);
        void Destroy();
    }
}