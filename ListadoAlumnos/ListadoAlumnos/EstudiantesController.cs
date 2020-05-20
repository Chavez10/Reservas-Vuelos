using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoAlumnos
{
    class EstudiantesController
    {
        EstudiantesModel est = new EstudiantesModel();
        
        public EstudiantesController()
        {
            
    }

        public void ListarEstudiantes()
        {
            string[,] lista =
           {
                { Convert.ToString(est.COD = 1), Convert.ToString(est.CARNET = 171721011), est.NOMBRES = "Javier Ignacio", est.APELLIDOS = "Molina Cano", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 7.0), Convert.ToString(est.EDAD = 28)  },
                { Convert.ToString(est.COD = 2), Convert.ToString(est.CARNET = 171723012), est.NOMBRES = "Lillian Eugenia", est.APELLIDOS = "Gomez Alvarez", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 10), Convert.ToString(est.EDAD = 33) },
                { Convert.ToString(est.COD = 3), Convert.ToString(est.CARNET = 179725013), est.NOMBRES = "Sixto Naranjoe", est.APELLIDOS = "Marin", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 8.6), Convert.ToString(est.EDAD = 15) },
                { Convert.ToString(est.COD = 4), Convert.ToString(est.CARNET = 175722014), est.NOMBRES = "Gerardo Emilio", est.APELLIDOS = "Duque Guitierrez", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 10), Convert.ToString(est.EDAD = 13) },
                { Convert.ToString(est.COD = 5), Convert.ToString(est.CARNET = 173726015), est.NOMBRES = "Jhony Alberto", est.APELLIDOS = "Saenz Hurtado", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 9.5), Convert.ToString(est.EDAD = 15) },
                { Convert.ToString(est.COD = 6), Convert.ToString(est.CARNET = 1777230161), est.NOMBRES = "German Antonio", est.APELLIDOS = "Lotero Upegui", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 8.0), Convert.ToString(est.EDAD = 34) },
                { Convert.ToString(est.COD = 7), Convert.ToString(est.CARNET = 1239341245), est.NOMBRES = "Oscar Dario", est.APELLIDOS = "Murillo Gonzalez", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 8.0), Convert.ToString(est.EDAD = 32) },
                { Convert.ToString(est.COD = 8), Convert.ToString(est.CARNET = 1248302134), est.NOMBRES = "Augusto Osorno", est.APELLIDOS = "Palacio Martinez", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 9.5), Convert.ToString(est.EDAD = 17) },
                { Convert.ToString(est.COD = 9), Convert.ToString(est.CARNET = 1235749023), est.NOMBRES = "Cesar Oswaldo", est.APELLIDOS = "Alzate Agudelo", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 8.0), Convert.ToString(est.EDAD = 26) },
                { Convert.ToString(est.COD = 10), Convert.ToString(est.CARNET = 847392732), est.NOMBRES = "Gloria Amparo", est.APELLIDOS = "Gonzalez Castaño", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 10), Convert.ToString(est.EDAD = 28) },
                { Convert.ToString(est.COD = 11), Convert.ToString(est.CARNET = 428028332), est.NOMBRES = "Jorge Leon", est.APELLIDOS = "Ruiz Ruiz", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 8.0), Convert.ToString(est.EDAD = 22) },
                { Convert.ToString(est.COD = 12), Convert.ToString(est.CARNET = 193483234), est.NOMBRES = "John Jairo", est.APELLIDOS = "Duque Garcia", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 9.4), Convert.ToString(est.EDAD = 32) },
                { Convert.ToString(est.COD = 13), Convert.ToString(est.CARNET = 384902931), est.NOMBRES = "Julio Cesar", est.APELLIDOS = "Gonzalez Castaño", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 10), Convert.ToString(est.EDAD = 22) },
                { Convert.ToString(est.COD = 14), Convert.ToString(est.CARNET = 183934023), est.NOMBRES = "Gabriel Jaime", est.APELLIDOS = "Rodas Monsalve", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 7.0), Convert.ToString(est.EDAD = 18) },
                { Convert.ToString(est.COD = 15), Convert.ToString(est.CARNET = 918238493), est.NOMBRES = "Gloria Amparo", est.APELLIDOS = "Jimenez Gomez", est.MATERIA = "Programacion III", Convert.ToString(est.NOTA = 10), Convert.ToString(est.EDAD = 18) }
            };

            var alumnos = (
                from string a in lista select a
                ).ToArray();

            foreach (var item in alumnos)
            {
                
                Console.WriteLine(" | " + item);
            }
        }

        public void AlumnosInicialesLG()
        {
            var lista = new List<EstudiantesModel>
           {
                new EstudiantesModel { COD = 1, CARNET = 171721011, NOMBRES = "Javier Ignacio", APELLIDOS = "Molina Cano", MATERIA = "Programacion III", NOTA = 7.0, EDAD = 28  },
                new EstudiantesModel { COD = 2,  CARNET = 171723012, NOMBRES = "Lillian Eugenia", APELLIDOS = "Gomez Alvarez", MATERIA = "Programacion III", NOTA = 10,     EDAD = 33 },
                new EstudiantesModel { COD = 3,  CARNET = 179725013, NOMBRES = "Sixto Naranjoe", APELLIDOS = "Marin", MATERIA = "Programacion III", NOTA = 8.6,             EDAD = 15 },
                new EstudiantesModel { COD = 4,  CARNET = 175722014, NOMBRES = "Gerardo Emilio", APELLIDOS = "Duque Guitierrez", MATERIA = "Programacion III", NOTA = 10,   EDAD = 13 },
                new EstudiantesModel { COD = 5,  CARNET = 173726015, NOMBRES = "Jhony Alberto", APELLIDOS = "Saenz Hurtado", MATERIA = "Programacion III", NOTA = 9.5,      EDAD = 15 },
                new EstudiantesModel { COD = 6,  CARNET = 1777230161, NOMBRES = "German Antonio", APELLIDOS = "Lotero Upegui", MATERIA = "Programacion III", NOTA = 8.0,    EDAD = 34 },
                new EstudiantesModel { COD = 7,  CARNET = 1239341245, NOMBRES = "Oscar Dario", APELLIDOS = "Murillo Gonzalez", MATERIA = "Programacion III", NOTA = 8.0,    EDAD = 32 },
                new EstudiantesModel { COD = 8,  CARNET = 1248302134, NOMBRES = "Augusto Osorno", APELLIDOS = "Palacio Martinez", MATERIA = "Programacion III", NOTA = 9.5, EDAD = 17 },
                new EstudiantesModel { COD = 9,  CARNET = 1235749023, NOMBRES = "Cesar Oswaldo", APELLIDOS = "Alzate Agudelo", MATERIA = "Programacion III", NOTA = 8.0,    EDAD = 26 },
                new EstudiantesModel { COD = 10, CARNET = 847392732, NOMBRES = "Gloria Amparo", APELLIDOS = "Gonzalez Castaño", MATERIA = "Programacion III", NOTA = 10,    EDAD = 28 },
                new EstudiantesModel { COD = 11, CARNET = 428028332, NOMBRES = "Jorge Leon", APELLIDOS = "Ruiz Ruiz", MATERIA = "Programacion III", NOTA = 8.0,             EDAD = 22 },
                new EstudiantesModel { COD = 12, CARNET = 193483234, NOMBRES = "John Jairo", APELLIDOS = "Duque Garcia", MATERIA = "Programacion III", NOTA = 9.4,          EDAD = 32 },
                new EstudiantesModel { COD = 13, CARNET = 384902931, NOMBRES = "Julio Cesar", APELLIDOS = "Gonzalez Castaño", MATERIA = "Programacion III", NOTA = 10,      EDAD = 22 },
                new EstudiantesModel { COD = 14, CARNET = 183934023, NOMBRES = "Gabriel Jaime", APELLIDOS = "Rodas Monsalve", MATERIA = "Programacion III", NOTA = 7.0,     EDAD = 18 },
                new EstudiantesModel { COD = 15, CARNET = 918238493, NOMBRES = "Gloria Amparo", APELLIDOS = "Jimenez Gomez", MATERIA = "Programacion III",  NOTA = 10,      EDAD = 18 }
            };

            var nombresL = lista.Where(x => x.NOMBRES.StartsWith("L")).ToList().ToString();
            var nombresG = lista.Where(x => x.NOMBRES.StartsWith("G")).ToList().ToString();
            foreach (var item in nombresL)
            {
                Console.WriteLine(item);
            }
            foreach (var item in nombresG)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
