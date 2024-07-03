using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZON
{
    public partial class otchet : Form
    {
        public otchet()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Получаем размер DataGridView
            int width = dataGridView1.Width;
            int height = dataGridView1.Height;

            // Создаем Bitmap нужного размера
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            // Рисуем DataGridView на Bitmap
            Rectangle bounds = new Rectangle(0, 0, width, height);
            dataGridView1.DrawToBitmap(bmp, bounds);

            // Рисуем Bitmap на странице печати
            e.Graphics.DrawImage(bmp, 0, 0);
            // Добавляем заголовок
            e.Graphics.DrawString("Отчет заявок", new Font("Arial", 14), Brushes.Black, new PointF(10, 10));

            // Проверяем, нужно ли печатать следующую страницу
            if (dataGridView1.Height > e.MarginBounds.Height)
            {
                e.HasMorePages = true;

                // Смещаем рисование DataGridView для следующей страницы
                dataGridView1.Top -= e.MarginBounds.Height;
            }
        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            // Вызываем диалог предварительного просмотра печати
            printPreviewDialog1.ShowDialog();
        }
    }
}
