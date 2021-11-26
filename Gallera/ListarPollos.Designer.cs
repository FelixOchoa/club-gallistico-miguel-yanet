namespace Gallera
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
            this.BTRegGallo = new System.Windows.Forms.Button();
            this.PanelListarGallos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPollos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelListarGallos
            // 
            this.PanelListarGallos.Controls.Add(this.BTRegGallo);
            this.PanelListarGallos.Controls.Add(this.DGVPollos);
            this.PanelListarGallos.Controls.Add(this.LBListarPollos);
            this.PanelListarGallos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListarGallos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelListarGallos.Location = new System.Drawing.Point(0, 0);
            this.PanelListarGallos.Name = "PanelListarGallos";
            this.PanelListarGallos.Size = new System.Drawing.Size(616, 449);
            this.PanelListarGallos.TabIndex = 3;
            this.PanelListarGallos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelListarGallos_Paint);
            // 
            // DGVPollos
            // 
            this.DGVPollos.AllowUserToAddRows = false;
            this.DGVPollos.AllowUserToDeleteRows = false;
            this.DGVPollos.AllowUserToOrderColumns = true;
            this.DGVPollos.AllowUserToResizeColumns = false;
            this.DGVPollos.AllowUserToResizeRows = false;
            this.DGVPollos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPollos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVPollos.Location = new System.Drawing.Point(3, 70);
            this.DGVPollos.MultiSelect = false;
            this.DGVPollos.Name = "DGVPollos";
            this.DGVPollos.RowHeadersVisible = false;
            this.DGVPollos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVPollos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPollos.Size = new System.Drawing.Size(610, 330);
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
            // BTRegGallo
            // 
            this.BTRegGallo.Location = new System.Drawing.Point(248, 409);
            this.BTRegGallo.Name = "BTRegGallo";
            this.BTRegGallo.Size = new System.Drawing.Size(116, 28);
            this.BTRegGallo.TabIndex = 9;
            this.BTRegGallo.Text = "Emparejar ";
            this.BTRegGallo.UseVisualStyleBackColor = true;
            this.BTRegGallo.Click += new System.EventHandler(this.BTRegGallo_Click);
            // 
            // ListarPollos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 449);
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
        private System.Windows.Forms.Button BTRegGallo;
    }
}