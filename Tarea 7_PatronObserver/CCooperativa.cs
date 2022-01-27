using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7_PatronObserver
{
    class CCooperativa:IObserver
    {
        CEmpleado empleado;
        
        

        public CCooperativa(CEmpleado empleado)
        {
            this.empleado = empleado;
            
        }

        public void Update()
        {
            double porcentaje = this.empleado.salarioneto * 0.025;
            double salariocop = this.empleado.salarioneto - porcentaje;

            Console.WriteLine("****Plan Cooperativo****");
            Console.WriteLine($"\nEl salario neto antes:{this.empleado.salarioneto}DOP\nEl monto descontado fue un total de:{porcentaje}Dop \n y el monto restante es de:{salariocop}DOP\n ");



            

            
        }
    }
}
