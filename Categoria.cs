using System;

class Categoria{
  private int id;
  private string descricao;
  private string tipo;
  private double preco;
  private Veiculo[] veiculos = new Veiculo[10];
  private int nv;

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
    Veiculo[] c = new Veiculo[nv];
    Array.Copy(veiculos, c, nv);
    return c;
  }

  public void VeiculoInserir(Veiculo v){
    if (nv == veiculos.Length){
      Array.Resize(ref veiculos, 2 * veiculos.Length);
    }
    veiculos[nv] = v;
    nv++;
  }

  private int VeiculoIndice(Veiculo v){
    for(int i = 0; i < nv; i++)
      if(veiculos[i] == v) return i;
    return -1;
  }

  public void VeiculoExcluir(Veiculo v){
    int n = VeiculoIndice(v);
    if(n == -1) return;
    for(int i = n; i < nv - 1; i++)
      veiculos[i] = veiculos[i+1];
    nv--;
  }

  public override string ToString(){
    return id + " - " + descricao + " preco: " + preco.ToString("0.00") + " - Nº de veiculos: " + nv;
  }
}
