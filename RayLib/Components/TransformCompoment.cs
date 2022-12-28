using ComponentBasedGame.Entities;
using System.Numerics;

namespace ComponentBasedGame.Components
{
    internal class TransformCompoment : IComponent
    {
        public Vector2 Position { get; set; }
        public Entity? Entity { get; set; }

        public float Speed { get; set; }

        public void Update(float elapsedGameTime)
        {

        }
    }
}
