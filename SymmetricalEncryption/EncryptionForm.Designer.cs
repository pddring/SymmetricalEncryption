namespace SymmetricalEncryption
{
    partial class EncryptionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEncrypt = new Button();
            txtInputFileName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOutputFileName = new TextBox();
            btnBrowseInput = new Button();
            btnBrowseOutput = new Button();
            lblStatus = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            pbProgress = new ProgressBar();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(491, 160);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(131, 37);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "&Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // txtInputFileName
            // 
            txtInputFileName.AllowDrop = true;
            txtInputFileName.Location = new Point(135, 19);
            txtInputFileName.Name = "txtInputFileName";
            txtInputFileName.Size = new Size(487, 23);
            txtInputFileName.TabIndex = 1;
            txtInputFileName.DragDrop += txtInputFileName_DragDrop;
            txtInputFileName.DragEnter += txtInputFileName_DragEnter;
            txtInputFileName.DragOver += txtInputFileName_DragOver;
            txtInputFileName.MouseEnter += txtInputFileName_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Input file name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Output file name:";
            // 
            // txtOutputFileName
            // 
            txtOutputFileName.AllowDrop = true;
            txtOutputFileName.Location = new Point(135, 65);
            txtOutputFileName.Name = "txtOutputFileName";
            txtOutputFileName.Size = new Size(487, 23);
            txtOutputFileName.TabIndex = 2;
            txtOutputFileName.DragDrop += txtOutputFileName_DragDrop;
            txtOutputFileName.DragEnter += txtOutputFileName_DragEnter;
            txtOutputFileName.MouseEnter += txtOutputFileName_MouseEnter;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.Location = new Point(637, 20);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(58, 23);
            btnBrowseInput.TabIndex = 5;
            btnBrowseInput.Text = "&Browse";
            btnBrowseInput.UseVisualStyleBackColor = true;
            btnBrowseInput.Click += btnBrowseInput_Click;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Location = new Point(637, 65);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(58, 23);
            btnBrowseOutput.TabIndex = 6;
            btnBrowseOutput.Text = "Bro&wse";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 171);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(191, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Welcome to Symmetric Encryption";
            // 
            // txtPassword
            // 
            txtPassword.AllowDrop = true;
            txtPassword.Location = new Point(135, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(487, 23);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // pbProgress
            // 
            pbProgress.Location = new Point(12, 205);
            pbProgress.Name = "pbProgress";
            pbProgress.Size = new Size(100, 23);
            pbProgress.TabIndex = 10;
            pbProgress.Visible = false;
            // 
            // EncryptionForm
            // 
            AcceptButton = btnEncrypt;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 231);
            Controls.Add(pbProgress);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(lblStatus);
            Controls.Add(btnBrowseOutput);
            Controls.Add(btnBrowseInput);
            Controls.Add(txtOutputFileName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInputFileName);
            Controls.Add(btnEncrypt);
            Name = "EncryptionForm";
            Text = "Symmetric Encryption";
            MouseEnter += EncryptionForm_MouseEnter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private TextBox txtInputFileName;
        private Label label1;
        private Label label2;
        private TextBox txtOutputFileName;
        private Button btnBrowseInput;
        private Button btnBrowseOutput;
        private Label lblStatus;
        private TextBox txtPassword;
        private Label label3;
        private ProgressBar pbProgress;
    }
}