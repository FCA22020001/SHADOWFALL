using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class LeftRaycast : MovementCore
    {
        private void LeftWallCekcer()
        {
            RaycastHit leftHit;
            Physics.Raycast(playerBody.transform.position, -playerBody.transform.right, out leftHit);
            Debug.DrawRay(playerBody.transform.position, -playerBody.transform.right, Color.cyan, 10f);
        }
    }
}
