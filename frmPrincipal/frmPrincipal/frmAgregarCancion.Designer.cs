namespace frmPrincipal
{
    partial class frmAgregarCancion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpArtista = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstArtista = new System.Windows.Forms.ListBox();
            this.lstAlbum = new System.Windows.Forms.ListBox();
            this.grpArtista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(98, 19);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(162, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Agregar Canciones";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(25, 94);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(63, 20);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(25, 125);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(101, 20);
            this.lblAnio.TabIndex = 5;
            this.lblAnio.Text = "AñoCreación";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(207, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(91, 94);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(207, 20);
            this.txtGenero.TabIndex = 9;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(132, 127);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(166, 20);
            this.txtAnio.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(187, 183);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 36);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpArtista
            // 
            this.grpArtista.Controls.Add(this.lstArtista);
            this.grpArtista.Location = new System.Drawing.Point(304, 37);
            this.grpArtista.Name = "grpArtista";
            this.grpArtista.Size = new System.Drawing.Size(184, 196);
            this.grpArtista.TabIndex = 15;
            this.grpArtista.TabStop = false;
            this.grpArtista.Text = "Seleccione un Artista:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAlbum);
            this.groupBox1.Location = new System.Drawing.Point(494, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 195);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione un Album";
            // 
            // lstArtista
            // 
            this.lstArtista.FormattingEnabled = true;
            this.lstArtista.Location = new System.Drawing.Point(19, 22);
            this.lstArtista.Name = "lstArtista";
            this.lstArtista.Size = new System.Drawing.Size(151, 160);
            this.lstArtista.TabIndex = 18;
            // 
            // lstAlbum
            // 
            this.lstAlbum.FormattingEnabled = true;
            this.lstAlbum.Location = new System.Drawing.Point(6, 23);
            this.lstAlbum.Name = "lstAlbum";
            this.lstAlbum.Size = new System.Drawing.Size(165, 160);
            this.lstAlbum.TabIndex = 0;
            // 
            // frmAgregarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 238);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpArtista);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbltitulo);
            this.Name = "frmAgregarCancion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BulletProffsRecords";
            this.Load += new System.EventHandler(this.frmAgregarCancion_Load);
            this.grpArtista.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpArtista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstArtista;
        private System.Windows.Forms.ListBox lstAlbum;
    }
}