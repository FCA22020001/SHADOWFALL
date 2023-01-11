//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region HitAction : SUCCESSION
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class HitAction : MonoBehaviour
    {
        [Header("Object")]
        [SerializeField] private GameObject Target;

        [Header("Script")]
        [SerializeField] private GunFire fire;
        void Start()
        {
            Target = this.gameObject;
        }

        void Update()
        {
            hitEffect();
        }

        private void hitEffect()
        {
            if (Target == fire.rayHitObject)
            {
                this.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
