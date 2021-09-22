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
                Thread.Sleep(500);
                Vaca unaVaca = Spawner.generarNuevaVaca();
                unaFinca.recibirVaca(unaVaca);
           }
           try
           { foreach (Vaca vaca in unaFinca.getVacas())
              {    Console.WriteLine("Nombre: " + vaca.getNombre());
              }
           } catch (Exception e)
           { 
              Console.WriteLine(e.Message);
           }
           

           Console.WriteLine("El maximo de litros de leche que produce una vaca en la finca es "+ unaFinca.getMayorProduccion());

        }
        
        
        
    }
    
}


