//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GunFire : PlayerMovements
// Script description
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class GunFire : PlayerMovements
    {
        private RaycastHit FireRayHit;

        [Header("Objects")]
        [SerializeField] public GameObject rayHitObject;
        [SerializeField] private GameObject nullObject;

        [Header("Audio")]
        private AudioSource audioSource;
        [SerializeField] private AudioClip fireSound;

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
            if (DIRECTOR.PLAYERSTATUS.mouseRock == false)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    audioSource.PlayOneShot(fireSound);

                    if(Physics.Raycast(_playerHead.transform.position, _playerHead.transform.forward, out FireRayHit, 1000))
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
                        DIRECTOR.PLAYERSTATUS.score += 15;
                    }
                    else if(rayHitObject.layer == 7 && rayHitObject.gameObject.GetComponent<HitAction>().hit == true)
                    {
                        return;
                    }
                    else
                    {
                        DIRECTOR.PLAYERSTATUS.score /= 3;
                    }

                    Debug.Log(" Score : " + DIRECTOR.PLAYERSTATUS.score);
                }
            }
        }
    }
}
