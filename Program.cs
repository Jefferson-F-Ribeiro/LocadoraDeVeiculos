using System;

class Program {
  public static void Main (string[] args) {/*
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
    foreach (Veiculo x in v) Console.WriteLine(x);*/

    int op = 0;
    Console.WriteLine(".~*-.~*-.~*-.~*-.~*-.~*-.~*.");
    Console.WriteLine("|   Locadora de Veículos   |");
    Console.WriteLine(".~*-.~*-.~*-.~*-.~*-.~*-.~*.");
    do {
      try{
      op = Menu();
      switch(op){
        case 1 : CategoriaListar(); break;
        case 2 : CategoriaInserir(); break;
      }
    } catch (Exception erro){
      Console.WriteLine(erro.Message);
      op = 100;
    }

    } while (op != 0);
    Console.WriteLine("Encerrado programa...");
  }

  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine(" --------------------------");
    Console.WriteLine("|  1 - Categoria - Listar  |");
    Console.WriteLine("|  2 - Categoria - Inserir |");
    Console.WriteLine("|  0 - Fim                 |");
    Console.WriteLine(" --------------------------");
    Console.Write("Informe uma opção: ");

    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static void CategoriaListar(){
      Console.WriteLine("Lista de Categorias");
  }

  public static void CategoriaInserir(){
      Console.WriteLine("Inserção de Categorias");
  }
}
