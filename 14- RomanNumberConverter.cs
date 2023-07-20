using System;

class RomanNumberConverter
{
    static void Main()
    {
        // Write a program that converts Arabic digits to Roman ones (Obs, Arabic = Decimal então usei decimal).
        Console.WriteLine("Digite num");
        int num = int.Parse(Console.ReadLine());
        string numeroRomano = ConverterParaRomano(num); //Função
        Console.WriteLine(numeroRomano);
    }

    static string ConverterParaRomano(int num)
    {
        if (num < 1 || num > 3999)
            throw new ArgumentOutOfRangeException("O número deve estar entre 1 e 3999."); //Limite dos nums romanos

        string[] milhares = { "", "M", "MM", "MMM" };
        string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] dezenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        return milhares[num / 1000] + //Calcula a posição dos arrays e concatena para mostrar no fim
               centenas[(num % 1000) / 100] +
               dezenas[(num % 100) / 10] +
               unidades[num % 10];
    }
}
