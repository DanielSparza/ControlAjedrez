namespace PresentacionAjedrez
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.optJugadores = new System.Windows.Forms.ToolStripButton();
            this.optArbitros = new System.Windows.Forms.ToolStripButton();
            this.optPaises = new System.Windows.Forms.ToolStripButton();
            this.optHoteles = new System.Windows.Forms.ToolStripButton();
            this.optRevervaciones = new System.Windows.Forms.ToolStripButton();
            this.optSalas = new System.Windows.Forms.ToolStripButton();
            this.optPartidas = new System.Windows.Forms.ToolStripButton();
            this.optMovimientos = new System.Windows.Forms.ToolStripButton();
            this.optCampeonatos = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campeonato Mundial de Ajedrez";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optJugadores,
            this.optArbitros,
            this.optPaises,
            this.optHoteles,
            this.optRevervaciones,
            this.optSalas,
            this.optPartidas,
            this.optMovimientos,
            this.optCampeonatos,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 40);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1124, 71);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // optJugadores
            // 
            this.optJugadores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optJugadores.Image = ((System.Drawing.Image)(resources.GetObject("optJugadores.Image")));
            this.optJugadores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optJugadores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optJugadores.Name = "optJugadores";
            this.optJugadores.Size = new System.Drawing.Size(68, 68);
            this.optJugadores.Text = "Jugadores";
            this.optJugadores.Click += new System.EventHandler(this.optJugadores_Click);
            // 
            // optArbitros
            // 
            this.optArbitros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optArbitros.Image = ((System.Drawing.Image)(resources.GetObject("optArbitros.Image")));
            this.optArbitros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optArbitros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optArbitros.Name = "optArbitros";
            this.optArbitros.Size = new System.Drawing.Size(68, 68);
            this.optArbitros.Text = "Arbitros";
            this.optArbitros.Click += new System.EventHandler(this.optArbitros_Click);
            // 
            // optPaises
            // 
            this.optPaises.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optPaises.Image = ((System.Drawing.Image)(resources.GetObject("optPaises.Image")));
            this.optPaises.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optPaises.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optPaises.Name = "optPaises";
            this.optPaises.Size = new System.Drawing.Size(68, 68);
            this.optPaises.Text = "Paises";
            this.optPaises.Click += new System.EventHandler(this.optPaises_Click);
            // 
            // optHoteles
            // 
            this.optHoteles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optHoteles.Image = ((System.Drawing.Image)(resources.GetObject("optHoteles.Image")));
            this.optHoteles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optHoteles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optHoteles.Name = "optHoteles";
            this.optHoteles.Size = new System.Drawing.Size(68, 68);
            this.optHoteles.Text = "Hoteles";
            this.optHoteles.Click += new System.EventHandler(this.optHoteles_Click);
            // 
            // optRevervaciones
            // 
            this.optRevervaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optRevervaciones.Image = ((System.Drawing.Image)(resources.GetObject("optRevervaciones.Image")));
            this.optRevervaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optRevervaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optRevervaciones.Name = "optRevervaciones";
            this.optRevervaciones.Size = new System.Drawing.Size(68, 68);
            this.optRevervaciones.Text = "Revervaciones";
            this.optRevervaciones.Click += new System.EventHandler(this.optRevervaciones_Click);
            // 
            // optSalas
            // 
            this.optSalas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optSalas.Image = ((System.Drawing.Image)(resources.GetObject("optSalas.Image")));
            this.optSalas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optSalas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalas.Name = "optSalas";
            this.optSalas.Size = new System.Drawing.Size(68, 68);
            this.optSalas.Text = "Salas";
            this.optSalas.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // optPartidas
            // 
            this.optPartidas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optPartidas.Image = ((System.Drawing.Image)(resources.GetObject("optPartidas.Image")));
            this.optPartidas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optPartidas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optPartidas.Name = "optPartidas";
            this.optPartidas.Size = new System.Drawing.Size(68, 68);
            this.optPartidas.Text = "Partidas";
            this.optPartidas.Click += new System.EventHandler(this.optPartidas_Click);
            // 
            // optMovimientos
            // 
            this.optMovimientos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optMovimientos.Image = ((System.Drawing.Image)(resources.GetObject("optMovimientos.Image")));
            this.optMovimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optMovimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optMovimientos.Name = "optMovimientos";
            this.optMovimientos.Size = new System.Drawing.Size(68, 68);
            this.optMovimientos.Text = "Movimientos";
            this.optMovimientos.Click += new System.EventHandler(this.optMovimientos_Click);
            // 
            // optCampeonatos
            // 
            this.optCampeonatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optCampeonatos.Image = ((System.Drawing.Image)(resources.GetObject("optCampeonatos.Image")));
            this.optCampeonatos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optCampeonatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optCampeonatos.Name = "optCampeonatos";
            this.optCampeonatos.Size = new System.Drawing.Size(68, 68);
            this.optCampeonatos.Text = "Campeonatos";
            this.optCampeonatos.Click += new System.EventHandler(this.optCampionatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 68);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 509);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton optJugadores;
        private System.Windows.Forms.ToolStripButton optArbitros;
        private System.Windows.Forms.ToolStripButton optPaises;
        private System.Windows.Forms.ToolStripButton optHoteles;
        private System.Windows.Forms.ToolStripButton optRevervaciones;
        private System.Windows.Forms.ToolStripButton optSalas;
        private System.Windows.Forms.ToolStripButton optPartidas;
        private System.Windows.Forms.ToolStripButton optMovimientos;
        private System.Windows.Forms.ToolStripButton optCampeonatos;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}