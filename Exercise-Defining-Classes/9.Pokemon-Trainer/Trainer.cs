using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
	public class Trainer
	{
        public Trainer(string name)
        {
            this.Name = name;
            this._pokemons = new List<Pokemon>();
            this._badges = 0;
        }

		private string _name;
		private int _badges;
		private List<Pokemon> _pokemons;

        public string Name { get { return _name; } set { _name = value; } }
        public int Badges { get { return _badges; } }

        public void AddPokemon(Pokemon pokemon)
        {
			this._pokemons.Add(pokemon);
        }
        public void Addbadge()
        {
            this._badges++;
        }
        public bool CheckElement(string element)
        {
            //If there is at least one pokemon with this element it will return true otherwise it will return false
            if (this._pokemons.Any(p => p.Element == element))
                return true;
            return false;
        }
        public void TakeHealth()
        {
            for (int i = 0; i < this._pokemons.Count; i++)
            {
                _pokemons[i].Health -= 10;
                if (_pokemons[i].Health <= 0)
                    _pokemons.RemoveAt(i);
            }
        }
        public override string ToString()
        {
            //output format;
            //"{trainerName} {badges} {numberOfPokemon}"
            return $"{this._name} {this._badges} {this._pokemons.Count}";
        }

    }
}

