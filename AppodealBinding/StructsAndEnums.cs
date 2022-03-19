using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppodealBinding
{

	static class CFunctions
	{
		// extern NSArray * _Nonnull AppodealAvailableUnitSizes ();
		[DllImport("__Internal")]
		static extern NSObject[] AppodealAvailableUnitSizes();

		// extern BOOL AppodealIsUnitSizeSupported (const CGSize size, NSArray * _Nonnull supportedSizes);
		[DllImport("__Internal")]
		
		static extern bool AppodealIsUnitSizeSupported(CGSize size, NSObject[] supportedSizes);

		// extern BOOL AppodealIsUnitSizeAvailable (const CGSize size);
		[DllImport("__Internal")]
		static extern bool AppodealIsUnitSizeAvailable(CGSize size);

		// extern CGSize AppodealNearestUnitSizeForSize (CGSize size);
		[DllImport("__Internal")]
		static extern CGSize AppodealNearestUnitSizeForSize(CGSize size);

		// extern BOOL APDIsAdSizeValid (const CGSize size);
		[DllImport("__Internal")]
		static extern bool APDIsAdSizeValid(CGSize size);

		// extern CGSize APDNearestValidAdSizeForCGSize (const CGSize size);
		[DllImport("__Internal")]
		static extern CGSize APDNearestValidAdSizeForCGSize(CGSize size);

		// extern NSString * _Nonnull APDSdkVersionString ();
		[DllImport("__Internal")]
		static extern NSString APDSdkVersionString();

		// extern NSString * _Nonnull APDFrameworkString (APDFramework framework);
		[DllImport("__Internal")]
		static extern NSString APDFrameworkString(APDFramework framework);
	}

	[Flags]
	[Native]
	public enum AppodealAdType : long
	{
		Interstitial = 1L << 0,
		Banner = 1L << 2,
		NativeAd = 1L << 3,
		RewardedVideo = 1L << 4,
		Mrec = 1L << 5,
		NonSkippableVideo = 1L << 6
	}

	[Flags]
	[Native]
	public enum APDAdType : ulong
	{
		InterstitialAd = AppodealAdType.Interstitial,
		Banner = AppodealAdType.Banner,
		NativeAd = AppodealAdType.NativeAd,
		RewardedVideo = AppodealAdType.RewardedVideo,
		Mrec = AppodealAdType.Mrec
	}

	[Flags]
	[Native]
	public enum AppodealShowStyle : long
	{
		Interstitial = 1L << 0,
		BannerTop = 1L << 2,
		BannerBottom = 1L << 3,
		RewardedVideo = 1L << 4,
		NonSkippableVideo = 1L << 5,
		BannerLeft = 1L << 6,
		BannerRight = 1L << 7
	}

	[Native]
	public enum AppodealUserGender : ulong
	{
		Other = 0,
		Female,
		Male
	}

	[Native]
	public enum APDErrorCode : long
	{
		Unknown = 195944097,
		MediationFailed,
		NoConnection,
		PresentationFailed,
		InitialisationFailed,
		Denied
	}

	[Flags]
	[Native]
	public enum APDLogFlag : ulong
	{
		LogFlagError = 1uL << 0,
		LogFlagWarning = 1uL << 1,
		LogFlagInfo = 1uL << 2,
		LogFlagDebug = 1uL << 3,
		logFlagVerbose = 1uL << 4
	}

	[Native]
	public enum APDLogLevel : ulong
	{
		Off = 0,
		Error = APDLogFlag.LogFlagError,
		Warning = Error | APDLogFlag.LogFlagWarning,
		Info = Warning | APDLogFlag.LogFlagInfo,
		Debug = Info | APDLogFlag.LogFlagDebug,
		Verbose = Debug | APDLogFlag.logFlagVerbose
	}

	[Native]
	public enum APDNativeAdType : ulong
	{
		Auto = 0,
		Video,
		NoVideo
	}

	[Native]
	public enum APDUserGender : ulong
	{
		Other = AppodealUserGender.Other,
		Female = AppodealUserGender.Female,
		Male = AppodealUserGender.Male
	}

	[Native]
	public enum APDFramework : ulong
	{
		Native = 1,
		Unity,
		Cocos2d,
		Marmalade,
		PhoneGap,
		GiderosMobile,
		AdobeAir,
		Cordova,
		Xamarin,
		GameMaker,
		MonkeyX,
		Sc2,
		LibGDX,
		Qt,
		Ue4,
		ReactNative,
		Corona,
		Stencyl,
		SDKBox,
		Defold,
		BuildBox,
		Flutter
	}

	[Native]
	public enum APDActivityType : long
	{
		MediationStart = 0,
		MediationFinish,
		ImpressionStart,
		ImpressionFinish,
		Click
	}

	[Flags]
	[Native]
	public enum APDNativeResourceAutocacheMask : ulong
	{
		Icon = 1uL << 0,
		Media = 1uL << 1
	}
}