using UnityEngine;

namespace SkipinAsteroids
{
    internal class MoveMovement : IMove
    {
        
        private readonly Rigidbody _playerRigidbody;
        private Vector2 _move;

        public float Speed { get; protected set; }


        public MoveMovement(Rigidbody playerRigidbody, float speed)
        {
           
            _playerRigidbody = playerRigidbody;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical)
        {

            _move.Set(horizontal, vertical);
           _playerRigidbody.AddForce(_move * Speed, (ForceMode)ForceMode2D.Impulse);
            
        }
    }
}


