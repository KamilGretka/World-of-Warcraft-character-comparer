﻿
using System.Collections.Generic;

namespace WowCharComparerLib.Models.CharacterProfile.Profession
{
    public class ProfModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public int Rank { get; set; }

        public int Max { get; set; }

        public int [] Recipes { get; set; }
    }
}
