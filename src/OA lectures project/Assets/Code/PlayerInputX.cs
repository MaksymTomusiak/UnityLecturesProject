using UnityEngine;

namespace Code
{
    public class PlayerInputX : MonoBehaviour
    {
        [SerializeField]
        private MoverX _mover;
        private void Update()
        {
            float input = Input.GetAxis("Horizontal");
            _mover.Move(input);
        }
    }
}
