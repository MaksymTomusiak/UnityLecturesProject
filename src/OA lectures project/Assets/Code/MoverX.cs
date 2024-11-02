using UnityEngine;

namespace Code
{
    internal class MoverX : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D _rigidbody;
        
        [SerializeField] 
        private float speed;

        public void Move(float input)
        {
            _rigidbody.velocity = new Vector2(input * speed, _rigidbody.velocity.y);
        }
    }
}