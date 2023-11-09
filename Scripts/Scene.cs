using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{

    public void LoadTheScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }


}
