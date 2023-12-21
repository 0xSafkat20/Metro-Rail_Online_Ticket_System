namespace Index_page
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            txtemail = new TextBox();
            button5 = new Button();
            txtpass = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 735);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(634, 57);
            label1.Name = "label1";
            label1.Size = new Size(127, 46);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(648, 384);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 2;
            label2.Text = "or Connect with Social Media";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(744, 573);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 3;
            label3.Text = "or,";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(634, 309);
            button1.Name = "button1";
            button1.Size = new Size(246, 42);
            button1.TabIndex = 4;
            button1.Text = "Log In ➧";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(634, 437);
            button2.Name = "button2";
            button2.Size = new Size(246, 42);
            button2.TabIndex = 5;
            button2.Text = "    Facebook";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.GhostWhite;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(634, 509);
            button3.Name = "button3";
            button3.Size = new Size(246, 42);
            button3.TabIndex = 6;
            button3.Text = "Gmail";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(634, 621);
            button4.Name = "button4";
            button4.Size = new Size(246, 42);
            button4.TabIndex = 7;
            button4.Text = "      Create an Account";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(638, 257);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = SystemColors.ControlDarkDark;
            txtemail.Location = new Point(634, 145);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(246, 30);
            txtemail.TabIndex = 9;
            txtemail.Text = "Enter Your Email";
            txtemail.TextChanged += txtemail_TextChanged;
            txtemail.Enter += textBox1_Enter;
            txtemail.Leave += txtemail_Leave;
            // 
            // button5
            // 
            button5.ForeColor = Color.Red;
            button5.Location = new Point(900, -1);
            button5.Name = "button5";
            button5.Size = new Size(82, 33);
            button5.TabIndex = 11;
            button5.Text = "✕";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.ForeColor = SystemColors.ControlDarkDark;
            txtpass.Location = new Point(634, 203);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(246, 30);
            txtpass.TabIndex = 12;
            txtpass.Text = "Enter Your Password";
            txtpass.Enter += textBox1_Enter_1;
            txtpass.Leave += txtpass_Leave;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HighlightText;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(536, -2);
            button6.Name = "button6";
            button6.Size = new Size(94, 37);
            button6.TabIndex = 13;
            button6.Text = "< Back";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 720);
            Controls.Add(button6);
            Controls.Add(txtpass);
            Controls.Add(button5);
            Controls.Add(txtemail);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private TextBox txtemail;
        private Button button5;
        private TextBox txtpass;
        private Button button6;
    }
}