using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FarmerControoler : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movespeed = 5f;
    public float boundary = 10f;
    private float facingdirection = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveinput = Input.GetAxis("Horizontal");
        Vector3 movedirection = new Vector3 (moveinput, 0, 0);
        transform . Translate(movedirection * movespeed * Time.deltaTime);
        Vector3 currentposition = transform.position;   
        if (currentposition.x < -boundary)
        {
            currentposition.x = -boundary;
        }
        else if (currentposition.x > boundary)
        {
            facingdirection = 1;
            currentposition.x = boundary;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            facingdirection = -1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            facingdirection = 1;
        }
        Vector3 newscale = transform.localScale;
        newscale.x = facingdirection;
        transform.localScale = newscale;
        transform.position = currentposition;
    }
}
