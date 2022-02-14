//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4735ae72-f6a8-42e3-8a4d-78a47d74c105"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1d4e908b-39ea-4dd2-8374-28415539f5cc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Change Colour"",
                    ""type"": ""Button"",
                    ""id"": ""93d13444-7f56-44f6-9908-58847251ea9c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""f314203c-f68a-4cb6-be68-2095fd7d6706"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Invert"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""86989a8d-b9fd-44d1-9cdb-67ff27dbaf16"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3b9229d3-f948-4ee0-b2f8-45186afb7f40"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3e77e930-e039-4495-83e1-565029d24a2d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b000cb57-d13d-4075-b489-88184a2ba6bc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d38be063-f1d2-4456-8d72-952dc147b3a8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""de4785d7-7bec-46f1-bbc9-d3d7d96a9463"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Colour"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7963b03b-62b8-4eba-bf0d-e032fcb6f10f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9c039e6a-cdc4-4b2c-912c-db36f4b2ac3e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""da281eeb-da38-451b-8201-b2be08ba5e5d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""66f785e6-190c-4135-966b-1a38440275e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""81644238-e72b-418d-9e0d-9c7469c5f670"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f2b1eea9-68fe-47be-8bf7-7c025d2f495d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ThreeDMovement"",
            ""id"": ""b2f95886-4048-4669-9c3c-2131d06afa8a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""158ba8a4-12c8-4c81-91f4-cf4f0c1f1daf"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""45265407-3ab0-435c-b98c-c477d57b6d26"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""b6d92075-662b-46e8-9641-549b257d731b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""601e81d4-734c-46eb-b282-ee0c547c8964"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""241bdd26-ca95-4a6e-ad76-5b8e6761d42a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""d9cc976d-7361-44f7-8363-8fb9e5de134e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ControlSwitcher"",
            ""id"": ""5a841478-e815-48c4-9b30-c3bd46cf60ba"",
            ""actions"": [
                {
                    ""name"": ""Change Control To 3D"",
                    ""type"": ""Button"",
                    ""id"": ""4152aeff-bcb1-4e26-b5d6-eff9f730babb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0c1a5584-efab-4f9d-921d-fb52a04c3ee2"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Change Control To 3D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ball"",
            ""id"": ""365837c7-6464-48c9-9582-0b72c0709066"",
            ""actions"": [
                {
                    ""name"": ""Bounce"",
                    ""type"": ""Button"",
                    ""id"": ""9c14330f-9eb5-429b-8e14-8e44f8256698"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=1,pressPoint=1),Hold(duration=1,pressPoint=1)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8655d132-88ce-47ca-a73f-8ebdd7692c1e"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bounce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_ChangeColour = m_Player.FindAction("Change Colour", throwIfNotFound: true);
        m_Player_Rotation = m_Player.FindAction("Rotation", throwIfNotFound: true);
        // ThreeDMovement
        m_ThreeDMovement = asset.FindActionMap("ThreeDMovement", throwIfNotFound: true);
        m_ThreeDMovement_Movement = m_ThreeDMovement.FindAction("Movement", throwIfNotFound: true);
        // ControlSwitcher
        m_ControlSwitcher = asset.FindActionMap("ControlSwitcher", throwIfNotFound: true);
        m_ControlSwitcher_ChangeControlTo3D = m_ControlSwitcher.FindAction("Change Control To 3D", throwIfNotFound: true);
        // Ball
        m_Ball = asset.FindActionMap("Ball", throwIfNotFound: true);
        m_Ball_Bounce = m_Ball.FindAction("Bounce", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_ChangeColour;
    private readonly InputAction m_Player_Rotation;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @ChangeColour => m_Wrapper.m_Player_ChangeColour;
        public InputAction @Rotation => m_Wrapper.m_Player_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @ChangeColour.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeColour;
                @ChangeColour.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeColour;
                @ChangeColour.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeColour;
                @Rotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ChangeColour.started += instance.OnChangeColour;
                @ChangeColour.performed += instance.OnChangeColour;
                @ChangeColour.canceled += instance.OnChangeColour;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // ThreeDMovement
    private readonly InputActionMap m_ThreeDMovement;
    private IThreeDMovementActions m_ThreeDMovementActionsCallbackInterface;
    private readonly InputAction m_ThreeDMovement_Movement;
    public struct ThreeDMovementActions
    {
        private @PlayerControls m_Wrapper;
        public ThreeDMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ThreeDMovement_Movement;
        public InputActionMap Get() { return m_Wrapper.m_ThreeDMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThreeDMovementActions set) { return set.Get(); }
        public void SetCallbacks(IThreeDMovementActions instance)
        {
            if (m_Wrapper.m_ThreeDMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ThreeDMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ThreeDMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ThreeDMovementActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_ThreeDMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public ThreeDMovementActions @ThreeDMovement => new ThreeDMovementActions(this);

    // ControlSwitcher
    private readonly InputActionMap m_ControlSwitcher;
    private IControlSwitcherActions m_ControlSwitcherActionsCallbackInterface;
    private readonly InputAction m_ControlSwitcher_ChangeControlTo3D;
    public struct ControlSwitcherActions
    {
        private @PlayerControls m_Wrapper;
        public ControlSwitcherActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeControlTo3D => m_Wrapper.m_ControlSwitcher_ChangeControlTo3D;
        public InputActionMap Get() { return m_Wrapper.m_ControlSwitcher; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlSwitcherActions set) { return set.Get(); }
        public void SetCallbacks(IControlSwitcherActions instance)
        {
            if (m_Wrapper.m_ControlSwitcherActionsCallbackInterface != null)
            {
                @ChangeControlTo3D.started -= m_Wrapper.m_ControlSwitcherActionsCallbackInterface.OnChangeControlTo3D;
                @ChangeControlTo3D.performed -= m_Wrapper.m_ControlSwitcherActionsCallbackInterface.OnChangeControlTo3D;
                @ChangeControlTo3D.canceled -= m_Wrapper.m_ControlSwitcherActionsCallbackInterface.OnChangeControlTo3D;
            }
            m_Wrapper.m_ControlSwitcherActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeControlTo3D.started += instance.OnChangeControlTo3D;
                @ChangeControlTo3D.performed += instance.OnChangeControlTo3D;
                @ChangeControlTo3D.canceled += instance.OnChangeControlTo3D;
            }
        }
    }
    public ControlSwitcherActions @ControlSwitcher => new ControlSwitcherActions(this);

    // Ball
    private readonly InputActionMap m_Ball;
    private IBallActions m_BallActionsCallbackInterface;
    private readonly InputAction m_Ball_Bounce;
    public struct BallActions
    {
        private @PlayerControls m_Wrapper;
        public BallActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bounce => m_Wrapper.m_Ball_Bounce;
        public InputActionMap Get() { return m_Wrapper.m_Ball; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BallActions set) { return set.Get(); }
        public void SetCallbacks(IBallActions instance)
        {
            if (m_Wrapper.m_BallActionsCallbackInterface != null)
            {
                @Bounce.started -= m_Wrapper.m_BallActionsCallbackInterface.OnBounce;
                @Bounce.performed -= m_Wrapper.m_BallActionsCallbackInterface.OnBounce;
                @Bounce.canceled -= m_Wrapper.m_BallActionsCallbackInterface.OnBounce;
            }
            m_Wrapper.m_BallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bounce.started += instance.OnBounce;
                @Bounce.performed += instance.OnBounce;
                @Bounce.canceled += instance.OnBounce;
            }
        }
    }
    public BallActions @Ball => new BallActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnChangeColour(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IThreeDMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IControlSwitcherActions
    {
        void OnChangeControlTo3D(InputAction.CallbackContext context);
    }
    public interface IBallActions
    {
        void OnBounce(InputAction.CallbackContext context);
    }
}
