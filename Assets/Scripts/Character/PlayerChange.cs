using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : CharacterWindow
{
    
    
    public void ChangePlayer(int id)
    {
        gameManager.instance.PlayerId = id;
        gameManager.instance.player.ChangeChar();
        CloseCharacter();

    }
    //public void DemonPlayer(int id)
    //{
    //    gameManager.instance.PlayerId = id;
    //    CloseCharacter();
    //}
}
