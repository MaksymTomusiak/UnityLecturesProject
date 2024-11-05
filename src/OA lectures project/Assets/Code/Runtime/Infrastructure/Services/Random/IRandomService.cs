namespace Code.Runtime.Infrastructure.Services
{
    public interface IRandomService
    {
        public float Range(float minInclusive, float maxInclusive);
    }
}