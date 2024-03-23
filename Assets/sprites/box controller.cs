using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Text diemTxt;
    private int diem = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "egg")
        {
            diem++;
            diemTxt.text = "x" + diem;
        }
    }
}
