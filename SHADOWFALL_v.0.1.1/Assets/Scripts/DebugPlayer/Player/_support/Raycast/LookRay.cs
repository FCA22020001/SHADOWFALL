//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region LookRay : MonoBehaviour
// 
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class LookRay : MonoBehaviour
    {
        public RaycastHit LookRayHit;
        public float lookRayDistance;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot to kneeForward the body
            if (Physics.Raycast(transform.position, transform.forward, out LookRayHit))
            {
                lookRayDistance = Vector3.Distance(transform.position, LookRayHit.point);

                // Debug space
                Debug.DrawRay(transform.position, transform.forward * 20, Color.red);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
