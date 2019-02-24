using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MoveObject
{
    private bool _check = false;
   
    public override void GameUpdate()
    {
        base.GameUpdate();
    }

    protected override void FinishEndPosition()
    {
        Manager.Instance.Remove(this);
        //Destroy(gameObject);
        //base.FinishEndPosition();
    }
    
    public bool isAddscoreCheck(Vector3 target)
    {
        if (!_check)
        {
            if(transform.position.x <= target.x)
            {
                _check = true;
                return true;
            }
        }

        return false;
    }
}
