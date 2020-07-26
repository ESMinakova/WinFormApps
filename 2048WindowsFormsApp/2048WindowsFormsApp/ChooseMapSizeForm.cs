using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class ChooseMapSizeForm : Form
    {
        public static int buttonResult;
        public static Size newClientSize;
        private int startPointX = 40;
        private int startPointY = 110;
        private int labelBlockSizeInPixels = 76;

        public ChooseMapSizeForm()
        {
            InitializeComponent();
        }

        private void fourToFourMapSizeButton_Click(object sender, EventArgs e)
        {
            buttonResult = 4;
            DetermineMapSizeInPixels(buttonResult);
        }

        private void fiveToFiveMapSizeButton_Click(object sender, EventArgs e)
        {
            buttonResult = 5;
            DetermineMapSizeInPixels(buttonResult);
        }

        private void sixToSixMapSizeButton_Click(object sender, EventArgs e)
        {
            buttonResult = 6;
            DetermineMapSizeInPixels(buttonResult);
        }

        private void DetermineMapSizeInPixels(int buttonResult)
        {
            newClientSize = new Size(startPointX + (buttonResult * labelBlockSizeInPixels), startPointY + (buttonResult * labelBlockSizeInPixels));
        }
        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Используйте стрелки вверх, вниз, вправо и влево, чтобы перемещать квадраты с цифрами. " +
                "Когда два одинаковых квадрата должны встать рядом, вместо этого они сливаются в один новый квадрат, " +
                "значение которого равно сумме предыдущих. Ваша задача набрать 2048");
        }

        private void выходИзИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChooseMapSizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
