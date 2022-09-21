using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Project_RPG_JMA
{
    public static class GameManager
    {
        public static string data_file = @"../../../DATA/PlayersData.xml";
        private static List<Player> ListPlayers = new List<Player>();
        public static Player CurrentPlayer;
        public static bool gameOver = false;
        public static bool gameQuit = false;

        public static int BattleRounds = 0;
        private static int MaxRounds = 5;
        public static Main_Game form;


        public static void StartGame( string name)
        {
            try
            {
                GameManager.ListPlayers = DataXML.Load(GameManager.data_file);
            }
            catch (IOException exception)
            {
                MessageBox.Show("EXCEPTION !" + exception.Message);
            }
            finally
            {
                MessageBox.Show("--- START GAME ----");

            }

            Player obj = Find_Player(name);
            if (obj != null)//Player is found
            {
                GameManager.CurrentPlayer = obj;
                MessageBox.Show("PLayer found!");
            }
            else // Player is not found
            {
                GameManager.CurrentPlayer = new Player(name, 100);
                
                GameManager.ListPlayers.Add(CurrentPlayer);
                GameManager.CurrentPlayer.Hp_max = 100;
                MessageBox.Show("PLayer not found creating new player!");
            }
     
        }

        public static void Merchant(Main_Game form)
        {
            Message.PrintMenu("You entounter a Wizard merchant who sells magical items!");
            Message.PrintMenu("He says: Anything of interest young adventurer?");

            form.SetMerchantButtons();
        }
            public static void StartBattle(Main_Game form)
        {

            Message.PrintMenu($"You are trying to kill the { CurrentPlayer.Enemy.Name}");
            form.SetBattleButtons();
            BattleRounds++;

            if (GameManager.CurrentPlayer.Enemy != null &&
                GameManager.CurrentPlayer.Enemy.IsDead())
            {
                CurrentPlayer.Xp += CurrentPlayer.Enemy.Rxp;
                form.lblXP.Text = CurrentPlayer.Xp.ToString();
                Message.PrintInfo("The " + CurrentPlayer.Enemy.Name + " is dead ! You gain " + CurrentPlayer.Enemy.Rxp +"XP!");
                BattleRounds = 0;
                Dragon tempdragon = new Dragon();
                if (GameManager.CurrentPlayer.Enemy.GetType() == tempdragon.GetType())
                {
                    int gp = ((Dragon)GameManager.CurrentPlayer.Enemy).Rgp;
                    GameManager.CurrentPlayer.Gp += gp;
                    Message.Print("\nYou collect the Dragon's Treasure! It is " + gp + " Gold Pieces !");
                    Message.form.lblGold.Text = GameManager.CurrentPlayer.Gp.ToString();
                }
                    GameManager.CurrentPlayer.Enemy = null;
                form.lblMonsterName.Visible = false;
                form.pbMontserHP.Visible = false;
                GameManager.CurrentPlayer.Protect = false;
                GameManager.CurrentPlayer.Next_Level();
                form.SetExploreButtons();
            }
            else
            {
                Message.PrintDanger("The " + CurrentPlayer.Enemy.Name + " is not dead !");
                if (BattleRounds >= MaxRounds)
                {
                    Message.PrintInfo("You panic and run away ...");
                    BattleRounds = 0;
                    GameManager.CurrentPlayer.Enemy = null;
                    GameManager.CurrentPlayer.Protect = false;
                    form.SetExploreButtons();
                }
                else
                {
                    if (GameManager.CurrentPlayer.Enemy != null)
                    {
                        form.lblMonsterName.Visible = true;
                        GameManager.CurrentPlayer.Enemy.Attack();
                        form.SetBattleButtons();

                        if (GameManager.CurrentPlayer.IsDead())
                        {
                            GameManager.gameOver = true;
                            MessageBox.Show("You have died...GAMEOVER");
                            SaveGame();
                            form.Close();
                        }
                    }
                }
            }
        }
        public static Player Find_Player(string name)
        {
            foreach (Player obj in GameManager.ListPlayers)
            {
                if (obj.Name.ToLower() == name.ToLower())// Player is found
                {
                    return obj;
                }
            }
            return null;
        }
  
        public static void SaveGame()
        {
            if (GameManager.CurrentPlayer.IsDead())
            {
                GameManager.ListPlayers.Remove(CurrentPlayer);
            }
            else
            {
                GameManager.CurrentPlayer.Enemy = null;
            }
            DataXML.Save(GameManager.data_file, GameManager.ListPlayers);
        }
        public static void Explore()
        {
            int random = Dice.GetInstance().Next(0, 80);
            Message.PrintDanger(random.ToString());
            switch (random)
            {

                case <= 25:
                    Monster monster = GameFactory.CreateMonster();
                    Message.PrintDanger(monster.Name + " approaches ! Prepare for Battle !");
                    form.lblMonsterName.Text = monster.Name;
                    monster.Target = CurrentPlayer;
                    GameManager.CurrentPlayer.Enemy = monster;
                    form.pbMontserHP.Value = GameManager.CurrentPlayer.Enemy.Hp;
                    StartBattle(Message.form);
                    break;

                case > 25 and <= 39:

                case >  40 and <= 48:
                    Merchant(Message.form);
                    break;
                case > 49 and <= 60:
                    int gp = Dice.GetInstance().Next(1, 300);
                    GameManager.CurrentPlayer.Gp += gp;
                    Message.Print("\nYou collect " + gp + " Gold Pieces !");
                    Message.form.lblGold.Text = GameManager.CurrentPlayer.Gp.ToString();
                    Message.form.pbMain.Refresh();
                    Message.form.pbMain.Image = Message.form.ilImages.Images[5];
                    Task.Delay(1000).Wait();
                    Message.form.pbMain.Refresh();
                    Message.form.pbMain.Image = Message.form.ilImages.Images[3];
                    break;
                default:
                    Message.PrintInfo("\nYou find nothing here! You keep Searching...");
                    break;
            }

        }
    }
}
