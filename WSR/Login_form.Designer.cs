namespace WSR {
    partial class Login_form {
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
            this.LoginIn_button = new System.Windows.Forms.Button();
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginIn_button
            // 
            this.LoginIn_button.Location = new System.Drawing.Point(106, 197);
            this.LoginIn_button.Name = "LoginIn_button";
            this.LoginIn_button.Size = new System.Drawing.Size(75, 23);
            this.LoginIn_button.TabIndex = 0;
            this.LoginIn_button.Text = "Login in";
            this.LoginIn_button.UseVisualStyleBackColor = true;
            this.LoginIn_button.Click += new System.EventHandler(this.LoginIn_button_Click);
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(106, 66);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(100, 20);
            this.Login_textbox.TabIndex = 1;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(106, 124);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(100, 20);
            this.Password_textbox.TabIndex = 2;
            this.Password_textbox.UseSystemPasswordChar = true;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(34, 66);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(33, 13);
            this.Login_label.TabIndex = 3;
            this.Login_label.Text = "Login";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(37, 124);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 4;
            this.Password_label.Text = "Password";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.Login_textbox);
            this.Controls.Add(this.LoginIn_button);
            this.Name = "Login_form";
            this.Text = "Login_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginIn_button;
        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
    }
}

