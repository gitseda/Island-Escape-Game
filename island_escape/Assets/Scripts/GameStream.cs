using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStream : MonoBehaviour
{
    [SerializeField] Text GameStoryText;
    [SerializeField] Case FirstStory;

    Case CurrentState;

    void Start()
    {
        CurrentState = FirstStory;
        GameStoryText.text = CurrentState.TakeStateStory();
    }

    void Update()
    {
        Case[] nextStates = CurrentState.TakeNextState();

        if ((Input.GetKeyDown(KeyCode.Keypad1)) || (Input.GetKeyDown(KeyCode.Alpha1)))
        {
            CurrentState = nextStates[0];        
        }
        else if ((Input.GetKeyDown(KeyCode.Keypad2)) || (Input.GetKeyDown(KeyCode.Alpha2)))
        {
            CurrentState = nextStates[1];
        }
        else if ((Input.GetKeyDown(KeyCode.Keypad3)) || (Input.GetKeyDown(KeyCode.Alpha3)))
        {
            CurrentState = nextStates[2];
        }
        GameStoryText.text = CurrentState.TakeStateStory();
    }
}
