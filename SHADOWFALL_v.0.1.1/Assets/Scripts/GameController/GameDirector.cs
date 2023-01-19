//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GameDirector : Game
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
        public int coutdownSeconds;

        [Header("Game timer")]
        [SerializeField] protected Text gameTimerText;
        [SerializeField] protected Text finishText;
        [SerializeField] protected float gameTimer;
        protected int timerSec;
        protected float finishTextTimer = 5.0f;

        [Header("Player")]
        [SerializeField] protected GameObject crossHair;
        [SerializeField] protected GameObject scoreHolder;
        [SerializeField] protected Text scoreText;

        [Header("Other scripts")]
        //[SerializeField] protected HitAction scr_HitAction;
        [SerializeField] protected PlayerMovements scr_PlayerController;

        public void onAwake()
        {
            //
        }
        public void onStart()
        {
            scr_PlayerController.PLAYERSTATUS.score = 0;
        }
        public void onUpdate()
        {
            CountdownBeforeGameTimer();
            InGameTimer();
        }
        public void onFixedUpdate()
        {
            //
        }
        public void CountdownBeforeGameTimer()
        {
            if (coutdownSeconds >= -6)
            {
                coutdownText.gameObject.SetActive(true);

                countdownTime -= Time.deltaTime;
                coutdownSeconds = (int)countdownTime;
                Debug.Log(coutdownSeconds);

                //Debug.Log("カウントダウン : " + seconds);

                coutdownText.text = coutdownSeconds.ToString();
            }

            if (countdownTime <= 0 && countdownTime >= -2)
            {
                gameTimerText.gameObject.SetActive(true);
                CrosshairEnable();
            }
            if (coutdownSeconds <= 0)
            {
                coutdownText.gameObject.SetActive(false);
            }

            if (countdownTime <= 0 && countdownTime >= -5)
            {
                startText.gameObject.SetActive(true);
            }
            else
            {
                startText.gameObject.SetActive(false);
            }
        }
        public void InGameTimer()
        {
            if (timerSec >= 0 && coutdownSeconds <= 0)
            {
                gameTimerText.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(true);

                gameTimer -= Time.deltaTime;
                timerSec = (int)gameTimer;
                //Debug.Log("Timer : " + timerSec);

                ScoreCaluculator();

                gameTimerText.text = timerSec.ToString() + " seconds";

                if (timerSec == 0 || timerSec <= 0)
                {
                    gameTimerText.gameObject.SetActive(false);
                }
                if (timerSec <= 0 && timerSec >= -5)
                {
                    if (finishTextTimer <= 5.0f && finishTextTimer >= -1.0f)
                    {
                        finishTextTimer -= Time.deltaTime;

                        finishText.gameObject.SetActive(true);
                        gameTimerText.gameObject.SetActive(false);
                        scoreText.gameObject.SetActive(false);
                    }
                    else
                    {
                        finishText.gameObject.SetActive(false);
                    }
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

        public void CrosshairEnable()
        {
            if (coutdownSeconds >= -4)
            {
                crossHair.gameObject.SetActive(true);
            }
        }

        private void ScoreCaluculator()
        {
            float score = scr_PlayerController.PLAYERSTATUS.score;
            scoreText.text = score.ToString() + " point";
            Debug.Log("Score getting now : " + score);
        }
    }
}
