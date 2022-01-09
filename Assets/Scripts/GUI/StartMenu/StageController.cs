using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StageController : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text requirement;
    [SerializeField] private GameObject locked;
    [SerializeField] private bool isLocked;
    private LevelSelectorController level;

    private void Start()
    {
        // Level = GameObject.FindGameObjectWithTag("PanelDetails");
        if (isLocked)
        {
            locked.SetActive(true);
            requirement.gameObject.SetActive(true);
        } else
        {
            locked.SetActive(false);
            requirement.gameObject.SetActive(false);
        }
    }

    public void OnSelectLevelClick()
    {
        if (isLocked)
        {
            // Show notification is Locked
        } else
        {
            level = new LevelSelectorController();
            level.DisplayPanelDetails();
        }
    }
}
