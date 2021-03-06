﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public class UI : MonoBehaviour
    {
        private const float ButtonWidthPercentage = 0.35f;
        private const float ButtonHeightPercentage = 0.075f;
        private readonly Vector2 ClearButtonPosPercentage = new Vector2(0.1f, 0.9f);
        private readonly Vector2 BakeButtonPosPercentage = new Vector2(0.55f, 0.9f);
        private readonly Vector2 RetryButtonPosPercentage = new Vector2(0.55f, 0.9f);   // retry and keeptrying button are at the same spot as bake button
        private Texture2D clearButtonTexture;
        private Texture2D bakeButtonTexture;
        private Texture2D retryButtonTexture;
        private Texture2D keepTryingButtonTexture;
        private GameController gameController;

        void Start()
        {
            bakeButtonTexture = (Texture2D)Resources.Load("BakeButtonTexture");
            clearButtonTexture = (Texture2D)Resources.Load("ClearButtonTexture");
            retryButtonTexture = (Texture2D)Resources.Load("RetryButtonTexture");
            keepTryingButtonTexture = (Texture2D)Resources.Load("KeepTryingButtonTexture");

            gameController = GameObject.FindObjectOfType<GameController>().GetComponent<GameController>();
        }

        void OnGUI()
        {
            float buttonWidth = ButtonWidthPercentage * Screen.width;
            float buttonHeight = ButtonHeightPercentage * Screen.height;
            Vector2 clearButtonPos = new Vector2(ClearButtonPosPercentage.x * Screen.width, ClearButtonPosPercentage.y * Screen.height);
            Vector2 bakeButtonPos = new Vector2(BakeButtonPosPercentage.x * Screen.width, BakeButtonPosPercentage.y * Screen.height);
            Vector2 retryButtonPos = new Vector2(RetryButtonPosPercentage.x * Screen.width, RetryButtonPosPercentage.y * Screen.height);

            if (!gameController.isBaking && !gameController.doneBaking && !gameController.isGameOver)
            {
                if (GUI.Button(new Rect(clearButtonPos.x, clearButtonPos.y, buttonWidth, buttonHeight), clearButtonTexture))
                {
                    //Debug.Log("Clear button clicked");
                    gameController.ClearPie();
                }

                if (GUI.Button(new Rect(bakeButtonPos.x, bakeButtonPos.y, buttonWidth, buttonHeight), bakeButtonTexture))
                {
                    //Debug.Log("Bake button clicked");
                    gameController.BakePie();
                }
            }

            if (gameController.doneBaking || gameController.isGameOver)
            {
                // Spawn emoticon and message here

                if (gameController.isGameOver)
                {
                    if (GUI.Button(new Rect(retryButtonPos.x, retryButtonPos.y, buttonWidth, buttonHeight), retryButtonTexture))
                    {
                        Debug.Log("Retry button clicked");
                        gameController.Retry();
                    }
                }
                else
                {
                    if (GUI.Button(new Rect(retryButtonPos.x, retryButtonPos.y, buttonWidth, buttonHeight), keepTryingButtonTexture))
                    {
                        Debug.Log("Keep trying button clicked");
                        gameController.KeepTrying();
                    }
                }
            }
        }
    }
}
