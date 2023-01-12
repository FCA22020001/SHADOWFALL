//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerMovements : MonoBehaviour
//  Player's movement controller.
// This script can controle for player object.
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerMovements : MonoBehaviour
    {
        #region Player body component
        [SerializeField] protected Rigidbody _playerBody;
        [SerializeField] protected Transform _playerHead;
        [SerializeField] protected Transform _playerLeftShoulder;
        [SerializeField] protected Transform _playerRightShoulder;
        [SerializeField] protected Transform _playerFoot;
        #endregion
        #region Script space
        protected PlayerStatus STATUS = new PlayerStatus();
        // Movements
        [SerializeField] private PlayerLook _look;
        [SerializeField] private PlayerWalk _walk;
        [SerializeField] private PlayerRun _run;
        [SerializeField] private PlayerJump _jump;
        [SerializeField] private PlayerDoubleJump _doubleJump;
        [SerializeField] private PlayerCrouch _crouch;
        //Raycasts
        [SerializeField] protected GroundCheckRay _playerUnderRay;
        [SerializeField] protected ShoulderLeftRay _playerLeftRay;
        [SerializeField] protected ShoulderRightRay _playerRightRay;
        #endregion
        #region Player body variables
        [SerializeField] protected float walkSpeed; //7.0f
        [SerializeField] protected float runSpeed; //15.0f
        [SerializeField] protected float maxSpeed; // 25f
        [SerializeField] protected float nowSpeed;
        #endregion
        #region Input configuration
        [SerializeField] protected float mouseSensitivity = 7f;
        #endregion

        #region Temporary variables
        protected float keyEscape, keyTab, jumpCount;
        protected int layerMask_Ground = 6, layerMask_Slope = 9,layerMask_Zipline = 10, layerMask_Stairs = 11, layerMask_Ladder = 12, layerMask_RunnableWall = 13;
        #endregion


        public void onAwake()
        {
            //Debug.Log("Loading datas...");
            ResetPlayerGear();
        }
        public void onStart()
        {
            //Debug.Log("Loading scripts...");
            //PlayerMouseInputEnable();
            //PlayerKeyInputEnable();
            LockCoursor();
        }
        public void onUpdate()
        {
            //Debug.Log("Updating...!");
            InputEnablesController();
            Movements();
            //JumpReadyChecker();
        }
        public void onFixedUpdate()
        {
            //Debug.Log("Updating every 0.002 second.");
            //_underRay.Raycast();
            PlayerGroundChecker();
            //Debug.Log("Grounded : " + STATUS.isGrounded);
            PlayerLeftWallChecker();
            //Debug.Log("OnLeftWall : " + STATUS.onLeftWall);
            PlayerRightWallChecker();
            //Debug.Log("OnRightWall : " + STATUS.onRightWall);
            //JumpReadyChecker();
        }

        #region Avoid to bug script script
        private void ResetPlayerGear()
        {
            walkSpeed = 7.0f;
            runSpeed = 15.0f;
            maxSpeed = 25.0f;
        }
        private void LockCoursor()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        #endregion

        #region Player movements
        private void Movements()
        {
            Look();
            NormalMovement();
            Jump();
        }
        private void Look()
        {
            // Look around
            if (STATUS.mouseRock == false)
            {
                _look.Look();
            }
        }
        private void NormalMovement()
        {
            if (STATUS.keyLock == false)
            {
                if (_playerBody.velocity.magnitude <= maxSpeed)
                {
                    _walk.Walk(); // Walking <- Need add speed limit
                    //_run.Run(); // Running <- Need add speed limit
                    //_crouch.Crouch(); // Crouching <- Here is getting bug( Can't keep onGround )
                    //Debug.Log(_playerBody.velocity.magnitude);
                }
            }
        }
        private void Jump()
        {
            //Debug.Log("Double Jump : " + STATUS.doubleJump);
            if (STATUS.isGrounded)
            {
                STATUS.doubleJump = true;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (STATUS.isGrounded)
                {
                    _jump.Jump();
                }
                else
                {
                    if (STATUS.doubleJump)
                    {
                        _doubleJump.DoubleJump();
                        STATUS.doubleJump = false;
                    }
                }
            }
        }
        #endregion

        #region Player status controller space
        private void PlayerMouseInputEnable()
        {
            STATUS.mouseRock = false;
        }
        private void PlayerMouseInputDisable()
        {
            STATUS.mouseRock = true;
        }
        private void PlayerKeyInputEnable()
        {
            STATUS.keyLock = false;
        }
        private void PlayerKeyInputDisable()
        {
            STATUS.keyLock = true;
        }
        private void InputEnablesController()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && keyEscape == 0)
            {
                keyEscape = 1;
                PlayerMouseInputDisable();
                PlayerKeyInputDisable();
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (Input.GetKeyDown(KeyCode.Escape) && keyEscape == 1)
            {
                keyEscape = 0;
                PlayerMouseInputEnable();
                PlayerKeyInputEnable();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                //Debug.Log("Cursor Visible : " + Cursor.visible);
            }

            if (Input.GetKeyDown(KeyCode.Tab) && keyTab == 0)
            {
                keyTab = 1;
                PlayerMouseInputDisable();
                PlayerKeyInputEnable();
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
            else if (Input.GetKeyDown(KeyCode.Tab) && keyTab == 1)
            {
                keyTab = 0;
                PlayerMouseInputEnable();
                PlayerKeyInputEnable();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
        private void PlayerGroundChecker()
        {
            // Here can check for player is ground or not ground.
            if (_playerUnderRay.underDistance <= 1.0f)
            {
                STATUS.isGrounded = true;
            }
            if (_playerUnderRay.underDistance > 1.0f)
            {
                STATUS.isGrounded = false;
            }
        }
        private void PlayerLeftWallChecker()
        {
            if (STATUS.isGrounded == false && _playerLeftRay.leftRayDistance <= 0.5f)
            {
                STATUS.onLeftWall = true;
            }
            else if (STATUS.isGrounded == false && _playerLeftRay.leftRayDistance > 0.5f)
            {
                STATUS.onLeftWall = false;
            }
            else
            {
                STATUS.onLeftWall = false;
            }
        }
        private void PlayerRightWallChecker()
        {
            if (STATUS.isGrounded == false && _playerRightRay.rightRayDistance <= 0.5f)
            {
                STATUS.onRightWall = true;
            }
            else if (STATUS.isGrounded == false && _playerRightRay.rightRayDistance > 0.5f)
            {
                STATUS.onRightWall = false;
            }
            else
            {
                STATUS.onRightWall = false;
            }
        }
        #endregion
    }
}
