namespace Code.Runtime.Infrastructure.Services.Random
{
    public interface IRandomService
    {
        public float Range(float minInclusive, float maxInclusive);
    }
}