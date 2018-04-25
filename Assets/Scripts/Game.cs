﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	// configuration parameters
    [SerializeField] bool isAutoPlayEnabled = false;
    [Range(.1f, 10f)][SerializeField] float timeScale = 1f;

    // state variables

    private void Start()
    {
        int gameCount = FindObjectsOfType<MusicPlayer>().Length;
        if (gameCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }

	// Update is called once per frame
	void Update ()
	{
        Time.timeScale = timeScale;
	}
}
