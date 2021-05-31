using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1SDSOP
{
    class Proceso
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int TiempoEstimado { get; set; }
        public int TiempoTrascurrido { get; set; }
        public int TiempoRestante { get; set; }
        public string Operaracion { get; set; }
        public float Resultado { get; set; }
        public int Estatus { get; set; }
        public int TiempoBloqueado { get; set; }
        public int TiempoLlegada { get; set; }
        public int TiempoFinalizacion { get; set; }
        public int TiempoRetorno { get; set; }
        public int TiempoRespuesta { get; set; }
        public int TiempoEspera { get; set; }
        public int TiempoServicio { get; set; }
        public int Primera { get; set; }
        public int Quantum { get; set; }
        public int Tamano { get; set; }

        public string imprimirListo()
        {
            string texto = " " + ID + "      " + TiempoEstimado + "        " + TiempoTrascurrido + "\n";
            return texto;
        }

        public string imprimirBloqueado()
        {
            string texto =" " + ID + "       " + TiempoBloqueado + "\n";
            return texto;
        }

        public string imprimirEjecucion()
        {
            string texto = "ID: " + ID + "\n"
                +"Nombre: " + Nombre + "\n"
                + "Operacion: " + Operaracion + "\n"
                + "TME: " + TiempoEstimado + "\n"
                + "TT: " + TiempoTrascurrido + "\n"
                + "TR: " + TiempoRestante + "\n" 
                + "TTQ: " + Quantum;
            return texto;
        }

        public string imprimirTerminado()
        {
            string aux;
            if(Resultado == 99999)
            {
                aux = "ERR";
            }
            else
            {
                aux = Resultado.ToString();
            }
            string texto = ID + "     " + Operaracion + "   " + aux + "        "
                + TiempoEstimado + "     " + TiempoLlegada + "     " + TiempoFinalizacion + "     "
                + TiempoRetorno + "     " + TiempoRespuesta + "     " + TiempoEspera + "     " + TiempoServicio + "\n";

            return texto;
        }
    }
}
