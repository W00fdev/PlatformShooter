using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private string _axisXName;
    [SerializeField] private string _axisZName;

    private int _axisXHash;
    private int _axisZHash;

    private Animator _animator;

    private float _maxVelocityMagnitude;

    public void Init(float maxVelocityMagnitude)
    {
        _animator = GetComponent<Animator>();
        _maxVelocityMagnitude = maxVelocityMagnitude;

        _axisXHash = Animator.StringToHash(_axisXName);
        _axisZHash = Animator.StringToHash(_axisZName);
    }

    public void UpdateAnimationsByVelocity(Vector3 playerVelocity)
    {
        playerVelocity.y = 0;

        _animator.SetFloat(_axisXHash, playerVelocity.x / _maxVelocityMagnitude);
        _animator.SetFloat(_axisZHash, playerVelocity.z / _maxVelocityMagnitude);
    }
}
