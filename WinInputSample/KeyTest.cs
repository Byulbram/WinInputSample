using UnityEngine;
using System.Collections;
using WindowsInput;

public class KeyTest : MonoBehaviour {

    public Material myColor;
    int ColorCounter = 0;

    void Update()
    {
        float X_delta = 0;
        float Y_delta = 0;

        if (WinInput.GetKey(KeyCode.W))
        {
            Y_delta += Time.deltaTime * 2;
        }

        if (WinInput.GetKey(KeyCode.S))
        {
            Y_delta -= Time.deltaTime * 2;
        }

        if (WinInput.GetKey(KeyCode.A))
        {
            X_delta -= Time.deltaTime * 2;
        }

        if (WinInput.GetKey(KeyCode.D))
        {
            X_delta += Time.deltaTime * 2;
        }

        //Check GetKeyDown by Color during 3 frame
        if (ColorCounter <= 0)
            myColor.color = Color.white;
        else
            ColorCounter--;

        if (WinInput.GetKeyDown(KeyCode.W) || WinInput.GetKeyDown(KeyCode.A) || WinInput.GetKeyDown(KeyCode.S) || WinInput.GetKeyDown(KeyCode.D))
        {
            myColor.color = Color.red;
            ColorCounter = 3;
        }

        if (WinInput.GetKeyUp(KeyCode.W) || WinInput.GetKeyUp(KeyCode.A) || WinInput.GetKeyUp(KeyCode.S) || WinInput.GetKeyUp(KeyCode.D))
        {
            myColor.color = Color.blue;
            ColorCounter = 3;
        }

        transform.Translate(new Vector3(X_delta, Y_delta, 0));
	}

}
