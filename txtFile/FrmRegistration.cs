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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string age = agetxt.Text;
            string bday = bd.Text;
            string progg = prog.Text;
            string fn = fntxt.Text;
            string mn = mitxt.Text;
            string snum = sntxt.Text;
            string lname = lntxt.Text;
            string genderr = gender.Text;
            string cn = cntxt.Text;
            string FileName = snum + ".txt";

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, FileName));

            string[] reg = { "StudentNo.:" + snum, "FullName:" + fn + " " + mn + " " + lname, 
                "Program:" + progg + "\nAge:" + age, "Birthday:" + bday, "ContactNo.:" + cn, "Gender: " + genderr };
            Console.WriteLine(snum);

            foreach (string i in reg)
            {
                outputFile.WriteLine(i);
            }
            
            outputFile.Close();
            MessageBox.Show("Saved!");
           
        }
    }
}
