using SkipinAsteroids.Object_Pool;
using UnityEngine;

namespace SkipinAsteroids
{

    internal sealed class GameStarter: MonoBehaviour
    {
       

        private void Start()
        {
            //Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));

            //IEnemyFactory factory = new AsteroidFactory();

            //factory.Create(new Health(100.0f, 100.0f));

            //Enemy.Factory = factory;

            //Enemy.Factory.Create(new Health(100.0f, 100.0f));
            

            EnemyPool enemyPool = new EnemyPool(10);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }

       
    }
    
}
