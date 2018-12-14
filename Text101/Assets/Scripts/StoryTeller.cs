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
        Debug.Log("Option One was selected.");
    }

    public void OptionTwo()
    {
        Debug.Log("Options Two was selected.");
    }


    public string GetCurrentStateName()
    {
        return state.name;
    }
}