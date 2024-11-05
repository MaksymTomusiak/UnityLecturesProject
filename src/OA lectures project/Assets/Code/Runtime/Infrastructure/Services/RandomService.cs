using UnityEngine;

namespace Code.Runtime.Infrastructure.Services
{
    public class RandomService : IRandomService
    {
        public float Range(float minInclusive, float maxInclusive) => Random.Range(minInclusive, maxInclusive);
    }
}