﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DGTools.NeuralNetwork.Test {
    public class BallState : MonoBehaviour
    {

        public bool dropped = false;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "drop") dropped = true;
        }
    }
}

