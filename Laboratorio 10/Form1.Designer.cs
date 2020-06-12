namespace Laboratorio_10
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bienvenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentasYSusTotalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentasYTotalesSiIniciaConVocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienvenido1 = new Laboratorio_10.Bienvenido();
            this.bienvenido2 = new Laboratorio_10.Bienvenido();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bienvenido2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 471F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 494);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.bienvenidoToolStripMenuItem, this.agregarCuentaToolStripMenuItem, this.verCuentasToolStripMenuItem,
                this.verCuentasYSusTotalesToolStripMenuItem, this.verCuentasYTotalesSiIniciaConVocalToolStripMenuItem,
                this.salirToolStripMenuItem
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 23);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bienvenidoToolStripMenuItem
            // 
            this.bienvenidoToolStripMenuItem.Name = "bienvenidoToolStripMenuItem";
            this.bienvenidoToolStripMenuItem.Size = new System.Drawing.Size(78, 19);
            this.bienvenidoToolStripMenuItem.Text = "Bienvenido";
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(102, 19);
            this.agregarCuentaToolStripMenuItem.Text = "Agregar Cuenta";
            // 
            // verCuentasToolStripMenuItem
            // 
            this.verCuentasToolStripMenuItem.Name = "verCuentasToolStripMenuItem";
            this.verCuentasToolStripMenuItem.Size = new System.Drawing.Size(81, 19);
            this.verCuentasToolStripMenuItem.Text = "Ver Cuentas";
            // 
            // verCuentasYSusTotalesToolStripMenuItem
            // 
            this.verCuentasYSusTotalesToolStripMenuItem.Name = "verCuentasYSusTotalesToolStripMenuItem";
            this.verCuentasYSusTotalesToolStripMenuItem.Size = new System.Drawing.Size(148, 19);
            this.verCuentasYSusTotalesToolStripMenuItem.Text = "Ver Cuentas y sus totales";
            // 
            // verCuentasYTotalesSiIniciaConVocalToolStripMenuItem
            // 
            this.verCuentasYTotalesSiIniciaConVocalToolStripMenuItem.Name =
                "verCuentasYTotalesSiIniciaConVocalToolStripMenuItem";
            this.verCuentasYTotalesSiIniciaConVocalToolStripMenuItem.Size = new System.Drawing.Size(224, 19);
            this.verCuentasYTotalesSiIniciaConVocalToolStripMenuItem.Text = "Ver Cuentas y totales si inicia con vocal";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 19);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // bienvenido1
            // 
            this.bienvenido1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("bienvenido1.BackgroundImage")));
            this.bienvenido1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bienvenido1.Location = new System.Drawing.Point(0, 0);
            this.bienvenido1.Name = "bienvenido1";
            this.bienvenido1.Size = new System.Drawing.Size(562, 458);
            this.bienvenido1.TabIndex = 0;
            // 
            // bienvenido2
            // 
            this.bienvenido2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bienvenido2.BackColor = System.Drawing.Color.AliceBlue;
            this.bienvenido2.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("bienvenido2.BackgroundImage")));
            this.bienvenido2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bienvenido2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bienvenido2.Location = new System.Drawing.Point(3, 26);
            this.bienvenido2.Name = "bienvenido2";
            this.bienvenido2.Size = new System.Drawing.Size(760, 465);
            this.bienvenido2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCuentasYTotalesSiIniciaConVocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCuentasYSusTotalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bienvenidoToolStripMenuItem;
        private Laboratorio_10.Bienvenido bienvenido1;
        private Laboratorio_10.Bienvenido bienvenido2;
    }
}