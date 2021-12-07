//Espacio del Problema
//Estamos trabajando en una empresa dedicada al negocio de venta de ropa deportiva y nos piden una
//cantidad de informes y datos que hay que entregar sobre los clubes de la Ciudad de Buenos Aires.
//Además, nos piden que hagamos un programa con un menú para que el usuario elija el
//reporte/información que necesite.
//Se sabe, que la cantidad total de Clubes es de 300, pero al inicio de éste espacio del problema, sólo
//se encuentran cargados 100.
//De cada Institución, se tiene la siguiente información:
//-Id del Club.
//- Nombre.
//- Tipo de Institución (Club o Club de Barrio).
//-Sede(Central – Única – Anexo - Polideportivo).
//- Cantidad de Socios.
//- Barrio.
//- Comuna (Identificado por un número entero).
//-Domicilio.
//- Teléfono.
//- E - mail.
//- Página web.
//- Actividades(Fútbol – Básquet – Natación – Voley – Tenis – Artes Marciales).
//Consignas a resolver
//Un analista de sistemas acostumbrado a trabajar con un marco de trabajo de Agile genera la siguiente
//lista de consignas que el programa debe resolver:
//1.Como usuario quiero tener la cantidad de clubes que están registrados.
//2. Cómo usuario, quiero poder añadir un Club al final de los ya existentes, mientras que esté en el
//rango de los 300 lugares considerados.
//3. Como usuario quiero tener un reporte de todos los clubes ordenados por el id. (usar Algoritmo de
//Burbujeo).
//4.Como usuario quiero tener un reporte de todos los clubes ordenados por el nombre del Club.
//5. Como usuario quiero poder ingresar el Nro. de Id de un club y que me muestre información que
//tenga sobre el mismo. (usar Algoritmo de búsqueda binaria).
//6.Como usuario quiero tener un reporte de todos los clubes ordenados por cantidad de socios (usar
//Algoritmo de Burbujeo)
//7.Como usuario quiero tener un reporte de todos los clubes que tengan declarada cierta actividad
//deportiva (fútbol, básquet, vóley, etc). Este reporte debe pedirme por consola la actividad que
//quiero buscar y luego sacar el reporte. Además, quiero generar un nuevo vector, de cada uno de
//los tipos de actividades.
//8. Como usuario quiero tener un reporte de todos los clubes que tengan una página web. El reporte lo
//necesito ordenado por Comuna (usar Algoritmo de Burbujeo).
//9.Como usuario quiero tener un reporte que diga el Id y nombre, del Club que mayor cantidad de
//socios tiene.

using System;

namespace tpintegrador
{
    class Program
    {
        static void cargarClub(ref int[] vecId, ref String[] vecNombre, ref String[] vecTipo, ref String[] vecSede, ref int[] vecCantSocios,
        ref String[] vecBarrio, ref int[] vecComuna, ref String[] vecDomicilio, ref int[] vecTelefono, ref String[] vecEmail,
        ref String[] vecWeb, ref String[] vecActividades, ref int cantidad)
        {

            Console.WriteLine("ingrese Id del club: ");
            vecId[cantidad] = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el Nombre del club del club: ");
            vecNombre[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese el tipo: ");
            vecTipo[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese la sede del club: ");
            vecSede[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese la cantidad de socios: ");
            vecCantSocios[cantidad] = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el barrio: ");
            vecBarrio[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese la comuna: ");
            vecComuna[cantidad] = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el domicilio: ");
            vecDomicilio[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese el Telefono: ");
            vecTelefono[cantidad] = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el Email: ");
            vecEmail[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese la página Web: ");
            vecWeb[cantidad] = Console.ReadLine();
            Console.WriteLine("ingrese las actividades: ");
            vecActividades[cantidad] = Console.ReadLine();
            cantidad++;

        }

        static void mostrarTodo(ref int[] vecId, ref String[] vecNombre, ref String[] vecTipo, ref String[] vecSede, ref int[] vecCantSocios,
        ref String[] vecBarrio, ref int[] vecComuna, ref String[] vecDomicilio, ref int[] vecTelefono, ref String[] vecEmail,
        ref String[] vecWeb, ref String[] vecActividades, ref int cantidad)
        {
            int i;
            Console.WriteLine("Este es el listado completo de clubes: ");
            for (i = 0; i < cantidad; i++)

                Console.Write(vecId[i] + "\n" + vecNombre[i] + "\n" + vecTipo[i] + "\n " + vecSede[i] + vecCantSocios[i] + "\n" + vecBarrio[i] + "\n" + vecComuna[i] + ""
                    + vecDomicilio[i] + "\n" + vecTelefono[i] + "\n" + vecEmail[i] + "\n" + vecWeb[i] + "\n" + vecActividades[i]);
        }

        static void ordenarPorId(ref int[] vecId, ref String[] vecNombre, ref String[] vecTipo, ref String[] vecSede, ref int[] vecCantSocios,
        ref String[] vecBarrio, ref int[] vecComuna, ref String[] vecDomicilio, ref int[] vecTelefono, ref String[] vecEmail,
        ref String[] vecWeb, ref String[] vecActividades, int cantidad)
        {   //ordeno el vector por ID mediante algoritmo de burbujeo
            int i, k, auxID, auxCantSocios, auxComuna,  auxTelefono;
            String auxNom, auxTipo, auxSede, auxBarrio, auxEmail, auxDomicilio, auxWeb;
            k = 0;
            int total = cantidad;
            while (k == 0)
            {
                k = 1;
                cantidad--;
                for (i = 0; i < cantidad; i++)
                    if (vecId[i] > vecId[i + 1])
                    {
                        k = 0;
                        auxID = vecId[i];
                        vecId[i] = vecId[i + 1];
                        vecId[i + 1] = auxID;

                        auxNom = vecNombre[i];
                        vecNombre[i] = vecNombre[i + 1];
                        vecNombre[i + 1] = auxNom;

                        auxTipo = vecTipo[i];
                        vecTipo[i] = vecTipo[i + 1];
                        vecTipo[i + 1] = auxTipo;

                        auxSede = vecSede[i];
                        vecSede[i] = vecSede[i + 1];
                        vecSede[i + 1] = auxSede;

                        auxCantSocios = vecCantSocios[i];
                        vecCantSocios[i] = vecCantSocios[i + 1];
                        vecCantSocios[i + 1] = auxCantSocios;

                        auxBarrio = vecBarrio[i];
                        vecBarrio[i] = vecBarrio[i + 1];
                        vecBarrio[i + 1] = auxBarrio;

                        auxComuna = vecComuna[i];
                        vecComuna[i] = vecComuna[i + 1];
                        vecComuna[i + 1] = auxComuna;

                        auxDomicilio = vecDomicilio[i];
                        vecDomicilio[i] = vecDomicilio[i + 1];
                        vecDomicilio[i + 1] = auxDomicilio;

                        auxTelefono = vecTelefono[i];
                        vecTelefono[i] = vecTelefono[i + 1];
                        vecTelefono[i + 1] = auxTelefono;

                        auxEmail = vecEmail[i];
                        vecEmail[i] = vecEmail[i + 1];
                        vecEmail[i + 1] = auxEmail;

                        auxWeb = vecWeb[i];
                        vecWeb[i] = vecWeb[i + 1];
                        vecWeb[i + 1] = auxWeb;
                    }
            }
            for (i = 0; i < total; i++)
            {
                Console.WriteLine("Id: " + vecId[i] + " Nombre del Club: " + vecNombre[i] + " " + vecSede[i]);
            }

        }

        static void buscarPorId(ref int[] vecId, ref String[] vecNombre, ref String[] vecTipo, ref String[] vecSede, ref int[] vecCantSocios,
        ref String[] vecBarrio, ref int[] vecComuna, ref String[] vecDomicilio, ref int[] vecTelefono, ref String[] vecEmail,
        ref String[] vecWeb, ref String[] vecActividades, int cantidad)
        {
            //ordeno el vector por Id mediante burbujeo
            int i, k, auxID, auxCantSocios, auxComuna, auxTelefono;
            String auxNom, auxTipo, auxSede, auxBarrio, auxDomicilio, auxEmail, auxWeb;
            k = 0;
            int total = cantidad;
            while (k == 0)
            {
                k = 1;
                cantidad--;
                for (i = 0; i < cantidad; i++)
                    if (vecId[i] > vecId[i + 1])
                    {
                        k = 0;
                        auxID = vecId[i];
                        vecId[i] = vecId[i + 1];
                        vecId[i + 1] = auxID;

                        auxNom = vecNombre[i];
                        vecNombre[i] = vecNombre[i + 1];
                        vecNombre[i + 1] = auxNom;

                        auxTipo = vecTipo[i];
                        vecTipo[i] = vecTipo[i + 1];
                        vecTipo[i + 1] = auxTipo;

                        auxSede = vecSede[i];
                        vecSede[i] = vecSede[i + 1];
                        vecSede[i + 1] = auxSede;

                        auxCantSocios = vecCantSocios[i];
                        vecCantSocios[i] = vecCantSocios[i + 1];
                        vecCantSocios[i + 1] = auxCantSocios;

                        auxBarrio = vecBarrio[i];
                        vecBarrio[i] = vecBarrio[i + 1];
                        vecBarrio[i + 1] = auxBarrio;

                        auxComuna = vecComuna[i];
                        vecComuna[i] = vecComuna[i + 1];
                        vecComuna[i + 1] = auxComuna;

                        auxDomicilio = vecDomicilio[i];
                        vecDomicilio[i] = vecDomicilio[i + 1];
                        vecDomicilio[i + 1] = auxDomicilio;

                        auxTelefono = vecTelefono[i];
                        vecTelefono[i] = vecTelefono[i + 1];
                        vecTelefono[i + 1] = auxTelefono;

                        auxEmail = vecEmail[i];
                        vecEmail[i] = vecEmail[i + 1];
                        vecEmail[i + 1] = auxEmail;

                        auxWeb = vecWeb[i];
                        vecWeb[i] = vecWeb[i + 1];
                        vecWeb[i + 1] = auxWeb;
                    }
            }
            //busqueda binaria
            int pos = -1;
            int min = 0;
            int max = total - 1;
            int pivote, buscado;
            Console.WriteLine("Ingrese el ID que desea buscar: ");
            buscado = int.Parse(Console.ReadLine());
            while ((min <= max) && (pos < 0))
            {
                pivote = (min + max) / 2;
                if (vecId[pivote] == buscado)
                    pos = pivote;
                if (vecId[pivote] < buscado)
                    min = pivote + 1;
                else
                    max = pivote - 1;
            }
            if (pos >= 0) {
                Console.WriteLine("Nombre: " + vecNombre[pos] + "\nBarrio: " + vecBarrio[pos] + "\nTipo: " +vecTipo[pos] +"\nSede: " + vecSede[pos] +
                    "\nCantidad de socios: " + vecCantSocios[pos] + "\nComuna: " + vecComuna[pos] + "\nDomicilio: " + vecDomicilio[pos] + "\nTelefono: " + vecTelefono[pos] +
                    "\nEmail: " + vecEmail[pos] + "\nSitio web: " + vecWeb[pos] + "\nActividades: " + vecActividades[pos]);
            }
            else {
                Console.WriteLine("El elemento buscado no se encuentra en esta lista!");
            }
        }

        static void buscarConPaginaWeb(String [] vecNombre, String [] vecWeb, int [] vecComuna, int cantidad)
        {
            int i, auxComuna;
            String auxWeb, auxClub;
            int k = 0;
            int c = 0;
            int total = 0;
            String[] webClub = new String[10];
            String[] club = new String[10];
            int[] comuna = new int[10];
            
            for (i = 0; i < cantidad; i++)
            {
                if (vecWeb[i] != null)
                {
                    //creo nuevos vectores para los clubes con pagina web
                    webClub[c] = vecWeb[i];
                    club[c] = vecNombre[i];
                    comuna[c] = vecComuna[i];
                    total++;
                    c++;
                }
            }
            //ordeno por algoritmo de burbujeo
            while (k == 0)
            {
                k = 1;
                cantidad--;
                for (i = 0; i < cantidad; i++)
                {
                    if (comuna[i] > comuna[i + 1])
                    {
                        k = 0;
                        auxComuna = comuna[i];
                        comuna[i] = comuna[i + 1];
                        comuna[i + 1] = auxComuna;

                        auxWeb = webClub[i];
                        webClub[i] = webClub[i + 1];
                        webClub[i + 1] = auxWeb;

                        auxClub = club[i];
                        club[i] = club[i + 1];
                        club[i + 1] = auxClub;
                    }
                }
            }

            for (i = 0; i < total; i++)
            {
                Console.WriteLine("\nClub: " + club[i] + "\nDirección web: " + webClub[i] + "\nComuna nº: " + comuna[i]);

            }

        }

        static void maxSocios(int[] cantSocios, int[] vecId, String[] vecNombre, int cantidad)
        {
            int i;
            int posMax = 0;
            int maximo = cantSocios[0];
            for (i = 1; i < cantidad; i++) { 
                if (cantSocios[i] > maximo)
                    cantSocios[i] = posMax;
            }

            Console.WriteLine("Cantidad de socios: " + cantSocios[posMax] + " - ID: " + vecId[posMax] + " -Nombre del club: " + vecNombre[posMax]);
        }

        static void ordenarPorSocios(int[] vecId,String[] vecNombre,int[] vecCantSocios, int cantidad)
        {
            //ordeno mediante algoritmo de burbujeo
            int i, k, auxID, auxCantSocios;
            String auxNom;
            k = 0;
            int total = cantidad;
            while (k == 0)
            {
                k = 1;
                cantidad--;
                for (i = 0; i < cantidad; i++)
                    if (vecCantSocios[i] > vecCantSocios[i + 1])
                    {
                        k = 0;
                        auxID = vecId[i];
                        vecId[i] = vecId[i + 1];
                        vecId[i + 1] = auxID;

                        auxNom = vecNombre[i];
                        vecNombre[i] = vecNombre[i + 1];
                        vecNombre[i + 1] = auxNom;


                        auxCantSocios = vecCantSocios[i];
                        vecCantSocios[i] = vecCantSocios[i + 1];
                        vecCantSocios[i + 1] = auxCantSocios;
                    }
            }
            for (i = 0; i < total; i++)
            {
                Console.WriteLine("Cantidad de socios: " + vecCantSocios[i] + " - ID: " + vecId[i] + " - Nombre del Club: " + vecNombre[i]);
            }

        }

        static void buscarPorActividad(String[] vecActividades, String[] vecNombre, int[] vecId, int cantidad)
        {
            int i;
            String respuesta;
            Console.WriteLine("Ingrese una actividad: ");
            respuesta = Console.ReadLine();
            for (i = 0; i < cantidad; i++)
            {
                if (respuesta == vecActividades[i])
                {
                    Console.WriteLine("Club: " + vecNombre[i]);
                }

            }

        }

        static void ordenarAlfabeticamente(String[] vecNombre, int capacidad)
        {
            int i;
            //Ordenar Array Ascendentemente
            Array.Sort(vecNombre);

            //Imprimir
            Console.WriteLine("Clubes ordenados alfabeticamente:");
            for (i = 0; i < capacidad; i++)
            {
                if (vecNombre[i] != null) { 
                Console.WriteLine(vecNombre[i]);
                }
            }
        }


        static void Main(string[] args)
        {

            int[] vecId = { 23, 34, 87, 2, 9, 0, 0, 0, 0, 0 };
            String[] vecNombre = { "Boca", "River", "Independiente", "San Lorenzo", "Racing", null, null, null, null, null };
            String[] vecTipo = { "club", "club", "Club de barrio", "Club de Barrio", "Club", null, null, null, null, null };
            String[] vecSede = { "Central", "Central", "Unica", "Anexo", "Polideportivo", null, null, null, null, null };
            int[] vecCantSocios = { 200000000, 15000, 3540, 445450, 44443, 0, 0, 0, 0, 0 };
            String[] vecBarrio = { "La Boca", "Belgrano", "Avellaneda", "Boedo", "Avellaneda", null, null, null, null, null };
            int[] vecComuna = { 12, 2, 45, 42, 5, 0, 0, 0, 0, 0 };
            String[] vecDomicilio = { "calle falsa 123", "juan perez 222", "calle 114 244", "calle abc 123", "calle asdf 233", null, null, null, null, null};
            int[] vecTelefono = { 44445555, 11112222, 333335555, 2222333, 55550000, 0, 0, 0, 0, 0 };
            String[] vecEmail = { "mail1", "mail2", "mail3", "mail4", "mail5", null, null, null, null, null };
            String[] vecWeb = { "www.boca.com", "www.river.com", "www.independiente.com", "www.slo.com", "www.racing.com", null, null, null, null, null };
            String[] vecActividades = { "futbol", "basquet", "futbol", "volley", "handball", null, null, null, null, null };


            int respuesta;
            int cantidad = 5;
            String continua = "s";
            int capacidad = 10;

            while (continua == "s" || continua == "S")
            {
                Console.WriteLine("***MENU***\n" +
                "1- Cantidad de clubes registrados.\n" +
                "2- Añadir Club.\n" +
                "3- Ordenar clubes por id.\n" +
                "4- Ordenar clubes por nombre.\n" +
                "5- Obtener información por ID.\n" +
                "6- Ordenar los clubes por cantidad de socios.\n" +
                "7- Buscar clubes por Activdad.\n" +
                "8- Clubes con pagina Web, ordenados por comuna.\n" +
                "9- Ordenar por cantidad de socios, mostrar ID y Nombre.\n");

            
            Console.WriteLine("Ingrese el reporte que desea genear:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                    case 1:
                        Console.WriteLine("La cantidad de clubes registrados es: " + cantidad);
                        break;
                    case 2:
                        cargarClub(ref vecId, ref vecNombre, ref vecTipo, ref vecSede, ref vecCantSocios, ref vecBarrio,
                        ref vecComuna, ref vecDomicilio, ref vecTelefono, ref vecEmail, ref vecWeb, ref vecActividades, ref cantidad);
                        break;
                    case 3:
                        ordenarPorId(ref vecId, ref vecNombre, ref vecTipo, ref vecSede, ref vecCantSocios, ref vecBarrio,
                        ref vecComuna, ref vecDomicilio, ref vecTelefono, ref vecEmail, ref vecWeb, ref vecActividades, cantidad);
                        break;
                    case 4:
                        ordenarAlfabeticamente(vecNombre, capacidad);
                        break;
                    case 5:
                        buscarPorId(ref vecId, ref vecNombre, ref vecTipo, ref vecSede, ref vecCantSocios, ref vecBarrio,
                    ref vecComuna, ref vecDomicilio, ref vecTelefono, ref vecEmail, ref vecWeb, ref vecActividades, cantidad);
                        break;
                    case 6:
                        ordenarPorSocios(vecId, vecNombre, vecCantSocios, cantidad);
                        break;
                    case 7:
                        buscarPorActividad(vecActividades, vecNombre, vecId, cantidad);
                        break;
                    case 8:
                        buscarConPaginaWeb(vecNombre, vecWeb, vecComuna, cantidad);
                        break;
                    case 9:
                        maxSocios(vecCantSocios, vecId, vecNombre, cantidad);
                        break;
                }

                Console.WriteLine("Desea realizar otro reporte? s para continuar, cualquier otra tecla para finalizar: ");
                continua = Console.ReadLine();
            }
        }
    }
}
