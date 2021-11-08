using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SkipinAsteroids
{
    public class Borders : MonoBehaviour
    {
        [SerializeField] private float _leftBorder;
        [SerializeField] private float _rightBorder;
        [SerializeField] private float _upBorder;
        [SerializeField] private float _downBorder;

        Vector3 pos;

        void Start()
        {
            float dist = Vector3.Distance(pos, Camera.main.transform.position);
            _leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
            _rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
            _upBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
            _downBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;

        }


        void Update()
        {
            Vector3 pos = transform.position;
            transform.position = new Vector3(Mathf.Clamp(pos.x, _leftBorder, _rightBorder), Mathf.Clamp(pos.y, _upBorder, _downBorder), pos.z);
        }
    }

}

