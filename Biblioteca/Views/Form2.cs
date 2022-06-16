using Biblioteca.Views;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBook_Click(object sender, EventArgs e)
        {
            Book bookfrm = new Book();

            bookfrm.ShowDialog();
            
        }

        private void ButtonGender_Click(object sender, EventArgs e)
        {
            Gender genderfrm = new Gender();

            genderfrm.ShowDialog();

        }

        private void simpleAuthor_Click(object sender, EventArgs e)
        {
            Author authorfrm = new Author();

            authorfrm.ShowDialog();

        }
    }
}
