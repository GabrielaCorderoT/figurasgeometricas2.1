using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class PoligonoReg:Figura
    {
      //esta clase requiere de la apotema
        private float apo;
        //crear un cosntructor para poligono regular
        public float Apo
        {
            set
            {
                //pregunta si apotema <0
                if (value < 0)
                {
                    apo = 0; //manda el valor a 0 
                    //NO EXISTEN LADOS NEGATIVOS
                }
                else
                {
                    apo = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return apo; //regresa o cacha el valor de la variable lado2
            }
        }
        //usamos el constructor de la clase padre 
        public float N //validar el numero de lados >5
        {
           set 
           {
              //pregunta si el # de lados (n)>5
              if (value < 5)
              {
                 N = 5; //manda el valor a 0 
                         //NO EXISTEN APOTEMASNEGATIVAS
              }
              else 
              {
                 N = value;
                 //value es el valor del textbox
              }
              
           }
           get
           {
             return N; //regresa el valor de n 
           }

           
        }

        //vamos a usar lows metodos de la clase padre 
        //vamos a sobreescribir el comportamiento de estos 
        public float area(float peri) //matodo sobrecargado que recibe el perimetro y lo utiliza
        {
            return (peri * apo) / 2;
        }
        public override float perimetro() //metodo con variable de paso que guarda el perimetro  
        {
            float peri;
            peri = N * Lado1;
            return peri;
        }
        
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT 
        }

         public override float area()//calculo de area clase papá 
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT 
        }
    }
}
