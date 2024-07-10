namespace study2.Forms
{
    partial class UserIC
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
            TXT_Name = new TextBox();
            TXT_Pass = new TextBox();
            保存 = new Button();
            name = new Label();
            Birthday = new Label();
            Password = new Label();
            TXT_Birth = new DateTimePicker();
            SuspendLayout();
            // 
            // TXT_Name
            // 
            TXT_Name.Location = new Point(174, 52);
            TXT_Name.Name = "TXT_Name";
            TXT_Name.Size = new Size(206, 23);
            TXT_Name.TabIndex = 0;
            // 
            // TXT_Pass
            // 
            TXT_Pass.Location = new Point(174, 166);
            TXT_Pass.Name = "TXT_Pass";
            TXT_Pass.Size = new Size(206, 23);
            TXT_Pass.TabIndex = 2;
            // 
            // 保存
            // 
            保存.Location = new Point(535, 166);
            保存.Name = "保存";
            保存.Size = new Size(113, 23);
            保存.TabIndex = 3;
            保存.Text = "保存";
            保存.UseVisualStyleBackColor = true;
            保存.Click += 保存_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(112, 55);
            name.Name = "name";
            name.Size = new Size(31, 15);
            name.TabIndex = 4;
            name.Text = "名前";
            // 
            // Birthday
            // 
            Birthday.AutoSize = true;
            Birthday.Location = new Point(112, 110);
            Birthday.Name = "Birthday";
            Birthday.Size = new Size(43, 15);
            Birthday.TabIndex = 5;
            Birthday.Text = "誕生日";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(112, 170);
            Password.Name = "Password";
            Password.Size = new Size(30, 15);
            Password.TabIndex = 6;
            Password.Text = "Pass";
            // 
            // TXT_Birth
            // 
            TXT_Birth.Location = new Point(174, 110);
            TXT_Birth.Name = "TXT_Birth";
            TXT_Birth.Size = new Size(200, 23);
            TXT_Birth.TabIndex = 7;
            TXT_Birth.Value = new DateTime(2024, 7, 8, 21, 37, 32, 0);
            // 
            // UserIC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TXT_Birth);
            Controls.Add(Password);
            Controls.Add(Birthday);
            Controls.Add(name);
            Controls.Add(保存);
            Controls.Add(TXT_Pass);
            Controls.Add(TXT_Name);
            Name = "UserIC";
            Text = "プロフィール";
            Load += UserIC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_Name;
        private TextBox TXT_Pass;
        private Button 保存;
        private Label name;
        private Label Birthday;
        private Label Password;
        private DateTimePicker TXT_Birth;
    }
}