namespace Quiz
{
    partial class AddPlayer
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
            this.AddBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CantelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(135, 64);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 1;
            // 
            // CantelBTN
            // 
            this.CantelBTN.Location = new System.Drawing.Point(13, 64);
            this.CantelBTN.Name = "CantelBTN";
            this.CantelBTN.Size = new System.Drawing.Size(75, 23);
            this.CantelBTN.TabIndex = 2;
            this.CantelBTN.Text = "Cantel";
            this.CantelBTN.UseVisualStyleBackColor = true;
            this.CantelBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CantelBTN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddBTN);
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CantelBTN;
    }
}