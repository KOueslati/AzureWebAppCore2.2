// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class ODataQueryOptionsPricingViewDto
    {
        /// <summary>
        /// Initializes a new instance of the ODataQueryOptionsPricingViewDto
        /// class.
        /// </summary>
        public ODataQueryOptionsPricingViewDto() { }

        /// <summary>
        /// Initializes a new instance of the ODataQueryOptionsPricingViewDto
        /// class.
        /// </summary>
        public ODataQueryOptionsPricingViewDto(object ifMatch = default(object), object ifNoneMatch = default(object), ODataQueryContext context = default(ODataQueryContext), object request = default(object), ODataRawQueryOptions rawValues = default(ODataRawQueryOptions), SelectExpandQueryOption selectExpand = default(SelectExpandQueryOption), ApplyQueryOption apply = default(ApplyQueryOption), FilterQueryOption filter = default(FilterQueryOption), OrderByQueryOption orderBy = default(OrderByQueryOption), SkipQueryOption skip = default(SkipQueryOption), TopQueryOption top = default(TopQueryOption), CountQueryOption count = default(CountQueryOption), object validator = default(object))
        {
            IfMatch = ifMatch;
            IfNoneMatch = ifNoneMatch;
            Context = context;
            Request = request;
            RawValues = rawValues;
            SelectExpand = selectExpand;
            Apply = apply;
            Filter = filter;
            OrderBy = orderBy;
            Skip = skip;
            Top = top;
            Count = count;
            Validator = validator;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "IfMatch")]
        public object IfMatch { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "IfNoneMatch")]
        public object IfNoneMatch { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Request")]
        public object Request { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "RawValues")]
        public ODataRawQueryOptions RawValues { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SelectExpand")]
        public SelectExpandQueryOption SelectExpand { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Apply")]
        public ApplyQueryOption Apply { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Filter")]
        public FilterQueryOption Filter { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "OrderBy")]
        public OrderByQueryOption OrderBy { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Skip")]
        public SkipQueryOption Skip { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Top")]
        public TopQueryOption Top { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Count")]
        public CountQueryOption Count { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

    }
}
