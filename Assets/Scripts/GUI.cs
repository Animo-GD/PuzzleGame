using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUI : MonoBehaviour
{
    public float count;
    public Text timertext;
    public Text wintexttimer;
    [SerializeField] private int Pcount;
    [SerializeField] private GameObject WinScreen;

    public GameObject PauseButton;

   // private bool GameIsPaused;

    private float timer = 0;
    public GameObject PauseMenu;
    
    private void Update()
    {
        
       
        if(count == Pcount)
        {
            WinScreen.SetActive(true);
            wintexttimer.text = timertext.text;
        }
        else
        {
            timertext.text = (timer).ToString("0");
            timer += Time.deltaTime;
        }
    }
    public void PauseGame()
    {
        //GameIsPaused = true;
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
       // GameIsPaused = false;
        PauseButton.SetActive(true);
    }

    public void Home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
