namespace Quiz
{
    partial class GameplayForm
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
            this.ABtn = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.BBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.DBtn = new System.Windows.Forms.Button();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ABtn
            // 
            this.ABtn.BackColor = System.Drawing.Color.Black;
            this.ABtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ABtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ABtn.Location = new System.Drawing.Point(16, 138);
            this.ABtn.Name = "ABtn";
            this.ABtn.Size = new System.Drawing.Size(31, 23);
            this.ABtn.TabIndex = 0;
            this.ABtn.Text = "A";
            this.ABtn.UseVisualStyleBackColor = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QuestionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionLabel.ForeColor = System.Drawing.Color.Orange;
            this.QuestionLabel.Location = new System.Drawing.Point(13, 13);
            this.QuestionLabel.MinimumSize = new System.Drawing.Size(260, 50);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(260, 50);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "label1";
            // 
            // BBtn
            // 
            this.BBtn.BackColor = System.Drawing.Color.Black;
            this.BBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.BBtn.Location = new System.Drawing.Point(242, 138);
            this.BBtn.Name = "BBtn";
            this.BBtn.Size = new System.Drawing.Size(31, 23);
            this.BBtn.TabIndex = 2;
            this.BBtn.Text = "B";
            this.BBtn.UseVisualStyleBackColor = false;
            // 
            // CBtn
            // 
            this.CBtn.BackColor = System.Drawing.Color.Black;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CBtn.Location = new System.Drawing.Point(13, 226);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(31, 23);
            this.CBtn.TabIndex = 3;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = false;
            // 
            // DBtn
            // 
            this.DBtn.BackColor = System.Drawing.Color.Black;
            this.DBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DBtn.Location = new System.Drawing.Point(241, 226);
            this.DBtn.Name = "DBtn";
            this.DBtn.Size = new System.Drawing.Size(31, 23);
            this.DBtn.TabIndex = 4;
            this.DBtn.Text = "D";
            this.DBtn.UseVisualStyleBackColor = false;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALabel.ForeColor = System.Drawing.Color.Orange;
            this.ALabel.Location = new System.Drawing.Point(13, 72);
            this.ALabel.MinimumSize = new System.Drawing.Size(125, 50);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(125, 50);
            this.ALabel.TabIndex = 5;
            this.ALabel.Text = "label1";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLabel.ForeColor = System.Drawing.Color.Orange;
            this.BLabel.Location = new System.Drawing.Point(148, 72);
            this.BLabel.MinimumSize = new System.Drawing.Size(125, 50);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(125, 50);
            this.BLabel.TabIndex = 6;
            this.BLabel.Text = "label2";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DLabel.ForeColor = System.Drawing.Color.Orange;
            this.DLabel.Location = new System.Drawing.Point(148, 164);
            this.DLabel.MinimumSize = new System.Drawing.Size(125, 50);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(125, 50);
            this.DLabel.TabIndex = 8;
            this.DLabel.Text = "label3";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLabel.ForeColor = System.Drawing.Color.Orange;
            this.CLabel.Location = new System.Drawing.Point(13, 164);
            this.CLabel.MinimumSize = new System.Drawing.Size(125, 50);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(125, 50);
            this.CLabel.TabIndex = 7;
            this.CLabel.Text = "label4";
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.Black;
            this.QuitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.QuitBtn.Location = new System.Drawing.Point(114, 226);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(61, 23);
            this.QuitBtn.TabIndex = 9;
            this.QuitBtn.Text = "Exit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            // 
            // GameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.DBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.BBtn);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ABtn);
            this.Name = "GameplayForm";
            this.Text = "GameplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ABtn;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button BBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button DBtn;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Button QuitBtn;
    }
}