namespace PilhaEstatica;

public class PilhaEstaticaGenerica<T> (int _tamanho = 10) : IEmpilhavel<T>
{
    private int _ponteiroTopo = -1;
    private T[] _dados = new T[_tamanho];
    
    public void Empilhar(T dado)
    {
        if (!EstaCheia())
        {
            _ponteiroTopo++;
            _dados[_ponteiroTopo] = dado;
        }
        else
        {
            throw new InvalidOperationException("Pilha Cheia!");
        }
    }

    public T Espiar()
    {
        T resultado = default(T);

        if (!EstaVazia())
        {
            resultado = _dados[_ponteiroTopo];
        }
        else
        {
            throw new InvalidOperationException("Pilha Vazia!");
        }
        
        return resultado;
    }

    public T Desempilhar()
    {
        T resultado = default(T);

        if (!EstaVazia())
        {
            resultado = _dados[_ponteiroTopo];
            _ponteiroTopo--;
        }
        else
        {
            throw new InvalidOperationException("Pilha Vazia!");
        }
        
        return resultado;
    }

    public bool EstaCheia()
    {
        return _ponteiroTopo == _dados.Length - 1;
    }

    public bool EstaVazia()
    {
        return _ponteiroTopo == -1;
    }

    public string Imprimir()
    {
        string retorno = "[";

        for (int i = _ponteiroTopo; i >= 0; i--)
        {
            if (i == 0)
            {
                retorno += _dados[i];
            }
            else
            {
                retorno += _dados[i] + ", ";
            }
        }
        
        return $"{retorno}]";
    }
}