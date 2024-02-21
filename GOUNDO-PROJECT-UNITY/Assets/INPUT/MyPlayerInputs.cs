//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/INPUT/MyPlayerInputs.inputactions
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

public partial class @MyPlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyPlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyPlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1bd5fe8b-bb55-4a65-b0c7-3df892139a60"",
            ""actions"": [
                {
                    ""name"": ""MOVE"",
                    ""type"": ""Value"",
                    ""id"": ""bdc3e642-cea9-4e62-b8b2-e4dd37a1eeda"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LOOK-Y"",
                    ""type"": ""Value"",
                    ""id"": ""b9cb426b-4f94-42b3-92ac-cf891e7d6cbe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""326dd4f0-1fb9-477c-8c76-a04553294fae"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c542f7f-2e46-4159-96d4-a309cb5c13b7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""93e1c166-d61a-48c1-ab6e-7fee37bf21eb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9eb8d13a-d48f-4066-b9ee-41434bdb6b55"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""91ded9cf-1af9-4de0-bd11-7579884ff10a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""095758b9-073f-44bd-ab65-28e7595bd9fa"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOVE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""12dc8ebe-2b22-43a9-b262-e5728f1df8b5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LOOK-Y"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1c779f5a-a702-41e8-bde1-44b3fe9e018f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LOOK-Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a86afa7f-f8b7-40f7-82d3-abbe24d3888d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LOOK-Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3cf28d86-2eb7-482f-94a4-a5f1db4ac770"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LOOK-Y"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2bf9e248-643c-4ea4-ad81-86c78ccb3d71"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LOOK-Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""31bccd77-d72e-414f-abc4-67835ca914f1"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LOOK-Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""439538c0-c3fb-4975-8d88-4753975f995a"",
            ""actions"": [
                {
                    ""name"": ""QUIT"",
                    ""type"": ""Button"",
                    ""id"": ""9119566d-c37a-41ef-9670-d263de581b52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RELOAD"",
                    ""type"": ""Button"",
                    ""id"": ""5409ec93-d206-48a2-9186-38b9ff1652f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""595e95b4-8b2c-4adc-887b-df9026ede9a2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QUIT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79fabca2-8b74-409a-87eb-b0496448530a"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RELOAD"",
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
        m_Player_MOVE = m_Player.FindAction("MOVE", throwIfNotFound: true);
        m_Player_LOOKY = m_Player.FindAction("LOOK-Y", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_QUIT = m_UI.FindAction("QUIT", throwIfNotFound: true);
        m_UI_RELOAD = m_UI.FindAction("RELOAD", throwIfNotFound: true);
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_MOVE;
    private readonly InputAction m_Player_LOOKY;
    public struct PlayerActions
    {
        private @MyPlayerInputs m_Wrapper;
        public PlayerActions(@MyPlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MOVE => m_Wrapper.m_Player_MOVE;
        public InputAction @LOOKY => m_Wrapper.m_Player_LOOKY;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @MOVE.started += instance.OnMOVE;
            @MOVE.performed += instance.OnMOVE;
            @MOVE.canceled += instance.OnMOVE;
            @LOOKY.started += instance.OnLOOKY;
            @LOOKY.performed += instance.OnLOOKY;
            @LOOKY.canceled += instance.OnLOOKY;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @MOVE.started -= instance.OnMOVE;
            @MOVE.performed -= instance.OnMOVE;
            @MOVE.canceled -= instance.OnMOVE;
            @LOOKY.started -= instance.OnLOOKY;
            @LOOKY.performed -= instance.OnLOOKY;
            @LOOKY.canceled -= instance.OnLOOKY;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_QUIT;
    private readonly InputAction m_UI_RELOAD;
    public struct UIActions
    {
        private @MyPlayerInputs m_Wrapper;
        public UIActions(@MyPlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @QUIT => m_Wrapper.m_UI_QUIT;
        public InputAction @RELOAD => m_Wrapper.m_UI_RELOAD;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @QUIT.started += instance.OnQUIT;
            @QUIT.performed += instance.OnQUIT;
            @QUIT.canceled += instance.OnQUIT;
            @RELOAD.started += instance.OnRELOAD;
            @RELOAD.performed += instance.OnRELOAD;
            @RELOAD.canceled += instance.OnRELOAD;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @QUIT.started -= instance.OnQUIT;
            @QUIT.performed -= instance.OnQUIT;
            @QUIT.canceled -= instance.OnQUIT;
            @RELOAD.started -= instance.OnRELOAD;
            @RELOAD.performed -= instance.OnRELOAD;
            @RELOAD.canceled -= instance.OnRELOAD;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerActions
    {
        void OnMOVE(InputAction.CallbackContext context);
        void OnLOOKY(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnQUIT(InputAction.CallbackContext context);
        void OnRELOAD(InputAction.CallbackContext context);
    }
}
