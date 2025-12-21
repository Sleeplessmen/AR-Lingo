using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance { get; private set; }

    // Định nghĩa tên Scene duy nhất tại đây để tránh gõ sai (Magic String)
    public const string MAIN_SCENE_NAME = "Main Scene";

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

    /// <summary>
    /// Dùng hàm này để Reset lại toàn bộ ứng dụng về trạng thái ban đầu
    /// (Ví dụ: Nút "Restart App" trong Settings hoặc khi gặp lỗi nghiêm trọng)
    /// </summary>
    public static void ReloadMainScene()
    {
        SceneManager.LoadScene(MAIN_SCENE_NAME);
    }

    /// <summary>
    /// Hàm hỗ trợ load scene (Giữ lại để tương thích hoặc mở rộng sau này)
    /// </summary>
    public static void LoadScene(string sceneName)
    {
        // Kiểm tra xem scene có tồn tại trong Build Settings không để tránh crash
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError($"Scene '{sceneName}' chưa được thêm vào Build Settings hoặc sai tên!");
        }
    }
}