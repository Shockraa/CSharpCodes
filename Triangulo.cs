using System;
					
public class Program
{
	public static void Main()
	{
		Triangulo objTriangulo = new Triangulo(); //Cria objeto
		Console.WriteLine("Insira o lado 1");
		objTriangulo.lado1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Insira o lado 2");
		objTriangulo.lado2 = double.Parse(Console.ReadLine());
		Console.WriteLine("Insira o lado 3");
		objTriangulo.lado3 = double.Parse(Console.ReadLine());
		Console.WriteLine( "É triangulo? "+ Triangulo.isTriangle(objTriangulo.lado1, objTriangulo.lado2, objTriangulo.lado3));
		
		
	}
}
public class Triangulo
{
	public double lado1;
	public double lado2;
	public double lado3;
	public static double perimetro;
	public static double area;
	public string tipo;
    
	
	public static bool isTriangle(double lado1 ,double lado2, double lado3) //Checa se é um triangulo
	{
		if(lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1) //Caso sim, ativa os métodos e retorna true
		{
			CalcularPerimetro(lado1, lado2, lado3);
			CalcularArea(lado1, lado2, lado3);
			Classificar(lado1, lado2, lado3);
			return true;
			
		}
		else
		{
		  return false;	//Encerra programa caso não seja
		}
	}
	public static void CalcularPerimetro(double lado1, double lado2, double lado3)
	{
		Triangulo.perimetro = lado1 + lado2 + lado3;
		Console.WriteLine("O perimetro do triangulo é: " + Triangulo.perimetro);
		 
	}
	public static void CalcularArea(double lado1, double lado2, double lado3)
	{
		Triangulo.area = Math.Sqrt((Triangulo.perimetro / 2) * ((Triangulo.perimetro / 2) - lado1) * ((Triangulo.perimetro / 2) - lado2) * ((Triangulo.perimetro / 2) - lado3) );
		Console.WriteLine("A área do triangulo é: " + Triangulo.area);
	}
	public static void Classificar (double lado1, double lado2, double lado3)
	{
		if (lado1 == lado2 && lado2 == lado3)
		{
			Console.WriteLine("O triangulo é equilatero");
		}
		else if(lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
		{
		   Console.WriteLine("O triangulo é isóceles");	
		}
		else
		{
		   Console.WriteLine("O triangulo é escaleno");	
		}
	}
}
