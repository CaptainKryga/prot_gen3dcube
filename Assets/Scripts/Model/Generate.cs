using UnityEngine;

namespace Model
{
    public class Generate : MonoBehaviour
    {
        [SerializeField] private Transform startPoint, parent;
        [SerializeField] private Cube prefabCube;
        
        private float delay = 1, time;
        private float speed = 1;
        private float distance = 5;

        public float Delay
        {
            set
            {
                delay = value;

                if (time > delay)
                    time = delay;
            }
        }

        public float Speed { set => speed = value; }
        public float Distance { set => distance = value; }
        
        private void Update()
        {
            time -= Time.deltaTime;

            if (time < 0)
            {
                GenerateNewCube();
                time = delay;
            }
        }

        private void GenerateNewCube()
        {
            Cube cube = Instantiate(prefabCube, startPoint.position, Quaternion.identity, parent);
            cube.Init(speed, distance);
        }
    }
}
