using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private string SceneName;
   
    public void SceneLoader()
    {
        SceneManager.LoadScene(SceneName);
    }

}

