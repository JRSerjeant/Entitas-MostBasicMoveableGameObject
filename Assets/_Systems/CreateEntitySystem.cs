using System;
using Entitas;

class CreateEntitySystem : IInitializeSystem, ISetPool
{

    Pool _pool;

    public void Initialize()
    {
        _pool.CreateEntity().AddPrefabName("MyTestCube").IsMoveable(true);
        _pool.CreateEntity().AddPrefabName("MyTestCube");
    }

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }
}

