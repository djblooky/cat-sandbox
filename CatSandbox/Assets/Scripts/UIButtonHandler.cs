using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField]
    Button MoveToolButton, StoneButton, IceButton;

    private Blocks blocks;

    void Start()
    {
        CreateButtonListeners();
    }

    void CreateButtonListeners()
    {
        MoveToolButton.onClick.AddListener(EnterMoveMode);
        StoneButton.onClick.AddListener(delegate { EnterBuildMode(blocks.getStoneBlock()); });
        IceButton.onClick.AddListener(delegate { EnterBuildMode(blocks.getIceBlock()); });
    }

    void EnterMoveMode()
    {

    }

    void EnterBuildMode(GameObject BuildingBlock)
    {

    }

}
