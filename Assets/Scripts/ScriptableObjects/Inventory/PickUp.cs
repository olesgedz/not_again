using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Item Add;
    Inventory gl;
    // Start is called before the first frame update
    void Start()
    {
        gl = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

        gl.AddItem(Add);
    }
}
