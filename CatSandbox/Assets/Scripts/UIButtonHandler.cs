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

    /// <summary>
    /// Creates a button listener for each UI button to enable its function
    /// </summary>
    void CreateButtonListeners()
    {
        MoveToolButton.onClick.AddListener(EnterInteractMode); //enters interact/move mode
        StoneButton.onClick.AddListener(delegate { EnterBuildMode(blocks.getStoneBlock()); }); //passes in stone block to build mode
        IceButton.onClick.AddListener(delegate { EnterBuildMode(blocks.getIceBlock()); }); //passes in ice block to build mode
    }

    void EnterInteractMode()
    {

    }

    /// <summary>
    ///Enables build mode and sets the building block
    /// </summary>
    /// <param name="BuildingBlock">Block player has selected to build with</param>
    void EnterBuildMode(GameObject BuildingBlock)
    {
        if (!Manager.Instance.getBuildMode().isEnabled()) //if build mode not enabled already
        {
            Manager.Instance.getBuildMode().setCurrentBuildingBlock(BuildingBlock);
            Manager.Instance.getBuildMode().Enable(true);
        }
    }

}
