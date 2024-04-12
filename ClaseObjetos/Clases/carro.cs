using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public int parqueao = 1;
        public int  patras= 0;
        public int quieto = 0;
        public int Dlante = 0;
       
        //encender luces
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
            if (encendido == 0 || quieto==1)
            {
                return 0;
            }

            if (velocidad_actual == Maxvelocidad)
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
            if (encendido == 0 )
            {
                return 0;
            }
            velocidad_actual = velocidad_actual - 5;

            if (velocidad_actual <= 0)
            {
                return 0;
            }

            return velocidad_actual;
        }

        public int frenar()
        {
            if (encendido == 0)
            {
                return 0;
            }

            velocidad_actual -= 20;

            if (velocidad_actual <= 0)
            {
                return 0;
            }

            return velocidad_actual;
        }

        public void Marcha_Atras()
        {
            if (encendido == 1 && patras==1)
            {
                acelerar();
            }
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
            if (encendido != 0 && parqueao==1)
            {
                encendido = 0;
            }
        }

        public void Parking()
        {
            if (parqueao == 0)
            {
                parqueao = 1;
            }
        }

        public void Reversa()
        {
            if (patras == 0)
            {
                patras = 1;
            }
            
        }

        public void Neutro()
        {
            if (quieto == 0)
            {
                quieto = 1;
            }
        }

        public void Delante()
        {
            if (Dlante == 0)
            {
                Dlante = 1;
            }
        }

        public void CajaCambios(string cambio)
        {
            if (velocidad_actual == 0 && encendido == 1)
            {
                switch (cambio)
                {
                    case "P":
                        Parking();
                        break;

                    case "R":
                        Reversa();
                        break;

                    case "N":
                        Neutro();
                        break;

                    case "D":
                        Delante();
                        break;
                }
            }
            else
            {
                //**Explota la caja de cambios**
            }
        }




    }
}


