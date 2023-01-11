//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region SlopeRightCheckRay : MonoBehaviour
// 
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class SlopeRightCheckRay : MonoBehaviour
    {
        public RaycastHit kneeRightRayHit;
        public float kneeRightDistance;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot to kneeLeft the body
            if (Physics.Raycast(transform.position, transform.right + -transform.up, out kneeRightRayHit))
            {
                kneeRightDistance = Vector3.Distance(transform.position, kneeRightRayHit.point);

                // Debug space
                Debug.DrawRay(transform.position, (transform.right + -transform.up) * 20, Color.cyan);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
