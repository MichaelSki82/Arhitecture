using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinAsteroids
{

    public interface IBulletFactory
    {
        Bullet Create(Vector3 bulletStartPosition);
    }
}
