using ComponentBasedGame.Entities;

namespace ComponentBasedGame.Components
{
    internal interface IComponent
    {
        Entity? Entity { get; set; }

        public void Update(float elapsedGameTime);
    }
}