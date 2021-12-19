using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class BulletController : MoveController
{
    public int time;
    public int dame;
    void Update()
    {
        Move(transform.up);
        BulletEx();
    }
    void BulletEx()
    {
        time += 1;
        if (time == 20)
        {
            PoolingObject.DestroyPooling<BulletController>(this);
            return;
        }
    }
}
