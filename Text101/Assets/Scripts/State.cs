using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] private string storyText;
    [SerializeField] State[] nextStates;

    private State[] states;


    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return states;
    }
}