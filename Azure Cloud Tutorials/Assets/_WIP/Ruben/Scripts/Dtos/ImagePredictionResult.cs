﻿using System;
using Newtonsoft.Json;

namespace MRTK.Tutorials.AzureCloudPower.Dtos
{
    public class ImagePredictionResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("iteration")]
        public string Iteration { get; set; }

        [JsonProperty("created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("predictions")]
        public Prediction[] Predictions { get; set; }
    }
}