using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New : MonoBehaviour
{
    public int variable1 = 2;
    private string Var2 = "Hello";
    int Var3 = 3;

    private Rigidbody2D rb;
    public int speed = 5;

    // Start is called before the first frame update
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //Debug.Log(var2+variable1);
    }



    // Update is called once per frame
    void Update()
    {

        float xInput = Input.GetAxis("Horizontal");
        xInput *= variable1;
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }


    public string nextLevel = "level 2";
      
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
                case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
