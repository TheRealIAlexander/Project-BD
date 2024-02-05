namespace ProiectBD
{
    partial class DashBoard
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
            this.Display_ListBox = new System.Windows.Forms.ListBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.adauga_in_tabele = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display_ListBox
            // 
            this.Display_ListBox.FormattingEnabled = true;
            this.Display_ListBox.ItemHeight = 20;
            this.Display_ListBox.Location = new System.Drawing.Point(26, 233);
            this.Display_ListBox.Name = "Display_ListBox";
            this.Display_ListBox.Size = new System.Drawing.Size(689, 304);
            this.Display_ListBox.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(22, 15);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(219, 20);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Introduceti numele/data aici:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(26, 58);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(248, 40);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Adresele de livrare din ziua";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(264, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(177, 27);
            this.SearchTextBox.TabIndex = 4;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(26, 104);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(248, 38);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "Angajatii si Clientii din ziua";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(316, 58);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(253, 40);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "Angajatul si coletele sale";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(26, 148);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(248, 38);
            this.Button4.TabIndex = 7;
            this.Button4.Text = "Incasarile din ziua";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(612, 58);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(253, 38);
            this.Button5.TabIndex = 8;
            this.Button5.Text = "Depozitele cu pachete urgente";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(316, 107);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(253, 35);
            this.Button6.TabIndex = 9;
            this.Button6.Text = "Clientul si coletele sale";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // adauga_in_tabele
            // 
            this.adauga_in_tabele.Location = new System.Drawing.Point(756, 239);
            this.adauga_in_tabele.Name = "adauga_in_tabele";
            this.adauga_in_tabele.Size = new System.Drawing.Size(204, 43);
            this.adauga_in_tabele.TabIndex = 10;
            this.adauga_in_tabele.Text = "Modificati tabelele?";
            this.adauga_in_tabele.UseVisualStyleBackColor = true;
            this.adauga_in_tabele.Click += new System.EventHandler(this.adauga_in_tabele_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(612, 107);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(253, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "Pachetele intarziate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(316, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(253, 50);
            this.button8.TabIndex = 12;
            this.button8.Text = "Angajati cu traseu mai mare decat media";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.adauga_in_tabele);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.Display_ListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Display_ListBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button adauga_in_tabele;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

