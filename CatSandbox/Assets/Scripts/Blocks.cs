using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField]
    private GameObject stoneBlock;

    public GameObject getStoneBlock()
    {
        return Instantiate(stoneBlock);
    }

    [SerializeField]
    private GameObject iceBlock;

    public GameObject getIceBlock()
    {
        return Instantiate(iceBlock);
    }

}
