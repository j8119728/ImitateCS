using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected RaycastHit hit;
    //移动
    //计算目标点
    //到达目标点  销毁 创建特效



    private void GenerateContactEffect() {
        //寻找资源
        GameObject prefabGo = Resources.Load<GameObject>("名字");
        //创建资源
        Instantiate(prefabGo);
    }
}
