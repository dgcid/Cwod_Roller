using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADragonian
{
    public class Information
    {
        //Vampire Fields
        public int Str_Box{ get; set;  }
        public int Dex_Box{ get; set;  }
        public int Stam_Box{ get; set;  }
        public int Char_Box{ get; set;  }
        public int Man_Box{ get; set;  }
        public int Appear_Box{ get; set;  }
        public int intel_Box{ get; set;  }
        public int Per_Box{ get; set;  }
        public int Wits_Box{ get; set;  }

        public int Alert_Box{ get; set;  }
        public int Ath_Box{ get; set;  }
        public int Brawl_Box{ get; set;  }
        public int Dodge_Box{ get; set;  }
        public int Emp_Box{ get; set;  }
        public int Express_Box{ get; set;  }
        public int intim_Box{ get; set;  }
        public int Lead_Box{ get; set;  }
        public int Street_Box{ get; set;  }
        public int Subt_Box{ get; set;  }
        public int AK_Box{ get; set;  }
        public int Crafts_box{ get; set;  }
        public int Drive_Box{ get; set;  }
        public int Eti_Box{ get; set;  }
        public int Fire_Box{ get; set;  }
        public int Mel_Box{ get; set;  }
        public int Perf_Box{ get; set;  }
        public int Sec_box{ get; set;  }
        public int Stealth_Box{ get; set;  }
        public int Surv_Box{ get; set;  }
        public int Ac_Box{ get; set;  }
        public int Com_Box{ get; set;  }
        public int Fin_Box{ get; set;  }
        public int Invest_Box{ get; set;  }
        public int Law_Box{ get; set;  }
        public int Ling_Box{ get; set;  }
        public int Med_Box { get; set; }
        public int Occ_Box{ get; set;  }
        public int Poli_Box{ get; set;  }
        public int Sci_Box{ get; set;  }
        public int Blood { get; set; }
        public int Will { get; set; }
        public int MaxWill { get; set; }
        public int Hp { get; set; }
        public string HStatus { get; set; }
        public int HNeg { get; set; }
        public string Name { get; set; }
        public String Gen { get; set; }
        public String Clan { get; set; }
        public String Sire { get; set; }
        public int Cons { get; set; }
        public int Conv { get; set; }
        public int Cour { get; set; }
        public int Human { get; set; }

        //Demon Fields
        public int DemStr { get; set; }
        public int DemDex { get; set; }
        public int DemStam { get; set; }
        public int DemChar { get; set; }
        public int DemMan { get; set; }
        public int DemApp { get; set; }
        public int DemPerc { get; set; }
        public int DemIntel { get; set; }
        public int DemWits { get; set; }

        public int DemAlert { get; set; }
        public int DemAth { get; set; }
        public int DemDod { get; set; }
        public int DemBrawl { get; set; }
        public int DemEmp { get; set; }
        public int DemExp { get; set; }
        public int DemIntim { get; set; }
        public int DemIntuit { get; set; }
        public int DemLead { get; set; }
        public int Demstreet { get; set; }
        public int DemSubt { get; set; }
        public int DemAK { get; set; }
        public int DemCraft { get; set; }
        public int DemDrive { get; set; }
        public int DemEti { get; set; }
        public int DemFire { get; set; }
        public int DemLarc { get; set; }
        public int DemMel { get; set; }
        public int DemPerf { get; set; }
        public int DemSteal { get; set; }
        public int DemSurv { get; set; }
        public int Demtech { get; set; }
        public int DemAcad { get; set; }
        public int Demcomp { get; set; }
        public int DemFin { get; set; }
        public int DemInvest { get; set; }
        public int DemLaw { get; set; }
        public int DemMed { get; set; }
        public int DemOcc { get; set; }
        public int Dempoli { get; set; }
        public int DemReli { get; set; }
        public int DemRes { get; set; }
        public int DemSci { get; set; }
        public String DemName { get; set; }
        public String DemHouse { get; set; }
        public String DemFaction { get; set; }
        public String DemVis { get; set; }
        public int DemHp { get; set; }
        public string DemHStatus { get; set; }
        public int DemHNeg { get; set; }
        public int DemTorm { get; set; }
        public int DemTempTorm { get; set; }
        public int DemWill { get; set; }
        public int DemCurWill { get; set; }
        public int DemFaith { get; set; }
        public int DemCurFaith { get; set; }
        public int DemCons { get; set; }
        public int DemConv { get; set; }
        public int DemCour { get; set; }


        //Wraith Fields
        public int Wrastr { get; set; }
        public int Wradex { get; set; }
        public int Wrastam { get; set; }
        public int Wrachar { get; set; }
        public int wraman { get; set; }
        public int wraapp { get; set; }
        public int wraperc { get; set; }
        public int wraintel { get; set; }
        public int wrawits { get; set; }

        public int wraalert { get; set; }
        public int wraath { get; set; }
        public int wraawa { get; set; }
        public int wradod { get; set; }
        public int wrabra { get; set; }
        public int wraemp { get; set; }
        public int wraexp { get; set; }
        public int wrainti { get; set; }
        public int wrastreet { get; set; }
        public int wrasubt { get; set; }
        public int wracraft { get; set; }
        public int wradrive { get; set; }
        public int wraeti { get; set; }
        public int wrafa { get; set; }
        public int wralead { get; set; }
        public int wramedit { get; set; }
        public int wramel { get; set; }
        public int wraperf { get; set; }
        public int wrasec { get; set; }
        public int wrasteal { get; set; }
        public int wraacad { get; set; }
        public int wracomp { get; set; }
        public int wraenig { get; set; }
        public int wrainvest { get; set; }
        public int wralaw { get; set; }
        public int wraling { get; set; }
        public int wramed { get; set; }
        public int wraocc { get; set; }
        public int wrapoli { get; set; }
        public int wrasci { get; set; }
        public int corpus { get; set; }
        public int wraWill { get; set; }
        public int wraMaxWill { get; set; }
        public int wracurcorp { get; set; }
        public string wraName { get; set; }
        public String wraLife { get; set; }
        public String wraDeath { get; set; }
        public int wrapathos { get; set; }
        public int wracurpathos { get; set; }















    }
}
