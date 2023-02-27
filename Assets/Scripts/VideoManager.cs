using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private bool _isPlaying;
    private GameObject _videoToSpawn;
    [SerializeField] private GameObject _prefabVideo;
    [SerializeField] private VideoPlayer _videoPlayer;

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("UILaunch"))
        {
            LaunchVideo();
        }

        if (gameObject.CompareTag("UIPlay"))
        {
            PlayVideo();
        }

        if (gameObject.CompareTag("UIPause"))
        {
            PauseVideo();
        }

        if (gameObject.CompareTag("UIBack"))
        {
            BackToPanelMenu();
        }

    }

    private void InstantiateVideo()
    {
        _videoToSpawn = Instantiate(_prefabVideo, _prefabVideo.transform.position, Quaternion.identity);
    }

    private void LaunchVideo()
    {
        InstantiateVideo();
        _videoToSpawn.SetActive(true);
        _isPlaying = true;
    }

    private void PlayVideo()
    {
        _videoPlayer.Play();
        _isPlaying = true;
    }

    private void PauseVideo()
    {
        _videoPlayer.Pause();
        _isPlaying = false;
        print("Pause : " + _videoPlayer.isPaused);
    }

    private void BackToPanelMenu()
    {
        _isPlaying = false;
        _prefabVideo.gameObject.SetActive(false);
    }
}
