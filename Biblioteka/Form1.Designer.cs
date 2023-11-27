namespace Biblioteka
{
    partial class Form1
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
            this.Btn_Unos = new System.Windows.Forms.Button();
            this.Btn_Pregled = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Unos
            // 
            this.Btn_Unos.Location = new System.Drawing.Point(314, 203);
            this.Btn_Unos.Name = "Btn_Unos";
            this.Btn_Unos.Size = new System.Drawing.Size(148, 66);
            this.Btn_Unos.TabIndex = 0;
            this.Btn_Unos.Text = "Unos Podataka";
            this.Btn_Unos.UseVisualStyleBackColor = true;
            this.Btn_Unos.Click += new System.EventHandler(this.Btn_Unos_Click);
            // 
            // Btn_Pregled
            // 
            this.Btn_Pregled.Location = new System.Drawing.Point(314, 321);
            this.Btn_Pregled.Name = "Btn_Pregled";
            this.Btn_Pregled.Size = new System.Drawing.Size(148, 66);
            this.Btn_Pregled.TabIndex = 1;
            this.Btn_Pregled.Text = "Pregled Podataka";
            this.Btn_Pregled.UseVisualStyleBackColor = true;
            this.Btn_Pregled.Click += new System.EventHandler(this.Btn_Pregled_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(314, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dobrodošli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Pregled);
            this.Controls.Add(this.Btn_Unos);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Unos;
        private System.Windows.Forms.Button Btn_Pregled;
        private System.Windows.Forms.Label label1;
    }
}

