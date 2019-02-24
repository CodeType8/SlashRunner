using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private float _startPostionX = 12.8f;
    [SerializeField]
    private float _endPositionX = -9.9f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Manager.Instance.isplay)
        {
            Vector3 position = transform.position;

            position.x -= Manager.Instance.getSpeed;

            if (position.x < _endPositionX)
            {
                position.x = _startPostionX;
            }

            transform.position = position;
        }
    }
}
