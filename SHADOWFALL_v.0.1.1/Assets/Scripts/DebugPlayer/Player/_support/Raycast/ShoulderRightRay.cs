//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region ShoulderRightRay : MonoBehaviour
// 
#endregion

using System;
using UnityEngine;


namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class ShoulderRightRay : MonoBehaviour
    {
        public RaycastHit RightRayHit;
        public float rightRayDistance;
        [Header("Get layer int")] public int rightrayHitObject;

        private void Update()
        {
            Raycast();
        }

        public void Raycast()
        {
            // Shot ray from foot right the body
            if (Physics.Raycast(transform.position, transform.right, out RightRayHit))
            {
                rightRayDistance = Vector3.Distance(transform.position, RightRayHit.point);

                rightrayHitObject = RightRayHit.transform.gameObject.layer;

                if (rightRayDistance <= 0.5f && rightrayHitObject == LayerMask.NameToLayer("RunnableWall"))
                {
                    Debug.Log("Right rayHit to wall from left raycast : " + rightrayHitObject + " ObjectName : " + LayerMask.LayerToName(rightrayHitObject));
                }

                // Debug space
                Debug.DrawRay(transform.position, transform.right * 20, Color.red);
                //Debug.Log("Distance : " + Distance);
            }
        }
    }
}
