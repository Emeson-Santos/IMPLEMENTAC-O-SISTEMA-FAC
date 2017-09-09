
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
            this.Id = id;
            this.Descricao = descricao;
        }
<<<<<<< HEAD

        public Servico(string descricao)
        {
            this.Descricao = descricao;
        }

        public Servico() : this(0, null) { }
        
        
=======
        public Servico(string descricao)
        {
            this.descricao = descricao;
        }

        public Servico() : this(0, null) { }

>>>>>>> 5aaaf1e55a285aeeb9aa7d5a1b8e093fe8f45706
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
