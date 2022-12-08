using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class LeftRaycast : PlayerStatusController
    {
        public float distanceFromLeftHit;

        private RaycastHit playerLeftRay;

        public void underRaycastShoot()
        {
            if (Physics.Raycast(_playerStatus.playerHead.transform.position, -_playerStatus.playerHead.transform.right, out playerLeftRay))
                distanceFromLeftHit = Vector3.Distance(_playerStatus.playerHead.transform.position, playerLeftRay.point);
        }
    }
}
