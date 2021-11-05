using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SkipinAsteroids

{ 
    public class ModelEnemy 
    {
        public float MinSpeed { get; }
        public float MaxSpeed { get; }

        public ModelEnemy(float minSpeed, float maxSpeed)
        {
            MaxSpeed = maxSpeed;
            MinSpeed = minSpeed;
        }
    }
}
