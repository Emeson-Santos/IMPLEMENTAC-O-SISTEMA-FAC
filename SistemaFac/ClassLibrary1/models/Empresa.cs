
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
         * id
         * razaoSocial
         * rua 
         * bairro
         * cep
         * numero
         * cidade
         * uf
         * telefone
         * email
         * imagem
         * eventosFornecidos
         * login
         * senha
         * isPrestadorServico
         * receberFeedback
         * receberListaPresentes
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
    
    public Empresa(string razaoSocial = null, string rua = null, string bairro)
        {
        }

        /**
         * 
         */
        public int Id;

        /**
         * 
         */
        public string RazaoSocial;

        /**
         * 
         */
        public string Rua;

        /**
         * 
         */
        public string Bairro;

        /**
         * 
         */
        public int Cep;

        /**
         * 
         */
        public int Numero;

        /**
         * 
         */
        public string Cidade;

        /**
         * 
         */
        public string UF;

        /**
         * 
         */
        public int Telefone;

        /**
         * 
         */
        public string Email;

        /**
         * 
         */
        public byte Imagem;

        /**
         * 
         */
        public List<TipoEvento> EventosFornecidos;

        /**
         * 
         */
        public string Login;

        /**
         * 
         */
        public string Senha;

        /**
         * 
         */
        public bool IsPrestadorServico;

        /**
         * 
         */
        public List<Feedback> ReceberFeedback;

        /**
         * 
         */
        public List<ListaPresentes> ReceberListaPresentes;




    }
}
