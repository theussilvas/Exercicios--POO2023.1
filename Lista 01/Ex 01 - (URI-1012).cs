using System;

class Program {
  public static void Main (string[] args) {
   
    string[] inputs = Console.ReadLine().Split(' ');
    double a = double.Parse(inputs[0]);
    double b = double.Parse(inputs[1]);
    double c = double.Parse(inputs[2]);
    double e = Math.Pow(c,2);
    
    double rectt= (a*c)/2;
    double circ= (3.14159*e);
    double trap=((a+b)*c)/2;
    double squa= Math.Pow(b,2);
    double rect= (a*b);

    string formrectt = rectt.ToString("0.000");
    string formcirc= circ.ToString("0.000");
    string formtrap= trap.ToString("0.000");
    string formsqua= squa.ToString("0.000");
    string formrect= rect.ToString("0.000");
    
    Console.WriteLine($"Triangulo = {formrectt}, Circulo = {formcirc}, Trapezio = {formtrap}, Quadrado = {formsqua}, Retangulo = {formrect}");
    
    

  }
}
