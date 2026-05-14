namespace SlotsGame
{
    public partial class MainMenuForm : Form
    {
        SlotGameForm slotGameForm;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            slotGameForm = new SlotGameForm();
            slotGameForm.Show();
            Hide();

        }
    }
}
