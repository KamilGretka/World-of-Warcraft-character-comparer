﻿using Newtonsoft.Json;

namespace WowCharComparerLib.Models.CharacterProfile.Mounts
{
    public class Mounts
    {
        [JsonProperty(PropertyName = "NumCollected")]
        public int NumberOfCollectedMounts { get; set; }

        [JsonProperty(PropertyName = "NumNotCollected")]
        public int NumberOfNotCollectedMounts { get; set; }

        public Collected [] Collected { get; set; }
    }
}
