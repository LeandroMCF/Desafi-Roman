using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Roman.Domains;
using Projeto_Roman.Interfaces;
using Projeto_Roman.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Roman.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private IProjetoRepository _projeto { get; set; }

        public ProjetoController()
        {
            _projeto = new ProjetoRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projeto.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Projeto novoProjeto)
        {
            _projeto.Cadastrar(novoProjeto);

            return StatusCode(202);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _projeto.Deletar(id);

            return StatusCode(204);
        }
    }
}
