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
           
    
           Console.WriteLine("Max:  "+ unaFinca.getMayorProduccion());
           Console.WriteLine("Min: "+ unaFinca.getMenorProduccion());
           Console.WriteLine("Produccion total: "+ unaFinca.getProduccionTotal());

           Vaca otraVaca = unaFinca.buscarPorNombre("Duende");

           if (otraVaca != null)
           {  Console.WriteLine(otraVaca.ToString());
               
           }

        }
        
        
        
    }
    
}


