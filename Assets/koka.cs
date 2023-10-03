using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class koka : MonoBehaviour
{
    public float Speed = 20f;
    public int a;
    public int b;
    public int c = 3;
    public GameObject sphere;
    public GameObject hol1; 
    public GameObject hol2;
    public Text x;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 10 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 10 * Speed * Time.deltaTime);
        }
        if (c == 0)
        {
            x.text = "Ты уничтожил их!";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
    private void OnCollisionStay(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    public void del()
    {
        if (sphere.activeSelf)
            sphere.SetActive(false);
        else if(hol1.activeSelf)
            hol1.SetActive(false);
        else if (hol2.activeSelf)
            hol2.SetActive(false);
        c--;
    }
}
