﻿using System;
using Newtonsoft.Json;

namespace Wize.Models
{
    public class PeriodeViewModel
    {
        // DATE non-null
        [JsonProperty(PropertyName = "debut")]
        public DateTime debut { get; set; }
        // DATE non-null
        [JsonProperty(PropertyName = "fin")]
        public DateTime fin { get; set; }
    }
}
