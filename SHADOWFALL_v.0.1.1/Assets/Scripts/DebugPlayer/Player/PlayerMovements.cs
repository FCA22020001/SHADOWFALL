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
using UnityEngine.UI;

namespace SHADOWFALL
{
    public class PlayerMovements : MonoBehaviour
    {
        #region Player body component
        [SerializeField] public Rigidbody _playerBody;
        [SerializeField] public Transform _playerHead;
        [SerializeField] public Transform _playerLeftShoulder;
        [SerializeField] public Transform _playerRightShoulder;
        [SerializeField] public Transform _playerFoot;

        [Header("Player status")]
        public PlayerStatus PLAYERSTATUS = new PlayerStatus();
        #endregion
        #region Script space
        // Game Controller
        [SerializeField] protected GameDirector DIRECTOR;
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
        #region User interface
        [SerializeField] protected GameObject ui_BackGround;
        [SerializeField] protected GameObject ui_EscapeKeyButtonHolder;
        #endregion
        #region Input configuration
        [SerializeField] protected float mouseSensitivity = 7f;
        #endregion

        #region Temporary variables
        protected bool keyEscape, keyTab, jumpCount;
        protected int layerMask_Ground = 6, layerMask_Slope = 9,layerMask_Zipline = 10, layerMask_Stairs = 11, layerMask_Ladder = 12, layerMask_RunnableWall = 13;
        #endregion


        public void onAwake()
        {
            //Debug.Log("Loading datas...");
            ResetPlayerGear();
            ResetPlayerInputStatus();
        }
        public void onStart()
        {
            //Debug.Log("Loading scripts...");
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
        private void ResetPlayerInputStatus()
        {
            keyEscape = false;
            keyTab = false;
            jumpCount = false;
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
            if (PLAYERSTATUS.mouseLock == false)
            {
                _look.Look();
            }
        }
        private void NormalMovement()
        {
            if (PLAYERSTATUS.keyLock == false)
            {
                if (_playerBody.velocity.magnitude <= runSpeed)
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
            if (PLAYERSTATUS.keyLock == false)
            {
                //Debug.Log("Double Jump : " + STATUS.doubleJump);
                if (PLAYERSTATUS.isGrounded)
                {
                    PLAYERSTATUS.doubleJump = true;
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (PLAYERSTATUS.isGrounded)
                    {
                        _jump.Jump();
                    }
                    else
                    {
                        if (PLAYERSTATUS.doubleJump)
                        {
                            _doubleJump.DoubleJump();
                            PLAYERSTATUS.doubleJump = false;
                        }
                    }
                }
            }
        }
        #endregion

        #region Player status controller space
        public void PlayerMouseInputEnable()
        {
            PLAYERSTATUS.mouseLock = false;
        }
        public void PlayerMouseInputDisable()
        {
            PLAYERSTATUS.mouseLock = true;
        }
        public void PlayerKeyInputEnable()
        {
            PLAYERSTATUS.keyLock = false;
        }
        public void PlayerKeyInputDisable()
        {
            PLAYERSTATUS.keyLock = true;
        }
        private void InputEnablesController()
        {
            if (DIRECTOR.timerSec >= 0f)
            {
                PlayerMouseInputEnable();
                PlayerKeyInputEnable();
            }
            else
            {
                PlayerMouseInputDisable();
                PlayerKeyInputDisable();
            }

            if (DIRECTOR.coutdownSeconds <= 1f && DIRECTOR.timerSec >= 1f)
            {
                if (Input.GetKeyDown(KeyCode.Escape) && keyEscape == false)
                {
                    keyEscape = true;
                    PlayerMouseInputDisable();
                    PlayerKeyInputDisable();

                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
                else if (Input.GetKeyDown(KeyCode.Escape) && keyEscape == true)
                {
                    keyEscape = false;
                    PlayerMouseInputEnable();
                    PlayerKeyInputEnable();
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    //Debug.Log("Cursor Visible : " + Cursor.visible);
                }

                if (Input.GetKeyDown(KeyCode.Tab) && keyTab == false)
                {
                    keyTab = true;
                    PlayerMouseInputDisable();
                    PlayerKeyInputEnable();
                    Cursor.lockState = CursorLockMode.Confined;
                    Cursor.visible = true;
                }
                else if (Input.GetKeyDown(KeyCode.Tab) && keyTab == true)
                {
                    keyTab = false;
                    PlayerMouseInputEnable();
                    PlayerKeyInputEnable();
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                }
            }
            // else
            // {
            //     keyEscape = false;
            //     PlayerMouseInputDisable();
            //     PlayerKeyInputDisable();
            //     //Cursor.lockState = CursorLockMode.Locked;
            //     //Cursor.visible = false;
            // }
            
        }
        private void PlayerGroundChecker()
        {
            // Here can check for player is ground or not ground.
            if (_playerUnderRay.underDistance <= 1.0f)
            {
                PLAYERSTATUS.isGrounded = true;
            }
            if (_playerUnderRay.underDistance > 1.0f)
            {
                PLAYERSTATUS.isGrounded = false;
            }
        }
        private void PlayerLeftWallChecker()
        {
            if (PLAYERSTATUS.isGrounded == false && _playerLeftRay.leftRayDistance <= 0.5f)
            {
                PLAYERSTATUS.onLeftWall = true;
            }
            else if (PLAYERSTATUS.isGrounded == false && _playerLeftRay.leftRayDistance > 0.5f)
            {
                PLAYERSTATUS.onLeftWall = false;
            }
            else
            {
                PLAYERSTATUS.onLeftWall = false;
            }
        }
        private void PlayerRightWallChecker()
        {
            if (PLAYERSTATUS.isGrounded == false && _playerRightRay.rightRayDistance <= 0.5f)
            {
                PLAYERSTATUS.onRightWall = true;
            }
            else if (PLAYERSTATUS.isGrounded == false && _playerRightRay.rightRayDistance > 0.5f)
            {
                PLAYERSTATUS.onRightWall = false;
            }
            else
            {
                PLAYERSTATUS.onRightWall = false;
            }
        }
        #endregion

        #region UI Conntroller
        private void EscapeKeyUI()
        {
            if (keyEscape == true)
            {
                ui_BackGround.gameObject.SetActive(true);
                ui_EscapeKeyButtonHolder.gameObject.SetActive(true);
            }
            if (keyEscape == false)
            {
                ui_BackGround.gameObject.SetActive(false);
                ui_EscapeKeyButtonHolder.gameObject.SetActive(false);
            }
        }
        #endregion
    }
}
