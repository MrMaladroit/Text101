using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] private string storyText;
    [SerializeField] State[] nextStates;

    private State[] states;
    
    private void Start()
    {
        states = nextStates;
    }

    public string GetStateStory()
    {
        return storyText;
    }

    public State GetNextState(int index)
    {
        states = nextStates;
        return states[index];
    }
}