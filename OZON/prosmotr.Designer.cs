namespace OZON
{
    partial class prosmotr
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
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox3 = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(333, 9);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 15;
            label5.Text = "Заявки";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(173, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(537, 615);
            dataGridView1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 448);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 19;
            label2.Text = "Ответ на заявку ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 375);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 18;
            label1.Text = "Статус";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Техническая поддержка", "Отпуск", "Замена оборудования", " Ремонт помещения" });
            comboBox1.Location = new Point(12, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 28);
            comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 471);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumAquamarine;
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(21, 544);
            button1.Name = "button1";
            button1.Size = new Size(116, 38);
            button1.TabIndex = 20;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(9, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 21;
            label3.Text = "Поиск ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(9, 41);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 23;
            label4.Text = "Статус";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Техническая поддержка", "Отпуск", "Замена оборудования", " Ремонт помещения" });
            comboBox2.Location = new Point(9, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(106, 28);
            comboBox2.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(9, 95);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 25;
            label6.Text = "Тип заявки";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Техническая поддержка", "Отпуск", "Замена оборудования", " Ремонт помещения" });
            comboBox3.Location = new Point(9, 118);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(106, 28);
            comboBox3.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox3);
            panel1.Location = new Point(12, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 158);
            panel1.TabIndex = 26;
            // 
            // prosmotr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(722, 693);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "prosmotr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prosmotr";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox3;
        private Panel panel1;
    }
}