using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SHADOWFALL
{
    public class ExitButton : MonoBehaviour
    {
        [SerializeField] private GameObject exitButton;
        [SerializeField] private int buttonStats;

        public void Start()
        {
            buttonStats = 0;
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape) && buttonStats == 0)
            {
                summonExitButton();
                buttonStats += 1;
            }
            if (Input.GetKeyDown(KeyCode.Escape) && buttonStats == 1)
            {
                desummonExitButton();
                buttonStats -= 1;
            }
        }
        private void summonExitButton()
        {
            exitButton.gameObject.SetActive(true);
        }

        private void desummonExitButton()
        {
            exitButton.gameObject.SetActive(false);
        }

        public void OnClickExitButton()
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
