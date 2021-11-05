
using UnityEngine;


namespace SkipinAsteroids
{
    public   class Shooting 
    {
        private BulletPool _bulletPool;
        //private Transform _barrel;
        //private float _force;
        //private Rigidbody2D _bullet;

        //public Shooting(Transform barrel, Rigidbody2D bullet, float force)
        //{
        //    _barrel = barrel;
        //     _force = force;
        
        //    _bullet = bullet;
        
        public Shooting()
        {
            _bulletPool = new BulletPool(100);

        }
        

        public void Shoot(Transform bulletStartPosition)
            
        {
            
               
                //var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
                //temAmmunition.AddForce(_barrel.up * _force);
            var _bullet = _bulletPool.GetItem("Bullet");
            _bullet.transform.position = bulletStartPosition.position;
            _bullet.transform.rotation = bulletStartPosition.rotation;
            _bullet.gameObject.SetActive(true);
            _bullet.Rigidbody2D.AddForce(bulletStartPosition.position, ForceMode2D.Force);

        }
    }

}

