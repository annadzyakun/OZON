namespace проба
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCreateRequest = new System.Windows.Forms.Button();
            this.buttonViewRequest = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(175, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Профиль сотрудника";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.button1.Location = new System.Drawing.Point(234, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCreateRequest
            // 
            this.buttonCreateRequest.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCreateRequest.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.buttonCreateRequest.Location = new System.Drawing.Point(158, 192);
            this.buttonCreateRequest.Name = "buttonCreateRequest";
            this.buttonCreateRequest.Size = new System.Drawing.Size(272, 42);
            this.buttonCreateRequest.TabIndex = 20;
            this.buttonCreateRequest.Text = "Создать заявку";
            this.buttonCreateRequest.UseVisualStyleBackColor = false;
            this.buttonCreateRequest.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonViewRequest
            // 
            this.buttonViewRequest.BackColor = System.Drawing.SystemColors.Info;
            this.buttonViewRequest.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.buttonViewRequest.Location = new System.Drawing.Point(158, 257);
            this.buttonViewRequest.Name = "buttonViewRequest";
            this.buttonViewRequest.Size = new System.Drawing.Size(272, 42);
            this.buttonViewRequest.TabIndex = 21;
            this.buttonViewRequest.Text = "Посмотреть заявки";
            this.buttonViewRequest.UseVisualStyleBackColor = false;
            this.buttonViewRequest.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.SystemColors.Info;
            this.buttonReport.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.buttonReport.Location = new System.Drawing.Point(158, 325);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(272, 42);
            this.buttonReport.TabIndex = 22;
            this.buttonReport.Text = "Посмотреть отчет";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(586, 557);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonViewRequest);
            this.Controls.Add(this.buttonCreateRequest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreateRequest;
        private System.Windows.Forms.Button buttonViewRequest;
        private System.Windows.Forms.Button buttonReport;
    }
}