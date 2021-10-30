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
    public partial class Login : Form
    {
        // IDPW를 초기화 하지 않으면 오류가 일어난다.
        private string IDPW = "";
        public string Login_State
        {
            get { return this.IDPW; }
            set { this.IDPW = value; }
        }
        
        public Login()
        {
            InitializeComponent();
        }

        private void StringSplit()
        {
            string temp = IDPW;
            string[] temp_list = temp.Split('?');
            IDTextBox.Text = temp_list[0];
            PasswordTextBox.Text = temp_list[1];
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;
            string pw = PasswordTextBox.Text;
            if(id == string.Empty || pw == string.Empty)
            {
                MessageBox.Show("아이디 또는 패스워드를 정확히 입력해주세요.");
            }
            else if(id != string.Empty && pw != string.Empty)
            {
                if(id == "admin" && pw == "admin")
                {
                    string idpw = id + "?" + pw;
                    Login_State = idpw;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("아이디 또는 패스워드를 정확히 입력해주세요.");
                }
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp SignUpForm = new SignUp();
            SignUpForm.StartPosition = FormStartPosition.Manual;
            SignUpForm.Location = new Point(this.Location.X - 50, this.Location.Y - 10);
            SignUpForm.ShowDialog();
        }
    }
}
