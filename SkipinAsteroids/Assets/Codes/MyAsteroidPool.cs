using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Object = UnityEngine.Object;
using SkipinAsteroids.Object_Pool;

namespace SkipinAsteroids
{
    internal sealed class MyAsteroidPool
    {
        private readonly Dictionary<string, HashSet<MyAsteroids>> _enemyPool;
        private readonly int _capacityPool;
        private Transform _rootPool;
        private readonly Health _hp;

        public MyAsteroidPool(int capacityPool, Health health)
        {
            _enemyPool = new Dictionary<string, HashSet<MyAsteroids>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                _rootPool = new GameObject(NameManager.Pool_AMMUNITION).transform;

            }
        }
        public MyAsteroids GetEnemy(string type)
        {
            MyAsteroids result;
            switch (type)
            {
                case "Asteroid":
                    result = GetAsteroid(GetListEnemies(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "не предусмотрен в программе");

            }
            return result;
        }
        private HashSet<MyAsteroids> GetListEnemies(string type)
        {
            return _enemyPool.ContainsKey(type) ? _enemyPool[type] : _enemyPool[type] = new HashSet<MyAsteroids>();

        }
        private MyAsteroids GetAsteroid(HashSet<MyAsteroids> enemies)
        {
            var enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (enemy == null)
            {
                var laser = Resources.Load<MyAsteroids>("Enemy/AsteroidBig");
                for (var i = 0; i < _capacityPool; i++)
                {
                    var instantiate = Object.Instantiate(laser);
                    ReturnToPool(instantiate.transform);
                    enemies.Add(instantiate);

                }
                GetAsteroid(enemies);
            }
            enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            return enemy;
        }
        private void ReturnToPool(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.gameObject.SetActive(false);
            transform.SetParent(_rootPool);

        }
        public void RemovePool()
        {
            Object.Destroy(_rootPool.gameObject);
        }
    }
}


