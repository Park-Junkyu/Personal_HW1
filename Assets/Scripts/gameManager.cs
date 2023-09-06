using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public int PlayerId;
    public Player player;


    private void Awake()
    {
        instance = this;
    }

    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
