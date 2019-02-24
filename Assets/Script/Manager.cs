using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{
    //private static Manager _instance = null;
    //public static Manager Instance {get{return _instance;}}

    [SerializeField]
    private Character _character = null;
    [SerializeField]
    private Ground _ground = null;
    [SerializeField]
    private Enemy _enemy = null;
    [SerializeField]
    private Enemy2 _enemy2 = null;
    [SerializeField]
    private Background _background = null;

    private List<Enemy> _EnemyList = new List<Enemy>();
    private List<Enemy2> _Enemy2List = new List<Enemy2>();

    [SerializeField]
    private float _speed = 0.1f;
    private float _createtime1 = 1.0f;
    private float _curtime1 = 0.0f;
    private float _createtime2 = 2.3f;
    private float _curtime2 = 0.0f;

    private bool _bplay = false;
    private int _score = 0;
    
    public bool isplay {get{return _bplay;}set{_bplay = value;}}
    public float getSpeed {get{return _speed;}}

    /*
    void Awake()
    {
        _instance = this;
    }
    */

    private void Start()
    {
        //_bplay = true;
    }

    // Update is called once per frame
    void Update()
    {
        _character.FreezePositionY(!_bplay);

        if (_bplay)
        {
            _curtime1 += Time.deltaTime;
            if (_createtime1 < _curtime1)
            {
                _curtime1 = 0;
                _EnemyList.Add(GameObject.Instantiate(_enemy));
            }

            _curtime2 += Time.deltaTime;
            if (_createtime2 < _curtime2)
            {
                _curtime2 = 0;
                _Enemy2List.Add(GameObject.Instantiate(_enemy2));
            }

            _character.GameUpdate();
            _ground.GameUpdate();
            //_enemy.GameUpdate();
            //_enemy2.GameUpdate();
            _EnemyList.ForEach((x) =>
            {
                x.GameUpdate();

                if (x.isAddscoreCheck(_enemy.transform.position))
                {
                    addscore();
                }
            } );
            _Enemy2List.ForEach(x => x.GameUpdate());
        }        
    }
    public void Remove(Enemy target)
    {
        _EnemyList.Remove(target);
        Destroy(target.gameObject);
    }

    public void Remove2(Enemy2 target)
    {
        _Enemy2List.Remove(target);
        Destroy(target.gameObject);
    }

    private void addscore()
    {
        _score++;

        Debug.Log(_score);
    }
}
