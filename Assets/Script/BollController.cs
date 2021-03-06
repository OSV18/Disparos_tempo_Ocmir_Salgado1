using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollController : MonoBehaviour
{
    public float SpeedBoll = 1.0F;
    float DamageBoll = 2.0F;
    public float lifeBoll = 5f;

// Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scale();
        }

        lifeBoll -= Time.deltaTime;
        if (lifeBoll > 0)
        {
            MoveBoll(Vector3.right);
        }
        
        else
        {
            Destroy(gameObject);
        }
        
    }

    private void MoveBoll(Vector3 direction)
    {
        transform.Translate(SpeedBoll * Time.deltaTime * direction);
    }
        
    private void Scale()
    {
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
    }
      

}

