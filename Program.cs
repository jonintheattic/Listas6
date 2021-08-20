using System;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6) Se deben ingresar los códigos de 15 productos de una empresa(números de 3 dígitos)

            //   Luego se ingresan las ventas realizadas durante el día.Por cada venta se ingresa código de
            //   vendedor, código de artículo y cantidad. Finaliza cuando el codigo de producto es 0.
            //   Los vendedores son 5 y están codificados en forma correlativa de 1001 a 1005
            //   Se puede recibir más de una venta de un mismo vendedor y articulo.
            //   Se desea:
            //   a) Mostrar un listado ordenado de mayor a menor por cantidad de unidades vendidas
            //   CANTIDAD CODIGO
            //   XXX XXX
            //   XXX XXX
            //   b) Indicar el/ los vendedores que realizaron menor cantidad de ventas(no de unidades)


            int[] productos = new int[3];
            int[] cantidad =  new int[3];

            int codigoVendedor;
            int vendedor1001 = 0;
            int vendedor1002 = 0;
            int vendedor1003 = 0;
            int vendedor1004 = 0;
            int vendedor1005 = 0;
            bool huboCambios;
            int temp;

            // 1. Leo todos los codigo de producto
            for (int i = 0; i < productos.Length; i++)
            {
                Console.Write("Ingrese el codigo del producto: ");
                productos[i] = int.Parse(Console.ReadLine());
            }

            int codigoProducto;

            Console.WriteLine("Ingrese los datos de las ventas:");
            // 2. ingreso los datos de las ventas, hasta que el codigo de producto sea 0
            do
            {
                Console.Write("Ingrese el codigo del vendedor: ");
                codigoVendedor = int.Parse(Console.ReadLine());


                Console.Write("Ingrese el codigo del producto: ");
                codigoProducto = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad vendida: ");
                int cantidadVendidos = int.Parse(Console.ReadLine());

                for (int l = 0; l < productos.Length; l++)
                {
                    if (codigoProducto == productos[l])
                       cantidad[l] += cantidadVendidos;
                    
                }


                if (codigoVendedor == 1001)
                {
                    vendedor1001++;
                }
                else
                {
                    if (codigoVendedor == 1002)
                    {
                        vendedor1002++;
                    }
                    else
                    {
                        if (codigoVendedor == 1003)
                        {
                            vendedor1003++;
                        }
                        else
                        {
                            if (codigoVendedor == 1004)
                            {
                                vendedor1004++;
                            }
                            else
                            {
                                if (codigoVendedor == 1005)
                                {
                                    vendedor1005++;
                                }
                            }
                        }
                    }
                }

            }
            while (codigoProducto != 0);

            do
            {
                huboCambios = false;

                for (int i = 0; i < productos.Length; i++)
                {
                    if ((i + 1) < cantidad.Length && cantidad[i] < cantidad[i + 1])
                    {
                        
                        temp = cantidad[i];
                        cantidad[i] = cantidad[i + 1];
                        cantidad[i + 1] = temp;

                        temp = productos[i];
                        productos[i] = productos[i + 1];
                        productos[i + 1] = temp;

                        huboCambios = true;
                    }
                }


                huboCambios = false;
            }
            while (huboCambios == true);


            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine(cantidad[i] + " " + productos[i]);
            }

            if (vendedor1001 > vendedor1002 && vendedor1001 > vendedor1003 && vendedor1001 > vendedor1004 && vendedor1001 > vendedor1005)
            {
                Console.WriteLine("El vendedor con mas ventas es el vendedor 1001");
            }
            else
            {
                if (vendedor1002 > vendedor1001 && vendedor1002 > vendedor1003 && vendedor1002 > vendedor1004 && vendedor1002 > vendedor1005)
                {
                    Console.WriteLine("El vendedor con mas ventas es el vendedor 1002");
                }
                else
                {
                    if (vendedor1003 > vendedor1001 && vendedor1003 > vendedor1002 && vendedor1003 > vendedor1004 && vendedor1003 > vendedor1005)
                    {
                        Console.WriteLine("El vendedor con mas ventas es el vendedor 1003");
                    }
                    else
                    {
                        if (vendedor1004 > vendedor1001 && vendedor1004 > vendedor1002 && vendedor1004 > vendedor1003 && vendedor1004 > vendedor1005)
                        {
                            Console.WriteLine("El vendedor con mas ventas es el vendedor 1004");
                        }
                        else
                        {
                            if (vendedor1005 > vendedor1001 && vendedor1005 > vendedor1002 && vendedor1005 > vendedor1003 && vendedor1005 > vendedor1004)
                            {
                                Console.WriteLine("El vendedor con mas ventas es el vendedor 1005");
                            }
                        }
                    }
                }
            }


        }


        

    }
}
