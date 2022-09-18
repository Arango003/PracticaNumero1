using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Catalogo
    {
        List<Pelicula> lista = new List<Pelicula>();


        public int ValidacionPelicula(string titulo)
        {

            int Posicion = -1;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].titulo == titulo)
                {
                    Posicion = i;
                }
            }

            return Posicion;
        }

        public string listarPelicula()
        {
            string Lista = "";
            foreach (Pelicula p in lista)
            {
                Lista += p.ToString();
            }

            return Lista;
        }
        public void RegistroPelicula(Pelicula pelicula)
        {

            int a = ValidacionPelicula(pelicula.titulo);

            if (a < 0)
            {
                lista.Add(pelicula);

            }
            else
            {
                Console.WriteLine("ESTA PELICULA YA EXISTE");
            }
        }

        public void ActualizacionPelicula(Pelicula pelicula)
        {
            int a = ValidacionPelicula(pelicula.titulo);

            if (a >= 0)
            {
                this.lista[a].ActualizacionDatos(pelicula.titulo, pelicula.director, pelicula.genero, pelicula.duracion, pelicula.añoEs);
            }
            else
            {
                Console.WriteLine("PELICULA NO EXISTENTE");
            }
        }

        public void ListarPorNombre()
        {
            int posicion;
            string titulo;

            Console.WriteLine("Ingrese el nombre de la pelicula");
            titulo = Console.ReadLine();
            posicion = ValidacionPelicula(titulo);

            if (posicion >= 0)
            {
                Console.WriteLine("TITULO:" + lista[posicion].titulo + "  DURACION:" + lista[posicion].duracion + " MIN" + "  ESTRENO:" + lista[posicion].añoEs + "  DIRECTOR:" + lista[posicion].director + "   GENERO:" + lista[posicion].genero + '\n');
            }
            else
            {
                Console.WriteLine("ERROR!");
            }

        }

        public void ListarPorDirector()
        {
            int posicion;
            string director;

            Console.WriteLine("Ingrese el nombre del director");
            director = Console.ReadLine();

            posicion = this.lista.FindIndex(pelicula => pelicula.director == director); ;

            if (posicion >= 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].director == director)
                    {
                        Console.WriteLine("TITULO:" + lista[i].titulo + "  DURACION:" + lista[i].duracion + " MIN" + "  ESTRENO:" + lista[i].añoEs + "  DIRECTOR:" + lista[i].director + "   GENERO:" + lista[i].genero + '\n');
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR");

            }

        }


        public void ListarPorGenero()
        {
            int posicion;
            string genero;

            Console.WriteLine("Ingrese el genero");
            genero = Console.ReadLine();

            posicion = this.lista.FindIndex(pelicula => pelicula.genero == genero); ;

            if (posicion >= 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].genero == genero)
                    {

                        Console.WriteLine("TITULO:" + lista[i].titulo + "  DURACION:" + lista[i].duracion + " MIN" + "  ESTRENO:" + lista[i].añoEs + "  DIRECTOR:" + lista[i].director + "   GENERO:" + lista[i].genero + '\n');


                    }
                }
            }
            else
            {
                Console.WriteLine("eroor");

            }

        }

    }
}
