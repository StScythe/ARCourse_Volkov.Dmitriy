using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[AddComponentMenu("ARCourse/ObjectSpawners")]

public class ObjectSpawners : MonoBehaviour
{
    [SerializeField] private MessageLogger _gameObjectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_gameObjectToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
