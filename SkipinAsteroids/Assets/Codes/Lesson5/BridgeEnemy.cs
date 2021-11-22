namespace SkipinAsteroids.Bridge
{
    internal sealed class BridgeEnemy//класс мост
    {
        private readonly IAttack _attack;
        private readonly IMove _move;

        public BridgeEnemy(IAttack attack, IMove move)
        {
            _attack = attack;
            _move = move;
        }

        public void Attack()
        {
            _attack.Attack();
        }

        public void Move()
        {
            _move.Move();
        }
    }
}

