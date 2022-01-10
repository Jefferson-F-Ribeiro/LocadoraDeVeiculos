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
        case 3 : CategoriaAtualizar(); break;
        case 4 : CategoriaExcluir(); break;
        case 5 : VeiculoListar(); break;
        case 6 : VeiculoInserir(); break;
        case 7 : VeiculoAtualizar(); break;
        case 8 : VeiculoExcluir(); break;
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
    Console.WriteLine(" ----------------------------");
    Console.WriteLine("|  1 - Categoria - Listar    |");
    Console.WriteLine("|  2 - Categoria - Inserir   |");
    Console.WriteLine("|  3 - Categoria - Atualizar |");
    Console.WriteLine("|  4 - Categoria - Excluir   |");
    Console.WriteLine("|  5 - Veiculo - Listar      |");
    Console.WriteLine("|  6 - Veiculo - Inserir     |");
    Console.WriteLine("|  7 - Veiculo - Atualizar   |");
    Console.WriteLine("|  8 - Veiculo - Excluir     |");
    Console.WriteLine("|  0 - Fim                   |");
    Console.WriteLine(" ----------------------------");
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

    public static void CategoriaAtualizar(){
    Console.WriteLine("Atualização de Categorias");
    CategoriaListar();
    Console.Write("Informe um código da categoria que deseja atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe uma nova descrição: ");
    string descricao = Console.ReadLine();
    Console.Write("Informe um novo tipo: ");
    string tipo = Console.ReadLine();
    Console.Write("Informe um novo preço: ");
    double preco = double.Parse(Console.ReadLine());

    Categoria c = new Categoria(id, descricao,tipo,preco);
    ncategoria.Atualizar(c);

  }

  public static void CategoriaExcluir(){
    Console.WriteLine("Exclusão de Categorias");
    CategoriaListar();
    Console.Write("Informe um código da categoria que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    Categoria c = ncategoria.Listar(id);
    ncategoria.Excluir(c);
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
      Console.Write("Informe um código para o veiculo: ");
      int id = int.Parse(Console.ReadLine());
      Console.Write("Informe uma descrição: ");
      string descricao = Console.ReadLine();
      Console.Write("Informe um modelo: ");
      string modelo = Console.ReadLine();
      Console.Write("Informe uma marca: ");
      string marca = Console.ReadLine();
      Console.Write("Informe uma durabilidade: ");
      double durabilidade = double.Parse(Console.ReadLine());
      CategoriaListar();
      Console.Write("Informe a categoria: ");
      int idcategoria = int.Parse(Console.ReadLine());

      Categoria c = ncategoria.Listar(idcategoria);

    Veiculo v = new Veiculo(id,descricao,modelo,marca,durabilidade,c);
    nveiculos.Inserir(v);
  }

  
  public static void VeiculoAtualizar(){
    Console.WriteLine("Atualização de Veiculos");
    VeiculoListar();
    Console.Write("Informe o código do veiculo que deseja atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Informe uma descrição: ");
    string descricao = Console.ReadLine();
    Console.Write("Informe um modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Informe uma marca: ");
    string marca = Console.ReadLine();
    Console.Write("Informe uma durabilidade: ");
    double durabilidade = double.Parse(Console.ReadLine());
    CategoriaListar();
    Console.Write("Informe a categoria: ");
    int idcategoria = int.Parse(Console.ReadLine());

    Categoria c = ncategoria.Listar(idcategoria);

    Veiculo v = new Veiculo(id,descricao,modelo,marca,durabilidade,c);
    nveiculos.Atualizar(v);
  }

  public static void VeiculoExcluir(){
    Console.WriteLine("Exclusão de Veiculos");
    VeiculoListar();
    Console.Write("Informe o código do veiculo que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    Veiculo v = nveiculos.Listar(id);
    nveiculos.Excluir(v);
  }



}
