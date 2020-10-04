using UnityEngine;

namespace Uit.Ai.Components
{
    public sealed class Rotation
    {
        public Quaternion RotateTo(Vector2 target, Vector2 position)
        {
            Vector2 diff = target - position;
            diff.Normalize();

            var rotation = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            return Quaternion.Euler(0f, 0f, rotation - 90);
        }

        public Quaternion RotateFrom(Vector2 target, Vector2 position)
        {
            Vector2 diff = target - position;
            diff.Normalize();

            var rotation = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            return Quaternion.Euler(0f, 0f, rotation - 90);
        }
    }
}