using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR {
    public partial class Admin_form : Form {
        public Admin_form() {
            InitializeComponent();
        }

        private void Admin_form_Load(object sender, EventArgs e) {
            label1.Text = User.Login;
            label2.Text = User.Role;
        }

        private void Admin_form_FormClosed(object sender, FormClosedEventArgs e) {

        }
    }
}
