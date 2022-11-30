using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerStatusController : MonoBehaviour
    {
        private PlayerStatus playerStatus = new PlayerStatus();
        private MovementCore movementCore;

        #region void for unity
        private void Awake()
        {
            movementCore = GetComponent<MovementCore>();
            movementCore.Initialize(playerStatus);
        }
        private void Start()
        {
            movementCore.onStart();
        }

        private void Update()
        {
            movementCore.onUpdate();
        }

        private void FixedUpdate()
        {
            movementCore.onFixedUpdate();
        }
        #endregion
    }
}
