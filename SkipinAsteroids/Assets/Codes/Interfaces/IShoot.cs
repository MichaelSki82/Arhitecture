using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinAsteroids
{

    public interface IShoot
    {
        void Shoot(Transform bulletStartPosition);
    }
}
