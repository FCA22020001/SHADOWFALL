using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class UnderRaycast : PlayerStatusController
    {
        public float distanceFromUnderHit;

        RaycastHit playerUnderRay;

        public void underRaycastShoot()
        {
            if (Physics.Raycast(_playerStatus.playerHead.transform.position, -_playerStatus.playerHead.transform.up, out playerUnderRay))
                distanceFromUnderHit = Vector3.Distance(_playerStatus.playerHead.transform.position, playerUnderRay.point);
        }
    }
}
