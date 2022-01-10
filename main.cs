using System;

class Program {
  public static void Main (string[] args) {
    Categoria c1 = new Categoria(1,"Sedan","Sedan",50);
    Categoria c2 = new Categoria(2,"Hatchback","Hatchback",25);
    Categoria c3 = new Categoria(3,"SUV","SUV",75);
    
    Console.WriteLine (c1);
    Console.WriteLine (c2);
    Console.WriteLine (c3);

    Veiculo v1 = new Veiculo(1, "Ford Focus 1.6","Focus","Ford",100, c2);
    Veiculo v2 = new Veiculo(2, "Ford Fusion Hybrid","Fusion","Ford",100, c1);
    Veiculo v3 = new Veiculo(3, "Ford Edge 2.7 V6","Edge","Ford",100, c3);
    Veiculo v4 = new Veiculo(4, "Ford Mustang Ecoboost","Mustang","Ford",100, c1);

    Console.WriteLine (v1);
    Console.WriteLine (v2);
    Console.WriteLine (v3);
    Console.WriteLine (v4);

    c1.VeiculoInserir(v2);
    c1.VeiculoInserir(v4);
    c2.VeiculoInserir(v1);
    c3.VeiculoInserir(v3);

    Console.WriteLine("");
    Veiculo[] v = c1.VeiculoListar();
    Console.Write("Veiculos na categoria: ");
    Console.WriteLine(c1.getDescricao());
    foreach (Veiculo x in v) Console.WriteLine(x);

    Console.WriteLine("");
    v = c2.VeiculoListar();
    Console.Write("Veiculos na categoria: ");
    Console.WriteLine(c2.getDescricao());
    foreach (Veiculo x in v) Console.WriteLine(x);

    Console.WriteLine("");
    v = c3.VeiculoListar();
    Console.Write("Veiculos na categoria: ");
    Console.WriteLine(c3.getDescricao());
    foreach (Veiculo x in v) Console.WriteLine(x);

  }
}
