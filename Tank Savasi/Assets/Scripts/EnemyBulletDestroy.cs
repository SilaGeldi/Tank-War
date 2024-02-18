using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision obj)
    {
         Invoke(nameof(OnDestroy),1.5f);
    }
    
    public void OnDestroy()
    {
        Destroy(this.gameObject);
    }
}
