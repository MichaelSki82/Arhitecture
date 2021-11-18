
using UnityEngine;


namespace SkipinAsteroids
{
    public   class Shooting : IShoot
    {
        private BulletPool _bulletPool;
        //private Transform _barrel;
        private float _force = 10f;
        //private Rigidbody2D _bullet;

        //public Shooting(Transform barrel, Rigidbody2D bullet, float force)
        //{
        //    _barrel = barrel;
        //     _force = force;
        
        //    _bullet = bullet;
        
        public Shooting()
        {
            //_bulletPool = new BulletPool(100);
            _bulletPool = ServiceLocator.ServiceLocator.Resolve<BulletPool>();
        }
        

        public void Shoot(Transform bulletStartPosition)
            
        {
            
               
                //var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
                //temAmmunition.AddForce(_barrel.up * _force);
            var _bullet = _bulletPool.GetItem("Bullet");
            Physics2D.IgnoreCollision(bulletStartPosition.parent.GetComponent<Collider2D>(), _bullet.GetComponent<Collider2D>());
                _bullet.transform.position = bulletStartPosition.position;
            _bullet.transform.rotation = bulletStartPosition.rotation;
            _bullet.gameObject.SetActive(true);
            _bullet.Rigidbody2D.AddForce(bulletStartPosition.transform.up.normalized *_force, ForceMode2D.Impulse);

        }
    }

}

