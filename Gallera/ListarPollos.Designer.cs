﻿namespace Gallera
{
    partial class ListarPollos
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
            this.PanelListarGallos = new System.Windows.Forms.Panel();
            this.DGVPollos = new System.Windows.Forms.DataGridView();
            this.LBListarPollos = new System.Windows.Forms.Label();
            this.PanelListarGallos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPollos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelListarGallos
            // 
            this.PanelListarGallos.Controls.Add(this.DGVPollos);
            this.PanelListarGallos.Controls.Add(this.LBListarPollos);
            this.PanelListarGallos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelListarGallos.Location = new System.Drawing.Point(8, 8);
            this.PanelListarGallos.Name = "PanelListarGallos";
            this.PanelListarGallos.Size = new System.Drawing.Size(621, 449);
            this.PanelListarGallos.TabIndex = 3;
            // 
            // DGVPollos
            // 
            this.DGVPollos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPollos.Location = new System.Drawing.Point(29, 71);
            this.DGVPollos.Name = "DGVPollos";
            this.DGVPollos.Size = new System.Drawing.Size(550, 330);
            this.DGVPollos.TabIndex = 1;
            // 
            // LBListarPollos
            // 
            this.LBListarPollos.AutoSize = true;
            this.LBListarPollos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBListarPollos.Location = new System.Drawing.Point(35, 25);
            this.LBListarPollos.Name = "LBListarPollos";
            this.LBListarPollos.Size = new System.Drawing.Size(154, 25);
            this.LBListarPollos.TabIndex = 0;
            this.LBListarPollos.Text = "Listado de Pollos";
            // 
            // ListarPollos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.PanelListarGallos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarPollos";
            this.Text = "ListarPollos";
            this.PanelListarGallos.ResumeLayout(false);
            this.PanelListarGallos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPollos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelListarGallos;
        private System.Windows.Forms.DataGridView DGVPollos;
        private System.Windows.Forms.Label LBListarPollos;
    }
}