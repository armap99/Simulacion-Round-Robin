namespace Actividad1SDSOP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonProcesar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelErrorOperacion = new System.Windows.Forms.Label();
            this.labelLoteActual = new System.Windows.Forms.Label();
            this.labelEjecucion = new System.Windows.Forms.Label();
            this.labelResueltos = new System.Windows.Forms.Label();
            this.labelContador = new System.Windows.Forms.Label();
            this.labelNoDelotes = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.numericProcesos = new System.Windows.Forms.NumericUpDown();
            this.labelNoProcesos = new System.Windows.Forms.Label();
            this.labelBloqueados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownQuantum = new System.Windows.Forms.NumericUpDown();
            this.labelProcesoSiguiente = new System.Windows.Forms.Label();
            this.Memoria = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelEnMemoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProcesar
            // 
            this.buttonProcesar.Location = new System.Drawing.Point(652, 408);
            this.buttonProcesar.Name = "buttonProcesar";
            this.buttonProcesar.Size = new System.Drawing.Size(99, 25);
            this.buttonProcesar.TabIndex = 0;
            this.buttonProcesar.Text = "Procesar";
            this.buttonProcesar.UseVisualStyleBackColor = true;
            this.buttonProcesar.Click += new System.EventHandler(this.buttonProcesar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(31, 408);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(89, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelErrorOperacion
            // 
            this.labelErrorOperacion.AutoSize = true;
            this.labelErrorOperacion.Location = new System.Drawing.Point(246, 83);
            this.labelErrorOperacion.Name = "labelErrorOperacion";
            this.labelErrorOperacion.Size = new System.Drawing.Size(0, 13);
            this.labelErrorOperacion.TabIndex = 6;
            // 
            // labelLoteActual
            // 
            this.labelLoteActual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLoteActual.Location = new System.Drawing.Point(246, 32);
            this.labelLoteActual.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelLoteActual.Name = "labelLoteActual";
            this.labelLoteActual.Size = new System.Drawing.Size(174, 142);
            this.labelLoteActual.TabIndex = 9;
            this.labelLoteActual.Text = "Listo";
            // 
            // labelEjecucion
            // 
            this.labelEjecucion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEjecucion.Location = new System.Drawing.Point(246, 188);
            this.labelEjecucion.Name = "labelEjecucion";
            this.labelEjecucion.Size = new System.Drawing.Size(174, 153);
            this.labelEjecucion.TabIndex = 10;
            this.labelEjecucion.Text = "Ejecucion";
            // 
            // labelResueltos
            // 
            this.labelResueltos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelResueltos.Location = new System.Drawing.Point(426, 35);
            this.labelResueltos.Name = "labelResueltos";
            this.labelResueltos.Size = new System.Drawing.Size(552, 305);
            this.labelResueltos.TabIndex = 11;
            this.labelResueltos.Text = "Resueltos";
            // 
            // labelContador
            // 
            this.labelContador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelContador.Location = new System.Drawing.Point(246, 371);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(174, 20);
            this.labelContador.TabIndex = 12;
            this.labelContador.Text = "Contador:0";
            // 
            // labelNoDelotes
            // 
            this.labelNoDelotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoDelotes.Location = new System.Drawing.Point(426, 374);
            this.labelNoDelotes.Name = "labelNoDelotes";
            this.labelNoDelotes.Size = new System.Drawing.Size(271, 17);
            this.labelNoDelotes.TabIndex = 13;
            this.labelNoDelotes.Text = "No. de Nuevos:";
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // numericProcesos
            // 
            this.numericProcesos.Location = new System.Drawing.Point(13, 32);
            this.numericProcesos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericProcesos.Name = "numericProcesos";
            this.numericProcesos.Size = new System.Drawing.Size(120, 20);
            this.numericProcesos.TabIndex = 14;
            this.numericProcesos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNoProcesos
            // 
            this.labelNoProcesos.AutoSize = true;
            this.labelNoProcesos.Location = new System.Drawing.Point(13, 13);
            this.labelNoProcesos.Name = "labelNoProcesos";
            this.labelNoProcesos.Size = new System.Drawing.Size(85, 13);
            this.labelNoProcesos.TabIndex = 15;
            this.labelNoProcesos.Text = "No. de procesos";
            // 
            // labelBloqueados
            // 
            this.labelBloqueados.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBloqueados.Location = new System.Drawing.Point(28, 188);
            this.labelBloqueados.Name = "labelBloqueados";
            this.labelBloqueados.Size = new System.Drawing.Size(174, 153);
            this.labelBloqueados.TabIndex = 16;
            this.labelBloqueados.Text = "Bloqueados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Listo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Terminado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Bloqueados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID   TTB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ID   TME   TT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ejecucion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID  Ope   Resul  TME  TL  TF  TR  TRes TE  TS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ingrese el Quantum:";
            // 
            // numericUpDownQuantum
            // 
            this.numericUpDownQuantum.Location = new System.Drawing.Point(12, 83);
            this.numericUpDownQuantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantum.Name = "numericUpDownQuantum";
            this.numericUpDownQuantum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownQuantum.TabIndex = 25;
            this.numericUpDownQuantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelProcesoSiguiente
            // 
            this.labelProcesoSiguiente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProcesoSiguiente.Location = new System.Drawing.Point(703, 371);
            this.labelProcesoSiguiente.Name = "labelProcesoSiguiente";
            this.labelProcesoSiguiente.Size = new System.Drawing.Size(275, 25);
            this.labelProcesoSiguiente.TabIndex = 26;
            this.labelProcesoSiguiente.Text = "Proceso Siguiente:";
            // 
            // Memoria
            // 
            this.Memoria.AutoSize = true;
            this.Memoria.Location = new System.Drawing.Point(995, 6);
            this.Memoria.Name = "Memoria";
            this.Memoria.Size = new System.Drawing.Size(47, 13);
            this.Memoria.TabIndex = 27;
            this.Memoria.Text = "Memoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(995, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Marco Espacio ID  Estado";
            // 
            // labelEnMemoria
            // 
            this.labelEnMemoria.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEnMemoria.Location = new System.Drawing.Point(997, 39);
            this.labelEnMemoria.Name = "labelEnMemoria";
            this.labelEnMemoria.Size = new System.Drawing.Size(361, 392);
            this.labelEnMemoria.TabIndex = 29;
            this.labelEnMemoria.Text = "Memoria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 450);
            this.Controls.Add(this.labelEnMemoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Memoria);
            this.Controls.Add(this.labelProcesoSiguiente);
            this.Controls.Add(this.numericUpDownQuantum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBloqueados);
            this.Controls.Add(this.labelNoProcesos);
            this.Controls.Add(this.numericProcesos);
            this.Controls.Add(this.labelNoDelotes);
            this.Controls.Add(this.labelContador);
            this.Controls.Add(this.labelResueltos);
            this.Controls.Add(this.labelEjecucion);
            this.Controls.Add(this.labelLoteActual);
            this.Controls.Add(this.labelErrorOperacion);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonProcesar);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcesar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelErrorOperacion;
        private System.Windows.Forms.Label labelLoteActual;
        private System.Windows.Forms.Label labelEjecucion;
        private System.Windows.Forms.Label labelResueltos;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Label labelNoDelotes;
        public System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.NumericUpDown numericProcesos;
        private System.Windows.Forms.Label labelNoProcesos;
        private System.Windows.Forms.Label labelBloqueados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantum;
        private System.Windows.Forms.Label labelProcesoSiguiente;
        private System.Windows.Forms.Label Memoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelEnMemoria;
    }
}

