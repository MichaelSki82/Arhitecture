using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEngine.Random;

namespace SkipinAsteroids
{
    public class EnemyController : MonoBehaviour//IController
    {
        private ModelEnemy _modelEnemy;
        private FactoryEnemy _factoryEnemy;

        private List<EnemyView> _enemys = new List<EnemyView>();

        private int _count = 7;
        
        public EnemyController(ModelEnemy modelEnemy, FactoryEnemy factoryEnemy)
        {
            _modelEnemy = modelEnemy;
            _factoryEnemy = factoryEnemy;
            SpawnEnemys(_count);
        }

        private void Start()
        {
            SpawnEnemys(7);
        }

        public void SpawnEnemys(int value)
        {
            for (int i = 0; i < value; i++)
            {

                var randomVect = new Vector3(Range(-1f, 1f), Range(-1f, 1f), 0);
                var numOfEnemy = Enum.GetNames(typeof(Enemys)).Length - 1;
                var t = (Enemys)Range(0, numOfEnemy);
                var enemy = _factoryEnemy.CreateEnemy(t);
                enemy.GetComponent<Rigidbody>().AddForce(randomVect.normalized * Range(_modelEnemy.MinSpeed, _modelEnemy.MaxSpeed), ForceMode.Impulse);
                _enemys.Add(enemy);

            }
        }
    }

}
