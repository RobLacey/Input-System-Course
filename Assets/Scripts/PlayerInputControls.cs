using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputControls : MonoBehaviour
{
    [SerializeField] [Range(0,15)]
    private float _speed = 3f;
    [SerializeField] [Range(0f,150f)]
    private float _rotationSpeed = 50f;

    private MeshRenderer _renderer;
    private Transform _modelsTransform;
    private float _rotateBy;
    private bool _canRotate;

    //Property
    private PlayerControls ControlScheme { get; set; }

    private void Awake()
    {
        ControlScheme = new PlayerControls();
        _renderer = GetComponentInChildren<MeshRenderer>();
        _modelsTransform = _renderer.transform;
    }

    private void OnEnable()
    {
        ControlScheme.Player.ChangeColour.performed += ChangePlayerColour;
        ControlScheme.Player.Rotation.performed += RotateObject;
        ControlScheme.Player.Rotation.canceled += RotationStopped;
        ControlScheme.ControlSwitcher.ChangeControlTo3D.performed += ChangeControlMap;
    }

    
    private void OnDisable()
    {
        ControlScheme.Player.ChangeColour.performed -= ChangePlayerColour;
        ControlScheme.Player.Rotation.performed -= RotateObject;
        ControlScheme.Player.Rotation.canceled -= RotationStopped;
        ControlScheme.ControlSwitcher.ChangeControlTo3D.performed -= ChangeControlMap;
    }

    // Start is called before the first frame update
    void Start()
    {
        ControlScheme.ControlSwitcher.Enable();
        ControlScheme.Player.Enable();
        ControlScheme.Ball.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        DoMovement();
        DoRotation();
    }

    private void DoMovement()
    {
        Move(ControlScheme.Player.enabled
                 ? (Vector3)ControlScheme.Player.Movement.ReadValue<Vector2>()
                 : ControlScheme.ThreeDMovement.Movement.ReadValue<Vector3>());
        
         void Move(Vector3 movementInput) => transform.Translate(movementInput * Time.deltaTime * _speed);
    }


    private void DoRotation()
    {
        if(!ControlScheme.Player.enabled) return;
        
        _rotateBy = ControlScheme.Player.Rotation.ReadValue<float>();
        
        if (_rotateBy != 0 && _canRotate)
        {
            _modelsTransform.Rotate(RotationSpeed(), RotationSpeed(), RotationSpeed());
        }
    }

    private float RotationSpeed() => _rotateBy * Time.deltaTime * _rotationSpeed;

    private void ChangePlayerColour(InputAction.CallbackContext context)
    {
         var newColour = new Color(RandomFloat(), RandomFloat(), RandomFloat(), 1f);
         _renderer.material.color = newColour;
         
         float RandomFloat() => Random.Range(0f, 1f);
    }
    
    private void RotateObject(InputAction.CallbackContext context) => _canRotate = true;

    private void RotationStopped(InputAction.CallbackContext context) => _canRotate = false;
    
    private void ChangeControlMap(InputAction.CallbackContext context)
    {
        if (ControlScheme.Player.enabled)
        {
            ControlScheme.Player.Disable();
            ControlScheme.ThreeDMovement.Enable();
        }
        else
        {
            ControlScheme.ThreeDMovement.Disable();
            ControlScheme.Player.Enable();
        }
    }
}
