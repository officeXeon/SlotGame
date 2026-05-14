using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SlotsGame
{
    public partial class AccountingManager : Form
    {
        private DataBase db;
        public string userName = "Игрок";
        public AccountingManager()
        {
            InitializeComponent();
        }

        private void AccountingManager_Load(object sender, EventArgs e)
        {

        }
        private void RegisterPLayerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                db = new DataBase();
                if (!db.GetPlayersNames().Contains(textBox1.Text))
                {
                    userName = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Данное имя занято, пожалуйста введите другое.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста введите имя игрока.");
            }
        }
    }
}
