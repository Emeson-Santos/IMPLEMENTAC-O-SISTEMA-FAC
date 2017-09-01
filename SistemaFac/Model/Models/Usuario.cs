
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string rua;
        private int cep;
        private string bairro;
        private DateTime datanascimento;
        private string email;
        private char sexo;
        private string cpf;
        private int rg;
        private int numero;
        private string uf;
        private string login;
        private string senha;
        private int contconvidadosconf;
        private List<Convite> listaconvite;
        private List<Feedback> enviarfeedback;
        private List<ListaPresentes> enviarlistapresentes;

        public Usuario( int id,string nome)
        {
            this.nome = nome;
            this.id = id;
        }

        public Usuario(string nome)
        {
            this.nome = nome;
        }

        public Usuario() : this(0, null)
        { }

        #region Propriedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string CPF
         {
            get { return cpf; }
            set { cpf = value; }
        }

        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }
    
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int QuantConvidadosConf
        {
            get { return contconvidadosconf; }
            set { contconvidadosconf = value; }
        }

        public List<Convite> ListaConvites
        {
            get { return listaconvite; }
            set { listaconvite = value; }
        }

        public List<Feedback> EnviarFeedback
        {
            get { return enviarfeedback; }
            set { enviarfeedback = value; }
        }

        public List<ListaPresentes> EnviarListaPresentes
        {
            get { return enviarlistapresentes; }
            set { enviarlistapresentes = value; }
        }

        # endregion



    }


}