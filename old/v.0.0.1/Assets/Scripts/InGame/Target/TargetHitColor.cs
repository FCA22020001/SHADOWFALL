using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class TargetHitColor : Target
    {
        public void setTargetColorRed()
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
