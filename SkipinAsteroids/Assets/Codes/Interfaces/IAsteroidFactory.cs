using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinAsteroids
{
    public interface IAsteroidFactory 
    {
        EnemyView CreateEnemy(Enemys exampleOfEnemy);
    }

}
