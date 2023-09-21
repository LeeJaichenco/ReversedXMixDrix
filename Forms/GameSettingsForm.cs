using System;
using System.Windows.Forms;

namespace ReversedXMixDrix
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void checkBoxPlayer2_Click(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked)
            {
                textBoxPlayer2.Enabled = true;
                textBoxPlayer2.Text = "";
            }
            else
            {
                textBoxPlayer2.Enabled = false;
                textBoxPlayer2.Text = "[Computer]";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            eGameMode gameMode = checkBoxPlayer2.Checked ? eGameMode.PlayAgainstPlayer : eGameMode.PlayAgainstComputer;
            GameSettings gameSettings = new GameSettings
            {
                BoardSize = (int)numericUpDownCols.Value,
                Player1 = new Player(eSymbol.X, textBoxPlayer1.Text),
                Player2 = gameMode == eGameMode.PlayAgainstPlayer ? new Player(eSymbol.O, textBoxPlayer2.Text) : new ComputerPlayer(),
                GameMode = gameMode,
            };

            Hide();
            GameForm gameForm = new GameForm(gameSettings);
            while(gameForm.ShowDialog() == DialogResult.Yes)
            {
                gameForm = new GameForm(gameSettings);
            }

            this.Close();
        }

        private void numericUpDown_Click(object sender, EventArgs e)
        {
            decimal newValue = (sender as NumericUpDown).Value;
            numericUpDownCols.Value = newValue;
            numericUpDownRows.Value = newValue;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ButtonStart.Enabled = (textBoxPlayer1.Text != "") && (textBoxPlayer2.Text != "");
        }

        private void GameSettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
