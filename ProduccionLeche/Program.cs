using System;
using System.Threading;


namespace ProduccionLeche
{
    class Program
    {

       

        static void Main(string[] args)
        { // Vaca unaVaca = new Vaca(nombre, fechaCumpleaños, produccion);
            Finca unaFinca = new Finca(1,"Bella Vista"); 
            
           for(int i = 0 ;i<10;i++){
                Thread.Sleep(5000);
                Vaca unaVaca = Spawner.generarNuevaVaca();
                unaFinca.recibirVaca(unaVaca);
           }

           foreach (Vaca vaca in unaFinca.getVacas())
           {   Console.WriteLine("Nombre: "+vaca.getNombre());
           }
           
        }
        
        
        
    }
    
}


