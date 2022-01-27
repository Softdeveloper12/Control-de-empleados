using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7_PatronObserver
{
    class CFuneraria:IObserver
    {
        CEmpleado empleado;

        

        public CFuneraria(CEmpleado empleado)
        {
            this.empleado = empleado;
            
        }
        public void Update()
        {
            Console.WriteLine("*****Plan Funeraria*****");
            if (this.empleado.salarioneto>= 3500)
            {
                double descuento = this.empleado.salarioneto * 0.25;
                double monto = this.empleado.salarioneto - descuento ;
                Console.WriteLine($"\nSu monto fijo sera de:{descuento}DOP \n Su monto restante es de:{monto}DOP\n");
            }
            else
            {
                Console.WriteLine($"\nDescuento del plan:0");
                Console.WriteLine("No es posible adquirir este plan, necesita estar dentro de los requisitos, vuelva e intente luego...");
                Console.ReadKey();
                Console.Clear();
                CMenu.menu();
            }
        }
    }
}
