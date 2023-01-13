//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region StartGame : MonoBehaviour
// Script description
#endregion

using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SHADOWFALL
{
    public class StartGame : MonoBehaviour
    {
        public void onClickStartButton()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
