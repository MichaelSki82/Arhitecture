using UnityEngine;

namespace SkipinAsteroids.Decorator
{
    internal interface IAmmunition
    {
        Rigidbody BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}

