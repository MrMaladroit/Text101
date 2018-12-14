using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private StoryTeller storyTeller;
    [SerializeField] private GameObject gameOptionsPanel;
    private string currentStateName;
    private PlayerPrefs save;

    public void Save()
    {
        currentStateName = storyTeller.GetCurrentStateName();       
        Debug.Log(currentStateName);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenOptionsPanel()
    {
        gameOptionsPanel.SetActive(true);
    }

    public void CloseOptionsPanel()
    {
        gameOptionsPanel.SetActive(false);
    }

    private void OnApplicationQuit()
    {
        Save();
    }


}