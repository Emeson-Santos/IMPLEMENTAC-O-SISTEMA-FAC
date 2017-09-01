
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

        public Servico(string descricao, int id)
        {
            this.id = id;
            this.descricao = descricao;
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

    }
}
