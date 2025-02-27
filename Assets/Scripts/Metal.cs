using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour
{

    public bool isCheck { get; set; } = false;


    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.AddGameObjects(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
