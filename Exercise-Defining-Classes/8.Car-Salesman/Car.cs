using System;

namespace DefiningClasses
{
	public class Car
	{
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight) :this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color) :this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) :this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        private string _model;
        private Engine _engine;
        private int _weight = -1;
        private string _color = "n/a";

        public string Model { get { return _model; } set { _model = value; } }
        public Engine Engine { get { return _engine; } set { _engine = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
        public string Color { get { return _color; } set { _color = value; } }

        public override string ToString()
        {
            //"{CarModel}:
            //  {EngineModel}:
            //    Power: {EnginePower}
            //    Displacement: {EngineDisplacement}
            //    Efficiency: {EngineEfficiency}
            //   Weight: {CarWeight}
            //   Color: {CarColor}"
            


            return
                $"{this._model}:\n" +
                $"  {this._engine.Model}:\n" +
                $"    Power: {this._engine.Power}\n" +
                $"    Displacement: {(this._engine.Dissplacement != -1 ? this._engine.Dissplacement.ToString() : "n/a")}\n" +
                $"    Efficiency: {this._engine.Efficieny}\n" +
                $"  Weight: {(this._weight != -1 ? this._weight.ToString() : "n/a")}\n" +
                $"  Color: {this._color}";
        }

    }
}

