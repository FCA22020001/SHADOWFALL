using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class BlueTargetHit : Target
    {
        public void TargetHit()
        {
            // Add the score
            hitScore += blueHitScore;

            // Play hit sound
            audioSource.PlayOneShot(hitTargetSound);
        }
    }
}
