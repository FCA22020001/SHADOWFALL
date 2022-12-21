using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class Target : MonoBehaviour
    {
        [Header("Target plate object")]
        protected GameObject targetPlate;

        [Header("Audio")]
        protected AudioClip hitTargetSound;
        protected AudioSource audioSource;

        [Header("Score number")]
        protected int hitScore;
        protected int cyanHitScore = 2;
        protected int blueHitScore = 5;
        protected int greenHitScore = 7;

        [Header("Scripts")]
        protected TargetHitColor _targetHitColor;
        protected CyanTargetHit _cyanTargetHit;
        protected BlueTargetHit _blueTargetHit;
        protected GreenTargetHit _greenTargetHit;

        public void Start()
        {
            targetPlate = GetComponent<GameObject>();

            audioSource = GetComponent<AudioSource>();

            _targetHitColor = GetComponent<TargetHitColor>();
            _cyanTargetHit = GetComponent<CyanTargetHit>();
            _blueTargetHit = GetComponent<BlueTargetHit>();
            _greenTargetHit = GetComponent<GreenTargetHit>();
        }

        // If bullet is hit the target, do hitBullet().
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "bullet") hitBullet();
        }

        public void hitBullet()
        {
            // If bullet is enter the target, check target's color and caluculate hitScore.
            if (targetPlate.GetComponent<Renderer>().material.color == Color.cyan) _cyanTargetHit.TargetHit();
            if (targetPlate.GetComponent<Renderer>().material.color == Color.blue) _blueTargetHit.TargetHit();
            if (targetPlate.GetComponent<Renderer>().material.color == Color.green) _greenTargetHit.TargetHit();

            // Change the taget object color.
            _targetHitColor.setTargetColorRed();
        }
    }
}
