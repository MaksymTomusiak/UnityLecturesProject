using System;
using UnityEngine;

namespace Code.Gameplay
{
    public class PlayerAnimator : MonoBehaviour
    {
        private static readonly int IsRunning = Animator.StringToHash("IsRunning");

        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private MoverX _moverX;

        private void Update()
        {
            _animator.SetBool(IsRunning, _moverX.IsMoving);
        }
    }
}