using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrowControl_Gameover : MonoBehaviour
{
    public RectTransform rect;
    public int choiceNum=0;
    public GameObject Gamemanager;
    public AudioClip se_select;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rect = GetComponent < RectTransform > ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.DownArrow))
        {
            if(choiceNum == 0) 
            {
                audioSource.PlayOneShot(se_select);
                rect.localPosition -= new Vector3(0,70,0);
                choiceNum=1;
            }
        }
        if (Input.GetKeyDown (KeyCode.UpArrow))
        {
            if(choiceNum == 1) 
            {
                audioSource.PlayOneShot(se_select);
                rect.localPosition += new Vector3(0,70,0);
                choiceNum=0;
            }
        }

        if((Input.GetKeyDown (KeyCode.Z))||Input.GetKeyDown(KeyCode.Return))
        {
            switch(choiceNum)
            {
                case 0:
                    Gamemanager.SendMessage("Retry");
                    break;
                case 1:
                    Gamemanager.SendMessage("GoToTitle");
                    break;
            }

        }
    }
    private void OnEnable()
    {      
      rect.localPosition += new Vector3(0,70*(choiceNum),0);
      choiceNum = 0;  
    }
}
