using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 edit;
    public Keyboard kbd;
    // Start is called before the first frame update
    void Start()
    {
        kbd = Keyboard.current;
        edit = new Vector3(1, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kbd == null) return;
        if (kbd.wKey.isPressed)
        {
            edit = edit * 2;
            transform.Rotate(edit);
            Debug.Log(transform.position);
        }
    }

    public void OnCollisionEnter(Collision c)
    {
        transform.position = c.transform.position;
        Debug.Log("Hi");
    }
}
