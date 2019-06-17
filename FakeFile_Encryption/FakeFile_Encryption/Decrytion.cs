using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//Path.

namespace FakeFile_Encryption
{
    public partial class Decryption : Form
    {
        FileIO fileIO = new FileIO();
        StatusFlags _statusFlags = new StatusFlags();

        public Decryption()
        {
            InitializeComponent();
            progressBar1.Visible = true;
            progressBar1.Minimum = (int)StatusFlags.ProgressTime.TimeMinimum;
            progressBar1.Maximum = (int)StatusFlags.ProgressTime.TimeMaximum;
            progressBar1.Step = (int)StatusFlags.ProgressTime.TimeStep;
        }

        private void Decryption_Load(object sender, EventArgs e)
        {
            _statusFlags.WorkSatge = StatusFlags.Stage.Load_Initial;
            this.progressBar1.Value = progressBar1.Minimum;
        }

        private void iuput_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.RestoreDirectory = true;
            openFileDlg.Title = "Select a Key file";
            openFileDlg.Filter = "Fake File|*.*";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDlg.FileName != null)
            {
                _statusFlags.fakeFilePath = openFileDlg.FileName;
                String fakeFileName = Path.GetFileName(_statusFlags.fakeFilePath);
                _statusFlags.FolderType = _statusFlags.TypeCheck(_statusFlags.fakeFilePath);
                switch (_statusFlags.FolderType)
                {
                    case StatusFlags.Type.OK:
                        input_textBox.Text = fakeFileName;
                        if (_statusFlags.WorkSatge == StatusFlags.Stage.Load_SaveFile)
                            break;
                        status_label.Text = "Please select a key file";
                        _statusFlags.WorkSatge = StatusFlags.Stage.Load_FakeFile;
                        break;
                    case StatusFlags.Type.Exception:
                        status_label.Text = "Path/File access error !";
                        break;
                }
            }//if (dilog.ShowDialog()
        }

        private void iuput_btn2_Click(object sender, EventArgs e)
        {
            if (_statusFlags.WorkSatge != StatusFlags.Stage.Load_OriginalFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_SaveFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_FakeFile)
            {
                status_label.Text = "Please input Fake file";
                return;
            }
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.RestoreDirectory = true;
            openFileDlg.Title = "Select a key file";
            openFileDlg.Filter = "key file|*.*";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDlg.FileName != null)
            {
                _statusFlags.keyFilePath = openFileDlg.FileName;
                String keyFileName = Path.GetFileName(_statusFlags.keyFilePath);
                _statusFlags.FolderType = _statusFlags.TypeCheck(_statusFlags.keyFilePath);
                switch (_statusFlags.FolderType)
                {
                    case StatusFlags.Type.OK:
                        input_textBox2.Text = keyFileName;
                        if (_statusFlags.WorkSatge == StatusFlags.Stage.Load_SaveFile)
                            break;
                        status_label.Text = "Please select a Save path";
                        _statusFlags.WorkSatge = StatusFlags.Stage.Load_OriginalFile;
                        break;
                    case StatusFlags.Type.Exception:
                        status_label.Text = "Path/File access error !";
                        break;
                }
            }//if (dilog.ShowDialog()
        }

        private void output_btn_Click(object sender, EventArgs e)
        {
            if (_statusFlags.WorkSatge != StatusFlags.Stage.Load_OriginalFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_SaveFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_FakeFile)
            {
                status_label.Text = "Please input Fake file and Key file!";
                return;
            }
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "Select save path";
            if (dilog.ShowDialog() == DialogResult.OK)
            {
                _statusFlags.newFilePath = dilog.SelectedPath;
                output_textBox.Text = _statusFlags.newFilePath;
                status_label.Text = "Please press 'Start' button";
                _statusFlags.WorkSatge = StatusFlags.Stage.Load_SaveFile;
            }
            else
            {
                return;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (output_textBox.Text == "")
            {
                return;
            }  
            if(fileIO.FileDecrypted(_statusFlags.fakeFilePath, _statusFlags.keyFilePath, _statusFlags.newFilePath)== StatusFlags.Type.OK)
            {
                for (int x = (int)StatusFlags.ProgressTime.TimeMinimum; x <= (int)StatusFlags.ProgressTime.TimeMaximum; x++)
                {
                    System.Threading.Thread.Sleep((int)StatusFlags.ProgressTime.TimeMaximum);
                    progressBar1.PerformStep();
                }
                status_label.Text = "File decrypted successfully";
                DialogResult dialogResult = MessageBox.Show("Complete !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    progressBar1.Value = progressBar1.Minimum;
                    //_statusFlags.WorkSatge = StatusFlags.Stage.Load_Initial;
                    status_label.Text = "Please load the fake file!";
                }
                else
                {
                    status_label.Text = "File decrypted failure";
                }
            }
            else
            {
                status_label.Text = "File decrypted Error!!";
            }

        }
    }
}
