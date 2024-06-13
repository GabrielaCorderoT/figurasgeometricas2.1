using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    abstract class Figura //clase padre
    {
        //clase que permite el ingreso de un lado, para poder crear una nueva figura
        //geometrica recuerda que una figura para existrir require minimo un lado
        //esta clase es tipo abstract es un molde, ella solo define el comportamiento
        //de una figura 

        //declaramos las variables que se van a pasar a las clases hijas, nos serviran
        //para guardar en caja de memoria el valor del primer lado 

        //la variable sera privada 
        private float lado1; //permite decimales

        //creamos atributos o propiedades 
        //definimos el constructor 
        public float Lado1
        {
            //METODO O MODIFICACION PARA PONER EL VALOR (#) EN LA CAJA DE MEMJORIA
            set
            {
                //pregunta si el lado <0
                if (value <0)
                {
                    lado1 = 0; //manda el valor a 0 
                }   //NO EXISTEN LADOS NEGATIVOS 
                else
                {
                    lado1 = value;
                    //value es el valor del textbox
                }

            }
            get //obtener el valor
            {
                return lado1; //regresa o cacha el valor de la variable lado
            }

            
        }

        //definido metodos, funciones, operaciones de la clase padre que tambien van 
        //a tener los hijos, metodos de tipo publico para que todos los usen, metodos
        //abstractos van vacios ya que cada hijo definira sus operaciones 
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();


    }
}
