using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class GameConfig : MonoBehaviour
{
    public bool IsInitialized {get; private set;}
    
    public PlayerConfig PlayerConfig {get; private set;}
    public InAppPackageConfig InAppPackageConfig {get; private set;}
    public InAppPackageConfig InAppPackageConfigOne {get; private set;}
    public InAppPackageConfig InAppPackageConfigTwo {get; private set;}
    public InAppPackageConfig InAppPackageConfigThree {get; private set;}
    
    public void Initialize()
    {
        LoadPlayerConfig();
        LoadInAppPackageConfig();
        LoadInAppPackageConfigOne();
        LoadInAppPackageConfigTwo();
        LoadInAppPackageConfigThree();
    }

    private async void LoadPlayerConfig()
    {
        var playerConfig = "PlayerConfig";
        
        AsyncOperationHandle<PlayerConfig> handle = Addressables.LoadAssetAsync<PlayerConfig>(playerConfig);
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            PlayerConfig = handle.Result;
            IsInitialized = true;
            Addressables.Release(handle);
        }
    }
    
    private async void LoadInAppPackageConfig()
    {
        var inAppConfig = "InAppPackageConfig";
        
        AsyncOperationHandle<InAppPackageConfig> handle = Addressables.LoadAssetAsync<InAppPackageConfig>(inAppConfig);
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            InAppPackageConfig = handle.Result;
            IsInitialized = true;
            Addressables.Release(handle);
        }
    }
    
    private async void LoadInAppPackageConfigOne()
    {
        var inAppConfig = "InAppPackageConfig 1";
        
        AsyncOperationHandle<InAppPackageConfig> handle = Addressables.LoadAssetAsync<InAppPackageConfig>(inAppConfig);
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            InAppPackageConfigOne = handle.Result;
            IsInitialized = true;
            Addressables.Release(handle);
        }
    }
    
    private async void LoadInAppPackageConfigTwo()
    {
        var inAppConfig = "InAppPackageConfig 2";
        
        AsyncOperationHandle<InAppPackageConfig> handle = Addressables.LoadAssetAsync<InAppPackageConfig>(inAppConfig);
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            InAppPackageConfigTwo = handle.Result;
            IsInitialized = true;
            Addressables.Release(handle);
        }
    }
    
    private async void LoadInAppPackageConfigThree()
    {
        var inAppConfig = "InAppPackageConfig 3";
        
        AsyncOperationHandle<InAppPackageConfig> handle = Addressables.LoadAssetAsync<InAppPackageConfig>(inAppConfig);
        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            InAppPackageConfigThree = handle.Result;
            IsInitialized = true;
            Addressables.Release(handle);
        }
    }
}
