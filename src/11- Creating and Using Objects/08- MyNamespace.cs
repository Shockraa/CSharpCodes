using System;

namespace CreatingAndUsingObjects
{
	public class Cat
	{
                /*Define your own namespace CreatingAndUsingObjects and place in it
                 two classes Cat and Sequence, which we used in the examples of the
                current chapter. Define one more namespace and make a class, which
                calls the classes Cat and Sequence, in it.*/

		//Namespace usado no outro exercício
 
		public string name;
		public string color;

                public Cat() // Constructor
		{
			this.name = "Unnamed";
			this.color = "gray";
			 SayMiau(this.name, this.color);
		}
		
		public Cat(string name, string color) // Constructor
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
	

