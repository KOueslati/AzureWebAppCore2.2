// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class IEdmPathExpression
    {
        /// <summary>
        /// Initializes a new instance of the IEdmPathExpression class.
        /// </summary>
        public IEdmPathExpression() { }

        /// <summary>
        /// Initializes a new instance of the IEdmPathExpression class.
        /// </summary>
        /// <param name="expressionKind">Possible values include: 'None',
        /// 'BinaryConstant', 'BooleanConstant', 'DateTimeOffsetConstant',
        /// 'DecimalConstant', 'FloatingConstant', 'GuidConstant',
        /// 'IntegerConstant', 'StringConstant', 'DurationConstant', 'Null',
        /// 'Record', 'Collection', 'Path', 'ParameterReference',
        /// 'OperationReference', 'PropertyReference', 'ValueTermReference',
        /// 'EntitySetReference', 'EnumMemberReference', 'If', 'Cast',
        /// 'IsType', 'OperationApplication', 'LabeledExpressionReference',
        /// 'Labeled', 'PropertyPath', 'NavigationPropertyPath',
        /// 'DateConstant', 'TimeOfDayConstant', 'EnumMember'</param>
        public IEdmPathExpression(System.Collections.Generic.IList<string> path = default(System.Collections.Generic.IList<string>), string expressionKind = default(string))
        {
            Path = path;
            ExpressionKind = expressionKind;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Path")]
        public System.Collections.Generic.IList<string> Path { get; private set; }

        /// <summary>
        /// Gets possible values include: 'None', 'BinaryConstant',
        /// 'BooleanConstant', 'DateTimeOffsetConstant', 'DecimalConstant',
        /// 'FloatingConstant', 'GuidConstant', 'IntegerConstant',
        /// 'StringConstant', 'DurationConstant', 'Null', 'Record',
        /// 'Collection', 'Path', 'ParameterReference', 'OperationReference',
        /// 'PropertyReference', 'ValueTermReference', 'EntitySetReference',
        /// 'EnumMemberReference', 'If', 'Cast', 'IsType',
        /// 'OperationApplication', 'LabeledExpressionReference', 'Labeled',
        /// 'PropertyPath', 'NavigationPropertyPath', 'DateConstant',
        /// 'TimeOfDayConstant', 'EnumMember'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ExpressionKind")]
        public string ExpressionKind { get; private set; }

    }
}