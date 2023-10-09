using MESysWin.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.GUI
{
    public partial class ClientCardForm : Form
    {
        public ClientCardForm(User user)
        {
            InitializeComponent();

            personname = user;

            FullNametext.Text = personname.Login;

        }
        private User personname;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
