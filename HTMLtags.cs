using System;
using System.Text.RegularExpressions;		
public class Program
{
	public static void Main()
	{
		string html = "<body><h1>Eu sou eu</h1></body><script>lololol</script>";
		string pattern = "<.*?>";
		string textoLimpo = Regex.Replace(html, pattern, string.Empty);
		Console.WriteLine(textoLimpo);
	}
}

