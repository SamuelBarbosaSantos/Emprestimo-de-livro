namespace Projeto_Emprestimo.Models
{
    public class Itens
    {
        public Guid ItemPedidoId { get; set; }
        
        public int codEmp { get; set; }
        public string codLivro { get; set; }

        public string nomeLivro { get; set; }
        public string imagem { get; set; }
        public string quantidade { get; set; }
    }
}
