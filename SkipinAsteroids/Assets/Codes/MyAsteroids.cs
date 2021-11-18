using SkipinAsteroids.Object_Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinAsteroids
{
    public  class MyAsteroids : MonoBehaviour, ITakeDamage
    {
        private float _damage = 5.0f;
        private Transform _rotPool;
        private Health _health;
        public Health Health
        {
            get
            {
                if (_health.Current <= 0f)
                {
                    ReturnToPool();

                }
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        private Transform RotPool
        {
            get
            {
                if(_rotPool == null)
                {
                    var find = GameObject.Find(NameManager.Pool_AMMUNITION);
                    _rotPool = find == null ? null : find.transform;
                }
                return _rotPool;
            }
        }

        public MyAsteroids (Health health)
        {
            _health = health;
        }

        private void Update()
        {
            if (!(transform.position.y < -15.0f)) return;
            ReturnToPool();
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent<DestroybleObject>(out _)) other.gameObject.GetComponent<ITakeDamage>().TakeDamage(_damage);
            ReturnToPool();
        }
        public void DependencyInjectHealth(Health hp) => Health = hp;
        private void ReturnToPool()
        {
            gameObject.SetActive(false);
            transform.SetParent(RotPool);
            if (!RotPool)
            {
                Destroy(gameObject);
            }
        }

        public void TakeDamage(float damage) => _health.ChangeCurrentHealth(damage);
    }
}

  

