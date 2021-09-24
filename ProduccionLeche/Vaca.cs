using System;

namespace ProduccionLeche
{
    public enum Razas
    {  JERSEY,
       GYR,
       HOLSTEIN,
       NORMANDO,
    }
    
    public class Vaca
    {
        private int id;
        private string nombre;
        private float produccion;
        private DateTime fechaNacimiento;
        private string descripcion;
        private Razas raza;
        private int numeroPartos;
        private int AI;
        private int AD;
        private int PI;
        private int PD;

        public Vaca(int id, string nombre, DateTime fechaNacimiento, float produccion )
        {   this.id = id;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.produccion = produccion;
        }
        public Vaca( string nombre, DateTime fechaNacimiento, float produccion )
        {   this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.produccion = produccion;
        }

      

        public DateTime getFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void setFechaNacimiento(DateTime fechaNacimiento )
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string getNombre()
        {      
            return   this.nombre;
        }

        public void setNombre(string nombre)
        {   this.nombre = nombre.ToUpper();
        }
        

        public void setProduccion(float produccion)
        {
            this.produccion = produccion;
        }

         public float getProduccion()
         {
             return this.produccion;
         }

         
         
    
         /*me entrega informacion clave sobre el objeto */
        public override string ToString()
        {
            return "Nombre: "+ this.nombre + "  Produccion: "+ this.produccion +
                    "Fecha Nacimiento"+ fechaNacimiento ;
        }
    }
}