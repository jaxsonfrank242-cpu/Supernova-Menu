using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;

namespace StupidTemplate.Mods
{
    internal class Rig
    {
        public static void GhostMonke()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton || Mouse.current.rightButton.isPressed)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }

            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void Noclip()
        {
            bool disableColliders = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = !disableColliders;
            }
        }
    }
}
