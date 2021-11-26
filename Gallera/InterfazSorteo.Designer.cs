namespace Gallera
{
    partial class InterfazSorteo
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
            this.Btn_Emparejar = new System.Windows.Forms.Button();
            this.DgvGallos = new System.Windows.Forms.DataGridView();
            this.LBListarGallo = new System.Windows.Forms.Label();
            this.PanelListarGallos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGallos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelListarGallos
            // 
            this.PanelListarGallos.Controls.Add(this.Btn_Emparejar);
            this.PanelListarGallos.Controls.Add(this.DgvGallos);
            this.PanelListarGallos.Controls.Add(this.LBListarGallo);
            this.PanelListarGallos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListarGallos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelListarGallos.Location = new System.Drawing.Point(0, 0);
            this.PanelListarGallos.Name = "PanelListarGallos";
            this.PanelListarGallos.Size = new System.Drawing.Size(762, 447);
            this.PanelListarGallos.TabIndex = 3;
            // 
            // Btn_Emparejar
            // 
            this.Btn_Emparejar.Location = new System.Drawing.Point(626, 71);
            this.Btn_Emparejar.Name = "Btn_Emparejar";
            this.Btn_Emparejar.Size = new System.Drawing.Size(92, 64);
            this.Btn_Emparejar.TabIndex = 2;
            this.Btn_Emparejar.Text = "Emparejar";
            this.Btn_Emparejar.UseVisualStyleBackColor = true;
            // 
            // DgvGallos
            // 
            this.DgvGallos.AllowUserToAddRows = false;
            this.DgvGallos.AllowUserToDeleteRows = false;
            this.DgvGallos.AllowUserToOrderColumns = true;
            this.DgvGallos.AllowUserToResizeColumns = false;
            this.DgvGallos.AllowUserToResizeRows = false;
            this.DgvGallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGallos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvGallos.Location = new System.Drawing.Point(29, 71);
            this.DgvGallos.MultiSelect = false;
            this.DgvGallos.Name = "DgvGallos";
            this.DgvGallos.RowHeadersVisible = false;
            this.DgvGallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGallos.Size = new System.Drawing.Size(576, 330);
            this.DgvGallos.TabIndex = 1;
            // 
            // LBListarGallo
            // 
            this.LBListarGallo.AutoSize = true;
            this.LBListarGallo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBListarGallo.Location = new System.Drawing.Point(35, 25);
            this.LBListarGallo.Name = "LBListarGallo";
            this.LBListarGallo.Size = new System.Drawing.Size(156, 25);
            this.LBListarGallo.TabIndex = 0;
            this.LBListarGallo.Text = "Listado de Gallos";
            // 
            // InterfazSorteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 447);
            this.Controls.Add(this.PanelListarGallos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazSorteo";
            this.Text = "InterfazSorteo";
            this.PanelListarGallos.ResumeLayout(false);
            this.PanelListarGallos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGallos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelListarGallos;
        private System.Windows.Forms.Button Btn_Emparejar;
        private System.Windows.Forms.DataGridView DgvGallos;
        private System.Windows.Forms.Label LBListarGallo;
    }
}