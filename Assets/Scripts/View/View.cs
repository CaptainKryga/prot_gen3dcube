using UnityEngine;

namespace View
{
    public class View : MonoBehaviour
    {
        [SerializeField] private Controller.Controller controller;
        
        public void OnInputField_SetDelay(string str)
        {
            float delay = float.Parse(str);
            controller.UpdateDelay(delay);
        }
        
        public void OnInputField_SetSpeed(string str)
        {
            float speed = float.Parse(str);
            controller.UpdateSpeed(speed);
        }
        
        public void OnInputField_SetDistance(string str)
        {
            float distance = float.Parse(str);
            controller.UpdateDistance(distance);
        }
    }
    
}
