using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    public class Model : MonoBehaviour
    {
        [SerializeField] private Generate generate;
        
        public void UpdateDelay(float delay)
        {
            generate.Delay = delay;
        }
        
        public void UpdateSpeed(float speed)
        {
            generate.Speed = speed;
        }

        public void UpdateDistance(float distance)
        {
            generate.Distance = distance;
        }
    }
}
