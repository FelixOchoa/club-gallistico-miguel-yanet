namespace Gallera
{
    partial class RegistroPollos
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
            this.PanelPollo = new System.Windows.Forms.Panel();
            this.BTRegPollo = new System.Windows.Forms.Button();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.LBColor = new System.Windows.Forms.Label();
            this.TBPeso = new System.Windows.Forms.TextBox();
            this.LBPeso = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.LBID = new System.Windows.Forms.Label();
            this.LBRegistroPollo = new System.Windows.Forms.Label();
            this.PanelPollo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPollo
            // 
            this.PanelPollo.Controls.Add(this.BTRegPollo);
            this.PanelPollo.Controls.Add(this.TBColor);
            this.PanelPollo.Controls.Add(this.LBColor);
            this.PanelPollo.Controls.Add(this.TBPeso);
            this.PanelPollo.Controls.Add(this.LBPeso);
            this.PanelPollo.Controls.Add(this.TBID);
            this.PanelPollo.Controls.Add(this.LBID);
            this.PanelPollo.Controls.Add(this.LBRegistroPollo);
            this.PanelPollo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPollo.Location = new System.Drawing.Point(2, 1);
            this.PanelPollo.Name = "PanelPollo";
            this.PanelPollo.Size = new System.Drawing.Size(621, 449);
            this.PanelPollo.TabIndex = 1;
            // 
            // BTRegPollo
            // 
            this.BTRegPollo.Location = new System.Drawing.Point(258, 287);
            this.BTRegPollo.Name = "BTRegPollo";
            this.BTRegPollo.Size = new System.Drawing.Size(128, 57);
            this.BTRegPollo.TabIndex = 7;
            this.BTRegPollo.Text = "Registrar Pollo";
            this.BTRegPollo.UseVisualStyleBackColor = true;
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(156, 224);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(350, 29);
            this.TBColor.TabIndex = 6;
            // 
            // LBColor
            // 
            this.LBColor.AutoSize = true;
            this.LBColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBColor.Location = new System.Drawing.Point(110, 230);
            this.LBColor.Name = "LBColor";
            this.LBColor.Size = new System.Drawing.Size(40, 17);
            this.LBColor.TabIndex = 5;
            this.LBColor.Text = "Color";
            // 
            // TBPeso
            // 
            this.TBPeso.Location = new System.Drawing.Point(156, 180);
            this.TBPeso.Name = "TBPeso";
            this.TBPeso.Size = new System.Drawing.Size(350, 29);
            this.TBPeso.TabIndex = 4;
            this.TBPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPeso_KeyPress);
            // 
            // LBPeso
            // 
            this.LBPeso.AutoSize = true;
            this.LBPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPeso.Location = new System.Drawing.Point(114, 186);
            this.LBPeso.Name = "LBPeso";
            this.LBPeso.Size = new System.Drawing.Size(36, 17);
            this.LBPeso.TabIndex = 3;
            this.LBPeso.Text = "Peso";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(156, 136);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(350, 29);
            this.TBID.TabIndex = 2;
            // 
            // LBID
            // 
            this.LBID.AutoSize = true;
            this.LBID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBID.Location = new System.Drawing.Point(66, 142);
            this.LBID.Name = "LBID";
            this.LBID.Size = new System.Drawing.Size(84, 17);
            this.LBID.TabIndex = 1;
            this.LBID.Text = "Identificación";
            // 
            // LBRegistroPollo
            // 
            this.LBRegistroPollo.AutoSize = true;
            this.LBRegistroPollo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBRegistroPollo.Location = new System.Drawing.Point(49, 96);
            this.LBRegistroPollo.Name = "LBRegistroPollo";
            this.LBRegistroPollo.Size = new System.Drawing.Size(155, 25);
            this.LBRegistroPollo.TabIndex = 0;
            this.LBRegistroPollo.Text = "Registro de Pollo";
            // 
            // RegistroPollos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.PanelPollo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPollos";
            this.Text = "RegistroPollos";
            this.PanelPollo.ResumeLayout(false);
            this.PanelPollo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPollo;
        private System.Windows.Forms.Button BTRegPollo;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.Label LBColor;
        private System.Windows.Forms.TextBox TBPeso;
        private System.Windows.Forms.Label LBPeso;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Label LBID;
        private System.Windows.Forms.Label LBRegistroPollo;
    }
}