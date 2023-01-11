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
            hitScore += greenHitScore;

            // Player hit sudio
            audioSource.PlayOneShot(hitTargetSound);
        }
    }
}
