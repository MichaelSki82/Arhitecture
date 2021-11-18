using System;
using System.Threading;
using UnityEngine;

namespace SkipinAsteroids.Singleton
{
    public sealed class Services
    {
        private static readonly Lazy<Services> _instance =
            new Lazy<Services>(() => new Services(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static Services Instance => _instance.Value;

        private Services()
        {
        }

        public void Test()
        {
            Debug.Log(nameof(Services));
        }
    }
}

