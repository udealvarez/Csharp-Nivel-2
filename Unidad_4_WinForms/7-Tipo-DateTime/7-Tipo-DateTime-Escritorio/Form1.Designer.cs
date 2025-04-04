
namespace _7_Tipo_DateTime_Escritorio
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnPrueba1 = new System.Windows.Forms.Button();
            this.btnPrueba2 = new System.Windows.Forms.Button();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.btnPrueba1B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(200, 105);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(248, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnPrueba1
            // 
            this.btnPrueba1.Location = new System.Drawing.Point(519, 106);
            this.btnPrueba1.Name = "btnPrueba1";
            this.btnPrueba1.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1.TabIndex = 1;
            this.btnPrueba1.Text = "Prueba 1";
            this.btnPrueba1.UseVisualStyleBackColor = true;
            this.btnPrueba1.Click += new System.EventHandler(this.btnPrueba1_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Location = new System.Drawing.Point(519, 167);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba2.TabIndex = 2;
            this.btnPrueba2.Text = "Prueba 2";
            this.btnPrueba2.UseVisualStyleBackColor = true;
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(200, 167);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 3;
            // 
            // btnPrueba1B
            // 
            this.btnPrueba1B.Location = new System.Drawing.Point(639, 106);
            this.btnPrueba1B.Name = "btnPrueba1B";
            this.btnPrueba1B.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba1B.TabIndex = 4;
            this.btnPrueba1B.Text = "Prueba 1.B";
            this.btnPrueba1B.UseVisualStyleBackColor = true;
            this.btnPrueba1B.Click += new System.EventHandler(this.btnPrueba1B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrueba1B);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.btnPrueba2);
            this.Controls.Add(this.btnPrueba1);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnPrueba1;
        private System.Windows.Forms.Button btnPrueba2;
        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.Button btnPrueba1B;
    }
}

