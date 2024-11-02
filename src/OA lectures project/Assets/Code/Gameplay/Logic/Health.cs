using System;
using UnityEngine;

namespace Code.Gameplay.Logic
{
    public class Health : MonoBehaviour
    {
        [SerializeField] 
        private float _currentHealth;

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