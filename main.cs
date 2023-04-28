using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 1) {
      int i = 2;
      while (i <= Math.Sqrt(num)) {
        if (num % i == 0) {
          Console.WriteLine("{0} is not a prime number", num);
          break;
        }
        i++;
      }
      if (i > Math.Sqrt(num)) {
        Console.WriteLine("{0} is a prime number", num);
      }
    }
    else {
      Console.WriteLine("{0} is not a prime number", num);
    }
  }
}
