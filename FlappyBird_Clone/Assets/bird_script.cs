using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird_script : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public Rigidbody2D Collision;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }

    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "danger")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
