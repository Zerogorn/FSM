using UnityEngine;

namespace Managers.FortManger.Item
{
    public sealed class FortView : MonoBehaviour, IFortView
    {
        public Vector2 GetPosition()
        {
            return transform.localPosition;
        }
    }
}