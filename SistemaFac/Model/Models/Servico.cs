
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        [Column(Order =1)]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage =" Obrigadorio que voce informer a Descrição do seu Servivo ")]
        [StringLength(1000,ErrorMessage ="No maximo 1000 Caracterios")]
        [Display(Name = "Descrição Completa")]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
