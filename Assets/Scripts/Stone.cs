using UnityEngine;

[CreateAssetMenu (fileName = "New Stone", menuName = "Stone/Pickups")]
public class Stone : ScriptableObject
{
    public Color color;
    public new string name;
    public int value;
    public float weight;
}
