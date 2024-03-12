using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string videoName;

    void Start()
    {
        videoPlayer.url = System.IO.Path.Combine("C:\\Users\\Admin\\Desktop\\SoulKnight\\Assets\\TimeLine", videoName);
        videoPlayer.Prepare();
        videoPlayer.loopPointReached += EndReached;
        videoPlayer.Play();
    }

    void EndReached(VideoPlayer vp)
    {
        // Video ended - handle it as needed
        SceneManager.LoadSceneAsync(1);
    }
}
