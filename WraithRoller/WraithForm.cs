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

namespace WraithRoller
{
    public partial class WraithForm : Form
    {
        XmlSerializer xs;
        List<Information> ls;

        public WraithForm()
        {
            InitializeComponent();

            ls = new List<Information>();
            xs = new XmlSerializer(typeof(List<Information>));
        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            Wraithstart.Visible = true;
        }


        private void LoadButton_Click(object sender, EventArgs e)
        {
            Wraithstart.Visible = true;
            openFileDialog1.InitialDirectory = @"I:\Projects\Cwod_Roller\WraithRoller\bin\Debug\Save";
            openFileDialog1.Filter = "Xml Files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                Information I = new Information();
                XmlLoad<Information> loadinfo = new XmlLoad<Information>();

                I = loadinfo.LoadData(openFileDialog1.FileName);
                WraStrBox.Text = Convert.ToString(I.Wrastr);
                WraDexBox.Text = Convert.ToString(I.Wradex);
                wraStamBox.Text = Convert.ToString(I.Wrastam);
                WraCharBox.Text = Convert.ToString(I.Wrachar);
                WraManiBox.Text = Convert.ToString(I.wraman);
                WraAppBox.Text = Convert.ToString(I.wraapp);
                WraIntBox.Text = Convert.ToString(I.wraintel);
                WraPercBox.Text = Convert.ToString(I.wraperc);
                WraWitsbox.Text = Convert.ToString(I.wrawits);
                WraAlertBox.Text = Convert.ToString(I.wraalert);
                WraAthBox.Text = Convert.ToString(I.wraath);
                WraAwBox.Text = Convert.ToString(I.wraawa);
                WraBraBox.Text = Convert.ToString(I.wrabra);
                WraDodBox.Text = Convert.ToString(I.wradod);
                WraEmpBox.Text = Convert.ToString(I.wraemp);
                WraExpBox.Text = Convert.ToString(I.wraexp);
                WraIntimBox.Text = Convert.ToString(I.wrainti);
                WraStreetBox.Text = Convert.ToString(I.wrastreet);
                WraSubbox.Text = Convert.ToString(I.wrasubt);
                WraCraBox.Text = Convert.ToString(I.wracraft);
                WraDrvBox.Text = Convert.ToString(I.wradrive);
                WraEtiBox.Text = Convert.ToString(I.wraeti);
                WraFABox.Text = Convert.ToString(I.wrafa);
                WraLeadBox.Text = Convert.ToString(I.wralead);
                WraMeditBox.Text = Convert.ToString(I.wramedit);
                WraMelBox.Text = Convert.ToString(I.wramel);
                WraPerfBox.Text = Convert.ToString(I.wraperf);
                WraSecBox.Text = Convert.ToString(I.wrasec);
                WraStealbox.Text = Convert.ToString(I.wrasteal);
                WraAcadBox.Text = Convert.ToString(I.wraacad);
                WraCompBox.Text = Convert.ToString(I.wracomp);
                WraEngBox.Text = Convert.ToString(I.wraenig);
                WraInvestBox.Text = Convert.ToString(I.wrainvest);
                WraLawbox.Text = Convert.ToString(I.wralaw);
                WraLingbox.Text = Convert.ToString(I.wraling);
                WraMedBox.Text = Convert.ToString(I.wramed);
                WraOccBox.Text = Convert.ToString(I.wraocc);
                WraPolibox.Text = Convert.ToString(I.wrapoli);
                WraScibox.Text = Convert.ToString(I.wrasci);
                WraPathosBox.Text = Convert.ToString(I.wrapathos);
                WraCurPathNum.Text = Convert.ToString(I.wracurpathos);
                WraithCorpusBox.Text = Convert.ToString(I.corpus);
                WraCurCorpNum.Text = Convert.ToString(I.wracurcorp);
                WraMWillBox.Text = Convert.ToString(I.wraMaxWill);
                WraCurWillNum.Text = Convert.ToString(I.wraWill);
                WraithNameBox.Text = Convert.ToString(I.wraName);
                WraithLifeBox.Text = Convert.ToString(I.wraLife);
                WraithDeathBox.Text = Convert.ToString(I.wraDeath);
            }
            

          
        }

        //Wraith Save
        private void wraSaveButt_Click_1(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"I:\Projects\Cwod_Roller\WraithRoller\bin\Debug\Save";
            saveFileDialog1.Filter = "Xml Files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Information i = new Information();


                //Save Attributes

                i.Wrastr = int.Parse(WraStrBox.Text);
                i.Wradex = int.Parse(WraDexBox.Text);
                i.Wrastam = int.Parse(wraStamBox.Text);
                i.Wrachar = int.Parse(WraCharBox.Text);
                i.wraman = int.Parse(WraManiBox.Text);
                i.wraapp = int.Parse(WraAppBox.Text);
                i.wraintel = int.Parse(WraIntBox.Text);
                i.wraperc = int.Parse(WraPercBox.Text);
                i.wrawits = int.Parse(WraWitsbox.Text);

                i.wraalert = int.Parse(WraAlertBox.Text);
                i.wraath = int.Parse(WraAthBox.Text);
                i.wrabra = int.Parse(WraBraBox.Text);
                i.wradod = int.Parse(WraDodBox.Text);
                i.wraemp = int.Parse(WraEmpBox.Text);
                i.wraexp = int.Parse(WraExpBox.Text);
                i.wrainti = int.Parse(WraIntimBox.Text);
                i.wralead = int.Parse(WraLeadBox.Text);
                i.wrastreet = int.Parse(WraStreetBox.Text);
                i.wrasubt = int.Parse(WraSubbox.Text);
                i.wracraft = int.Parse(WraCraBox.Text);
                i.wradrive = int.Parse(WraDrvBox.Text);
                i.wraeti = int.Parse(WraEtiBox.Text);
                i.wrafa = int.Parse(WraFABox.Text);
                i.wramel = int.Parse(WraMelBox.Text);
                i.wraperf = int.Parse(WraPerfBox.Text);
                i.wrasec = int.Parse(WraSecBox.Text);
                i.wrasteal = int.Parse(WraStealbox.Text);
                i.wraacad = int.Parse(WraAcadBox.Text);
                i.wracomp = int.Parse(WraCompBox.Text);
                i.wraenig = int.Parse(WraEngBox.Text);
                i.wrainvest = int.Parse(WraInvestBox.Text);
                i.wralaw = int.Parse(WraLawbox.Text);
                i.wraling = int.Parse(WraLingbox.Text);
                i.wramed = int.Parse(WraMedBox.Text);
                i.wraocc = int.Parse(WraOccBox.Text);
                i.wrapoli = int.Parse(WraPolibox.Text);
                i.wrasci = int.Parse(WraScibox.Text);
                i.wrapathos = int.Parse(WraPathosBox.Text);
                i.wracurpathos = int.Parse(WraCurPathNum.Text);
                i.corpus = int.Parse(WraithCorpusBox.Text);
                i.wracurcorp = int.Parse(WraCurCorpNum.Text);
                i.wraName = Convert.ToString(WraithNameBox.Text);
                i.wraLife = Convert.ToString(WraithLifeBox.Text);
                i.wraDeath = Convert.ToString(WraithDeathBox.Text);
                i.wraMaxWill = int.Parse(WraMWillBox.Text);
                i.wraWill = int.Parse(WraCurWillNum.Text);
                XmlSave.SaveData(i, saveFileDialog1.FileName);
                WraithNumbers.Text = Convert.ToString("Save Successful");


            }

        }

        //////////////////
        //Wraith Roller//
        ////////////////

        //Wraith Button
        private void button4_Click(object sender, EventArgs e)
        {
            Wraithstart.Visible = true;
        }

        private void WraStartOver_Click_1(object sender, EventArgs e)
        {
            Wraithstart.Visible = false;
        }

        private void WraithCombatbutt_Click_1(object sender, EventArgs e)
        {
            WraithCombat.Visible = true;
        }

        ////Various Loads
        //Load Pathos Corpus Will
        private void WraithLoadStats_Click_1(object sender, EventArgs e)
        {
            WraCurCorpNum.Text = Convert.ToString(WraithCorpusBox.Text);
            WraCurPathNum.Text = Convert.ToString(WraPathosBox.Text);
            WraCurWillNum.Text = Convert.ToString(WraMWillBox.Text);
        }

        //Initiative rating
        private void WraInitButt_Click_1(object sender, EventArgs e)
        {
            var Dex = Convert.ToInt32(WraDexBox.Text);
            var Wits = Convert.ToInt32(WraWitsbox.Text);
            Random Roll = new Random();
            int Face;
            Face = Roll.Next(1, 11);
            WraInitNum.Text = Convert.ToString(Dex + Wits + Face);
        }

        //Wraith Dodge Rating
        private void WraDodgeRatebutt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(WraDodBox.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);



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

                        if (Success > Fail)
                        {
                            WraDodRateNum.Text = Convert.ToString(Success - Fail);
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        // Wraith Jog / Run Calc
        private void WraCalcButt_Click_1(object sender, EventArgs e)
        {
            var Dex = Convert.ToInt32(WraDexBox.Text);
            WraRunNum.Text = Convert.ToString(Dex + 60);
            WraJogNum.Text = Convert.ToString(Dex + 36);
        }

        //Wraith End turn 
        private void button33_Click_1(object sender, EventArgs e)
        {
            WraActNum.Text = Convert.ToString(0);
        }

        ////Wraith Spend buttons

        //Lose Corpus
        private void WraSpendCorpbutt_Click_1(object sender, EventArgs e)
        {
            var corp = Convert.ToInt32(WraCurCorpNum.Text);
            WraCurCorpNum.Text = Convert.ToString(corp - 1);
        }

        //Wraith jog Button
        private void WraJogbutt_Click_1(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("0.5");
            WraActNum.Text = Convert.ToString(Act);

        }

        //Wraith run button
        private void WraRunButt_Click_1(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
            WraActNum.Text = Convert.ToString(Act);
        }

        //Gain Corpus
        private void GainCorpusbutt_Click_1(object sender, EventArgs e)
        {
            var corp = Convert.ToInt32(WraCurCorpNum.Text);
            WraCurCorpNum.Text = Convert.ToString(corp + 1);
        }

        //Spens Pathos
        private void WraCurPathButt_Click_1(object sender, EventArgs e)
        {
            var pathos = Convert.ToInt32(WraCurPathNum.Text);
            WraCurPathNum.Text = Convert.ToString(pathos - 1);
        }

        private void GainPathButt_Click_1(object sender, EventArgs e)
        {
            var pathos = Convert.ToInt32(WraCurPathNum.Text);
            WraCurPathNum.Text = Convert.ToString(pathos + 1);
        }


        //Use Will
        private void WraSpendWillbutt_Click_1(object sender, EventArgs e)
        {
            var Will = Convert.ToInt32(WraCurWillNum.Text);
            WraCurWillNum.Text = Convert.ToString(Will - 1);
        }


        private void GainWillButt_Click_1(object sender, EventArgs e)
        {
            var Will = Convert.ToInt32(WraCurWillNum.Text);
            WraCurWillNum.Text = Convert.ToString(Will + 1);
        }

       

        ////Close Combat////

        //Flank
        private void WraFlankButt_Click_1(object sender, EventArgs e)
        {
            WraithNumbers.Text = Convert.ToString("You are Flanking enemy add 1 auto success to your next close combat Attack.");
        }


        //Body slam
        private void WraBodSlambutt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                        if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString ("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Grapple
        private void WraGrappleButt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(WraStrBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var Grap = Str + Brawl;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Grap;

                    if (Actions > 0.5)
                    {
                        dicecount = Grap - actionInt;

                    }
                    else
                    {
                        dicecount = Grap;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                        if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Kick
        private void WraKickButt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();



                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);


                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Brawl;

                    if (Actions > 0.5)
                    {
                        dicecount = Brawl - actionInt;

                    }
                    else
                    {
                        dicecount = Brawl;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                                              if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Punch
        private void WraPunchbutt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                        if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Leaping Rake
        private void WraLeapingRake_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                          if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Use Powers
        private void WraUsePowButt_Click_1(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
            WraActNum.Text = Convert.ToString(Act);
        }

        ////Ranged Combat

        //Take Aim
        private void WraAimButt_Click_1(object sender, EventArgs e)
        {
            WraithNumbers.Text = Convert.ToString("You have taken aim add 1 auto success");
        }

        //Auto-Fire
        private void WraAutoFButt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Firea = Convert.ToInt32(WraFABox.Text);
                    var BS = Firea + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS + 10;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt + 10;

                    }
                    else
                    {
                        dicecount = BS + 10;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                        if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Wraith 3rb
        private void Wra3rbbutt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Firea = Convert.ToInt32(WraFABox.Text);
                    var BS = Firea + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS + 2;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt + 2;

                    }
                    else
                    {
                        dicecount = BS + 2;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                         if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dual Wep
        private void WraDualWepButt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Firea = Convert.ToInt32(WraFABox.Text);
                    var BS = Firea + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                         if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        // Wraith Cover
        private void WraCovButt_Click_1(object sender, EventArgs e)
        {
            WraithNumbers.Text = Convert.ToString("you are in cover remind StoryTeller");
        }

        //// Defense Manuevers

        //Block
        private void WraBlockButt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraFABox.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;



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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                        if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Wraith Dodge
        private void WraDodgeButt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Dodge = Convert.ToInt32(WraDodBox.Text);
                    var BS = Dodge + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraFABox.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;



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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                           if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Parry
        private void WraParrybutt_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Melee = Convert.ToInt32(WraMelBox.Text);
                    var BS = Melee + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraFABox.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;



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
                            WraithNumbers.Text = Convert.ToString(Success + " " + "Successes");
                        }
                        else
                              if (Fail - Success > 1)
                        {
                            WraithNumbers.Text = Convert.ToString("Botch");
                        }
                        if (Success <= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Wraith Soak
        private void WraSoakButt_Click_1(object sender, EventArgs e)
        {
            var Arm = Convert.ToInt32(WraArmBox.Text);
            var Stam = Convert.ToInt32(wraStamBox.Text);
            var Dmg = Convert.ToInt32(WraDamagebox.Text);
            var Soak = Arm + Stam;
            var Damagetaken = Dmg - Soak;
            if (Damagetaken <= 0)
            {
                WraithNumbers.Text = Convert.ToString("No Damage");

            }
            else
            if (Damagetaken > 0)
            {
                WraithNumbers.Text = Convert.ToString("You take" + " " + Damagetaken + " " + "Damage");

            }
        }




        private void wraithSocButt_Click_1(object sender, EventArgs e)
        {
            //wraith Social todo list
            ////Physical Feats////
            //Climbing (Dex + Ath)
            //Driving (Dex + Drive)
            //Encumbrance (Str)
            //Hunting (Perception)
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
            //Fast-Talk (Manipulation + Subterfuge)
            //Interrogation (Manipulation + Intimidation)
            //Intimidation (Str + Intimidation)
            //Oration (Charisma + Leadership)
            //Performance (Charisma + Performance)


        }

        private void WraBackButt_Click_1(object sender, EventArgs e)
        {
            WraithCombat.Visible = false;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

       
    }
}
