
namespace CodeStorage
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.BlankPanel = new System.Windows.Forms.Panel();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.InformationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.CheckPasswordLabel = new System.Windows.Forms.Label();
            this.CheckPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordButton = new System.Windows.Forms.Button();
            this.CheckPasswordButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.BlankPanel.SuspendLayout();
            this.InformationPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ButtonPanel);
            this.MainPanel.Controls.Add(this.BlankPanel);
            this.MainPanel.Controls.Add(this.InformationPanel);
            this.MainPanel.Controls.Add(this.LogoPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(284, 461);
            this.MainPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.ColumnCount = 3;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.Controls.Add(this.SignUpButton, 1, 0);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 300);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 1;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.ButtonPanel.Size = new System.Drawing.Size(284, 50);
            this.ButtonPanel.TabIndex = 3;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpButton.Location = new System.Drawing.Point(59, 3);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(164, 44);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.Text = "가입하기";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // BlankPanel
            // 
            this.BlankPanel.Controls.Add(this.InformationLabel);
            this.BlankPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlankPanel.Location = new System.Drawing.Point(0, 250);
            this.BlankPanel.Name = "BlankPanel";
            this.BlankPanel.Size = new System.Drawing.Size(284, 50);
            this.BlankPanel.TabIndex = 2;
            // 
            // InformationLabel
            // 
            this.InformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InformationLabel.Location = new System.Drawing.Point(0, 0);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(284, 50);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "label1";
            this.InformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationPanel
            // 
            this.InformationPanel.ColumnCount = 3;
            this.InformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.InformationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.InformationPanel.Controls.Add(this.IDLabel, 1, 0);
            this.InformationPanel.Controls.Add(this.PasswordLabel, 1, 2);
            this.InformationPanel.Controls.Add(this.IDTextBox, 1, 1);
            this.InformationPanel.Controls.Add(this.PasswordTextBox, 1, 3);
            this.InformationPanel.Controls.Add(this.CheckPasswordLabel, 1, 4);
            this.InformationPanel.Controls.Add(this.CheckPasswordTextBox, 1, 5);
            this.InformationPanel.Controls.Add(this.PasswordButton, 2, 3);
            this.InformationPanel.Controls.Add(this.CheckPasswordButton, 2, 5);
            this.InformationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationPanel.Location = new System.Drawing.Point(0, 100);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.RowCount = 6;
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InformationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.InformationPanel.Size = new System.Drawing.Size(284, 150);
            this.InformationPanel.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IDLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(74, 1);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(136, 19);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "아이디";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PasswordLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(74, 51);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(136, 19);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "패스워드";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDTextBox.Location = new System.Drawing.Point(74, 24);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.IDTextBox.MaxLength = 200;
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(136, 23);
            this.IDTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Location = new System.Drawing.Point(74, 74);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.PasswordTextBox.MaxLength = 12;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(136, 23);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // CheckPasswordLabel
            // 
            this.CheckPasswordLabel.AutoSize = true;
            this.CheckPasswordLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckPasswordLabel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckPasswordLabel.Location = new System.Drawing.Point(74, 101);
            this.CheckPasswordLabel.Name = "CheckPasswordLabel";
            this.CheckPasswordLabel.Size = new System.Drawing.Size(136, 19);
            this.CheckPasswordLabel.TabIndex = 4;
            this.CheckPasswordLabel.Text = "패스워드 확인";
            // 
            // CheckPasswordTextBox
            // 
            this.CheckPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckPasswordTextBox.Location = new System.Drawing.Point(74, 123);
            this.CheckPasswordTextBox.MaxLength = 12;
            this.CheckPasswordTextBox.Name = "CheckPasswordTextBox";
            this.CheckPasswordTextBox.PasswordChar = '*';
            this.CheckPasswordTextBox.Size = new System.Drawing.Size(136, 23);
            this.CheckPasswordTextBox.TabIndex = 5;
            // 
            // PasswordButton
            // 
            this.PasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordButton.Location = new System.Drawing.Point(216, 73);
            this.PasswordButton.Name = "PasswordButton";
            this.PasswordButton.Size = new System.Drawing.Size(65, 24);
            this.PasswordButton.TabIndex = 6;
            this.PasswordButton.Text = "숨김";
            this.PasswordButton.UseVisualStyleBackColor = true;
            this.PasswordButton.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // CheckPasswordButton
            // 
            this.CheckPasswordButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckPasswordButton.Location = new System.Drawing.Point(216, 123);
            this.CheckPasswordButton.Name = "CheckPasswordButton";
            this.CheckPasswordButton.Size = new System.Drawing.Size(65, 24);
            this.CheckPasswordButton.TabIndex = 7;
            this.CheckPasswordButton.Text = "숨김";
            this.CheckPasswordButton.UseVisualStyleBackColor = true;
            this.CheckPasswordButton.Click += new System.EventHandler(this.CheckPasswordButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.LogoLabel);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(284, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // LogoLabel
            // 
            this.LogoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoLabel.Font = new System.Drawing.Font("Ink Free", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LogoLabel.Location = new System.Drawing.Point(0, 0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(284, 100);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Code Storage";
            this.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sign Up";
            this.MainPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.BlankPanel.ResumeLayout(false);
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel InformationPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel BlankPanel;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label CheckPasswordLabel;
        private System.Windows.Forms.TextBox CheckPasswordTextBox;
        private System.Windows.Forms.Button PasswordButton;
        private System.Windows.Forms.Button CheckPasswordButton;
        private System.Windows.Forms.Label InformationLabel;
    }
}