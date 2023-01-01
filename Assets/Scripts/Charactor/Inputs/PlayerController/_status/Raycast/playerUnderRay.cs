using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL{
    public class playerUnderRay : PlayerStatusController{

        private RaycastHit rayHit;
        
        public void Raycast(){
            // Under ray
            if (Physics.Raycast(_playerHead.transform.position, -_playerHead.transform.up, out rayHit))
                underRayhitDistance = Vector3.Distance(_playerHead.transform.position, rayHit.point);
        }
    }
}
