namespace study2.Practice
{
    partial class Practice1
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
            TNT_btn2 = new Button();
            TNT_btn = new Button();
            TNT_btn3 = new Button();
            TNT_btn4 = new Button();
            SuspendLayout();
            // 
            // TNT_btn2
            // 
            TNT_btn2.Location = new Point(33, 62);
            TNT_btn2.Name = "TNT_btn2";
            TNT_btn2.Size = new Size(75, 23);
            TNT_btn2.TabIndex = 1;
            TNT_btn2.Text = "ボタン２";
            TNT_btn2.UseVisualStyleBackColor = true;
            TNT_btn2.Click += button2_Click;
            // 
            // TNT_btn
            // 
            TNT_btn.Location = new Point(33, 21);
            TNT_btn.Name = "TNT_btn";
            TNT_btn.Size = new Size(75, 23);
            TNT_btn.TabIndex = 0;
            TNT_btn.Text = "ボタン";
            TNT_btn.UseVisualStyleBackColor = true;
            TNT_btn.Click += button1_Click;
            // 
            // TNT_btn3
            // 
            TNT_btn3.Location = new Point(33, 103);
            TNT_btn3.Name = "TNT_btn3";
            TNT_btn3.Size = new Size(75, 23);
            TNT_btn3.TabIndex = 2;
            TNT_btn3.Text = "ボタン３";
            TNT_btn3.UseVisualStyleBackColor = true;
            TNT_btn3.Click += TNT_btn3_Click;
            // 
            // TNT_btn4
            // 
            TNT_btn4.Location = new Point(33, 145);
            TNT_btn4.Name = "TNT_btn4";
            TNT_btn4.Size = new Size(75, 23);
            TNT_btn4.TabIndex = 3;
            TNT_btn4.Text = "ボタン4";
            TNT_btn4.UseVisualStyleBackColor = true;
            TNT_btn4.Click += TNT_btn4_Click;
            // 
            // Practice1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TNT_btn4);
            Controls.Add(TNT_btn3);
            Controls.Add(TNT_btn2);
            Controls.Add(TNT_btn);
            Name = "Practice1";
            ResumeLayout(false);
        }

        #endregion

        private Button TNT_btn2;
        private Button TNT_btn;
        private Button TNT_btn3;
        private Button TNT_btn4;
    }
}