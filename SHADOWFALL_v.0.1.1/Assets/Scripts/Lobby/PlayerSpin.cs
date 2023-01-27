//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerSpin : MonoBehaviour
// Rotate the player in lobby
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerSpin : MonoBehaviour
    {
        [SerializeField] private Rigidbody playerBody;
        [SerializeField] private float spinSpeed;

        private void Awake()
        {
            playerBody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            playerBody.transform.Rotate(0, spinSpeed, 0);
        }
    }
}
