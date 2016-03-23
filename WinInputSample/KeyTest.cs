using UnityEngine;
using System.Collections;
using WindowsInput;

public class KeyTest : MonoBehaviour {
    
	void Update () 
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

        transform.Translate(new Vector3(X_delta, Y_delta, 0));
	}

}
