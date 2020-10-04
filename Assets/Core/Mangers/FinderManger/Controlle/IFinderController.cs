using Managers.FinderManger.Obj.Config;
using UnityEngine;

namespace Managers.FinderManger.View
{
    public interface IFinderController
    {
        IConfiguration Configuration { get; }

        bool HasItem();
        Vector2 GetPosition();
        void SetRotation(Quaternion quaternion);
        void SetPosition(Vector2 position);
        void MoveForward(float speed);
    }
}