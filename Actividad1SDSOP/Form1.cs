using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Actividad1SDSOP
{
    public partial class Form1 : Form
    {
        List<Proceso> Procesos = new List<Proceso>();
        List<Marco> MemoriaP = new List<Marco>(40);
        private bool Pausar = false;
        private bool Error = false;
        private bool Interrupcion = false;
        private bool Bcp = false;
        int Contador = 0;
        int IDAux = 0;
        int Quantum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        bool vacia()
        {
            bool aux = true;
            for(int i = 0; i < Procesos.Count; i++)
            {
                if (Procesos[i].Estatus != 4)
                {
                    aux = false;
                }
            }
            return aux;
        }

        int cuatroEnMemoria()
        {
            int aux = 0;
            for (int i = 0; i < Procesos.Count; i++)
            {
                if (Procesos[i].Estatus != 0 && Procesos[i].Estatus != 4 )
                {
                    aux++;
                }
            }
            return aux;
        }

        int NoNuevos()
        {
            int aux = 0;
            for(int i = 0; i<Procesos.Count; i++)
            {
                if(Procesos[i].Estatus == 0)
                {
                    aux++;
                }
            }
            return aux;
        }

        string Resueltos()
        {
            string texto = "";
            for(int i = 0; i<Procesos.Count; i++)
            {
                if (Procesos[i].Estatus == 4)
                {
                    texto += Procesos[i].imprimirTerminado();
                }
            }
            return texto;
        }

        string Bloqueados()
        {
            string texto = "";
            for(int i = 0;i < Procesos.Count; i++)
            {
                if (Procesos[i].Estatus == 3)
                {
                    if (Procesos[i].TiempoBloqueado == 7)
                    {
                        Procesos[i].Estatus = 1;
                        Procesos[i].TiempoBloqueado = 0;
                    }
                    else
                    {
                        Procesos[i].TiempoBloqueado++;
                        Procesos[i].TiempoEspera++;
                    }
                    texto += Procesos[i].imprimirBloqueado();
                }
            }
            return texto;
        }

        string Listos()
        {
            string texto = "";
            for(int i = 0; i < Procesos.Count; i++)
            {
                if(Procesos[i].Estatus == 1)
                {
                    Procesos[i].TiempoEspera++;
                    if(Procesos[i].Primera == 0)
                    {
                        Procesos[i].TiempoRespuesta++;
                    }
                    texto += Procesos[i].imprimirListo();
                }
            }
            return texto;
        }

        string Ejecucion()
        {
            string texto = "";
            int aux = 0;
            for(int i = 0;i < Procesos.Count; i++)
            {
                if (Procesos[i].Estatus == 2)
                {
                    aux = 1;
                    if (Procesos[i].Primera == 0)
                    {
                        Procesos[i].Primera = 1;
                        Procesos[i].TiempoRespuesta = Contador - Procesos[i].TiempoLlegada;
                    }
                    Procesos[i].TiempoRestante--;
                    Procesos[i].TiempoTrascurrido++;
                    Procesos[i].TiempoServicio++;
                    Procesos[i].Quantum++;
                    if (Procesos[i].TiempoTrascurrido == Procesos[i].TiempoEstimado)
                    {
                        Procesos[i].Estatus = 4;
                        Procesos[i].TiempoFinalizacion = Contador;
                        Procesos[i].TiempoRetorno = Procesos[i].TiempoFinalizacion - Procesos[i].TiempoLlegada;
                        for (int y = 0; y < Procesos.Count; y++)
                        {
                            if (Procesos[y].Estatus == 0)
                            {
                                Procesos[y].Estatus = 1;
                                Procesos[y].TiempoLlegada = Contador;
                                break;
                            }
                        }
                    }
                    texto = Procesos[i].imprimirEjecucion();
                    if(Procesos[i].Quantum == Quantum && Procesos[i].TiempoTrascurrido != Procesos[i].TiempoEstimado)
                    {
                        Proceso rr = Procesos[i];
                        Procesos[i].Estatus = 1;
                        Procesos[i].Quantum = 0;
                        Procesos.RemoveAt(i);
                        Procesos.Add(rr);
                    }
                    
                }
            }
            if(aux == 0)
            {
                for (int i = 0; i < Procesos.Count; i++)
                {
                    if (Procesos[i].Estatus == 1)
                    {
                        Procesos[i].Estatus = 2;
                        break;
                    }
                }
            } 
            return texto;
        }

        private void tiempoInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonProcesar_Click(object sender, EventArgs e)
        {
            Pausar = false;
            worker.RunWorkerAsync();
            
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Quantum = (int)numericUpDownQuantum.Value;
            int i = (int)numericProcesos.Value;
            Random rnd = new Random();
            for (int y = 0; y < i; y++)
            {
                Proceso Otro = new Proceso();
                int tiempo = rnd.Next(7, 16);
                int operaciones = rnd.Next(1,6);
                int numeroUno = rnd.Next(1, 10);
                int numeroDos = rnd.Next(1, 10);
                int tamano = rnd.Next(6, 29);
                Otro.Tamano = tamano;
                Otro.Nombre = "Armando";
                Otro.TiempoTrascurrido = 0;
                Otro.TiempoRestante = tiempo;
                Otro.TiempoEstimado = tiempo;
                Otro.TiempoBloqueado = 0;
                Otro.TiempoLlegada = 0;
                Otro.TiempoFinalizacion = 0;
                Otro.TiempoRetorno = 0;
                Otro.TiempoRespuesta = 0;
                Otro.TiempoEspera = 0;
                Otro.TiempoServicio = 0;
                Otro.ID = y;
                IDAux = y;
                Otro.Estatus = 0;
                Otro.Primera = 0;
                Otro.Quantum = 0;
                if(operaciones == 1)
                {
                    string Operacion = numeroUno+ "+" + numeroDos;
                    Otro.Operaracion = Operacion;
                    Otro.Resultado = numeroUno + numeroDos;
                }
                else if (operaciones == 2)
                {
                    string Operacion = numeroUno + "-" + numeroDos;
                    Otro.Operaracion = Operacion;
                    Otro.Resultado = numeroUno - numeroDos;
                }
                else if (operaciones == 3)
                {
                    string Operacion = numeroUno + "*" + numeroDos;
                    Otro.Operaracion = Operacion;
                    Otro.Resultado = numeroUno * numeroDos;
                }
                else if (operaciones == 4)
                {
                    string Operacion = numeroUno + "/" + numeroDos;
                    Otro.Operaracion = Operacion;
                    Otro.Resultado = numeroUno / numeroDos;
                }
                else if (operaciones == 5)
                {
                    string Operacion = numeroUno + "%" + numeroDos;
                    Otro.Operaracion = Operacion;
                    Otro.Resultado = numeroUno % numeroDos;
                }
                else if (operaciones == 6)
                {
                    string Operacion = numeroUno + "^" + numeroDos;
                    Otro.Operaracion = Operacion;
                    Otro.Resultado = (float)Math.Pow(numeroUno,numeroDos);
                }
                Procesos.Add(Otro);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    Pausar = true;
                    break;
                case Keys.C:
                    Pausar = false;
                    Bcp = false;
                    break;
                case Keys.W:
                    Error = true;
                    break;
                case Keys.E:
                    Interrupcion = true;
                    break;
                case Keys.N:
                    Nuevo();
                    break;
                case Keys.T:
                    Bcp = true;
                    break;
            }
        }

        void Nuevo()
        {
            Random rnd = new Random();
            Proceso Otro = new Proceso();
            int tiempo = rnd.Next(7, 16);
            int operaciones = rnd.Next(1, 6);
            int numeroUno = rnd.Next(1, 10);
            int numeroDos = rnd.Next(1, 10);
            Otro.Nombre = "Armando";
            Otro.TiempoTrascurrido = 0;
            Otro.TiempoRestante = tiempo;
            Otro.TiempoEstimado = tiempo;
            Otro.TiempoBloqueado = 0;
            Otro.TiempoLlegada = Contador;
            Otro.TiempoFinalizacion = 0;
            Otro.TiempoRetorno = 0;
            Otro.TiempoRespuesta = 0;
            Otro.TiempoEspera = 0;
            Otro.TiempoServicio = 0;
            Otro.ID = IDAux + 1;
            IDAux++;
            Otro.Estatus = 0;
            if (cuatroEnMemoria() < 4)
            {
                Otro.Estatus = 1;
            }
            Otro.Primera = 0;
            if (operaciones == 1)
            {
                string Operacion = numeroUno + "+" + numeroDos;
                Otro.Operaracion = Operacion;
                Otro.Resultado = numeroUno + numeroDos;
            }
            else if (operaciones == 2)
            {
                string Operacion = numeroUno + "-" + numeroDos;
                Otro.Operaracion = Operacion;
                Otro.Resultado = numeroUno - numeroDos;
            }
            else if (operaciones == 3)
            {
                string Operacion = numeroUno + "*" + numeroDos;
                Otro.Operaracion = Operacion;
                Otro.Resultado = numeroUno * numeroDos;
            }
            else if (operaciones == 4)
            {
                string Operacion = numeroUno + "/" + numeroDos;
                Otro.Operaracion = Operacion;
                Otro.Resultado = numeroUno / numeroDos;
            }
            else if (operaciones == 5)
            {
                string Operacion = numeroUno + "%" + numeroDos;
                Otro.Operaracion = Operacion;
                Otro.Resultado = numeroUno % numeroDos;
            }
            else if (operaciones == 6)
            {
                string Operacion = numeroUno + "^" + numeroDos;
                Otro.Operaracion = Operacion;
                Otro.Resultado = (float)Math.Pow(numeroUno, numeroDos);
            }
            Procesos.Add(Otro);
        }

        string mostrarBCP()
        {
            string texto = "";
            for (int i = 0; i < Procesos.Count; i++)
            {
                if(Procesos[i].Estatus == 0)//nuevos
                {
                    texto += Procesos[i].ID + "     " + Procesos[i].Operaracion + "   " + "null" + "        "
                    + Procesos[i].TiempoEstimado + "     " + "null" + "     " + "null" + "     "
                    + "null" + "     " + "null" + "     " + "null" + "     "
                    + "null" + " Estatus: Nuevo\n";
                }
                else if (Procesos[i].Estatus == 1)//listos
                {
                    texto += Procesos[i].ID + "     " + Procesos[i].Operaracion + "   " + "null" + "        "
                    + Procesos[i].TiempoEstimado + "     " + Procesos[i].TiempoLlegada + "     " + "null" + "     "
                    + "null" + "     " + Procesos[i].TiempoRespuesta + "     " + Procesos[i].TiempoEspera + "     "
                    + Procesos[i].TiempoServicio + "   Estatus: Listo " + "TResCPU: "+ Procesos[i].TiempoRestante + "\n";
                }
                else if(Procesos[i].Estatus == 2)//ejecucion 
                {
                    texto += Procesos[i].ID + "     " + Procesos[i].Operaracion + "   " + "null" + "        "
                    + Procesos[i].TiempoEstimado + "     " + Procesos[i].TiempoLlegada + "     " + "null" + "     "
                    + "null" + "     " + Procesos[i].TiempoRespuesta + "     " + Procesos[i].TiempoEspera + "     "
                    + Procesos[i].TiempoServicio + "   Estatus: Ejecucion " + "TResCPU: " + Procesos[i].TiempoRestante + "\n";
                }
                else if (Procesos[i].Estatus == 3)//bloqueado 
                {
                    texto += Procesos[i].ID + "     " + Procesos[i].Operaracion + "   " + "null" + "        "
                    + Procesos[i].TiempoEstimado + "     " + Procesos[i].TiempoLlegada + "     " + Contador + "     "
                    + Procesos[i].TiempoRetorno  + "     " + Procesos[i].TiempoRespuesta + "     " + Procesos[i].TiempoEspera + "     "
                    + Procesos[i].TiempoServicio + "   Estatus: Bloqueado por:"+ Procesos[i].TiempoBloqueado + "  TResCPU: "+ Procesos[i].TiempoRestante + "\n";
                }
                else if (Procesos[i].Estatus == 4)//terminado 
                {
                    string aux;
                    if (Procesos[i].Resultado == 99999)
                    {
                        aux = "ERR";
                    }
                    else
                    {
                        aux = Procesos[i].Resultado.ToString();
                    }
                    texto += Procesos[i].ID + "     " + Procesos[i].Operaracion + "   " + aux + "        "
                    + Procesos[i].TiempoEstimado + "     " + Procesos[i].TiempoLlegada + "     " + Contador + "     "
                    + Procesos[i].TiempoRetorno + "     " + Procesos[i].TiempoRespuesta + "     " + Procesos[i].TiempoEspera + "     " 
                    + Procesos[i].TiempoServicio + "   Estatus: Terminado\n";
                }
            }
            return texto;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int conta = 0;
            for (int i = 0; i < Procesos.Count; i++)
            {
                if (Procesos[i].Estatus == 0)
                {
                    Procesos[i].Estatus = 1;
                    Procesos[i].TiempoLlegada = Contador;
                    conta++;
                }
                if(conta == 4)
                {
                    break;
                }
            }
            while (!vacia())
            {
                while (Pausar)
                {
                    Thread.Sleep(100);
                }
                while (Bcp)
                {
                    worker.ReportProgress(2);
                    Thread.Sleep(100);
                }
                if (Error)
                {
                    Error = false;
                    for(int i = 0;i < Procesos.Count; i++)
                    {
                        if(Procesos[i].Estatus == 2)
                        {
                            Procesos[i].Resultado = 99999;
                            Procesos[i].TiempoFinalizacion = Contador;
                            Procesos[i].TiempoRetorno = Procesos[i].TiempoFinalizacion - Procesos[i].TiempoLlegada;
                            Procesos[i].Estatus = 4;
                            for (int z = 0; z < Procesos.Count; z++)
                            {
                                if (Procesos[z].Estatus == 0)
                                {
                                    Procesos[z].Estatus = 1;
                                    Procesos[z].TiempoLlegada = Contador;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (Interrupcion)
                {
                    for (int i = 0; i < Procesos.Count; i++)
                    {
                        if (Procesos[i].Estatus == 2)
                        {
                            Procesos[i].Quantum = 0;
                            Procesos[i].Estatus = 3;
                            Proceso Aux = new Proceso();
                            Aux = Procesos[i];
                            Procesos.RemoveAt(i);
                            Procesos.Add(Aux);
                            break;
                        }
                    }
                    Interrupcion = false;
                }
                worker.ReportProgress(1);
                Contador++;
                Thread.Sleep(1000);
            }
            worker.ReportProgress(1);
        }


        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == 2)
            {
                labelResueltos.Text = mostrarBCP();
            }
            if(e.ProgressPercentage == 1)
            {
                labelBloqueados.Text = Bloqueados();
                labelResueltos.Text = Resueltos();
                labelLoteActual.Text = Listos();
                labelEjecucion.Text = Ejecucion();
                labelContador.Text = "Contador: " + Contador;
                labelNoDelotes.Text = "No. de nuevos: " + NoNuevos();
            }
            
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            System.Diagnostics.Debug.WriteLine($"FINALIZADO");
            
        }
    }
}
