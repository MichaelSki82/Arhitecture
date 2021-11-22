using UnityEngine;

namespace SkipinAsteroids.Bridge
{
    internal sealed class ExampleBridge : MonoBehaviour
    {
        private void Start()
        {
            var enemy = new BridgeEnemy(new MagicalAttack(), new Infantry());
        }
    }
}

