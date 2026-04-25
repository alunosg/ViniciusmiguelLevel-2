using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoaderScene(string sceneName) => SceneManager.LoadScene(sceneName);
}
