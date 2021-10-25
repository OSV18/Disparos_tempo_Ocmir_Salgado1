using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public Vector3 SpawnBoll = new Vector3(0,0,0);
    public GameObject Ammunation;
    //public GameObject Spawn;
    public float Cooldown = 3f;
    //public float timefire = 0;
    public bool isShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isShoot)
        {
            isShoot = true;
            Instantiate(Ammunation, SpawnBoll, Ammunation.transform.rotation);
        }

        if(isShoot)
        {
            isShoot = false;
            Invoke("cooldown",Cooldown);
        }

         
    }

        private void cooldown()
    {
        isShoot = true;
    }
}
