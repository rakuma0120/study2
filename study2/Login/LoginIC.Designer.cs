namespace study2.Login
{
    partial class LoginIC
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
            TXT_ID = new TextBox();
            TXT_PW = new TextBox();
            LB_ID = new Label();
            LB_PW = new Label();
            BTN_LOGIN = new Button();
            BTN_Eye = new Button();
            SuspendLayout();
            // 
            // TXT_ID
            // 
            TXT_ID.Location = new Point(74, 12);
            TXT_ID.Name = "TXT_ID";
            TXT_ID.Size = new Size(206, 23);
            TXT_ID.TabIndex = 0;
            TXT_ID.TextChanged += TXT_ID_TextChanged;
            // 
            // TXT_PW
            // 
            TXT_PW.Location = new Point(74, 41);
            TXT_PW.Name = "TXT_PW";
            TXT_PW.PasswordChar = '*';
            TXT_PW.Size = new Size(206, 23);
            TXT_PW.TabIndex = 2;
            // 
            // LB_ID
            // 
            LB_ID.AutoSize = true;
            LB_ID.Location = new Point(30, 15);
            LB_ID.Name = "LB_ID";
            LB_ID.Size = new Size(18, 15);
            LB_ID.TabIndex = 3;
            LB_ID.Text = "ID";
            // 
            // LB_PW
            // 
            LB_PW.AutoSize = true;
            LB_PW.Location = new Point(30, 44);
            LB_PW.Name = "LB_PW";
            LB_PW.Size = new Size(25, 15);
            LB_PW.TabIndex = 4;
            LB_PW.Text = "PW";
            // 
            // BTN_LOGIN
            // 
            BTN_LOGIN.Location = new Point(140, 80);
            BTN_LOGIN.Name = "BTN_LOGIN";
            BTN_LOGIN.Size = new Size(75, 23);
            BTN_LOGIN.TabIndex = 5;
            BTN_LOGIN.Text = "LOGIN";
            BTN_LOGIN.UseVisualStyleBackColor = true;
            BTN_LOGIN.Click += BTN_LOGIN_Click;
            // 
            // BTN_Eye
            // 
            BTN_Eye.Location = new Point(286, 41);
            BTN_Eye.Name = "BTN_Eye";
            BTN_Eye.Size = new Size(25, 23);
            BTN_Eye.TabIndex = 6;
            BTN_Eye.Text = "\r\n";
            BTN_Eye.UseVisualStyleBackColor = true;
            BTN_Eye.Click += BTN_Eye_Click;
            // 
            // LoginIC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 130);
            Controls.Add(BTN_Eye);
            Controls.Add(BTN_LOGIN);
            Controls.Add(LB_PW);
            Controls.Add(LB_ID);
            Controls.Add(TXT_PW);
            Controls.Add(TXT_ID);
            MaximizeBox = false;
            Name = "LoginIC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_ID;
        private TextBox TXT_PW;
        private Label LB_ID;
        private Label LB_PW;
        private Button BTN_LOGIN;
        private Button BTN_Eye;
    }
}