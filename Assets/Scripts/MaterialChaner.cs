using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChaner : MonoBehaviour
{
    // Start is called before the first frame update

    int index = 0;

    public Material[] materials;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(materials.Length <= 0)
        {
            return;
        }
        if(OVRInput.GetDown(OVRInput.Button.Two))
        {
            RightChange();
        }
        else if(OVRInput.GetDown(OVRInput.Button.One))
        {
            LeftChange();
        }
    }

    void RightChange()
    {
        index++;

        if(index == materials.Length)
        {
            index = materials.Length - 1;
        }
        GetComponent<MeshRenderer>().material = materials[index];
    }

    void LeftChange()
    {
        index--;


        if (index < 0)
        {
            index = 0;
        }

        GetComponent<MeshRenderer>().material = materials[index];
    }
}
