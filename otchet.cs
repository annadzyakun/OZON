using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static проба.avtorization;

namespace проба
{
    public partial class otchet : Form
    {
        private User currentUser;
        public otchet(User user)
        {
            InitializeComponent();
            currentUser = user;
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            avtorization avtorization = new avtorization();
            avtorization.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            // Устанавливаем обработчик события PrintPage
            printDocument.PrintPage += printDocument1_PrintPage;
            // Показывать диалог предварительного просмотра печати
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }
        private int currentPage = 1; 
        private int totalPages; 
        private int currentTop = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int width = dataGridView1.Width;
            int height = dataGridView1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle bounds = new Rectangle(0, currentTop, width, height);
            dataGridView1.DrawToBitmap(bmp, bounds);
            e.Graphics.DrawString("Отчет заявок", new Font("Arial", 14), Brushes.Black, new PointF(10, 10));
            e.Graphics.DrawImage(bmp, 0, 0);
            if (currentTop + height < dataGridView1.Height)
            {
                e.HasMorePages = true;
                currentTop += e.MarginBounds.Height;
                currentPage++; 
            }
            else
            {
                e.HasMorePages = false;
            }
        }
   
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User user = new User("your_username", "Менеджер");
            Form2 form = new Form2(user);
            form.Show();
            this.Hide();
        }

        private void otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "oZONDataSet4.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.oZONDataSet4.Заявки);

        }
    }
}
