using System;

class Program {
  public static void Main (string[] args) {
    Categoria c1 = new Categoria(1,"Sedan","Sedan",50);
    Categoria c2 = new Categoria(2,"Hatchback","Hatchback",25);
    
    Console.WriteLine (c1);
    Console.WriteLine (c2);

    Veiculo v1 = new Veiculo(1, "Ford Focus 1.6","Focus","Ford",100);
    Veiculo v2 = new Veiculo(2, "Ford Fusion Hybrid","Fusion","Ford",100);
    Veiculo v3 = new Veiculo(3, "Ford Edge 2.7 V6","Edge","Ford",100);
    Veiculo v4 = new Veiculo(4, "Ford Mustang Ecoboost","Mustang","Ford",100);

    Console.WriteLine (v1);
    Console.WriteLine (v2);
    Console.WriteLine (v3);
    Console.WriteLine (v4);
  }
}

class Categoria{
  private int id;
  private string descricao;
  private string tipo;
  private double preco;

  public Categoria(int id, string descricao, string tipo, double preco){
    this.id = id;
    this.descricao = descricao;
    this.tipo = tipo;
    this.preco = preco > 0 ? preco : 0;
  }

  public void setId(int id){
    this.id = id;
  }

  public void setDescricao(string descricao){
    this.descricao = descricao;
  }

  public void setTipo(string tipo){
    this.tipo = tipo;
  }

  public void setPreco(double preco){
    this.preco = preco > 0 ? preco : 0;
  }

  public int getId(){
    return id;
  }

  public string getDescricao(){
    return descricao;
  }

  public string getTipo(){
    return tipo;
  }

  public double getPreco(){
    return preco;
  }

  public override string ToString(){
    return id + " - " + descricao + " preco: " + preco.ToString("0.00");
  }
}


class Veiculo{
  private int id;
  private string descricao;
  private string modelo;
  private string marca;
  private double durabilidade;

  public Veiculo(int id, string descricao, string modelo, string marca, double durabilidade){
    this.id = id;
    this.descricao = descricao;
    this.modelo = modelo;
    this.marca = marca;
    this.durabilidade = durabilidade > 0 ? durabilidade : 0;
  }

  public override string ToString(){
    return id + " - " + descricao + " - " + modelo + " - " + marca + " - " + durabilidade;
  }
  
  public void setId(int id){
    this.id = id;
  }

  public void setDescricao(string descricao){
    this.descricao = descricao;
  }

  public void setModelo(string modelo){
    this.modelo = modelo;
  }

  public void setMarca(string marca){
    this.marca = marca;
  }

  public void setDurabilidade(double durabilidade){
    this.durabilidade = durabilidade > 0 ? durabilidade : 0;
  }

  public int getId(){
    return id;
  }

  public string getDescricao(){
    return descricao;
  }

  public string getModelo(){
    return modelo;
  }

  public string getMarca(){
    return marca;
  }

  public double getDurabilidade(){
    return durabilidade;
  }
}