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
    public partial class Encryption : Form
    {
        FileIO fileIO = new FileIO();
        StatusFlags _statusFlags = new StatusFlags();

        public Encryption()
        {
            InitializeComponent();
            progressBar1.Visible = true;
            progressBar1.Minimum = (int)StatusFlags.ProgressTime.TimeMinimum;
            progressBar1.Maximum = (int)StatusFlags.ProgressTime.TimeMaximum;
            progressBar1.Step = (int)StatusFlags.ProgressTime.TimeStep;
        }

        private void Encryption_Load(object sender, EventArgs e)
        {

            _statusFlags.WorkSatge = StatusFlags.Stage.Load_Initial;
            this.progressBar1.Value = progressBar1.Minimum;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iuput_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.RestoreDirectory = true;
            openFileDlg.Title = "Select a Original file";
            openFileDlg.Filter = "Original|*.*";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDlg.FileName != null)
            {
                _statusFlags.sourceFilePath = openFileDlg.FileName;
                String sourceFileName = Path.GetFileName(_statusFlags.sourceFilePath);
                _statusFlags.FolderType = _statusFlags.TypeCheck(_statusFlags.sourceFilePath);
                switch (_statusFlags.FolderType)
                {
                    case StatusFlags.Type.OK:
                        input_textBox.Text = sourceFileName;
                        if (_statusFlags.WorkSatge == StatusFlags.Stage.Load_SaveFile)
                            break;
                        status_label.Text = "Please select a pack file";
                        _statusFlags.WorkSatge = StatusFlags.Stage.Load_OriginalFile;
                        break;
                    case StatusFlags.Type.Exception:
                        status_label.Text = "Path/File access error !";
                        break;
                }
            }//if (dilog.ShowDialog()
        }


        private void iuput_btn2_Click(object sender, EventArgs e)
        {
            if (_statusFlags.WorkSatge != StatusFlags.Stage.Load_OriginalFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_SaveFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_PackFile)
            {
                status_label.Text = "Please input Original file";
                return;
            }
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.RestoreDirectory = true;
            openFileDlg.Title = "Select a pack file";
            openFileDlg.Filter = "pack file|*.*";
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDlg.FileName != null)
            {
                _statusFlags.packFilePath = openFileDlg.FileName;
                String packFileName = Path.GetFileName(_statusFlags.packFilePath);
                _statusFlags.fileNameExtension = Path.GetExtension(_statusFlags.packFilePath);
                _statusFlags.FolderType = _statusFlags.TypeCheck(_statusFlags.packFilePath);
                switch (_statusFlags.FolderType)
                {
                    case StatusFlags.Type.OK:
                        input_textBox2.Text = packFileName;
                        if (_statusFlags.WorkSatge == StatusFlags.Stage.Load_SaveFile)
                            break;
                        status_label.Text = "Please select a Save path";
                        _statusFlags.WorkSatge = StatusFlags.Stage.Load_PackFile;
                        break;
                    case StatusFlags.Type.Exception:
                        status_label.Text = "Path/File access error !";
                        break;
                }
            }//if (dilog.ShowDialog()
        }

        private void output_btn_Click(object sender, EventArgs e)
        {
            if(_statusFlags.WorkSatge != StatusFlags.Stage.Load_PackFile&& _statusFlags.WorkSatge != StatusFlags.Stage.Load_OriginalFile && _statusFlags.WorkSatge != StatusFlags.Stage.Load_SaveFile)
            {
                status_label.Text = "Please input Original file and pack file";
                return;
            }
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.RestoreDirectory = true;
            saveFileDlg.Title = "Select a save path";
            //saveFileDlg.FilterIndex = 1;
            saveFileDlg.Filter = "Filename Extension (" + _statusFlags.fileNameExtension + ")" + "|*" + _statusFlags.fileNameExtension;
            if (saveFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDlg.FileName != null)
            {
                _statusFlags.newFilePath = saveFileDlg.FileName;
                String newFileName = Path.GetFileName(_statusFlags.newFilePath);
                output_textBox.Text = newFileName;
                status_label.Text = "Please press 'Start' button";
                _statusFlags.WorkSatge = StatusFlags.Stage.Load_SaveFile;

            }//if (dilog.ShowDialog()
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (output_textBox.Text == "")
            {
                return;
            }


            for (int x = (int)StatusFlags.ProgressTime.TimeMinimum; x <= (int)StatusFlags.ProgressTime.TimeMaximum; x++)
            {
                System.Threading.Thread.Sleep((int)StatusFlags.ProgressTime.TimeMaximum);
                progressBar1.PerformStep();
            }
            fileIO.FakeFileEncrypted(_statusFlags.sourceFilePath, _statusFlags.packFilePath, _statusFlags.newFilePath);

            status_label.Text = "File encrypted successfully";
            DialogResult dialogResult = MessageBox.Show("Complete !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.OK)
            {
                progressBar1.Value = progressBar1.Minimum;
                //_statusFlags.WorkSatge = StatusFlags.Stage.Load_Initial;
                status_label.Text = "Please load the source file!";
            }
        }

    }
}
