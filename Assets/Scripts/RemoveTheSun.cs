using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class RemoveTheSun : MonoBehaviour
{
    public GameObject sun;

    private void OnTriggerEnter(Collider other)
    {
        sun.SetActive(false);
    }
}
