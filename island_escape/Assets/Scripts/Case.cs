using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Case")]
public class Case : ScriptableObject
{
    [TextArea(12, 10)] [SerializeField] string storyText;
    [SerializeField] Case[] nextStates;

    public string TakeStateStory() 
    { 
        return storyText;
    }

    public Case[] TakeNextState()
    {
        return nextStates;
    }
}
