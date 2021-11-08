using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SkipinAsteroids

{ 
    public class EnemyModel
    {
        public float MinSpeed { get; }
        public float MaxSpeed { get; }

        public EnemyModel(float minSpeed, float maxSpeed)
        {
            MaxSpeed = maxSpeed;
            MinSpeed = minSpeed;
        }
    }
}
