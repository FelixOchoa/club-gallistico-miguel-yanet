namespace Gallera
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.childContainer = new System.Windows.Forms.Panel();
            this.BTRegGallo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTRegPollo = new System.Windows.Forms.Button();
            this.BTListarGallo = new System.Windows.Forms.Button();
            this.BTListarPollo = new System.Windows.Forms.Button();
            this.BTSorteo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // childContainer
            // 
            this.childContainer.Location = new System.Drawing.Point(178, 1);
            this.childContainer.Name = "childContainer";
            this.childContainer.Size = new System.Drawing.Size(621, 449);
            this.childContainer.TabIndex = 3;
            // 
            // BTRegGallo
            // 
            this.BTRegGallo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegGallo.Location = new System.Drawing.Point(25, 141);
            this.BTRegGallo.Name = "BTRegGallo";
            this.BTRegGallo.Size = new System.Drawing.Size(127, 23);
            this.BTRegGallo.TabIndex = 1;
            this.BTRegGallo.Text = "Registro de Gallo";
            this.BTRegGallo.UseVisualStyleBackColor = true;
            this.BTRegGallo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gallera";
            // 
            // BTRegPollo
            // 
            this.BTRegPollo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegPollo.Location = new System.Drawing.Point(25, 172);
            this.BTRegPollo.Name = "BTRegPollo";
            this.BTRegPollo.Size = new System.Drawing.Size(127, 23);
            this.BTRegPollo.TabIndex = 4;
            this.BTRegPollo.Text = "Registro de Pollo";
            this.BTRegPollo.UseVisualStyleBackColor = true;
            this.BTRegPollo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTListarGallo
            // 
            this.BTListarGallo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTListarGallo.Location = new System.Drawing.Point(25, 203);
            this.BTListarGallo.Name = "BTListarGallo";
            this.BTListarGallo.Size = new System.Drawing.Size(127, 23);
            this.BTListarGallo.TabIndex = 5;
            this.BTListarGallo.Text = "Listar Gallos";
            this.BTListarGallo.UseVisualStyleBackColor = true;
            this.BTListarGallo.Click += new System.EventHandler(this.BTListarGallo_Click);
            // 
            // BTListarPollo
            // 
            this.BTListarPollo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTListarPollo.Location = new System.Drawing.Point(25, 234);
            this.BTListarPollo.Name = "BTListarPollo";
            this.BTListarPollo.Size = new System.Drawing.Size(127, 23);
            this.BTListarPollo.TabIndex = 6;
            this.BTListarPollo.Text = "Listar Pollos";
            this.BTListarPollo.UseVisualStyleBackColor = true;
            this.BTListarPollo.Click += new System.EventHandler(this.BTListarPollo_Click);
            // 
            // BTSorteo
            // 
            this.BTSorteo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSorteo.Location = new System.Drawing.Point(25, 265);
            this.BTSorteo.Name = "BTSorteo";
            this.BTSorteo.Size = new System.Drawing.Size(127, 23);
            this.BTSorteo.TabIndex = 7;
            this.BTSorteo.Text = "Sorteo";
            this.BTSorteo.UseVisualStyleBackColor = true;
            this.BTSorteo.Click += new System.EventHandler(this.BTSorteo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.BTSorteo);
            this.Controls.Add(this.BTListarPollo);
            this.Controls.Add(this.BTListarGallo);
            this.Controls.Add(this.BTRegPollo);
            this.Controls.Add(this.BTRegGallo);
            this.Controls.Add(this.childContainer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel childContainer;
        private System.Windows.Forms.Button BTRegGallo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTRegPollo;
        private System.Windows.Forms.Button BTListarGallo;
        private System.Windows.Forms.Button BTListarPollo;
        private System.Windows.Forms.Button BTSorteo;
    }
}

