using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject eggbroken;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D col)
    {   
        if (col.gameObject.name.Equals("dat"))
        {
            Instantiate(eggbroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("egg"))
        {
            Instantiate(eggbroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("farmer"))
        {
            Instantiate(eggbroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("box"))
        {
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
    }
}
