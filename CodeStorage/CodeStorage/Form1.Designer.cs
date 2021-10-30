
namespace CodeStorage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.SideBarMainPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPhoto = new System.Windows.Forms.PictureBox();
            this.SettingHelpPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SettingPhoto = new System.Windows.Forms.PictureBox();
            this.HelpPhoto = new System.Windows.Forms.PictureBox();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.LoginPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SideBar_Timer = new System.Windows.Forms.Timer(this.components);
            this.SideBarToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SideBar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPhoto)).BeginInit();
            this.SettingHelpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(884, 0);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Visible = false;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(70)))), ((int)(((byte)(159)))));
            this.SideBar.Controls.Add(this.SideBarMainPanel);
            this.SideBar.Controls.Add(this.LogoPanel);
            this.SideBar.Controls.Add(this.SettingHelpPanel);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 511);
            this.SideBar.TabIndex = 2;
            // 
            // SideBarMainPanel
            // 
            this.SideBarMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
            this.SideBarMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBarMainPanel.Location = new System.Drawing.Point(0, 50);
            this.SideBarMainPanel.Name = "SideBarMainPanel";
            this.SideBarMainPanel.Size = new System.Drawing.Size(200, 311);
            this.SideBarMainPanel.TabIndex = 3;
            // 
            // LogoPanel
            // 
            this.LogoPanel.ColumnCount = 2;
            this.LogoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LogoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LogoPanel.Controls.Add(this.LogoLabel, 1, 0);
            this.LogoPanel.Controls.Add(this.LogoPhoto, 0, 0);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.RowCount = 1;
            this.LogoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LogoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.LogoPanel.Size = new System.Drawing.Size(200, 50);
            this.LogoPanel.TabIndex = 4;
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoLabel.Font = new System.Drawing.Font("Ink Free", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(53, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(144, 50);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Code Storage";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogoLabel.Click += new System.EventHandler(this.LogoLabel_Click);
            // 
            // LogoPhoto
            // 
            this.LogoPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPhoto.Image = ((System.Drawing.Image)(resources.GetObject("LogoPhoto.Image")));
            this.LogoPhoto.Location = new System.Drawing.Point(2, 2);
            this.LogoPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.LogoPhoto.Name = "LogoPhoto";
            this.LogoPhoto.Size = new System.Drawing.Size(46, 46);
            this.LogoPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPhoto.TabIndex = 1;
            this.LogoPhoto.TabStop = false;
            this.LogoPhoto.Click += new System.EventHandler(this.LogoPhoto_Click);
            this.LogoPhoto.MouseHover += new System.EventHandler(this.LogoPhoto_MouseHover);
            // 
            // SettingHelpPanel
            // 
            this.SettingHelpPanel.ColumnCount = 2;
            this.SettingHelpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SettingHelpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SettingHelpPanel.Controls.Add(this.LoginLabel, 1, 2);
            this.SettingHelpPanel.Controls.Add(this.SettingPhoto, 0, 0);
            this.SettingHelpPanel.Controls.Add(this.HelpPhoto, 0, 1);
            this.SettingHelpPanel.Controls.Add(this.SettingLabel, 1, 0);
            this.SettingHelpPanel.Controls.Add(this.HelpLabel, 1, 1);
            this.SettingHelpPanel.Controls.Add(this.LoginPhoto, 0, 2);
            this.SettingHelpPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingHelpPanel.Location = new System.Drawing.Point(0, 361);
            this.SettingHelpPanel.Name = "SettingHelpPanel";
            this.SettingHelpPanel.RowCount = 3;
            this.SettingHelpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SettingHelpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SettingHelpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SettingHelpPanel.Size = new System.Drawing.Size(200, 150);
            this.SettingHelpPanel.TabIndex = 2;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(53, 100);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(144, 50);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // SettingPhoto
            // 
            this.SettingPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingPhoto.Image = ((System.Drawing.Image)(resources.GetObject("SettingPhoto.Image")));
            this.SettingPhoto.Location = new System.Drawing.Point(2, 2);
            this.SettingPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.SettingPhoto.Name = "SettingPhoto";
            this.SettingPhoto.Size = new System.Drawing.Size(46, 46);
            this.SettingPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingPhoto.TabIndex = 0;
            this.SettingPhoto.TabStop = false;
            this.SettingPhoto.Click += new System.EventHandler(this.SettingPhoto_Click);
            this.SettingPhoto.MouseHover += new System.EventHandler(this.SettingPhoto_MouseHover);
            // 
            // HelpPhoto
            // 
            this.HelpPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.HelpPhoto.Image = ((System.Drawing.Image)(resources.GetObject("HelpPhoto.Image")));
            this.HelpPhoto.Location = new System.Drawing.Point(2, 52);
            this.HelpPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.HelpPhoto.Name = "HelpPhoto";
            this.HelpPhoto.Size = new System.Drawing.Size(46, 46);
            this.HelpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpPhoto.TabIndex = 1;
            this.HelpPhoto.TabStop = false;
            this.HelpPhoto.Click += new System.EventHandler(this.HelpPhoto_Click);
            this.HelpPhoto.MouseHover += new System.EventHandler(this.HelpPhoto_MouseHover);
            // 
            // SettingLabel
            // 
            this.SettingLabel.AutoSize = true;
            this.SettingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingLabel.Location = new System.Drawing.Point(53, 0);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(144, 50);
            this.SettingLabel.TabIndex = 2;
            this.SettingLabel.Text = "Setting";
            this.SettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingLabel.Click += new System.EventHandler(this.SettingLabel_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpLabel.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpLabel.Location = new System.Drawing.Point(53, 50);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(144, 50);
            this.HelpLabel.TabIndex = 3;
            this.HelpLabel.Text = "Help";
            this.HelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelpLabel.Click += new System.EventHandler(this.HelpLabel_Click);
            // 
            // LoginPhoto
            // 
            this.LoginPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPhoto.Image = ((System.Drawing.Image)(resources.GetObject("LoginPhoto.Image")));
            this.LoginPhoto.Location = new System.Drawing.Point(2, 102);
            this.LoginPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.LoginPhoto.Name = "LoginPhoto";
            this.LoginPhoto.Size = new System.Drawing.Size(46, 46);
            this.LoginPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPhoto.TabIndex = 0;
            this.LoginPhoto.TabStop = false;
            this.LoginPhoto.Click += new System.EventHandler(this.LoginPhoto_Click);
            this.LoginPhoto.MouseHover += new System.EventHandler(this.LoginPhoto_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // SideBar_Timer
            // 
            this.SideBar_Timer.Interval = 10;
            this.SideBar_Timer.Tick += new System.EventHandler(this.SideBar_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.TitleBar);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "Code Storage";
            this.SideBar.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPhoto)).EndInit();
            this.SettingHelpPanel.ResumeLayout(false);
            this.SettingHelpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPhoto;
        private System.Windows.Forms.PictureBox LoginPhoto;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SideBarMainPanel;
        private System.Windows.Forms.TableLayoutPanel SettingHelpPanel;
        private System.Windows.Forms.PictureBox SettingPhoto;
        private System.Windows.Forms.PictureBox HelpPhoto;
        private System.Windows.Forms.Label SettingLabel;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.TableLayoutPanel LogoPanel;
        private System.Windows.Forms.Timer SideBar_Timer;
        private System.Windows.Forms.ToolTip SideBarToolTip;
    }
}

