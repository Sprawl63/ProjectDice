using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList diceList = new ArrayList();
        ArrayList modList = new ArrayList();
        int[] diceNum = new int[] { 2, 4, 6, 8, 10, 12, 20 };
        Random rdm;
        public Form1()
        {
            InitializeComponent();
        }
        private void rollDice(int dice, int amount, int mod)
        {
            rdm = new Random();
            int[] ary = new int[amount];
            int total = 0;
            for (int i = 0; i < amount; i++)
            {
                ary[i] = rdm.Next(1, dice+1);
            }
            outputBox.AppendText(amount + "d" + dice + " + " + mod + ": ");
            for(int i = 0; i < amount; i++)
            {
                outputBox.AppendText(ary[i] + ", ");
                total += ary[i];
            }
            total += mod;
            outputBox.AppendText(" = " + total);
            outputBox.AppendText("\r\n");
        }
        private void callRoll()
        {
            getDice();
            getMods();
            outputBox.AppendText("Rolled: \r\n");
            for(int d = 0; d < diceList.Count; d++)
            {
                if ((int)diceList[d] != 0)
                {
                    rollDice(diceNum[d], (int)diceList[d], (int)modList[d]);
                } 
            }
            diceList.Clear();
            modList.Clear();
        }
        private void getDice()
        {
            try
            {
                diceList.Add(Convert.ToInt32(d2Amt.Text));
                diceList.Add(Convert.ToInt32(d4Amt.Text));
                diceList.Add(Convert.ToInt32(d6Amt.Text));
                diceList.Add(Convert.ToInt32(d8Amt.Text));
                diceList.Add(Convert.ToInt32(d10Amt.Text));
                diceList.Add(Convert.ToInt32(d12Amt.Text));
                diceList.Add(Convert.ToInt32(d20Amt.Text));

            }
            catch (Exception)
            {
                outputBox.AppendText("Please enter a positive integer. \r\n");
            }
        }
        private void getMods()
        {
            try
            {
                modList.Add(Convert.ToInt32(d2Mod.Text));
                modList.Add(Convert.ToInt32(d4Mod.Text));
                modList.Add(Convert.ToInt32(d6Mod.Text));
                modList.Add(Convert.ToInt32(d8Mod.Text));
                modList.Add(Convert.ToInt32(d10Mod.Text));
                modList.Add(Convert.ToInt32(d12Mod.Text));
                modList.Add(Convert.ToInt32(d20Mod.Text));
            }
            catch
            {
                outputBox.AppendText("Please enter an integer. \r\n");
            }
        }
        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            outputBox.SelectionStart = outputBox.Text.Length;
            outputBox.ScrollToCaret();
        }
        private void resetBut_Click(object sender, EventArgs e)
        {
            outputBox.ResetText();
            d2Amt.ResetText();
            d2Amt.AppendText("0");
            d4Amt.ResetText();
            d4Amt.AppendText("0");
            d6Amt.ResetText();
            d6Amt.AppendText("0");
            d8Amt.ResetText();
            d8Amt.AppendText("0");
            d10Amt.ResetText();
            d10Amt.AppendText("0");
            d12Amt.ResetText();
            d12Amt.AppendText("0");
            d20Amt.ResetText();
            d20Amt.AppendText("0");
            d2Mod.ResetText();
            d2Mod.AppendText("0");
            d4Mod.ResetText();
            d4Mod.AppendText("0");
            d6Mod.ResetText();
            d6Mod.AppendText("0");
            d8Mod.ResetText();
            d8Mod.AppendText("0");
            d10Mod.ResetText();
            d10Mod.AppendText("0");
            d12Mod.ResetText();
            d12Mod.AppendText("0");
            d20Mod.ResetText();
            d20Mod.AppendText("0");
        }
        private void rollBut_Click(object sender, EventArgs e)
        {
            callRoll();
        }
        private void d2Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d4Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d6Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d8Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d10Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d12Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d20Amt_TextChanged(object sender, EventArgs e)
        {

        }
        private void d2Mod_TextChanged(object sender, EventArgs e)
        {

        }
        private void d4Mod_TextChanged(object sender, EventArgs e)
        {

        }
        private void d6Mod_TextChanged(object sender, EventArgs e)
        {

        }
        private void d8Mod_TextChanged(object sender, EventArgs e)
        {

        }
        private void d10Mod_TextChanged(object sender, EventArgs e)
        {

        }
        private void d12Mod_TextChanged(object sender, EventArgs e)
        {

        }
        private void d20Mod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}