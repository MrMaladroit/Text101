using UnityEngine;
using UnityEngine.UI;

public class StoryTeller : MonoBehaviour
{
    [SerializeField] private Text storyTextDisplay;
    [SerializeField] private State titleState;

    private State state;

    // Use this for initialization
    void Start()
    {
        state = titleState;
        storyTextDisplay.text = state.GetStateStory();
    }

    public void OptionOne()
    {
        state = state.GetNextState(0);
        Debug.Log("Option One was selected.");
        UpdateText();
    }

    public void OptionTwo()
    {
        state = state.GetNextState(1);
        Debug.Log("Options Two was selected.");
        UpdateText();
    }


    public string GetCurrentStateName()
    {
        return state.name;
    }

    private void UpdateText()
    {
        storyTextDisplay.text = state.GetStateStory();
    }
}