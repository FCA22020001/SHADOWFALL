//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region SlopeForwardCheckRay : MonoBehaviour
// DSABLE THIS SCRIPT
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class SlopeForwardCheckRay : MonoBehaviour
    {
        public RaycastHit kneeForwardRayHit;
        public float kneeForwardDistance;
        public Vector3 forwardSlopeQuaternionAngle;
        public Vector3 forwardSlopeEularAngle;
        private string rayHitLayer;

        private float temp2;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot to kneeForward the body
            if (Physics.Raycast(transform.position, transform.forward + -transform.up, out kneeForwardRayHit))
            {
                kneeForwardDistance = Vector3.Distance(transform.position, kneeForwardRayHit.point);

                forwardSlopeEularAngle = new Vector3(kneeForwardRayHit.transform.gameObject.transform.localEulerAngles.x,
                                                         kneeForwardRayHit.transform.gameObject.transform.localEulerAngles.y,
                                                         kneeForwardRayHit.transform.gameObject.transform.localEulerAngles.z);
                //Debug.Log("Hit object rotation : " + forwardSlopeQuaternionAngle);

                // Debug space
                Debug.DrawRay(transform.position, (transform.forward + -transform.up) * 20, Color.cyan);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
