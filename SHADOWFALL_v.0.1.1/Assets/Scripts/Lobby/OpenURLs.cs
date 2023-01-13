//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region OpenURLs : MonoBehaviour
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class OpenURLs : MonoBehaviour
    {
        public void discordOpen()
        {
            Application.OpenURL("https://discord.com/invite/fWd4FvVnaH");
        }

        public void sourceCodeOpen()
        {
            Application.OpenURL("https://github.com/FCA22020001/SHADOWFALL");
        }
    }
}
