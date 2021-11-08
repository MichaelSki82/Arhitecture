using UnityEngine;

namespace SkipinAsteroids
{
    internal class MoveMovement : IMove
    {
        
        private readonly Rigidbody2D _playerRigidbody;
        private Vector2 _move;

        public float Speed { get; protected set; }


        public MoveMovement(Rigidbody2D playerRigidbody, float speed)
        {
           
            _playerRigidbody = playerRigidbody;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical)
        {

            _move.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));// (horizontal, vertical);
           _playerRigidbody.AddForce(_move * Speed, ForceMode2D.Impulse);
            
        }
    }
}


