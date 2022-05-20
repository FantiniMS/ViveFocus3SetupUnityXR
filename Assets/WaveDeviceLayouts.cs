using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace Wave.XR
{
    [Preserve]
#if UNITY_EDITOR
    [UnityEditor.InitializeOnLoad]
#endif
    [InputControlLayout(displayName = "XR Wave HMD")]
    public class WaveHMD : XRHMD
    {
        static WaveHMD()
        {
            InputSystem.RegisterLayout<WaveHMD>("XRWaveHMD", new InputDeviceMatcher()
                .WithInterface(XRUtilities.InterfaceCurrent)
                .WithProduct("(Wave HMD|WVR HMD)"));
        }

        [RuntimeInitializeOnLoadMethod]
        private static void InitializeInPlayer()
        {
        }

        [Preserve]
        [InputControl]
        public ButtonControl userPresence { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDTrackingState")]
        public new IntegerControl trackingState { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDIsTracked")]
        public new ButtonControl isTracked { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDPosition")]
        public new Vector3Control devicePosition { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDRotation")]
        public new QuaternionControl deviceRotation { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDAngularVelocity")]
        public Vector3Control deviceAngularVelocity { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDAcceleration")]
        public Vector3Control deviceAcceleration { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDAngularAcceleration")]
        public Vector3Control deviceAngularAcceleration { get; private set; }

        [Preserve]
        [InputControl(alias = "headleftposition")]
        public new Vector3Control leftEyePosition { get; private set; }

        [Preserve]
        [InputControl(alias = "headleftrotation")]
        public new QuaternionControl leftEyeRotation { get; private set; }

        [Preserve]
        [InputControl(alias = "headrightposition")]
        public new Vector3Control rightEyePosition { get; private set; }

        [Preserve]
        [InputControl(alias = "headrightrotation")]
        public new QuaternionControl rightEyeRotation { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDCenterEyePosition")]
        public new Vector3Control centerEyePosition { get; private set; }

        [Preserve]
        [InputControl(alias = "HMDCenterEyeRotation")]
        public new QuaternionControl centerEyeRotation { get; private set; }

        [Preserve]
        [InputControl(alias = "headCameraVelocity")]
        public Vector3Control centerEyeAngularVelocity { get; private set; }

        [Preserve]
        [InputControl(alias = "headCameraAcceleration")]
        public Vector3Control centerEyeAcceleration { get; private set; }

        [Preserve]
        [InputControl(alias = "headCameraAngularAcceleration")]
        public Vector3Control centerEyeAngularAcceleration { get; private set; }

        protected override void FinishSetup()
        {
            base.FinishSetup();

            userPresence = GetChildControl<ButtonControl>("UserPresence");
            trackingState = GetChildControl<IntegerControl>("TrackingState");
            isTracked = GetChildControl<ButtonControl>("IsTracked");
            devicePosition = GetChildControl<Vector3Control>("DevicePosition");
            deviceRotation = GetChildControl<QuaternionControl>("DeviceRotation");
            deviceAngularVelocity = GetChildControl<Vector3Control>("DeviceAngularVelocity");
            deviceAcceleration = GetChildControl<Vector3Control>("DeviceAcceleration");
            deviceAngularAcceleration = GetChildControl<Vector3Control>("DeviceAngularAcceleration");
            leftEyePosition = GetChildControl<Vector3Control>("LeftEyePosition");
            leftEyeRotation = GetChildControl<QuaternionControl>("LeftEyeRotation");
            rightEyePosition = GetChildControl<Vector3Control>("RightEyePosition");
            rightEyeRotation = GetChildControl<QuaternionControl>("RightEyeRotation");
            centerEyePosition = GetChildControl<Vector3Control>("CenterEyePosition");
            centerEyeRotation = GetChildControl<QuaternionControl>("CenterEyeRotation");
            centerEyeAngularVelocity = GetChildControl<Vector3Control>("CenterEyeAngularVelocity");
            centerEyeAcceleration = GetChildControl<Vector3Control>("CenterEyeAcceleration");
            centerEyeAngularAcceleration = GetChildControl<Vector3Control>("CenterEyeAngularAcceleration");
        }
    }


    [Preserve]
#if UNITY_EDITOR
    [UnityEditor.InitializeOnLoad]
#endif
    [InputControlLayout(displayName = "Wave Controller", commonUsages = new[] { "LeftHand", "RightHand" })]
    public class WaveController : XRControllerWithRumble
    {
        static WaveController()
        {
            InputSystem.RegisterLayout<WaveController>("XRWaveController", new InputDeviceMatcher()
                .WithInterface(XRUtilities.InterfaceCurrent)
                .WithProduct("(WVR_CR_(Left|Right)_001|WVR_CR_(Left|Right)_001)"));
        }

        [RuntimeInitializeOnLoadMethod]
        private static void InitializeInPlayer()
        {
        }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerPrimary2DAxisTouchpadAxis", "LeftControllerPrimary2DAxisTouchpadAxis" })]
        public Vector2Control primary2DAxis { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerTriggerTriggerAxis", "LeftControllerTriggerTriggerAxis" })]
        public AxisControl trigger { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerGrip", "LefttControllerGrip" })]
        public AxisControl grip { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerPrimaryButton", "LeftControllerPrimaryButton" })]
        public ButtonControl primaryButton { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerSecondaryButton", "LeftControllerSecondaryButton" })]
        public ButtonControl secondaryButton { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerGripButton", "LeftControllerGripButton" })]
        public ButtonControl gripPressed { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerMenuButton", "LeftControllerMenuButton" })]
        public ButtonControl menu { get; private set; }


        [Preserve]
        [InputControl(aliases = new[] { "RightControllerPrimaryTouch", "LeftControllerPrimaryTouch" })]
        public ButtonControl primaryTouched { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerSecondaryTouch", "LeftControllerSecondaryTouch" })]
        public ButtonControl secondaryTouched { get; private set; }


        [Preserve]
        [InputControl(aliases = new[] { "RightControllerTriggerButton", "LeftControllerTriggerButton" })]
        public ButtonControl triggerPressed { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerSecondaryTouchThumbstickTouch", "LeftControllerSecondaryTouchThumbstickTouch" })]
        public ButtonControl thumbstickTouched { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerTrackingState", "LeftControllerTrackingState" })]
        public new IntegerControl trackingState { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerIsTracked", "LeftControllerIsTracked" })]
        public new ButtonControl isTracked { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerPosition", "LeftControllerPosition" })]
        public new Vector3Control devicePosition { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerRotation", "LeftControllerRotation" })]
        public new QuaternionControl deviceRotation { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerVelocity", "LeftControllerVelocity" })]
        public Vector3Control deviceVelocity { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerAngularVelocity", "LeftControllerAngularVelocity" })]
        public Vector3Control deviceAngularVelocity { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerAcceleration", "LeftControllerAcceleration" })]
        public Vector3Control deviceAcceleration { get; private set; }

        [Preserve]
        [InputControl(aliases = new[] { "RightControllerAngularAcceleration", "LeftControllerAngularAcceleration" })]
        public Vector3Control deviceAngularAcceleration { get; private set; }

        protected override void FinishSetup()
        {
            base.FinishSetup();

            primary2DAxis = GetChildControl<Vector2Control>("primary2DAxis");
            trigger = GetChildControl<AxisControl>("trigger");
            grip = GetChildControl<AxisControl>("grip");

            primaryButton = GetChildControl<ButtonControl>("primaryButton");
            secondaryButton = GetChildControl<ButtonControl>("secondaryButton");
            gripPressed = GetChildControl<ButtonControl>("gripPressed");
            menu = GetChildControl<ButtonControl>("menu");
            primaryTouched = GetChildControl<ButtonControl>("primaryTouched");
            secondaryTouched = GetChildControl<ButtonControl>("secondaryTouched");
            thumbstickTouched = GetChildControl<ButtonControl>("thumbstickTouched");
            triggerPressed = GetChildControl<ButtonControl>("triggerPressed");

            trackingState = GetChildControl<IntegerControl>("trackingState");
            isTracked = GetChildControl<ButtonControl>("isTracked");
            devicePosition = GetChildControl<Vector3Control>("devicePosition");
            deviceRotation = GetChildControl<QuaternionControl>("deviceRotation");
            deviceVelocity = GetChildControl<Vector3Control>("deviceVelocity");
            deviceAngularVelocity = GetChildControl<Vector3Control>("deviceAngularVelocity");
            deviceAcceleration = GetChildControl<Vector3Control>("deviceAcceleration");
            deviceAngularAcceleration = GetChildControl<Vector3Control>("deviceAngularAcceleration");
        }
    }
}