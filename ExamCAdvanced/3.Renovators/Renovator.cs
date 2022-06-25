using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
        }
        

        private string _name;
        private string _type;
        private double _rate;
        private int _days;
        private bool _hired = false;

        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        public double Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }
        public int Days
        {
            get { return this._days; }
            set { this._days = value; }
        }
        public bool Hired { get { return _hired; }}

        public void Hire()
        {
            this._hired = true;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"-Renovator: {this._name}");
            sb.AppendLine($"--Specialty: {this._type}");
            sb.Append($"--Rate per day: {this._rate} BGN");
            return sb.ToString();
        }
    }
}
