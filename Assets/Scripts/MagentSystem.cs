using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagentSystem : MonoBehaviour
{
    public List<GameObject> gameObjects;

    public GameObject target;

    public bool isSwitch = false;

    bool isChange = false;
    public float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance.GetGameObjects().Count >= 1)
        {
            gameObjects = GameManager.Instance.GetGameObjects();
        }

    }


    private void FixedUpdate()
    {
        MagentUpdate();

    }

    // Update is called once per frame
    void Update()
    {
            
    }



    void MagentUpdate()
    {
        if(null != gameObjects)
        {
            foreach(var gameObject in gameObjects)
            {
                if(gameObject.GetComponent<Metal>() == null)
                {
                    print("test");
                }
                if(gameObject.GetComponent<Metal>().isCheck == true)
                {
                    float step = speed * Time.deltaTime;
                    gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, target.transform.position, step);
                }
                
            }
        }
    }

}
