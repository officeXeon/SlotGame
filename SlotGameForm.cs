using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SlotsGame
{
    public partial class SlotGameForm : Form
    {
        int slot1, slot2, slot3;
        MainMenuForm mainMenu;
        Random random = new Random();
        public SlotGameForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            InitGameElements();
            SlotGame();
        }

        private void InitGameElements()
        {
            int slot1 = random.Next(1, 10);
            int slot2 = random.Next(1, 10);
            int slot3 = random.Next(1, 10);

            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "777 СЛОТЫ 777";
        }
        private async void SlotGame()
        {
            foreach (int number in Enumerable.Range(0, slot1))
            {
                await Task.Delay(150);
                label1.Text = number.ToString();
            }
            label1.Text += "!";
            foreach (int number in Enumerable.Range(0, slot2))
            {
                await Task.Delay(150);
                label2.Text = number.ToString();
            }
            label2.Text += "!";
            foreach (int number in Enumerable.Range(0, slot3))
            {
                await Task.Delay(150);
                label3.Text = number.ToString();
            }
            label3.Text += "!";

            await Task.Delay(500);

            if (slot1 == slot2 && slot2 == slot3)
            {
                label4.Text = "Джекпот!!!";
            }
            else
            {
                label4.Text = "Вы проиграли!";
            }
        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            mainMenu = new MainMenuForm();
            mainMenu.Show();
            Hide();
        }
    }
}

