﻿namespace Quiz {
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
            this.PlayersList = new System.Windows.Forms.ListBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.AddBtn.Location = new System.Drawing.Point(172, 41);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "ADD PLAYER";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.SelectBtn.Location = new System.Drawing.Point(172, 12);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(110, 23);
            this.SelectBtn.TabIndex = 1;
            this.SelectBtn.Text = "PLAY";
            this.SelectBtn.UseVisualStyleBackColor = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // PlayersList
            // 
            this.PlayersList.BackColor = System.Drawing.SystemColors.InfoText;
            this.PlayersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayersList.ForeColor = System.Drawing.Color.White;
            this.PlayersList.FormattingEnabled = true;
            this.PlayersList.Location = new System.Drawing.Point(13, 12);
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(153, 119);
            this.PlayersList.TabIndex = 3;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.EditBtn.Location = new System.Drawing.Point(172, 70);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(110, 23);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "ADD QUESTIONS";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitBtn.Location = new System.Drawing.Point(172, 108);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(293, 143);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.PlayersList);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "LoginForm";
            this.Text = "LOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.ListBox PlayersList;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

