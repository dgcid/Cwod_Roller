using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace HADragonian
{
    public partial class Form1 : Form
    {
        XmlSerializer xs;
        List<Information> ls;
        public Form1()
        {
            InitializeComponent();
            ls = new List<Information>();
            xs = new XmlSerializer(typeof(List<Information>));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dragonstart.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DraStartOver_Click(object sender, EventArgs e)
        {
            Dragonstart.Visible = false;
        }

        private void DragonCombatbutt_Click(object sender, EventArgs e)
        {
            DragonCombat.Visible = true;
        }

        ///////////////////////
        /////Various Loads////
        /////////////////////

        private void DragonLoadStats_Click(object sender, EventArgs e)
        {
            DraCurQuinNum.Text = Convert.ToString(DraMaxQuinBox.Text);
            DraCurMastNum.Text = Convert.ToString(DraMastMaxBox.Text);
            DraCurAncNum.Text = Convert.ToString(DraMaxAncBox.Text);
            DraCurFaithnum.Text = Convert.ToString(MaxFaithNum.Text);
            
        }

        //Spend Anc
        private void DraSpendCorpbutt_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurAncNum.Text);
            DraCurAncNum.Text = Convert.ToString(Anc - 1);
        }

        //Gain Anc
        private void GainCorpusbutt_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurAncNum.Text);
            DraCurAncNum.Text = Convert.ToString(Anc + 1);
        }


        //Spend Mas
        private void DraSpendWillbutt_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurMastNum.Text);
            DraCurMastNum.Text = Convert.ToString(Anc - 1);
        }

        //Gain Mas
        private void GainWillButt_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurMastNum.Text);
            DraCurMastNum.Text = Convert.ToString(Anc + 1);
        }

        //Spend QUin
        private void DraCurQuinButt_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurQuinNum.Text);
            DraCurQuinNum.Text = Convert.ToString(Anc - 1);
        }

        //Gain Quin
        private void GainQUinButt_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurQuinNum.Text);
            DraCurQuinNum.Text = Convert.ToString(Anc + 1);
        }

        //Spend faith
        private void SpendFaith_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurFaithnum.Text);
            DraCurFaithnum.Text = Convert.ToString(Anc - 1);
        }

        //Gain Faith
        private void GainFaith_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraCurFaithnum.Text);
            DraCurFaithnum.Text = Convert.ToString(Anc + 1);
        }

        //Lose Torm
        private void button5_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraTempTormNum.Text);
            DraTempTormNum.Text = Convert.ToString(Anc - 1);

        }

        //Gain Trom
        private void button4_Click(object sender, EventArgs e)
        {
            var Anc = Convert.ToInt32(DraTempTormNum.Text);
            DraTempTormNum.Text = Convert.ToString(Anc + 1);
        }

        private void DraCalcButt_Click(object sender, EventArgs e)
        {
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int fly = Convert.ToInt32(DraFlightBox.Text);
            DraRunNum.Text = Convert.ToString(Dex + 36);
            DraJogNum.Text = Convert.ToString(Dex + 60);
            DraFly.Text = Convert.ToString(15 * fly);
        }

        ///////////////////////
        /////Heal Buttons////
        /////////////////////

        private void Heal1Butt_Click(object sender, EventArgs e)
        { 
        var Health = Convert.ToInt32(CurHealth.Text);

        

            if (Health == 1)
            {
                CurHealth.Text = Convert.ToString("0");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");

            }

            if (Health == 2)
            {
                CurHealth.Text = Convert.ToString("1");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 3)
            {
                CurHealth.Text = Convert.ToString("2");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 4)
            {
                CurHealth.Text = Convert.ToString("3");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 5)
            {
                CurHealth.Text = Convert.ToString("4");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 6)
            {
                CurHealth.Text = Convert.ToString("5");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 7)
            {
                CurHealth.Text = Convert.ToString("6");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 8)
            {
                CurHealth.Text = Convert.ToString("7");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
            }
            if (Health == 9)
            {
                CurHealth.Text = Convert.ToString("8");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
            }
            if (Health == 10)
            {
                CurHealth.Text = Convert.ToString("9");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
            }
            if (Health == 11)
            {
                CurHealth.Text = Convert.ToString("10");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");

            }
            if (Health == 12)
            {
                CurHealth.Text = Convert.ToString("11");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");

            }
            if (Health == 13)
            {
                CurHealth.Text = Convert.ToString("12");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
            }
            if (Health == 14)
            {
                CurHealth.Text = Convert.ToString("13");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");

            }
            if (Health == 15)
            {
                CurHealth.Text = Convert.ToString("14");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");

            }
            if (Health == 16)
            {
                CurHealth.Text = Convert.ToString("15");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 17)
            {
                CurHealth.Text = Convert.ToString("16");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 18)
            {
                CurHealth.Text = Convert.ToString("17");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 19)
            {
                CurHealth.Text = Convert.ToString("18");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 20)
            {
                CurHealth.Text = Convert.ToString("19");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 21)
            {
                CurHealth.Text = Convert.ToString("20");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 22)
            {
                CurHealth.Text = Convert.ToString("21");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 23)
            {
                CurHealth.Text = Convert.ToString("22");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 24)
            {
                CurHealth.Text = Convert.ToString("23");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }
            if (Health == 25)
            {
                CurHealth.Text = Convert.ToString("24");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }
            if (Health == 26)
            {
                CurHealth.Text = Convert.ToString("25");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }
            if (Health == 27)
            {
                CurHealth.Text = Convert.ToString("26");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }
            if (Health == 28)
            {
                CurHealth.Text = Convert.ToString("27");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }
            if (Health == 29)
            {
                CurHealth.Text = Convert.ToString("28");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }
        }

        private void HealAllButt_Click(object sender, EventArgs e)
        {
            CurHealth.Text = Convert.ToString(0);
            CurHealthStatus.Text = Convert.ToString("Fine");
            CurHealthNegative.Text = Convert.ToString(0);
        }

        private void QuinHeal_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(CurHealth.Text);
            var quin = Convert.ToInt32(DraCurQuinNum.Text);




            if (Health == 1)
            {
                CurHealth.Text = Convert.ToString("0");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }

            if (Health == 2)
            {
                CurHealth.Text = Convert.ToString("1");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 3)
            {
                CurHealth.Text = Convert.ToString("2");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 4)
            {
                CurHealth.Text = Convert.ToString("3");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 5)
            {
                CurHealth.Text = Convert.ToString("4");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 6)
            {
                CurHealth.Text = Convert.ToString("5");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 7)
            {
                CurHealth.Text = Convert.ToString("6");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 8)
            {
                CurHealth.Text = Convert.ToString("7");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 9)
            {
                CurHealth.Text = Convert.ToString("8");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 10)
            {
                CurHealth.Text = Convert.ToString("9");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 11)
            {
                CurHealth.Text = Convert.ToString("10");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 12)
            {
                CurHealth.Text = Convert.ToString("11");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 13)
            {
                CurHealth.Text = Convert.ToString("12");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);
            }
            if (Health == 14)
            {
                CurHealth.Text = Convert.ToString("13");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 15)
            {
                CurHealth.Text = Convert.ToString("14");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 16)
            {
                CurHealth.Text = Convert.ToString("15");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 17)
            {
                CurHealth.Text = Convert.ToString("16");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 18)
            {
                CurHealth.Text = Convert.ToString("17");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 19)
            {
                CurHealth.Text = Convert.ToString("18");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 20)
            {
                CurHealth.Text = Convert.ToString("19");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 21)
            {
                CurHealth.Text = Convert.ToString("20");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 22)
            {
                CurHealth.Text = Convert.ToString("21");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 23)
            {
                CurHealth.Text = Convert.ToString("22");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 24)
            {
                CurHealth.Text = Convert.ToString("23");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 25)
            {
                CurHealth.Text = Convert.ToString("24");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 26)
            {
                CurHealth.Text = Convert.ToString("25");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 27)
            {
                CurHealth.Text = Convert.ToString("26");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 28)
            {
                CurHealth.Text = Convert.ToString("27");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
            if (Health == 29)
            {
                CurHealth.Text = Convert.ToString("28");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurQuinNum.Text = Convert.ToString(quin - 1);

            }
        }
    

        private void FaithHealButt_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(CurHealth.Text);
            var faith = Convert.ToInt32(DraCurFaithnum.Text);




            if (Health == 1)
            {
                CurHealth.Text = Convert.ToString("0");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }

            if (Health == 2)
            {
                CurHealth.Text = Convert.ToString("1");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 3)
            {
                CurHealth.Text = Convert.ToString("2");
                CurHealthStatus.Text = Convert.ToString("Fine");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 4)
            {
                CurHealth.Text = Convert.ToString("3");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 5)
            {
                CurHealth.Text = Convert.ToString("4");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 6)
            {
                CurHealth.Text = Convert.ToString("5");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 7)
            {
                CurHealth.Text = Convert.ToString("6");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 8)
            {
                CurHealth.Text = Convert.ToString("7");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 9)
            {
                CurHealth.Text = Convert.ToString("8");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 10)
            {
                CurHealth.Text = Convert.ToString("9");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 11)
            {
                CurHealth.Text = Convert.ToString("10");
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 12)
            {
                CurHealth.Text = Convert.ToString("11");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 13)
            {
                CurHealth.Text = Convert.ToString("12");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);
            }
            if (Health == 14)
            {
                CurHealth.Text = Convert.ToString("13");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 15)
            {
                CurHealth.Text = Convert.ToString("14");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 16)
            {
                CurHealth.Text = Convert.ToString("15");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 17)
            {
                CurHealth.Text = Convert.ToString("16");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 18)
            {
                CurHealth.Text = Convert.ToString("17");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 19)
            {
                CurHealth.Text = Convert.ToString("18");
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 20)
            {
                CurHealth.Text = Convert.ToString("19");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 21)
            {
                CurHealth.Text = Convert.ToString("20");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 22)
            {
                CurHealth.Text = Convert.ToString("21");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 23)
            {
                CurHealth.Text = Convert.ToString("22");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 24)
            {
                CurHealth.Text = Convert.ToString("23");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 25)
            {
                CurHealth.Text = Convert.ToString("24");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 26)
            {
                CurHealth.Text = Convert.ToString("25");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 27)
            {
                CurHealth.Text = Convert.ToString("26");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 28)
            {
                CurHealth.Text = Convert.ToString("27");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 29)
            {
                CurHealth.Text = Convert.ToString("28");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");
                DraCurFaithnum.Text = Convert.ToString(faith - 1);

            }
        }
    

        private void DraJogbutt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("0.5");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraRunButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void FlyButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraInitButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();
            int Face;
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Wit = Convert.ToInt32(DraWitsbox.Text);

            Face = Roll.Next(1, 11);
            DraInitNum.Text = Convert.ToString(Dex + Wit + Face);
        }


        private void DraUsePowButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }

        private void DraBackButt_Click(object sender, EventArgs e)
        {
            DragonCombat.Visible = false;
        }

        private void DragonSocButt_Click(object sender, EventArgs e)
        {
            //later
        }

        private void DraGDustButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Str = Convert.ToInt32(DraStrBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Str;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraGClawbutt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void SqueezeButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraGGitebutt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraWingSlapButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void TripButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraClampBIteButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void TailWhipButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void RollButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraVicShaButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Str = Convert.ToInt32(DraStrBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Str;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void HornAttackButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraBraBox.Text);
            int Bite = Brawl + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void RollMasteryButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Mastery = Convert.ToInt32(DraCurMastNum.Text);

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Mastery + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Mastery - actionInt + NegHealth;

            }
            else
            {
                dicecount = Mastery + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraAimButt_Click(object sender, EventArgs e)
        {
            DragonNumbers.Text = "You have taken Aim add 1 Success to next ranged attack";
        }


        private void Dra3rbbutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DraDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(DraFABox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DraDiffBox.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(DraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 2;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 2;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 2;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //


                        if (Success > Fail)
                        {
                            DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                        if (Success <= Fail)
                        {
                            DragonNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                        if (Fail - Success > 0)
                        {
                            DragonNumbers.Text = Convert.ToString("Botch");
                        }

                    }
                    var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
                    DraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        private void DraAutoFButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DraDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(DraFABox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DraDiffBox.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(DraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 10;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 10;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 10;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //


                        if (Success > Fail)
                        {
                            DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                        if (Success <= Fail)
                        {
                            DragonNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                        if (Fail - Success > 0)
                        {
                            DragonNumbers.Text = Convert.ToString("Botch");
                        }

                    }
                    var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
                    DraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        private void DraDualWepButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DraDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(DraFABox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DraDiffBox.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(DraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //


                        if (Success > Fail)
                        {
                            DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                        if (Success <= Fail)
                        {
                            DragonNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                        if (Fail - Success > 0)
                        {
                            DragonNumbers.Text = Convert.ToString("Botch");
                        }

                    }
                    var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
                    DraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        private void VReloadArmsButt_Click(object sender, EventArgs e)
        {
            DragonNumbers.Text = Convert.ToString("Reloading your Arms");
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }

        private void DraCovButt_Click(object sender, EventArgs e)
        {
            DragonNumbers.Text = Convert.ToString("You are in cover remind storyteller");
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void VStrafing_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DraDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(DraFABox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DraDiffBox.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(DraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 10;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 10;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 10;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //


                        if (Success > Fail)
                        {
                            DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                        if (Success <= Fail)
                        {
                            DragonNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                        if (Fail - Success > 0)
                        {
                            DragonNumbers.Text = Convert.ToString("Botch");
                        }

                    }
                    var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
                    DraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        private void DraADustButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraATailWhip_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraPlummetButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraAClawButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraAHornAttackButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraSnatchButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraABiteButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraGrapplingButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraBackRollButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraAWingSlapButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraDiveAttack_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Flight = Convert.ToInt32(DraFlightBox.Text);
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Bite = Flight + Dex;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth;

            }
            else
            {
                dicecount = Bite + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Mastery = Convert.ToInt32(DraCurMastNum.Text);

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(DraActNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Mastery + NegHealth;

            if (Actions > 0.5)
            {
                dicecount = Mastery - actionInt + NegHealth;

            }
            else
            {
                dicecount = Mastery + NegHealth;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }
            var Act = Convert.ToDecimal(DraActNum.Text) + Convert.ToDecimal("1.0");
            DraActNum.Text = Convert.ToString(Act);
        }


        private void DraBlockButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Brawl = Convert.ToInt32(DraDexBox.Text);
            int Block = Dex + Brawl;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var dicecount = Block + NegHealth;


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }

        }


        private void DraDodgeButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Dodge = Convert.ToInt32(DraDodBox.Text);
            int Block = Dex + Dodge;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var dicecount = Block + NegHealth;


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }

        }


        private void DraParrybutt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Dex = Convert.ToInt32(DraDexBox.Text);
            int Melee = Convert.ToInt32(DraMelBox.Text);
            int Block = Dex + Melee;

            // Difficulty //
            int Diff = Convert.ToInt32(DraDiffBox.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var dicecount = Block + NegHealth;


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //


                if (Success > Fail)
                {
                    DragonNumbers.Text = Convert.ToString(Success + " " + "Successes");

                }
                else
                if (Success <= Fail)
                {
                    DragonNumbers.Text = Convert.ToString("Fail");

                }
                else
                if (Fail - Success > 0)
                {
                    DragonNumbers.Text = Convert.ToString("Botch");
                }

            }

        }


        private void DraSoakButt_Click(object sender, EventArgs e)
        {
            //  Damage Box - Soak
            var Arm = Convert.ToInt32(DraArmBox.Text);
            var Stam = Convert.ToInt32(DraStamBox.Text);
            var Dmg = Convert.ToInt32(DraDamagebox.Text);
            var Health = Convert.ToInt32(CurHealth.Text);
            var Soak = Arm + Stam;
            var Damagetaken = Dmg - Soak;
            var ExistingDamage = Health + Damagetaken;

            switch (Damagetaken)
            {
                case 0:
                    if (Damagetaken <= 0)
                    {
                        DragonNumbers.Text = Convert.ToString("No Damage");

                    }
                    break;
                case 1:
                    if (Damagetaken == 1)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 2:
                    if (Damagetaken == 2)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 3:
                    if (Damagetaken == 3)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 4:
                    if (Damagetaken == 4)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 5:
                    if (Damagetaken == 5)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 6:
                    if (Damagetaken == 6)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 7:
                    if (Damagetaken == 7)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 8:
                    if (Damagetaken == 8)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 9:
                    if (Damagetaken == 9)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 10:
                    if (Damagetaken == 10)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 11:
                    if (Damagetaken == 11)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 12:
                    if (Damagetaken == 12)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 13:
                    if (Damagetaken == 13)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 14:
                    if (Damagetaken == 14)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 15:
                    if (Damagetaken == 15)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 16:
                    if (Damagetaken == 16)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 17:
                    if (Damagetaken == 17)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 18:
                    if (Damagetaken == 18)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 19:
                    if (Damagetaken == 19)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 20:
                    if (Damagetaken == 20)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 21:
                    if (Damagetaken == 21)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 22:
                    if (Damagetaken == 22)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 23:
                    if (Damagetaken == 23)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 24:
                    if (Damagetaken == 24)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 25:
                    if (Damagetaken == 25)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 26:
                    if (Damagetaken == 26)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 27:
                    if (Damagetaken == 27)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 28:
                    if (Damagetaken == 28)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 29:
                    if (Damagetaken == 9)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 30:
                    if (Damagetaken == 30)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;

            }
            if (ExistingDamage == 0)
            {
                CurHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 1)
            {
                CurHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 2)
            {
                CurHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 3)
            {
                CurHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 4)
            {
                CurHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 5)
            {
                CurHealthStatus.Text = Convert.ToString("Bruised");

            }
            if (ExistingDamage == 6)
            {
                CurHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 7)
            {
                CurHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 8)
            {
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 9)
            {
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 10)
            {
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 11)
            {
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 12)
            {
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 13)
            {
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 14)
            {
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 15)
            {
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 16)
            {
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 17)
            {
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 18)
            {
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 19)
            {
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 20)
            {
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 21)
            {
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 22)
            {
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 23)
            {
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString(-2);
                if (ExistingDamage == 24)
                {
                    CurHealthStatus.Text = Convert.ToString("Crippled");
                    CurHealthNegative.Text = Convert.ToString(-5);
                }
                if (ExistingDamage == 25)
                {
                    CurHealthStatus.Text = Convert.ToString("Crippled");
                    CurHealthNegative.Text = Convert.ToString(-5);
                }
                if (ExistingDamage == 26)
                {
                    CurHealthStatus.Text = Convert.ToString("Crippled");
                    CurHealthNegative.Text = Convert.ToString(-5);
                }
                if (ExistingDamage == 27)
                {
                    CurHealthStatus.Text = Convert.ToString("Crippled");
                    CurHealthNegative.Text = Convert.ToString(-5);
                }
                if (ExistingDamage == 28)
                {
                    CurHealthStatus.Text = Convert.ToString("Crippled");
                    CurHealthNegative.Text = Convert.ToString(-5);
                }
                if (ExistingDamage == 29)
                {
                    CurHealthStatus.Text = Convert.ToString("Incapacitated");
                    CurHealthNegative.Text = Convert.ToString(-99);
                    if (ExistingDamage == 30)
                    {
                        CurHealthStatus.Text = Convert.ToString("Dead");
                        CurHealthNegative.Text = Convert.ToString(-99);
                    }
                }
            }
        }


        private void button33_Click(object sender, EventArgs e)
        {
            DraActNum.Text = Convert.ToString(0);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
