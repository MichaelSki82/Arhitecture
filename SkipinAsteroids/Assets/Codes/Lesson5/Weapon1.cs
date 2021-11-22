using UnityEngine;

namespace SkipinAsteroids.Proxy.ProxyProtection
{
    public sealed class Weapon : IWeapon
    {
        public void Fire()
        {
            Debug.Log("Fire");
        }
    }
}

