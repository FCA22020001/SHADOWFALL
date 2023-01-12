//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GunFire : SUCCESSION
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class GunFire : MonoBehaviour
    {
        [SerializeField] private Transform head;
        private RaycastHit FireRayHit;

        [Header("Objects")]
        [SerializeField] public GameObject rayHitObject;
        [SerializeField] private GameObject nullObject;

        [Header("Audio")]
        private AudioSource audioSource;
        [SerializeField] private AudioClip fireSound;

        protected PlayerStatus STATUS = new PlayerStatus();

        void Start()
        {
            audioSource = gameObject.GetComponent<AudioSource>();
        }
        void Update()
        {
            Fire();
        }
        
        private void Fire()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                audioSource.PlayOneShot(fireSound);

                if(Physics.Raycast(head.transform.position, head.transform.forward, out FireRayHit, 1000))
                {
                    rayHitObject = FireRayHit.collider.gameObject;
                    //Debug.Log("Target object : " + rayHitObject);
                }
                else
                {
                    rayHitObject = nullObject;
                }

                if (rayHitObject.layer == 7 && rayHitObject.gameObject.GetComponent<HitAction>().hit == false)
                {
                    STATUS.score += 1;
                }

                //Debug.Log(" Score : " + STATUS.score);
            }
        }
    }
}
