using System;

namespace CreatingAndUsingObjects
{
	public class Cat
	{
		// Field name
		public string name;
		// Field color
		public string color;

        public Cat()
		{
			this.name = "Unnamed";
			this.color = "gray";
			 SayMiau(this.name, this.color);
		}
		// Constructor with parameters
		public Cat(string name, string color)
		{
			this.name = name;
			this.color = color;
			 SayMiau(this.name, this.color);
		}
		public void SayMiau(string name, string color)
        {
            Console.WriteLine($"Miau! My name is {name} and I am {color}.");
        }

	}
	
}
	

