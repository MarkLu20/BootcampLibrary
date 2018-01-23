using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public
         Material matest;
    List<Material> testlist;

    GameObject testObject;
    // Use this for initialization
    void Start()

    {

        testObject = GameObject.Find("Sphere");
        testObject.GetComponent<MeshRenderer>().material = matest;
        



    }

    // Update is called once per frame
    void Update()
    {
        testObject.transform.Translate(0.01f, 0.0f, 0.0f);
    }
}
