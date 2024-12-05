using System;

class Program
{
    static void Main()
    {
        // Solicita as duas datas ao usuário
        Console.WriteLine("Digite a primeira data (formato: dd/MM/yyyy): ");
        
        
        
        
        DateTime data1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        
        Console.WriteLine("Digite a segunda data (formato: dd/MM/yyyy): ");
        
        
        
        DateTime data2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        
        // Calcula a diferença de dias entre as duas datas
        TimeSpan diferenca = data2 - data1;

        // Exibe o número de dias entre as datas
        Console.WriteLine($"A diferença entre as duas datas é de {diferenca.Days} dias.");
    }
}
