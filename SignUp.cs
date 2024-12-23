
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

             string username = txtUsername.Text;
              string email = txtEmail.Text;
               string password = m.Text; 
                string confirmPassword = m2.Text; 


                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
              string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
             {
               MessageBox.Show("يرجى ملء جميع الحقول.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
               }


                 if (password != confirmPassword)
                 {
               MessageBox.Show("كلمتا المرور غير متطابقتين.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return;
                               }


                    MessageBox.Show("تم إنشاء الحساب بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
 


        }

    }
}















