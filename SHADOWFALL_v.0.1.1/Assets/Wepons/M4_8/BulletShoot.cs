//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region BulletShoot : Monobehaviour
// Fire the bullet
// If player mouse down, fire the bullet
// Single fire only
#endregion

using System;
using UnityEngine;

namespace SHADOWFALL
{
    public class BulletShoot : MonoBehaviour
    {

        private PlayerMovements input_manager;
        public GameObject bullet;
        private Rigidbody rb;
        //public float fireRate = 0.1f;
        //private float nextFire = 0.0f;

        public float bulletSpeed = 1000f;

        public AudioClip shootSound;
        private AudioSource audioSource;

        private void Awake()
        {
            input_manager = GetComponent<PlayerMovements>();
            audioSource = GetComponent<AudioSource>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb = Instantiate(bullet, transform.position, transform.rotation).GetComponent<Rigidbody>();

                rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
                audioSource.PlayOneShot(shootSound);
            }

            // if (Input.GetMouseButton(0) && Time.time > nextFire)
            // {
            //     nextFire = Time.time + fireRate;
            //     rb = Instantiate(bullet, transform.position, transform.rotation).GetComponent<Rigidbody>();

            //     rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
            //     audioSource.PlayOneShot(shootSound);
            // }
        }

        // private void OnCollisionEnter( Collision collision )
        // {
        //     if (collision.gameObject.CompareTag( "Target" ))
        //     {
        //         input_manager.PLAYERSTATUS.score += 15;

        //         //Destroy( collision.gameObject );
        //     }
        //     else
        //     {
        //         input_manager.PLAYERSTATUS.score /= 3;
        //     }
        // }
    }
}
