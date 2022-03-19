using System;
using Appodeal;
using CoreGraphics;
using Foundation;
using UIKit;

// @interface Appodeal : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface Appodeal
{
	// +(NSArray<NSString *> * _Nonnull)registeredNetworkNames;
	[Static]
	[Export ("registeredNetworkNames")]
	[Verify (MethodToProperty)]
	string[] RegisteredNetworkNames { get; }

	// +(void)disableNetworks:(NSArray<NSString *> * _Nullable)networks;
	[Static]
	[Export ("disableNetworks:")]
	void DisableNetworks ([NullAllowed] string[] networks);

	// +(void)disableNetworks:(NSArray<NSString *> * _Nullable)networks forAdType:(AppodealAdType)adType;
	[Static]
	[Export ("disableNetworks:forAdType:")]
	void DisableNetworks ([NullAllowed] string[] networks, AppodealAdType adType);

	// +(void)disableNetwork:(NSString * _Nonnull)networkName;
	[Static]
	[Export ("disableNetwork:")]
	void DisableNetwork (string networkName);

	// +(void)disableNetworkForAdType:(AppodealAdType)adType name:(NSString * _Nonnull)networkName;
	[Static]
	[Export ("disableNetworkForAdType:name:")]
	void DisableNetworkForAdType (AppodealAdType adType, string networkName);

	// +(double)predictedEcpmForAdType:(AppodealAdType)type;
	[Static]
	[Export ("predictedEcpmForAdType:")]
	double PredictedEcpmForAdType (AppodealAdType type);

	// +(void)setLocationTracking:(BOOL)enabled;
	[Static]
	[Export ("setLocationTracking:")]
	void SetLocationTracking (bool enabled);

	// +(void)setAutocache:(BOOL)autocache types:(AppodealAdType)types;
	[Static]
	[Export ("setAutocache:types:")]
	void SetAutocache (bool autocache, AppodealAdType types);

	// +(BOOL)isAutocacheEnabled:(AppodealAdType)types;
	[Static]
	[Export ("isAutocacheEnabled:")]
	bool IsAutocacheEnabled (AppodealAdType types);

	// +(void)initializeWithApiKey:(NSString * _Nonnull)apiKey types:(AppodealAdType)types hasConsent:(BOOL)consent;
	[Static]
	[Export ("initializeWithApiKey:types:hasConsent:")]
	void InitializeWithApiKey (string apiKey, AppodealAdType types, bool consent);

	// +(void)initializeWithApiKey:(NSString * _Nonnull)apiKey types:(AppodealAdType)types;
	[Static]
	[Export ("initializeWithApiKey:types:")]
	void InitializeWithApiKey (string apiKey, AppodealAdType types);

	// +(void)setTriggerPrecacheCallbacks:(BOOL)shouldTrigger;
	[Static]
	[Export ("setTriggerPrecacheCallbacks:")]
	void SetTriggerPrecacheCallbacks (bool shouldTrigger);

	// +(BOOL)isInitalizedForAdType:(AppodealAdType)type;
	[Static]
	[Export ("isInitalizedForAdType:")]
	bool IsInitalizedForAdType (AppodealAdType type);

	// +(void)setLogLevel:(APDLogLevel)logLevel;
	[Static]
	[Export ("setLogLevel:")]
	void SetLogLevel (APDLogLevel logLevel);

	// +(void)setFramework:(APDFramework)framework version:(NSString * _Nullable)version;
	[Static]
	[Export ("setFramework:version:")]
	void SetFramework (APDFramework framework, [NullAllowed] string version);

	// +(void)setExtras:(NSDictionary<NSString *,id> * _Nullable)extras;
	[Static]
	[Export ("setExtras:")]
	void SetExtras ([NullAllowed] NSDictionary<NSString, NSObject> extras);

	// +(void)setActivityDelegate:(id<APDActivityDelegate> _Nullable)activityDelegate;
	[Static]
	[Export ("setActivityDelegate:")]
	void SetActivityDelegate ([NullAllowed] APDActivityDelegate activityDelegate);

	// +(void)setInterstitialDelegate:(id<AppodealInterstitialDelegate> _Nullable)interstitialDelegate;
	[Static]
	[Export ("setInterstitialDelegate:")]
	void SetInterstitialDelegate ([NullAllowed] AppodealInterstitialDelegate interstitialDelegate);

	// +(void)setBannerDelegate:(id<AppodealBannerDelegate> _Nullable)bannerDelegate;
	[Static]
	[Export ("setBannerDelegate:")]
	void SetBannerDelegate ([NullAllowed] AppodealBannerDelegate bannerDelegate);

	// +(void)setRewardedVideoDelegate:(id<AppodealRewardedVideoDelegate> _Nullable)rewardedVideoDelegate;
	[Static]
	[Export ("setRewardedVideoDelegate:")]
	void SetRewardedVideoDelegate ([NullAllowed] AppodealRewardedVideoDelegate rewardedVideoDelegate);

	// +(void)setNonSkippableVideoDelegate:(id<AppodealNonSkippableVideoDelegate> _Nullable)nonSkippableVideoDelegate;
	[Static]
	[Export ("setNonSkippableVideoDelegate:")]
	void SetNonSkippableVideoDelegate ([NullAllowed] AppodealNonSkippableVideoDelegate nonSkippableVideoDelegate);

	// +(void)setPreferredBannerAdSize:(APDUnitSize)adSize;
	[Static]
	[Export ("setPreferredBannerAdSize:")]
	void SetPreferredBannerAdSize (APDUnitSize adSize);

	// +(UIView * _Nullable)banner;
	[Static]
	[NullAllowed, Export ("banner")]
	[Verify (MethodToProperty)]
	UIView Banner { get; }

	// +(BOOL)showAd:(AppodealShowStyle)style rootViewController:(UIViewController * _Nullable)rootViewController;
	[Static]
	[Export ("showAd:rootViewController:")]
	bool ShowAd (AppodealShowStyle style, [NullAllowed] UIViewController rootViewController);

	// +(BOOL)showAd:(AppodealShowStyle)style forPlacement:(NSString * _Nonnull)placement rootViewController:(UIViewController * _Nullable)rootViewController;
	[Static]
	[Export ("showAd:forPlacement:rootViewController:")]
	bool ShowAd (AppodealShowStyle style, string placement, [NullAllowed] UIViewController rootViewController);

	// +(BOOL)canShow:(AppodealAdType)type forPlacement:(NSString * _Nonnull)placement;
	[Static]
	[Export ("canShow:forPlacement:")]
	bool CanShow (AppodealAdType type, string placement);

	// +(id<APDReward> _Nonnull)rewardForPlacement:(NSString * _Nonnull)placement;
	[Static]
	[Export ("rewardForPlacement:")]
	APDReward RewardForPlacement (string placement);

	// +(void)cacheAd:(AppodealAdType)type;
	[Static]
	[Export ("cacheAd:")]
	void CacheAd (AppodealAdType type);

	// +(void)hideBanner;
	[Static]
	[Export ("hideBanner")]
	void HideBanner ();

	// +(void)setTestingEnabled:(BOOL)testingEnabled;
	[Static]
	[Export ("setTestingEnabled:")]
	void SetTestingEnabled (bool testingEnabled);

	// +(void)trackInAppPurchase:(NSNumber * _Nonnull)amount currency:(NSString * _Nonnull)currency;
	[Static]
	[Export ("trackInAppPurchase:currency:")]
	void TrackInAppPurchase (NSNumber amount, string currency);

	// +(NSString * _Nonnull)getVersion;
	[Static]
	[Export ("getVersion")]
	[Verify (MethodToProperty)]
	string Version { get; }

	// +(BOOL)isReadyForShowWithStyle:(AppodealShowStyle)showStyle;
	[Static]
	[Export ("isReadyForShowWithStyle:")]
	bool IsReadyForShowWithStyle (AppodealShowStyle showStyle);

	// +(BOOL)isPrecacheAd:(AppodealAdType)adType;
	[Static]
	[Export ("isPrecacheAd:")]
	bool IsPrecacheAd (AppodealAdType adType);

	// +(void)setSegmentFilter:(NSDictionary * _Nonnull)segmentFilter __attribute__((deprecated("This method is deprecated. Use +setCustomState: instead")));
	[Static]
	[Export ("setSegmentFilter:")]
	void SetSegmentFilter (NSDictionary segmentFilter);

	// +(void)setCustomState:(NSDictionary * _Nonnull)customState;
	[Static]
	[Export ("setCustomState:")]
	void SetCustomState (NSDictionary customState);

	// +(void)setSmartBannersEnabled:(BOOL)smartBannerEnabled;
	[Static]
	[Export ("setSmartBannersEnabled:")]
	void SetSmartBannersEnabled (bool smartBannerEnabled);

	// +(void)setBannerBackgroundVisible:(BOOL)bannerBackgroundVisible __attribute__((deprecated("This method is deprecated and will be removed in next release")));
	[Static]
	[Export ("setBannerBackgroundVisible:")]
	void SetBannerBackgroundVisible (bool bannerBackgroundVisible);

	// +(void)setBannerAnimationEnabled:(BOOL)bannerAnimationEnabled;
	[Static]
	[Export ("setBannerAnimationEnabled:")]
	void SetBannerAnimationEnabled (bool bannerAnimationEnabled);

	// +(void)setBannerLeftRotationAngleDegrees:(CGFloat)leftRotationAngleDegrees rightRotationAngleDegrees:(CGFloat)rightRotationAngleDegrees;
	[Static]
	[Export ("setBannerLeftRotationAngleDegrees:rightRotationAngleDegrees:")]
	void SetBannerLeftRotationAngleDegrees (nfloat leftRotationAngleDegrees, nfloat rightRotationAngleDegrees);

	// +(void)setChildDirectedTreatment:(BOOL)childDirectedTreatment;
	[Static]
	[Export ("setChildDirectedTreatment:")]
	void SetChildDirectedTreatment (bool childDirectedTreatment);

	// +(void)updateConsent:(BOOL)consent;
	[Static]
	[Export ("updateConsent:")]
	void UpdateConsent (bool consent);

	// +(APDFramework)framework;
	[Static]
	[Export ("framework")]
	[Verify (MethodToProperty)]
	APDFramework Framework { get; }

	// +(NSString * _Nullable)frameworkVersion;
	[Static]
	[NullAllowed, Export ("frameworkVersion")]
	[Verify (MethodToProperty)]
	string FrameworkVersion { get; }

	// +(NSString * _Nullable)pluginVersion;
	// +(void)setPluginVersion:(NSString * _Nonnull)pluginVersion;
	[Static]
	[NullAllowed, Export ("pluginVersion")]
	[Verify (MethodToProperty)]
	string PluginVersion { get; set; }

	// +(NSNumber * _Nonnull)segmentId;
	[Static]
	[Export ("segmentId")]
	[Verify (MethodToProperty)]
	NSNumber SegmentId { get; }
}

// @interface UserMetadata (Appodeal)
[Category]
[BaseType (typeof(Appodeal))]
interface Appodeal_UserMetadata
{
	// +(void)setUserId:(NSString * _Nonnull)userId;
	[Static]
	[Export ("setUserId:")]
	void SetUserId (string userId);

	// +(void)setUserAge:(NSUInteger)age;
	[Static]
	[Export ("setUserAge:")]
	void SetUserAge (nuint age);

	// +(void)setUserGender:(AppodealUserGender)gender;
	[Static]
	[Export ("setUserGender:")]
	void SetUserGender (AppodealUserGender gender);
}
