using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static SoundManager soundManager;
    private static SceneManager sceneManager;
    private static UIManager uiManager;
    private static ScoreManager scoreManager;

    public static GameManager Instance { get { return instance; } }
    public static SoundManager Sound { get { return soundManager; } }
    public static SceneManager Scene { get { return sceneManager; } }
    public static UIManager UI { get { return uiManager; } }
    public static ScoreManager Score { get { return scoreManager; } }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
        InitManagers();
    }

    private void InitManagers()
    {
        GameObject sceneObj = new GameObject();
        sceneObj.name = "SceneManager";
        sceneObj.transform.parent = transform;
        sceneManager = sceneObj.AddComponent<SceneManager>();

        GameObject soundObj = new GameObject();
        soundObj.name = "SoundManager";
        soundObj.transform.parent = transform;
        soundManager = soundObj.AddComponent<SoundManager>();

        GameObject uiObj = new GameObject();
        uiObj.name = "UIManager";
        uiObj.transform.parent = transform;
        uiManager = uiObj.AddComponent<UIManager>();

        GameObject scoreObj = new GameObject();
        scoreObj.name = "UIManager";
        scoreObj.transform.parent = transform;
        scoreManager = scoreObj.AddComponent<ScoreManager>();
    }
}