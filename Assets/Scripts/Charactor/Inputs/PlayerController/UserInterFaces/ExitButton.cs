using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SHADOWFALL
{
    public class ExitButton : MonoBehaviour
    {
        [SerializeField] private GameObject exitButton;
        [SerializeField]private float buttonStats;

        public void Start()
        {
            buttonStats = 0;
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && buttonStats == 0)
            {
                summonExitButton();
                buttonStats = 1;
            }
            if (Input.GetKeyDown(KeyCode.Escape) && buttonStats == 1)
            {
                desummonExitButton();
                buttonStats = 0;
            }
        }
        private void summonExitButton()
        {
            exitButton.SetActive(true);
        }

        private void desummonExitButton()
        {
            exitButton.SetActive(false);
        }

        public void OnClickExitButton()
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
