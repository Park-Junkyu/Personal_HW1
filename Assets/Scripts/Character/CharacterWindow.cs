using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWindow : MonoBehaviour
{
    public GameObject characterChangeWindow;

    public void ShowCharacter()
    {
        characterChangeWindow.SetActive(true);
    }

    public void CloseCharacter()
    {
        characterChangeWindow.SetActive(false);
    }
}
