using System;

namespace ProduccionLeche
{
    public class Finca
    {    /*Atributos*/
        /*public private*/
        private int id;
        private string nombre;
        private  string ubicacion;
        private float lat;
        private float lon;
        private  Vaca[] vacas = new Vaca[100];
        private float produccionTotal = 0;
        

        /*Constructor*/
        public Finca  (int id, string nombre)
        {
            this.id = id;
            this.nombre =  nombre.ToUpper();
        }
       
        /*logica de negocio*/
        public float getProduccionTotal()
        {   produccionTotal = 0;
            foreach (Vaca vaca in vacas)     
            {   if (vaca != null)
                {   produccionTotal += vaca.getProduccion();
                }
            }
            return this.produccionTotal;
        }

        public float getMayorProduccion()
        {   float max = 0;
            foreach (Vaca vaca in this.vacas)
            {
                if (vaca == null) break;
                if (vaca.getProduccion() > max)
                    max = vaca.getProduccion();
            }
            return max;
            
        }

        public float getMenorProduccion()
        {
            return 0;
        }
        
        public Vaca getPorNombre(string nombre)
        {
            return null;
        }


        public void recibirVaca(Vaca unaVaca)
        {   int posicionVacio = 0;
            foreach (Vaca vaca in this.vacas)
            { if (vaca == null) break;
                posicionVacio++;
            }
            if(posicionVacio<100)
             vacas[posicionVacio] = unaVaca; 
        }




        /*encapsulacion */
        /*set  y get */
        public void setNombre(string nombre)
        {   this.nombre = nombre.ToUpper();
        }

        public string getNombre()
        {   return nombre.Replace('E', '#');
        }


        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return this.id;
        }


        public void setUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }

        public string getUbicacion()
        {
            return this.ubicacion;
        }


        public void setLat(float lat)
        {
            this.lat = lat;
        }

        public float getLat()
        {
            return this.lat;
        }
        
        public void setLon(float lon)
        {
            this.lon = lon;
        }

        public float getLon()
        {
            return this.lon;
        }

        public void set(Vaca[] vacas)
        {   this.vacas = vacas;
        }

        public Vaca[] getVacas()
        {
            return this.vacas;
        }



    }
}