using System;

namespace Zapatron
{
    public class Program
    {
        static void Main(string[] args)

        {
            string logo = @"  
                              _____  _______                   __         ______              ______    __                                                 
                             /     |/       \                 /  |       /      \            /      \  /  |                                                
                             $$$$$ |$$$$$$$  |  ______    ____$$ |      /$$$$$$  |  ______  /$$$$$$  |_$$ |_    __   __   __   ______    ______    ______  
                                $$ |$$ |__$$ | /      \  /    $$ |      $$ \__$$/  /      \ $$ |_ $$// $$   |  /  | /  | /  | /      \  /      \  /      \ 
                           __   $$ |$$    $$< /$$$$$$  |/$$$$$$$ |      $$      \ /$$$$$$  |$$   |   $$$$$$/   $$ | $$ | $$ | $$$$$$  |/$$$$$$  |/$$$$$$  |
                          /  |  $$ |$$$$$$$  |$$ |  $$ |$$ |  $$ |       $$$$$$  |$$ |  $$ |$$$$/      $$ | __ $$ | $$ | $$ | /    $$ |$$ |  $$/ $$    $$ |
                          $$ \__$$ |$$ |  $$ |$$ \__$$ |$$ \__$$ |      /  \__$$ |$$ \__$$ |$$ |       $$ |/  |$$ \_$$ \_$$ |/$$$$$$$ |$$ |      $$$$$$$$/ 
                          $$    $$/ $$ |  $$ |$$    $$/ $$    $$ |      $$    $$/ $$    $$/ $$ |       $$  $$/ $$   $$   $$/ $$    $$ |$$ |      $$       |
                           $$$$$$/  $$/   $$/  $$$$$$/   $$$$$$$/        $$$$$$/   $$$$$$/  $$/         $$$$/   $$$$$/$$$$/   $$$$$$$/ $$/        $$$$$$$/  

                                                                            


                                                  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                                                  $$$$$$   Nombre del programador: Jesus Dario Rodriguez     $$$$$$
                                                  $$$$$$   Matricula: ES1822021661                           $$$$$$
                                                  $$$$$$   Grupo: DS-DPRN2-2201-B2-001                       $$$$$$
                                                  $$$$$$   Profesor: Ing.Jacobo Díaz Martínez                $$$$$$
                                                  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
";
            //código para pantalla de presentación
            Console.WriteLine(logo);
            System.Threading.Thread.Sleep(5000);//
            Console.Clear();
            menu();
        }
        static void menu()
        {
            string seleccionTipo = "";// esta variable controla el tipo de calzado a construir
            int seleccionCalzado = 0;//esta variable se usa para controlar la seleccion de la clase a llamar
            double precioUnitario = 0;
            int tallaInterna = 0;
            int cantidad = 0;
            string color = "";
            int aux = 1;
            String menu = @"
                               ╔════════════════════════════════════════════════════════╗
                               ║         Seleccione la operación a realizar:            ║
                               ╠════════════════════════════════════════════════════════╢
                               ║    1.- Seleccionar Vendedor                            ║
                               ║                                                        ║
                               ║    2.- Venta                                           ║
                               ║                                                        ║
                               ║    3.- Factura                                         ║
                               ║                                                        ║
                               ║    0.- Salir                                           ║
                               ║                                                        ║
                               ╠════════════════════════════════════════════════════════╢
                               ║    Ingrese su seleccion ...                            ║
                               ╚════════════════════════════════════════════════════════╝";
            String vendedor = "";


            while (aux != 0)
            {

                Console.WriteLine(menu);
                int seleccion = (int)Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (seleccion)
                {
                    case 1:
                        int aux2 = 1;
                        while (aux2 != 0)
                        {
                            String menuVendedor = @"
                                          ┌───────────────────────────────┐
                                          │  Seleccione el vendedor:      │
                                          ├───────────────────────────────┤
                                          │  1.- Juan                     │
                                          │  2.- Pedro                    │
                                          │  3.- Karina                   │
                                          │  4.- Vanessa                  │
                                          │  5.- Olga                     │
                                          │  0.- Volver al menu anterior  │
                                          └───────────────────────────────┘         
";
                            Console.WriteLine(menuVendedor);
                            int seleccion2 = (int)Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (seleccion2)
                            {
                                case 1:
                                    vendedor = "Juan";
                                    aux2 = 0;
                                    break;
                                case 2:
                                    vendedor = "Pedro";
                                    aux2 = 0;
                                    break;
                                case 3:
                                    vendedor = "Karina";
                                    aux2 = 0;
                                    break;
                                case 4:
                                    vendedor = "Vanessa";
                                    aux2 = 0;
                                    break;
                                case 5:
                                    vendedor = "Olga";
                                    aux2 = 0;
                                    break;
                                case 0:
                                    aux2 = 0;
                                    break;
                                default:
                                    Console.WriteLine("Seleccione un vendedor ´válido");
                                    break;

                            }
                            Console.WriteLine("El vendedor: {0} ha sido seleccionado",vendedor);
                        }
                        break;
                    case 2:
                        int aux3 = 1;
                        int aux4 = 1;
                        while (aux3 != 0)
                        {
                            String menuCalzado = @"
                                         ┌───────────────────────────────┐
                                         │ Seleccione el tipo de calzado │
                                         │                               │
                                         ├───────────────────────────────┤
                                         │ 1.- Dama                      │
                                         │ 2.- Caballero                 │
                                         │ 3.- Niños                     │
                                         │ 4.- Bebes                     │
                                         │ 0.- Regresar al menu anterior │
                                         ├───────────────────────────────┤
                                         │ Ingrese su selección:         │
                                         └───────────────────────────────┘               
                            ";
                            Console.WriteLine(menuCalzado);
                            int seleccion3 = (int)Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (seleccion3)
                            {
                                case 1:
                                    seleccionCalzado = 1;
                                    aux3 = 0;
                                    break;
                                case 2:
                                    seleccionCalzado = 2;
                                    aux3 = 0;
                                    break;
                                case 3:
                                    seleccionCalzado = 3;
                                    aux3 = 0;
                                    break;
                                case 4:
                                    seleccionCalzado = 4;
                                    aux3 = 0;
                                    break;
                                case 0:
                                    aux3 = 0;
                                    break;
                                default:
                                    Console.WriteLine("Seleccione una opcion valida");
                                    break;
                            }

                        }
                        while (aux4 != 0)
                        {
                            String menuTipo = @"

                                         ┌───────────────────────────────┐
                                         │ Seleccione el tipo de calzado │
                                         │                               │
                                         ├───────────────────────────────┤
                                         │ 1.- Sandalias                 │
                                         │ 2.- BotaS                     │
                                         │ 3.- Mocasin                   │
                                         │ 4.- Tenis                     │
                                         │ 0.- Regresar al menu anterior │
                                         ├───────────────────────────────┤
                                         │ Ingrese su selección:         │
                                         └───────────────────────────────┘   
";
                            Console.WriteLine(menuTipo);
                            int tipoSeleccion = (int)Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (tipoSeleccion)
                            {
                                case 1:
                                    seleccionTipo = "Sandalias";
                                    aux4 = 0;
                                    break;
                                case 2:
                                    seleccionTipo = "Botas";
                                    aux4 = 0;
                                    break;
                                case 3:
                                    seleccionTipo = "Mocasín";
                                    aux4 = 0;
                                    break;
                                case 4:
                                    seleccionTipo = "Tennis";
                                    aux4 = 0;
                                    break;
                                case 0:
                                    aux4 = 0;
                                    break;

                            }

                        }

                        Console.WriteLine("Precio");
                        precioUnitario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\n Talla:");
                        tallaInterna = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n Color");
                        color = Console.ReadLine();
                        Console.WriteLine("\n Cantidad:");
                        cantidad = Convert.ToInt32(Console.ReadLine());


                        break;

                    case 3:
                        if (seleccionCalzado == 1)
                        {
                            Dama calzado = new Dama("Dama", seleccionTipo, precioUnitario, tallaInterna, color, cantidad);
                            calzado.venta(vendedor);
                        }
                        else if (seleccionCalzado == 2)
                        {
                            Caballero calzado = new("Caballero", seleccionTipo, precioUnitario, tallaInterna, color, cantidad);
                            calzado.venta(vendedor);
                        }
                        else if (seleccionCalzado == 3)
                        {
                            Ninos calzado = new("Niños", seleccionTipo, precioUnitario, tallaInterna, color, cantidad);
                            calzado.venta(vendedor);
                        }
                        else
                        {
                            Bebes calzado = new("Bebes", seleccionTipo, precioUnitario, tallaInterna, color, cantidad);
                            calzado.venta(vendedor);
                        }
                        Console.ReadKey();
                        aux = 0;

                        break;
                    case 0:
                        aux = 0;
                        break;
                }

            }

        }
    }
}
