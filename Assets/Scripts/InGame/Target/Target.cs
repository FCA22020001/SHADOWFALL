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
            // Get target plate gameobjects.
            // This plate is focus the player.
            targetPlate = GetComponent<GameObject>();

            // Get audio source.
            // This audio source is hitTargetSound.
            audioSource = GetComponent<AudioSource>();

            // If bullets are hit, change the target's color.
            _targetHitColor = GetComponent<TargetHitColor>();

            // If bullets are hit, calculate score and play sound.
            _cyanTargetHit = GetComponent<CyanTargetHit>();
            _blueTargetHit = GetComponent<BlueTargetHit>();
            _greenTargetHit = GetComponent<GreenTargetHit>();
        }

        // If bullet is hit the target, do hitBullet().
        private void OnCollisionEnter(Collision collision)
        {
            // If bullet is hit target, do void hitBullet(); scripts.
            if (collision.gameObject.tag == "bullet") hitBullet();
        }

        public void hitBullet()
        {
            // If bullet is enter the target, check target's color and caluculate hitScore.
            // If hit cyan target, current score + 2.
            if (targetPlate.GetComponent<Renderer>().material.color == Color.cyan) _cyanTargetHit.TargetHit();
            // If hit blue target, current score + 5.
            if (targetPlate.GetComponent<Renderer>().material.color == Color.blue) _blueTargetHit.TargetHit();
            // If hit green target, current score + 7.
            if (targetPlate.GetComponent<Renderer>().material.color == Color.green) _greenTargetHit.TargetHit();

            // Change the taget object color to red.
            _targetHitColor.setTargetColorRed();
        }
    }
}
