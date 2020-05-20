using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoAlumnos
{
    class EstudiantesModel
    {
        public int COD { get; set; }
        public int CARNET { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string MATERIA { get; set; }
        public double NOTA { get; set; }
        public int EDAD { get; set; }
    }
}
