using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazGraficaCarro.Clases
{
    public class Carro
    {
        public string Marca { get; }
        public int Modelo { get; }

        public String Color { get; set; }

        private int Encendido = 0;
        private int Apagado = 0;
        private int velocidad_actual = 0;
        public int MAXVELOCIDAD { get; }
        private const int MINVELOCIDAD = 0;





        //CONSTRUCTOR
        public Carro(string _marca, int _modelo, string _color, int _MAXVEL)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            MAXVELOCIDAD = _MAXVEL;
            Encendido = 0;
            this.velocidad_actual = 0;
        }



        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $" ->El carro esta apagado, asi no se puede";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += 12;
                mensaje = $" El carro va a: {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = " -> Aguas, vas a maxima velocidad, rapido y furioso???";
            }

            //return mensaje;
            return mensaje;

        }


        public string Acelerar(int AcekerarAkph)
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += AcekerarAkph;
                mensaje = $"vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
            }

            //Console.WriteLine(mensaje);
            return mensaje;

        }



        public string GetVelocidadActual()
        {
            if (velocidad_actual <= 0)
            {
                velocidad_actual = 0;
            }
            return $" --> Atento vamos a : {velocidad_actual} KPH";
        }


        public String EncenderMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                return "\t---> Brururururururu el carro está encendido!!! <---";
                velocidad_actual = 0;

            }
            else
            {
                return "\tups el carro ya estaba encendido";
            }
        }

        public string Desacelerar()
        {

            string mensaje = "";
            if (velocidad_actual > MINVELOCIDAD)
            {
                velocidad_actual -= 12;
                mensaje = $" -> Desaceleraste a : {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MINVELOCIDAD;
                mensaje = " ->Aguas!, Ya no puedes desacelerar más..";
            }
           // Console.WriteLine(mensaje);
            return mensaje;
        }

        public string Desacelerar(int desacelerarAkph)
        {


            string mensaje = "";
            if (velocidad_actual > MINVELOCIDAD)
            {
                velocidad_actual += desacelerarAkph;
                mensaje = $"vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MINVELOCIDAD;
                mensaje = " ->Aguas!, Ya no puedes desacelerar más..";
            }

            //Console.WriteLine(mensaje);
            return mensaje;

        }

        public String FrenadoNormal()
        {
            String mensaje = "";

            velocidad_actual -= 24;
            mensaje = "\t->Has frenado";
            if (velocidad_actual < 0)
            {
                return "\t->El carro ya esta parado!";
            }

           // Console.WriteLine(mensaje);
            return mensaje;
        }

        public String Frenado_total()
        {
            String mensaje = "";
            velocidad_actual -= velocidad_actual;
            mensaje = "\t Ojoo! Has frenado bruscamente!!!";

           // Console.WriteLine(mensaje);
            return mensaje;

        }

        public string ApagarMotor()
        {
            if (Apagado == 0)
            {
                Apagado = 1;
                return "\t---> Psssttt El motor está apagado <---";
                velocidad_actual = 0;

            }
            else
            {
                return"\t---> Eyyy Ya has apagado el motor!!!";
            }
        }

        public string Claxón()
        {
            return " ***PIIIII PIIIIIIIII*** (BOCINA)";
        }


        public string DameInformacion()
        {
            return $" MARCA DEL CARRO: {Marca}  MODELO DEL CARRO: {Modelo}  COLOR DEL CARRO: {Color}";

        }



    }
}

