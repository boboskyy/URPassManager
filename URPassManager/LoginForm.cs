using MetroFramework.Forms;
using Neurotec.Biometrics;
using Neurotec.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URPassManager.core;

namespace URPassManager
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        internal class VerificationResult
        {
            public NffvStatus engineStatus;
            public int score;
        };

        private void doVerify(object sender, DoWorkEventArgs args)
        {
            VerificationResult verificationResult = new VerificationResult();
            verificationResult.score = Program.Engine.Verify((NffvUser)args.Argument, 20000, out verificationResult.engineStatus);
            args.Result = verificationResult;
        }

        private void CancelScanningHandler(object sender, EventArgs e)
        {
            Program.Engine.Cancel();
        }

        private void loginFpBtn_Click(object sender, EventArgs e)
        {
            if (Program.Engine.Users.Count < 1)
                return;

            RunWorkerCompletedEventArgs taskResult = BusyForm.RunLongTask("Waiting for fingerprint ...", new DoWorkEventHandler(doVerify),
                        false, Program.Engine.Users[0], new EventHandler(CancelScanningHandler));
            VerificationResult verificationResult = (VerificationResult)taskResult.Result;
            if (verificationResult.engineStatus == NffvStatus.TemplateCreated)
            {
                if (verificationResult.score > 0)
                {
                    onCorrect(true);
                }
                else
                {
                    onInvalid(false);
                }
            }
            else
            {
                MessageBox.Show(string.Format("Verification was not finished. Reason: {0}", verificationResult.engineStatus));
            }
        }


        private void loginPassBt_Click(object sender, EventArgs e)
        {
            InfoLabel.ForeColor = Color.White;
            InfoLabel.Text = "Logowanie...";

            SHA256 sha = SHA256.Create();
            string hash = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(rePasswordBox.Text)));
            if (hash == FileManager.ReadPassHash())
                onCorrect(false);
            else
                onInvalid(false);
        }

        private void rePasswordBox_TextChanged_1(object sender, EventArgs e)
        {
            loginPassBt.Enabled = (rePasswordBox.Text.Length > 0);
        }

        private void onCorrect(bool finger)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void onInvalid(bool finger)
        {
            InfoLabel.ForeColor = Color.Red;
            InfoLabel.Text = finger ? "Nie rozpoznano odcisku palca" : "Podano błędne hasło!";
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
