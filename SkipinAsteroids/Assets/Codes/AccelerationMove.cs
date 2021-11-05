using UnityEngine;

namespace SkipinAsteroids
{
    internal  class AccelerationMove : MoveMovement
    {
        private readonly float _acceleration;

        public AccelerationMove(Rigidbody playerRigidbody, float speed, float acceleration) : base(playerRigidbody, speed)
        {
            _acceleration = acceleration;
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
