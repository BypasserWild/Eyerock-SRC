using GorillaExtensions;
using GorillaTag;
using Photon.Pun;
using POpusCodec.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using static Eyerock.Misc.Variables;
using static Eyerock.Menu.Main;
using static Mono.Security.X509.X509Stores;
using static GorillaLocomotion.Player;
using BepInEx;
using System.Diagnostics;


namespace Eyerock.Mods
{
    public class MoveMent : MonoBehaviour
    {
        public static void GripMonkey()
        {

                foreach (GorillaSurfaceOverride item in UnityEngine.GameObject.FindObjectsOfType<GorillaSurfaceOverride>())
                {
                    item.overrideIndex = 0;
                }
        }
        public static void GripMonkeyFix()
        {
                foreach (GorillaSurfaceOverride item in UnityEngine.GameObject.FindObjectsOfType<GorillaSurfaceOverride>())
                {
                    item.overrideIndex = -1;
                }
        }

        public static void Page2()
        {
            buttonsType = 1;
        }
        public static void Page1()
        {
            buttonsType = 0;
        }
        public static void Page3()
        {
            buttonsType = 2;
        }
        public static void Page4()
        {
            buttonsType = 3;
        }
        public static void PageCosmetics()
        {
            buttonsType = 4;
        }
        public static void PlaceHolder()
        {
            
        }
        public static void JoioDiscord()
        {
            Process.Start("https://discord.gg/XFTsyFhzcf");
        }
        public static void SpeedBoost(bool w)
        {
            if (w == true) 
            {
                GorillaLocomotion.Player.Instance.rightHandSurfaceOverride.extraVelMaxMultiplier = 1.3f;
                GorillaLocomotion.Player.Instance.rightHandSurfaceOverride.extraVelMultiplier = 1.3f;
                GorillaLocomotion.Player.Instance.leftHandSurfaceOverride.extraVelMultiplier = 1.3f;
                GorillaLocomotion.Player.Instance.leftHandSurfaceOverride.extraVelMaxMultiplier = 1.3f;
            }
            else
            {
                GorillaLocomotion.Player.Instance.rightHandSurfaceOverride.extraVelMaxMultiplier = 1f;
                GorillaLocomotion.Player.Instance.rightHandSurfaceOverride.extraVelMultiplier = 1f;
                GorillaLocomotion.Player.Instance.leftHandSurfaceOverride.extraVelMultiplier = 1f;
                GorillaLocomotion.Player.Instance.leftHandSurfaceOverride.extraVelMaxMultiplier = 1f;
            }
        }

        public static void LongArms()
        {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
        }
        public static void LongArmsFix()
        {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);

        }

        public static void CarMonkey()
        {
            if (ControllerInputPoller.instance.rightControllerPrimary2DAxis.y > 0.5f)
            {
                GorillaTagger.Instance.rigidbody.velocity += GorillaTagger.Instance.headCollider.transform.forward * 15 * Time.time;
            }
        }

        public static void InvisibleMonke()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 180;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0;
            }
        }
        public static void GhostMonke()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void Platforms()
        {
            if (RIGHTTTT == true && ControllerInputPoller.instance.rightGrab)
            {
                ROject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                ROject.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                ROject.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                ROject.transform.localScale = new Vector3(0.0125f, 0.28f, 0.2825f);


                ROject.AddComponent<MeshRenderer>();
                ROject.AddComponent<Renderer>();
                ROject.GetComponent<MeshRenderer>().material = UberShader;
                ROject.GetComponent<MeshRenderer>().material.color = Color.magenta;


                GameObject.Destroy(ROject.GetComponent<Rigidbody>());
                GameObject.Destroy(ROject.GetComponent<Rigidbody2D>());
                RIGHTTTT = false;
            }
            else if (RIGHTTTT == false && !ControllerInputPoller.instance.rightGrab)
            {
                GameObject.Destroy(ROject);
                ROject = null;
                RIGHTTTT = true;
            }
            if (LEFTTTT == true && ControllerInputPoller.instance.leftGrab)
            {
                LObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                LObject.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                LObject.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                LObject.transform.localScale = new Vector3(0.0125f, 0.28f, 0.2825f); 


                LObject.AddComponent<MeshRenderer>();
                LObject.AddComponent<Renderer>();
                LObject.GetComponent<MeshRenderer>().material =UberShader;
                LObject.GetComponent<MeshRenderer>().material.color = Color.magenta;


                GameObject.Destroy(LObject.GetComponent<Rigidbody>());
                GameObject.Destroy(LObject.GetComponent<Rigidbody2D>());
                LEFTTTT = false;
            }
            else if (LEFTTTT == false && ControllerInputPoller.instance.leftGrab == false)
            {
                GameObject.Destroy(LObject);
                LObject = null;
                LEFTTTT = true;
            }
        }

        public static void NoClip()
        {
            foreach (MeshCollider mesher in UnityEngine.GameObject.FindObjectsOfType<MeshCollider>()) // oppsie poopsie
            {
                if (ControllerInputPoller.instance.leftControllerIndexFloat == 1f)
                {
                    mesher.enabled = false;
                }
                else
                {
                    mesher.enabled = true;
                }
            }
        }
        public static void TpGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit hit;
                if (Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out hit))
                {
                    GameObject pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    pointer.gameObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    UnityEngine.GameObject.Destroy(pointer.gameObject.GetComponent<SphereCollider>());
                    pointer.gameObject.transform.position = hit.point;
                    pointer.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                    pointer.gameObject.GetComponent<MeshRenderer>().material = UberShader;
                    GameObject.Destroy(pointer, Time.time);
                    if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f)
                    {
                        if (Time.time > delay + 0.8)
                        {
                            GorillaLocomotion.Player.Instance.transform.position = pointer.transform.position;
                            delay = Time.time;
                        }
                    }
                }
            }
        }
        public static void SuperMonk()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.time * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        private static GameObject lineObjectRight;
        private static GameObject lineObjectLeft;

        public static void SpiderMonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f)
            {
                if (lineObjectRight == null)
                {
                    ShootLine(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.forward + GorillaTagger.Instance.rightHandTransform.forward, 30f, true);
                }
                else
                {
                    UpdateLinePosition(lineObjectRight, GorillaTagger.Instance.rightHandTransform.position, 5f);
                }
            }
            else if (lineObjectRight != null)
            {
                GameObject.Destroy(lineObjectRight.gameObject);
                lineObjectRight = null;
            }

            if (ControllerInputPoller.instance.leftControllerIndexFloat == 1f)
            {
                if (lineObjectLeft == null)
                {
                    ShootLine(GorillaTagger.Instance.leftHandTransform.position, GorillaTagger.Instance.leftHandTransform.forward + GorillaTagger.Instance.leftHandTransform.up, 30f, false);
                }
                else
                {
                    UpdateLinePosition(lineObjectLeft, GorillaTagger.Instance.leftHandTransform.position, 5f);
                }
            }
            else if (lineObjectLeft != null)
            {
                GameObject.Destroy(lineObjectLeft.gameObject);
                lineObjectLeft = null;
            }
        }

        private static void ShootLine(Vector3 startPos, Vector3 handUpVector, float lineLength, bool isRightHand)
        {
            Vector3 direction = handUpVector.normalized * lineLength;

            RaycastHit hit;
            bool hitSomething = Physics.Raycast(startPos, direction, out hit);

            GameObject lineObject = new GameObject("Line");
            LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();
            lineRenderer.startWidth = 0.1f;
            lineRenderer.endWidth = 0.1f;
            lineRenderer.positionCount = 2;
            lineRenderer.startColor = Color.white;
            lineRenderer.endColor = Color.white;
            lineRenderer.material = UberShader;
            lineRenderer.SetPosition(0, startPos);

            if (hitSomething)
            {
                lineRenderer.SetPosition(1, hit.point);
            }
            else
            {
                lineRenderer.SetPosition(1, startPos + direction);
            }

            Rigidbody playerRigidbody = GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>();
            playerRigidbody.AddForce(direction, ForceMode.Impulse);
            if (isRightHand)
            {
                lineObjectRight = lineObject;
            }
            else
            {
                lineObjectLeft = lineObject;
            }
        }
        private static void UpdateLinePosition(GameObject lineObject, Vector3 newPosition, float lineLength)
        {
            LineRenderer lineRenderer = lineObject.GetComponent<LineRenderer>();
            lineRenderer.SetPosition(0, newPosition);
            Vector3 endPoint = lineRenderer.GetPosition(1);
            Vector3 direction = (endPoint - newPosition).normalized * lineLength;
            Rigidbody playerRigidbody = GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>();
            playerRigidbody.AddForce(direction, ForceMode.Impulse);
        }


        public static void CheckPoint()
        {
            if (rig == null)
            {
                rig = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                rig.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                rig.GetComponent<Renderer>().material = new Material(Shader.Find("GUI/Text Shader"));
                rig.GetComponent<Renderer>().material.color = Color.red;

                Destroy(rig.GetComponent<Rigidbody>());
                Destroy(rig.GetComponent<Rigidbody2D>());
                Destroy(rig.GetComponent<Collider>());
                Destroy(rig.GetComponent<Collider2D>());
                Destroy(rig.GetComponent<BoxCollider>());
                Destroy(rig.GetComponent<MeshCollider>());
            }

            if (ControllerInputPoller.instance.rightGrab && rig != null)
            {
                rig.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                rig.transform.rotation = Quaternion.identity;
            }
            else if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f && rig != null)
            {
                rig.GetComponent<Renderer>().material.color = Color.green;
                foreach (MeshCollider mesh in UnityEngine.GameObject.FindObjectsOfType<MeshCollider>())
                {
                    mesh.enabled = false;
                }
                GorillaTagger.Instance.transform.position = rig.transform.position;
            }
            else
            {
                foreach (MeshCollider mesh in UnityEngine.GameObject.FindObjectsOfType<MeshCollider>())
                {
                    mesh.enabled = true;
                }
                rig.GetComponent<Renderer>().material.color = Color.red;
            }
        }

        public static void destroycheckpoint()
        {
            GameObject.Destroy(rig.gameObject);
        }

        public static void UpAndDown()
        {
            if (ControllerInputPoller.instance.rightControllerGripFloat == 1f)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.down * 100f, ForceMode.Acceleration);
            }
            if (ControllerInputPoller.instance.leftControllerGripFloat == 1f)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * 100f, ForceMode.Acceleration);
            }
        }

        public static void WallHelper()
        {
            if (ControllerInputPoller.instance.rightControllerGripFloat == 1f)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.right * 10f, ForceMode.Acceleration);
            }
            if (ControllerInputPoller.instance.leftControllerGripFloat == 1f)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.left * 10f, ForceMode.Acceleration);
            }
        }

        public static void MoonGrav()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(Vector3.up * 4f, ForceMode.Acceleration);
        }

        public static void JupiterGrav()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(Vector3.down * 10f, ForceMode.Acceleration);
        }
  
        public static void BlackHole()
        {
            if (rig1 == null)
            {
                rig1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                rig1.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                rig1.GetComponent<Renderer>().material = new Material(Shader.Find("GUI/Text Shader"));
                rig1.GetComponent<Renderer>().material.color = Color.black;

                Destroy(rig1.GetComponent<Rigidbody>());
                Destroy(rig1.GetComponent<Rigidbody2D>());
                Destroy(rig1.GetComponent<Collider>());
                Destroy(rig1.GetComponent<Collider2D>());
                Destroy(rig1.GetComponent<BoxCollider>());
                Destroy(rig1.GetComponent<MeshCollider>());
            }

            if (ControllerInputPoller.instance.rightGrab && rig1 != null)
            {
                rig1.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                rig1.transform.rotation = Quaternion.identity;
            }
            else if (ControllerInputPoller.instance.rightControllerIndexFloat == 1f && rig1 != null)
            {
                Vector3 direction = rig1.transform.position - GorillaLocomotion.Player.Instance.transform.position;

                float forceMagnitude = 1000f; 
                Vector3 force = direction.normalized * forceMagnitude;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(force, ForceMode.Force);
            }
        }
        public static void delerig1()
        {
            GameObject.Destroy(rig1.gameObject);
        }

        public static void NameChanger()
        {
            if (Time.time > delay3 + 1f)
            {
                string randomName = GetRandomName();
                PhotonNetwork.NickName = randomName;
                PhotonNetwork.LocalPlayer.NickName = randomName;
                GorillaLocomotion.Player.Instance.name = randomName;
                PlayerPrefs.Save();
                delay3 = Time.time;
            }
        }

        public static string GetRandomName()
        {
            int utdthg = UnityEngine.Random.Range(0, names.Length);
            return names[utdthg];
        }

        public static void HideinTrees()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/SmallTrees/").SetActive(false);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/newTreehouse/smalltreetreehouse").SetActive(false);
        }

        public static void HideinTreesFix()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/SmallTrees/").SetActive(true);
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Forest/Terrain/newTreehouse/smalltreetreehouse").SetActive(true);
        }

        public static void LeanBomb()
        {
            if (Bombbby == true && ControllerInputPoller.instance.leftControllerPrimaryButton && BombObject == null)
            {
                BombObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                BombObject.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                BombObject.transform.localScale = new Vector3(0.2f, 0.3f, 0.4f);
                BombObject.GetComponent<Renderer>().material = UberShader;
                BombObject.GetComponent<Renderer>().material.color = Color.white;
                Destroy(BombObject.GetComponent<MeshCollider>());
                Destroy(BombObject.GetComponent<Rigidbody>());
                Destroy(BombObject.GetComponent<Rigidbody2D>());
                Destroy(BombObject.GetComponent<BoxCollider>());
                Bombbby = false;
            }
            else if (Bombbby == false && ControllerInputPoller.instance.rightControllerPrimaryButton && BombObject != null)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddExplosionForce(50000f, BombObject.transform.position, 50f);
                Destroy(BombObject);
                BombObject = null;
                Bombbby = true;
            }
        }
        public static void BigMonke()
        {
            GorillaLocomotion.Player.Instance.scale = 2f;
        }
        public static void BigMonkeFix()
        {
            GorillaLocomotion.Player.Instance.scale = 1f;
        }
    }
    public class Visuals : MonoBehaviour
    {
        public static void RGBMONKEY()
        {
            float saturation = Mathf.PingPong(Time.time * 1, 1.0f);
            float value = Mathf.PingPong(Time.time * 1, 1.0f);

            color = Color.HSVToRGB(0f, saturation, value);
            if (Time.time > delay22 + 0.5f && GorillaNetworking.GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(PhotonNetwork.LocalPlayer.UserId))
            {
                GorillaTagger.Instance.UpdateColor(color.r, color.g, color.b);
                GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", RpcTarget.All, new object[]
                {
                    color.r,
                    color.g,
                    color.b,
                    false
                });
                delay22 = Time.time;
            }
            else if(Time.time > delay22 + 0.5f)
            {
                GorillaTagger.Instance.UpdateColor(color.r, color.g, color.b);
                delay22 = Time.time;
            }
        }
        public static void STROBEMONKEY()
        {
            Color color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
            if (Time.time > delay2 + 0.5f && GorillaNetworking.GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(PhotonNetwork.LocalPlayer.UserId))
            {
                GorillaTagger.Instance.offlineVRRig.InitializeNoobMaterialLocal(color.r, color.g, color.b);
                GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", RpcTarget.All, new object[]
                {
                    color.r,
                    color.g,
                    color.b,
                    false
                });
                delay2 = Time.time;
            }
            else if (Time.time > delay2 + 0.5f)
            {
                GorillaTagger.Instance.offlineVRRig.InitializeNoobMaterialLocal(color.r, color.g, color.b);
                delay2 = Time.time; // why nigger it works
            }
        }
        public static void Beacons()
        {
            foreach (VRRig item in GorillaParent.instance.vrrigs)
            {
                //
                if (!item.isOfflineVRRig && !item.isMyPlayer)
                {
                    if(Beacon == null)
                    {
                        Beacon = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                        Beacon.transform.rotation = Quaternion.identity;
                        Beacon.transform.localScale = new Vector3(0.05f, 1000, 0.05f);
                    }

                    Beacon.transform.position = item.transform.position;
                    MeshRenderer r = Beacon.AddComponent<MeshRenderer>();
                    r.material = item.mainSkin.material;
                    r.material.color = item.mainSkin.material.color;


                    GameObject.Destroy(r.GetComponent<Rigidbody>());
                    GameObject.Destroy(r.GetComponent<Rigidbody2D>());
                    GameObject.Destroy(Beacon, Time.time);
                }
            }
          
            
        }
    }
}
