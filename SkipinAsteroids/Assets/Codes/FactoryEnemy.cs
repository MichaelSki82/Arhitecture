using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using System;


namespace SkipinAsteroids
{
    public class FactoryEnemy : IAsteroidFactory
    
    {
        private GameResourses _gameResourses;

        public FactoryEnemy (GameResourses gameResourses)
        {
            _gameResourses = gameResourses;
        }

        public EnemyView CreateEnemy(Enemys enemy)
        {
            switch (enemy)
            {
                case Enemys.AsteroidBig:
                    return new AsteroidBig (_gameResourses.AsteriodPrefabBig).Create();
                case Enemys.AsteroidBoss:
                    return new AsteroidBoss(_gameResourses.AsteriodPrefabBoss).Create();
                case Enemys.AsteroidMed:
                    return new AsteroidMed(_gameResourses.AsteriodPrefabMed).Create();
                case Enemys.AsteroidSmall:
                    return new AsteroidSmall(_gameResourses.AsteriodPrefabSmall).Create();
            }
            return null;
        }
    }

}


    
