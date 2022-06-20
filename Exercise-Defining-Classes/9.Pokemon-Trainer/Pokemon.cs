
namespace DefiningClasses
{
    public class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        private string _name;
        private string _element;
        private int _health;

        public string Name { get { return _name; } set { _name = value; } }
        public string Element { get { return _element; } set { _element = value; } }
        public int Health { get { return _health; }  set { _health = value;  } }

    }
}