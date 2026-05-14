namespace SlotsGame
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            PlayBtn = new Button();
            StatBtn = new Button();
            ExitBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(160, 33);
            label1.Name = "label1";
            label1.Size = new Size(324, 71);
            label1.TabIndex = 0;
            label1.Text = "Главное меню";
            // 
            // PlayBtn
            // 
            PlayBtn.FlatStyle = FlatStyle.Flat;
            PlayBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            PlayBtn.Location = new Point(224, 180);
            PlayBtn.Margin = new Padding(3, 4, 3, 4);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(214, 49);
            PlayBtn.TabIndex = 1;
            PlayBtn.Text = "Играть";
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // StatBtn
            // 
            StatBtn.FlatStyle = FlatStyle.Flat;
            StatBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            StatBtn.Location = new Point(224, 260);
            StatBtn.Margin = new Padding(3, 4, 3, 4);
            StatBtn.Name = "StatBtn";
            StatBtn.Size = new Size(214, 49);
            StatBtn.TabIndex = 2;
            StatBtn.Text = "Статистика";
            StatBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitBtn.Location = new Point(224, 335);
            ExitBtn.Margin = new Padding(3, 4, 3, 4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(214, 51);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Выход";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(656, 530);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 483);
            Controls.Add(ExitBtn);
            Controls.Add(StatBtn);
            Controls.Add(PlayBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenuForm";
            Text = "Слоты";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button PlayBtn;
        private Button StatBtn;
        private Button ExitBtn;
        private PictureBox pictureBox1;
    }

        
}

