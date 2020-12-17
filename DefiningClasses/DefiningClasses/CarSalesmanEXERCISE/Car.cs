using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model,Engine engine, int weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model,Engine engine,string color)
            :this(model,engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight,string color)
            :this(model,engine)
        {
            this.Weight = weight;
            this.Color = color;
        }
        public override string ToString()
        {
            string displacement = this.Engine.Displacement != 0 ? this.Engine.Displacement.ToString() : "n/a";
            string weight = this.Weight != 0 ? this.Weight.ToString() : "n/a";

            return $"{this.Model}:\n" +
                $"  {this.Engine.Model}:\n" +
                $"     Power: {this.Engine.Power}\n" +
                $"     Displacement: {displacement}\n" +
                $"     Efficiency: {(this.Engine.Efficiency != null ? this.Engine.Efficiency : "n/a")}\n" +
                $"  Weight: {weight}\n" +
                $"  Color: {(this.Color != null ? this.Color.ToString() : "n/a")}".ToString();
        }
    }
}
