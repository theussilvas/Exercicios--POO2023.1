using System;

class Program {
  public static void Main (string[] args) {
    
    int tempo = int.Parse(Console.ReadLine());
    int km= int.Parse(Console.ReadLine());

    double distancia = tempo*km;
    double gasolina= distancia/12;
    string formresult = gasolina.ToString("0.000");

    Console.WriteLine($"{formresult}");
    }
  }
    
