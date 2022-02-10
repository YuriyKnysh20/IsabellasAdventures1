using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdsCore : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] private bool _testMode = false;
    private string _gameId = "4263973";
    private string _video = "Interstitial_Android";
    private string _rewardedVideo = "Rewarded_Android";
    private string _banner = "Banner_Android";
    void Start()//инициализация сервисов
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(_gameId, _testMode);

        #region Banner
        StartCoroutine(ShowBannerWhenInitialized());
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
       #endregion
    }
    public static void ShowAdsVideo(string placementId)//инициализация рекламы по типу
    {
        if(Advertisement.IsReady())
        {
            Advertisement.Show(placementId);
        }
        else
        {
            Debug.Log("Advertisement not ready!");
        }
    }

    IEnumerator ShowBannerWhenInitialized()
    {
        while(!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show(_banner);
    }

    public void OnUnityAdsReady(string placementId)
    {
        if(placementId==_rewardedVideo)
        {
            //дейсвтия,если реклама доступна
        }
    }
    public void OnUnityAdsDidError(string message)
    {
        //ошибка рекламы
    }
    public void OnUnityAdsDidStart(string placementId)
    {
     //только запустили рекламу
    }


  public void OnUnityAdsDidFinish(string placementId,ShowResult showResult)//обработка рекламы
    {
        if(showResult==ShowResult.Finished)
        {
            Debug.Log("+1");
            //действия если пользователь посмотрел рекламу до конца
        }
        else if(showResult == ShowResult.Skipped)
        {
            Debug.Log("Пирожок");
            //действия если пользователь пропустил рекламу
        }
        else if(showResult==ShowResult.Failed)
        {
            //действия при ошибке
        }
    }   
}
