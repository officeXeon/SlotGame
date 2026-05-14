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
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(190, 45);
            label1.Name = "label1";
            label1.Size = new Size(261, 57);
            label1.TabIndex = 0;
            label1.Text = "Главное меню";
            // 
            // PlayBtn
            // 
            PlayBtn.FlatStyle = FlatStyle.Flat;
            PlayBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            PlayBtn.Location = new Point(232, 151);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(187, 37);
            PlayBtn.TabIndex = 1;
            PlayBtn.Text = "Играть";
            PlayBtn.UseVisualStyleBackColor = true;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // StatBtn
            // 
            StatBtn.FlatStyle = FlatStyle.Flat;
            StatBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            StatBtn.Location = new Point(232, 210);
            StatBtn.Name = "StatBtn";
            StatBtn.Size = new Size(187, 37);
            StatBtn.TabIndex = 2;
            StatBtn.Text = "Статистика";
            StatBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitBtn.Location = new Point(232, 268);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(187, 38);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Выход";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(12, 339);
            button4.Name = "button4";
            button4.Size = new Size(50, 43);
            button4.TabIndex = 4;
            button4.Text = "⚙";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 394);
            Controls.Add(button4);
            Controls.Add(ExitBtn);
            Controls.Add(StatBtn);
            Controls.Add(PlayBtn);
            Controls.Add(label1);
            Name = "MainMenuForm";
            Text = "Слоты";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button PlayBtn;
        private Button StatBtn;
        private Button ExitBtn;
        private Button button4;
    }

        
}

