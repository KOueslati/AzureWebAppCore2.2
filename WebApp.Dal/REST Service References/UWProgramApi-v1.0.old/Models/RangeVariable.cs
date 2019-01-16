// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class RangeVariable
    {
        /// <summary>
        /// Initializes a new instance of the RangeVariable class.
        /// </summary>
        public RangeVariable() { }

        /// <summary>
        /// Initializes a new instance of the RangeVariable class.
        /// </summary>
        public RangeVariable(string name = default(string), IEdmTypeReference typeReference = default(IEdmTypeReference), int? kind = default(int?))
        {
            Name = name;
            TypeReference = typeReference;
            Kind = kind;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "TypeReference")]
        public IEdmTypeReference TypeReference { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Kind")]
        public int? Kind { get; private set; }

    }
}
