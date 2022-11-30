using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class MovementCore : MonoBehaviour
    {
        #region Components
        protected Rigidbody playerBody;
        protected Transform playerCamera;
        protected Transform playerHead;
        #endregion

        #region Scripts
        // Player settings
        protected PlayerStatus _playerStatus;
        protected KeyConfig _keyConfig;

        // Checkers
        protected GroundChecker _groundChecker;

        // Player input scripts
        protected PlayerInput_key _playerKey;
        protected PlayerInput_mouse _mouseInput;

        // Player normal movement scripts
        protected Look _playerLook;
        protected Walk _playerWalk;
        protected Dash _playerDash;
        protected Jump _playerJump;
        // protected Crouch _playerCrouch;
        protected Sliding _playerSliding;

        // Player air movement scripts
        protected DoubleJump _playerDoubleJump;

        // Player wall movement scripts
        protected Wallrun_leftwall _playerLeftWallrunning;
        protected Wallrun_leftwall _playerRightWallrunning;
        #endregion

        #region void from PlayerStatusController
        public void Initialize(PlayerStatus playerStatus)
        {
            _playerStatus = playerStatus;
            getComponents();
        }
        public void onStart()
        {
            MouseEnables();
        }

        public void onUpdate()
        {
            _playerKey.PlayerInputkey();
            Look();
        }

        public void onFixedUpdate()
        {
            _playerWalk.playerWalk();
        }
        #endregion

        #region Support scripts
        // Getting components
        private void getComponents()
        {
            // Player's status and key config script
            //_playerStatus = GetComponent<PlayerStatus>();
            _keyConfig = GetComponent<KeyConfig>();

            // Player input get script
            _playerKey = GetComponent<PlayerInput_key>();
            _mouseInput = GetComponent<PlayerInput_mouse>();

            // Player normal movement script
            _playerLook = GetComponent<Look>();
            _playerWalk = GetComponent<Walk>();

            // Get rigidbody
            playerBody = GetComponent<Rigidbody>();
        }
        #endregion

        // Mouse display disable/enable controle
        private void MouseEnables()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        // Get mouse input, move camera angle and spin player body.
        private void Look()
        {
            if (_playerStatus.mouseInput == true)
            {
                _playerLook.playerLook();
            }
        }
    }
}
