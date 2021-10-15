using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myClick : MonoBehaviour {

	public void toMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void toDescription()
    {
        Application.LoadLevel("GameDescription");
    }

    public void toStartGame()
    {
        Application.LoadLevel("game");
    }
}
