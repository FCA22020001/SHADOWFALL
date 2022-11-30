using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    [ExecuteInEditMode]
    public class TestRaycast : MonoBehaviour
    {
        [SerializeField] private Rigidbody box;

        // Start is called before the first frame update
        void Start()
        {
            box = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            // Normal raycast
            forwardRaycast();
            backwardRaycast();
            rightRaycast();
            leftRaycast();

            // Naname houkou raycast
            forwardRightRaycast();
            forwardLeftRaycast();
            backwardRightRaycast();
            backwardLeftRaycast();

            // Upside raycast
            upRaycast();
            upRightRaycast();
            upLeftRaycast();
            upForwardRightRaycast();
            upForwardLeftRaycast();

            // Downside raycast
            downRaycast();
            downRightRaycast();
            downLeftRaycast();
            downForwardRightRaycast();
            downForwardLeftRaycast();
        }

        private void forwardRaycast(){
            RaycastHit forwardHit;
            Physics.Raycast(box.transform.position, box.transform.forward, out forwardHit);
            Debug.DrawRay(box.transform.position, box.transform.forward, Color.yellow, 10f);
        }
        private void backwardRaycast(){
            RaycastHit backwardHit;
            Physics.Raycast(box.transform.position, -box.transform.forward, out backwardHit);
            Debug.DrawRay(box.transform.position, -box.transform.forward, Color.grey, 10f);
        }
        private void rightRaycast(){
            RaycastHit rightHit;
            Physics.Raycast(box.transform.position, box.transform.right, out rightHit);
            Debug.DrawRay(box.transform.position, box.transform.right, Color.magenta, 10f);
        }
        private void leftRaycast(){
            RaycastHit leftHit;
            Physics.Raycast(box.transform.position, -box.transform.right, out leftHit);
            Debug.DrawRay(box.transform.position, -box.transform.right, Color.cyan, 10f);
        }
        private void forwardRightRaycast(){
            RaycastHit forwardRightHit;
            Physics.Raycast(box.transform.position, box.transform.forward + box.transform.right, out forwardRightHit);
            Debug.DrawRay(box.transform.position, box.transform.forward + box.transform.right, Color.red, 10f);
        }
        private void forwardLeftRaycast(){
            RaycastHit forwardLeftHit;
            Physics.Raycast(box.transform.position, box.transform.forward + -box.transform.right, out forwardLeftHit);
            Debug.DrawRay(box.transform.position, box.transform.forward + -box.transform.right, Color.black, 10f);
        }
        private void backwardRightRaycast(){
            RaycastHit backwardRightHit;
            Physics.Raycast(box.transform.position, -box.transform.forward + box.transform.right, out backwardRightHit);
            Debug.DrawRay(box.transform.position, -box.transform.forward + box.transform.right, Color.blue, 10f);
        }
        private void backwardLeftRaycast(){
            RaycastHit backwardLeftHit;
            Physics.Raycast(box.transform.position, -box.transform.forward + -box.transform.right, out backwardLeftHit);
            Debug.DrawRay(box.transform.position, -box.transform.forward + -box.transform.right, Color.white, 10f);
        }
        private void upRaycast(){
            RaycastHit upHit;
            Physics.Raycast(box.transform.position, box.transform.up, out upHit);
            Debug.DrawRay(box.transform.position, box.transform.up, Color.green, 10f);
        }
        private void downRaycast(){
            RaycastHit downHit;
            Physics.Raycast(box.transform.position, -box.transform.up, out downHit);
            Debug.DrawRay(box.transform.position, -box.transform.up, Color.green, 10f);
        }
        private void upRightRaycast(){
            RaycastHit upRightHit;
            Physics.Raycast(box.transform.position, box.transform.up + box.transform.right, out upRightHit);
            Debug.DrawRay(box.transform.position, box.transform.up + box.transform.right, Color.green, 10f);
        }
        private void upLeftRaycast(){
            RaycastHit upLeftHit;
            Physics.Raycast(box.transform.position, box.transform.up + -box.transform.right, out upLeftHit);
            Debug.DrawRay(box.transform.position, box.transform.up + -box.transform.right, Color.green, 10f);
        }
        private void upForwardRightRaycast(){
            RaycastHit upForwardRightHit;
            Physics.Raycast(box.transform.position, box.transform.up + box.transform.right + box.transform.forward, out upForwardRightHit);
            Debug.DrawRay(box.transform.position, box.transform.up + box.transform.right + box.transform.forward, Color.green, 10f);
        }
        private void upForwardLeftRaycast(){
            RaycastHit upForwardLeftHit;
            Physics.Raycast(box.transform.position, box.transform.up + -box.transform.right + box.transform.forward, out upForwardLeftHit);
            Debug.DrawRay(box.transform.position, box.transform.up + -box.transform.right + box.transform.forward, Color.green, 10f);
        }
        private void downRightRaycast(){
            RaycastHit downRightHit;
            Physics.Raycast(box.transform.position, -box.transform.up + box.transform.right, out downRightHit);
            Debug.DrawRay(box.transform.position, -box.transform.up + box.transform.right, Color.green, 10f);
        }
        private void downLeftRaycast(){
            RaycastHit downLeftHit;
            Physics.Raycast(box.transform.position, -box.transform.up + -box.transform.right, out downLeftHit);
            Debug.DrawRay(box.transform.position, -box.transform.up + -box.transform.right, Color.green, 10f);
        }
        private void downForwardRightRaycast(){
            RaycastHit downForwardRightHit;
            Physics.Raycast(box.transform.position, -box.transform.up + box.transform.right + box.transform.forward, out downForwardRightHit);
            Debug.DrawRay(box.transform.position, -box.transform.up + box.transform.right + box.transform.forward, Color.green, 10f);
        }
        private void downForwardLeftRaycast(){
            RaycastHit downForwardLeftHit;
            Physics.Raycast(box.transform.position, -box.transform.up + -box.transform.right + box.transform.forward, out downForwardLeftHit);
            Debug.DrawRay(box.transform.position, -box.transform.up + -box.transform.right + box.transform.forward, Color.green, 10f);
        }
    }
}
