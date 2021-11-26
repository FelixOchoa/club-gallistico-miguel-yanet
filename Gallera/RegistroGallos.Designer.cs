namespace Gallera
{
    partial class RegistroGallos
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
            this.PanelGallo = new System.Windows.Forms.Panel();
            this.BTRegGallo = new System.Windows.Forms.Button();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.LBColor = new System.Windows.Forms.Label();
            this.TBPeso = new System.Windows.Forms.TextBox();
            this.LBPeso = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.LBID = new System.Windows.Forms.Label();
            this.LBRegistroGallo = new System.Windows.Forms.Label();
            this.TBNombreDueno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelGallo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGallo
            // 
            this.PanelGallo.Controls.Add(this.TBNombreDueno);
            this.PanelGallo.Controls.Add(this.label1);
            this.PanelGallo.Controls.Add(this.BTRegGallo);
            this.PanelGallo.Controls.Add(this.TBColor);
            this.PanelGallo.Controls.Add(this.LBColor);
            this.PanelGallo.Controls.Add(this.TBPeso);
            this.PanelGallo.Controls.Add(this.LBPeso);
            this.PanelGallo.Controls.Add(this.TBID);
            this.PanelGallo.Controls.Add(this.LBID);
            this.PanelGallo.Controls.Add(this.LBRegistroGallo);
            this.PanelGallo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelGallo.Location = new System.Drawing.Point(0, 1);
            this.PanelGallo.Name = "PanelGallo";
            this.PanelGallo.Size = new System.Drawing.Size(621, 449);
            this.PanelGallo.TabIndex = 0;
            this.PanelGallo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGallo_Paint);
            // 
            // BTRegGallo
            // 
            this.BTRegGallo.Location = new System.Drawing.Point(258, 287);
            this.BTRegGallo.Name = "BTRegGallo";
            this.BTRegGallo.Size = new System.Drawing.Size(128, 57);
            this.BTRegGallo.TabIndex = 7;
            this.BTRegGallo.Text = "Registrar Gallo";
            this.BTRegGallo.UseVisualStyleBackColor = true;
            this.BTRegGallo.Click += new System.EventHandler(this.BTRegGallo_Click);
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(156, 185);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(350, 29);
            this.TBColor.TabIndex = 6;
            // 
            // LBColor
            // 
            this.LBColor.AutoSize = true;
            this.LBColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBColor.Location = new System.Drawing.Point(110, 191);
            this.LBColor.Name = "LBColor";
            this.LBColor.Size = new System.Drawing.Size(40, 17);
            this.LBColor.TabIndex = 5;
            this.LBColor.Text = "Color";
            // 
            // TBPeso
            // 
            this.TBPeso.Location = new System.Drawing.Point(156, 141);
            this.TBPeso.Name = "TBPeso";
            this.TBPeso.Size = new System.Drawing.Size(350, 29);
            this.TBPeso.TabIndex = 4;
            this.TBPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPeso_KeyPress);
            // 
            // LBPeso
            // 
            this.LBPeso.AutoSize = true;
            this.LBPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPeso.Location = new System.Drawing.Point(114, 147);
            this.LBPeso.Name = "LBPeso";
            this.LBPeso.Size = new System.Drawing.Size(36, 17);
            this.LBPeso.TabIndex = 3;
            this.LBPeso.Text = "Peso";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(156, 97);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(350, 29);
            this.TBID.TabIndex = 2;
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBID.Location = new System.Drawing.Point(11, 103);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(139, 17);
            this.LBID.TabIndex = 1;
            this.LBID.Text = "Identificación del gallo";
            // 
            // LBRegistroGallo
            // 
            this.LBRegistroGallo.AutoSize = true;
            this.LBRegistroGallo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRegistroGallo.Location = new System.Drawing.Point(49, 57);
            this.LBRegistroGallo.Name = "LBRegistroGallo";
            this.LBRegistroGallo.Size = new System.Drawing.Size(157, 25);
            this.LBRegistroGallo.TabIndex = 0;
            this.LBRegistroGallo.Text = "Registro de Gallo";
            // 
            // TBNombreDueno
            // 
            this.TBNombreDueno.Location = new System.Drawing.Point(156, 227);
            this.TBNombreDueno.Name = "TBNombreDueno";
            this.TBNombreDueno.Size = new System.Drawing.Size(350, 29);
            this.TBNombreDueno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del dueño";
            // 
            // RegistroGallos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.PanelGallo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroGallos";
            this.Text = "Gallos";
            this.PanelGallo.ResumeLayout(false);
            this.PanelGallo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelGallo;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.Label LBColor;
        private System.Windows.Forms.TextBox TBPeso;
        private System.Windows.Forms.Label LBPeso;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.Label LBRegistroGallo;
        private System.Windows.Forms.Button BTRegGallo;
        private System.Windows.Forms.TextBox TBNombreDueno;
        private System.Windows.Forms.Label label1;
    }
}