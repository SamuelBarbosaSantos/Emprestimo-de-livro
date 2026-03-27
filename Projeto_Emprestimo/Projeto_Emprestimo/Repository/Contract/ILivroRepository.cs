using Projeto_Emprestimo.Models;

namespace Projeto_Emprestimo.Repository.Contract
{
    public interface ILivroRepository
    {
        //CRUD
        IEnumerable <Livro> ObterTodosLivros();
        void Cadastrar(Livro livro);
        void Atualizar(Livro livro);    
        Livro ObterLivros(int Id);
        void Excluir(int Id);


    }
}
