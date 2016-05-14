﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityUtilities.Examples
{
    public class NoiseOutputValueExample : MonoBehaviour
    {
        [SerializeField] NoiseOutputValue positionNoise;
        [SerializeField] Transform sphere;

        private void Update()
        {
            // Updates the value with Time.deltaTime*speed
            positionNoise.Progress();

            // Sets the y position at the current output value
            sphere.transform.position = new Vector3(0, positionNoise.OutputValue, 0f);
        }
    }
}
