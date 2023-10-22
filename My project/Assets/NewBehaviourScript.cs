using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheakActive()
    {
        if (cube.activeInHierarchy == true)
        {
            cube.SetActive(false);
        }
        else
        {
            cube.SetActive(true);
        }
    }

}
