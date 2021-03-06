//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/InputMaster.inputactions
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

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""P1"",
            ""id"": ""38124b9a-ec38-4b10-8f1c-8188159bf669"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""351b0824-9942-432a-a2f6-52cfbe329b1f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""65b3f3e2-4ffa-46b7-9c7e-538af01f3f19"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""032f9900-42e3-46a3-b03f-d54c14596a16"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1d356bf3-39bd-42d9-b20b-92e60d4652b7"",
                    ""path"": ""<Keyboard>/w"",
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
            ""name"": ""P2"",
            ""id"": ""7d4d56df-181b-484d-8af6-212a41507c23"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d1a8b466-3862-4de3-b83a-16cf4a7da593"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""392cd5f9-1668-44f2-bc59-a60c0aa9e080"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d7929925-86ee-4856-a9c2-ffa788e28e59"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6a751977-1a86-420b-a2a8-52a40c44b03f"",
                    ""path"": ""<Keyboard>/upArrow"",
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
            ""name"": ""Global"",
            ""id"": ""057c8775-2e11-4fec-b6a1-51e058c056f7"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""0816f413-46a5-4790-ae37-9a2e42b04821"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9d92d149-28dc-478d-a6d2-8f7c64b491fb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // P1
        m_P1 = asset.FindActionMap("P1", throwIfNotFound: true);
        m_P1_Movement = m_P1.FindAction("Movement", throwIfNotFound: true);
        // P2
        m_P2 = asset.FindActionMap("P2", throwIfNotFound: true);
        m_P2_Movement = m_P2.FindAction("Movement", throwIfNotFound: true);
        // Global
        m_Global = asset.FindActionMap("Global", throwIfNotFound: true);
        m_Global_Start = m_Global.FindAction("Start", throwIfNotFound: true);
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

    // P1
    private readonly InputActionMap m_P1;
    private IP1Actions m_P1ActionsCallbackInterface;
    private readonly InputAction m_P1_Movement;
    public struct P1Actions
    {
        private @InputMaster m_Wrapper;
        public P1Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_P1_Movement;
        public InputActionMap Get() { return m_Wrapper.m_P1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(P1Actions set) { return set.Get(); }
        public void SetCallbacks(IP1Actions instance)
        {
            if (m_Wrapper.m_P1ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_P1ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_P1ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_P1ActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_P1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public P1Actions @P1 => new P1Actions(this);

    // P2
    private readonly InputActionMap m_P2;
    private IP2Actions m_P2ActionsCallbackInterface;
    private readonly InputAction m_P2_Movement;
    public struct P2Actions
    {
        private @InputMaster m_Wrapper;
        public P2Actions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_P2_Movement;
        public InputActionMap Get() { return m_Wrapper.m_P2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(P2Actions set) { return set.Get(); }
        public void SetCallbacks(IP2Actions instance)
        {
            if (m_Wrapper.m_P2ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_P2ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_P2ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_P2ActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_P2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public P2Actions @P2 => new P2Actions(this);

    // Global
    private readonly InputActionMap m_Global;
    private IGlobalActions m_GlobalActionsCallbackInterface;
    private readonly InputAction m_Global_Start;
    public struct GlobalActions
    {
        private @InputMaster m_Wrapper;
        public GlobalActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_Global_Start;
        public InputActionMap Get() { return m_Wrapper.m_Global; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GlobalActions set) { return set.Get(); }
        public void SetCallbacks(IGlobalActions instance)
        {
            if (m_Wrapper.m_GlobalActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_GlobalActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_GlobalActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_GlobalActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_GlobalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public GlobalActions @Global => new GlobalActions(this);
    public interface IP1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IP2Actions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IGlobalActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
