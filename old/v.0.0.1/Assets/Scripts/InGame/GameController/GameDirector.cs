using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class GameDirector : MonoBehaviour
    {
        [Header("Timer score")]
        protected Time score_time;
        protected float score_time_recent;
        protected float score_time_mostfast;

        [Header("Target score")]
        protected float score_targethit_maximum;
        protected float score_targethit_recent;
        protected float score_targethit_current;

        protected PlayerStatus _playerStatus = new PlayerStatus();

        private void Awake()
        {

        }
        private void Start()
        {

        }
        private void Update()
        {

        }
    }
}
