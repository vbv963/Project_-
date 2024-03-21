using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player_rigidbody;
    [SerializeField]
    private float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
           player_rigidbody.AddForce(0f, 0f, speed);
        }
        if(Input.GetKey(KeyCode.DownArrow) == true)
        {
           player_rigidbody.AddForce(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow) == true)
        {
           player_rigidbody.AddForce(speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.RightArrow) == true)
        {
           player_rigidbody.AddForce(-speed, 0f, 0f);
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
