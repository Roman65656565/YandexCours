using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageNPS : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<DamagePlayer>().GetDamage(1);
        }
    }
}
