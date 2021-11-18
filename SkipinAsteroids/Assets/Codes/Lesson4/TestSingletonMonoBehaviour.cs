using UnityEngine;

namespace SkipinAsteroids.Singleton
{
    internal sealed class TestSingletonMonoBehaviour : SingletonMonoBehaviour<TestSingletonMonoBehaviour>
    {
        public void Test()
        {
            Debug.Log(nameof(TestSingletonMonoBehaviour));
        }
    }
}

