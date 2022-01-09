using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StartMenu
{
    public class UIController : MonoBehaviour
    {
        #region Attributes

        #endregion

        #region Functions
        public void ExitGame()
        {
            SceneManager.instance.ExitGame();
        }
        #endregion
    }
}

