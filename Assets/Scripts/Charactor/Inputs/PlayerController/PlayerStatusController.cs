using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    // This script must be run independently.
    // This is because changing it within a PlayerMovementController will cause it to get mixed up.
    // Click here to see the structure of the script.
    // https://miro.com/app/board/uXjVPNElwC0=/?moveToWidget=3458764539677421419&cot=14
    // All state-checking child programs are stored in "./_status".
    public class PlayerStatusController : MonoBehaviour
    {
        protected PlayerStatus _playerStatus = new PlayerStatus();

        #region Collision programs
        protected Enter Enter;
        protected Stay Stay;
        protected Exit Exit;
        #endregion

        #region Raycast programs
        protected UnderRaycast UnderRaycast;
        protected LeftRaycast LeftRaycast;
        #endregion

        #region Collision Based programs
        // All collision programs are executed by child programs that inherit PlayerStatusController depending on the situation.
        private void OnCollisionEnter(Collision collision)
        {
            /// <summary> Enter ground
            /// If player is collision enter to "ground".
            /// Set player status.
            /// _playerStatus.grounded = true;
            /// _playerStatus.canJump = true;
            /// </summary>
            if (collision.transform.CompareTag("ground") && UnderRaycast.distanceFromUnderHit <= 1.5f)
            {
                Enter.enterGround();
            }
            /// <summary> Enter left wall
            /// If player is collision enter to "runableWall".
            /// Set player status.
            /// _playerStatus.isRightWall = false;
            /// _playerStatus.canWalljump = true;
            /// The program to change the state of isLeftWall is Raycasts/LeftRay.cs.
            /// </summary>
            if (collision.transform.CompareTag("runableWall") && LeftRaycast.distanceFromLeftHit <= 3f)
            {
                Enter.enterLeftWall();
            }
            /// <summary> Enter right wall
            /// If player is collision enter to "runableWall".
            /// Set player status.
            /// _playerStatus.isLeftWall = false;
            /// _playerStatus.canWalljump = true;
            /// The program to change the state of isRightWall is Raycasts/RightRay.cs.
            /// </summary>
            if (collision.transform.CompareTag("runableWall") && _playerStatus.rightwall == true) Enter.enterRightWall();
        }

        private void OnCollisionStay(Collision collision)
        {
            /// <summary> Stay ground
            /// If player is collision stay on "ground".
            /// Set player status.
            /// _playerStatus.grounded = true;
            /// _playerStatus.canJump = true;
            /// </summary>
            if (collision.transform.CompareTag("ground")) Stay.stayGround();
            /// <summary> Stay left wall
            /// If player is collision stay on "runableWall".
            /// _playerStatus.isRightWall = false;
            /// _playerStatus.canWalljump = true;
            /// _playerStatus.wallrunning = true;
            /// The program to change the state of isLeftWall is Raycasts/LeftRay.cs.
            /// </summary>
            if (collision.transform.CompareTag("runableWall") && _playerStatus.leftwall == true) Stay.stayLeftWall();
            /// <summary> Stay right wall
            /// If player is collision stay on "runableWall".
            /// _playerStatus.isLeftWall = false;
            /// _playerStatus.canWalljump = true;
            /// _playerStatus.wallrunning = true;
            /// The program to change the state of isRightWall is Raycasts/RightRay.cs.
            /// </summary>
            if (collision.transform.CompareTag("runableWall") && _playerStatus.rightwall == true) Stay.stayRightWall();
        }

        private void OnCollisionExit(Collision collision)
        {
            /// <summary> Exit from ground
            /// If player is collision exit from "ground".
            /// Set player status.
            /// _playerStatus.grounded = false;
            /// _playerStstus.canJump = false;
            /// _playerStatus.candoubleJump = true;
            /// </summary>
            if (collision.transform.CompareTag("ground")) Exit.exitGround(); LeftRay();
            /// <summary> Exit from left wall.
            /// If player is collision exit from "runableWall".
            /// Set player status.
            /// _playerStatus.isLeftWall = false;
            /// _playerStatus.isRightWall = false;
            /// _playerStatus.canWalljump = false;
            /// _playerStatus.wallrunning = false;
            /// _playerStatus.candoubleJump = true;
            /// </summary>
            if (collision.transform.CompareTag("runableWall") && _playerStatus.leftwall == false) Exit.exitLeftWall();
            /// <summary> Exit from right wall.
            /// If player is collision exit from "runableWall".
            /// Set player status.
            /// _playerStatus.isLeftWall = false;
            /// _playerStatus.isRightWall = false;
            /// _playerStatus.canWalljump = false;
            /// _playerStatus.wallrunning = false;
            /// _playerStatus.candoubleJump = true;
            /// </summary>
            if (collision.transform.CompareTag("runableWall") && _playerStatus.rightwall == false) Exit.exitRightWall();
        }
        #endregion

        #region Raycast programs
        /// <summary> Left raycast using
        /// If player is not grounded, shoot left raycast.
        /// Get distance from -playerHead.right.position to left ray hit position.
        /// </summary>
        private void LeftRay()
        {
            if (_playerStatus.isGrounded == false) LeftRaycast.underRaycastShoot();
        }
        #endregion
    }
}
