using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Sprite spriteDown, spriteUp;
    public string action;
    public GameObject mus_on, mus_off;
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = spriteDown;
    }

    private void Start()
    {
        if(gameObject.name == "ButtonMusic")
        if (PlayerPrefs.GetString("Music") != "no")
        {
            mus_on.SetActive(true);
            mus_off.SetActive(false);
            GameObject.Find("MainAudio").GetComponent<AudioSource>().Play();
            }
        else
        {
            mus_on.SetActive(false);
            mus_off.SetActive(true);
        }
    } 
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = spriteUp;
    }
    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GameObject.Find("ClickAudio").GetComponent<AudioSource>().Play();
        switch(gameObject.name)
        {
            case "ButtonStart" :
                Application.LoadLevel("play");
                break;
            case "ButtonRate":
                Application.OpenURL("http://google.com");
                break;
            case "ButtonMusic":
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    mus_on.SetActive(false);
                    mus_off.SetActive(true);
                    GameObject.Find("MainAudio").GetComponent<AudioSource>().Stop();
                }
                else
                {
                    PlayerPrefs.SetString("Music", "yes");
                    mus_on.SetActive(true);
                    mus_off.SetActive(false);
                    GameObject.Find("MainAudio").GetComponent<AudioSource>().Play();
                }
               
                break;
            case "Home":
                Application.LoadLevel("Main");
                break;
            case "Replay":
                Application.LoadLevel("play");
                break;
            case "ButtonHelp":
                Application.LoadLevel("Help");
                break;
            
        }
    }
}
