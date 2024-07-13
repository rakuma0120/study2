namespace study2.Practice
{
    partial class Practice2
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
            label1 = new Label();
            label2 = new Label();
            ID_BOX = new TextBox();
            Pass_BOX = new TextBox();
            Pass_Eye = new Button();
            Save_BTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "パスワード";
            // 
            // ID_BOX
            // 
            ID_BOX.Location = new Point(66, 30);
            ID_BOX.Name = "ID_BOX";
            ID_BOX.Size = new Size(233, 23);
            ID_BOX.TabIndex = 2;
            // 
            // Pass_BOX
            // 
            Pass_BOX.Location = new Point(66, 74);
            Pass_BOX.Name = "Pass_BOX";
            Pass_BOX.PasswordChar = '●';
            Pass_BOX.Size = new Size(233, 23);
            Pass_BOX.TabIndex = 3;
            // 
            // Pass_Eye
            // 
            Pass_Eye.Location = new Point(314, 74);
            Pass_Eye.Name = "Pass_Eye";
            Pass_Eye.Size = new Size(20, 23);
            Pass_Eye.TabIndex = 4;
            Pass_Eye.Text = "👁";
            Pass_Eye.UseVisualStyleBackColor = true;
            Pass_Eye.Click += Pass_Eye_Click;
            // 
            // Save_BTN
            // 
            Save_BTN.Location = new Point(579, 116);
            Save_BTN.Name = "Save_BTN";
            Save_BTN.Size = new Size(75, 23);
            Save_BTN.TabIndex = 5;
            Save_BTN.Text = "登録";
            Save_BTN.UseVisualStyleBackColor = true;
            Save_BTN.Click += Save_BTN_Click;
            // 
            // Practice2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Save_BTN);
            Controls.Add(Pass_Eye);
            Controls.Add(Pass_BOX);
            Controls.Add(ID_BOX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Practice2";
            Text = "Practice2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ID_BOX;
        private TextBox Pass_BOX;
        private Button Pass_Eye;
        private Button Save_BTN;
    }
}