//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region SlopeBackwardCheckRay : MonoBehaviour
// DSABLE THIS SCRIPT
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class SlopeBackwardCheckRay : MonoBehaviour
    {
        public RaycastHit kneeBackwardRayHit;
        public float kneeBackwardDistance;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot to kneeForward the body
            if (Physics.Raycast(transform.position, -transform.forward + -transform.up, out kneeBackwardRayHit))
            {
                kneeBackwardDistance = Vector3.Distance(transform.position, kneeBackwardRayHit.point);

                // Debug space
                Debug.DrawRay(transform.position, (-transform.forward + -transform.up) * 20, Color.cyan);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
