//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GameDirector : Game
// Game's director for main game scene
#endregion

using System;
using System.Text.Json;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManager;

namespace SHADOWFALL
{
    public class GameDirector : Game
    {
        [Header("Game start coutdown")]
        [SerializeField] protected Text countdownText;
        [SerializeField] protected Text startText;
        [SerializeField] private int countdown; // Set here to countdown seconds.
        [SerializeField] protected int countdownTime; // 5 sec
        public int _countdownTime;
        [Header("Game timer")]
        [SerializeField] protected Text timerText;
        [SerializeField] private int timer; // Set here to timer seconds.
        [SerializeField] protected int timerTime; // 60 sec
        public int _timerTime;

        [Header("Player's UI")]
        [SerializeField] protected gameObject crossHair;
        [SerializeField] protected gameObject score;

        [Header("Status")]
        [SerializeField] protected bool inGame;


        private void Awake()
        {
            // Reset timer
            countdownTime = countdown;
            timerTime = timer;
        }

        private void startCoutdown()
        {
            while ( countdownTime >= -1 )
            {
                countdownTime -= Time.deltaTime;

                countdownText.gameObject.SetActive(true);

                _countdownTime = (int)coutdownTime;

                countdownText.text = _countdownTime.ToString();
            }
        }
        private void gameTimer()
        {
            while ( timerTime >= 0 )
            {
                timerTime -= Time.deltaTime;

                timerText.gameObject.SetActive(true);

                _timerTime = (int)timerTime;

                timerText.text = _timerTime.ToString();

                inGame = true;
            }
            if (timerTime == 0)
            {
                inGame = false;
            }
        }

        private void playerUIController()
        {
            while (inGame)
            {
                enableCrossHair();
                enableScore();
            }
            while (!inGame)
            {
                disableCrossHair();
                disableScore();
            }
        }
        private void enableCrossHair()
        {
            crossHair.gameObject.SetActive(true);
        }
        private void enableScore()
        {
            score.gameObject.SetActive(true);
        }
        private void disableCrossHair()
        {
            crossHair.gameObject.SetActive(false);
        }
        private void disableScore()
        {
            score.gameObject.SetActive(false);
        }
    }
}
