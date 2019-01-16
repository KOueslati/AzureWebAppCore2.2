// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class TopQueryOption
    {
        /// <summary>
        /// Initializes a new instance of the TopQueryOption class.
        /// </summary>
        public TopQueryOption() { }

        /// <summary>
        /// Initializes a new instance of the TopQueryOption class.
        /// </summary>
        public TopQueryOption(ODataQueryContext context = default(ODataQueryContext), string rawValue = default(string), int? value = default(int?), object validator = default(object))
        {
            Context = context;
            RawValue = rawValue;
            Value = value;
            Validator = validator;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "RawValue")]
        public string RawValue { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Value")]
        public int? Value { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

    }
}
