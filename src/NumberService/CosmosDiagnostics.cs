// Generated by https://quicktype.io

namespace NumberService
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CosmosDiagnostics
    {
        [JsonProperty("DiagnosticVersion")]
        public long DiagnosticVersion { get; set; }

        [JsonProperty("Summary")]
        public Summary Summary { get; set; }

        [JsonProperty("Context")]
        public Context[] Context { get; set; }
    }

    public partial class Context
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("HandlerElapsedTimeInMs", NullValueHandling = NullValueHandling.Ignore)]
        public double? HandlerElapsedTimeInMs { get; set; }

        [JsonProperty("CpuHistory", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuHistory { get; set; }

        [JsonProperty("ContactedReplicas", NullValueHandling = NullValueHandling.Ignore)]
        public ContactedReplica[] ContactedReplicas { get; set; }

        [JsonProperty("RegionsContacted", NullValueHandling = NullValueHandling.Ignore)]
        public Uri[] RegionsContacted { get; set; }

        [JsonProperty("FailedReplicas", NullValueHandling = NullValueHandling.Ignore)]
        public object[] FailedReplicas { get; set; }

        [JsonProperty("ElapsedTimeInMs", NullValueHandling = NullValueHandling.Ignore)]
        public double? ElapsedTimeInMs { get; set; }

        [JsonProperty("StartTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartTimeUtc { get; set; }

        [JsonProperty("EndTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndTimeUtc { get; set; }

        [JsonProperty("TargetEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TargetEndpoint { get; set; }

        [JsonProperty("ResponseTimeUtc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ResponseTimeUtc { get; set; }

        [JsonProperty("ResourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        [JsonProperty("OperationType", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        [JsonProperty("LocationEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public Uri LocationEndpoint { get; set; }

        [JsonProperty("ActivityId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ActivityId { get; set; }

        [JsonProperty("StoreResult", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreResult { get; set; }
    }

    public partial class ContactedReplica
    {
        [JsonProperty("Count")]
        public long Count { get; set; }

        [JsonProperty("Uri")]
        public string Uri { get; set; }
    }

    public partial class Summary
    {
        [JsonProperty("StartUtc")]
        public DateTimeOffset StartUtc { get; set; }

        [JsonProperty("TotalElapsedTimeInMs")]
        public double TotalElapsedTimeInMs { get; set; }

        [JsonProperty("UserAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("TotalRequestCount")]
        public long TotalRequestCount { get; set; }

        [JsonProperty("FailedRequestCount")]
        public long FailedRequestCount { get; set; }
    }
}