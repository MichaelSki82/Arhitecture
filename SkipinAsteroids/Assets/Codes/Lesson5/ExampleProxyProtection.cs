using UnityEngine;

namespace SkipinAsteroids.Proxy.ProxyProtection
{
    internal sealed class ExampleProxyProtection : MonoBehaviour
    {
        private void Start()
        {
            var unlockWeapon = new UnlockWeapon(false);
            var weapon = new Weapon();
            var weaponProxy = new WeaponProxy(weapon, unlockWeapon);
            weaponProxy.Fire();
            unlockWeapon.IsUnlock = true;
            weaponProxy.Fire();
        }
    }
}

