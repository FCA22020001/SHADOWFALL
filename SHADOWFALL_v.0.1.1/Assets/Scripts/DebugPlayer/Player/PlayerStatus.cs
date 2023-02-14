//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region PlayerStatus : NULL
// Script description
#endregion


using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class PlayerStatus
    {
        private float _score;

        public bool mouseLock {get; set;} = false;
        public bool keyLock {get; set;} = false;

        public bool isGrounded {get; set;} = false;
        public bool onLeftWall {get; set;} = false;
        public bool onRightWall {get; set;} = false;

        public bool running {get; set;} = false;
        public bool doubleJump {get; set;} = false;

        public float score
        {
            get => _score;
            set
            {
                _score = value;
                if(_score <= 0) _score = 0;
            }
        }

        public string ScoreText => score.ToString("0") + "point";
    }
}

