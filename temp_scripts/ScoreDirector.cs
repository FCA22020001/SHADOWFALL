//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region ScoreDirector : MonoBehavior
// Player getting score's director
// This script can change player's score.
#endregion

using System;
using UnityEngine;
using UnityEngine.UI;

namespace SHADOWFALL
{
    public class ScoreDirector : MonoBehavior
    {
        private GameDirector DIRECTOR;
        private PlayerMovements MOVEMENTS;

        private void Awake()
        {
            DIRECTOR = GetComponent<GameDirector>();
            MOVEMENTS = GetComponent<PlayerMovements>();
        }

        private void Start()
        {
            MOVEMENTS.PLAYERSTATUS.score = 0;
        }

        private void Update()
        {
            //
        }

        private void checkHitObject()
        {
            
        }
    }
}
