using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATIO
{
    internal class Program
    {
        class Venta
        {
            public string producto;
            public int unidades;
            public float total;
        }

        static List<Venta> ventas = new List<Venta>();
        static List<Venta> devoluciones = new List<Venta>();

        static void Main()
        {
            Console.WriteLine("============================");
            Console.WriteLine("TIENDA DON LUCAS");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolución");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("============================");
            Console.WriteLine("Ingrese una opción");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio2();
                    break;
                case 2:
                    ejercicio3();
                    break;
                case 3:
                    ejercicio4();
                    break;
            }
            Console.ReadKey();

            return;
        }

        static void ejercicio2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR VENTA DE:");
            Console.WriteLine("============================");
            Console.WriteLine("1: LIMPIEZA");
            Console.WriteLine("2: ABARROTES");
            Console.WriteLine("3: GOLOSINAS");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion2 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion2)
            {
                case 1:
                    ejercicio4_1();
                    break;
                case 2:
                    ejercicio4_2();
                    break;
                case 3:
                    ejercicio4_3();
                    break;
                case 4:
                    ejercicio4_4();
                    break;
                case 5:
                    Main();
                    break;
            }
            return;
        }

        static void ejercicio3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR DEVOLUCIÓN DE:");
            Console.WriteLine("============================");
            Console.WriteLine("1: LIMPIEZA");
            Console.WriteLine("2: ABARROTES");
            Console.WriteLine("3: GOLOSINAS");
            Console.WriteLine("4: Electrónicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion3 = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion3)
            {
                case 1:
                    ejercicio4_2_1();
                    break;
                case 2:
                    ejercicio4_2_2();
                    break;
                case 3:
                    ejercicio4_2_3();
                    break;
                case 4:
                    ejercicio4_2_4();
                    break;
                case 5:
                    Main();
                    break;
            }
            return;
        }

        static void ejercicio4_1()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR VENTA DE LIMPIEZA:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaVenta = new Venta { producto = "Limpieza", unidades = UNIDADES, total = TOTAL1 };
            ventas.Add(nuevaVenta);

            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de limpieza ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_1();
                    break;
                case 2:
                    ejercicio2();
                    break;
            }
        }

        static void ejercicio4_2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR VENTA DE ABARROTES:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaVenta = new Venta { producto = "Abarrotes", unidades = UNIDADES, total = TOTAL1 };
            ventas.Add(nuevaVenta);

            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ABARROTES ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_2();
                    break;
                case 2:
                    ejercicio2();
                    break;
            }
        }

        static void ejercicio4_3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR VENTA DE GOLOSINAS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaVenta = new Venta { producto = "Golosinas", unidades = UNIDADES, total = TOTAL1 };
            ventas.Add(nuevaVenta);

            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de GOLOSINAS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_3();
                    break;
                case 2:
                    ejercicio2();
                    break;
            }
        }

        static void ejercicio4_4()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR VENTA DE ELECTRÓNICOS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaVenta = new Venta { producto = "Electrónicos", unidades = UNIDADES, total = TOTAL1 };
            ventas.Add(nuevaVenta);

            Console.WriteLine("============================");
            Console.WriteLine("Se han ingresado " + UNIDADES + " unidades");
            Console.WriteLine("Se han ingresado " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos ELECTRÓNICOS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_4();
                    break;
                case 2:
                    ejercicio2();
                    break;
            }
        }

        static void ejercicio4_2_1()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR DEVOLUCIÓN DE LIMPIEZA:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaDevolucion = new Venta { producto = "Limpieza", unidades = UNIDADES, total = TOTAL1 };
            devoluciones.Add(nuevaDevolucion);

            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de limpieza ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_2_1();
                    break;
                case 2:
                    ejercicio3();
                    break;
            }
        }

        static void ejercicio4_2_2()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR DEVOLUCIÓN DE ABARROTES:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaDevolución = new Venta { producto = "Abarrotes", unidades = UNIDADES, total = TOTAL1 };
            devoluciones.Add(nuevaDevolución);

            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ABARROTES ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_2_2();
                    break;
                case 2:
                    ejercicio3();
                    break;
            }
        }

        static void ejercicio4_2_3()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR DEVOLUCIÓN DE GOLOSINAS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaDevolución = new Venta { producto = "Golosinas", unidades = UNIDADES, total = TOTAL1 };
            devoluciones.Add(nuevaDevolución);

            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de GOLOSINAS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_2_3();
                    break;
                case 2:
                    ejercicio3();
                    break;
            }
        }

        static void ejercicio4_2_4()
        {
            Console.WriteLine("============================");
            Console.WriteLine("REGISTRAR DEVOLUCIÓN DE ELECTRÓNICOS:");
            Console.WriteLine("============================");
            Console.Write("Ingrese cantidad (unidades):");
            int UNIDADES = int.Parse(Console.ReadLine());
            Console.Write("Ingrese precio: S/");
            float PRECIO = float.Parse(Console.ReadLine());
            float TOTAL1 = UNIDADES * PRECIO;

            Venta nuevaDevolución = new Venta { producto = "Electrónicos", unidades = UNIDADES, total = TOTAL1 };
            devoluciones.Add(nuevaDevolución);

            Console.WriteLine("============================");
            Console.WriteLine("Se han REGRESADO " + UNIDADES + " unidades");
            Console.WriteLine("Se han DEVUELTO " + TOTAL1 + " en caja");
            Console.WriteLine("============================");
            Console.WriteLine("1: Registrar más productos de ELECTRÓNICOS ");
            Console.WriteLine("2: <- Regresar");
            Console.WriteLine("============================");
            Console.WriteLine("INGRESE UNA OPCION");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    ejercicio4_2_4();
                    break;
                case 2:
                    ejercicio3();
                    break;
            }
        }

        static void ejercicio4()
        {
            Console.WriteLine("Estadísticas finales:");
            Console.WriteLine("============================");

            Dictionary<string, int> ventasPorRubro = new Dictionary<string, int>();
            Dictionary<string, int> devolucionesPorRubro = new Dictionary<string, int>();
            Dictionary<string, int> inventarioPorRubro = new Dictionary<string, int>();

            foreach (var venta in ventas)
            {
                if (!ventasPorRubro.ContainsKey(venta.producto))
                {
                    ventasPorRubro[venta.producto] = 0;
                    devolucionesPorRubro[venta.producto] = 0;
                    inventarioPorRubro[venta.producto] = 0;
                }
                ventasPorRubro[venta.producto] += venta.unidades;
                inventarioPorRubro[venta.producto] += venta.unidades;
            }

            foreach (var devolucion in devoluciones)
            {
                if (ventasPorRubro.ContainsKey(devolucion.producto))
                {
                    devolucionesPorRubro[devolucion.producto] += devolucion.unidades;
                    inventarioPorRubro[devolucion.producto] -= devolucion.unidades;
                }
            }

            float totalCajaGeneral = 0;

            foreach (var rubro in ventasPorRubro.Keys)
            {
                int vendidos = ventasPorRubro[rubro];
                int devueltos = devolucionesPorRubro.ContainsKey(rubro) ? devolucionesPorRubro[rubro] : 0;
                int enInventario = inventarioPorRubro[rubro];
                float totalEnCaja = (vendidos - devueltos) * 10; 

                Console.WriteLine("============================");
                Console.WriteLine($"{vendidos} vendidos");
                Console.WriteLine($"{rubro} | {devueltos} devueltos");
                Console.WriteLine($"{enInventario} en total");
                Console.WriteLine($"S/ {totalEnCaja:F2} en caja");

                totalCajaGeneral += totalEnCaja;
            }

            Console.WriteLine("============================");
            Console.WriteLine($"Queda en caja S/ {totalCajaGeneral:F2}");
            Console.WriteLine("============================");
        }

    }
}    
