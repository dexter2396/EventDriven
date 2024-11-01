using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName fileNameForm = new FrmFileName();
            fileNameForm.ShowDialog();

            string GetInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(GetInput);
                Console.WriteLine(GetInput);

            }





        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.ShowDialog();
        }
    }
}
