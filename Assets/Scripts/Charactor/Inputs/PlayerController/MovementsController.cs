using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class MovementController : MovementCore
    {
        // If you use these variables, you must set protected.
        // It can use only in children class.
        #region Player body components
        protected Rigidbody _playerBody;
        protected Transform _playerCamera;
        #endregion

        // If you use these variables, you must set protected.
        // These variables can use in children class.
        #region Configulation scripts
        // Player's key/mouse configulation
        protected KeyConfig _playerKeyConfig;
        #endregion

        // If you use these variables, you must set protected.
        // If you create children scripts, you must use in inheritance MovementController.
        // These variables use in children scripts.
        #region Movement scripts
        // Player status variables scripts
        protected PlayerStatus _playerStatus;
        // Movement horizontal/vertical input
        protected HorizontalInput _playerKeyHorizontal;
        protected VerticalInput _playerKeyVertical;
        #endregion
        #region Look scripts
        // Look around
        protected Look _playerLook;
        // Look mouse input
        protected MouseXInput _playerMouseX;
        protected MouseYInput _playerMouseY;
        #endregion


        public void Initialize(PlayerStatus playerStatus)
        {
            _playerStatus = playerStatus;
            getComponents();
            getScripts();
        }
        public void onUpdate()
        {
            Look();
        }


        private void getComponents()
        {
            // Get player's body rigidbody(collision)
            _playerBody = GetComponent<Rigidbody>();
        }
        private void getScripts()
        {
            // Get keyconfig scripts.
            _playerKeyConfig = GetComponent<KeyConfig>();

            // Get inputs scripts
            _playerMouseX = GetComponent<MouseXInput>();
            _playerMouseY = GetComponent<MouseYInput>();
            _playerKeyHorizontal = GetComponent<HorizontalInput>();
            _playerKeyVertical = GetComponent<VerticalInput>();

            // Get normal movement scripts.
            _playerLook = GetComponent<Look>();
        }


        private void Look()
        {
            if (_playerStatus.mouseInputEnables == true) _playerLook.playerLook();
        }

        private void Movement()
        {
            // Keyboard input enable.
            //if (_playerStatus.keyboardInputEnables == true)
            //{
            // Walking
            //if (_playerStatus.walking == true && _playerStatus.running == false) _playerWalk.playerWalk();

            // Running
            // if (_playerStatus.walking == false && _playerStatus.running == true) _playerDash.playerDash();

            // Jumping
            // if (_playerStatus.grounded == true) _playerJump.playerJump();

            // Crouching
            // if (_playerStatus.walking == true && _playerStatus.running == false) _playerCrouch.playerCrouch();

            // Sliding
            // if (_playerStatus.walking == false && _playerStatus.running == true) _playerSliding.playerSliding();

            // Double jump
            // if (_playerStatus.grounded == false && _playerStatus.candoubleJump == true) _playerDoubleJump.playerDoubleJump();

            // Wall running
            // if (_playerStatus.grounded == false && _playerStatus.wallrunning == true){
            //     if (_playerStatus.isLeftWall == true) _playerWallrunLeft.playerWallrunLeft();
            //     if (_playerStatus.isRightWall == true) _playerWallrunRight.playerWallrunRight();
            // }
            //}
        }
    }
}
