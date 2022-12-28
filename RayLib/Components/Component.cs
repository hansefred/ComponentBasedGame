using ComponentBasedGame.Entities;

namespace ComponentBasedGame.Components
{
    internal class Component : IComponent
    {
        public Entity? Entity { get; set; }

        public virtual void Update(float elapsedGameTime) { }
    }
}
