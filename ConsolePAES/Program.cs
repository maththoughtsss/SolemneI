namespace ConsolePAES
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            //Declaración de Variables
            String? strNumLocales, strCantidadPersonas, strCantidadPersonasSobre700;
            double numLocales=0, contador=1, cantidadPersonas=0, cantidadPersonasSobre700=0, totalGlobalPersonas=0, totalSobre700=0, porcentajeSobre700=0, nivelLocal=0, nivel1=0, nivel2=0, nivel3=0, nivel4=0;

            //Input Número de Locales (Cantidad de ciclos)
            Console.WriteLine("Ingrese el número de locales a registrar: ");
            strNumLocales = Console.ReadLine();
            double.TryParse(strNumLocales, out numLocales);

            //Ciclo While de Almacenaje de Datos
            while(contador <= numLocales)
            {
                //Input y Conversion de Variables
                Console.WriteLine("Nombre del Local:");
                Console.ReadLine();
                Console.WriteLine("Cantidad de Personas que rindieron PAES:");
                strCantidadPersonas = Console.ReadLine();
                double.TryParse(strCantidadPersonas,out cantidadPersonas);
                Console.WriteLine("Cantidad de Personas con más de 700 puntos:");
                strCantidadPersonasSobre700 = Console.ReadLine();
                double.TryParse(strCantidadPersonasSobre700, out cantidadPersonasSobre700);

                //Cálculo de Nivel Local
                nivelLocal = cantidadPersonasSobre700 * 100 / cantidadPersonas;

                //Clasificación de Niveles
                if(nivelLocal >= 80)
                {
                    nivel1++;
                }
                if(nivelLocal <= 80 && nivelLocal >=60)
                {
                    nivel2++;
                }
                if(nivelLocal <= 60 && nivelLocal >= 40)
                {
                    nivel3++;
                }
                if(nivelLocal <= 40 && nivelLocal >= 20)
                {
                    nivel4++;
                }

                //Cálculo de Total Global de Personas y Porcentaje de Personas sobre 700 puntos
                totalGlobalPersonas = totalGlobalPersonas + cantidadPersonas;
                totalSobre700 = totalSobre700 + cantidadPersonasSobre700;
                porcentajeSobre700 = totalSobre700 * 100 / totalGlobalPersonas;

                contador++;
            }
            //Outputs
            Console.WriteLine($"\nLa Cantidad Total de Personas que rindieron PAES en los {numLocales} Locales es de: {totalGlobalPersonas}");
            Console.WriteLine($"La Cantidad Total de Personas que obtubieron un puntajes sobre 700 es de: {totalSobre700}");
            Console.WriteLine($"El Porcentaje Total de Personas que obtuvieron un puntaje sobre 700 es del: {porcentajeSobre700}%");
            Console.WriteLine($"\nCantidad de Locales con Nivel 1 - Excelencia: {nivel1}");
            Console.WriteLine($"Cantidad de Locales con Nivel 2 - Bueno: {nivel2}");
            Console.WriteLine($"Cantidad de Locales con Nivel 3 - Regular: {nivel3}");
            Console.WriteLine($"Cantidad de Locales con Nivel 4 - Inicial: {nivel4}");     
        }
    }
}