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
    public class EquipeController : ControllerBase
    {
        private IEquipeRepository _projeto { get; set; }

        public EquipeController()
        {
            _projeto = new EquipeRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_projeto.Listar());
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _projeto.Deletar(id);
            
            return StatusCode(204);
        }

        [HttpPost]
        public IActionResult Cadastrar(Equipe equipe)
        {
            _projeto.Cadastrar(equipe);

            return StatusCode(202);
        }
    }
}
