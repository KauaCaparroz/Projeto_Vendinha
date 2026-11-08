using Microsoft.AspNetCore.Mvc;
using Projeto_Vendinha.Data;

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
    }
}