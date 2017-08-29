
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * @author EMESON SANTOS
 */
 namespace Model.models
{
    public class Empresa
    {

        /**
         * 
         * 
         */
        private int id;
        private string razaoSocial;
        private string rua;
        private string bairro;
        private int cep;
        private int numero;
        private string cidade;
        private string uf;
        private int telefone;
        private string email;
        private byte imagem;
        private List<TipoEvento> eventosFornecidos;
        private string login;
        private string senha;
        private bool isPrestadorServico;
        private List<Feedback> receberFeedback;
        private List<ListaPresentes> receberListaPresentes;
    
    public Empresa(int id, string razaoSocial)
        {
            this.id = id;
            this.razaoSocial = razaoSocial;
           
        }
        public Empresa(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }
        public Empresa() : this(0,null)
        {
            
        }
        /**
         * 
         */
        public int Id
        {
            get { return id; }
            set { id = value;}
        }

        /**
         * 
         */
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        /**
         * 
         */
        public string Rua
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        /**
         * 
         */
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        /**
         * 
         */
        public int Cep
        {
            get { return cep; }
            set { cep = value; }

        }

        /**
         * 
         */
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        /**
         * 
         */
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
            
        /**
         * 
         */
        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        /**
         * 
         */
        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        /**
         * 
         */
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /**
         * 
         */
        public byte Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }

        /**
         * 
         */
        public List<TipoEvento> EventosFornecidos
        {
            get { return eventosFornecidos; }
            set { eventosFornecidos = value; }
        }

        /**
         * 
         */
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        /**
         * 
         */
        public string Senha
        {
            get { return senha; }
            set { senha = value; }

            /**
             * 
             */
        }
        public bool IsPrestadorServico
        {
            get { return isPrestadorServico; }
            set { isPrestadorServico = value; }
        }
           
        

        /**
         * 
         */
        public List<Feedback> ReceberFeedback
        {
            get { return receberFeedback; }
            set { receberFeedback = value; }
        }

        /**
         * 
         */
        public List<ListaPresentes> ReceberListaPresentes
        {
            get { return receberListaPresentes; }
            set { receberListaPresentes = value; }
        }
    }
}
