using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Start Button").GetComponent<Button>();
        button.onClick.AddListener(Begin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Begin() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene (sceneBuildIndex:scene + 1);
        Debug.Log("YAYAYAY");
    }
}
