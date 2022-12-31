using Raylib_cs;
using ComponentBasedGame.Components;

namespace ComponentBasedGame.Systems
{
    internal class BaseSystem<T> where T : IComponent
    {
        protected List<T> _components = new List<T>();

        public void Register(T component)
        {
            _components.Add(component);
        }

        public void Update(float elapsedGameTime)
        {
            foreach (T component in _components)
            {
                component.Update(elapsedGameTime);
            }
        }

    }

    internal class TransformSystem : BaseSystem<TransformCompoment>
    {

    }

    internal class DrawableRectangleSystem : BaseSystem<DrawableRectangleComponent>
    {

    }

    internal class DrawableTextureSystem : BaseSystem<DrawableTextureComponent> 
    {

    }

    internal class InputSystem : BaseSystem<PlayerInputComponent>
    {

    }




}
