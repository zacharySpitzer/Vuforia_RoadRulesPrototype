using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PannelManager : MonoBehaviour
{
    public GameObject instructionPannel, Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Instructions()
    {
        instructionPannel.SetActive(true);
        Button.SetActive(false);
    }
    public void InstructionsScene()
    {
        SceneManager.LoadScene(1);
       
    }
    public void InstructionScreen()
    {
        Button.SetActive(true);
        instructionPannel.SetActive(false);
    }
    public void Close()
    {
        Application.Quit();
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
