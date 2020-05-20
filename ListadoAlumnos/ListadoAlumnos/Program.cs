using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudiantesController est = new EstudiantesController();
            //est.ListarEstudiantes();
            est.AlumnosInicialesLG();
            Console.ReadKey();
        }
    }
}
