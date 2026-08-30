using System.Linq.Expressions;

public class Pilha
{
    // Atributos
    private List<object> pilha = new List<object>(); // Arranjo dinâmico de objetos (T).
    private object Topo = null;
    private int Qtd = 0;

    // Métodos
    public int Alcance()
    {
        return Qtd;
    }

    public object Buscar(object ValorBusca)
    {
        if (ValorBusca is int ValorInt)
        {
            int i = -1;
            foreach (object Elem in pilha)
            {
                if (Elem is int ElemInt)
                {
                    i++;
                    if (ElemInt == ValorInt)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }// Futuramente adicionarei mais tipos para seleção
        return "Não é um número";
    }

    public object GetTopo()
    {
        return Topo;
    }

    public void Empilhar(object ValorEmp) // Nota: O ValorEmp é do tipo Object, mas quando é transferido o seu valor para o arranjo dinâmico, ele representa seu tipo literal (inteiro, string, bool, float...).
    {
        pilha.Add(ValorEmp);
        Qtd++;
        Topo = ValorEmp;
    }

    public void Desempilhar()
    {
        if (Qtd == 0)
        {
            throw new ArgumentException("Não é possível desempilhar uma pilha vazia.");
        }
        else if (Qtd == 1)
        {
            pilha.RemoveAt(pilha.Count() - 1);
            Qtd--;
            Topo = null;
            return;
        }
        else
        {
            pilha.RemoveAt(pilha.Count() - 1);
            Qtd--;
            Topo = pilha[pilha.Count() - 1]; // Último da pilha depois que desempilhado.
            return;
        }
    }

    /*
    - Observações:
    Pilha:
    1 - Para concluir, a classe precisa de um método que retorna uma string pelo método Console.WriteLine(). Equivalente ao __str__() do Python.

    2 - Corrigir os avisos de instabilidade acusados pelo compilador -> Topo.

    3 - Permitir a adição de mais tipos de dados na Estrutura de dado (Cast).
    
    Fila:

    */
}