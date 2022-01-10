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

  public void Atualizar(Veiculo v){
    Veiculo v_atual = Listar(v.getId());
    v_atual.setDescricao(v.getDescricao());
    v_atual.setModelo(v.getModelo());
    v_atual.setMarca(v.getMarca());
    v_atual.setDurabilidade(v.getDurabilidade());
    if(v_atual.getCategoria() != null){
      v_atual.getCategoria().VeiculoExcluir(v_atual);
    }
    v_atual.setCategoria(v.getCategoria());
    if(v_atual.getCategoria() != null)
      v_atual.getCategoria().VeiculoInserir(v_atual);
  }

  private int Indice(Veiculo v){
    for(int i = 0; i < nv; i++)
      if(veiculos[i] == v) return i;
    return -1;
  }

  public void Excluir(Veiculo v){
    int n =Indice(v);
    if(n == -1) return;
    for(int i = n; i < nv - 1; i++)
      veiculos[i] = veiculos[i+1];
    nv--;
    Categoria c = v.getCategoria();
    if (c != null) c.VeiculoExcluir(v);
  }
}