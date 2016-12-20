using System;
using Entitas;

class MovableSystem : IExecuteSystem, ISetPool
{
    Pool _pool;

    public void Execute()
    {
    }

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }
}

