namespace Tezt_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_cuadro = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_consonante = new System.Windows.Forms.Label();
            this.lbl_vocal = new System.Windows.Forms.Label();
            this.lbl_linea = new System.Windows.Forms.Label();
            this.lbl_tabulador = new System.Windows.Forms.Label();
            this.lbl_espacio = new System.Windows.Forms.Label();
            this.lbl_caracter = new System.Windows.Forms.Label();
            this.lbl_palabra = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_quitar = new System.Windows.Forms.ComboBox();
            this.btn_procesar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo: ";
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(69, 28);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(296, 20);
            this.txt_ruta.TabIndex = 1;
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(390, 26);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 2;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_cuadro
            // 
            this.txt_cuadro.Location = new System.Drawing.Point(16, 77);
            this.txt_cuadro.Name = "txt_cuadro";
            this.txt_cuadro.ReadOnly = true;
            this.txt_cuadro.Size = new System.Drawing.Size(455, 245);
            this.txt_cuadro.TabIndex = 3;
            this.txt_cuadro.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carácteres: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Espacios en blanco: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tabuladores: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Líneas: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Vocales: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Consonantes: ";
            // 
            // lbl_consonante
            // 
            this.lbl_consonante.AutoSize = true;
            this.lbl_consonante.Location = new System.Drawing.Point(430, 490);
            this.lbl_consonante.Name = "lbl_consonante";
            this.lbl_consonante.Size = new System.Drawing.Size(13, 13);
            this.lbl_consonante.TabIndex = 17;
            this.lbl_consonante.Text = "0";
            // 
            // lbl_vocal
            // 
            this.lbl_vocal.AutoSize = true;
            this.lbl_vocal.Location = new System.Drawing.Point(430, 467);
            this.lbl_vocal.Name = "lbl_vocal";
            this.lbl_vocal.Size = new System.Drawing.Size(13, 13);
            this.lbl_vocal.TabIndex = 16;
            this.lbl_vocal.Text = "0";
            // 
            // lbl_linea
            // 
            this.lbl_linea.AutoSize = true;
            this.lbl_linea.Location = new System.Drawing.Point(430, 443);
            this.lbl_linea.Name = "lbl_linea";
            this.lbl_linea.Size = new System.Drawing.Size(13, 13);
            this.lbl_linea.TabIndex = 15;
            this.lbl_linea.Text = "0";
            // 
            // lbl_tabulador
            // 
            this.lbl_tabulador.AutoSize = true;
            this.lbl_tabulador.Location = new System.Drawing.Point(430, 421);
            this.lbl_tabulador.Name = "lbl_tabulador";
            this.lbl_tabulador.Size = new System.Drawing.Size(13, 13);
            this.lbl_tabulador.TabIndex = 14;
            this.lbl_tabulador.Text = "0";
            // 
            // lbl_espacio
            // 
            this.lbl_espacio.AutoSize = true;
            this.lbl_espacio.Location = new System.Drawing.Point(430, 398);
            this.lbl_espacio.Name = "lbl_espacio";
            this.lbl_espacio.Size = new System.Drawing.Size(13, 13);
            this.lbl_espacio.TabIndex = 13;
            this.lbl_espacio.Text = "0";
            // 
            // lbl_caracter
            // 
            this.lbl_caracter.AutoSize = true;
            this.lbl_caracter.Location = new System.Drawing.Point(430, 375);
            this.lbl_caracter.Name = "lbl_caracter";
            this.lbl_caracter.Size = new System.Drawing.Size(13, 13);
            this.lbl_caracter.TabIndex = 12;
            this.lbl_caracter.Text = "0";
            // 
            // lbl_palabra
            // 
            this.lbl_palabra.AutoSize = true;
            this.lbl_palabra.Location = new System.Drawing.Point(430, 351);
            this.lbl_palabra.Name = "lbl_palabra";
            this.lbl_palabra.Size = new System.Drawing.Size(13, 13);
            this.lbl_palabra.TabIndex = 11;
            this.lbl_palabra.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 545);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Quitar: ";
            // 
            // cbo_quitar
            // 
            this.cbo_quitar.DisplayMember = "1";
            this.cbo_quitar.FormattingEnabled = true;
            this.cbo_quitar.Items.AddRange(new object[] {
            "Espacios",
            "Vocales",
            "Consonantes"});
            this.cbo_quitar.Location = new System.Drawing.Point(83, 542);
            this.cbo_quitar.Name = "cbo_quitar";
            this.cbo_quitar.Size = new System.Drawing.Size(148, 21);
            this.cbo_quitar.TabIndex = 19;
            this.cbo_quitar.Text = "Seleccione";
            // 
            // btn_procesar
            // 
            this.btn_procesar.Location = new System.Drawing.Point(248, 540);
            this.btn_procesar.Name = "btn_procesar";
            this.btn_procesar.Size = new System.Drawing.Size(75, 23);
            this.btn_procesar.TabIndex = 20;
            this.btn_procesar.Text = "Procesar";
            this.btn_procesar.UseVisualStyleBackColor = true;
            this.btn_procesar.Click += new System.EventHandler(this.btn_procesar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(329, 540);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 23);
            this.btn_guardar.TabIndex = 21;
            this.btn_guardar.Text = "Guardar como...";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 585);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_procesar);
            this.Controls.Add(this.cbo_quitar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_consonante);
            this.Controls.Add(this.lbl_vocal);
            this.Controls.Add(this.lbl_linea);
            this.Controls.Add(this.lbl_tabulador);
            this.Controls.Add(this.lbl_espacio);
            this.Controls.Add(this.lbl_caracter);
            this.Controls.Add(this.lbl_palabra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cuadro);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.RichTextBox txt_cuadro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_consonante;
        private System.Windows.Forms.Label lbl_vocal;
        private System.Windows.Forms.Label lbl_linea;
        private System.Windows.Forms.Label lbl_tabulador;
        private System.Windows.Forms.Label lbl_espacio;
        private System.Windows.Forms.Label lbl_caracter;
        private System.Windows.Forms.Label lbl_palabra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_quitar;
        private System.Windows.Forms.Button btn_procesar;
        private System.Windows.Forms.Button btn_guardar;
    }
}

