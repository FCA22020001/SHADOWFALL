//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region GunFire : MonoBehaviour
// This script is player's Attack function
// Now can fire raycast only.
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class GunFire : MonoBehaviour
    {
        // private RaycastHit FireRayHit;
        // [SerializeField] private LayerMask layerMask;
        [Header("Scripts")]
        [SerializeField] PlayerMovements playerMovements;

        [Header("Objects")]
        [SerializeField] public GameObject rayHitObject;
        [SerializeField] private GameObject nullObject;

        [Header("Audio")]
        private AudioSource audioSource;
        [SerializeField] private AudioClip fireSound;

        void Start()
        {
            // Get audio source
            audioSource = gameObject.GetComponent<AudioSource>();
        }
        void Update()
        {
            Fire();
        }
        
        private void Fire()
        {
            // Player's mouse is not lokking
            if (playerMovements.PLAYERSTATUS.mouseLock == false)
            {
                // Player is fire raycast
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    // Play sound
                    audioSource.PlayOneShot(fireSound);

                    // Check raycast hit object
                    if(Physics.Raycast(playerMovements._playerHead.transform.position, playerMovements._playerHead.transform.forward, out var FireRayHit, 1000))
                    {
                        // If hit object, set hitted object
                        rayHitObject = FireRayHit.collider.gameObject;
                        Debug.Log("Target object : " + rayHitObject);
                    }
                    else
                    {
                        // If not hit object, set null object
                        rayHitObject = nullObject;
                        Debug.Log("Target object : " + rayHitObject);
                    }

                    // If layer numer 7 and rayhit target object is equal, score plus 15
                    if (rayHitObject.layer == 7 && rayHitObject.gameObject.GetComponent<HitAction>().hit == false)
                    {
                        playerMovements.PLAYERSTATUS.score += 15;
                        // Debug.Log("Score +15 : Done : Currently score is " + playerMovements.PLAYERSTATUS.score);
                    }
                    else
                    {
                        //If can't hit target object, score / 3
                        var score = playerMovements.PLAYERSTATUS.score;
                        score /= 3;
                        //playerMovements.PLAYERSTATUS.score = (int)score;
                        playerMovements.PLAYERSTATUS.score = Mathf.FloorToInt(score);
                        Debug.Log("Score /3 : Done : Currently score is " + playerMovements.PLAYERSTATUS.score);
                    }
                }
            }
        }
    }
}
