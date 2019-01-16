// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class ODataPath
    {
        /// <summary>
        /// Initializes a new instance of the ODataPath class.
        /// </summary>
        public ODataPath() { }

        /// <summary>
        /// Initializes a new instance of the ODataPath class.
        /// </summary>
        public ODataPath(IEdmType edmType = default(IEdmType), IEdmNavigationSource navigationSource = default(IEdmNavigationSource), string pathTemplate = default(string), System.Collections.Generic.IList<ODataPathSegment> segments = default(System.Collections.Generic.IList<ODataPathSegment>))
        {
            EdmType = edmType;
            NavigationSource = navigationSource;
            PathTemplate = pathTemplate;
            Segments = segments;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "EdmType")]
        public IEdmType EdmType { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "NavigationSource")]
        public IEdmNavigationSource NavigationSource { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "PathTemplate")]
        public string PathTemplate { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Segments")]
        public System.Collections.Generic.IList<ODataPathSegment> Segments { get; private set; }

    }
}