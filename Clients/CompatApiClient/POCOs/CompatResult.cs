﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompatApiClient.POCOs
{
    public class CompatResult
    {
        public int ReturnCode;
        public string SearchTerm;
        public Dictionary<string, TitleInfo> Results;

        [JsonIgnore]
        public TimeSpan RequestDuration;
        [JsonIgnore]
        public RequestBuilder RequestBuilder;
    }

    public class TitleInfo
    {
        public static readonly TitleInfo Maintenance = new TitleInfo { Status = "Maintenance" };
        public static readonly TitleInfo CommunicationError = new TitleInfo { Status = "Error" };
        public static readonly TitleInfo Unknown = new TitleInfo { Status = "Unknown" };

        public string Title;
        [JsonProperty(PropertyName = "alternative-title")]
        public string AlternativeTitle;
        [JsonProperty(PropertyName = "wiki-title")]
        public string WikiTitle;
        public string Status;
        public string Date;
        public int Thread;
        public string Commit;
        public int? Pr;
        public bool? Network;
        public string Update;
    }
}