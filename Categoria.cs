using System;

class Categoria{
  private int id;
  private string descricao;
  private string tipo;
  private double preco;
  private Veiculo[] veiculos = new Veiculo[10];
  private int np;

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

  public Veiculo[] VeiculoListar(){
    Veiculo[] c = new Veiculo[np];
    Array.Copy(veiculos, c, np);
    return c;
  }

  public void VeiculoInserir(Veiculo v){
    if (np == veiculos.Length){
      Array.Resize(ref veiculos, 2 * veiculos.Length);
    }
    veiculos[np] = v;
    np++;
  }

  public override string ToString(){
    return id + " - " + descricao + " preco: " + preco.ToString("0.00") + " - Nº de veiculos: " + np;
  }
}
