using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    class repositorioConvite
    {
        private static List<Convite> ListaConvite;

        static repositorioConvite()
        {
            ListaConvite = new List<Convite>();
        }

        public Convite Adicionar ( Convite convite)
        {
            convite.Confirmado = ListaConvite;
            ListaConvite.Add(convite);
            return convite;
        }
    }
}
