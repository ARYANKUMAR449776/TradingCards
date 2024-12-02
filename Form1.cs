namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BindingSource playerBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTeam.Items.AddRange(new string[] { "Los Angeles Lakers", "Golden State Warriors", "Memphis Grizzlies" });
            cmbNewTeam.Items.AddRange(new string[] { "Los Angeles Lakers", "Golden State Warriors", "Memphis Grizzlies" });

            playerBindingSource.DataSource = Data.GetPlayers();
            lstPlayer.DataSource = playerBindingSource;
            lstPlayer.DisplayMember = "Name";

            BindPlayerDetails();
            playerBindingSource.PositionChanged += playerBindingSource_SelectionChange;
        }

        private void playerBindingSource_SelectionChange(object sender, EventArgs e)
        {
            var selectedPlayer = (Player)playerBindingSource.Current;
            if (selectedPlayer != null)
            {
                switch (selectedPlayer.Team)
                {
                    case "Los Angeles Lakers":
                        cardPanel.BackColor = Color.Yellow;
                        lblName.ForeColor = Color.RebeccaPurple;
                        lblTeam.ForeColor = Color.RebeccaPurple;
                        lblPPG.ForeColor = Color.RebeccaPurple;
                        lblRPG.ForeColor = Color.RebeccaPurple;
                        lblAPG.ForeColor = Color.RebeccaPurple;
                        lblSPG.ForeColor = Color.RebeccaPurple;
                        break;
                    case "Golden State Warriors":
                        cardPanel.BackColor = Color.Blue;
                        lblName.ForeColor = Color.Yellow;
                        lblTeam.ForeColor = Color.Yellow;
                        lblPPG.ForeColor = Color.Yellow;
                        lblRPG.ForeColor = Color.Yellow;
                        lblAPG.ForeColor = Color.Yellow;
                        lblSPG.ForeColor = Color.Yellow;
                        break;
                    case "Memphis Grizzlies":
                        cardPanel.BackColor = Color.DarkBlue;
                        lblName.ForeColor = Color.White;
                        lblTeam.ForeColor = Color.White;
                        lblPPG.ForeColor = Color.White;
                        lblRPG.ForeColor = Color.White;
                        lblAPG.ForeColor = Color.White;
                        lblSPG.ForeColor = Color.White;
                        break;
                    default:
                        cardPanel.BackColor = Color.DarkBlue;
                        break;
                }
            }
        }

        private void BindPlayerDetails()
        {
            lblName.DataBindings.Add("Text", playerBindingSource, "Name");
            lblTeam.DataBindings.Add("Text", playerBindingSource, "Team");
            lblPPG.DataBindings.Add("Text", playerBindingSource, "PointsPerGame", true, DataSourceUpdateMode.OnPropertyChanged, null, "PPG: 0.0");
            lblRPG.DataBindings.Add("Text", playerBindingSource, "ReboundsPerGame", true, DataSourceUpdateMode.OnPropertyChanged, null, "RPG: 0.0");
            lblAPG.DataBindings.Add("Text", playerBindingSource, "AssistsPerGame", true, DataSourceUpdateMode.OnPropertyChanged, null, "APG: 0.0");
            lblSPG.DataBindings.Add("Text", playerBindingSource, "StealsPerGame", true, DataSourceUpdateMode.OnPropertyChanged, null, "SPG: 0.0");
            picPlayer.DataBindings.Add("ImageLocation", playerBindingSource, "PlayerPhoto");

            txtName.DataBindings.Add("Text", playerBindingSource, "Name");
            txtPPG.DataBindings.Add("Text", playerBindingSource, "PointsPerGame");
            txtRPG.DataBindings.Add("Text", playerBindingSource, "ReboundsPerGame");
            txtAPG.DataBindings.Add("Text", playerBindingSource, "AssistsPerGame");
            txtSPG.DataBindings.Add("Text", playerBindingSource, "StealsPerGame");
            txtPhotoPath.DataBindings.Add("Text", playerBindingSource, "PlayerPhoto");
            cmbTeam.DataBindings.Add("Text", playerBindingSource, "Team");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewName.Text) || string.IsNullOrWhiteSpace(cmbNewTeam.Text))
            {
                MessageBox.Show("Please provide a Name and Team for the player.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPlayerName = txtNewName.Text.Trim();
            bool isDuplicate = Data.GetPlayers().Any(p => p.Name.Equals(newPlayerName, StringComparison.OrdinalIgnoreCase));

            if (isDuplicate)
            {
                MessageBox.Show("A player with this name already exists. Please enter a unique name.", "Duplicate Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPlayer = new Player
            {
                Id = Data.GetPlayers().Max(p => p.Id) + 1,
                Name = newPlayerName,
                Team = cmbNewTeam.Text,
                PlayerPhoto = txtNewPhotoPath.Text.Trim(),
                PointsPerGame = double.TryParse(txtNewPPG.Text, out double ppg) ? ppg : 0,
                ReboundsPerGame = double.TryParse(txtNewRPG.Text, out double rpg) ? rpg : 0,
                AssistsPerGame = double.TryParse(txtNewAPG.Text, out double apg) ? apg : 0,
                StealsPerGame = double.TryParse(txtNewSPG.Text, out double spg) ? spg : 0
            };

            Data.AddPlayer(newPlayer);
            playerBindingSource.ResetBindings(false);

            ClearInputFieldsForAdding();
            MessageBox.Show("Player added successfully!", "Success");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (playerBindingSource.Current == null)
            {
                MessageBox.Show("Please select a player to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPlayer = (Player)playerBindingSource.Current;

            selectedPlayer.Name = txtName.Text.Trim();
            selectedPlayer.PointsPerGame = double.TryParse(txtPPG.Text, out double ppg) ? ppg : 0;
            selectedPlayer.ReboundsPerGame = double.TryParse(txtRPG.Text, out double rpg) ? rpg : 0;
            selectedPlayer.AssistsPerGame = double.TryParse(txtAPG.Text, out double apg) ? apg : 0;
            selectedPlayer.StealsPerGame = double.TryParse(txtSPG.Text, out double spg) ? spg : 0;
            selectedPlayer.PlayerPhoto = txtPhotoPath.Text.Trim();
            selectedPlayer.Team = cmbTeam.Text;

            playerBindingSource.ResetBindings(false);
            MessageBox.Show("Player updated successfully!", "Success");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedPlayer = (Player)playerBindingSource.Current;
            if (selectedPlayer != null)
            {
                Data.RemovePlayer(selectedPlayer);

               
                playerBindingSource.ResetBindings(false);

               
                if (playerBindingSource.Count > 0)
                {
                    playerBindingSource.Position = 0;
                }
                else
                {
                    ClearPlayerDetailsCard(); 
                }

                MessageBox.Show("Player deleted successfully!", "Success");
            }
            else
            {
                MessageBox.Show("No player selected to delete.", "Error");
            }
        }


        private void ClearInputFieldsForAdding()
        {
            txtNewName.Clear();
            cmbNewTeam.SelectedIndex = -1;
            txtNewPhotoPath.Clear();
            txtNewPPG.Clear();
            txtNewRPG.Clear();
            txtNewAPG.Clear();
            txtNewSPG.Clear();
        }

        private void ClearPlayerDetailsCard()
        {
            lblName.Text = string.Empty;
            lblTeam.Text = string.Empty;
            lblPPG.Text = "PPG: 0.0";
            lblRPG.Text = "RPG: 0.0";
            lblAPG.Text = "APG: 0.0";
            lblSPG.Text = "SPG: 0.0";
            picPlayer.Image = null;
        }
    }
}
