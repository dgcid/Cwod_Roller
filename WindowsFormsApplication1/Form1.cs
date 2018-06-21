using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class cWOD_Roller : Form
    {
        

        public cWOD_Roller()
        {
            InitializeComponent();
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
        
        private void Str_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stam_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void combatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Bite//
        private void button1_Click(object sender, EventArgs e)

        {
            Random Roll = new Random();

            // Attributes //
            int Str = Convert.ToInt32(Str_Box.Text);
            int Dex = Convert.ToInt32(Dex_Box.Text);
            int Stam = Convert.ToInt32(Stam_Box.Text);
            int Char = Convert.ToInt32(Char_Box.Text);
            int Mani = Convert.ToInt32(Man_box.Text);
            int appear = Convert.ToInt32(Appear_Box.Text);
            int Intel = Convert.ToInt32(Intel_box.Text);
            int Perc = Convert.ToInt32(Per_Box.Text);
            int Wit = Convert.ToInt32(Wits_box.Text);

            // Abilites // 
            int Alert = Convert.ToInt32(Alert_Box.Text);
            int Ath = Convert.ToInt32(Ath_Box.Text);
            int Brawl = Convert.ToInt32(Brawl_Box.Text);
            int Dodge = Convert.ToInt32(Dodge_Box.Text);
            int Emp = Convert.ToInt32(Emp_Box.Text);
            int Express = Convert.ToInt32(Express_Box.Text);
            int Intim = Convert.ToInt32(Intim_Box.Text);
            int Lead = Convert.ToInt32(Lead_Box.Text);
            int Street = Convert.ToInt32(Street_Box.Text);
            int Sub = Convert.ToInt32(Subt_Box.Text);
            int AniK = Convert.ToInt32(AK_Box.Text);
            int Craft = Convert.ToInt32(Crafts_box.Text);
            int Drive = Convert.ToInt32(Drive_Box.Text);
            int Eti = Convert.ToInt32(Eti_Box.Text);
            int FireA = Convert.ToInt32(Fire_Box.Text);
            int Melee = Convert.ToInt32(Mel_Box.Text);
            int Perf = Convert.ToInt32(Perf_Box.Text);
            int Sec = Convert.ToInt32(Sec_box.Text);
            int Steal = Convert.ToInt32(Stealth_Box.Text);
            int Surv = Convert.ToInt32(Surv_Box.Text);
            int Acad = Convert.ToInt32(Ac_Box.Text);
            int Comp = Convert.ToInt32(Com_Box.Text);
            int Fin = Convert.ToInt32(Fin_Box.Text);
            int Invest = Convert.ToInt32(Invest_Box.Text);
            int Law = Convert.ToInt32(Law_Box.Text);
            int Ling = Convert.ToInt32(Ling_Box.Text);
            int Med = Convert.ToInt32(Med_Box.Text);
            int Occ = Convert.ToInt32(Occ_Box.Text);
            int Poli = Convert.ToInt32(Poli_Box.Text);
            int Sci = Convert.ToInt32(Sci_Box.Text);
            // Difficulty //
            int Diff = Convert.ToInt32(Diff_Box.Text);

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


            for (int roll = 1; roll <= Str + Dex + 1; ++roll)
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
                        break;
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                    case 8:
                        break;
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

                if (Success >= Fail)
                {
                    Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                }
                else
                {
                    Numbers.Text = Convert.ToString("Fail");
                }
            }

        }

        //Punch//
        private void button2_Click(object sender, EventArgs e)
        {
            {
                Random Roll = new Random();

                // Attributes //
                int Str = Convert.ToInt32(Str_Box.Text);
                int Dex = Convert.ToInt32(Dex_Box.Text);
                int Stam = Convert.ToInt32(Stam_Box.Text);
                int Char = Convert.ToInt32(Char_Box.Text);
                int Mani = Convert.ToInt32(Man_box.Text);
                int appear = Convert.ToInt32(Appear_Box.Text);
                int Intel = Convert.ToInt32(Intel_box.Text);
                int Perc = Convert.ToInt32(Per_Box.Text);
                int Wit = Convert.ToInt32(Wits_box.Text);

                // Abilites // 
                int Alert = Convert.ToInt32(Alert_Box.Text);
                int Ath = Convert.ToInt32(Ath_Box.Text);
                int Brawl = Convert.ToInt32(Brawl_Box.Text);
                int Dodge = Convert.ToInt32(Dodge_Box.Text);
                int Emp = Convert.ToInt32(Emp_Box.Text);
                int Express = Convert.ToInt32(Express_Box.Text);
                int Intim = Convert.ToInt32(Intim_Box.Text);
                int Lead = Convert.ToInt32(Lead_Box.Text);
                int Street = Convert.ToInt32(Street_Box.Text);
                int Sub = Convert.ToInt32(Subt_Box.Text);
                int AniK = Convert.ToInt32(AK_Box.Text);
                int Craft = Convert.ToInt32(Crafts_box.Text);
                int Drive = Convert.ToInt32(Drive_Box.Text);
                int Eti = Convert.ToInt32(Eti_Box.Text);
                int FireA = Convert.ToInt32(Fire_Box.Text);
                int Melee = Convert.ToInt32(Mel_Box.Text);
                int Perf = Convert.ToInt32(Perf_Box.Text);
                int Sec = Convert.ToInt32(Sec_box.Text);
                int Steal = Convert.ToInt32(Stealth_Box.Text);
                int Surv = Convert.ToInt32(Surv_Box.Text);
                int Acad = Convert.ToInt32(Ac_Box.Text);
                int Comp = Convert.ToInt32(Com_Box.Text);
                int Fin = Convert.ToInt32(Fin_Box.Text);
                int Invest = Convert.ToInt32(Invest_Box.Text);
                int Law = Convert.ToInt32(Law_Box.Text);
                int Ling = Convert.ToInt32(Ling_Box.Text);
                int Med = Convert.ToInt32(Med_Box.Text);
                int Occ = Convert.ToInt32(Occ_Box.Text);
                int Poli = Convert.ToInt32(Poli_Box.Text);
                int Sci = Convert.ToInt32(Sci_Box.Text);
                // Difficulty //
                int Diff = Convert.ToInt32(Diff_Box.Text);

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


                for (int roll = 1; roll <= Brawl + Dex; ++roll)
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
                            break;
                            if (7 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                        case 8:
                            break;
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

                    if (Success >= Fail)
                    {
                        Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                    }
                    else
                    {
                        Numbers.Text = Convert.ToString("Fail");
                    }
                }

            }
        }
       
        //Kiss//
        private void button3_Click(object sender, EventArgs e)
        {
            {
                Random Roll = new Random();

                // Attributes //
                int Str = Convert.ToInt32(Str_Box.Text);
                int Dex = Convert.ToInt32(Dex_Box.Text);
                int Stam = Convert.ToInt32(Stam_Box.Text);
                int Char = Convert.ToInt32(Char_Box.Text);
                int Mani = Convert.ToInt32(Man_box.Text);
                int appear = Convert.ToInt32(Appear_Box.Text);
                int Intel = Convert.ToInt32(Intel_box.Text);
                int Perc = Convert.ToInt32(Per_Box.Text);
                int Wit = Convert.ToInt32(Wits_box.Text);

                // Abilites // 
                int Alert = Convert.ToInt32(Alert_Box.Text);
                int Ath = Convert.ToInt32(Ath_Box.Text);
                int Brawl = Convert.ToInt32(Brawl_Box.Text);
                int Dodge = Convert.ToInt32(Dodge_Box.Text);
                int Emp = Convert.ToInt32(Emp_Box.Text);
                int Express = Convert.ToInt32(Express_Box.Text);
                int Intim = Convert.ToInt32(Intim_Box.Text);
                int Lead = Convert.ToInt32(Lead_Box.Text);
                int Street = Convert.ToInt32(Street_Box.Text);
                int Sub = Convert.ToInt32(Subt_Box.Text);
                int AniK = Convert.ToInt32(AK_Box.Text);
                int Craft = Convert.ToInt32(Crafts_box.Text);
                int Drive = Convert.ToInt32(Drive_Box.Text);
                int Eti = Convert.ToInt32(Eti_Box.Text);
                int FireA = Convert.ToInt32(Fire_Box.Text);
                int Melee = Convert.ToInt32(Mel_Box.Text);
                int Perf = Convert.ToInt32(Perf_Box.Text);
                int Sec = Convert.ToInt32(Sec_box.Text);
                int Steal = Convert.ToInt32(Stealth_Box.Text);
                int Surv = Convert.ToInt32(Surv_Box.Text);
                int Acad = Convert.ToInt32(Ac_Box.Text);
                int Comp = Convert.ToInt32(Com_Box.Text);
                int Fin = Convert.ToInt32(Fin_Box.Text);
                int Invest = Convert.ToInt32(Invest_Box.Text);
                int Law = Convert.ToInt32(Law_Box.Text);
                int Ling = Convert.ToInt32(Ling_Box.Text);
                int Med = Convert.ToInt32(Med_Box.Text);
                int Occ = Convert.ToInt32(Occ_Box.Text);
                int Poli = Convert.ToInt32(Poli_Box.Text);
                int Sci = Convert.ToInt32(Sci_Box.Text);
                // Difficulty //
                int Diff = Convert.ToInt32(Diff_Box.Text);

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


                for (int roll = 1; roll <= Brawl + Dex + 1; ++roll)
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
                            break;
                            if (7 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                        case 8:
                            break;
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

                    if (Success >= Fail)
                    {
                        Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                    }
                    else
                    {
                        Numbers.Text = Convert.ToString("Fail");
                    }
                }

            }
        }
        //Claw//
        private void button4_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Brawl + Dex; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

       // Clinch//
        private void button5_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Brawl + Str; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Disarm//
        private void button8_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Melee + Dex; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //hold//
        private void button7_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Brawl + Str; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Kick
        private void button6_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Brawl; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }
       
        //Leg Sweep//
        private void button13_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Brawl + Dex; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Tackle//
        private void button11_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Brawl + Str; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Weapon Strike//
        private void button10_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Per_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

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


                    for (int roll = 1; roll <= Melee + Dex; ++roll)
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
                                break;
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                            case 8:
                                break;
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

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }
    }


 }


// Extra //
//for (int roll = 1; roll <= Str; ++roll);
//int randomNumber = Roll.Next(1, Convert.ToInt32(10) + 1);
//            if (randomNumber >= Diff)
//            {
//                Numbers.Text = Convert.ToString( "{0}  " + face);
//            }
//            else
//            {
//                Numbers.Text = Convert.ToString("Fail");
//            } 