namespace lab4_densi
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
            button1 = new Button();
            txtOut = new RichTextBox();
            txtInfo = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(254, 135);
            button1.Name = "button1";
            button1.Size = new Size(90, 89);
            button1.TabIndex = 0;
            button1.Text = "Взять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(48, 120);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(200, 104);
            txtOut.TabIndex = 1;
            txtOut.Text = "";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(48, 70);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(200, 44);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(48, 32);
            button2.Name = "button2";
            button2.Size = new Size(200, 32);
            button2.TabIndex = 3;
            button2.Text = "Перезаполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 236);
            Controls.Add(button2);
            Controls.Add(txtInfo);
            Controls.Add(txtOut);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox txtOut;
        private RichTextBox txtInfo;
        private Button button2;
    }
}