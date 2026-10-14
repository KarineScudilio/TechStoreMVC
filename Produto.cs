namespace TechStoreMVC.Models;

public class Produto
{
    // Passo 01 - Criar as Models
    // Atributos
    public int Id {get; set;} // Get para obter um id - Indentificador
                            // Set para definir um novo valor, atualizar etc
    public string Nome {get; set;}
    public decimal Preco {get; set;}
    public int Estoque {get; set;}

       //Método Construtor - Define valorws iniciais desses atributos acima!
       public Produto (
        int id,
        string nome,
        decimal preco,
        int estoque
)
    {
        Id = id;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;

    }
}
