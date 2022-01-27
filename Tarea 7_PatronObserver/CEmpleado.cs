using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7_PatronObserver
{
    class CEmpleado
    {
        private static Random alt = new Random();
        public  int codigo = alt.Next(100, 999);
        
        public string nombre;
        public string cargo;
        public double salario;
        public double salarioneto;
        public double consumo;

        public static double acciones { get; set; }
       
        public List<IObserver> observerslist = new List<IObserver>();
        public CEmpleado()
        {
            Console.WriteLine("--------Modulo de Creacion de empleado--------");
            Console.WriteLine($"\nCodigo de empleado: {codigo}");
            

            Console.WriteLine("Ingrese el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el cargo");
            cargo = Console.ReadLine();

            Console.WriteLine("Ingrese salario:");
            salario = double.Parse(Console.ReadLine());

            salarioneto =  salario-(salario * 0.0591);
            

            Console.WriteLine($"Sueldo neto:{salarioneto}");

        }
        

        public void AgregarSub(IObserver observador)
        {
            observerslist.Add(observador);
        }

        public void RemoverSub(IObserver observador)
        {
            observerslist.Remove(observador);
            
        }

        public void Notificaciones()
        {
            foreach (var elementos in observerslist)
            {
                elementos.Update();
            }
        }
        public void Operaciones(double valor)
        {
            acciones = valor;
            Notificaciones();
        }
    }
}
