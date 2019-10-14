using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField]
    private static GameObject stoneBlock;

    public static GameObject getStoneBlock()
    {
        return stoneBlock;
    }

    [SerializeField]
    private static GameObject iceBlock;

    public static GameObject getIceBlock()
    {
        return iceBlock;
    }

}
