namespace TechStoreMVC.Models;

public class ProdutosDB
 
 // Passo 01 - Criar/trazer os dados de produtos de Controller
 // Método q vai listar nossos objetos de um produto
 // e armazená-los na variável produtos
{
    private static readonly List<Produto> produtos = new()
{
            
                new Produto(1, "Mouse Gamer", 129.9m, 10),
                new Produto(2, "Teclado Mecânico", 249.9m, 5),
                new Produto(3, "Monitor 24 polegadas", 899.9m, 8),
                new Produto(4, "Headset Gamer", 179.9m, 15),
                
    };
    // Passo 02 - criar os metodos de CRUD e remover toda regra de negócio de Controll
    // Responsabilidade do Listar: Devolve/ Mostra todos os produtos. Igual ao Index
    // Controller
    public List<Produto> Listar()
    {
        return produtos;
    }
    public Produto? buscarPorId(int id)
    {
        return produtos.FirstOrDefault(
            produto => produto.Id == id
        );
    }
    public void Adicionar(Produto produto)
    {
        produto.Id = produtos.Count + 1;
        produtos.Add(produto);
    }
public bool Atualizar(Produto produtoAtualizado)
    {
        Produto? produtoExistente =
        buscarPorId(produtoAtualizado.Id);
    
        if(produtoExistente is null)
        return false;

        produtoExistente.Nome = produtoAtualizado.Nome;
        produtoExistente.Preco = produtoAtualizado.Preco;
        produtoExistente.Estoque = produtoAtualizado.Estoque;
        return true;
    }

    public bool Excluir(int Id)
    {
        Produto? produto = buscarPorId(Id);
        if(produto is null)
        return false;
        produtos.Remove(produto);

        return true;
    }
}