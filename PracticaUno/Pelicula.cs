using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    internal class Pelicula
    {
        public string titulo;
        public string director;
        public string genero;
        public int duracion;
        public int añoEs;

        public void ActualizacionDatos(string titulo, string director, string genero, int duracion, int añoEs)
        {
            this.titulo = titulo;
            this.director = director;
            this.genero = genero;
            this.duracion = duracion;
            this.añoEs = añoEs;
        }



        public override string ToString()
        {
            return "TITULO:" + titulo + "  DIRECTOR:" + director + "   GENERO:" + genero + "  DURACION: " + duracion + " MIN " + " ESTRENO:" + añoEs + '\n';
        }
    }
}
