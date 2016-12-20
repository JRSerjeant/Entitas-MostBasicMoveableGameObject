using System;
using Entitas;
using UnityEngine;

class MovableSystem : IExecuteSystem, ISetPool
{
    Pool _pool;
    Group _Moveable;
    public void Execute()
    {
        foreach (var member in _Moveable.GetEntities())
        {
            member.gameObject.gameObject.transform.Translate(Vector3.left * Time.deltaTime);
        }
    }

    public void SetPool(Pool pool)
    {
        _pool = pool;
        _Moveable = pool.GetGroup(CoreMatcher.Moveable);
    }
}

