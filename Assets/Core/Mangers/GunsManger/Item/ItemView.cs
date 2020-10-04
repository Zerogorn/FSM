using UnityEngine;

namespace Managers.GunsManger.Item
{
    public sealed class ItemView : MonoBehaviour, IItemView
    {
        public Vector2 GetPosition()
        {
            return transform.localPosition;
        }

        public void SetPosition(Vector2 position)
        {
            transform.localPosition = position;
        }

        public void Destroy()
        {
            Destroy(gameObject);
        }
    }
}