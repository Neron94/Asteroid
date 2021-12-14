// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/AsteroidInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @AsteroidInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @AsteroidInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""AsteroidInput"",
    ""maps"": [
        {
            ""name"": ""ShipControll"",
            ""id"": ""74931d51-6d4c-42ca-90f3-dd076c986a3a"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""0eb79b34-c0c5-435b-8aa6-026e26c6327c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""b6506893-38fd-4736-8656-0265ede0e7fe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireMainWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""ea0dad20-cda6-4909-b117-14a68450e8a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireAlternativeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""c259b227-602d-47ac-9372-a38ef441390f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24f07758-bc34-4d86-975f-f5f0f826d2ca"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16f4bc02-dcfc-4317-b2d9-01f517405dc1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FireMainWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f4ba2c7-43db-47ee-a053-67064895307f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FireAlternativeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Rotation"",
                    ""id"": ""61e43ee4-243f-4d4b-acf9-58b951480c9e"",
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
                    ""id"": ""b79baa5b-c4a1-4db5-a75e-b502f152b16d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""75a666f6-6b15-4c1f-916c-c921a018e4d0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MenuControll"",
            ""id"": ""9e545072-2da9-4ce5-a205-e247a252494b"",
            ""actions"": [
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""be51adbe-9be4-48e4-87de-ffae7283e2a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectTop"",
                    ""type"": ""Button"",
                    ""id"": ""ae110f89-578f-439e-90f4-1cbb9c662560"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectDown"",
                    ""type"": ""Button"",
                    ""id"": ""5bab9f07-0ac6-4f83-8052-b1eacb153c6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b9b2b0c4-be96-4e26-955d-77e6296d8d95"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90f96784-0285-42a5-99f7-780cdedaea60"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelectTop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db676013-95c9-4d3c-acf5-879a0534d650"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelectDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ShipControll
        m_ShipControll = asset.FindActionMap("ShipControll", throwIfNotFound: true);
        m_ShipControll_Thrust = m_ShipControll.FindAction("Thrust", throwIfNotFound: true);
        m_ShipControll_Rotation = m_ShipControll.FindAction("Rotation", throwIfNotFound: true);
        m_ShipControll_FireMainWeapon = m_ShipControll.FindAction("FireMainWeapon", throwIfNotFound: true);
        m_ShipControll_FireAlternativeWeapon = m_ShipControll.FindAction("FireAlternativeWeapon", throwIfNotFound: true);
        // MenuControll
        m_MenuControll = asset.FindActionMap("MenuControll", throwIfNotFound: true);
        m_MenuControll_Enter = m_MenuControll.FindAction("Enter", throwIfNotFound: true);
        m_MenuControll_SelectTop = m_MenuControll.FindAction("SelectTop", throwIfNotFound: true);
        m_MenuControll_SelectDown = m_MenuControll.FindAction("SelectDown", throwIfNotFound: true);
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

    // ShipControll
    private readonly InputActionMap m_ShipControll;
    private IShipControllActions m_ShipControllActionsCallbackInterface;
    private readonly InputAction m_ShipControll_Thrust;
    private readonly InputAction m_ShipControll_Rotation;
    private readonly InputAction m_ShipControll_FireMainWeapon;
    private readonly InputAction m_ShipControll_FireAlternativeWeapon;
    public struct ShipControllActions
    {
        private @AsteroidInput m_Wrapper;
        public ShipControllActions(@AsteroidInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_ShipControll_Thrust;
        public InputAction @Rotation => m_Wrapper.m_ShipControll_Rotation;
        public InputAction @FireMainWeapon => m_Wrapper.m_ShipControll_FireMainWeapon;
        public InputAction @FireAlternativeWeapon => m_Wrapper.m_ShipControll_FireAlternativeWeapon;
        public InputActionMap Get() { return m_Wrapper.m_ShipControll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControllActions set) { return set.Get(); }
        public void SetCallbacks(IShipControllActions instance)
        {
            if (m_Wrapper.m_ShipControllActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnThrust;
                @Rotation.started -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnRotation;
                @FireMainWeapon.started -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnFireMainWeapon;
                @FireMainWeapon.performed -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnFireMainWeapon;
                @FireMainWeapon.canceled -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnFireMainWeapon;
                @FireAlternativeWeapon.started -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnFireAlternativeWeapon;
                @FireAlternativeWeapon.performed -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnFireAlternativeWeapon;
                @FireAlternativeWeapon.canceled -= m_Wrapper.m_ShipControllActionsCallbackInterface.OnFireAlternativeWeapon;
            }
            m_Wrapper.m_ShipControllActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @FireMainWeapon.started += instance.OnFireMainWeapon;
                @FireMainWeapon.performed += instance.OnFireMainWeapon;
                @FireMainWeapon.canceled += instance.OnFireMainWeapon;
                @FireAlternativeWeapon.started += instance.OnFireAlternativeWeapon;
                @FireAlternativeWeapon.performed += instance.OnFireAlternativeWeapon;
                @FireAlternativeWeapon.canceled += instance.OnFireAlternativeWeapon;
            }
        }
    }
    public ShipControllActions @ShipControll => new ShipControllActions(this);

    // MenuControll
    private readonly InputActionMap m_MenuControll;
    private IMenuControllActions m_MenuControllActionsCallbackInterface;
    private readonly InputAction m_MenuControll_Enter;
    private readonly InputAction m_MenuControll_SelectTop;
    private readonly InputAction m_MenuControll_SelectDown;
    public struct MenuControllActions
    {
        private @AsteroidInput m_Wrapper;
        public MenuControllActions(@AsteroidInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Enter => m_Wrapper.m_MenuControll_Enter;
        public InputAction @SelectTop => m_Wrapper.m_MenuControll_SelectTop;
        public InputAction @SelectDown => m_Wrapper.m_MenuControll_SelectDown;
        public InputActionMap Get() { return m_Wrapper.m_MenuControll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControllActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControllActions instance)
        {
            if (m_Wrapper.m_MenuControllActionsCallbackInterface != null)
            {
                @Enter.started -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnEnter;
                @SelectTop.started -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnSelectTop;
                @SelectTop.performed -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnSelectTop;
                @SelectTop.canceled -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnSelectTop;
                @SelectDown.started -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnSelectDown;
                @SelectDown.performed -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnSelectDown;
                @SelectDown.canceled -= m_Wrapper.m_MenuControllActionsCallbackInterface.OnSelectDown;
            }
            m_Wrapper.m_MenuControllActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @SelectTop.started += instance.OnSelectTop;
                @SelectTop.performed += instance.OnSelectTop;
                @SelectTop.canceled += instance.OnSelectTop;
                @SelectDown.started += instance.OnSelectDown;
                @SelectDown.performed += instance.OnSelectDown;
                @SelectDown.canceled += instance.OnSelectDown;
            }
        }
    }
    public MenuControllActions @MenuControll => new MenuControllActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IShipControllActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnFireMainWeapon(InputAction.CallbackContext context);
        void OnFireAlternativeWeapon(InputAction.CallbackContext context);
    }
    public interface IMenuControllActions
    {
        void OnEnter(InputAction.CallbackContext context);
        void OnSelectTop(InputAction.CallbackContext context);
        void OnSelectDown(InputAction.CallbackContext context);
    }
}
