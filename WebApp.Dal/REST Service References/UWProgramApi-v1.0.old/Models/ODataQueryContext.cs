// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class ODataQueryContext
    {
        /// <summary>
        /// Initializes a new instance of the ODataQueryContext class.
        /// </summary>
        public ODataQueryContext() { }

        /// <summary>
        /// Initializes a new instance of the ODataQueryContext class.
        /// </summary>
        public ODataQueryContext(IEdmModel model = default(IEdmModel), IEdmType elementType = default(IEdmType), IEdmNavigationSource navigationSource = default(IEdmNavigationSource), string elementClrType = default(string), ODataPath path = default(ODataPath))
        {
            Model = model;
            ElementType = elementType;
            NavigationSource = navigationSource;
            ElementClrType = elementClrType;
            Path = path;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Model")]
        public IEdmModel Model { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ElementType")]
        public IEdmType ElementType { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "NavigationSource")]
        public IEdmNavigationSource NavigationSource { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ElementClrType")]
        public string ElementClrType { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Path")]
        public ODataPath Path { get; private set; }

    }
}