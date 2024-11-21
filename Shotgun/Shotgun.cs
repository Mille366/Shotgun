using Shotgun.NewFolder;

namespace Shotgun
{
    public partial class Shotgun : Form
    {
        private Player player = new Player();
        private GameComputer gameComputer = new GameComputer();
        private GameLogic game;
        public Shotgun()

        {
            game = new GameLogic(player, gameComputer);
            InitializeComponent();
            UpdateAmmoLabels();
        }


        public void UpdateAmmoLabels()
        {
            labelPlayerAmmo.Text = player.PlayerShots.ToString();
            labelComputerAmmo.Text = gameComputer.ComputerShots.ToString();
        }



        private void ShowResult(string result)
        {
            textBoxResult.AppendText(result + Environment.NewLine);
            UpdateAmmoLabels(); 

            if (result.Contains("vinner"))
            {
                buttonBlock.Enabled = false;
                buttonRelod.Enabled = false;
                buttonShoot.Enabled = false;
                buttonShotgun.Enabled = false;

            }
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (!player.CanShoot())
            {
                MessageBox.Show("Du har inga skott!");
                return;
            }
            string result = game.PlayerAction("Skjuta");
            ShowResult(result);
        }
            

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            string result = game.PlayerAction("Blocka");
            ShowResult(result);
        }

            private void buttonRelod_Click(object sender, EventArgs e)
            {
            string result = game.PlayerAction("Ladda");
            ShowResult(result);
            UpdateAmmoLabels();
            }

            private void buttonShotgun_Click(object sender, EventArgs e)
            {
                if (player.PlayerShots < 3)
                {
                    MessageBox.Show("Du behöver minst 3 skott för att använda Shotgun!");
                    return;
                }

                string result = game.PlayerAction("Shotgun");
                ShowResult(result);
            }

            private void buttonRestart_Click(object sender, EventArgs e)
            {
                game.ResetGame();
                UpdateAmmoLabels();
                textBoxResult.Clear();
                textBoxResult.AppendText("Nytt spel startat!");

            buttonBlock.Enabled = true;
            buttonRelod.Enabled = true;
            buttonRestart.Enabled = true;
            buttonShoot.Enabled = true;
            buttonShotgun.Enabled = true;

            }
    }
}