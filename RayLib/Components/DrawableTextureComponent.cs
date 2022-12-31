using ComponentBasedGame.Entities;
using Raylib_cs;


namespace ComponentBasedGame.Components
{
    internal class DrawableTextureComponent : IComponent
    {
        public Texture2D Texture2D { get; set; }
        public Entity? Entity { get; set; }

        public Color T_Int { get; set; }

        public void Update(float elapsedGameTime)
        {
            var transform = Entity!.GetComponent<TransformCompoment>();


            if (transform is not null)
            {
                Raylib.DrawTexture(Texture2D,(int)transform.Position.X, (int)transform.Position.Y, T_Int);
            }
            else
            {
                Raylib.DrawTexture(Texture2D, 0, 0, T_Int);
            }
        }
    }
}
