namespace Quiz {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddBtn = new System.Windows.Forms.Button();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.NewPlayerTB = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.AddBtn.Location = new System.Drawing.Point(172, 78);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(100, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SelectBtn.Location = new System.Drawing.Point(172, 49);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(100, 23);
            this.SelectBtn.TabIndex = 1;
            this.SelectBtn.Text = "SELECT";
            this.SelectBtn.UseVisualStyleBackColor = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // NewPlayerTB
            // 
            this.NewPlayerTB.BackColor = System.Drawing.SystemColors.InfoText;
            this.NewPlayerTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPlayerTB.ForeColor = System.Drawing.Color.White;
            this.NewPlayerTB.Location = new System.Drawing.Point(172, 12);
            this.NewPlayerTB.Name = "NewPlayerTB";
            this.NewPlayerTB.Size = new System.Drawing.Size(100, 20);
            this.NewPlayerTB.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 145);
            this.listBox1.TabIndex = 3;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.EditBtn.Location = new System.Drawing.Point(173, 107);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(100, 23);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.DeleteBtn.Location = new System.Drawing.Point(173, 136);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(99, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NewPlayerTB);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "LoginForm";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.TextBox NewPlayerTB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}

