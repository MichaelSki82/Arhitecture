
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Object = UnityEngine.Object;
using SkipinAsteroids.Object_Pool;


namespace SkipinAsteroids
    
{
    public class MyAsteroidsSpawner
    {
        private readonly MyAsteroidPool _asteroidPool;


        public MyAsteroidsSpawner(int maxAsteroidCount, Health hp)
        {
            _asteroidPool = new MyAsteroidPool(maxAsteroidCount, hp);
        }
        public void SpawnAsteroid(int maxAsteroidCount)
        {
            for (int i = 0; i < maxAsteroidCount; i++)
            {
                var asteroid = _asteroidPool.GetEnemy("Asteroid");
                asteroid.transform.position = new Vector2(Random.Range(-8.0f, 8.0f), Random.Range(5.0f, 15.0f));
                asteroid.gameObject.SetActive(true);
            }
        }
    }
}