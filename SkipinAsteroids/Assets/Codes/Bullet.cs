using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkipinAsteroids.Object_Pool;


namespace SkipinAsteroids
{

    public class Bullet : MonoBehaviour
    {
       
        [SerializeField] private float _damage;
        
        public Rigidbody2D Rigidbody2D;

        private Transform _bulletPool;




        private Transform BulletPool
        {

            get
            {
                if (_bulletPool == null)
                {
                    var find = GameObject.Find(NameManager.BULLET_Pool);
                    _bulletPool = find == null ? null : find.transform;
                }
                return _bulletPool;
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent<DestroybleObject>(out var destroybleObject))
            {
                other.gameObject.GetComponent<ITakeDamage>().TakeDamage(_damage);
                ReturnToPool();
            }
            ReturnToPool();
        }
        protected void ReturnToPool()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.SetActive(false);
            transform.SetParent(BulletPool);
            if (!BulletPool)
            {
                Destroy(gameObject);
            }

        }
    }
}
