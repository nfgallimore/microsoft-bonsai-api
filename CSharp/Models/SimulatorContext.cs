// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bonsai.SimulatorApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SimulatorContext
    {
        /// <summary>
        /// Initializes a new instance of the SimulatorContext class.
        /// </summary>
        public SimulatorContext()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SimulatorContext class.
        /// </summary>
        /// <param name="deploymentMode">Possible values include:
        /// 'Unspecified', 'Hosted', 'Testing'</param>
        public SimulatorContext(SimulatorContextTypesDeploymentMode? deploymentMode = default(SimulatorContextTypesDeploymentMode?), string deploymentDetails = default(string), string simulatorClientId = default(string), string collection = default(string), string package = default(string), Purpose purpose = default(Purpose))
        {
            DeploymentMode = deploymentMode;
            DeploymentDetails = deploymentDetails;
            SimulatorClientId = simulatorClientId;
            Collection = collection;
            Package = package;
            Purpose = purpose;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Unspecified', 'Hosted',
        /// 'Testing'
        /// </summary>
        [JsonProperty(PropertyName = "deploymentMode")]
        public SimulatorContextTypesDeploymentMode? DeploymentMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deploymentDetails")]
        public string DeploymentDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "simulatorClientId")]
        public string SimulatorClientId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "collection")]
        public string Collection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "package")]
        public string Package { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        public Purpose Purpose { get; set; }

    }
}
