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
            this.label1 = new System.Windows.Forms.Label();
            this.inpt_nombrePdf = new System.Windows.Forms.TextBox();
            this.btn_generarPdf = new System.Windows.Forms.Button();
            this.btn_cancelarPelea = new System.Windows.Forms.Button();
            this.DgvGallos = new System.Windows.Forms.DataGridView();
            this.LBListarGallo = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tmePck_fecha = new System.Windows.Forms.DateTimePicker();
            this.PanelListarGallos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGallos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelListarGallos
            // 
            this.PanelListarGallos.Controls.Add(this.tmePck_fecha);
            this.PanelListarGallos.Controls.Add(this.label2);
            this.PanelListarGallos.Controls.Add(this.label1);
            this.PanelListarGallos.Controls.Add(this.inpt_nombrePdf);
            this.PanelListarGallos.Controls.Add(this.btn_generarPdf);
            this.PanelListarGallos.Controls.Add(this.btn_cancelarPelea);
            this.PanelListarGallos.Controls.Add(this.DgvGallos);
            this.PanelListarGallos.Controls.Add(this.LBListarGallo);
            this.PanelListarGallos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListarGallos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelListarGallos.Location = new System.Drawing.Point(0, 0);
            this.PanelListarGallos.Name = "PanelListarGallos";
            this.PanelListarGallos.Size = new System.Drawing.Size(762, 447);
            this.PanelListarGallos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(285, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del pdf:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inpt_nombrePdf
            // 
            this.inpt_nombrePdf.Location = new System.Drawing.Point(285, 422);
            this.inpt_nombrePdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inpt_nombrePdf.Name = "inpt_nombrePdf";
            this.inpt_nombrePdf.Size = new System.Drawing.Size(110, 22);
            this.inpt_nombrePdf.TabIndex = 10;
            // 
            // btn_generarPdf
            // 
            this.btn_generarPdf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_generarPdf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_generarPdf.Location = new System.Drawing.Point(153, 406);
            this.btn_generarPdf.Name = "btn_generarPdf";
            this.btn_generarPdf.Size = new System.Drawing.Size(127, 39);
            this.btn_generarPdf.TabIndex = 9;
            this.btn_generarPdf.Text = "Generar PDF";
            this.btn_generarPdf.UseVisualStyleBackColor = true;
            this.btn_generarPdf.Click += new System.EventHandler(this.btn_generarPdf_Click);
            // 
            // btn_cancelarPelea
            // 
            this.btn_cancelarPelea.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btn_cancelarPelea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancelarPelea.Location = new System.Drawing.Point(20, 406);
            this.btn_cancelarPelea.Name = "btn_cancelarPelea";
            this.btn_cancelarPelea.Size = new System.Drawing.Size(127, 39);
            this.btn_cancelarPelea.TabIndex = 9;
            this.btn_cancelarPelea.Text = "Cancelar pelea";
            this.btn_cancelarPelea.UseVisualStyleBackColor = true;
            this.btn_cancelarPelea.Click += new System.EventHandler(this.btn_cancelarPelea_Click);
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
            this.DgvGallos.RowHeadersWidth = 51;
            this.DgvGallos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGallos.Size = new System.Drawing.Size(588, 330);
            this.DgvGallos.TabIndex = 1;
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(437, 404);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha de evento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmePck_fecha
            // 
            this.tmePck_fecha.Location = new System.Drawing.Point(411, 422);
            this.tmePck_fecha.Name = "tmePck_fecha";
            this.tmePck_fecha.Size = new System.Drawing.Size(156, 22);
            this.tmePck_fecha.TabIndex = 13;
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
        private System.Windows.Forms.Button btn_cancelarPelea;
        private System.Windows.Forms.Button btn_generarPdf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpt_nombrePdf;
        private System.Windows.Forms.DateTimePicker tmePck_fecha;
        private System.Windows.Forms.Label label2;
    }
}