
using UnityEngine;


namespace SkipinAsteroids
{
    internal sealed  class Shooting 
    {
        
        private Transform _barrel;
        private float _force;
        private Rigidbody2D _bullet;

        public Shooting(Transform barrel, Rigidbody2D bullet, float force)
        {
            _barrel = barrel;
            _force = force;
            _bullet = bullet;
        }


        public void Shoot()
        {
            
                var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);
            
        }
    }

}

