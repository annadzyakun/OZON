namespace проба
{
    partial class zaiavki
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zaiavki));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.fio = new System.Windows.Forms.TextBox();
            this.opisanie = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОзаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаподачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.oZONDataSet2 = new проба.OZONDataSet2();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.заявкиTableAdapter2 = new проба.OZONDataSet2TableAdapters.ЗаявкиTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZONDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оформление заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО заявителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дата подачи";
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Техническая поддержка",
            "Отпуск",
            "Замену оборудования",
            "Ремонт помещения"});
            this.cb.Location = new System.Drawing.Point(25, 249);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 24);
            this.cb.TabIndex = 6;
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(25, 299);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(121, 22);
            this.fio.TabIndex = 7;
            // 
            // opisanie
            // 
            this.opisanie.Location = new System.Drawing.Point(25, 357);
            this.opisanie.Name = "opisanie";
            this.opisanie.Size = new System.Drawing.Size(121, 22);
            this.opisanie.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 63);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.button1.Location = new System.Drawing.Point(25, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзаявкиDataGridViewTextBoxColumn,
            this.фИОзаявителяDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.датаподачиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявкиBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(173, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 606);
            this.dataGridView1.TabIndex = 12;
            // 
            // номерзаявкиDataGridViewTextBoxColumn
            // 
            this.номерзаявкиDataGridViewTextBoxColumn.DataPropertyName = "Номер_заявки";
            this.номерзаявкиDataGridViewTextBoxColumn.HeaderText = "Номер_заявки";
            this.номерзаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерзаявкиDataGridViewTextBoxColumn.Name = "номерзаявкиDataGridViewTextBoxColumn";
            this.номерзаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерзаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОзаявителяDataGridViewTextBoxColumn
            // 
            this.фИОзаявителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО_заявителя";
            this.фИОзаявителяDataGridViewTextBoxColumn.HeaderText = "ФИО_заявителя";
            this.фИОзаявителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОзаявителяDataGridViewTextBoxColumn.Name = "фИОзаявителяDataGridViewTextBoxColumn";
            this.фИОзаявителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаподачиDataGridViewTextBoxColumn
            // 
            this.датаподачиDataGridViewTextBoxColumn.DataPropertyName = "Дата_подачи";
            this.датаподачиDataGridViewTextBoxColumn.HeaderText = "Дата_подачи";
            this.датаподачиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаподачиDataGridViewTextBoxColumn.Name = "датаподачиDataGridViewTextBoxColumn";
            this.датаподачиDataGridViewTextBoxColumn.Width = 125;
            // 
            // заявкиBindingSource2
            // 
            this.заявкиBindingSource2.DataMember = "Заявки";
            this.заявкиBindingSource2.DataSource = this.oZONDataSet2;
            // 
            // oZONDataSet2
            // 
            this.oZONDataSet2.DataSetName = "OZONDataSet2";
            this.oZONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(29, 424);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 22);
            this.date.TabIndex = 13;
            // 
            // заявкиTableAdapter2
            // 
            this.заявкиTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.button2.Location = new System.Drawing.Point(25, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(62, 586);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 16);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Назад";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // zaiavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(722, 693);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.opisanie);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "zaiavki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "zaiavki";
            this.Load += new System.EventHandler(this.zaiavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZONDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox opisanie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОзаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаподачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker date;
        private OZONDataSet2 oZONDataSet2;
        private System.Windows.Forms.BindingSource заявкиBindingSource2;
        private OZONDataSet2TableAdapters.ЗаявкиTableAdapter заявкиTableAdapter2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}