﻿using System;
using Code.Extensions;
using UnityEngine;

namespace Code.Gameplay
{
    public class MoveView : MonoBehaviour
    {
        [SerializeField]
        private MoverX _moverX;

        private void Update()
        {
            float sign = Math.Sign(_moverX.Speed);
            if (sign == 0)
            {
                return;
            }

            var x = sign * Math.Abs(transform.localScale.x);
            transform.localScale = transform.localScale.SetX(x);
        }
    }
}