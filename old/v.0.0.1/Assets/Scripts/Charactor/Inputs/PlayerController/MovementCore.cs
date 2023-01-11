using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class MovementCore : MonoBehaviour
    {
        // Player's status get here from PlayerStatus.cs
        private PlayerStatus _playerStatus = new PlayerStatus();

        // Get player's movement scripts here from MovementController.cs
        private MovementController _movementController;


        private void Awake()
        {
            _movementController = GetComponent<MovementController> ();
            _movementController.Initialize();
        }

        private void Start()
        {

        }

        private void Update()
        {
            _movementController.onUpdate();
        }

        private void FixedUpdate()
        {
            
        }
    }
}
