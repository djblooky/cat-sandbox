using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{ 
    private BuildMode buildMode;

    public BuildMode getBuildMode()
    {
        return buildMode;
    }

    private MoveMode moveMode;

    public MoveMode getMoveMode()
    {
        return moveMode;
    }
}
