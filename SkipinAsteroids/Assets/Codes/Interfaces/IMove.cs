using UnityEngine;

namespace SkipinAsteroids
{
    public interface IMove
    {
        float Speed { get; }
        void Move(float horizontal, float vertical);
    }
}

