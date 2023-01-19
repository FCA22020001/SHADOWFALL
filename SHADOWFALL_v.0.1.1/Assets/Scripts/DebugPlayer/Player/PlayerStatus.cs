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

public class PlayerStatus
{
    public bool mouseLock {get; set;} = false;
    public bool keyLock {get; set;} = false;

    public bool isGrounded {get; set;} = false;
    public bool onLeftWall {get; set;} = false;
    public bool onRightWall {get; set;} = false;

    public bool running {get; set;} = false;
    public bool doubleJump {get; set;} = false;

    public float score {get; set;} = 0f;
}
