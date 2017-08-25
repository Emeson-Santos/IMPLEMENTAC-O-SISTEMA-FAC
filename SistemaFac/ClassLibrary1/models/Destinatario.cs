
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * @author EMESON SANTOS
 */
    namespace Model.models
{
    public class Destinatario
    {

        /**
         * 
         */
        private int id;
        private string email;


    
    public Destinatario( string email = null)
        {
            this.email = email;

        }

        /**
         * 
         */
        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        /**
         * 
         */
        public string Email {
            get { return email; }
            set { email = value; }
        }


    }
}
    