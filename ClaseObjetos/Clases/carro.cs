using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos.Clases
{
    public class carro
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
        public bool luces_encendidas = false;
        public bool radio_encendida = false;
        public bool aire_acondicionado_encendido = false;
        public bool seguro_activado = false;

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

        public int arrancar()
        {
            if (encendido == 1 || arranque!=1)
            {
                arranque = 1;
            }
            return arranque;
        } 
        public int acelerar()
        {
            if (arranque == 0 || quieto==1)
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
            if (arranque == 0 )
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
            if (arranque == 0)
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
            if (arranque == 1 && patras==1)
            {
                acelerar();
            }
        }

        public void Driving()
        {
            if (arranque == 1 && Dlante == 1)
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
            patras = 0;
            Dlante = 0;
            quieto = 0;
            if (parqueao == 0)
            {
                parqueao = 1;
            }
        }

        public void Reversa()
        {
            parqueao = 0;
            Dlante = 0;
            quieto = 0;
            if (patras == 0)
            {
                patras = 1;
            }
            
        }

        public void Neutro()
        {
            patras = 0;
            Dlante = 0;
            parqueao = 0;
            if (quieto == 0)
            {
                quieto = 1;
            }
        }

        public void Delante()
        {
            patras = 0;
            parqueao = 0;
            quieto = 0;
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

        public void EncenderLuces()
        {
            if (encendido == 1)
            {
                luces_encendidas = true;
            }
        }

        public void ApagarLuces()
        {
            luces_encendidas = false;
        }

        public void EncenderRadio()
        {
            if (encendido == 1)
            {
                radio_encendida = true;
            }
        }

        public void ApagarRadio()
        {
            radio_encendida = false;
        }

        public void EncenderAire()
        {
            if (encendido == 1)
            {
                aire_acondicionado_encendido = true;
            }
        }

        public void ApagarAire()
        {
            aire_acondicionado_encendido = false;
        }

        public void ActivarSeguro()
        {
            if (encendido == 1 && velocidad_actual == 0)
            {
                seguro_activado = true;
            }
        }

        public void DesactivarSeguro()
        {
            seguro_activado = false;
        }

    }
}


