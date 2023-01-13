//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GameDirector : SUCCESSION
// Script description
#endregion

using System;
using UnityEngine;
using UnityEngine.UI;

namespace SHADOWFALL
{
    public class GameDirector : Game
    {
        [Header("Start countdown")]
        [SerializeField] protected Text coutdownText;
        [SerializeField] protected Text startText;
        [SerializeField] protected float countdownTime;
        protected int seconds;

        [Header("Game timer")]
        [SerializeField] protected Text gameTimerText;
        [SerializeField] protected Text finishText;
        [SerializeField] protected float gameTimer;
        protected int timerSec;

        [Header("Player")]
        [SerializeField] protected GameObject crossHair;
        [SerializeField] protected GameObject scoreHolder;
        [SerializeField] protected Text scoreText;

        [Header("Player status")]
        public PlayerStatus PLAYERSTATUS = new PlayerStatus();

        [Header("Other scripts")]
        protected HitAction scr_HitAction;

        public void onAwake()
        {
            PLAYERSTATUS.mouseRock = true;
            PLAYERSTATUS.keyLock = true;

            Debug.Log("Player input status : key=" + PLAYERSTATUS.keyLock + " mouse=" + PLAYERSTATUS.mouseRock);

            scr_HitAction = GetComponent<HitAction>();
        }
        public void onStart()
        {
            PLAYERSTATUS.score = 0;
        }
        public void onUpdate()
        {
            //
        }
        public void onFixedUpdate()
        {
            GameTimer();
        }
        public void CountdownTimer()
        {
            if (seconds >= -6){
                coutdownText.gameObject.SetActive(true);
                countdownTime -= Time.deltaTime;
                seconds = (int)countdownTime;

                //Debug.Log("カウントダウン : " + seconds);

                coutdownText.text = seconds.ToString();
            }

            if (seconds == 0 || seconds <= 0)
            {
                coutdownText.gameObject.SetActive(false);

                gameTimerText.gameObject.SetActive(true);
                CrosshairEnable();
                InputAllow();
            }

            if (seconds <= 0 && seconds >= -5)
            {
                startText.gameObject.SetActive(true);
            }
            else
            {
                startText.gameObject.SetActive(false);
            }
        }
        public void GameTimer()
        {
            if (seconds <= 0 && seconds >= -10)
            {
                gameTimerText.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(true);

                gameTimer -= Time.deltaTime;
                timerSec = (int)gameTimer;
                //Debug.Log("Timer : " + timerSec);

                PlayerScoreController();

                if (gameTimer <= -1)
                {
                    gameTimerText.gameObject.SetActive(false);
                }

                gameTimerText.text = timerSec.ToString() + " seconds";

                if (gameTimer <= 0 && gameTimer >= -5)
                {
                    finishText.gameObject.SetActive(true);
                }
                else
                {
                    finishText.gameObject.SetActive(false);
                }
            }
            else
            {
                gameTimerText.gameObject.SetActive(false);
                scoreText.gameObject.SetActive(false);
            }
        }
        public void InputAllow()
        {
            PLAYERSTATUS.mouseRock = false;
            PLAYERSTATUS.keyLock = false;
        }

        public void CrosshairEnable()
        {
            if (seconds >= -4)
            {
                crossHair.gameObject.SetActive(true);
            }
        }

        private void PlayerScoreController()
        {
            scoreText.text = PLAYERSTATUS.score.ToString() + " point";
        }
    }
}
