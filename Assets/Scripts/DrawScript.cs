using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawScript : MonoBehaviour
{
    

    [SerializeField] Camera Cam               = null;
        [SerializeField] LineRenderer trailPrefab = null;

        private LineRenderer currentTrail;
        private List<Vector3> points = new List<Vector3>();

        void Start()
        {
           

            if(!Cam)
            {
                Cam = Camera.main;
            }
        }

        
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CreateNewLine();
            }

            if (Input.GetMouseButton(0))
            {
                AddPoint();
            }

            
        }

        private void CreateNewLine()
        {
            currentTrail = Instantiate(trailPrefab);
            currentTrail.transform.SetParent(transform, true);
            points.Clear();
        }
 
        private void UpdateLinePoints()
        {
            if(currentTrail != null && points.Count > 1)
            {
                currentTrail.positionCount = points.Count;
                currentTrail.SetPositions(points.ToArray());
            }
        }

        private void AddPoint()
        {
            var Ray = Cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                if(hit.collider.CompareTag("Writeable"))
                {
                    
                    points.Add(hit.point);
                    UpdateLinePoints();
                    return;
                }
                else
                    return;
            }
        }

    }


