namespace NJsonSchema
{
	public class JsonSchemaAppender
	{
		private readonly ITypeNameGenerator _typeNameGenerator;

		public object RootObject { get; }

		protected JsonSchema RootSchema => null;

		public JsonSchemaAppender(object rootObject, ITypeNameGenerator typeNameGenerator)
		{
		}

		public virtual void AppendSchema(JsonSchema schema, string typeNameHint)
		{
		}
	}
}
