using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;



namespace Negocio.Business
{
    class GerenciadorConvite
    {
        private repositorioConvite persistencia;

        public GerenciadorConvite()
        {
            persistencia = new repositorioConvite();
        }

    }
}
