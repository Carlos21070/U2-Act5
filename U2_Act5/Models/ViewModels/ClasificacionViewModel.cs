using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace U2_Act5.Models.ViewModels
{
    public class ClasificacionViewModel
    {
        public int NumImg { get; set; }
        public IEnumerable<Models.Clase> Clasificacion { get; set; }
    }
}
