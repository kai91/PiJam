using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class ProgressBar : MonoBehaviour
    {
        public float progressPercentage;
        public Vector2 posPercentage;
        public Vector2 sizePercentage;
        public Texture2D emptyTexture;
        public Texture2D fullTexture;

        void OnGUI()
        {
            float posX = Screen.width * posPercentage.x;
            float posY = Screen.height * posPercentage.y;
            float width = Screen.width * sizePercentage.x;
            float height = Screen.height * sizePercentage.y;

            //draw the background:
            GUI.BeginGroup(new Rect(posX, posY, width, height));
            GUI.DrawTexture(new Rect(0, 0, width, height), emptyTexture);

            //draw the filled-in part:
            GUI.BeginGroup(new Rect(0, 0, width * progressPercentage, height));
            GUI.DrawTexture(new Rect(0, 0, width, height), fullTexture);

            GUI.EndGroup();
            GUI.EndGroup();
        }

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
