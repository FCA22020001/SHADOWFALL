using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Crouch : MovementController
    {
        public void playerStartCrouch()
        {
            // I can't change scale of player when player crouch.
            // And crouch is only change camera's hight.
            _playerCamera.transform.localPosition = new Vector3(0f, 0.2f, 0f);
        }

        public void playerStopCrouch()
        {
            _playerCamera.transform.localPosition = new Vector3(0f, 0.7f, 0f);
        }
    }
}
