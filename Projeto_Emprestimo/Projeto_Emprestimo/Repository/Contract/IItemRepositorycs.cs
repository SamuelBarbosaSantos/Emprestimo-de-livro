using Projeto_Emprestimo.Models;

namespace Projeto_Emprestimo.Repository.Contract
{
    public interface IItemRepository
    {

        //CRUD
        IEnumerable<Itens> ObterTodosItens();
        void Cadastrar(Itens item);
        void Atualizar(Itens item);
        Itens ObterItens(int Id);
        void Excluir(int Id);
    }
}
