using System;

class Program {
  public static void Main (string[] args) {
    Categoria c1 = new Categoria(1,"Sedan","Sedan",50);
    Categoria c2 = new Categoria(2,"Hatchback","Hatchback",25);
    
    Console.WriteLine (c1);
    Console.WriteLine (c2);

    Veiculo v1 = new Veiculo(1, "Ford Focus 1.6","Focus","Ford",100, c2);
    Veiculo v2 = new Veiculo(2, "Ford Fusion Hybrid","Fusion","Ford",100, c1);
    Veiculo v3 = new Veiculo(3, "Ford Edge 2.7 V6","Edge","Ford",100);
    Veiculo v4 = new Veiculo(4, "Ford Mustang Ecoboost","Mustang","Ford",100);

    Console.WriteLine (v1);
    Console.WriteLine (v2);
    Console.WriteLine (v3);
    Console.WriteLine (v4);
  }
}
