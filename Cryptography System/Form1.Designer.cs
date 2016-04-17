namespace Cryptography_System
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOutputFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.inputFile = new System.Windows.Forms.TextBox();
            this.openInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputFile = new System.Windows.Forms.TextBox();
            this.openOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.encryptionGroup = new System.Windows.Forms.GroupBox();
            this.tripledes = new System.Windows.Forms.RadioButton();
            this.rc2 = new System.Windows.Forms.RadioButton();
            this.rijndael = new System.Windows.Forms.RadioButton();
            this.des = new System.Windows.Forms.RadioButton();
            this.hashGroup = new System.Windows.Forms.GroupBox();
            this.sha512 = new System.Windows.Forms.RadioButton();
            this.sha1 = new System.Windows.Forms.RadioButton();
            this.sha256 = new System.Windows.Forms.RadioButton();
            this.md5 = new System.Windows.Forms.RadioButton();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.digest = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.encryptionGroup.SuspendLayout();
            this.hashGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInputFileToolStripMenuItem,
            this.openOutputFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // openInputFileToolStripMenuItem
            // 
            this.openInputFileToolStripMenuItem.Name = "openInputFileToolStripMenuItem";
            this.openInputFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openInputFileToolStripMenuItem.Text = "Open &Input File";
            this.openInputFileToolStripMenuItem.Click += new System.EventHandler(this.openInputFileToolStripMenuItem_Click);
            // 
            // openOutputFileToolStripMenuItem
            // 
            this.openOutputFileToolStripMenuItem.Name = "openOutputFileToolStripMenuItem";
            this.openOutputFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openOutputFileToolStripMenuItem.Text = "Open &Output File";
            this.openOutputFileToolStripMenuItem.Click += new System.EventHandler(this.openOutputFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(15, 40);
            this.inputFile.Name = "inputFile";
            this.inputFile.Size = new System.Drawing.Size(266, 20);
            this.inputFile.TabIndex = 2;
            // 
            // openInput
            // 
            this.openInput.Location = new System.Drawing.Point(299, 37);
            this.openInput.Name = "openInput";
            this.openInput.Size = new System.Drawing.Size(75, 23);
            this.openInput.TabIndex = 3;
            this.openInput.Text = "Browse";
            this.openInput.UseVisualStyleBackColor = true;
            this.openInput.Click += new System.EventHandler(this.openInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(15, 79);
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(266, 20);
            this.outputFile.TabIndex = 5;
            // 
            // openOutput
            // 
            this.openOutput.Location = new System.Drawing.Point(299, 79);
            this.openOutput.Name = "openOutput";
            this.openOutput.Size = new System.Drawing.Size(75, 23);
            this.openOutput.TabIndex = 6;
            this.openOutput.Text = "Browse";
            this.openOutput.UseVisualStyleBackColor = true;
            this.openOutput.Click += new System.EventHandler(this.openOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(65, 120);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(216, 20);
            this.password.TabIndex = 8;
            this.password.UseSystemPasswordChar = true;
            // 
            // encryptionGroup
            // 
            this.encryptionGroup.Controls.Add(this.tripledes);
            this.encryptionGroup.Controls.Add(this.rc2);
            this.encryptionGroup.Controls.Add(this.rijndael);
            this.encryptionGroup.Controls.Add(this.des);
            this.encryptionGroup.Location = new System.Drawing.Point(15, 146);
            this.encryptionGroup.Name = "encryptionGroup";
            this.encryptionGroup.Size = new System.Drawing.Size(368, 56);
            this.encryptionGroup.TabIndex = 9;
            this.encryptionGroup.TabStop = false;
            this.encryptionGroup.Text = "Encryption Algorithm";
            // 
            // tripledes
            // 
            this.tripledes.AutoSize = true;
            this.tripledes.Location = new System.Drawing.Point(279, 19);
            this.tripledes.Name = "tripledes";
            this.tripledes.Size = new System.Drawing.Size(73, 17);
            this.tripledes.TabIndex = 3;
            this.tripledes.Text = "TripleDES";
            this.tripledes.UseVisualStyleBackColor = true;
            this.tripledes.CheckedChanged += new System.EventHandler(this.tripledes_CheckedChanged);
            // 
            // rc2
            // 
            this.rc2.AutoSize = true;
            this.rc2.Location = new System.Drawing.Point(97, 19);
            this.rc2.Name = "rc2";
            this.rc2.Size = new System.Drawing.Size(46, 17);
            this.rc2.TabIndex = 2;
            this.rc2.Text = "RC2";
            this.rc2.UseVisualStyleBackColor = true;
            // 
            // rijndael
            // 
            this.rijndael.AutoSize = true;
            this.rijndael.Location = new System.Drawing.Point(188, 19);
            this.rijndael.Name = "rijndael";
            this.rijndael.Size = new System.Drawing.Size(63, 17);
            this.rijndael.TabIndex = 1;
            this.rijndael.Text = "Rijndael";
            this.rijndael.UseVisualStyleBackColor = true;
            // 
            // des
            // 
            this.des.AutoSize = true;
            this.des.Checked = true;
            this.des.Location = new System.Drawing.Point(6, 20);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(47, 17);
            this.des.TabIndex = 0;
            this.des.TabStop = true;
            this.des.Text = "DES";
            this.des.UseVisualStyleBackColor = true;
            // 
            // hashGroup
            // 
            this.hashGroup.Controls.Add(this.sha512);
            this.hashGroup.Controls.Add(this.sha1);
            this.hashGroup.Controls.Add(this.sha256);
            this.hashGroup.Controls.Add(this.md5);
            this.hashGroup.Location = new System.Drawing.Point(12, 208);
            this.hashGroup.Name = "hashGroup";
            this.hashGroup.Size = new System.Drawing.Size(359, 56);
            this.hashGroup.TabIndex = 10;
            this.hashGroup.TabStop = false;
            this.hashGroup.Text = "Message Digest Algorithm";
            // 
            // sha512
            // 
            this.sha512.AutoSize = true;
            this.sha512.Location = new System.Drawing.Point(282, 19);
            this.sha512.Name = "sha512";
            this.sha512.Size = new System.Drawing.Size(65, 17);
            this.sha512.TabIndex = 7;
            this.sha512.TabStop = true;
            this.sha512.Text = "SHA512";
            this.sha512.UseVisualStyleBackColor = true;
            this.sha512.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // sha1
            // 
            this.sha1.AutoSize = true;
            this.sha1.Location = new System.Drawing.Point(100, 19);
            this.sha1.Name = "sha1";
            this.sha1.Size = new System.Drawing.Size(53, 17);
            this.sha1.TabIndex = 6;
            this.sha1.TabStop = true;
            this.sha1.Text = "SHA1";
            this.sha1.UseVisualStyleBackColor = true;
            // 
            // sha256
            // 
            this.sha256.AutoSize = true;
            this.sha256.Location = new System.Drawing.Point(191, 19);
            this.sha256.Name = "sha256";
            this.sha256.Size = new System.Drawing.Size(65, 17);
            this.sha256.TabIndex = 5;
            this.sha256.TabStop = true;
            this.sha256.Text = "SHA256";
            this.sha256.UseVisualStyleBackColor = true;
            // 
            // md5
            // 
            this.md5.AutoSize = true;
            this.md5.Checked = true;
            this.md5.Location = new System.Drawing.Point(9, 20);
            this.md5.Name = "md5";
            this.md5.Size = new System.Drawing.Size(48, 17);
            this.md5.TabIndex = 4;
            this.md5.TabStop = true;
            this.md5.Text = "MD5";
            this.md5.UseVisualStyleBackColor = true;
            this.md5.CheckedChanged += new System.EventHandler(this.md5_CheckedChanged);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 270);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 37);
            this.encrypt.TabIndex = 11;
            this.encrypt.Text = "&Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(112, 270);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 37);
            this.decrypt.TabIndex = 12;
            this.decrypt.Text = "&Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // digest
            // 
            this.digest.Location = new System.Drawing.Point(206, 270);
            this.digest.Name = "digest";
            this.digest.Size = new System.Drawing.Size(75, 37);
            this.digest.TabIndex = 13;
            this.digest.Text = "Di&gest";
            this.digest.UseVisualStyleBackColor = true;
            this.digest.Click += new System.EventHandler(this.digest_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(299, 270);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 37);
            this.exit.TabIndex = 14;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 321);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 13);
            this.progressBar1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Progress Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.digest);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.hashGroup);
            this.Controls.Add(this.encryptionGroup);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openOutput);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openInput);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cryptography System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.encryptionGroup.ResumeLayout(false);
            this.encryptionGroup.PerformLayout();
            this.hashGroup.ResumeLayout(false);
            this.hashGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOutputFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputFile;
        private System.Windows.Forms.Button openInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputFile;
        private System.Windows.Forms.Button openOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.GroupBox encryptionGroup;
        private System.Windows.Forms.RadioButton tripledes;
        private System.Windows.Forms.RadioButton rc2;
        private System.Windows.Forms.RadioButton rijndael;
        private System.Windows.Forms.RadioButton des;
        private System.Windows.Forms.GroupBox hashGroup;
        private System.Windows.Forms.RadioButton sha512;
        private System.Windows.Forms.RadioButton sha1;
        private System.Windows.Forms.RadioButton sha256;
        private System.Windows.Forms.RadioButton md5;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button digest;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
    }
}

