using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class RightRaycast : PlayerStatusController
    {
        public float distanceFromRightHit;

        private RaycastHit playerRightRay;

        public void rightRaycastShoot()
        {
            if (Physics.Raycast(_playerStatus.playerHead.transform.position, _playerStatus.playerHead.transform.right, out playerRightRay))
                distanceFromRightHit = Vector3.Distance(_playerStatus.playerHead.transform.position, playerRightRay.point);
        }
    }
}
