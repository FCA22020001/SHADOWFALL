using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Exit : PlayerStatusController
    {
        public void exitGround()
        {
            _playerStatus.isGrounded = false;
            _playerStatus.canJump = false;
            _playerStatus.canDoubleJump = true;
        }

        #region Exit wall
        public void exitLeftWall()
        {
            _playerStatus.leftwall = false;
            _playerStatus.rightwall = false;
            _playerStatus.canWallJump = false;
            _playerStatus.wallrunning = false;
            _playerStatus.canDoubleJump = true;
        }
        public void exitRightWall()
        {
            _playerStatus.leftwall = false;
            _playerStatus.rightwall = false;
            _playerStatus.canWallJump = false;
            _playerStatus.wallrunning = false;
            _playerStatus.canDoubleJump = true;
        }
        #endregion
    }
}
