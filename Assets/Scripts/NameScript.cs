using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameScript : MonoBehaviour
{

    public string Name;
    public TextMeshProUGUI nameText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetName();
    }

    void SetName() 
    {
        //nameText = TextMeshProUGUI.Find("Name Text");
        Name = nameText.text;
    }
}
