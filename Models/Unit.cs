using System;
using System.Web;
using System.Collections.Generic;

namespace Keeper.Models
{
    public class Unit
    {
        public string name;
        public string race;
        public Attributes Attributes = new Attributes();
        public Proficiencies Proficiencies = new Proficiencies();
    }

    public class Attributes
    {
        public string Strength;
        public string Dexterity;
        public string Constitution;
        public string Wisdom;
        public string Intelligence;
        public string Charisma;
    }

    public class Proficiencies
    {
        public string AcrobaticsDex; //eg 2
        public string AnimalHandlingWis;
        public string ArcanaInt;
        public string AthleticsStr;
        public string DeceptionCha;
        public string HistoryInt;
        public string InsightWis;
        public string IntimidationCha;
        public string InvestigationInt;
        public string MedicineWis;
        public string NatureInt;
        public string PerceptionWis;
        public string PerformanceCha;
        public string PersuasionCha;
        public string ReligionInt;
        public string SleightOfHandDex;
        public string StealthDex;
        public string SurvivalWis;
    }
}
