using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private float _smallBounce = 3f;
    [SerializeField] private float _bigBounceTimeThreshold = 0.9f;
    [SerializeField] private float _bigBounce = 10f;
    
    private Rigidbody _rigidbody;

    //Property
    private PlayerControls ControlScheme { get; set; }

    private void Awake()
    {
        ControlScheme = new PlayerControls();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        ControlScheme.Ball.Enable();
        ControlScheme.Ball.Bounce.performed += BounceChargeUp;
    }
    
    private void BounceChargeUp(InputAction.CallbackContext context)
    {
        if (context.duration > _bigBounceTimeThreshold)
        {
            _rigidbody.AddForce(Vector3.up * _bigBounce, ForceMode.Impulse);
        }
        else
        {
            _rigidbody.AddForce(Vector3.up * _smallBounce, ForceMode.Impulse);

        }
    }
}
