//
//  SHADOWFALL
//      Created by Okumura Naofumi
//      Released by LAPLACE Network ( https://discord.gg/fWd4FvVnaH )
//

#region TargetGenerator : MonoBehaviour
// Script description
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class TargetGenerator : MonoBehaviour
    {
        [Header("Target object")]
        [SerializeField] private GameObject Target_0;
        [SerializeField] private GameObject Target_0_inMinimap;
        [SerializeField] private GameObject Target_1;
        [SerializeField] private GameObject Target_1_inMinimap;
        [SerializeField] private GameObject Target_2;
        [SerializeField] private GameObject Target_2_inMinimap;
        [SerializeField] private GameObject Target_3;
        [SerializeField] private GameObject Target_3_inMinimap;
        [SerializeField] private GameObject Target_4;
        [SerializeField] private GameObject Target_4_inMinimap;
        [SerializeField] private GameObject Target_5;
        [SerializeField] private GameObject Target_5_inMinimap;
        [SerializeField] private GameObject Target_6;
        [SerializeField] private GameObject Target_6_inMinimap;
        [SerializeField] private int targetSpawnLimit; // Currently 4
        [SerializeField] private int currentLaunchTarget; // Target launch amount
        [SerializeField] bool rdy_T0, rdy_T1, rdy_T2, rdy_T3, rdy_T4, rdy_T5, rdy_T6;

        [Header("Variables")]
        private float positionX; // -240 ~ 240
        private float positionY; // 2.5 ~ 55.0
        private float positionZ; // -240 ~ 240

        [Header("Scripts")]
        [SerializeField] private HitAction hittingBullet_0;
        [SerializeField] private HitAction hittingBullet_1;
        [SerializeField] private HitAction hittingBullet_2;
        [SerializeField] private HitAction hittingBullet_3;
        [SerializeField] private HitAction hittingBullet_4;
        [SerializeField] private HitAction hittingBullet_5;
        [SerializeField] private HitAction hittingBullet_6;

        void Awake()
        {
            onAwakeSetTargetStatus();
        }
        void Start()
        {
            // Set current launching target amount
            currentLaunchTarget = 0;

            onStartTargetLaunch();
        }
        void Update()
        {
            //
        }
        void FixedUpdate()
        {
            // Launch target
            TargetCore();
            // Hide and standby target
            TargetHide();
        }

        private void TargetCore()
        {
            if(currentLaunchTarget <= 4)
            {
                if (rdy_T0 == true)
                {
                    CaluculateTargetZeroPosition(); // If ready for target 0, launch target 0.
                }
                if (rdy_T1 == true)
                {
                    CaluculateTargetOnePosition(); // If ready for target 1, launch target 1.
                }
                if (rdy_T2  == true)
                {
                    CaluculateTargetTwoPosition(); // If ready for target 2, launch target 2.
                }
                if (rdy_T3 == true)
                {
                    CaluculateTargetThreePosition(); // If ready for target 3, launch target 3.
                }
                if (rdy_T4 == true)
                {
                    CaluculateTargetFourPosition(); // If ready for target 3, launch target 3.
                }
                if (rdy_T5 == true)
                {
                    CaluculateTargetFivePosition(); // If ready for target 3, launch target 3.
                }
                if (rdy_T6 == true)
                {
                    CaluculateTargetSixPosition(); // If ready for target 3, launch target 3.
                }
            }
            if (currentLaunchTarget <= 0)
            {
                currentLaunchTarget = 0;
            }
        }
        public void TargetHide()
        {
            if (hittingBullet_0.hit == true)
            {
                Target_0.transform.position = new Vector3(0, -15, 0);
                rdy_T0 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_0_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_0.GetComponent<Renderer>().material.color = Color.green;
                Target_0_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_0.GetComponent<HitAction>().hit = false;
            }
            if (hittingBullet_1.hit == true)
            {
                Target_1.transform.position = new Vector3(0, -15, 0);
                rdy_T1 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_1_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_1.GetComponent<Renderer>().material.color = Color.green;
                Target_1_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_1.GetComponent<HitAction>().hit = false;
            }
            if (hittingBullet_2.hit == true)
            {
                Target_2.transform.position = new Vector3(0, -15, 0);
                rdy_T2 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_2_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_2.GetComponent<Renderer>().material.color = Color.green;
                Target_2_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_2.GetComponent<HitAction>().hit = false;
            }
            if (hittingBullet_3.hit == true)
            {
                Target_3.transform.position = new Vector3(0, -15, 0);
                rdy_T3 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_3_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_3_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_3.GetComponent<HitAction>().hit = false;
            }
            if (hittingBullet_4.hit == true)
            {
                Target_4.transform.position = new Vector3(0, -15, 0);
                rdy_T4 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_4_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_4_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_4.GetComponent<HitAction>().hit = false;
            }
            if (hittingBullet_5.hit == true)
            {
                Target_5.transform.position = new Vector3(0, -15, 0);
                rdy_T5 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_5_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_5_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_5.GetComponent<HitAction>().hit = false;
            }
            if (hittingBullet_6.hit == true)
            {
                Target_6.transform.position = new Vector3(0, -15, 0);
                rdy_T6 = true;
                currentLaunchTarget -= 1;

                // Set visualization
                Target_6_inMinimap.gameObject.SetActive(false);

                // Reset target
                Target_6_inMinimap.GetComponent<Renderer>().material.color = Color.red;
                Target_6.GetComponent<HitAction>().hit = false;
            }
        }

        private void onAwakeSetTargetStatus()
        {
            rdy_T0 = false;
            rdy_T1 = false;
            rdy_T2 = false;
            rdy_T3 = false;
            rdy_T4 = false;
            rdy_T5 = false;
            rdy_T6 = false;
        }
        private void onStartTargetLaunch()
        {
            CaluculateTargetZeroPosition();
            CaluculateTargetOnePosition();
            CaluculateTargetTwoPosition();
            CaluculateTargetThreePosition();
            CaluculateTargetFourPosition();
            CaluculateTargetFivePosition();
            CaluculateTargetSixPosition();
        }

        private void CaluculateTargetZeroPosition()
        {
            
            Target_0.GetComponent<Renderer>().material.color = Color.green;
            Target_0_inMinimap.GetComponent<Renderer>().material.color = Color.green;

            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_0.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_0_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T0 = false;
        }
        private void CaluculateTargetOnePosition()
        {
            
            Target_1.GetComponent<Renderer>().material.color = Color.green;
            Target_1_inMinimap.GetComponent<Renderer>().material.color = Color.green;

            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_1.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_1_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T1 = false;
        }
        private void CaluculateTargetTwoPosition()
        {
            Target_2.GetComponent<Renderer>().material.color = Color.green;
            Target_2_inMinimap.GetComponent<Renderer>().material.color = Color.green;

            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_2.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_2_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T2 = false;
        }
        private void CaluculateTargetThreePosition()
        {
            Target_3.GetComponent<Renderer>().material.color = Color.green;
            Target_3_inMinimap.GetComponent<Renderer>().material.color = Color.green;


            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_3.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_3_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T3 = false;
        }
        private void CaluculateTargetFourPosition()
        {
            
            Target_4.GetComponent<Renderer>().material.color = Color.green;
            Target_4_inMinimap.GetComponent<Renderer>().material.color = Color.green;

            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_4.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_4_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T4 = false;
        }
        private void CaluculateTargetFivePosition()
        {
            
            Target_5.GetComponent<Renderer>().material.color = Color.green;
            Target_5_inMinimap.GetComponent<Renderer>().material.color = Color.green;

            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_5.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_5_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T5 = false;
        }
        private void CaluculateTargetSixPosition()
        {
            
            Target_6.GetComponent<Renderer>().material.color = Color.green;
            Target_6_inMinimap.GetComponent<Renderer>().material.color = Color.green;

            // Caluculate target's x
            positionX = UnityEngine.Random.Range(-240.0f, 240.0f);
            // Caluculate target's y
            positionY = UnityEngine.Random.Range(2.5f, 55.0f);
            // Caluculate target's z
            positionZ = UnityEngine.Random.Range(-240.0f, 240.0f);

            // Aooly target position
            Target_6.transform.position = new Vector3(positionX, positionY, positionZ);

            // Set visualization
            Target_6_inMinimap.gameObject.SetActive(true);

            // Set target amount
            currentLaunchTarget += 1;
            //Set ready status
            rdy_T6 = false;
        }

    }
}
