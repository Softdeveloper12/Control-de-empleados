using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_7_PatronObserver
{
    class CMenu
    {
        public static CEmpleado empleado;
        
        public static List<CEmpleado> Savedata = new List<CEmpleado>();
        public static CCooperativa cooperativa;
        public static CFarmacia farmacia;
        public static CFuneraria funeraria;

        public static void menu()
        {
            Console.WriteLine("\nSeleccione la opcion que desea realizar:");
            Console.WriteLine("1- La creacion del empleado");
            Console.WriteLine("2- La inscripcion / cancelacion de los planes (cooperativa , farmacia y plan funerario)");
            Console.WriteLine("3- El registro del consumo de farmacia");
            Console.WriteLine("4- El calculo de la nomina. ");
            Console.WriteLine("5- Salir. ");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.Clear();
                    empleado = new CEmpleado();
                    Savedata.Add(empleado);
                    Console.WriteLine("Empleado agregado");
                    menu();


                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Viene para :");
                    Console.WriteLine("1- Suscribirse en un plan");
                    Console.WriteLine("2- Cancelar su plan ");
                    Console.WriteLine("3- Volver al menu");
                    int s = int.Parse(Console.ReadLine());
                    switch (s)
                    {
                        case 1:
                            
                                    Console.WriteLine("\nIngrese el tipo de plan que desea:");
                                    Console.WriteLine("1- Plan Cooperativa");
                                    Console.WriteLine("2- Plan Farmacia ");
                                    Console.WriteLine("3- Plan Funeraria ");
                                    int opp = int.Parse(Console.ReadLine());
                                    switch (opp)
                                    {
                                        case 1:

                                    Console.WriteLine("Inserte su codigo para la validacion");
                                    int valor1 = int.Parse(Console.ReadLine());
                                    foreach (CEmpleado emp in Savedata)
                                    {
                                        if (emp.codigo== valor1)
                                        {
                                            cooperativa = new CCooperativa(emp);
                                            emp.AgregarSub(cooperativa);
                                            emp.Notificaciones();
                                        }

                                    }
                                            menu();
                                            break;
                                        case 2:


                                    Console.WriteLine("Inserte su codigo para la validacion");
                                    int valor2 = int.Parse(Console.ReadLine());
                                    foreach (CEmpleado emp in Savedata)
                                    {
                                        if (emp.codigo == valor2)
                                        {
                                            Console.WriteLine("Desea consumir algo?");
                                            Console.WriteLine("1- Afirmativo");
                                            Console.WriteLine("2- Negativo");
                                            int r = int.Parse(Console.ReadLine());
                                            switch (r)
                                            {
                                                case 1:
                                                    Console.WriteLine("Ingrese el consumo que ha realizado en la farmacia:");
                                                    emp.consumo = double.Parse(Console.ReadLine());
                                                    farmacia = new CFarmacia(emp);
                                                    emp.AgregarSub(farmacia);
                                                    emp.Notificaciones();

                                                    break;
                                                case 2:
                                                    Console.WriteLine("Gracias por visitarnos, vuelva pronto...");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    CMenu.menu();
                                                    break;
                                                default:

                                                    break;
                                            }
                                            
                                        }

                                    }
                                            menu();
                                            break;
                                        case 3:
                                    Console.WriteLine("Inserte el codigo para la validacion");
                                    int valor3 = int.Parse(Console.ReadLine());
                                    foreach (CEmpleado emp in Savedata)
                                    {
                                        if (emp.codigo == valor3)
                                        {
                                            funeraria = new CFuneraria(emp);
                                            emp.AgregarSub(funeraria);
                                            emp.Operaciones(emp.salarioneto);
                                        }
                                        
                                    }
                                            menu();
                                            break;
                                        default:
                                            Console.WriteLine("Intente nuevamente....");
                                            Console.ReadKey();
                                            Console.Clear();
                                            menu();

                                            break;
                                    }
                               
                            break;
                        case 2:
                            Console.WriteLine("Ingrese su codigo de empleado para la validacion:");
                            int value = int.Parse(Console.ReadLine());
                            foreach(CEmpleado emp1 in Savedata)
                            {
                                if (emp1.codigo == value)
                                {
                                    Console.WriteLine("\nIngrese el tipo de plan que desea cancelar:");
                                    Console.WriteLine("1- Plan Cooperativa");
                                    Console.WriteLine("2- Plan Farmacia ");
                                    Console.WriteLine("3- Plan Funeraria ");
                                    int opts = int.Parse(Console.ReadLine());
                                    switch (opts)
                                    {
                                        case 1:

                                            cooperativa = new CCooperativa(emp1);
                                            emp1.RemoverSub(cooperativa);
                                            Console.WriteLine("Listo");
                                            Console.ReadKey();

                                            menu();
                                            break;
                                        case 2:
                                            
                                            farmacia = new CFarmacia(emp1);
                                            emp1.RemoverSub(farmacia);
                                            Console.WriteLine("Listo");
                                            Console.ReadKey();
                                            menu();
                                            break;
                                        case 3:
                                            funeraria = new CFuneraria(emp1);
                                            emp1.RemoverSub(funeraria);
                                            Console.WriteLine("Listo");
                                            Console.ReadKey();

                                            menu();
                                            break;
                                        default:
                                            Console.WriteLine("Intente nuevamente....");
                                            menu();


                                            break;
                                    }
                                }
                            }
                            break;

                        case 3:
                            Console.Clear();
                            menu();
                            break;
                    }
                    break;
                case 3:
                    foreach (CEmpleado farconsumo in Savedata)
                    {
                        Console.WriteLine($"Nombre del empleado:{farconsumo.nombre}\n Consumo:{farconsumo.consumo}");
                    }
                    break;
                case 4:
                    foreach(CEmpleado nomina in Savedata)
                    {
                        Console.WriteLine($"Nombre del empleado:{nomina.nombre}\n Salario Bruto:{nomina.salario}\n");
                        nomina.Notificaciones();
                       
                    }

                    break;
                case 5:
                    Console.WriteLine("Gracias por su participacion, hasta luego...");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Intente nuevamente, pero esta vez elija una opcion valida....");
                    Console.ReadKey();
                    Console.Clear();
                    menu();
                    break;
            }
        }
    }
}


