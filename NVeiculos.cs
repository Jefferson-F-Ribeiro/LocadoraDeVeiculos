using System;

class NVeiculos{
  private Veiculo[] veiculos = new Veiculo[10];
  private int nv;

  public void Inserir(Veiculo v){
    if(nv == veiculos.Length){
      Array.Resize(ref veiculos, 2*veiculos.Length);
    }
    veiculos[nv] = v;
    nv++;

    Categoria c = v.getCategoria();
    if(c != null) c.VeiculoInserir(v);
  }

  public Veiculo[] Listar(){
    Veiculo[] v = new Veiculo[nv];
    Array.Copy(veiculos, v, nv);
    return v;
  }

  public Veiculo Listar(int id){
    for(int i = 0; i < nv; i++){
      if(veiculos[i].getId() == id) return veiculos[i];
    }
    return null;
  }
}