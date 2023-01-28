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

        void Start()
        {
            MOVEMENTS = GetComponent<PlayerMovements>();

            // Change mouse lock
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Get score form before scene
            float resultScore = PlayerPrefs.GetFloat("SCORE");

            // Set score and edit text in result scene.
            float score = (int)resultScore;
            scoreText.text = score.ToString() + " point";

        }
    }
}
