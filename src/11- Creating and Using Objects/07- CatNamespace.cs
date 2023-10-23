using System;	
using CreatingAndUsingObjects;			
class Program
{
	public static void Main()
	{
		/*Write a program which creates 10 objects of type Cat, gives them names
                  CatN, where N is a unique serial number of the object, and in the end call
                  the method SayMiau() for each of them. For the implementation use the
                  namespace CreatingAndUsingObjects.*/

                // Programa para praticar namespaces
		
		Cat Cat1 = new("Leo","White");
		Cat Cat2 = new("Safira","Gray");
		Cat Cat3 = new("Malu","White");
		Cat Cat4 = new("Tom","Gray");
		Cat Cat5 = new("Lari","Black");
		Cat Cat6 = new("Jacinto","Black");
		Cat Cat7 = new("Oli","White");
		Cat Cat8 = new();
		Cat Cat9 = new("Sem nome","Yellow");
		Cat Cat10 = new("Luna","Gray");
	}
}
