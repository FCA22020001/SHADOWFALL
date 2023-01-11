//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region ShoulderLeftRay : MonoBehaviour
// 
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class ShoulderLeftRay : MonoBehaviour
    {
        public RaycastHit LeftRayHit;
        public float leftRayDistance;
        [Header("Get layer int")] public int leftrayHitObject;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot left the body
            if (Physics.Raycast(transform.position, -transform.right, out LeftRayHit))
            {
                leftRayDistance = Vector3.Distance(transform.position, LeftRayHit.point);

                leftrayHitObject = LeftRayHit.transform.gameObject.layer;
                //Debug.Log("Hit object layer int : " + LeftRayHit.transform.gameObject.layer);

                if (leftRayDistance <= 0.5f && leftrayHitObject == LayerMask.NameToLayer("RunnableWall"))
                {
                    Debug.Log("Left rayHit to wall from left raycast : " + leftrayHitObject + " ObjectName : " + LayerMask.LayerToName(leftrayHitObject));
                }

                // Debug space
                Debug.DrawRay(transform.position, -transform.right * 20, Color.red);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
