using System.Windows.Forms.VisualStyles;
using T3.Control;
using T3.Model;

namespace T3.View
{
    public partial class Form1 : Form
    {
        private bool hidden = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dwm.Windows10EnableBlurBehind(Handle); // sets blur for transparent options
            Dwm.SetWindowCorners(Handle); // sets rounding for windows 11 corners
            TopMost = true;

            FormBorderStyle = FormBorderStyle.None;

            MaximizeBox = false;
            MinimizeBox = false;
            Move += ResetPos;

            ResetPosition();
            StartPosition = FormStartPosition.Manual;
        }

        private void ResetPos(object? sender, EventArgs e)
        {
            ResetPosition();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidden = !hidden;
            ResetPosition();
        }
        private void ResetPosition()
        {
            Point pos;
            if (hidden)
            {
                pos = new Point(Screen.PrimaryScreen.Bounds.Width - button1.Width - 4, (int)Math.Round(Screen.PrimaryScreen.Bounds.Height * 0.3f));
            }
            else
            {
                pos = new Point(Screen.PrimaryScreen.Bounds.Width - Width, (int)Math.Round(Screen.PrimaryScreen.Bounds.Height * 0.3f));
            }
            Location = pos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!BitcoinAPIController.FetchData(dateTimePicker3.Value, dateTimePicker4.Value))
            {
                return;
            }

            // volume information
            BitcoinData largest = BitcoinAPIController.GetLargestVolume();
            BitcoinData smallest = BitcoinAPIController.GetSmallestVolume();
            lowestVolume.Text = smallest.Total_volume.ToString();
            lowestPrice.Text = Math.Round(smallest.Price, 2).ToString() + " €";
            highestVolume.Text = largest.Total_volume.ToString();
            highestPrice.Text = Math.Round(largest.Price, 2).ToString() + " €";

            dateTimePicker1.Value = smallest.DateTime;
            dateTimePicker2.Value = largest.DateTime;

            //bullish and bearish values
            int[] values = BitcoinAPIController.GetHighestTrends();
            textBox1.Text = values[0].ToString();
            textBox2.Text = values[1].ToString();

            int val = DateTime.Compare(smallest.DateTime, largest.DateTime);
            // selling times
            if (val < 0)
            {
                dateTimePicker5.Value = smallest.DateTime;
                dateTimePicker6.Value = largest.DateTime;
            }
            else
            {
                dateTimePicker5.Value = BitcoinAPIController.GetBestBuyTime();
                dateTimePicker6.Value = BitcoinAPIController.GetBestSellTime();
            }
        }
    }
}
