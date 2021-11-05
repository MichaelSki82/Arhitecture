

namespace SkipinAsteroids
{
    public interface IEnemyFactory
    {
        Enemy Create(Health hp);
        
    }
}