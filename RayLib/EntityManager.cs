using ComponentBasedGame.Components;
using ComponentBasedGame.Entities;
using ComponentBasedGame.Systems;
using System.Reflection;

namespace ComponentBasedGame
{
    internal class EntityManager
    {
        public List<Entity> Entities { get; set; } = new List<Entity>();




        private DrawableSystem _drawableComponentSystem = new ();
        private TransformSystem _transformComponentSystem = new();
        private InputSystem _inputSystem = new();

        public EntityManager()
        {
         
        }


        public void BeforeDraw (float elapsedTime)
        {
            _transformComponentSystem.Update(elapsedTime);
            _inputSystem.Update(elapsedTime);
        }

        public void Draw (float elapsedTime) 
        {
            _drawableComponentSystem.Update(elapsedTime);
        }
        public void AfterDraw (float elapsedTime) 
        {
        }

        public void Register (Entity entity)
        {
            entity.EntityManager = this;

            foreach (var component in entity.Components)
            {
                if (component.GetType() == typeof(DrawableComponent))
                {
                    _drawableComponentSystem.Register((DrawableComponent)component);
                }
                if (component.GetType() == typeof(TransformCompoment))
                {
                    _transformComponentSystem.Register((TransformCompoment)component);
                }
                if (component.GetType() == typeof(PlayerInputComponent))
                {
                    _inputSystem.Register((PlayerInputComponent)component);
                }
            }
            Entities.Add (entity);
        }
    }
}
