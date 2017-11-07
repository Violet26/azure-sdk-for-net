// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Object representing a metric for any resource .
    /// </summary>
    public partial class ResourceMetric
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetric class.
        /// </summary>
        public ResourceMetric()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceMetric class.
        /// </summary>
        /// <param name="name">Name of metric.</param>
        /// <param name="unit">Metric unit.</param>
        /// <param name="timeGrain">Metric granularity. E.g PT1H, PT5M,
        /// P1D</param>
        /// <param name="startTime">Metric start time.</param>
        /// <param name="endTime">Metric end time.</param>
        /// <param name="resourceId">Metric resource Id.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="metricValues">Metric values.</param>
        /// <param name="properties">Properties.</param>
        public ResourceMetric(ResourceMetricName name = default(ResourceMetricName), string unit = default(string), string timeGrain = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string resourceId = default(string), string id = default(string), IList<ResourceMetricValue> metricValues = default(IList<ResourceMetricValue>), IList<ResourceMetricProperty> properties = default(IList<ResourceMetricProperty>))
        {
            Name = name;
            Unit = unit;
            TimeGrain = timeGrain;
            StartTime = startTime;
            EndTime = endTime;
            ResourceId = resourceId;
            Id = id;
            MetricValues = metricValues;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public ResourceMetricName Name { get; private set; }

        /// <summary>
        /// Gets metric unit.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets metric granularity. E.g PT1H, PT5M, P1D
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; private set; }

        /// <summary>
        /// Gets metric start time.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets metric end time.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets metric resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; private set; }

        /// <summary>
        /// Gets resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets metric values.
        /// </summary>
        [JsonProperty(PropertyName = "metricValues")]
        public IList<ResourceMetricValue> MetricValues { get; private set; }

        /// <summary>
        /// Gets properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<ResourceMetricProperty> Properties { get; private set; }

    }
}
