using System;

namespace ProgrammingIIIFinal
{
    public class Spell : IComparable<Spell>
    {
        public string spellName;
        public string spellLevel;
        public string spellSchool;
        public string castTime;
        public string spellRange;
        public string spellComponents;
        public string spellDuration;
        public string spellClasses;
        public string spellDescription;
        public Spell()
        {

        }

        public Spell(string spellName, string spellLevel, string spellSchool, string castTime, string spellRange,
            string spellComponents, string spellDuration, string spellClasses, string spellDescription)
        {
            this.spellName = spellName;
            this.spellLevel = spellLevel;
            this.spellSchool = spellSchool;
            this.castTime = castTime;
            this.spellRange = spellRange;
            this.spellComponents = spellComponents;
            this.spellDuration = spellDuration;
            this.spellClasses = spellClasses;
            this.spellDescription = spellDescription;
        }

        override public string ToString() 
        {
            return this.spellName;
        }
        public int CompareTo(Spell other)
        {
            if (other == null) return 1;

            return spellName.CompareTo(other.spellName);
        }
    }

}
