using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CacheWork
{
    public partial class MainForm : Form
    {
        static int segmentsCount = 10;
        static int stringsCount = 10;
        static int elementsCount = 4;

        Controller Data = new Controller(segmentsCount, stringsCount, elementsCount);
        Stopwatch Time = new Stopwatch();

        int[] stringData;
        int I_adress, J_adress, K_adress;
        int Values;

        public MainForm()
        {
            InitializeComponent();
            PrintMainMemory();
            PrintCache();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                I_adress = Convert.ToInt32(segmentTextBox.Text);
                J_adress = Convert.ToInt32(stringTextBox.Text);
                K_adress = Convert.ToInt32(elementTextBox.Text);

                Time.Start();
                Values = Data[I_adress, J_adress, K_adress];
                Time.Stop();

                UpdateStatus(Values);

                PrintMainMemory();
                PrintCache();
            }
            catch
            {
                MessageBox.Show("Введены неккоректные данные.", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                I_adress = Convert.ToInt32(segmentTextBox.Text);
                J_adress = Convert.ToInt32(stringTextBox.Text);
                K_adress = Convert.ToInt32(elementTextBox.Text);
                Values = Convert.ToInt32(newElementTextBox.Text);

                Time.Start();
                Data[I_adress, J_adress, K_adress] = Values;
                Time.Stop();

                UpdateStatus(Values);

                PrintMainMemory();
                PrintCache();
            }
            catch
            {
                MessageBox.Show("Введены неккоректные данные.", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void PrintCache()
        {
            cacheTextBox.Text = "";
            for (int i = 1; i <= stringsCount; i++)
            {
                stringData = Controller.CacheController[i];
                cacheTextBox.Text += Controller.CacheController.GetTag(i);
                cacheTextBox.Text += "     ";

                for (int k = 0; k < elementsCount; k++)
                {
                    cacheTextBox.Text += stringData[k] + " ";
                }

                cacheTextBox.Text += Environment.NewLine;
            }
        }

        void PrintMainMemory()
        {
            mainMemoryTextBox.Text = "";
            for (int i = 1; i <= segmentsCount; i++)
            {
                for (int j = 1; j <= stringsCount; j++)
                {
                    stringData = Controller.MainMemoryController.GetString(i, j);
                    for (int k = 0; k < elementsCount; k++)
                    {
                        mainMemoryTextBox.Text += stringData[k] + " ";
                    }
                    mainMemoryTextBox.Text += Environment.NewLine;
                }
                mainMemoryTextBox.Text += Environment.NewLine;
            }
        }

        void UpdateStatus(int el)
        {
            if (Data.FromCache)
            {
                statusTextBox.Text = " Элемент загружен из КЭШ памяти";
            }
            else
            {
                statusTextBox.Text = " Элемент загружен из Основной памяти";
            }

            elementFromTextBox.Text = el.ToString();
            timeTextBox.Text = Time.Elapsed.ToString();
            Time.Reset();

            stringFromTextBox.Text = "";
            for (int i = 1; i <= elementsCount; i++)
            {
                stringFromTextBox.Text += Controller.CacheController[J_adress, i] + " ";
            }
        }
    }
}
