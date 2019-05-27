using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] TList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        int countTime = 0;
        String selectedTea = "";
        int minute = 0;
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < this.TList.Length; i++)
            {
                this.cbTea.Items.Add(this.TList[i]);
            }
            this.selectedTea = this.cbTea.Text;

            if (this.TList.Length > 0)
            {
                this.cbTea.SelectedIndex = 0;
            }
        }

        private void CbTea_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectedTea = this.cbTea.Text;

            InputValue();

        }

        private void InputValue()
        {
            if (selectedTea.Equals("홍차") || this.cbTea.Text.Equals("국화차"))
            {
                this.lblCount.Text = "2분";
                this.countTime = 10;
            }
            else if (selectedTea.Equals("녹차"))
            {
                this.lblCount.Text = "3분";
                this.countTime = 60 * 60 * 3;
            }
            else if (selectedTea.Equals("루이보스차"))
            {
                this.lblCount.Text = "5분";
                this.countTime = 60 * 60 * 5;
            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.countTime < 1)
            {
                this.timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                InputValue();
                this.cbTea.Focus();
            }
            else
            {
                this.countTime--;
                this.minute = countTime / (60 * 60);
                this.second = countTime % 60;

                this.lblCount.Text = minute + "분 " + second + "초 남았습니다!";

            }
        }
    }
}
