using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Player : MonoBehaviour
{
    [SerializeField] private AssetReference _config;
    
    private PlayerConfig _playerConfig;
    private AsyncOperationHandle<PlayerConfig> _handle;

    private bool _isInitialized;

    private async void Start()
    {
        _handle = _config.LoadAssetAsync<PlayerConfig>();
        await _handle.Task;

        if (_handle.Status == AsyncOperationStatus.Succeeded)
        {
            _playerConfig = _handle.Result;
            _isInitialized = true;
            Addressables.Release(_handle);
        }
    }
    
    private void Update()
    {
        if (_isInitialized == false) return;
        transform.position += transform.forward * _playerConfig.StartingSpeed * Time.deltaTime;
    }
}
