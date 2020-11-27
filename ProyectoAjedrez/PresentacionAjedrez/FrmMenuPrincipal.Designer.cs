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
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.optPartidas = new System.Windows.Forms.ToolStripButton();
            this.optMovimientos = new System.Windows.Forms.ToolStripButton();
            this.optCampionatos = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStripButton6,
            this.optPartidas,
            this.optMovimientos,
            this.optCampionatos});
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
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton6.Text = "toolStripButton6";
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
            // 
            // optCampionatos
            // 
            this.optCampionatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optCampionatos.Image = ((System.Drawing.Image)(resources.GetObject("optCampionatos.Image")));
            this.optCampionatos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optCampionatos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optCampionatos.Name = "optCampionatos";
            this.optCampionatos.Size = new System.Drawing.Size(68, 68);
            this.optCampionatos.Text = "Campionatos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(972, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(763, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Hola";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(667, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(763, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 34);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Hola x2";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 509);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton optPartidas;
        private System.Windows.Forms.ToolStripButton optMovimientos;
        private System.Windows.Forms.ToolStripButton optCampionatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}