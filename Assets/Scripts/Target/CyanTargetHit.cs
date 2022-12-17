using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class CyanTargetHit : Target
    {
        public void TargetHit()
        {
            // Add hit score
            hitScore += 2;

            // Player hit sudio
            audioSource.PlayOneShot(hitTargetSound);
        }
    }
}
