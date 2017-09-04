
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class TipoEvento
    {

        private int id;
        private string descricao;
        private List<Servico> servicosAssociados;

        public TipoEvento(string descricao =null)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.ServicosAssociados = ServicosAssociados;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
          get { return descricao; }
          set { descricao = value; }
        }

        public List<Servico> ServicosAssociados
        {
            get { return servicosAssociados; }
            set { servicosAssociados = value; }
        }
    }
}