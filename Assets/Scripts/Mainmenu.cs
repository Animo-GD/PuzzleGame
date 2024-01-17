using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public GameObject puzzleScreen;
    private bool PSOpened;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && PSOpened)
        {
            PSOpened = false;
            puzzleScreen.SetActive(false);
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PuzzleMenu()
    {
        puzzleScreen.SetActive(true);
        PSOpened = true;
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);
    }

    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void level5()
    {
        SceneManager.LoadScene(5);
    }
    public void level6()
    {
        SceneManager.LoadScene(6);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
