using System;
using System.Collections.Generic;
using Projeto_Roman.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using Projeto_Roman.Domains;
using Projeto_Roman.Contexts;

namespace Projeto_Roman.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        Roman ctx = new Roman();

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuario = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuario);

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
