using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogopeli = new Catalogo();

            int swi = 11;
            while (swi != 0)
            {

                List<Pelicula> lista = new List<Pelicula>();
                Console.WriteLine("menu ");
                Console.WriteLine("1.agregar pelicula");
                Console.WriteLine("2.buscar pelicula por nombr");
                Console.WriteLine("3.listar pelicula ppr el director");
                Console.WriteLine("4.listar pelicula por genero");
                Console.WriteLine("5.ver todas las peliculas");
                Console.WriteLine("0.Salir");
                swi = int.Parse(Console.ReadLine());
                Pelicula pelicula = new Pelicula();




                if (swi == 1)
                {
                    Console.WriteLine("ingresa el titulo de la pelicula");
                    pelicula.titulo = Console.ReadLine();

                    int a = catalogopeli.ValidacionPelicula(pelicula.titulo);

                    if (a >= 0)
                    {
                        string Opc;
                        Console.WriteLine(" pelicula ya esta en el catalogo! deseas actualizarla? Si/No");
                        Opc = Console.ReadLine();
                        if (Opc == "si")
                        {
                            Console.WriteLine("AÑO DE LA PELICULA");
                            pelicula.añoEs = int.Parse(Console.ReadLine());

                            Console.WriteLine("DIRECTOR DE LA PELICULA");
                            pelicula.director = Console.ReadLine();



                            Console.WriteLine("GENERO DE LA PELICULA");
                            pelicula.genero = Console.ReadLine();

                            catalogopeli.ActualizacionPelicula(pelicula);
                        }
                        else if (Opc == "no")
                        {
                            break;
                        }


                    }
                    else if (a == -1)
                    {
                        Console.WriteLine("DIRECTOR DE LA PELICULA");
                        pelicula.director = Console.ReadLine();

                        Console.WriteLine("GENERO DE LA PELICULA");
                        pelicula.genero = Console.ReadLine();

                        Console.WriteLine("DURACION DE LA PELICULA");
                        pelicula.duracion = int.Parse(Console.ReadLine());

                        Console.WriteLine("AÑO DE ESTRENO DE LA PELICULA");
                        pelicula.añoEs = int.Parse(Console.ReadLine());

                        catalogopeli.RegistroPelicula(pelicula);
                    }

                }
                else if (swi == 2)
                {
                    catalogopeli.ListarPorNombre();
                }
                else if (swi == 3)
                {
                    catalogopeli.ListarPorDirector();
                }
                else if (swi == 4)
                {
                    catalogopeli.ListarPorGenero();
                }
                else if (swi == 5)
                {
                    Console.WriteLine(catalogopeli.listarPelicula());
                }

            }
        }

    }
}
