using MetroFramework.Forms;
using Neurotec.Biometrics;
using Neurotec.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URPassManager.core;

namespace URPassManager
{
    public partial class RegisterForm : MetroForm
    {
        private bool _scannedFinger = false;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void rePasswordBox_TextChanged(object sender, EventArgs e)
        {
            checkPass();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            checkPass();
        }

        private void checkPass()
        {
            if (passwordBox.Text.Length > 0 && passwordBox.Text == rePasswordBox.Text)
                addFpBtn.Enabled = true;
            else
                addFpBtn.Enabled = false;
        }

        internal class EnrollmentResult
        {
            public NffvStatus engineStatus;
            public NffvUser engineUser;
        };

        private void doEnroll(object sender, DoWorkEventArgs args)
        {
            EnrollmentResult enrollmentResults = new EnrollmentResult();
            enrollmentResults.engineUser = Program.Engine.Enroll(20000, out enrollmentResults.engineStatus);
            args.Result = enrollmentResults;
        }

        private void CancelScanningHandler(object sender, EventArgs e)
        {
            Program.Engine.Cancel();
        }

        private void addFpBtn_Click(object sender, EventArgs e)
        {
            if (_scannedFinger)
            {
                FileManager.WritePassHash(passwordBox.Text);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                return;
            }

            addFpBtn.Text = "Zarejestruj";
            addFpBtn.Enabled = false;
            this.Height = 460;

            RunWorkerCompletedEventArgs taskResult = BusyForm.RunLongTask("Waiting for fingerprint ...", new DoWorkEventHandler(doEnroll),
                        false, null, new EventHandler(CancelScanningHandler));
            EnrollmentResult enrollmentResult = (EnrollmentResult)taskResult.Result;

            if (enrollmentResult.engineStatus == NffvStatus.TemplateCreated)
            {
                NffvUser engineUser = enrollmentResult.engineUser;
                fpPicBox.Image = engineUser.GetBitmap();

                _scannedFinger = true;
                addFpBtn.Enabled = true;
                
            }
            else
            {
                NffvStatus engineStatus = enrollmentResult.engineStatus;
                MessageBox.Show(string.Format("Enrollment was not finished. Reason: {0}", engineStatus));
            }

            /* rem  */
            //_scannedFinger = true;
            //addFpBtn.Enabled = true;
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
