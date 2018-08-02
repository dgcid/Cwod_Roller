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

namespace AngelRoller
{

    public partial class AngelForm : Form
    {
        XmlSerializer xs;
        List<Information> ls;
        public AngelForm()
        {
            InitializeComponent();
            ls = new List<Information>();
            xs = new XmlSerializer(typeof(List<Information>));

        }

        private void NewPlayerButt_Click(object sender, EventArgs e)
        {
            DemonStart.Visible = true;
        }

        private void LoadPlayerButt_Click(object sender, EventArgs e)
        {
            if (File.Exists("...\\Demon.Xml"))
            {
                // Load Demon Boxes

                DemonStart.Visible = true;
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream fs = new FileStream("...\\Demon.Xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information I = (Information)xs.Deserialize(fs);

                DemStrBox.Text = Convert.ToString(I.DemStr);
                DemDexBox.Text = Convert.ToString(I.DemDex);
                DemStamBox.Text = Convert.ToString(I.DemStam);
                DemCharBox.Text = Convert.ToString(I.DemChar);
                DemManBox.Text = Convert.ToString(I.DemMan);
                DemAppBox.Text = Convert.ToString(I.DemApp);
                DemIntBox.Text = Convert.ToString(I.DemIntel);
                DemPercBox.Text = Convert.ToString(I.DemPerc);
                DemWitsBox.Text = Convert.ToString(I.DemWits);
                DemCurHealthNum.Text = Convert.ToString(I.DemHp);
                DemHealthStatus.Text = Convert.ToString(I.DemHStatus);
                DemonCurHealthNeg.Text = Convert.ToString(I.DemHNeg);
                MaxDemWillBox.Text = Convert.ToString(I.DemWill);
                DemCurWillNum.Text = Convert.ToString(I.DemCurWill);
                MaxFaithBox.Text = Convert.ToString(I.DemFaith);
                CurFaithNum.Text = Convert.ToString(I.DemCurFaith);
                HouseBox.Text = Convert.ToString(I.DemHouse);
                FactionTextBox.Text = Convert.ToString(I.DemFaction);
                DemonNameBox.Text = Convert.ToString(I.DemName);
                VisageBox.Text = Convert.ToString(I.DemVis);
                DemonConvBox.Text = Convert.ToString(I.DemConv);
                DemonConsBox.Text = Convert.ToString(I.DemCons);
                DemCourBox.Text = Convert.ToString(I.DemCour);

                fs.Close();

            }
        }
        

        //Demon Start Over
        private void button59_Click_1(object sender, EventArgs e)
        {

            DemonStart.Visible = false;
        }

        //Demon Social Button
        private void button23_Click_2(object sender, EventArgs e)
        {
            DemonSocial.Visible = true;
            /////// Demon Social Feats To Do List //////

            ////Physical Feats////
            //Climbing (Dex + Ath)
            //Driving (Dex + Drive)
            //Encumbrance (Str)
            //Intrusion (Dexterity + SecurityLabel)
            //Jumping (Str)
            //Run Jump (Str + Ath)
            //Lifting (Str)
            //Open/Close (Str)
            //Pursuit (Dexterity + Athletics)
            //Shadowing ( Dexterity + Stealth)
            //Sneaking (Dexterity + Stealth)
            //Swimming (Stamina + Athletics)
            //Throwing (Dexterity + Athletics)

            ////Mental feats////
            //Awakening (Perception)
            //Creation  (Crafts + Manipulation)
            //Hacking (Wits + Computer)
            //Investigation (Perception + Investigation)
            //Repair (Dexterity + Crafts)
            //Academic Research (Intelligence + Academics)
            //Occult Research (Intelligence + Occult)
            //Science Research (Intelligence + Science)
            //Tracking (Perception + Survival)

            //// Social Feats ////
            //Carousing (Charisma + Empathy)
            //Credibility (Manipulation + Subterfuge)

            //Interrogation (Manipulation + Intimidation)
            //Intimidation (Str + Intimidation)
            //Oration (Charisma + Leadership)
            //Performance (Charisma + Performance)

        }

        //Demon Save Button
        private void button24_Click_2(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("...\\Demon.xml", FileMode.Create, FileAccess.Write);
            Information i = new Information();
            //Save Attributes
            i.DemStr = int.Parse(DemStrBox.Text);
            i.DemDex = int.Parse(DemDexBox.Text);
            i.DemStam = int.Parse(DemStamBox.Text);
            i.DemChar = int.Parse(DemCharBox.Text);
            i.DemMan = int.Parse(DemManBox.Text);
            i.DemApp = int.Parse(DemAppBox.Text);
            i.DemIntel = int.Parse(DemIntBox.Text);
            i.DemPerc = int.Parse(DemPercBox.Text);
            i.DemWits = int.Parse(DemWitsBox.Text);

            i.DemFaith = int.Parse(MaxFaithBox.Text);
            i.DemCurFaith = int.Parse(CurFaithNum.Text);
            i.DemWill = int.Parse(MaxDemWillBox.Text);
            i.DemCurWill = int.Parse(DemCurWillNum.Text);
            i.DemHp = int.Parse(DemCurHealthNum.Text);
            i.DemHStatus = Convert.ToString(DemHealthStatus.Text);
            i.DemHNeg = int.Parse(DemonCurHealthNeg.Text);
            i.DemName = Convert.ToString(DemonNameBox.Text);
            i.DemFaction = Convert.ToString(FactionTextBox.Text);
            i.DemVis = Convert.ToString(VisageBox.Text);
            i.DemHouse = Convert.ToString(HouseBox.Text);
            ls.Add(i);
            xs.Serialize(fs, ls);
            DemNumbers.Text = Convert.ToString("Save successful");
            fs.Close();


        }


        //Close Combat//

        //Dem Clinch
        private void DemClinchbutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    var Str = Convert.ToInt32(DemStrBox.Text);

                    // Abilites // 

                    var Brawl = Convert.ToInt32(FaithRollBox.Text);
                    var Clinch = Str + Brawl;
                    // Difficulty //
                    var Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Clinch + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Clinch - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Clinch + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                        if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                        if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Dem Disarm
        private void button52_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(FaithRollBox.Text);
                    var Disarm = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Disarm + NegHealth + 1;

                    if (Actions > 0.5)
                    {
                        dicecount = Disarm - actionInt + NegHealth + 1;

                    }
                    else
                    {
                        dicecount = Disarm + NegHealth + 1;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                          if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                          if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Dem Hold
        private void button51_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(DemStrBox.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(FaithRollBox.Text);
                    var hold = Str + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = hold + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = hold - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = hold + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                         if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                         if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Dem Kick
        private void DemKickButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Abilites // 
                    int Brawl = Convert.ToInt32(FaithRollBox.Text);

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Brawl + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Brawl - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Brawl + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                          if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                          if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Dem Punch
        private void button56_Click(object sender, EventArgs e)
        {
            {
                Random Roll = new Random();

                // Attributes //
                var Dex = Convert.ToInt32(DemDexBox.Text);

                // Abilites // 
                var Brawl = Convert.ToInt32(FaithRollBox.Text);
                var Punch = (Dex + Brawl);

                // Difficulty //
                int Diff = Convert.ToInt32(DemDiffBox.Text);
                var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                var Actions = Convert.ToDouble(DemActNum.Text);
                var actionDec = Convert.ToDecimal("1.5");
                var actionInt = Convert.ToInt32(Math.Floor(Actions));
                var dicecount = Punch + NegHealth;

                if (Actions > 0.5)
                {
                    dicecount = Punch - actionInt + NegHealth;

                }
                else
                {
                    dicecount = Punch + NegHealth;
                }



                // Face Storage //
                int Face;

                //Success counter//
                int Success = 0;
                int Fail = 0;

                //Actual Roll
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
                                //--Success;
                                // ++Fail;
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

                    ////Ensures that lists are working properly//
                    // Numbers.Text = Convert.ToString("S" + Success + " " + "F" + Fail );


                    if (Success > Fail)
                    {
                        DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                    }
                    else
                           if (Success <= Fail)
                    {
                        DemNumbers.Text = Convert.ToString("Fail");
                    }
                    else
                           if (Fail - Success > 0)
                    {
                        DemNumbers.Text = Convert.ToString("Botch");
                    }
                }
                var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                DemActNum.Text = Convert.ToString(Act);
                var faith = Convert.ToInt32(CurFaithNum.Text);
                var negfaith = Convert.ToInt32(FaithRollBox.Text);
                CurFaithNum.Text = Convert.ToString(faith - negfaith);
            }
        }


        //Dem Sweep
        private void DemLegSweepButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(FaithRollBox.Text);
                    var Sweep = Dex + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Sweep + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Sweep - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Sweep + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                                               if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                                               if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Dem Tackle
        private void DemTackleButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(DemStrBox.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(FaithRollBox.Text);
                    var Tackle = Brawl + Str;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Tackle + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Tackle - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Tackle + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                         if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                         if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Dem Weapon Stirke
        private void DemWSButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(FaithRollBox.Text);
                    var WS = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = WS + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = WS - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = WS + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                         if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                         if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Demon Use Power
        private void DemUseButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
            DemActNum.Text = Convert.ToString(Act);
        }

        //Ranged Combat//

        // Dem Aim
        private void button45_Click(object sender, EventArgs e)
        {
            DemNumbers.Text = "You have taken Aim Add 1 Success to next Ranged Attack";
        }

        //Dem Auto-Fire
        private void button44_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(FaithRollBox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                       if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                        else
                       if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }

        //Dem Cover
        private void button43_Click(object sender, EventArgs e)
        {
            DemNumbers.Text = Convert.ToString("You are in cover remind storyteller add 1 success to next Ranged Attack");

        }

        //Dem Reload
        private void DemReload_Click(object sender, EventArgs e)
        {
            DemNumbers.Text = Convert.ToString("Reloading your Arms");
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
            DemActNum.Text = Convert.ToString(Act);
        }

        //Dem Strafe
        private void DemStrafing_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(FaithRollBox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                        if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                        if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }

                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }

        //Dem 3RB
        private void button42_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int FireA = Convert.ToInt32(FaithRollBox.Text);
                    var Auto = FireA = Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                         if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                         if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }

        //Dem Dual-Weapons
        private void button41_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites // 
                    int FireA = Convert.ToInt32(FaithRollBox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
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
                                if (10 >= Diff + 2)
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                          if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                          if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                    var faith = Convert.ToInt32(CurFaithNum.Text);
                    var negfaith = Convert.ToInt32(FaithRollBox.Text);
                    CurFaithNum.Text = Convert.ToString(faith - negfaith);
                }
            }
        }


        //Defense Controls//

        //Dem Block
        private void DemBlockButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);
                    // Abilites // 
                    int Brawl = Convert.ToInt32(FaithRollBox.Text);
                    var Block = Dex + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                          if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                          if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }

                }
            }
        }

        //Dem Parry
        private void DemParButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(FaithRollBox.Text);
                    var parry = Dex + Melee;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var dicecount = parry + NegHealth;

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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                           if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                           if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }
                    }

                }
            }
        }

        //Dem Dodge
        private void DemDodButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(FaithRollBox.Text);
                    var Dod = Dex + Dodge;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var dicecount = Dod + NegHealth;
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
                            DemNumbers.Text = Convert.ToString(Success + " " + "Successes");

                        }
                        else
                            if (Success <= Fail)
                        {
                            DemNumbers.Text = Convert.ToString("Fail");

                        }
                        else
                            if (Fail - Success > 0)
                        {
                            DemNumbers.Text = Convert.ToString("Botch");
                        }

                    }

                }
            }
        }


        //Dem Soak
        private void DemSoakButt_Click(object sender, EventArgs e)
        {
            //  Damage Box - Soak
            var Arm = Convert.ToInt32(DemArmBox.Text);
            var Stam = Convert.ToInt32(DemStamBox.Text);
            var Dmg = Convert.ToInt32(DDTBox.Text);
            var Health = Convert.ToInt32(DemCurHealthNum.Text);
            var Soak = Arm + Stam;
            var Damagetaken = Dmg - Soak;
            var ExistingDamage = Health + Damagetaken;

            switch (Damagetaken)
            {
                case 0:
                    if (Damagetaken <= 0)
                    {
                        DemNumbers.Text = Convert.ToString("No Damage");

                    }
                    break;
                case 1:
                    if (Damagetaken == 1)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 2:
                    if (Damagetaken == 2)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 3:
                    if (Damagetaken == 3)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 4:
                    if (Damagetaken == 4)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 5:
                    if (Damagetaken == 5)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 6:
                    if (Damagetaken == 6)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 7:
                    if (Damagetaken == 7)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 8:
                    if (Damagetaken == 8)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 9:
                    if (Damagetaken == 9)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 10:
                    if (Damagetaken == 10)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 11:
                    if (Damagetaken == 11)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 12:
                    if (Damagetaken == 12)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 13:
                    if (Damagetaken == 13)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 14:
                    if (Damagetaken >= 14)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;

            }
            if (ExistingDamage == 0)
            {
                DemHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 1)
            {
                DemHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 2)
            {
                DemHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 3)
            {
                DemHealthStatus.Text = Convert.ToString("Hurt");
                DemonCurHealthNeg.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 4)
            {
                DemHealthStatus.Text = Convert.ToString("Hurt");
                DemonCurHealthNeg.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 5)
            {
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 6)
            {
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 7)
            {
                DemHealthStatus.Text = Convert.ToString("Wounded");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 8)
            {
                DemHealthStatus.Text = Convert.ToString("Wounded");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 9)
            {
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 10)
            {
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 11)
            {
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString(-5);
            }
            if (ExistingDamage == 12)
            {
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString(-5);
            }
            if (ExistingDamage == 13)
            {
                DemHealthStatus.Text = Convert.ToString("Incapacitated");
                DemonCurHealthNeg.Text = Convert.ToString(-99);
            }
            if (ExistingDamage == 14)
            {
                DemHealthStatus.Text = Convert.ToString("Dead");
                DemonCurHealthNeg.Text = Convert.ToString(-99);
            }
        }


        //Rating Controls

        //Dem Load Various Stats
        private void LoadWTFButt_Click(object sender, EventArgs e)
        {
            DemCurWillNum.Text = MaxDemWillBox.Text;
            CurFaithNum.Text = MaxFaithBox.Text;
        }

        //Dem Spend Will
        private void DemSpendWill_Click(object sender, EventArgs e)
        {
            var Will = Convert.ToInt32(DemCurWillNum.Text);
            DemCurWillNum.Text = Convert.ToString(Will - 1);
        }


        //Dem Spend faith
        private void SpendFaithButt_Click(object sender, EventArgs e)
        {
            var faith = Convert.ToInt32(CurFaithNum.Text);
            CurFaithNum.Text = Convert.ToString(faith - 1);
        }

        //Dem Initiative Rate
        private void DemInitiativeButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();
            int Face;
            int Dex = Convert.ToInt32(DemDexBox.Text);
            int Wit = Convert.ToInt32(DemWitsBox.Text);

            Face = Roll.Next(1, 11);
            DemInitiativeNum.Text = Convert.ToString(Dex + Wit + Face);

            // Dex + Wits + 1 d10 roll
        }


        //Dem Dodge Rate
        private void demDodgeRateButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(FaithRollBox.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);



                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= Dex + Dodge; ++roll)
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

                        if (Success >= Fail)
                        {
                            DemDodgeRateNum.Text = Convert.ToString(Success);
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }


        //Dem Jog/Run Calcukate
        private void DemCalcBox_Click(object sender, EventArgs e)
        {
            int Dex = Convert.ToInt32(DemDexBox.Text);
            DemJogNum.Text = Convert.ToString(Dex + 36);
            DemRunNum.Text = Convert.ToString(Dex + 60);
        }


        //Dem Jog Button
        private void DemJogButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("0.5");
            DemActNum.Text = Convert.ToString(Act);
        }


        //Dem Run button
        private void DemRunbutt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
            DemActNum.Text = Convert.ToString(Act);

        }

        //Dem Heal 1 button (Natural Heal)
        private void Demheal1Butt_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(DemCurHealthNum.Text);



            if (Health == 1)
            {
                DemCurHealthNum.Text = Convert.ToString("0");
                DemHealthStatus.Text = Convert.ToString("Fine");


            }

            if (Health == 2)
            {
                DemCurHealthNum.Text = Convert.ToString("1");
                DemHealthStatus.Text = Convert.ToString("Bruised");

            }
            if (Health == 3)
            {
                DemCurHealthNum.Text = Convert.ToString("2");
                DemHealthStatus.Text = Convert.ToString("Bruised");
                DemonCurHealthNeg.Text = Convert.ToString("0");

            }
            if (Health == 4)
            {
                DemCurHealthNum.Text = Convert.ToString("3");
                DemHealthStatus.Text = Convert.ToString("Hurt");

            }
            if (Health == 5)
            {
                DemCurHealthNum.Text = Convert.ToString("4");
                DemHealthStatus.Text = Convert.ToString("Hurt");

            }
            if (Health == 6)
            {
                DemCurHealthNum.Text = Convert.ToString("5");
                DemHealthStatus.Text = Convert.ToString("Injured");

            }
            if (Health == 7)
            {
                DemCurHealthNum.Text = Convert.ToString("6");
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString("-1");

            }
            if (Health == 8)
            {
                DemCurHealthNum.Text = Convert.ToString("7");
                DemHealthStatus.Text = Convert.ToString("Wounded");

            }
            if (Health == 9)
            {
                DemCurHealthNum.Text = Convert.ToString("8");
                DemHealthStatus.Text = Convert.ToString("Wounded");

            }
            if (Health == 10)
            {
                DemCurHealthNum.Text = Convert.ToString("9");
                DemHealthStatus.Text = Convert.ToString("Mauled");

            }
            if (Health == 11)
            {
                DemCurHealthNum.Text = Convert.ToString("10");
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString("-2");

            }
            if (Health == 12)
            {
                DemCurHealthNum.Text = Convert.ToString("11");
                DemHealthStatus.Text = Convert.ToString("Crippled");

            }
            if (Health == 13)
            {
                DemCurHealthNum.Text = Convert.ToString("12");
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString("-5");

            }


        }


        // Heal All Button
        private void DemHealAllbutt_Click(object sender, EventArgs e)
        {
            DemCurHealthNum.Text = Convert.ToString(0);
            DemHealthStatus.Text = Convert.ToString("Fine");
            DemonCurHealthNeg.Text = Convert.ToString(0);
        }


        //Dem Faith Healing
        private void FaithHealButt_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(DemCurHealthNum.Text);
            var faith = Convert.ToInt32(CurFaithNum.Text);



            if (Health == 1)
            {
                DemCurHealthNum.Text = Convert.ToString("0");
                DemHealthStatus.Text = Convert.ToString("Fine");
                CurFaithNum.Text = Convert.ToString(faith - 1);



            }

            if (Health == 2)
            {
                DemCurHealthNum.Text = Convert.ToString("1");
                DemHealthStatus.Text = Convert.ToString("Bruised");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 3)
            {
                DemCurHealthNum.Text = Convert.ToString("2");
                DemHealthStatus.Text = Convert.ToString("Bruised");
                DemonCurHealthNeg.Text = Convert.ToString("0");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 4)
            {
                DemCurHealthNum.Text = Convert.ToString("3");
                DemHealthStatus.Text = Convert.ToString("Hurt");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 5)
            {
                DemCurHealthNum.Text = Convert.ToString("4");
                DemHealthStatus.Text = Convert.ToString("Hurt");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 6)
            {
                DemCurHealthNum.Text = Convert.ToString("5");
                DemHealthStatus.Text = Convert.ToString("Injured");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 7)
            {
                DemCurHealthNum.Text = Convert.ToString("6");
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString("-1");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 8)
            {
                DemCurHealthNum.Text = Convert.ToString("7");
                DemHealthStatus.Text = Convert.ToString("Wounded");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 9)
            {
                DemCurHealthNum.Text = Convert.ToString("8");
                DemHealthStatus.Text = Convert.ToString("Wounded");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 10)
            {
                DemCurHealthNum.Text = Convert.ToString("9");
                DemHealthStatus.Text = Convert.ToString("Mauled");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 11)
            {
                DemCurHealthNum.Text = Convert.ToString("10");
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString("-2");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 12)
            {
                DemCurHealthNum.Text = Convert.ToString("11");
                DemHealthStatus.Text = Convert.ToString("Crippled");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 13)
            {
                DemCurHealthNum.Text = Convert.ToString("12");
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString("-5");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }


        }


        //Dem End Turn
        private void button31_Click(object sender, EventArgs e)
        {
            DemActNum.Text = Convert.ToString(0);
        }
    }
}