using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{
    private BuildMode buildMode = new BuildMode();

    public BuildMode getBuildMode()
    {
        return buildMode;
    }

    private MoveMode moveMode = new MoveMode();

    public MoveMode getMoveMode()
    {
        return moveMode;
    }
}
