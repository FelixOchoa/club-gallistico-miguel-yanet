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
            this.DgvGallos = new System.Windows.Forms.DataGridView();
            this.LBListarGallo = new System.Windows.Forms.Label();
            this.PanelListarGallos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGallos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelListarGallos
            // 
            this.PanelListarGallos.Controls.Add(this.DgvGallos);
            this.PanelListarGallos.Controls.Add(this.LBListarGallo);
            this.PanelListarGallos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListarGallos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelListarGallos.Location = new System.Drawing.Point(0, 0);
            this.PanelListarGallos.Name = "PanelListarGallos";
            this.PanelListarGallos.Size = new System.Drawing.Size(762, 447);
            this.PanelListarGallos.TabIndex = 3;
            this.PanelListarGallos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelListarGallos_Paint);
            // 
            // DgvGallos
            // 
            this.DgvGallos.AllowUserToAddRows = false;
            this.DgvGallos.AllowUserToDeleteRows = false;
            this.DgvGallos.AllowUserToOrderColumns = true;
            this.DgvGallos.AllowUserToResizeColumns = false;
            this.DgvGallos.AllowUserToResizeRows = false;
            this.DgvGallos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGallos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvGallos.Location = new System.Drawing.Point(0, 71);
            this.DgvGallos.MultiSelect = false;
            this.DgvGallos.Name = "DgvGallos";
            this.DgvGallos.ReadOnly = true;
            this.DgvGallos.RowHeadersVisible = false;
            this.DgvGallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGallos.Size = new System.Drawing.Size(588, 330);
            this.DgvGallos.TabIndex = 1;
            this.DgvGallos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGallos_CellContentClick);
            // 
            // LBListarGallo
            // 
            this.LBListarGallo.AutoSize = true;
            this.LBListarGallo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBListarGallo.Location = new System.Drawing.Point(222, 43);
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
        private System.Windows.Forms.DataGridView DgvGallos;
        private System.Windows.Forms.Label LBListarGallo;
        private System.Windows.Forms.Panel PanelListarGallos;
    }
}