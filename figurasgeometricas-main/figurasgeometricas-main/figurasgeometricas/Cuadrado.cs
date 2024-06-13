using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Cuadrado:Figura
    {
        //esta clase requiere dos lados para funcionar 
        //creamos el lado2
        private float lado2;
        //crear un constructor para cuadrado
        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a 0 
                    //NO EXISTEN LADOS NEGATIVOS
                }
                else
                {
                    lado2 = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return lado2; //regresa o cacha el valor de la variable lado2
            }
        }
        //usamos el constructor de la clase padre 
        public Cuadrado(float lado1, float lado2, float lado3, float lado4)
        {
            //lado1 y lado2 se van a leer de la caja de texto
            //usando el boton guardar 
            this.Lado1 = lado1; //hace que unicamente el valor, la cantidad del lado sea 
                                //sea disponible para la clase CUADRADO, cuando no se 
                                //use la CUADRADO la variable sera 0
            this.Lado2 = lado2;

            this.Lado3 = lado3;

            this.Lado4 = lado4;



        }
        //esta clase requiere cuatro lados para funcionar 
        //creamos primero el lado3
        private float lado3;
        //crear un constructor para cuadrado
        public float Lado3
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado3 = 0; //manda el valor a 0 
                    //NO EXISTEN LADOS NEGATIVOS
                }
                else
                {
                    lado3 = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return lado3; //regresa o cacha el valor de la variable lado3
            }
        }

        //esta clase requiere cuatro lados para funcionar 
        //creamos el lado4
        private float lado4;
        //crear un constructor para cuadrado
        public float Lado4
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado4 = 0; //manda el valor a 0 
                    //NO EXISTEN LADOS NEGATIVOS
                }
                else
                {
                    lado4 = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return lado4; //regresa o cacha el valor de la variable lado4
            }
        }

        //vamos a usar los metodos de la clase padre 
        //vamos a sobreescribir el comportamiento de estos 
        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return Lado1 + Lado2 + Lado3 + Lado4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT 
        }
    }
}
