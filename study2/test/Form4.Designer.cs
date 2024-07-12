namespace study2.test
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Name_Box = new TextBox();
            Name2_Box = new TextBox();
            Mail_Box = new TextBox();
            Lile_Box = new TextBox();
            Save_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 18);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "プロフィール設定";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 105);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "氏名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "氏名(カナ)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 219);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "メールアドレス";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 273);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "趣味";
            // 
            // Name_Box
            // 
            Name_Box.Location = new Point(228, 126);
            Name_Box.Name = "Name_Box";
            Name_Box.Size = new Size(137, 23);
            Name_Box.TabIndex = 5;
            // 
            // Name2_Box
            // 
            Name2_Box.Location = new Point(228, 183);
            Name2_Box.Name = "Name2_Box";
            Name2_Box.Size = new Size(137, 23);
            Name2_Box.TabIndex = 6;
            // 
            // Mail_Box
            // 
            Mail_Box.Location = new Point(228, 245);
            Mail_Box.Name = "Mail_Box";
            Mail_Box.Size = new Size(137, 23);
            Mail_Box.TabIndex = 7;
            // 
            // Lile_Box
            // 
            Lile_Box.Location = new Point(228, 298);
            Lile_Box.Name = "Lile_Box";
            Lile_Box.Size = new Size(137, 23);
            Lile_Box.TabIndex = 8;
            // 
            // Save_Button
            // 
            Save_Button.Location = new Point(339, 363);
            Save_Button.Name = "Save_Button";
            Save_Button.Size = new Size(155, 23);
            Save_Button.TabIndex = 9;
            Save_Button.Text = "登録する";
            Save_Button.UseVisualStyleBackColor = true;
            Save_Button.Click += Save_Button_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save_Button);
            Controls.Add(Lile_Box);
            Controls.Add(Mail_Box);
            Controls.Add(Name2_Box);
            Controls.Add(Name_Box);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "プロフィール";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private TextBox Mail_Box;
        private TextBox Name2_Box;
        private TextBox Name_Box;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Lile_Box;
        private Button Save_Button;
    }
}