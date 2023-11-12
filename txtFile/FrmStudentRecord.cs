using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtFile
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            FrmRegistration frmreg = new FrmRegistration();
            frmreg.ShowDialog();
        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            DisplayList();
        }

        public void DisplayList()
        {
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.Title = "Browse Text Files";
            openFileDialog2.DefaultExt = "txt";
            openFileDialog2.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog2.ShowDialog();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = openFileDialog2.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = ""; while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvdisplay.Items.Add(_getText);
                }
            }
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully Uploaded!");
        }
    }
}
