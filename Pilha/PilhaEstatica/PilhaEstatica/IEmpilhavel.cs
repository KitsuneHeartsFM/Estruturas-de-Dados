namespace PilhaEstatica;

public interface IEmpilhavel <T>
{
    // métodos principais
    void Empilhar(T dado);
    T? Espiar();
    T? Desempilhar();
    
    // métodos auxiliares
    bool EstaCheia();
    bool EstaVazia();
    string Imprimir();
}