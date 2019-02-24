using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MoveObject
{
    public override void GameUpdate()
    {
        base.GameUpdate();
    }

    protected override void FinishEndPosition()
    {
        Manager.Instance.Remove2(this);
    }
}
