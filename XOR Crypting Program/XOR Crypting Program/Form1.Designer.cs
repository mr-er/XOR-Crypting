namespace XOR_Crypting_Program
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
            this.bInputFileOpen = new System.Windows.Forms.Button();
            this.bSaveOutputToFile = new System.Windows.Forms.Button();
            this.rTBConsole = new System.Windows.Forms.RichTextBox();
            this.bSavePasswordToFile = new System.Windows.Forms.Button();
            this.bInputPasswordOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bDoXOR = new System.Windows.Forms.Button();
            this.rTBPassword = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bInputFileOpen
            // 
            this.bInputFileOpen.BackColor = System.Drawing.SystemColors.Control;
            this.bInputFileOpen.Location = new System.Drawing.Point(22, 12);
            this.bInputFileOpen.Name = "bInputFileOpen";
            this.bInputFileOpen.Size = new System.Drawing.Size(131, 53);
            this.bInputFileOpen.TabIndex = 0;
            this.bInputFileOpen.Text = "Otwórz plik z danymi wejściowymi";
            this.bInputFileOpen.UseVisualStyleBackColor = false;
            this.bInputFileOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSaveOutputToFile
            // 
            this.bSaveOutputToFile.Enabled = false;
            this.bSaveOutputToFile.Location = new System.Drawing.Point(183, 226);
            this.bSaveOutputToFile.Name = "bSaveOutputToFile";
            this.bSaveOutputToFile.Size = new System.Drawing.Size(664, 23);
            this.bSaveOutputToFile.TabIndex = 1;
            this.bSaveOutputToFile.Text = "Zapisz plik";
            this.bSaveOutputToFile.UseVisualStyleBackColor = true;
            this.bSaveOutputToFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // rTBConsole
            // 
            this.rTBConsole.Location = new System.Drawing.Point(183, 12);
            this.rTBConsole.Name = "rTBConsole";
            this.rTBConsole.ReadOnly = true;
            this.rTBConsole.Size = new System.Drawing.Size(664, 208);
            this.rTBConsole.TabIndex = 3;
            this.rTBConsole.Text = "";
            // 
            // bSavePasswordToFile
            // 
            this.bSavePasswordToFile.Location = new System.Drawing.Point(22, 255);
            this.bSavePasswordToFile.Name = "bSavePasswordToFile";
            this.bSavePasswordToFile.Size = new System.Drawing.Size(131, 23);
            this.bSavePasswordToFile.TabIndex = 4;
            this.bSavePasswordToFile.Text = "Zapisz hasło do pliku";
            this.bSavePasswordToFile.UseVisualStyleBackColor = true;
            this.bSavePasswordToFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // bInputPasswordOpen
            // 
            this.bInputPasswordOpen.Location = new System.Drawing.Point(22, 124);
            this.bInputPasswordOpen.Name = "bInputPasswordOpen";
            this.bInputPasswordOpen.Size = new System.Drawing.Size(131, 23);
            this.bInputPasswordOpen.TabIndex = 9;
            this.bInputPasswordOpen.Text = "Wczytaj hasło";
            this.bInputPasswordOpen.UseVisualStyleBackColor = true;
            this.bInputPasswordOpen.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hasło:";
            // 
            // bDoXOR
            // 
            this.bDoXOR.Enabled = false;
            this.bDoXOR.Location = new System.Drawing.Point(183, 255);
            this.bDoXOR.Name = "bDoXOR";
            this.bDoXOR.Size = new System.Drawing.Size(664, 23);
            this.bDoXOR.TabIndex = 11;
            this.bDoXOR.Text = "Wykonaj szyfrowanie/deszyfrowanie";
            this.bDoXOR.UseVisualStyleBackColor = true;
            this.bDoXOR.Click += new System.EventHandler(this.button5_Click);
            // 
            // rTBPassword
            // 
            this.rTBPassword.Location = new System.Drawing.Point(22, 153);
            this.rTBPassword.MaxLength = 3000;
            this.rTBPassword.Name = "rTBPassword";
            this.rTBPassword.Size = new System.Drawing.Size(131, 96);
            this.rTBPassword.TabIndex = 12;
            this.rTBPassword.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 285);
            this.Controls.Add(this.rTBPassword);
            this.Controls.Add(this.bDoXOR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bInputPasswordOpen);
            this.Controls.Add(this.bSavePasswordToFile);
            this.Controls.Add(this.rTBConsole);
            this.Controls.Add(this.bSaveOutputToFile);
            this.Controls.Add(this.bInputFileOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XOR Crypting Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bInputFileOpen;
        private System.Windows.Forms.Button bSaveOutputToFile;
        private System.Windows.Forms.RichTextBox rTBConsole;
        private System.Windows.Forms.Button bSavePasswordToFile;
        private System.Windows.Forms.Button bInputPasswordOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDoXOR;
        private System.Windows.Forms.RichTextBox rTBPassword;
    }
}

