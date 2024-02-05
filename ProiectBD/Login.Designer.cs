namespace ProiectBD
{
    partial class Login
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
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(266, 115);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(166, 27);
            this.userTextBox.TabIndex = 0;
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Location = new System.Drawing.Point(268, 173);
            this.parolaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.PasswordChar = '*';
            this.parolaTextBox.Size = new System.Drawing.Size(164, 27);
            this.parolaTextBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(158, 118);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(91, 20);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username:";
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Location = new System.Drawing.Point(158, 173);
            this.parolaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(88, 20);
            this.parolaLabel.TabIndex = 3;
            this.parolaLabel.Text = "Password:";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(268, 255);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(164, 43);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Register_Button
            // 
            this.Register_Button.Location = new System.Drawing.Point(75, 255);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(143, 43);
            this.Register_Button.TabIndex = 6;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = true;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 389);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.userTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Register_Button;
    }
}