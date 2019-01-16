// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class OrderByQueryOption
    {
        /// <summary>
        /// Initializes a new instance of the OrderByQueryOption class.
        /// </summary>
        public OrderByQueryOption() { }

        /// <summary>
        /// Initializes a new instance of the OrderByQueryOption class.
        /// </summary>
        public OrderByQueryOption(ODataQueryContext context = default(ODataQueryContext), System.Collections.Generic.IList<OrderByNode> orderByNodes = default(System.Collections.Generic.IList<OrderByNode>), string rawValue = default(string), object validator = default(object), OrderByClause orderByClause = default(OrderByClause))
        {
            Context = context;
            OrderByNodes = orderByNodes;
            RawValue = rawValue;
            Validator = validator;
            OrderByClause = orderByClause;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "OrderByNodes")]
        public System.Collections.Generic.IList<OrderByNode> OrderByNodes { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "RawValue")]
        public string RawValue { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "OrderByClause")]
        public OrderByClause OrderByClause { get; private set; }

    }
}