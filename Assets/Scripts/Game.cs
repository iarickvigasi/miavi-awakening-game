using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{

    [SerializeField] Text mainText;
    [SerializeField] State state;

    // Start is called before the first frame update
    void Start()
    {
        mainText.text = state.getText();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = state.getNextStates()[0];
            mainText.text = state.getText();

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = state.getNextStates()[1];
            mainText.text = state.getText();
        }
    }
}
