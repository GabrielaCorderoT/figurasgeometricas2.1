using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Cubo:Figura
    {
        //usamos el constructor de la clase padre 
        public Cubo(float lado1)
        {
            //radio se va a leer de la caja de texto con el boton guardar
            Lado1 = lado1;
        }

        //se crea la variante arista para obtener el perimetro del cubo 
        private float arista;
        //crear un constructor para cubo
        public float Arista
        {
            set
            {
                //pregunta si la arista <0
                if (value < 0)
                {
                    Arista = 0; //manda el valor a 0 
                    //NO EXISTEN NEGATIVOS
                }
                else
                {
                    arista = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return arista; //regresa o cacha el valor de la variable arista
            }
        }
        //vamos a usar los metodos de la clase padre 
        //vamos a sobreescribir el comportamiento de estos 
        public override float area()
        {
            return Lado1 * 6;

        }
        public override float perimetro()
        {
            return Arista * 12;
        }

        public override float volumen()
        {
            return Lado1 * Lado1 * Lado1;
        }
    }
}
