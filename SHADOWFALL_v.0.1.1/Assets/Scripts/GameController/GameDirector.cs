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
        [SerializeField] protected Text timerText;
        [SerializeField] protected Text startText;
        [SerializeField] protected float countdownTime;
        protected int seconds;

        [Header("Game timer")]
        [SerializeField] protected Text ingameTimer;
        [SerializeField] protected Text finishText;
        [SerializeField] protected float timer;
        protected int timerSec;

        [Header("Player")]
        [SerializeField] protected GameObject crossHair;

        [Header("Player status")]
        protected PlayerStatus _playerStatus = new PlayerStatus();

        [Header("Other scripts")]
        protected HitAction scr_HitAction;

        public void onAwake()
        {
            _playerStatus.mouseRock = true;

            scr_HitAction = GetComponent<HitAction>();
        }
        public void onStart()
        {
            _playerStatus.score = 0;
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
                countdownTime -= Time.deltaTime;
                seconds = (int)countdownTime;

                Debug.Log("カウントダウン : " + seconds);

                timerText.text = seconds.ToString();
            }

            if (seconds == 0)
            {
                timerText.gameObject.SetActive(false);
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
            if (seconds <= 0)
            {
                ingameTimer.gameObject.SetActive(true);
                if (timer > 0)
                {
                    timer -= Time.deltaTime;
                    timerSec = (int)timer;
                    Debug.Log("Timer : " + timerSec);

                    ingameTimer.text = timerSec.ToString();
                }
                else if (timer <= -1)
                {
                    ingameTimer.gameObject.SetActive(false);
                    finishText.gameObject.SetActive(true);
                }
            }
        }
        public void InputAllow()
        {
            _playerStatus.mouseRock = false;
        }

        public void CrosshairEnable()
        {
            if (seconds >= -4)
            {
                crossHair.gameObject.SetActive(true);
            }
        }
    }
}
