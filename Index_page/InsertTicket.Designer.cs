namespace Index_page
{
    partial class InsertTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertTicket));
            txtform = new TextBox();
            txtto = new TextBox();
            comboBox1 = new ComboBox();
            Insertbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtrouit = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtform
            // 
            txtform.Location = new Point(217, 158);
            txtform.Name = "txtform";
            txtform.Size = new Size(151, 27);
            txtform.TabIndex = 0;
            // 
            // txtto
            // 
            txtto.Location = new Point(217, 209);
            txtto.Name = "txtto";
            txtto.Size = new Size(151, 27);
            txtto.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AC_BERTH", "AC_SEAT", "NORMAL_BERTH", "NORMAL_SEAT" });
            comboBox1.Location = new Point(217, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = SystemColors.MenuHighlight;
            Insertbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Insertbtn.ForeColor = SystemColors.HighlightText;
            Insertbtn.Location = new Point(28, 416);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(151, 51);
            Insertbtn.TabIndex = 3;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 161);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "FROM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 212);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 5;
            label2.Text = "TO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 271);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "SEATS";
            // 
            // button1
            // 
            button1.Location = new Point(1, -1);
            button1.Name = "button1";
            button1.Size = new Size(119, 46);
            button1.TabIndex = 7;
            button1.Text = "◁ Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(228, 416);
            button2.Name = "button2";
            button2.Size = new Size(151, 51);
            button2.TabIndex = 8;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(444, 416);
            button3.Name = "button3";
            button3.Size = new Size(151, 51);
            button3.TabIndex = 9;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtrouit
            // 
            txtrouit.Location = new Point(217, 105);
            txtrouit.Name = "txtrouit";
            txtrouit.Size = new Size(151, 27);
            txtrouit.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 108);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 4;
            label4.Text = "Rouit ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(444, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(544, 267);
            dataGridView1.TabIndex = 10;
            // 
            // InsertTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1023, 564);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Insertbtn);
            Controls.Add(comboBox1);
            Controls.Add(txtto);
            Controls.Add(txtrouit);
            Controls.Add(txtform);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InsertTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertTicket";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtform;
        private TextBox txtto;
        private ComboBox comboBox1;
        private Button Insertbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtrouit;
        private Label label4;
        private DataGridView dataGridView1;
    }
}