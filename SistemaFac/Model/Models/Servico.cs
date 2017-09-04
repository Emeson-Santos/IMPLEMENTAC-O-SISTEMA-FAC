
using System.ComponentModel.DataAnnotations;


namespace Model.Models
{

    public class Servico
    {

        private int id;
        private string descricao;

        public Servico(string descricao, int id)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        public Servico()
        {
            this.Id = id;
            this.Descricao = descricao;
        }
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required(ErrorMessage =" Obrigadorio que voce informer a Descri��o do seu Servivo ")]
        [StringLength(1000,ErrorMessage ="No maximo 1000 Caracterios")]
        [Display(Name = "Descri��o Completa")]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
