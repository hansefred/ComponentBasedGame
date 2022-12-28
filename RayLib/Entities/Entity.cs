using ComponentBasedGame.Components;

namespace ComponentBasedGame.Entities
{
    internal class Entity
    {
        private List<IComponent> _components = new List<IComponent>();

        public Guid ID { get; set; } = Guid.NewGuid();

        public List<IComponent> Components { get => _components; set => _components = value; }


        public EntityManager? EntityManager { get; set; }


        public void AddComponent(IComponent component)
        {
            component.Entity = this;
            _components.Add(component);
        }

        public T? GetComponent<T>() where T : IComponent
        {
            var comp = _components.FirstOrDefault(o => o.GetType() == typeof(T));

            if (comp is null)
            {
                return default(T);
            }
            return (T)comp;
        }
    }
}
