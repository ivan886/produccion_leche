using System;

namespace ProduccionLeche
{    /*Generar Vacas de forma aleatoria cada  5 segundos */
    public static class Spawner
    {  
        private static int  generarProduccion()
        {   Random rd = new Random();
            return rd.Next(0, 20);
        }

        private static string generarNombreAleatorio()
        {   string[] nombres = {"Bessie", "Duende" ,"Botón de oro" ,"Clarabelle","Dottie","Guinness","magia","mantequilla"}; 
            Random rd = new Random();
            int posicion = rd.Next(0,7);  
            return nombres[posicion];
        }

        private static   DateTime generarFechaNacimiento()
        {   Random rd = new Random();
            int dia = rd.Next(1, 31);
            int mes = rd.Next(1, 12);
            int año = rd.Next(DateTime.Now.Year-7, DateTime.Now.Year);
            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            return fechaNacimiento;
        }

        public static Vaca generarNuevaVaca()
        {   int produccion = generarProduccion();
            string nombre = generarNombreAleatorio();
            DateTime fechaCumpleaños = generarFechaNacimiento();
            Vaca unaVaca = new Vaca(nombre, fechaCumpleaños, produccion);
            return unaVaca;
        }
        
    }
}