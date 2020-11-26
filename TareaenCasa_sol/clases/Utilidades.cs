using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC
{
    //Un espacio de nombres es un contenedor lógico de clases
    //permite agrupo varias clases dentro de ese espacio
    //Ejemplo: TIC.Utilidades

    class Utilidades
    {
        /*
        1) Ejercicio en clase
           Un formulario solicita un número que representa una tabla de multiplicar.
           Se debe mostrar la tabla de multiplicar en un cuadro de texto(Textbox) 
           o en un listbox.
        */

            /*
             Modificadores de acceso: public, private, protected
             public: toda clase puede acceder al método o función
             private: solo la propia clase puede acceder al método o función
             protected: solo las clases que heredan de la clase base pueden
             acceder al método o función
             */

        /// <summary>
        /// La función calcula una tabla de multiplicar
        /// </summary>
        /// <param name="tabla">la tabla a calcular</param>
        /// <returns>Una cadena con la tabla calculada</returns>
        public static String CalculaTabla(int tabla)
        {
            //las funciones estáticas se pueden utilizar sin necesidad de crear
            //una instancia de la clase.
            String aux = "";
            for(int i=1; i<=12; i++)
            {   //5 x 1 = 5
                //5 X 2 = 10
                aux = aux + tabla.ToString() + " X " + i.ToString() + " = " + (tabla * i);
                aux = aux + Environment.NewLine;
            }
            return aux;
        }

        /// <summary>
        /// Calcula el factorial de un entero
        /// </summary>
        /// <param name="num">Represente el entero al que se le calcula el factorial</param>
        /// <returns>Devuelve el factorial</returns>
        public static long factorial(int num)
        {
            long fac = 1;
            if (num == 0)
                return 1;  //retorna y abandona la función

            for (int i = 1; i <= num; i++)
                fac *= i;
            
            return fac;
        }
    }
}
