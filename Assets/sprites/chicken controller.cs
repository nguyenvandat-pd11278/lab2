using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickencontroller : MonoBehaviour
{
    public GameObject egg;
    public float eggspawninterval = 3.0f;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= eggspawninterval)
        {
            Instantiate(egg, transform.position, Quaternion.identity);
            timer = 0.0f;
        }
    }
}
