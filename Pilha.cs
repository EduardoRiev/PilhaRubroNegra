class Pilha
{
    private int tamanhoPilha;
    private Peça[] peças;
    private int indiceRubro;
    private int indiceNegro;
    public Pilha(int tamanhoPilha, int indiceRubro, int indiceNegro, Peça[] peças)
    {
        this.tamanhoPilha = tamanhoPilha;
        this.indiceRubro = indiceRubro;
        this.indiceNegro = indiceNegro;
        this.peças = peças;
    }
    ////////////////////////////////////
    public int GetTamanhoPilha()
    {
        return tamanhoPilha;
    }
    public void SetTamanhoPilha(int tamanhoPilha)
    {
        this.tamanhoPilha = tamanhoPilha;
    }
    ////////////////////////////////////
    public int GetIndiceRubro()
    {
        return indiceRubro;
    }
    public void SetIndiceRubro(int indiceRubro)
    {
        this.indiceRubro = indiceRubro;
    }
    ////////////////////////////////////
    public int GetIndiceNegro()
    {
        return indiceNegro;
    }
    public void SetIndiceNegro(int indiceNegro)
    {
        this.indiceNegro = indiceNegro;
    }
    ////////////////////////////////////
    public Peça[] GetPeças()
    {
        return peças;
    }
    public void SetPeças(Peça[] peças)
    {
        this.peças = peças;
    }
    ////////////////////////////////////
    public void PopNegro()
    {
        peças[indiceNegro] = null;
        indiceNegro--;
    }
    public void PopRubro()
    {
        peças[indiceRubro] = null;
        indiceRubro--;
    }
    ////////////////////////////////////
    public void PushNegro(Peça peça)
    {
        if (indiceNegro - 1 == indiceRubro)
        {
            DuplicaArray();
        }
        indiceNegro--;
        SetIndiceNegro(indiceNegro);
        peças[indiceNegro] = peça;
    }
    public void PushRubro(Peça peça)
    {
        if (indiceRubro + 1 == indiceNegro)
        {
            DuplicaArray();
        }
        indiceRubro++;
        SetIndiceRubro(indiceRubro);
        peças[indiceRubro] = peça;
    }
    ////////////////////////////////////
    public void DuplicaArray()
    {
        Peça[] novoArray = new Peça[tamanhoPilha * 2];
        int cont = novoArray.Length - 1;
        for (int i = 0; i <= indiceRubro; i++)
        {
            novoArray[i] = peças[i];
        }
        for (int i = peças.Length - 1; i >= indiceNegro; i--)
        {
            novoArray[cont] = peças[i];
            cont--;
        }
        indiceNegro = cont + 1;
        tamanhoPilha *= 2;
        SetPeças(novoArray);
    }
    public void Listar()
    {
        for (int i = 0; i < tamanhoPilha; i++)
        {
            if (peças[i] == null)
            {
                Console.Write("-");
            }
            else
            {
                Console.Write($"{peças[i].GetCor()} ");
            }
        }
    }
}
