using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SkipinAsteroids
{
    public class EnemyView : MonoBehaviour
    {
        public event Action OnDeath;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Bullet"))
            {
                OnDeath?.Invoke();
                Destroy(gameObject);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            //сделать точку респвна
        }
    }

}

