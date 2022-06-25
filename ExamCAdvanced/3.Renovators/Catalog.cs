using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.Renovators = new List<Renovator>();
        }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count { get; private set; }
        public List<Renovator> Renovators { get; set; }
        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return null;
            }
            if (this.Count == this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            Renovators.Add(renovator);
            this.Count++;
            return $"Successfully added {renovator.Name} to the catalog.";

        }
        public bool RemoveRenovator(string name)
        {
            for (int i = 0; i < this.Renovators.Count; i++)
            {
                if (this.Renovators[i].Name == name)
                {
                    this.Renovators.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int numberOfRemovedRenovators = 0;

            for (int i = 0; i < Renovators.Count; i++)
            {
                if (this.Renovators[i].Type == type)
                {
                    this.Renovators.RemoveAt(i);
                    numberOfRemovedRenovators++;
                }
            }
            return numberOfRemovedRenovators;
        }
        public Renovator HireRenovator(string name)
        {
            var hiredRenovator = this.Renovators.FirstOrDefault(r => r.Name == name);
            hiredRenovator.Hire();
            return hiredRenovator;
        }
        public List<Renovator> PayRenovators(int days)
        {
            return  this.Renovators.Where(r => r.Days >= days).ToList();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");
            for (int i = 0; i < this.Renovators.Count; i++)
            {
                if (this.Renovators[i].Hired == false)
                {
                    sb.AppendLine(this.Renovators[i].ToString());
                }
            }
            return sb.ToString();
        }

    }

}
