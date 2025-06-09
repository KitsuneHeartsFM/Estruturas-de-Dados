namespace PilhaEstatica;

class Program
{
    static void Main(string[] args)
    {
        IEmpilhavel<string> pilha = new PilhaEstaticaGenerica<string>();
        
        pilha.Empilhar("Untouchables");
        pilha.Empilhar("Hybrid Theory");
        pilha.Empilhar("White Pony");
        pilha.Empilhar("Three Dollar Bill Y'all!");
        pilha.Empilhar("Iowa");

        Console.WriteLine(pilha.Imprimir());
    }
}