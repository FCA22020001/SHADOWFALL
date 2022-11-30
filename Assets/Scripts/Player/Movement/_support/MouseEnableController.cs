using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SHADOWFALL
{
    public class MouseEnableController : PlayerInput_mouse
    {
        // Start is called before the first frame update
        void Start()
        {
            _mouseInput.mouseInputEnabled = true;
        }
    }
}
