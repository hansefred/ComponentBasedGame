using ComponentBasedGame.Entities;
using Raylib_cs;
using System.Numerics;

namespace ComponentBasedGame.Components
{
    internal class PlayerInputComponent : IComponent
    {
        public Entity? Entity { get; set; }

        public void Update(float elapsedGameTime)
        {
            var transform = Entity!.GetComponent<TransformCompoment>();

            if (transform is not null)
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    transform.Position = new Vector2 (transform.Position.X + elapsedGameTime * transform.Speed, transform.Position.Y);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    transform.Position = new Vector2(transform.Position.X - elapsedGameTime * transform.Speed, transform.Position.Y);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    transform.Position = new Vector2(transform.Position.X, transform.Position.Y - elapsedGameTime * transform.Speed);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    transform.Position = new Vector2(transform.Position.X, transform.Position.Y + elapsedGameTime * transform.Speed);
                }

            }
        }
    }
}
