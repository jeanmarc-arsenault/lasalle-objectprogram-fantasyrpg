using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_JMA
{
    public static class Message
    {
        public static Main_Game form;
        public static void Print(String message)
        {
            /*form.listBoxMessages.BackColor = newcolor;*/
            
            form.lbFirstline.Items.Insert(0, message);
            form.listBoxMessages.Items.Insert(0, message);
        }


        public static void PrintDanger(string message)
        {
            form.lbFirstline.ForeColor = Color.Red;
            Print(message);
        }
        public static void PrintWarning(string message)
        {
            form.lbFirstline.ForeColor = Color.Yellow;
            Print(message);
        }
        public static void PrintInfo(string message)
        {
            form.lbFirstline.ForeColor = Color.LightGreen;
            Print(message);
        }
        public static void PrintMainMenu(string message)
        {
            form.lbFirstline.ForeColor = Color.Black;
            Print(message);
        }
        public static void PrintMenu(string message)
        {
            form.lbFirstline.ForeColor = Color.Gray;
            Print(message);
        }










    }






}
