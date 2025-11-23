using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public static ConfigService Container { get; private set; }


    private void Awake()

    {

        Container = new ConfigService();

        

        var gameConfig = new GameConfig();

        

        gameConfig.Initialize();

        

        Container.Register(gameConfig);

    }
}
