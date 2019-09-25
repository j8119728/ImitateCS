using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    private AudioSource audioSource;
    public Transform firePos;
    public AudioClip clip;
    private GunAnimation anim;
    //为子类提供重写的机会
    protected virtual  void Stark()
    {
        anim = GetComponent<GunAnimation>();
    }

    /// <summary>
    /// 开火
    /// </summary>
    /// <param name="direction">子弹方向</param>
    public void Firing(Vector3 direction)
    {
        //玩家发射方向枪口

        //敌人发射方向玩家

        //判断弹夹是否有子弹
        if (Ready()) return;
        //播放声音 播放动画 创建子弹 播放火光粒子
        audioSource.PlayOneShot(clip);
        Instantiate(bulletPrefab, firePos.position,Quaternion.LookRotation(direction));
    }

    private bool Ready()
    {
        if (currentAmmo <= 0)
        {
            return false;
        }
        currentAmmo--;
        if (currentAmmo == 0)
        {
            print("播放缺少子弹动画");
        }
        return true;
    }
    //当前弹夹子弹数
    public int currentAmmo = 15;
    //剩余子弹数
    public int remainBullets = 190;
    //弹夹容量
    public int ammoCapacity = 15;

    public void UpdateAmmo()//更换弹夹
    {

    }
}
