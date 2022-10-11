using UnityEngine;

namespace Controller
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private Model.Model model;
        public void UpdateDelay(float delay)
        {
            model.UpdateDelay(delay);
        }
        
        public void UpdateSpeed(float speed)
        {
            model.UpdateSpeed(speed);
        }

        public void UpdateDistance(float distance)
        {
            model.UpdateDistance(distance);
        }
    }
}
