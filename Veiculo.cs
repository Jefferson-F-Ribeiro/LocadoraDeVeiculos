using System;

class Veiculo{
  private int id;
  private string descricao;
  private string modelo;
  private string marca;
  private double durabilidade;
  private Categoria categoria;

  public Veiculo(int id, string descricao, string modelo, string marca, double durabilidade){
    this.id = id;
    this.descricao = descricao;
    this.modelo = modelo;
    this.marca = marca;
    this.durabilidade = durabilidade > 0 ? durabilidade : 0;
  }

  public Veiculo(int id, string descricao, string modelo, string marca, double durabilidade, Categoria categoria) : this(id, descricao, modelo, marca, durabilidade){
    this.categoria = categoria;
  }

  public override string ToString(){
    if(categoria == null)
      return id + " - " + descricao + " - " + modelo + " - " + marca + " - " + durabilidade;
    else
      return id + " - " + descricao + " - " + modelo + " - " + marca + " - " + durabilidade + " - " + categoria.getDescricao();
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

  public void setCategoria(Categoria categoria){
    this.categoria = categoria;
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

  public Categoria getCategoria(){
    return categoria;
  } 
}