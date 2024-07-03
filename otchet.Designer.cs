namespace проба
{
    partial class otchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otchet));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОзаявителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типзаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаподачиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ответDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oZONDataSet4 = new проба.OZONDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.заявкиTableAdapter = new проба.OZONDataSet4TableAdapters.ЗаявкиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZONDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.button2.Location = new System.Drawing.Point(24, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзаявкиDataGridViewTextBoxColumn,
            this.фИОзаявителяDataGridViewTextBoxColumn,
            this.типзаявкиDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.датаподачиDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.ответDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(169, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 617);
            this.dataGridView1.TabIndex = 16;
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
            // типзаявкиDataGridViewTextBoxColumn
            // 
            this.типзаявкиDataGridViewTextBoxColumn.DataPropertyName = "Тип_заявки";
            this.типзаявкиDataGridViewTextBoxColumn.HeaderText = "Тип_заявки";
            this.типзаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типзаявкиDataGridViewTextBoxColumn.Name = "типзаявкиDataGridViewTextBoxColumn";
            this.типзаявкиDataGridViewTextBoxColumn.Width = 125;
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
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // ответDataGridViewTextBoxColumn
            // 
            this.ответDataGridViewTextBoxColumn.DataPropertyName = "Ответ";
            this.ответDataGridViewTextBoxColumn.HeaderText = "Ответ";
            this.ответDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ответDataGridViewTextBoxColumn.Name = "ответDataGridViewTextBoxColumn";
            this.ответDataGridViewTextBoxColumn.Width = 125;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.oZONDataSet4;
            // 
            // oZONDataSet4
            // 
            this.oZONDataSet4.DataSetName = "OZONDataSet4";
            this.oZONDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Отчет";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.button1.Location = new System.Drawing.Point(24, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(64, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 16);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Назад";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(722, 693);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "otchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "otchet";
            this.Load += new System.EventHandler(this.otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZONDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private OZONDataSet4 oZONDataSet4;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private OZONDataSet4TableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОзаявителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типзаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаподачиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ответDataGridViewTextBoxColumn;
    }
}