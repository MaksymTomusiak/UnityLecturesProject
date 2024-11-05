using UnityEngine;

namespace Code.Runtime.Gameplay.Logic
{
    public class Mace : MonoBehaviour, ICollectable
    {
        [SerializeField] private float _healthToSubtract;

        public void Collect(Collector collector)
        {
            collector.GetComponent<Health>().Substract(_healthToSubtract);
        }
    }
}