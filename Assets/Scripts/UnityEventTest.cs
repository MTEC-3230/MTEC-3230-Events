using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
using UnityEngine.UI; 

public class UnityEventTest : MonoBehaviour
{
    private Renderer rend;


    public Button turnColorButton;

    public UnityEvent newUnityEvent; 

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        turnColorButton.onClick.AddListener(DoSomething);


    }


    public void DoSomething()
    {
        Debug.Log("Button was pressed.");
        newUnityEvent.Invoke(); 
        //Color col = new Color(Random.value, Random.value, Random.value);
        //if (rend != null) rend.material.color = col;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
