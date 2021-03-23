﻿using System.Diagnostics.CodeAnalysis;
using RaaLabs.Edge.Modules.EdgeHub;

namespace RaaLabs.Edge.Prioritizer.events
{
    [ExcludeFromCodeCoverage]
    [OutputName("nonprioritized")]
    public class EdgeHubDataPointNonPrioritized : IEdgeHubOutgoingEvent
    {
        public EdgeHubDataPointNonPrioritized(string timeseries, dynamic value, long timestamp)
        {
            Timeseries = timeseries;
            Value = value;
            Timestamp = timestamp;
        }
        public string Timeseries { get; set; }

        public dynamic Value { get; set; }

        public long Timestamp { get; set; }
    }
}