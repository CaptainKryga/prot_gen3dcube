using UnityEngine;
using Random = UnityEngine.Random;

namespace Model
{
    public class Cube : MonoBehaviour
    {
        [SerializeField] private MeshRenderer mr;

        [SerializeField] private float speed;
        [SerializeField] private Vector3 endPoint;

        private void Start()
        {
            mr.material.color = Random.ColorHSV();
        }

        public void Init(float speed, float distance)
        {
            this.speed = speed;

            endPoint = transform.position + Vector3.forward * distance;
        }
        
        private void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint, speed * Time.deltaTime);
            
            if (transform.position == endPoint)
                Destroy(gameObject);
        }
    }
}
