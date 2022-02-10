using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private InputField nameField;
    [SerializeField] private GameObject characterScreen;
	public Button back;
	private void Start()
	{
        characterScreen.SetActive(false);

        if (PlayerPrefs.HasKey("Player_Name"))
		nameField.text=PlayerPrefs.GetString("Player_Name");
	}
	public void  OnEndEditName()
	{
		PlayerPrefs.SetString("Player_Name",nameField.text);
    }

	public void LoadCharacterChoiceScreen()
    {
        characterScreen.SetActive(true);
    }

	public void LoadCharacterScreen()
    {

    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Back()
    {
		back.interactable = true;
    }
 public void OnClickPlay()
 {
 SceneManager.LoadScene(1);
 }
 public void OnClickExit()
 {
 Application.Quit();
 }
	
}
