namespace NerdStore.Core.DomainObjects
{
    public class DomainException : Exception
    {
        public DomainException() { }

        public DomainException(string menssagem) : base(menssagem) { }

        public DomainException(string menssagem, Exception innerException) : base(menssagem, innerException) { }
    }
}
