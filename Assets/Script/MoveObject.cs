using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour, IGameObject
{
    [SerializeField]
    private float _startPostionX = 12.8f;
    [SerializeField]
    private float _endPositionX = -9.9f;

    void Start()
    {
        
    }

    virtual public void GameUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 position = transform.position;

        position.x -= Manager.Instance.getSpeed;

        if (position.x < _endPositionX)
        {
            FinishEndPosition();
            //position.x = _startPostionX;
        }

        transform.position = position;
    }

    virtual protected void FinishEndPosition()
    {
        transform.position = new Vector3(_startPostionX, transform.position.y, 0);
        //position.x = _startPostionX;
    }
}
