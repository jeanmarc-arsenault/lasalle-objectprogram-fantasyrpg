using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_RPG_JMA
{
    public partial class Main_Game : Form
    {

        Form1 form1 = new Form1();


        public Main_Game()
        {
            InitializeComponent();
            Message.form = this;
            GameManager.form = this;
            lblMainName.Text = GameManager.CurrentPlayer.Name;
        }


        public void SetBattleButtons()
        {
            btnExplore.Enabled = false;
            btnExplore.BackColor = Color.Gray;
            btnAttack.Enabled = true;
            btnCloak.Enabled = true;
            btnDust.Enabled = true;
            btnPotion.Enabled = true;
            btnShield.Enabled = true;
            btnBuyPotion.Visible = false;
            btnBuySheild.Visible = false;
            btnBuyCloak.Visible = false;
            btnBuyDust.Visible = false;
            btnBuyRock.Visible = false;
            btnBuyTorch.Visible = false;
            btnBuySword.Visible = false;
            btnLeave.Visible = false;
            lblMonsterName.Visible = true;
            pbMontserHP.Visible = true;
        }

        public void SetExploreButtons()
        {
            btnExplore.Enabled = true;
            btnExplore.BackColor = Color.LimeGreen;
            btnAttack.Enabled = false;
            btnCloak.Enabled = false;
            btnDust.Enabled = false;
            btnPotion.Enabled = false;
            btnShield.Enabled = false;
            btnPotion.Enabled = false;
            btnShield.Enabled = false;

            btnBuyPotion.Visible = false;
            btnBuySheild.Visible = false;
            btnBuyCloak.Visible = false;
            btnBuyDust.Visible = false;
            btnBuyRock.Visible = false;
            btnBuyTorch.Visible = false;
            btnBuySword.Visible = false;
            btnLeave.Visible = false;
            lblMonsterName.Visible = false;
            pbMontserHP.Visible = false;
            pbMain.Refresh();
            pbMain.Image = ilImages.Images[3];

        }

        public void SetMerchantButtons()
        {

            btnExplore.Enabled = false;
            btnExplore.BackColor = Color.Gray;
            btnAttack.Enabled = false;
            btnCloak.Enabled = false;
            btnDust.Enabled = false;
            btnPotion.Enabled = false;
            btnShield.Enabled = false;

            btnBuyPotion.Visible = true;
            btnBuySheild.Visible = true;
            btnBuyCloak.Visible = true;
            btnBuyDust.Visible = true;
            btnBuyRock.Visible = true;
            btnBuyTorch.Visible = true;
            btnBuySword.Visible = true;
            btnLeave.Visible = true;
            lblMonsterName.Visible = false;
            pbMontserHP.Visible = false;
            pbMain.Refresh();
            pbMain.Image = ilImages.Images[13];
        }



        private void btnExplore_Click(object sender, EventArgs e)
        {
            GameManager.Explore();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            GameManager.CurrentPlayer.Attack();
            if(GameManager.CurrentPlayer.Enemy == null)
                pbMontserHP.Value = 0;
            else
            pbMontserHP.Value = GameManager.CurrentPlayer.Enemy.Hp;
        }

        private void btnShield_Click(object sender, EventArgs e)
        {
            GameManager.CurrentPlayer.ApplyPower(Power.PowerType.Protect);
            

        }

        private void btnCloak_Click(object sender, EventArgs e)
        {
            GameManager.CurrentPlayer.ApplyPower(Power.PowerType.Invisible);
        }

        private void btnPotion_Click(object sender, EventArgs e)
        {
            GameManager.CurrentPlayer.ApplyPower(Power.PowerType.Healing);
        }

        private void btnDust_Click(object sender, EventArgs e)
        {
            GameManager.CurrentPlayer.ApplyPower(Power.PowerType.Sleepy);
        }

        private void btnBuySheild_Click(object sender, EventArgs e)
        {
            Power shield = GameFactory.CreateProtect();
            GameManager.CurrentPlayer.Buy_Power(shield);
        }

        private void btnBuyDust_Click(object sender, EventArgs e)
        {
            Power magic_powder = GameFactory.CreateSleepy();
            GameManager.CurrentPlayer.Buy_Power(magic_powder);
        }

        private void btnBuyPotion_Click(object sender, EventArgs e)
        {
            Power magic_potion = GameFactory.CreateHealing();
            GameManager.CurrentPlayer.Buy_Power(magic_potion);
        }

        private void btnBuyCloak_Click(object sender, EventArgs e)
        {
            Power magic_cape = GameFactory.CreateInvisible();
            GameManager.CurrentPlayer.Buy_Power(magic_cape);
        }

        private void btnBuyRock_Click(object sender, EventArgs e)
        {
            Weapon rock = GameFactory.CreateRock();
            GameManager.CurrentPlayer.Buy_Weapon(rock);

        }

        private void btnBuyTorch_Click(object sender, EventArgs e)
        {
            Weapon torch = GameFactory.CreateTorch();
            GameManager.CurrentPlayer.Buy_Weapon(torch);

        }

        private void btnBuySword_Click(object sender, EventArgs e)
        {
            
            Weapon sword = GameFactory.CreateSword();
            GameManager.CurrentPlayer.Buy_Weapon(sword);
            
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Message.Print("\nYou leave the Wizard to continue your adventure...");
            SetExploreButtons();

        }

        private void pbMain_BackgroundImageChanged(object sender, EventArgs e)
        {
            pbMain.Refresh();
        }

        private void Main_Game_Load(object sender, EventArgs e)
        {

        }


    }
}






















