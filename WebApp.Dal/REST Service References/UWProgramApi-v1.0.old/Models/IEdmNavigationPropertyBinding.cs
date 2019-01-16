// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class IEdmNavigationPropertyBinding
    {
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationPropertyBinding
        /// class.
        /// </summary>
        public IEdmNavigationPropertyBinding() { }

        /// <summary>
        /// Initializes a new instance of the IEdmNavigationPropertyBinding
        /// class.
        /// </summary>
        public IEdmNavigationPropertyBinding(IEdmNavigationProperty navigationProperty = default(IEdmNavigationProperty), IEdmNavigationSource target = default(IEdmNavigationSource))
        {
            NavigationProperty = navigationProperty;
            Target = target;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "NavigationProperty")]
        public IEdmNavigationProperty NavigationProperty { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Target")]
        public IEdmNavigationSource Target { get; private set; }

    }
}