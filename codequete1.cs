using System;

class MainClass {
  public static void Main (string[] args) {
  
    int x = int.MaxValue;
    long y = long.MaxValue;
    short z = short.MaxValue;

    ulong a = (ulong)x + (ulong)y + (ulong)z;

    Console.WriteLine (a);

  }
}
