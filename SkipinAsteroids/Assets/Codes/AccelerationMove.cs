using UnityEngine;

namespace SkipinAsteroids
{
    internal  class AccelerationMove : MoveMovement
    {
        private readonly float _acceleration;
        private readonly float _speed;

        public AccelerationMove(Rigidbody2D playerRigidbody, float speed, float acceleration) : base(playerRigidbody, speed)
        {
            _acceleration = acceleration;
            _speed = speed;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}
