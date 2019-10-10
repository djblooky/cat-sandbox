using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMode 
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

    private GameObject CurrentBuildingBlock;

    public void setCurrentBuildingBlock(GameObject CurrentBuildingBlock)
    {
        this.CurrentBuildingBlock = CurrentBuildingBlock;
    }

    private void Update()
    {
        UpdateBuilding();
    }

    private void UpdateBuilding()
    {
        if (Enabled)
        {
            BlockHover();
            CheckForBlockPlace();
        }
    }

    private void BlockHover()
    {
        //draw transparent block over mouse hover and snap to tilemap
        //turn block red if it overlaps with (collides) with other object
    }

    private void CheckForBlockPlace()
    {
        Vector2 CurrentMousePosition = Input.mousePosition;

        if (Input.GetMouseButtonDown(0)) //if left click
        {
            //place block at currentMousePosition (snapped to tile)
        }
    }

}
