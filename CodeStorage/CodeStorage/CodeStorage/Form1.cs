using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region MS SQL Server 관련
using System.Data.SqlClient;
//using System.Data;
#endregion

namespace CodeStorage
{
    public partial class Form1 : Form
    {
        // 사이드바 최소, 최대 길이
        private const int SIDEBAR_MAX_WIDTH = 200;
        private const int SIDEBAR_MIN_WIDTH = 50;
        // 타이틀바 포인터
        private Point TitleBar_Point = new Point();
        private int SideBar_state = 0;
        private int SideBar_icon_state = 0;
        // 사이드바 가로 길이
        private int SideBar_width = 200;
        // 로그인 상태 0 --> 비로그인 상태 / 1 --> 로그인 상태
        private int Login_state = 0;
        // zz
        static public string Data_Value = null;

        public Form1()
        {
            InitializeComponent();
        }

        #region 타이틀바 생성
        // 직접 타이틀바를 생성하고 드래그 해서 앱을 옮기는 방법 설정
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            TitleBar_Point = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            // e.Button --> 어떤 마우스 버튼을 누럴ㅆ는지 가져옵니다.
            // if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            if(e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (TitleBar_Point.X -e.X), this.Top - (TitleBar_Point.Y - e.Y));
            }
        }
        #endregion

        #region SideBar Function
        private int SideBar_Resize(int state)
        {
            if(state == 0)
            {
                //LogoLabel.Visible = false;
                //LoginLabel.Visible = false;
                state = 1;
            }
            else if(state == 1)
            {
                //LogoLabel.Visible = true;
                //LoginLabel.Visible = true;
                state = 0;
            }
            if (SideBar_icon_state == 0)
            {
                LogoPhoto.Load(@"C:\Users\한웅재\Desktop\이미지\SideBarOpen(icon-icons.com).png");
                LogoPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                SideBar_icon_state = 1;
            }
            else if (SideBar_icon_state == 1)
            {
                LogoPhoto.Load(@"C:\Users\한웅재\Desktop\이미지\SideBarClose(icon-icons.com).png");
                LogoPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                SideBar_icon_state = 0;
            }
            return state;
        }

        private void SideBar_Timer_Tick(object sender, EventArgs e)
        {
            // 사이드바를 슬라이딩으로 숨김
            if (SideBar_state == 1)
            {
                LogoLabel.Visible = false;
                SettingLabel.Visible = false;
                HelpLabel.Visible = false;
                LoginLabel.Visible = false;
                SideBar_width = SideBar_width - 10;
                if (SideBar_width <= SIDEBAR_MIN_WIDTH)
                {
                    SideBar_Timer.Stop();
                }
            }
            // 사이드바를 슬라이딩으로 보이게함
            else
            {
                SideBar_width = SideBar_width + 10;
                if (SideBar_width >= SIDEBAR_MAX_WIDTH)
                {
                    SideBar_Timer.Stop();
                    LogoLabel.Visible = true;
                    SettingLabel.Visible = true;
                    HelpLabel.Visible = true;
                    LoginLabel.Visible = true;
                }
            }
            SideBar.Width = SideBar_width;
        }
        #endregion

        #region 로고 관련
        private void LogoPanel_Click(object sender, EventArgs e)
        {
            SideBar_state = SideBar_Resize(SideBar_state);
            SideBar_Timer.Start();
        }

        private void LogoLabel_Click(object sender, EventArgs e)
        {
            SideBar_state = SideBar_Resize(SideBar_state);
            SideBar_Timer.Start();
        }

        private void LogoPhoto_Click(object sender, EventArgs e)
        {
            SideBar_state = SideBar_Resize(SideBar_state);
            SideBar_Timer.Start();
        }
        #endregion

        #region 로그인 관련
        private void LoginPhoto_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            if (Login_state == 0)
            {
                LoginFormOpen(LoginForm);
                if(LoginForm.Login_State != string.Empty)
                {
                    Login_state = 1;
                    
                }
            }
            else if(Login_state == 1)
            {
                DialogResult temp = DialogResult.None;
                temp = MessageBox.Show("로그아웃 하시겠습니까??", "YesOrNo", MessageBoxButtons.YesNo);
                if (temp == DialogResult.Yes)
                {
                    Login_state = 0;
                    //label1.Text = DialogResult.Yes.ToString() + " / " + DialogResult.Yes.GetType();
                    label1.Text = "label1";
                    LoginLabel.Text = "Login";
                }
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            if (Login_state == 0)
            {
                LoginFormOpen(LoginForm);
                if (LoginForm.Login_State != string.Empty)
                {
                    Login_state = 1;
                }
            }
            else if (Login_state == 1)
            {
                DialogResult temp = DialogResult.None;
                temp = MessageBox.Show("로그아웃 하시겠습니까??", "Log Out", MessageBoxButtons.YesNo);
                if (temp == DialogResult.Yes)
                {
                    Login_state = 0;
                    //label1.Text = DialogResult.Yes.ToString() + " / " + DialogResult.Yes.GetType();
                    label1.Text = "label1";
                    LoginLabel.Text = "Login";
                }
            }
        }

        private void LoginFormOpen(Login LoginForm)
        {
            //Login LoginForm = new Login();
            LoginForm.StartPosition = FormStartPosition.Manual;
            LoginForm.Location = new Point(this.Location.X + 350, this.Location.Y + 30);
            LoginForm.ShowDialog();
            //label1.Text = LoginForm.Login_State;
            if (LoginForm.Login_State != string.Empty)
            {
                string temp;
                temp = LoginForm.Login_State;
                string[] temp_list = temp.Split('?');
                //label1.Text = temp_list[0] + " / " + temp_list[1];
                label1.Text = Data_Value;
                LoginLabel.Text = temp_list[0];
            }
        }
        #endregion

        #region 셋팅 및 헬프 관련
        private void SettingPhoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구현중.....");
        }

        private void SettingLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구현중.....");
        }

        private void HelpPhoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구현중.....");
        }

        private void HelpLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구현중.....");
        }
        #endregion

        #region 툴팁 관련
        private void LogoPhoto_MouseHover(object sender, EventArgs e)
        {
            SideBarToolTip.SetToolTip(LogoPhoto, "SideBar");
        }
        #endregion

        private void SettingPhoto_MouseHover(object sender, EventArgs e)
        {
            SideBarToolTip.SetToolTip(SettingPhoto, "Setting");
        }

        private void HelpPhoto_MouseHover(object sender, EventArgs e)
        {
            SideBarToolTip.SetToolTip(HelpPhoto, "Help");
        }

        private void LoginPhoto_MouseHover(object sender, EventArgs e)
        {
            SideBarToolTip.SetToolTip(LoginPhoto, "Login");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /*
            // Integrated Security가 true일 경우 윈도우 인증, false일 경우 사용자ID 와 암호 사용하여 인증
            SqlConnection sqlcon = new SqlConnection("Server=.\\SQLEXPRESS;Database=Study;Integrated Security=true;");
            sqlcon.Open();

            string strSql_Select = "select * from student;";
            SqlCommand cmd_Select = new SqlCommand(strSql_Select, sqlcon);
            SqlDataReader rd = cmd_Select.ExecuteReader();
            string str_temp = null;
            while(rd.Read())
            {
                str_temp = str_temp + rd.GetString(0) + " / " + rd.GetInt32(1) + " / " + rd.GetDouble(2) +  " / " + rd.GetString(3) + "\n";

            }
            label1.Text = str_temp;

            rd.Close();
            sqlcon.Close();
            */
        }
    }
}
