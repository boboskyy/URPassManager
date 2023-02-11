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
using URPassManager.core;

namespace URPassManager
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            FileManager.LoadDb();
            ReloadAccounts();
        }

        private void ReloadAccounts()
        {
            AccountView.Rows.Clear();
            foreach(PMEntity account in FileManager.DB)
            {
                AddAccountView(account);
            }
        }

        private void AddAccountView(PMEntity entity)
        {
            string asteriskPass = new string('•', entity.Password.Length);
            if (AccountView.InvokeRequired)
                AccountView.Invoke(new Action<PMEntity>(AddAccountView), entity);
            else
                AccountView.Rows.Add(new object[] { entity.URL, entity.Username, asteriskPass });
            
        }

        private void AccountView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                DataGridViewRow row = AccountView.Rows[e.RowIndex];

                AccountView.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
                row.Selected = true;

                AccountView.Focus();

            }
        }

        private void AccountView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
                metroContextMenu1.Show(AccountView, e.Location);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = AccountView.SelectedRows[0];
            Clipboard.SetText(selectedRow.Cells[1].Value.ToString());
        }

        private void modyfikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileManager.DB.Count < 1)
                return;
            modify();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileManager.DB.Count < 1)
                return;
            DataGridViewRow selectedRow = AccountView.SelectedRows[0];
            if (selectedRow.Index > -1)
            {
                FileManager.DB.RemoveAt(selectedRow.Index);
                FileManager.SaveDb();
                ReloadAccounts();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AccountForm form = new AccountForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                FileManager.DB.Add(new PMEntity(form.URL, form.Username, form.Password));
                FileManager.SaveDb();
                ReloadAccounts();
            }
        }

        private void kopiujHasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = AccountView.SelectedRows[0];
            Clipboard.SetText(FileManager.DB[selectedRow.Index].Password);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (FileManager.DB.Count < 1)
                return;
            DataGridViewRow selectedRow = AccountView.SelectedRows[0];
            if(selectedRow.Index > -1)
            {
                FileManager.DB.RemoveAt(selectedRow.Index);
                FileManager.SaveDb();
                ReloadAccounts();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (FileManager.DB.Count < 1)
                return;
            modify();
        }

        private void modify()
        {
            DataGridViewRow selectedRow = AccountView.SelectedRows[0];
            if (selectedRow.Index > -1)
            {
                AccountForm form = new AccountForm();
                form.URL = selectedRow.Cells[0].Value.ToString();
                form.Username = selectedRow.Cells[1].Value.ToString();
                form.Password = FileManager.DB[selectedRow.Index].Password;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    FileManager.DB.RemoveAt(selectedRow.Index);
                    FileManager.DB.Add(new PMEntity(form.URL, form.Username, form.Password));
                    FileManager.SaveDb();
                    ReloadAccounts();
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
