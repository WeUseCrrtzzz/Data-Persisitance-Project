using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameScript : MonoBehaviour
{

    private MainManager managerScript;
    public Name nameScript;   
    public Text self;
    public int bestScore = 1;


    // Start is called before the first frame update
    void Start()
    {
        managerScript = GameObject.Find("MainManager").GetComponent<MainManager>();
        nameScript = GameObject.Find("Name").GetComponent<Name>();
    }

    // Update is called once per frame
    void Update()
    {
        self.text = "Best Score : " + bestScore + " Name : " + nameScript.playerName; 
    }
}
