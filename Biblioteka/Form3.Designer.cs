namespace Biblioteka
{
    partial class Form3
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
            this.Txt_main = new System.Windows.Forms.TextBox();
            this.Txt_Trazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Trazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_main
            // 
            this.Txt_main.Location = new System.Drawing.Point(12, 109);
            this.Txt_main.Multiline = true;
            this.Txt_main.Name = "Txt_main";
            this.Txt_main.Size = new System.Drawing.Size(953, 397);
            this.Txt_main.TabIndex = 0;
            // 
            // Txt_Trazi
            // 
            this.Txt_Trazi.Location = new System.Drawing.Point(12, 40);
            this.Txt_Trazi.Name = "Txt_Trazi";
            this.Txt_Trazi.Size = new System.Drawing.Size(703, 20);
            this.Txt_Trazi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraživać";
            // 
            // Btn_Trazi
            // 
            this.Btn_Trazi.Location = new System.Drawing.Point(721, 40);
            this.Btn_Trazi.Name = "Btn_Trazi";
            this.Btn_Trazi.Size = new System.Drawing.Size(85, 20);
            this.Btn_Trazi.TabIndex = 3;
            this.Btn_Trazi.Text = "Traži";
            this.Btn_Trazi.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 518);
            this.Controls.Add(this.Btn_Trazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Trazi);
            this.Controls.Add(this.Txt_main);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_main;
        private System.Windows.Forms.TextBox Txt_Trazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Trazi;
    }
}