using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "MainLevel";

	public SceneFader sceneFader;

    private void Start()
    {
        AkSoundEngine.PostEvent("MenuMusic", gameObject);
    }

    public void Play ()
	{
        AkSoundEngine.PostEvent("MenuMusicStop", gameObject);
        sceneFader.FadeTo(levelToLoad);
	}

	public void Quit ()
	{
		Debug.Log("Exiting...");
		Application.Quit();
	}

}
