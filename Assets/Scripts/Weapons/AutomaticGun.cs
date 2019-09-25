using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 连发枪
/// </summary>
public class AutomaticGun : Gun
{
    protected override void Stark()
    {
        base.Stark();
        print(22);
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            print("连发");
        }
    }
}
