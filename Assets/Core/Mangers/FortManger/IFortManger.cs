using UnityEngine;

namespace Managers.FortManger
{
    public interface IFortManger
    {
        void CreateFort();
        Vector2 GetFortPosition();
    }
}