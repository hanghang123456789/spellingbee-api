using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.SpellingBeeGenerator
{
    /// <summary>
    /// Query options for the Spelling Bee Generator API
    /// </summary>
    public class SpellingBeeGeneratorQueryOptions
    {
        /// <summary>
        /// Difficulty: easy, medium, hard (affects word count)
        /// Example: medium
        /// </summary>
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }
    }
}
