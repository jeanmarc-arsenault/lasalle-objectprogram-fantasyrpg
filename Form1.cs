using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_RPG_JMA
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtName.Text != null)
            {
                GameManager.StartGame( txtName.Text);
                GameManager.CurrentPlayer.MyWeapon = GameFactory.CreateStick();
                this.Hide();
                Main_Game main = new Main_Game();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

    }
}
