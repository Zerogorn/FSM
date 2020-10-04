using Managers.GunsManger.Item;
using UnityEngine;

namespace Managers.GunsManger.Factory
{
    public interface IGunsFactory
    {
        IItemView CreateRandomItem(Transform container);
    }
}