    namespace Projeto_Vendinha.Models
    {
        public class Cliente
        {
            public int Id { get; set; }
            public string NomeCompleto { get; set; } = "";
            public string CPF { get; set; } = "";
            public DateTime DataNascimento { get; set; }
            public string? Email { get; set; } //o ponto de interrogação é por causa que é opcional se o cliente quer ou nao adicionar um email, se nao quiser fica null
        }
    }