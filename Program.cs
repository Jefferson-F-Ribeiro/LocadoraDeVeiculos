using System;

class Program {
  private static NCategoria ncategoria = new NCategoria();
  private static NVeiculos nveiculos = new NVeiculos();
  public static void Main (string[] args) {
    
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
    Console.WriteLine("|  3 - Veiculo - Listar    |");
    Console.WriteLine("|  4 - Veiculo - Inserir   |");
    Console.WriteLine("|  0 - Fim                 |");
    Console.WriteLine(" --------------------------");
    Console.Write("Informe uma opção: ");

    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  public static void CategoriaListar(){
      Console.WriteLine("Lista de Categorias");
      Categoria[] cs = ncategoria.Listar();
      if(cs.Length == 0){
        Console.WriteLine("Nenhuma categoria cadastrada");
        return;
      }

      foreach(Categoria c in cs) Console.WriteLine(c); Console.WriteLine();
  }

  public static void CategoriaInserir(){
      Console.WriteLine("Inserção de Categorias");
      Console.Write("Informe um código para a categoria: ");
      int id = int.Parse(Console.ReadLine());
      Console.Write("Informe uma descrição: ");
      string descricao = Console.ReadLine();
      Console.Write("Informe um tipo: ");
      string tipo = Console.ReadLine();
      Console.Write("Informe um preço: ");
      double preco = double.Parse(Console.ReadLine());

    Categoria c = new Categoria(id, descricao,tipo,preco);
    ncategoria.Inserir(c);
  }

  public static void VeiculoListar(){
      Console.WriteLine("Lista de Veiculos");
      Veiculo[] vs = nveiculos.Listar();
      if(vs.Length == 0){
        Console.WriteLine("Nenhum veiculo cadastrado");
        return;
      }

      foreach(Veiculo v in vs) Console.WriteLine(v); Console.WriteLine();
  }

  public static void VeiculoInserir(){
      Console.WriteLine("Inserção de Veiculos");
      Console.Write("Informe um código para o veículo: ");
      int id = int.Parse(Console.ReadLine());
      Console.Write("Informe uma descrição: ");
      string descricao = Console.ReadLine();
      Console.Write("Informe um modelo: ");
      string modelo = Console.ReadLine();
      Console.Write("Informe uma marca: ");
      string marca = Console.ReadLine();
      Console.Write("Informe uma durabilidade: ");
      double durabilidade = double.Parse(Console.ReadLine());

    Veiculo v = new Veiculo(id,descricao,modelo,marca,durabilidade);
    nveiculos.Inserir(v);
  }




}
