namespace SymmetricalEncryption
{
    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void btnBrowseInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose a file to encrypt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtInputFileName.Text = dlg.FileName;
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Choose a file to save your encrypted data into";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtOutputFileName.Text = dlg.FileName;
            }
        }

        private void txtInputFileName_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtInputFileName.Text = filenames[0];
        }

        private void txtInputFileName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtInputFileName_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtOutputFileName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtOutputFileName_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtOutputFileName.Text = filenames[0];
        }

        private void txtInputFileName_MouseEnter(object sender, EventArgs e)
        {
            SetStatus("Choose a file to encrypt");
        }

        private void EncryptionForm_MouseEnter(object sender, EventArgs e)
        {
            SetStatus("Welcome to symmetric encrytor");
        }

        private void txtOutputFileName_MouseEnter(object sender, EventArgs e)
        {
            SetStatus("Choose where to save your encrypted file");
        }

        public void SetStatus(string status, bool error = false)
        {
            lblStatus.Text = status;
            if (error)
            {
                lblStatus.ForeColor = Color.Red;
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // presence check
            if (txtInputFileName.Text == "")
            {
                SetStatus("You need to choose an input file", true);
                txtInputFileName.Focus();
                return;
            }

            // presence check
            if (txtOutputFileName.Text == "")
            {
                SetStatus("You need to choose an output file", true);
                txtOutputFileName.Focus();
                return;
            }

            // lookup check
            if (txtOutputFileName.Text == txtInputFileName.Text)
            {
                SetStatus("Your output file must be different to your input file", true);
                txtOutputFileName.Focus();
                return;
            }

            // lookup check
            if (!File.Exists(txtInputFileName.Text))
            {
                SetStatus("Could not find this input file (does it exist?)", true);
                txtInputFileName.Focus();
                return;
            }

            // length check
            if (txtPassword.Text.Length < 5)
            {
                SetStatus("Password must be 5 or more characters", true);
                txtPassword.Focus();
                return;
            }

            SetStatus("Encrypting...");
            Encryptor encryptor = new Encryptor(txtInputFileName.Text, txtOutputFileName.Text);
            pbProgress.Visible = true;
            pbProgress.Value = 0;
            pbProgress.Maximum = 100;
            encryptor.OnUpdate += Encryptor_OnUpdate;
            encryptor.Encrypt(txtPassword.Text);
        }

        private void Encryptor_OnUpdate(object? sender, EventArgs e)
        {
            pbProgress.Value++;
        }
    }
}