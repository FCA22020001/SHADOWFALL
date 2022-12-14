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
        // Player status variables scripts
        // public PlayerStatus _playerStatus;
        protected PlayerStatus _playerStatus = new PlayerStatus();
        #endregion

        // If you use these variables, you must set protected.
        // If you create children scripts, you must use in inheritance MovementController.
        // These variables use in children scripts.
        #region Movement scripts
        // Movement horizontal/vertical input
        protected HorizontalInput _playerKeyHorizontal;
        protected VerticalInput _playerKeyVertical;
        // Walking
        protected Walk _playerWalk;
        #endregion
        #region Look scripts
        // Look around
        protected Look _playerLook;
        // Look mouse input
        protected MouseXInput _playerMouseX;
        protected MouseYInput _playerMouseY;
        #endregion


        public void Initialize()
        {
            getComponents();
            getScripts();
        }
        public void onUpdate()
        {
            Look();
            Movement();
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

            // Get movement scripts.
            _playerWalk = GetComponent<Walk>();
        }


        private void Look()
        {
            if (_playerStatus.mouseInputEnables == true) _playerLook.playerLook();
        }

        private void Movement()
        {
            // Keyboard input enable.
            if (_playerStatus.keboardInputEnables == true)
            {
                ///<Summary>
                ///  
                ///</Summary>
            }
        }
    }
}
