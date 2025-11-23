using UnityEngine;

public class Player : MonoBehaviour
{
    private GameConfig _gameConfig;
    
    private void Awake()
    {
        _gameConfig = Bootstrap.Container.Resolve<GameConfig>();
    }

    private void Update()
    {
        if (_gameConfig.IsInitialized == false) return;
        transform.position += transform.forward * _gameConfig.PlayerConfig.StartingSpeed * Time.deltaTime;
    }
}
