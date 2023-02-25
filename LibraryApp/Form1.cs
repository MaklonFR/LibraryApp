using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            BooksForm bf = new BooksForm();
            bf.MdiParent = this;
            bf.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            UsersForm uf = new UsersForm();
            uf.MdiParent = this;
            uf.Show();
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            BorrowForm bof = new BorrowForm();
            bof.MdiParent = this;
            bof.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ReturnForm rf = new ReturnForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            AboutForm af = new AboutForm();
            af.MdiParent = this;
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            BooksForm bf = new BooksForm();
            bf.MdiParent = this;
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            UsersForm uf = new UsersForm();
            uf.MdiParent = this;
            uf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            BorrowForm bof = new BorrowForm();
            bof.MdiParent = this;
            bof.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            ReturnForm rf = new ReturnForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            AboutForm af = new AboutForm();
            af.MdiParent = this;
            af.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
