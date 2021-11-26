namespace Gallera
{
    partial class InterfazSorteoPollo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvGallos = new System.Windows.Forms.DataGridView();
            this.LBListarGallo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGallos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBListarGallo);
            this.panel1.Controls.Add(this.DgvGallos);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 407);
            this.panel1.TabIndex = 0;
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
            this.DgvGallos.Location = new System.Drawing.Point(7, 38);
            this.DgvGallos.MultiSelect = false;
            this.DgvGallos.Name = "DgvGallos";
            this.DgvGallos.ReadOnly = true;
            this.DgvGallos.RowHeadersVisible = false;
            this.DgvGallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGallos.Size = new System.Drawing.Size(588, 330);
            this.DgvGallos.TabIndex = 2;
            // 
            // LBListarGallo
            // 
            this.LBListarGallo.AutoSize = true;
            this.LBListarGallo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBListarGallo.Location = new System.Drawing.Point(228, 7);
            this.LBListarGallo.Name = "LBListarGallo";
            this.LBListarGallo.Size = new System.Drawing.Size(154, 25);
            this.LBListarGallo.TabIndex = 3;
            this.LBListarGallo.Text = "Listado de Pollos";
            // 
            // InterfazSorteoPollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazSorteoPollo";
            this.Text = "InterfazSorteoPollo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGallos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvGallos;
        private System.Windows.Forms.Label LBListarGallo;
    }
}