using Managers.FortManger.Item;
using UnityEngine;

namespace Managers.FortManger.Factory
{
    public interface IFortFactory
    {
        IFortView CreateFort(Transform container);
    }
}