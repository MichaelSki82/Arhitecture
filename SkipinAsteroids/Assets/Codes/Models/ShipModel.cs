using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinAsteroids
{
    public class ShipModel
    {
        public float Speed { get ; }
        public float Health { get; }

        public float Acceleration { get;  }

        public ShipModel(float speed, float health, float acceleration)
        {
            Speed = speed;
            Health = health;
            Acceleration = acceleration;
        }
    }
}
    