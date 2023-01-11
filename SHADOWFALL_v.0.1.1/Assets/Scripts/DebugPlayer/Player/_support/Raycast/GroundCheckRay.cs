//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GroundCheckRay : Monbehavior
// Grounded checker
//     If Distance <= 1.0f -> PLAYER.isGrounded = true;
//     If Distance > 1.0f -> PLAYER.isGrounded = false;
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class GroundCheckRay : MonoBehaviour
    {
        public RaycastHit underRayHit;
        public float underDistance;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot to under the body
            if (Physics.Raycast(transform.position, -transform.up, out underRayHit))
            {
                underDistance = Vector3.Distance(transform.position, underRayHit.point);

                // Debug space
                Debug.DrawRay(transform.position, -transform.up * 20, Color.white * Color.green);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
