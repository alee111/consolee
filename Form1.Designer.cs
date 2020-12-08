namespace Consolee
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
            this.button1 = new System.Windows.Forms.Button();
            this.btncamioneta = new System.Windows.Forms.Button();
            this.btncamion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "carro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncamioneta
            // 
            this.btncamioneta.Location = new System.Drawing.Point(274, 117);
            this.btncamioneta.Name = "btncamioneta";
            this.btncamioneta.Size = new System.Drawing.Size(130, 61);
            this.btncamioneta.TabIndex = 1;
            this.btncamioneta.Text = "camioneta";
            this.btncamioneta.UseVisualStyleBackColor = true;
            this.btncamioneta.Click += new System.EventHandler(this.btncamioneta_Click);
            // 
            // btncamion
            // 
            this.btncamion.Location = new System.Drawing.Point(274, 202);
            this.btncamion.Name = "btncamion";
            this.btncamion.Size = new System.Drawing.Size(129, 56);
            this.btncamion.TabIndex = 2;
            this.btncamion.Text = "camion";
            this.btncamion.UseVisualStyleBackColor = true;
            this.btncamion.Click += new System.EventHandler(this.btncamion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 320);
            this.Controls.Add(this.btncamion);
            this.Controls.Add(this.btncamioneta);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "btncarro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncamioneta;
        private System.Windows.Forms.Button btncamion;
    }
}