using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinAsteroids
{
    public class AsteroidBig 
    {
        private GameObject _gameObject;

        public AsteroidBig(GameObject prefab)
        {
            _gameObject = prefab;
        }

        public EnemyView Create()
        {
            return Object.Instantiate(_gameObject, Vector3.right, Quaternion.identity).GetComponent<EnemyView>();
        }
    }

}

