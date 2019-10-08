using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField]
    GameObject stoneBlock;

    public GameObject getStoneBlock()
    {
        return Instantiate(stoneBlock);
    }

    [SerializeField]
    GameObject iceBlock;

    public GameObject getIceBlock()
    {
        return Instantiate(iceBlock);
    }

}
