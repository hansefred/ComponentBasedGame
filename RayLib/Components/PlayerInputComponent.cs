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
                    transform.Direction = new Vector2 (transform.Direction.X +1, transform.Direction.Y);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    transform.Direction = new Vector2(transform.Direction.X - 1 , transform.Direction.Y);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    transform.Direction = new Vector2(transform.Direction.X , transform.Direction.Y -1);
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    transform.Direction = new Vector2(transform.Direction.X , transform.Direction.Y + 1);
                }
                    
            

            }
        }
    }
}
