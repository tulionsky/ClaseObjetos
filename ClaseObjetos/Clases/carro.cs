using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos.Clases
{
    internal class carro
    {
        public string Marca { get; }
        public string Transmision { get; }
        public int Año { get; }
        public int Capacidad_pasajeros { get; }
        public string Modelo { get; }
        public string Color { get; set; }
        public string Marca_llanta { get; set; }
        public string Marca_radio { get; set; }
        public string Altura_suspension { get; set; }

        public string Owner { get; set; }

        public int encendido = 0;
        private int arranque = 0;
        private bool freno = false;
        
        //Frenado
        //Marcha atras
        //desaceleracion
        //giro
        //encendido de radio
        //encendido aire
        //colocar seguro
        public int velocidad_inicial { get; }
        public int velocidad_actual = 0;
        public int Maxvelocidad { get; set; }


        public carro(string m, int año, string t, string model, int capacidad, int VelMax)
        {
            Marca = m;
            Año = año;
            Transmision = t;
            Modelo = model;
            Capacidad_pasajeros = capacidad;
            Maxvelocidad = VelMax;
            velocidad_inicial = 0;
        }
        public int acelerar()
        {
            if (encendido == 0)
            {
                return 0;
            }

            if (velocidad_actual >= Maxvelocidad)
            {
                return velocidad_actual;
            }

            velocidad_actual += 10;

            if (velocidad_actual > Maxvelocidad)
            {
                velocidad_actual = Maxvelocidad;
            }

            return velocidad_actual;
        }

        public int desacelerar()
        {
            if (encendido == 0)
            {
                return 0;
            }

            if (velocidad_actual == 0)
            {
                return 0;
            }

            velocidad_actual = velocidad_actual - 5;

            return velocidad_actual;
        }

        public int frenar()
        {
            if (encendido == 0)
            {
                return 0;
            }

            if (velocidad_actual <= 0)
            {
                return 0;
            }

            velocidad_actual -= 20;

            return velocidad_actual;
        }

        
        public int encender()
        {
            if (encendido != 1)
            {
                encendido = 1;
            }
            return encendido;
        }
        public void apagar()
        {
            if (encendido != 0)
            {
                encendido = 0;
            }
        }






    }
}


