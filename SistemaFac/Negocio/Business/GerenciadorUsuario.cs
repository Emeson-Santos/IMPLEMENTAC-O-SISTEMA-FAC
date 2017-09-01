using System;
using System.Collections.Generic;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
  public  class GerenciadorUsuario
    {
        private repositorioUsuarios persistencia;

        public GerenciadorUsuario()
        {
            persistencia = new repositorioUsuarios();
        }

        public Usuario  Adicionar(Usuario usuario)
        {
            persistencia.Adicionar(usuario);
            return usuario;
        }

        public void Editar(Usuario usuario)
        {
            persistencia.editar(usuario);
        }

        public void Remover(Usuario usuario)
        {
            persistencia.remover(usuario);
        }

        public Usuario Obter(int id)
        {
            return persistencia.Obter(u => u.Id == id);
        }

        public List<Usuario> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
