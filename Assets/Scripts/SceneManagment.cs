using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();    //po prostu wychodzi z aplikacji
    }
    public void firstLevel()
    {
        SceneManager.LoadScene(1);   //ładuje scene z numerem 1, czyli pierwszy level
    }
}
