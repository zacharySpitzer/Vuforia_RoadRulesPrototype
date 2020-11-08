using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class Button1 : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbGameObject, button2;
    public GameObject Car1, Car2;
    public List<GameObject> MoveToPoints;
    public GameObject Pannel;
    public GameObject InstructionsPannelButton;
    public float timer = 3f;
    bool isPressed;
    public GameObject theScenario;
    void Start()
    {
       // MoveToPoints = new List<GameObject>();
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    private void Update()
    {
    //    if (isPressed == true)
    //    {
    //        timer -= Time.deltaTime;

    //    }
    //    if (timer <= 0)
    //    {
    //        timer = 3;
    //    }

    }


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //cube.transform.Rotate(Vector3.right * Time.deltaTime); ;
        // Debug.Log("vb Pressed");
        InstructionsPannelButton.SetActive(false);
            Pannel.SetActive(true);
            Debug.Log("vb Pressed");
            isPressed = false;
        

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //cube.SetActive(true);
        Debug.Log("vb Released");
    }
    public void MoveObjects()
    {

    }
  
}