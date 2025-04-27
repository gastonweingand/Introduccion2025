namespace WinApp
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearTaxi = new System.Windows.Forms.Button();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            // 
            // btnCrearTaxi
            // 
            this.btnCrearTaxi.Location = new System.Drawing.Point(130, 148);
            this.btnCrearTaxi.Name = "btnCrearTaxi";
            this.btnCrearTaxi.Size = new System.Drawing.Size(117, 46);
            this.btnCrearTaxi.TabIndex = 1;
            this.btnCrearTaxi.Text = "Crear Taxi";
            this.btnCrearTaxi.UseVisualStyleBackColor = true;
            this.btnCrearTaxi.Click += new System.EventHandler(this.btnCrearTaxi_Click);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(146, 58);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(178, 26);
            this.txtPatente.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.btnCrearTaxi);
            this.Controls.Add(this.label1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearTaxi;
        private System.Windows.Forms.TextBox txtPatente;
    }
}