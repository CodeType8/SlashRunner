using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IGameObject
{
    [SerializeField]
    private Rigidbody2D _rigiBody = null;
    [SerializeField]
    private float _jumpvalue = 1.0f;
    [SerializeField]
    private float _movevalue = 1.0f;

    int count = 0;

    private void Start()
    {
        _rigiBody.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    public void GameUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigiBody.AddForce(new Vector2(0, _jumpvalue));
            count ++;
        }
    }

    public void FreezePositionY(bool value)
    {
        if (value)
        {
            _rigiBody.constraints = value ? RigidbodyConstraints2D.FreezePositionY : RigidbodyConstraints2D.None;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        switch (collision.gameObject.tag)
        {
            case "Enemies":
                Manager.Instance.isplay = false;
                break;
        }
    }
}
