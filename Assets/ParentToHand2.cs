using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.MagicLeap;

public class ParentToHand2 : MonoBehaviour
{

    //public Vector3[] pos;

    private MLHandKeyPose[] _gestures;
    // Use this for initialization
    void Start()
    {

        MLResult result = MLHands.Start();
        if (!result.IsOk)
        {
            Debug.LogErrorFormat("Error: HandTrackingVisualizer failed starting MLHands, disabling script. Reason: {0}", result);
            enabled = false;
            return;
        }
        _gestures = new MLHandKeyPose[5];
        _gestures[0] = MLHandKeyPose.Ok;
        _gestures[1] = MLHandKeyPose.Finger;
        _gestures[2] = MLHandKeyPose.OpenHandBack;
        _gestures[3] = MLHandKeyPose.Fist;
        _gestures[4] = MLHandKeyPose.Thumb;
        MLHands.KeyPoseManager.EnableKeyPoses(_gestures, true, false);
    }

    private void OnDestroy()
    {
        MLHands.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (MLHands.IsStarted)
        {
            //pos[0] = MLHands.Left.Middle.KeyPoints[0].Position;
            this.transform.position = MLHands.Right.Center;
            //print(Hand.IsVisible);
            //print(MLHands.Left.Index.KeyPoints[0].Position);
            //print(Hand.Thumb.KeyPoints[0].Position);
        }

    }
}
