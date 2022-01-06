namespace PropertiesInformation.Domain.Exceptions
{
    [System.Serializable]
    public class PropertyNoExistsException : AppException
    {
        public PropertyNoExistsException() { }
        public PropertyNoExistsException(string message) : base(message) { }
        public PropertyNoExistsException(string message, System.Exception inner) : base(message, inner) { }
        protected PropertyNoExistsException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
