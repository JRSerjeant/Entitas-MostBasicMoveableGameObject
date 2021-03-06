//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public GameObjectComponent gameObject { get { return (GameObjectComponent)GetComponent(CoreComponentIds.GameObject); } }
        public bool hasGameObject { get { return HasComponent(CoreComponentIds.GameObject); } }

        public Entity AddGameObject(UnityEngine.GameObject newGameObject) {
            var component = CreateComponent<GameObjectComponent>(CoreComponentIds.GameObject);
            component.gameObject = newGameObject;
            return AddComponent(CoreComponentIds.GameObject, component);
        }

        public Entity ReplaceGameObject(UnityEngine.GameObject newGameObject) {
            var component = CreateComponent<GameObjectComponent>(CoreComponentIds.GameObject);
            component.gameObject = newGameObject;
            ReplaceComponent(CoreComponentIds.GameObject, component);
            return this;
        }

        public Entity RemoveGameObject() {
            return RemoveComponent(CoreComponentIds.GameObject);
        }
    }
}

    public partial class CoreMatcher {

        static IMatcher _matcherGameObject;

        public static IMatcher GameObject {
            get {
                if(_matcherGameObject == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.GameObject);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherGameObject = matcher;
                }

                return _matcherGameObject;
            }
        }
    }
