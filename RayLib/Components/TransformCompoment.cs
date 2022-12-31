using ComponentBasedGame.Entities;
using System.Numerics;

namespace ComponentBasedGame.Components
{
    internal class TransformCompoment : IComponent
    {

        public Vector2 Direction { get; set; }
        public Vector2 Position { get; set; }
        public Entity? Entity { get; set; }

        public float Speed { get; set; }

        public void Update(float elapsedGameTime)
        {
            Position = new Vector2(Position.X + (Direction.X * Speed * elapsedGameTime), Position.Y + ( Direction.Y * Speed * elapsedGameTime));

            Direction = new Vector2();
        }
    }
}
