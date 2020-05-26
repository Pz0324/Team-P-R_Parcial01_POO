using System.ComponentModel;

namespace WindowsFormsApp4
{
    partial class PrincipalPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(PrincipalPanel));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Usuarios = new System.Windows.Forms.Button();
            this.Pedidos = new System.Windows.Forms.Button();
            this.Historial = new System.Windows.Forms.Button();
            this.panelOpc = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelOpc, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.888889F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Usuarios, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Pedidos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Historial, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(172, 576);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.Location = new System.Drawing.Point(3, 3);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(166, 84);
            this.Usuarios.TabIndex = 0;
            this.Usuarios.Text = "button1";
            this.Usuarios.UseVisualStyleBackColor = false;
            // 
            // Pedidos
            // 
            this.Pedidos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pedidos.Location = new System.Drawing.Point(3, 93);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(166, 84);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "button2";
            this.Pedidos.UseVisualStyleBackColor = false;
            // 
            // Historial
            // 
            this.Historial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Historial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Historial.Location = new System.Drawing.Point(3, 183);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(166, 84);
            this.Historial.TabIndex = 2;
            this.Historial.Text = "button3";
            this.Historial.UseVisualStyleBackColor = false;
            // 
            // panelOpc
            // 
            this.panelOpc.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (56)))),
                ((int) (((byte) (65)))));
            this.panelOpc.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("panelOpc.BackgroundImage")));
            this.panelOpc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelOpc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpc.Location = new System.Drawing.Point(181, 59);
            this.panelOpc.Name = "panelOpc";
            this.panelOpc.Size = new System.Drawing.Size(709, 576);
            this.panelOpc.TabIndex = 1;
            // 
            // PrincipalPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrincipalPanel";
            this.Size = new System.Drawing.Size(893, 638);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelOpc;
        private System.Windows.Forms.Button Historial;
        private System.Windows.Forms.Button Pedidos;
        private System.Windows.Forms.Button Usuarios;
    }
}