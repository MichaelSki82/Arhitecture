using UnityEngine;



namespace SkipinAsteroids
{
    internal sealed class Player : MonoBehaviour
    {
        
        //[SerializeField] private Rigidbody2D _bullet;
        //[SerializeField] private Transform _barrel;
        private IShootingController _shootingController;
        
        private Transform _bulletStartPosition;
        [SerializeField] private float _force;

        private ShipModel _shipModel;
        private ShipView _shipView;
        private Rigidbody2D _rbPlayer;
        private Vector2 _movementVector2;
        private Rigidbody _playerRigidbody;
        private float _health;

        
        private Camera _camera;
        
        
        
        AccelerationMove accelMove;
        RotationShip rotship;

        private void Start()
        {
            _shipModel = new ShipModel(1f, 100f, 10f);
            _shipView = FindObjectOfType<ShipView>();
            _camera = Camera.main;
            _health = _shipModel.Health;
           
            accelMove = new AccelerationMove(_playerRigidbody, _shipModel.Speed, _shipModel.Acceleration);
            rotship = new RotationShip( transform);

            _bulletStartPosition = FindObjectOfType<BulletPoint>().transform;
            _shootingController = new ShootingController();
            
           
            _rbPlayer = _shipView.GetComponent<Rigidbody2D>();

                 
                 


        }

        private void Update()
        {

            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            rotship.Rotation(direction);
            
            

            

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                accelMove.AddAcceleration();            
                                
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                accelMove.RemoveAcceleration();
                
            }

            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log("${FindObjectOfType<BulletPoint>()transform.position");
                _shootingController.Shooting.Shoot(FindObjectOfType<BulletPoint>().transform);
            }
        }

        private void FixedUpdate()
        {
            _movementVector2.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            _rbPlayer.AddForce(_movementVector2 * _shipModel.Speed, ForceMode2D.Impulse);
        }




        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _health--;
            }
        }
    }
}

