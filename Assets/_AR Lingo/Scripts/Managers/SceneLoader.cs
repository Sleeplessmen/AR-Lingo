using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadHomeScene() => LoadScene("HomeScene");
    public void LoadScanScene() => LoadScene("ScanScene");
    public void LoadARViewScene() => LoadScene("ARViewScene");
    public void LoadQuizScene() => LoadScene("QuizScene");
    public void LoadDictionaryScene() => LoadScene("DictionaryScene");
}