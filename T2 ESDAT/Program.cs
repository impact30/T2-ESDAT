using T2_ESDAT;

ArbolBBP arbolPersonas =  new ArbolBBP();

int opcion;

do
{
    Console.WriteLine("*****************************");
    Console.WriteLine("***** Arbol de Personas *****");
    Console.WriteLine("*****************************");
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Listar");
    Console.WriteLine("3. Mayores de cierta edad");
    Console.WriteLine("4. Antepenultimo");
    Console.WriteLine("5. Fin.");
    if (!int.TryParse(Console.ReadLine(), out opcion)) continue;
    Console.Clear();

    switch (opcion)
    {
        case 1:
            {
                Console.Write("DNI: ");
                int dni = int.Parse(Console.ReadLine());

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Persona p = new Persona { Dni = dni, Nombre = nombre, Edad = edad };
                arbolPersonas.Agrega(p);
                break;

            }
        case 2:
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Lista de personas");
                arbolPersonas.ImprimePre();
                break;
            }
        case 3:
            {
                Console.WriteLine("La cantidad de personas mayores a 40 es: "+ arbolPersonas.CantidadMayores(40));
                
                break;
            }
        case 4:
            {
                Console.WriteLine("La antepenultima persona es: ");
                arbolPersonas.Antepenultimo();
                break;
            }
    }
} while (opcion != 5);