
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class TipoEvento
    {

        private int id;
        private string descricao;
        private List<Servico> servicosAssociados;

        public TipoEvento(string descricao =null)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.ServicosAssociados = servicosAssociados;
        }

        public TipoEvento()
        {
            this.Id = id;
            this.Descricao = descricao;
            this.ServicosAssociados = servicosAssociados;
        }

        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage ="Descri�ao do tipo de Servico")]
        [StringLength(1000,ErrorMessage ="Numero Maximoq 1000 de Caracter ")]
        [Display(Name ="Descri��o")]
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