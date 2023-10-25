using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{

    public string playerName;
    private NameScript nameTextScript;

    // Start is called before the first frame update
    void Start()
    {
        nameTextScript = GameObject.Find("Name Text").GetComponent<NameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        playerName = nameTextScript.Name;
        DontDestroyOnLoad(gameObject);
    }
}
