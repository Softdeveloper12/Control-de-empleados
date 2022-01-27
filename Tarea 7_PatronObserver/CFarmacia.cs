using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7_PatronObserver
{
    class CFarmacia : IObserver
    {
        CEmpleado empleado;

        public CFarmacia()
        {
        }

        public CFarmacia(CEmpleado empleado)
        {
            this.empleado = empleado;

        }
        public void Update()
        {
            double monto = empleado.consumo / 2;

            this.empleado.salarioneto = this.empleado.salarioneto - monto;
            Console.WriteLine("****Plan Farmacia****");

            Console.WriteLine($"\nEl consumo tiene un monto total de:{monto}DOP \nAhora cuenta con un salario de:{this.empleado.salarioneto}\n");
            
        }
      

        
    }
}
