using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;


    /// ///////////////////////////////////////////////////////////////////////
    List<Transform> objPositions = new List<Transform>();
    List<GameObject> gameObjects = new List<GameObject>();


    static public GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("확인용");
                _instance = new GameManager();
            }

            return _instance;

        }
    }

    public void AddGameObjects(GameObject obj)
    {
        gameObjects.Add(obj);
    }

    public ref List<GameObject> GetGameObjects()
    {
        return ref gameObjects;
    }


    public void AddTransform(GameObject obj)
    {
        GameObject gm = new GameObject();
        gm.transform.position = obj.transform.position;
        gm.transform.localRotation = obj.transform.localRotation;
        gm.transform.localScale = obj.transform.localScale;

        objPositions.Add(gm.transform);
    }

}
