using System.Reflection.Emit;
using System.Resources;

namespace SlotsGame
{
    partial class SlotGameForm
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
            button1 = new Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            BackToMenuBtn = new Button();
            BackgroundGame = new PictureBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)BackgroundGame).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.LightGreen;
            button1.Location = new Point(110, 400);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(687, 131);
            button1.TabIndex = 3;
            button1.Text = "$$$ КРУТИТЬ $$$";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 100F);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(127, 181);
            label1.Name = "label1";
            label1.Size = new Size(175, 202);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 100F);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(361, 181);
            label2.Name = "label2";
            label2.Size = new Size(175, 202);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 100F);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(588, 181);
            label3.Name = "label3";
            label3.Size = new Size(175, 202);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Courier New", 62F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(33, 26);
            label4.Name = "label4";
            label4.Size = new Size(856, 117);
            label4.TabIndex = 4;
            label4.Text = "    СЛОТЫ    ";
            // 
            // BackToMenuBtn
            // 
            BackToMenuBtn.BackColor = Color.Gray;
            BackToMenuBtn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BackToMenuBtn.Location = new Point(14, 534);
            BackToMenuBtn.Margin = new Padding(3, 4, 3, 4);
            BackToMenuBtn.Name = "BackToMenuBtn";
            BackToMenuBtn.Size = new Size(53, 50);
            BackToMenuBtn.TabIndex = 5;
            BackToMenuBtn.Text = "←";
            BackToMenuBtn.UseVisualStyleBackColor = false;
            BackToMenuBtn.Click += BackToMenuBtn_Click;
            // 
            // BackgroundGame
            // 
            BackgroundGame.Location = new Point(-6, 0);
            BackgroundGame.Margin = new Padding(3, 4, 3, 4);
            BackgroundGame.Name = "BackgroundGame";
            BackgroundGame.Size = new Size(962, 597);
            BackgroundGame.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundGame.TabIndex = 6;
            BackgroundGame.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(815, 534);
            label5.Name = "label5";
            label5.Size = new Size(113, 40);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // SlotGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(956, 595);
            Controls.Add(label5);
            Controls.Add(BackToMenuBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(BackgroundGame);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SlotGameForm";
            Text = "Игра...";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)BackgroundGame).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion


        private Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Button BackToMenuBtn;
        private PictureBox BackgroundGame;
        private System.Windows.Forms.Label label5;
    }
}