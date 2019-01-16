// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class IEdmNavigationSource
    {
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationSource class.
        /// </summary>
        public IEdmNavigationSource() { }

        /// <summary>
        /// Initializes a new instance of the IEdmNavigationSource class.
        /// </summary>
        public IEdmNavigationSource(System.Collections.Generic.IList<IEdmNavigationPropertyBinding> navigationPropertyBindings = default(System.Collections.Generic.IList<IEdmNavigationPropertyBinding>), IEdmPathExpression path = default(IEdmPathExpression), IEdmType type = default(IEdmType), string name = default(string))
        {
            NavigationPropertyBindings = navigationPropertyBindings;
            Path = path;
            Type = type;
            Name = name;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "NavigationPropertyBindings")]
        public System.Collections.Generic.IList<IEdmNavigationPropertyBinding> NavigationPropertyBindings { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Path")]
        public IEdmPathExpression Path { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Type")]
        public IEdmType Type { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

    }
}