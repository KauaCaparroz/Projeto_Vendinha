using Microsoft.AspNetCore.Mvc;
using Projeto_Vendinha.Data;
using Projeto_Vendinha.Models;

//prepara o Controller para receber pedidos e acessar o banco.
namespace Projeto_Vendinha.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly VendinhaContext banco;

        public ClientesController(VendinhaContext context)
        {
            banco = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var clientes = banco.Clientes.ToList();//pegue todos os clientes do banco e coloque em uma lista
            return Ok(clientes); //devolva essa lista para quem pediu.
        }

        [HttpPost]// Indica que essa função recebe dados para cadastrar um cliente
        public IActionResult Cadastrar(Cliente cliente)// Função que recebe as informações do cliente
        {

            if (banco.Clientes.Any(c => c.CPF == cliente.CPF))
                // Verifica se já existe um cliente com o mesmo CPF 
                //c representa cada cliente da lista
                //c.CPF é o CPF do cliente que está sendo verificado
                //ANNY Verifica se já existe um CPF igual

            {
                return BadRequest("Esse CPF já está cadastrado!");// Se o CPF já existir, impede o cadastro
            }

            banco.Clientes.Add(cliente);// Adiciona o cliente ao banco de dados

            banco.SaveChanges();// Salva as informações no banco

            return Ok("Cliente cadastrado com sucesso!");// Retorna uma mensagem confirmando o cadastro
        }
    }
}