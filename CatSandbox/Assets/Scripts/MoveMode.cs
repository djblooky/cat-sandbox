using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMode 
{
    private bool Enabled = false;

    public bool isEnabled()
    {
        return Enabled;
    }

    public void Enable(bool Enabled)
    {
        this.Enabled = Enabled;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CheckForCatClick
        //CheckForDestinationClick
    }

    
}
