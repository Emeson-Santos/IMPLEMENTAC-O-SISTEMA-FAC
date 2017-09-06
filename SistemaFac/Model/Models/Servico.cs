
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{

    public class Servico
    {

        private int id;
        private string descricao;

        public Servico(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }
        public Servico(string descricao)
        {
            this.descricao = descricao;
        }

        public Servico() : this(0, null) { }

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

    }
}
