namespace Index_page
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCurpas = new TextBox();
            txtNewPas = new TextBox();
            txtConPass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 72);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 142);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Current Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 198);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "New Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 278);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 4;
            label5.Text = "Retype New Password";
            // 
            // txtCurpas
            // 
            txtCurpas.Location = new Point(338, 142);
            txtCurpas.Name = "txtCurpas";
            txtCurpas.Size = new Size(182, 27);
            txtCurpas.TabIndex = 5;
            // 
            // txtNewPas
            // 
            txtNewPas.Location = new Point(338, 191);
            txtNewPas.Name = "txtNewPas";
            txtNewPas.Size = new Size(182, 27);
            txtNewPas.TabIndex = 6;
            txtNewPas.UseSystemPasswordChar = true;
            // 
            // txtConPass
            // 
            txtConPass.Location = new Point(338, 275);
            txtConPass.Name = "txtConPass";
            txtConPass.Size = new Size(182, 27);
            txtConPass.TabIndex = 7;
            txtConPass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(372, 329);
            button1.Name = "button1";
            button1.Size = new Size(111, 41);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(-2, -2);
            button2.Name = "button2";
            button2.Size = new Size(102, 38);
            button2.TabIndex = 9;
            button2.Text = "◁ Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(338, 224);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtConPass);
            Controls.Add(txtNewPas);
            Controls.Add(txtCurpas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCurpas;
        private TextBox txtNewPas;
        private TextBox txtConPass;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
    }
}