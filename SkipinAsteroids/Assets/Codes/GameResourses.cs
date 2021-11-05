using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


namespace SkipinAsteroids
{

    public class GameResourses
    {
        private GameObject _asteroidBig;
        private GameObject _asteroidBoss;
        private GameObject _asteroidMed;
        private GameObject _asteroidSmall;

        public GameObject AsteriodPrefabBig
        {
            get
            {
                if(_asteroidBig == null)
                {
                    _asteroidBig = Resources.Load<GameObject>("AsteroidBig");
                }
                return _asteroidBig;
            }
        }
        public GameObject AsteriodPrefabBoss
        {
            get
            {
                if (_asteroidBig == null)
                {
                    _asteroidBig = Resources.Load<GameObject>("AsteroidBoss");
                }
                return _asteroidBoss;
            }
        }
        public GameObject AsteriodPrefabMed
        {
            get
            {
                if (_asteroidBig == null)
                {
                    _asteroidBig = Resources.Load<GameObject>("AsteroidMed");
                }
                return _asteroidMed;
            }
        }
        public GameObject AsteriodPrefabSmall
        {
            get
            {
                if (_asteroidBig == null)
                {
                    _asteroidBig = Resources.Load<GameObject>("AsteroidSmall");
                }
                return _asteroidSmall;
            }
        }
    }
}
