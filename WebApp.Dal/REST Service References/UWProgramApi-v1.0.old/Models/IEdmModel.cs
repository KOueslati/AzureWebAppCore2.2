// <autogenerated>By AutoRest</autogenerated>

namespace UWProgramApi.v1_0.Models
{
    using System.Linq;

    public partial class IEdmModel
    {
        /// <summary>
        /// Initializes a new instance of the IEdmModel class.
        /// </summary>
        public IEdmModel() { }

        /// <summary>
        /// Initializes a new instance of the IEdmModel class.
        /// </summary>
        public IEdmModel(System.Collections.Generic.IList<IEdmSchemaElement> schemaElements = default(System.Collections.Generic.IList<IEdmSchemaElement>), System.Collections.Generic.IList<IEdmVocabularyAnnotation> vocabularyAnnotations = default(System.Collections.Generic.IList<IEdmVocabularyAnnotation>), System.Collections.Generic.IList<IEdmModel> referencedModels = default(System.Collections.Generic.IList<IEdmModel>), System.Collections.Generic.IList<string> declaredNamespaces = default(System.Collections.Generic.IList<string>), object directValueAnnotationsManager = default(object), IEdmEntityContainer entityContainer = default(IEdmEntityContainer))
        {
            SchemaElements = schemaElements;
            VocabularyAnnotations = vocabularyAnnotations;
            ReferencedModels = referencedModels;
            DeclaredNamespaces = declaredNamespaces;
            DirectValueAnnotationsManager = directValueAnnotationsManager;
            EntityContainer = entityContainer;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SchemaElements")]
        public System.Collections.Generic.IList<IEdmSchemaElement> SchemaElements { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "VocabularyAnnotations")]
        public System.Collections.Generic.IList<IEdmVocabularyAnnotation> VocabularyAnnotations { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ReferencedModels")]
        public System.Collections.Generic.IList<IEdmModel> ReferencedModels { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DeclaredNamespaces")]
        public System.Collections.Generic.IList<string> DeclaredNamespaces { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DirectValueAnnotationsManager")]
        public object DirectValueAnnotationsManager { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "EntityContainer")]
        public IEdmEntityContainer EntityContainer { get; private set; }

    }
}
