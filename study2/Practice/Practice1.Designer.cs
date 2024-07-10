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
            TNT_btn = new Button();
            button2 = new Button();
            SuspendLayout();
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
            // button2
            // 
            button2.Location = new Point(33, 62);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "ボタン２";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Practice1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(TNT_btn);
            Name = "Practice1";
            ResumeLayout(false);
        }

        #endregion

        private Button TNT_btn;
        private Button button2;
    }
}