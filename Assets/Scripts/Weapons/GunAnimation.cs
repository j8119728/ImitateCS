using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimation : MonoBehaviour
{
    //开枪动画
    public string fireAnimName = "PlayerGun01_Fire";
    //换弹动画
    public string updateAmmoAnimName = "PlayerGun01_UpdateAmmo";
    //缺少子弹动画
    public string lackBulletAnimName = "PlayerGun01_LackBullet";

    public AnimationAction action;

    private void Awake()
    {
        //action = new AnimationAction(GetComponentInChildren<Animation>());
    }
}
