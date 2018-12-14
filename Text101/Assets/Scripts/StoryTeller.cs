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

    // Update is called once per frame
    void Update()
    {
    }
}