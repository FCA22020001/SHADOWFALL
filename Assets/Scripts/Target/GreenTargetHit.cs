using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class GreenTargetHit : Target
    {
        public void TargetHit()
        {
            // Add hit score
            hitScore += 7;

            // Player hit sudio
            audioSource.PlayOneShot(hitTargetSound);
        }
    }
}
