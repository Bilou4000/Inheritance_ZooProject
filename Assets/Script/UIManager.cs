using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] GameObject pauseMenu;

    private bool check;

    private void Awake()
    {
        pauseMenu.SetActive(false);
    }

    void Start()
    {
        Time.timeScale = 1.0f;
        check = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && check)
        {
            pauseMenu.SetActive(true);

            Time.timeScale = 0f;
            StartCoroutine(CheckSwitch());

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !check)
        {
            pauseMenu.SetActive(false);

            Time.timeScale = 1.0f;
            check = true;
        }
    }

    IEnumerator CheckSwitch()
    {
        yield return new WaitForEndOfFrame();
        check = false;
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
