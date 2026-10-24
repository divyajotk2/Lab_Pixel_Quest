using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    { spriteRenderer = GetComponent<SpriteRenderer>();
      


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            spriteRenderer.color = Color.yellow;
        }   
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            spriteRenderer.color = Color.white;
        }   
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            spriteRenderer.color = Color.black;
        }
    }
}
