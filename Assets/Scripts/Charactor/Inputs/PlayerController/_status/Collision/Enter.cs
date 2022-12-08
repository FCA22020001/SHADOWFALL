using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Enter : PlayerStatusController
    {
        public void enterGround()
        {
            _playerStatus.isGrounded = true;
            _playerStatus.canJump = true;
        }

        #region Enter wall
        public void enterLeftWall()
        {
            _playerStatus.leftwall = true;
            _playerStatus.rightwall = false;
            _playerStatus.canWallJump = true;
        }
        public void enterRightWall()
        {
            _playerStatus.leftwall = false;
            _playerStatus.canWallJump = true;
        }
        #endregion
    }
}
