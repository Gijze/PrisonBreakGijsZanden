using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public GameObject MyWeapon;
    public GameObject WeaponOnGround;

    // Start is called before the first frame update
    void Start()
    {
        MyWeapon.SetActive(false);
    }
    void OnTriggerEnter(Collider _collider)
    {
        if(_collider.gameObject.tag == "Player")
        {
            MyWeapon.SetActive(true);
            WeaponOnGround.SetActive(false);
        }
    }
}
