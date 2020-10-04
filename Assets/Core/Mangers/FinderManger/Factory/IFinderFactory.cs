using Managers.FinderManger.View;
using UnityEngine;

namespace Managers.FinderManger.Factory
{
    public interface IFinderFactory
    {
        IFinderController Create(Transform container);
    }
}