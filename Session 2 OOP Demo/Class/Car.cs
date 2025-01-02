using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP_Demo.Class
{
    internal class Car
    {
		#region Attributes
		private int id;
		private string? model;
		private double speed;
		#endregion

		#region Properties
		public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		public string? Model
		{
			get { return model; }
			set { model = value; }
		}


		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		#endregion

		//if u define a constructor, compiler will no longer generate "empty parameterless constructor" 
		public Car(int id, string? model, double speed)
		{
			this.id = id;
			this.model = model;
			this.speed = speed;
			Console.WriteLine("Constructor 01");
		}

		public Car(int id, string? model) : this(id, model, 120) //constructor chain
		{
			//this.id = id;
			//this.model = model;
			//this.speed = 120;
			Console.WriteLine("Constructor 02");
		}

		public Car(int id) : this(id, "Kkoda Kodiaq", 200)
		{
			//this.id = id;
			//this.model= "Kkoda Kodiaq";
			//this.speed = 200;
			Console.WriteLine("Constructor 03");
		}

		//constructor overloading
		#region Mothods
		public override string ToString()
		{
			return $"ID = {id}, Model: {model}, Speed = {speed}";
		} 
		#endregion
	}
}
