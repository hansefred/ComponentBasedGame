using ComponentBasedGame.Components;
using ComponentBasedGame.Entities;
using ComponentBasedGame.Systems;
using System.Reflection;

namespace ComponentBasedGame
{
    internal class EntityManager
    {
        public List<Entity> Entities { get; set; } = new List<Entity>();




        private DrawableRectangleSystem _drawableComponentSystem = new ();
        private TransformSystem _transformComponentSystem = new();
        private InputSystem _inputSystem = new();
        private DrawableTextureSystem _drawableTextureSystem= new ();

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
            _drawableTextureSystem.Update(elapsedTime);
        }
        public void AfterDraw (float elapsedTime) 
        {
        }

        public void Register (Entity entity)
        {
            entity.EntityManager = this;

            foreach (var component in entity.Components)
            {

                if (component.GetType() == typeof(DrawableRectangleComponent))
                {
                    _drawableComponentSystem.Register((DrawableRectangleComponent)component);
                }
                else if (component.GetType() == typeof(TransformCompoment))
                {
                    _transformComponentSystem.Register((TransformCompoment)component);
                }
                else if (component.GetType() == typeof(PlayerInputComponent))
                {
                    _inputSystem.Register((PlayerInputComponent)component);
                }
                else if (component.GetType() == typeof(DrawableTextureComponent))
                {
                    _drawableTextureSystem.Register((DrawableTextureComponent)component);
                }
            }
            Entities.Add (entity);
        }
    }
}
