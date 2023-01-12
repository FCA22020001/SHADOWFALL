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
    public bool mouseRock, keyLock;

    public bool isGrounded;
    public bool onLeftWall;
    public bool onRightWall;

    public bool running;
    public bool doubleJump;

    public int score;
}
