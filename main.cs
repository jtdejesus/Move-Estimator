using System;

class Program {
  public static void Main (string[] args) {
    double perMove = 200;
    double hours = 103;
    double miles = 3000;
    double Total = perMove +  hours * 150 + miles * 2;
    Console.WriteLine ("$" + Total + ".00" );
  }
}