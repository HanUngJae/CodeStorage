using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeStorage
{

    public partial class SignUp : Form
    {

        private int Password_state = 0;
        private int CheckPassword_state = 0;

        public SignUp()
        {
            InitializeComponent();
            InformationLabel.Text = "영문 및 숫자로만 구성\n아이디 최대 20글자\n비밀번호 최대 12글자";
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            if(Password_state == 0)
            {
                PasswordButton.Text = "보임";
                PasswordTextBox.PasswordChar = default(char);
                Password_state = 1;
            }
            else if(Password_state == 1)
            {
                PasswordButton.Text = "숨김";
                PasswordTextBox.PasswordChar = '*';
                Password_state = 0;
            }
        }

        private void CheckPasswordButton_Click(object sender, EventArgs e)
        {
            if (CheckPassword_state == 0)
            {
                CheckPasswordButton.Text = "보임";
                CheckPasswordTextBox.PasswordChar = default(char);
                CheckPassword_state = 1;
            }
            else if (CheckPassword_state == 1)
            {
                CheckPasswordButton.Text = "숨김";
                CheckPasswordTextBox.PasswordChar = '*';
                CheckPassword_state = 0;
            }
        }
    }
}
