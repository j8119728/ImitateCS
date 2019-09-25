using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单发枪
/// </summary>
public class SingleGun : Gun
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // base.Firing(枪口方向);
        }
    }
}
