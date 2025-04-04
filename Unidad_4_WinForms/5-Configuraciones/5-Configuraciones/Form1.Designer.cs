
namespace _5_Configuraciones
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbWizard = new System.Windows.Forms.RadioButton();
            this.rbMuggle = new System.Windows.Forms.RadioButton();
            this.rbSquibs = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColorFav = new System.Windows.Forms.ComboBox();
            this.nudNumeroFav = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(197, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(95, 633);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvElementos
            // 
            this.lvElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElementos.HideSelection = false;
            this.lvElementos.Location = new System.Drawing.Point(134, 404);
            this.lvElementos.Name = "lvElementos";
            this.lvElementos.Size = new System.Drawing.Size(302, 214);
            this.lvElementos.TabIndex = 7;
            this.lvElementos.UseCompatibleStateImageBehavior = false;
            this.lvElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(141, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(92, 107);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(99, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha Nacimiento: ";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(197, 101);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(197, 147);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(135, 17);
            this.cbChocolate.TabIndex = 2;
            this.cbChocolate.Text = "Te gusta el chocolate?";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(65, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 32);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rbWizard
            // 
            this.rbWizard.AutoSize = true;
            this.rbWizard.Checked = true;
            this.rbWizard.Location = new System.Drawing.Point(39, 38);
            this.rbWizard.Name = "rbWizard";
            this.rbWizard.Size = new System.Drawing.Size(58, 17);
            this.rbWizard.TabIndex = 8;
            this.rbWizard.TabStop = true;
            this.rbWizard.Text = "Wizard";
            this.rbWizard.UseVisualStyleBackColor = true;
            // 
            // rbMuggle
            // 
            this.rbMuggle.AutoSize = true;
            this.rbMuggle.Location = new System.Drawing.Point(171, 38);
            this.rbMuggle.Name = "rbMuggle";
            this.rbMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbMuggle.TabIndex = 9;
            this.rbMuggle.Text = "Muggle";
            this.rbMuggle.UseVisualStyleBackColor = true;
            // 
            // rbSquibs
            // 
            this.rbSquibs.AutoSize = true;
            this.rbSquibs.Location = new System.Drawing.Point(298, 38);
            this.rbSquibs.Name = "rbSquibs";
            this.rbSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbSquibs.TabIndex = 10;
            this.rbSquibs.Text = "Squibs";
            this.rbSquibs.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbTipo.Controls.Add(this.rbWizard);
            this.gbTipo.Controls.Add(this.rbSquibs);
            this.gbTipo.Controls.Add(this.rbMuggle);
            this.gbTipo.Location = new System.Drawing.Point(95, 193);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(415, 80);
            this.gbTipo.TabIndex = 3;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "TIPO";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(122, 301);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(69, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color favorito";
            // 
            // cboColorFav
            // 
            this.cboColorFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFav.FormattingEnabled = true;
            this.cboColorFav.Location = new System.Drawing.Point(197, 298);
            this.cboColorFav.Name = "cboColorFav";
            this.cboColorFav.Size = new System.Drawing.Size(200, 21);
            this.cboColorFav.TabIndex = 4;
            // 
            // nudNumeroFav
            // 
            this.nudNumeroFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNumeroFav.Location = new System.Drawing.Point(197, 338);
            this.nudNumeroFav.Name = "nudNumeroFav";
            this.nudNumeroFav.Size = new System.Drawing.Size(200, 20);
            this.nudNumeroFav.TabIndex = 5;
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(110, 345);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(82, 13);
            this.lblNumeroFavorito.TabIndex = 15;
            this.lblNumeroFavorito.Text = "Numero favorito";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVerPerfil.FlatAppearance.BorderSize = 3;
            this.btnVerPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPerfil.Location = new System.Drawing.Point(21, 377);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(87, 41);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 659);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.nudNumeroFav);
            this.Controls.Add(this.cboColorFav);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lvElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(938, 745);
            this.MinimumSize = new System.Drawing.Size(622, 698);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbWizard;
        private System.Windows.Forms.RadioButton rbMuggle;
        private System.Windows.Forms.RadioButton rbSquibs;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColorFav;
        private System.Windows.Forms.NumericUpDown nudNumeroFav;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

