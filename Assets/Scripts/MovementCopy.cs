using UnityEngine;

public class MovementCopy : MonoBehaviour
{
    [SerializeField] private Transform _targetJoint;
    private ConfigurableJoint _joint;
    private Quaternion _initAngle;

    private void Start()
    {
        _joint = GetComponent<ConfigurableJoint>();
        _initAngle = _targetJoint.rotation;
    }

    private void FixedUpdate()
    {
        _joint.targetRotation = _targetJoint.localRotation * _initAngle;
    }
}
