using UnityEngine;

namespace Uit.Ai.Components
{
    public sealed class 
        Move
    {
        public Vector2 MoveTo(Vector2 from, Vector2 to, float speed)
        {
            var step = speed * Time.deltaTime;
            return Vector2.MoveTowards(from, to, step);
        }
    }
}