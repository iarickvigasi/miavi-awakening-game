using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)][SerializeField] string text;
    [SerializeField] State[] nextStates;

    public string getText()
    {
        return text;
    }

    public State[] getNextStates()
    {
        return nextStates;
    }
}
