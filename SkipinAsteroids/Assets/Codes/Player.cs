using UnityEngine;



namespace SkipinAsteroids
{
    internal sealed class Player : MonoBehaviour
    {
        private Transform _bulletStartPosition;
       
        private ShipModel _shipModel;
        private ShipView _shipView;
        private Rigidbody2D _rbPlayer;
        private Vector2 _movementVector2;
        private Rigidbody _playerRigidbody;
        private float _health;
        Shooting shoot;
        
        private Camera _camera;
        MoveMovement moveMove;
        AccelerationMove accelMove;
        RotationShip rotship;

        //EnemyController _enemyController;
        //private EnemyView _enemyView;
        //private ModelEnemy _modelEnemy;
        //private FactoryEnemy _factoryEnemy;
        //private GameResourses _gameResourses;
        // private int countAsteriods = 10;

        private void Start()
        {
            _shipModel = new ShipModel(1f, 100f, 10f);
            _shipView = FindObjectOfType<ShipView>();
            _camera = Camera.main;
            _health = _shipModel.Health;
           _rbPlayer = _shipView.GetComponent<Rigidbody2D>();
            accelMove = new AccelerationMove(_rbPlayer, _shipModel.Speed, _shipModel.Acceleration);
            rotship = new RotationShip( _shipView.transform);
            shoot = new Shooting();
            _bulletStartPosition = FindObjectOfType<BulletPoint>().transform;
            moveMove = new MoveMovement(_rbPlayer, _shipModel.Speed);
            //_modelEnemy = new ModelEnemy(1f, 5f);
            //_gameResourses = new GameResourses();
            //_factoryEnemy = new FactoryEnemy(_gameResourses);
            //_enemyController = new EnemyController(_modelEnemy, _factoryEnemy);
            
           
            

                 
                 


        }

        private void Update()
        {

            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            rotship.Rotation(direction);

            //_enemyController.SpawnEnemys(_countAsteriods);

            

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
                
                shoot.Shoot((FindObjectOfType<BulletPoint>().transform));
            }
        }

        private void FixedUpdate()
        {
            //_movementVector2.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
           // _rbPlayer.AddForce(_movementVector2 * _shipModel.Speed, ForceMode2D.Impulse);
            moveMove.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

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

