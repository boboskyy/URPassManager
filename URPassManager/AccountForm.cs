using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URPassManager
{
    public partial class AccountForm : MetroForm
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        public string URL
        {
            get
            {
                return urlBox.Text;
            }
            set
            {
                urlBox.Text = value;
            }
        }

        public string Username
        {
            get
            {
                return usernameBox.Text;
            }
            set
            {
                usernameBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passBox.Text;
            }
            set
            {
                passBox.Text = value;
            }
        }
    }
}
