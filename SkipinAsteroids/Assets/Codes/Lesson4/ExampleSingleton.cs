using UnityEngine;

namespace SkipinAsteroids.Singleton
{
    internal sealed class ExampleSingleton : MonoBehaviour
    {
        private void Start()
        {
            Services.Instance.Test();
        }
    }
}