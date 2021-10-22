using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public Vector3 SpawnBoll = new Vector3(0,0,0);
    public GameObject Ammunation;
    //public GameObject Spawn;
    public float cooldown = 3f;
    public float timefire = 0;
    public bool isShoot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isShoot)
        {
            isShoot = true;
            Instantiate(Ammunation, SpawnBoll, Ammunation.transform.rotation);
        }
        if (isShoot)
        {
            timefire += Time.deltaTime;

        }
        if (timefire > cooldown)
        {
            isShoot = false;
            timefire = 0;
            
        }
        
    }
}
