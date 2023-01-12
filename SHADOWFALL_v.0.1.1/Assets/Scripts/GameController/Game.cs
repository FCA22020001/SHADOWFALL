//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region Game : Monobehavior
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class Game : MonoBehaviour
    {
        [SerializeField] GameDirector director;

        void Awake()
        {
            director.onAwake();
        }
        void Start()
        {
            director.onStart();
        }
        void Update()
        {
            director.CountdownTimer();
        }
        void FixedUpdate()
        {
            director.onFixedUpdate();
        }
    }
}
