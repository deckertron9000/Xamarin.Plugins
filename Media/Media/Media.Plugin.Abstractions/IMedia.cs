using System;
using System.Threading.Tasks;

namespace Media.Plugin.Abstractions
{
  /// <summary>
  /// Interface for Media
  /// </summary>
  public interface IMedia
  {
    /// <summary>
    /// Gets if a camera is available on the device
    /// </summary>
    bool IsCameraAvailable { get; }
    /// <summary>
    /// Gets if ability to take photos supported on the device
    /// </summary>
    bool IsTakePhotoSupported { get; }

    /// <summary>
    /// Gets if the ability to pick photo is supported on the device
    /// </summary>
    bool IsPickPhotoSupported { get; }
    /// <summary>
    /// Gets if ability to take video is supported on the device
    /// </summary>
    bool IsTakeVideoSupported { get; }

    /// <summary>
    /// Gets if the ability to pick a video is supported on the device
    /// </summary>
    bool IsPickVideoSupported { get; }

	/// <summary>
	/// Gets if a microphone is available on the device
	/// </summary>
	bool IsMicrophoneAvailable { get; }

	/// <summary>
	/// Gets if the ability to take audio is supported on the device
	/// </summary>
	bool IsTakeAudioSupported { get; }

	/// <summary>
	/// Gets if the ability to pick audio is supported on the device
	/// </summary>
	bool IsPickAudioSupported { get; }

    /// <summary>
    /// Picks a photo from the default gallery
    /// </summary>
    /// <returns>Media file or null if canceled</returns>
    Task<MediaFile> PickPhotoAsync();

    /// <summary>
    /// Take a photo async with specified options
    /// </summary>
    /// <param name="options">Camera Media Options</param>
    /// <returns>Media file of photo or null if canceled</returns>
    Task<MediaFile> TakePhotoAsync(StoreCameraMediaOptions options);

    /// <summary>
    /// Picks a video from the default gallery
    /// </summary>
    /// <returns>Media file of video or null if canceled</returns>
    Task<MediaFile> PickVideoAsync();

    /// <summary>
    /// Take a video with specified options
    /// </summary>
    /// <param name="options">Video Media Options</param>
    /// <returns>Media file of new video or null if canceled</returns>
    Task<MediaFile> TakeVideoAsync(StoreVideoOptions options);

	/// <summary>
	/// Picks audio from the default gallery
	/// </summary>
	/// <returns>Media file of audio or null if cancelled</returns>
	Task<MediaFile> PickAudioAsync();

	/// <summary>
	/// Take audio with specified options
	/// </summary>
	/// <param name="options">Audio Media Options</param>
	/// <returns>Media file of new audio or null if cancelled</returns>
	Task<MediaFile> TakeAudioAsync(StoreAudioOptions options);
  }
}
