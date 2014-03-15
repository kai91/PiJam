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
        public Vector2 pos;
        public Vector2 size;
        public Texture2D emptyTex;
        public Texture2D fullTex;

        void OnGUI()
        {
            float posX = Screen.width * pos.x;
            float posY = Screen.height * pos.y;
            float width = size.x;
            float height = size.y;

            //draw the background:
            GUI.BeginGroup(new Rect(posX, posY, width, height));
            GUI.DrawTexture(new Rect(0, 0, width, height), emptyTex);

            //draw the filled-in part:
            GUI.BeginGroup(new Rect(0, 0, width * progressPercentage, height));
            GUI.DrawTexture(new Rect(0, 0, width, height), fullTex);

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
