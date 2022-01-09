using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartMenu
{
    public class UIController : MonoBehaviour
    {
        #region Attributes
        [SerializeField] private GameObject Settings;
        [SerializeField] private GameObject HeroSelection;
        [SerializeField] private GameObject LevelSelection;
        [SerializeField] private GameObject StartMenu;
        #endregion

        private void Start()
        {
            StartMenu.SetActive(true);
            Settings.SetActive(false);
            HeroSelection.SetActive(false);
            LevelSelection.SetActive(false);
        }

        public void OpenSettings()
        {
            StartMenu.SetActive(false);
            Settings.SetActive(true);
        }

        public void OpenHeroSelection()
        {
            StartMenu.SetActive(false);
            HeroSelection.SetActive(true);
        }

        public void OpenLevelSelection()
        {
            StartMenu.SetActive(false);
            LevelSelection.SetActive(true);
        }
    }
}

