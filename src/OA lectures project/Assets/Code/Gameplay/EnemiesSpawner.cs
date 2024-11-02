using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace Code.Gameplay
{
    public class EnemiesSpawner : MonoBehaviour
    {
        private float _timer;
        
        [SerializeField]
        private float _spawnInterval = 2;
        
        [SerializeField]
        private GameObject _enemy;

        private void Start() 
            => _timer = _spawnInterval;

        private void Update()
        {
            _timer -= Time.deltaTime;

            if (_timer < 0)
            {
                SpawnEnemy();
                _timer = _spawnInterval;
            }
        }

        private void SpawnEnemy()
        {
            Instantiate(_enemy, gameObject.transform);
        }
    }
}