using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    [SerializeField] private int hp;

    private void Update()
    {
        if (hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void GetDamage(int damage)
    {
        hp -= damage;
    }
}
