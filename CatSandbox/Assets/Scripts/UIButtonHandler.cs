using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField]
    Button MoveToolButton, StoneButton, IceButton;

    void Start()
    {
        CreateButtonListeners();
    }

    /// <summary>
    /// Creates a button listener for each UI button to enable its function
    /// </summary>
    void CreateButtonListeners()
    {
        MoveToolButton.onClick.AddListener(EnterMoveMode); //enters interact/move mode
        StoneButton.onClick.AddListener(delegate { EnterBuildMode(Blocks.getStoneBlock()); }); //passes in stone block to build mode
        IceButton.onClick.AddListener(delegate { EnterBuildMode(Blocks.getIceBlock()); }); //passes in ice block to build mode
    }

    void EnterMoveMode()
    {
        if (!(Manager.Instance.getMoveMode().isEnabled())) //if interact/move mode not enabled already
        {
            Manager.Instance.getMoveMode().Enable(true);
            Debug.Log("Enabled move mode");
        }
    }

    /// <summary>
    ///Enables build mode and sets the building block
    /// </summary>
    /// <param name="BuildingBlock">Block player has selected to build with</param>
    void EnterBuildMode(GameObject BuildingBlock)
    {
        if (!(Manager.Instance.getBuildMode().isEnabled())) //if build mode not enabled already
        {
            Manager.Instance.getBuildMode().setCurrentBuildingBlock(BuildingBlock);
            Manager.Instance.getBuildMode().Enable(true);
            Debug.Log("Enabled build mode");
        }
    }

}
