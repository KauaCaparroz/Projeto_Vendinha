namespace Projeto_Vendinha.Models
{
    public class Divida
    {
        // Identificador da dívida
        public int Id { get; set; }

        // Valor da dívida
        public decimal Valor { get; set; }

        // Indica se a dívida foi paga
        public bool Paga { get; set; }

        // Data de criação da dívida
        public DateTime DataCriacao { get; set; }

        // Data do pagamento, se já foi paga
        public DateTime? DataPagamento { get; set; }

        // Identificador do cliente
        public int ClienteId { get; set; }

        // Cliente relacionado à dívida
        public Cliente? Cliente { get; set; }// o porque do ? em ciliente é que Permite que os dados completos do cliente fiquem nulos
                                             // quando ainda não forem carregados pelo sistema pois antes de puxar todas as informações do cliente é puxado o id que contem apenas o numero e quem é.
    }
}

