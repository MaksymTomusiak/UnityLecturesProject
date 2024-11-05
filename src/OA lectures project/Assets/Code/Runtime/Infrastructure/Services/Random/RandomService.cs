namespace Code.Runtime.Infrastructure.Services.Random
{
    public class RandomService : IRandomService
    {
        public float Range(float minInclusive, float maxInclusive) => UnityEngine.Random.Range(minInclusive, maxInclusive);
    }
}