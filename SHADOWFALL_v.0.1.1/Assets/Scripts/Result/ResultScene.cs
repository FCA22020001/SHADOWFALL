using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SHADOWFALL
{
    public class ResultScene : MonoBehaviour
    {
        private PlayerMovements MOVEMENTS;
        [SerializeField] private Text scoreText;

        // Start is called before the first frame update
        void Start()
        {
            MOVEMENTS = GetComponent<PlayerMovements>();

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Get score
            float score = (int)MOVEMENTS.PLAYERSTATUS.score;
            scoreText.text = score.ToString() + " point";

        }
    }
}
