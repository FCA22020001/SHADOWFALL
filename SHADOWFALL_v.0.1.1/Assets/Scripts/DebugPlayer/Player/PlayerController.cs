//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerController : Monobehavior
//  This is a script to control player's body.
//  This script can body control, see around and check body status.
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerController : MonoBehaviour
    {
        private PlayerMovements _controller;

        void Awake()
        {
            _controller = GetComponent<PlayerMovements>();

            _controller.onAwake();
        }
        void Start()
        {
            _controller.onStart();
        }
        void Update()
        {
            _controller.onUpdate();
        }
        void FixedUpdate()
        {
            _controller.onFixedUpdate();
        }
    }
}
