using System;
using System.Text.RegularExpressions;		
public class Program

/*Write a program that extracts all the text without any tags and
attribute values from an HTML document.*/
{
	public static void Main()
	{
		string html = "<body><h1>Comando: </h1></body><script>console.log()</script>";
		string pattern = "<.*?>"; 
		string clean = Regex.Replace(html, pattern, string.Empty); //Switches text
		Console.WriteLine(clean); //Displays the clean tex
	}
}

