namespace PropertiesInformation.Domain.Exceptions
{
    [System.Serializable]
    public class PropertyExistsException : AppException
    {
        public PropertyExistsException() { }
        public PropertyExistsException(string message) : base(message) { }
        public PropertyExistsException(string message, System.Exception inner) : base(message, inner) { }
        protected PropertyExistsException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
