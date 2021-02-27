using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosCap10_12.Capitulo_10.Clases
{
    public class Poligonos
    {
        private float Longitudlados;
        private float apotema;
        public float LongitudLados
        {
            get
            {
                return Longitudlados;
            } 

            set
            { 
                if (value <= 0)
                    Longitudlados = 1;
                else
                    Longitudlados = value;
            } 
        }

        public float Apotema
        {
            get
            {
                return apotema;
            }

            set
            {
                if (value <= 0)
                    apotema = 1;
                else
                    apotema = value;
            }
        }

        public Poligonos(float lados, float apotema2)
        {
            Longitudlados = lados;
            apotema = apotema2;
        }

        public float CalcularPerimetro()
        {
            return (Longitudlados * 6);
        }

        public float CalcularArea()
        {
            return ((CalcularPerimetro() * apotema) / 2);
        }

        public string TOString()
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendFormat($"Perimetro: {CalcularPerimetro()} \nArea: {CalcularArea()}");
            return (informacion.ToString());
        }
    }
}
