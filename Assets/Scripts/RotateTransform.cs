using UnityEngine;

public class RotateTransform : MonoBehaviour
{
    [SerializeField]
    private Transform Target; // public variable in Udon

    // Update is called once per frame
    private void FixedUpdate()
    {
        Target.Rotate(new Vector3(0, 1, 0), 1);
    }
}