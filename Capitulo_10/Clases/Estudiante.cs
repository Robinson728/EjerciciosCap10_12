using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCap10_12.Capitulo_10.Clases
{
    public class Estudiantes
    {
        public int Matricula { get; set; }
        public string NombreCompleto { get; set; }
        public string Carrera { get; set; }
        public int Semestre { get; set; }
        public float Indice { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Estudiantes()
        {
            Matricula = 0;
            NombreCompleto = string.Empty;
            Carrera = string.Empty;
            Semestre = 0;
            Indice = 0;
            Telefono = string.Empty;
            FechaNacimiento = DateTime.Now;
        }
    }
}
