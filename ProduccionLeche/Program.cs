using System;
using System.Threading;

namespace ProduccionLeche
{
    class Program
    {

       

        static void Main(string[] args)
        {
           for(int i = 0 ;i<70;i++){
            Vaca unaVaca = Spawner.generarNuevaVaca();
            Console.WriteLine(unaVaca.getNombre());
            Console.WriteLine(unaVaca.getFechaNacimiento());
            Console.WriteLine(unaVaca.getProduccion());

           }
        }
        
        
        
    }
    
}


