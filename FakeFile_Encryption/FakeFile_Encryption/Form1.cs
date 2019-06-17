using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeFile_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            Encryption encryption = new Encryption();
            encryption.ShowDialog(this);
            if (encryption.DialogResult == System.Windows.Forms.DialogResult.OK)
                this.Visible = true;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            Decryption decryption = new Decryption();
            //this.Visible = false;
            decryption.ShowDialog(this);

            if (decryption.DialogResult == System.Windows.Forms.DialogResult.OK)
                this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
