using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using U2_Act5.Models;

namespace U2_Act5.Services
{
    public class ClaseService
    {
        public List<Clase> Clases { get; set; }

        public ClaseService()
        {
            using (animalesContext context = new animalesContext())
            {
                Clases = context.Clase.OrderBy(x => x.Nombre).ToList();
            }
        }
    }
}
