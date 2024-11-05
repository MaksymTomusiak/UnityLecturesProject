using System;
using UnityEngine;

namespace Code.Runtime.Gameplay.Logic
{
    public class Health : MonoBehaviour
    {
        [SerializeField] 
        private float _currentHealth;

        public float CurrentHealth => _currentHealth;
        public float MaxHealth { get; private set; }

        private void Start()
        {
            MaxHealth = _currentHealth;
        }

        public void Substract(float healthToSubtract)
        {
            if (healthToSubtract < 0)
                throw new InvalidOperationException($"Health to subtract have to be positive but was {healthToSubtract}");
            _currentHealth -= healthToSubtract;
            if (_currentHealth < 0)
            {
                _currentHealth = 0;
            }
        }
    }
}