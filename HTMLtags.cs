using System;
using System.Text.RegularExpressions;		
public class Program
{
	public static void Main()
	{
		string html = "<body><h1>Comando: </h1></body><script>console.log()</script>";
		string pattern = "<.*?>"; //sequencia
		string textoLimpo = Regex.Replace(html, pattern, string.Empty); //trocar texto
		Console.WriteLine(textoLimpo);
	}
}

