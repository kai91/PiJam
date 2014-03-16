﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class ProgressBar : MonoBehaviour
    {
        private float passiveSpeed;
        private float activeSpeed;
        public float progressPercentage;
        public Vector2 posPercentage;
        public Vector2 sizePercentage;
        public Texture2D emptyTexture;
        public Texture2D fullTexture;

        private float posX, posY, width, height;

        void OnGUI()
        {
            posX = Screen.width * posPercentage.x;
            posY = Screen.height * posPercentage.y;
            width = Screen.width * sizePercentage.x;
            height = Screen.height * sizePercentage.y;

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
            passiveSpeed = 0.01f;
            activeSpeed = 0.005f;
        }

        public void incrementPassiveSpeed()
        {
            passiveSpeed += 0.01f;
        }

        public void incremnetActiveSpeed()
        {
            activeSpeed += 0.025f;
        }

        public void click()
        {
            if (!GameObject.FindObjectOfType<GameController>().GetComponent<GameController>().isBaking)
                return;
            progressPercentage += activeSpeed;
        }

        // Update is called once per frame
        void Update()
        {
            if (!GameObject.FindObjectOfType<GameController>().GetComponent<GameController>().isBaking)
                return;
            progressPercentage += Time.deltaTime * passiveSpeed;
            if (progressPercentage >= 1)
            {
                Debug.Log("Baking done");
            }
        }
    }
}
