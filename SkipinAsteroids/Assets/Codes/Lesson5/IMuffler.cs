using UnityEngine;

namespace SkipinAsteroids.Decorator
{
    internal interface IMuffler
    {
        AudioClip AudioClipMuffler { get; }
        float VolumeFireOnMuffler { get; }
        Transform BarrelPositionMuffler { get; }
        GameObject MufflerInstance { get; }
    }
}

