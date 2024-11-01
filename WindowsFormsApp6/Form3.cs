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

namespace WindowsFormsApp6
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registration = new FrmRegistration();
            registration.ShowDialog();

            string studentNumber = txtStudentNo.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleinitial = txtMiddleInitial.Text;
            string age = txtAge.Text;
            string birthday = dtpBirthday.Value.ToShortDateString();
            string gender = cmbGender.SelectedItem?.ToString() ?? "Not Specified";
            string program = txtProgram.Text;
            string contactNumber = txtContactNo.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string fileName = studentNumber + ".txt";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                outputFile.WriteLine($"Student Number: {studentNumber}");
                outputFile.WriteLine($"First Name: {firstName}");
                outputFile.WriteLine($"Last Name: {lastName}");
                outputFile.WriteLine($"Middle Initial: {middleinitial}");
                outputFile.WriteLine($"Age: {age}");
                outputFile.WriteLine($"Birthday: {birthday}");
                outputFile.WriteLine($"Gender: {gender}");
                outputFile.WriteLine($"Program: {program}");
                outputFile.WriteLine($"Contact Number: {contactNumber}");
            }
        }
    }
}
