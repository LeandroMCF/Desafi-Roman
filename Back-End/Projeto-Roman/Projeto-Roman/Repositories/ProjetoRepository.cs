using System;
using System.Collections.Generic;
using Projeto_Roman.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Roman.Domains;
using Projeto_Roman.Contexts;

namespace Projeto_Roman.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        Roman ctx = new Roman();

        public void Cadastrar(Projeto novoProjeto)
        {
            ctx.Projetos.Add(novoProjeto);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto projeto = ctx.Projetos.Find(id);

            ctx.Projetos.Remove(projeto);

            ctx.SaveChanges();
        }

        public List<Projeto> Listar()
        {
            return ctx.Projetos.ToList();
        }
    }
}
