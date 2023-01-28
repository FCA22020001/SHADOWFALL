//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region SlopeLeftCheckRay : MonoBehaviour
// DSABLE THIS SCRIPT
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class SlopeLeftCheckRay : MonoBehaviour
    {
        public RaycastHit kneeLeftRayHit;
        public float kneeLeftDistance;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot to kneeLeft the body
            if (Physics.Raycast(transform.position, -transform.right + -transform.up, out kneeLeftRayHit))
            {
                kneeLeftDistance = Vector3.Distance(transform.position, kneeLeftRayHit.point);

                // Debug space
                Debug.DrawRay(transform.position, (-transform.right + -transform.up) * 20, Color.cyan);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
