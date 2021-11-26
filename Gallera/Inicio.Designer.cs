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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.childContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BTRegGallo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTRegPollo = new System.Windows.Forms.Button();
            this.BTListarGallo = new System.Windows.Forms.Button();
            this.BTListarPollo = new System.Windows.Forms.Button();
            this.BTSorteo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.childContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // childContainer
            // 
            this.childContainer.Controls.Add(this.label2);
            resources.ApplyResources(this.childContainer, "childContainer");
            this.childContainer.Name = "childContainer";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BTRegGallo
            // 
            resources.ApplyResources(this.BTRegGallo, "BTRegGallo");
            this.BTRegGallo.Name = "BTRegGallo";
            this.BTRegGallo.UseVisualStyleBackColor = true;
            this.BTRegGallo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BTRegPollo
            // 
            resources.ApplyResources(this.BTRegPollo, "BTRegPollo");
            this.BTRegPollo.Name = "BTRegPollo";
            this.BTRegPollo.UseVisualStyleBackColor = true;
            this.BTRegPollo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTListarGallo
            // 
            resources.ApplyResources(this.BTListarGallo, "BTListarGallo");
            this.BTListarGallo.Name = "BTListarGallo";
            this.BTListarGallo.UseVisualStyleBackColor = true;
            this.BTListarGallo.Click += new System.EventHandler(this.BTListarGallo_Click);
            // 
            // BTListarPollo
            // 
            resources.ApplyResources(this.BTListarPollo, "BTListarPollo");
            this.BTListarPollo.Name = "BTListarPollo";
            this.BTListarPollo.UseVisualStyleBackColor = true;
            this.BTListarPollo.Click += new System.EventHandler(this.BTListarPollo_Click);
            // 
            // BTSorteo
            // 
            resources.ApplyResources(this.BTSorteo, "BTSorteo");
            this.BTSorteo.Name = "BTSorteo";
            this.BTSorteo.UseVisualStyleBackColor = true;
            this.BTSorteo.Click += new System.EventHandler(this.BTSorteo_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTSorteo);
            this.Controls.Add(this.BTListarPollo);
            this.Controls.Add(this.BTListarGallo);
            this.Controls.Add(this.BTRegPollo);
            this.Controls.Add(this.BTRegGallo);
            this.Controls.Add(this.childContainer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.childContainer.ResumeLayout(false);
            this.childContainer.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

