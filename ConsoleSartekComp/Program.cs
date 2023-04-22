namespace ConsoleSartekComp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Declaración e Inicio de Variables
            String menu = "\n\tSARTEKCOMP \n \n 1.- Venta de Productos\n 2.- Total a Pagar\n 3.- Estadísticas\n 4.- Salir\n";
            int opcion = 0, edad = 0, cantidad = 0, contadorNotebook = 0, contadorImpresora = 0, contadorMicAudifonos = 0;
            String? strOpcion = "", strEdad = "", strTipoProducto = "", strCantidad = "", strMetodoPago = "";
            double valorNotebook, valorImpresora, valorMicAudifonos, descuentoCantidad, descuentoEdad, descuentoTransferencia, totalDescuento = 0, totalPagar = 0;

            valorNotebook = 350000;
            valorImpresora = 150000;
            valorMicAudifonos = 50000;

            descuentoCantidad = 0.1;
            descuentoEdad = 0.2;
            descuentoTransferencia = 0.05;

            do
            {
                //Despliegue Menú
                Console.WriteLine(menu + "\n" + "Ingrese una Opción...");
                strOpcion = Console.ReadLine();
                int.TryParse(strOpcion,out opcion);
                
                //Selección del Menú de Opciones
                switch (opcion)
                {
                    //Inputs Sección "Venta de Productos"
                    case 1:
                    Console.WriteLine("Ingrese su Edad: ");
                    strEdad = Console.ReadLine();
                    int.TryParse(strEdad, out edad);
                    Console.WriteLine("Ingrese el Tipo de Producto:\n \n N - Notebook\n I - Impresora Láser\n MA - Juego de Micrófono Audífonos");
                    strTipoProducto = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad de Productos que desea comprar: ");
                    strCantidad = Console.ReadLine();
                    int.TryParse(strCantidad, out cantidad);
                    break;
                    
                    case 2:
                    //Sentencias para Clasificación de Tipo de Producto, Cálculo Total a Pagar y Aplicación de Descuentos según Edad, Cantidad y Método de Pago            
                    if(strTipoProducto == "N")
                    {
                        totalPagar = valorNotebook * cantidad;
                        contadorNotebook = contadorNotebook + cantidad;
                    }
                    if(strTipoProducto == "I")
                    {
                        totalPagar = valorImpresora * cantidad;
                        contadorImpresora = contadorImpresora + cantidad;                     
                    }
                    if(strTipoProducto == "MA")
                    {
                        totalPagar = valorMicAudifonos * cantidad;
                        contadorMicAudifonos = contadorMicAudifonos + cantidad;
                    }

                    if(edad >= 40)
                    {
                        totalDescuento = totalPagar * descuentoEdad;
                        totalPagar = totalPagar - totalDescuento;
                    }
                    if(cantidad >= 4)
                    {
                        totalDescuento = totalPagar * descuentoCantidad;
                        totalPagar = totalPagar - totalDescuento;
                    }

                    //Selección de Método de Pago
                    Console.WriteLine($"Seleccione el método de Pago: \n D - Débito\n C - Crédito\n T - Transferencia");
                    strMetodoPago = Console.ReadLine();
                    if(strMetodoPago == "T")
                    {
                        totalDescuento = totalPagar * descuentoTransferencia;
                        totalPagar = totalPagar - totalDescuento;
                        Console.WriteLine($"Total a Pagar: {totalPagar}");
                    }
                    else 
                    {
                        Console.WriteLine($"Total a Pagar: {totalPagar}");
                    }

                    break;
                    case 3:
                    //Outputs de Estadísticas de Ventas
                    Console.WriteLine($"Total de Notebooks Vendidos: {contadorNotebook}");
                    Console.WriteLine($"Total de Impresoras Vendidas: {contadorImpresora}");
                    Console.WriteLine($"Total de Juegos Micrófono-Audífonos Vendidos: {contadorMicAudifonos}");
                    break;
                    case 4:
                    //Salida de la Aplicación
                    Console.WriteLine("Saliendo de la aplicación...");
                    break;
                    default:
                    //Validación Default para Opción No Válida
                    Console.WriteLine("Opción No Válida, Intente Nuevamente...");
                    break;
                }

            }while(opcion != 4);
        }
    }
}