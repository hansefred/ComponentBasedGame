using Raylib_cs;
using ComponentBasedGame.Entities;


namespace ComponentBasedGame.Components
{
    internal class DrawableComponent : IComponent
    {

        Rectangle _rectangle;
        Color _color;

        public DrawableComponent(Rectangle rectangle, Color color)
        {
            _rectangle = rectangle;
            _color = color;
        }

        public Entity? Entity { get; set; }

        public void Update(float elapsedGameTime)
        {
            var transform = Entity!.GetComponent<TransformCompoment>();

            if (transform is not null)
            {
                Raylib.DrawRectangle((int)transform.Position.X, (int)transform.Position.Y, (int)_rectangle.width, (int)_rectangle.height, _color);
            }
            else
            {
                Raylib.DrawRectangleRec(_rectangle, _color);
            }
        }
    }
}
