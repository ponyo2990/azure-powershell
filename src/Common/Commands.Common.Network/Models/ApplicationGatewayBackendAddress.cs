// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Network.Version2017_03_01.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Internal;
    using Microsoft.Azure.Management.Internal.Network;
    using Microsoft.Azure.Management.Internal.Network.Version2017_03_01;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Backend address of an application gateway.
    /// </summary>
    public partial class ApplicationGatewayBackendAddress
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendAddress
        /// class.
        /// </summary>
        public ApplicationGatewayBackendAddress()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendAddress
        /// class.
        /// </summary>
        /// <param name="fqdn">Fully qualified domain name (FQDN).</param>
        /// <param name="ipAddress">IP address</param>
        public ApplicationGatewayBackendAddress(string fqdn = default(string), string ipAddress = default(string))
        {
            Fqdn = fqdn;
            IpAddress = ipAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified domain name (FQDN).
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets IP address
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

    }
}