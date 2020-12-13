// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""58ba8184-ee2c-49ca-80aa-2e7de731ded1"",
            ""actions"": [
                {
                    ""name"": ""Player Move"",
                    ""type"": ""Value"",
                    ""id"": ""baf21bb2-ef86-4b36-af7a-d332c96c5d21"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e932356a-50dd-4c60-a873-184c1d7623f7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""06934c16-ed91-4aab-b91b-db12ef9d2056"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6f686493-1b08-47eb-934b-3392b35e0530"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af696afd-4421-4104-9e99-ce95f2b0119c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""08fb142b-0bd7-4403-adda-7173ff83a23c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5923ac23-bbd4-4b2e-a9cb-6872c621b9c0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""FishMinigame"",
            ""id"": ""4f7f892e-97ff-48a6-9842-7a86e61ad456"",
            ""actions"": [
                {
                    ""name"": ""Player Catch"",
                    ""type"": ""Value"",
                    ""id"": ""af781a31-6c05-446e-aefa-6ae9864ace8c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""732d1914-94cc-4999-bef9-0afc899facbf"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Catch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae1bb341-12ff-47dd-9cb7-3e7a828f7878"",
                    ""path"": ""<Touchscreen>/touch1/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player Catch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_PlayerMove = m_PlayerMovement.FindAction("Player Move", throwIfNotFound: true);
        // FishMinigame
        m_FishMinigame = asset.FindActionMap("FishMinigame", throwIfNotFound: true);
        m_FishMinigame_PlayerCatch = m_FishMinigame.FindAction("Player Catch", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_PlayerMove;
    public struct PlayerMovementActions
    {
        private @Player m_Wrapper;
        public PlayerMovementActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMove => m_Wrapper.m_PlayerMovement_PlayerMove;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @PlayerMove.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayerMove;
                @PlayerMove.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayerMove;
                @PlayerMove.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnPlayerMove;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerMove.started += instance.OnPlayerMove;
                @PlayerMove.performed += instance.OnPlayerMove;
                @PlayerMove.canceled += instance.OnPlayerMove;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // FishMinigame
    private readonly InputActionMap m_FishMinigame;
    private IFishMinigameActions m_FishMinigameActionsCallbackInterface;
    private readonly InputAction m_FishMinigame_PlayerCatch;
    public struct FishMinigameActions
    {
        private @Player m_Wrapper;
        public FishMinigameActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerCatch => m_Wrapper.m_FishMinigame_PlayerCatch;
        public InputActionMap Get() { return m_Wrapper.m_FishMinigame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FishMinigameActions set) { return set.Get(); }
        public void SetCallbacks(IFishMinigameActions instance)
        {
            if (m_Wrapper.m_FishMinigameActionsCallbackInterface != null)
            {
                @PlayerCatch.started -= m_Wrapper.m_FishMinigameActionsCallbackInterface.OnPlayerCatch;
                @PlayerCatch.performed -= m_Wrapper.m_FishMinigameActionsCallbackInterface.OnPlayerCatch;
                @PlayerCatch.canceled -= m_Wrapper.m_FishMinigameActionsCallbackInterface.OnPlayerCatch;
            }
            m_Wrapper.m_FishMinigameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerCatch.started += instance.OnPlayerCatch;
                @PlayerCatch.performed += instance.OnPlayerCatch;
                @PlayerCatch.canceled += instance.OnPlayerCatch;
            }
        }
    }
    public FishMinigameActions @FishMinigame => new FishMinigameActions(this);
    public interface IPlayerMovementActions
    {
        void OnPlayerMove(InputAction.CallbackContext context);
    }
    public interface IFishMinigameActions
    {
        void OnPlayerCatch(InputAction.CallbackContext context);
    }
}
