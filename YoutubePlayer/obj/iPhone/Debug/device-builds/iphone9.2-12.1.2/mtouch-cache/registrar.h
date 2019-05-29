#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@class UIApplicationDelegate;
@class AppDelegate;
@class FirstViewController;
@class SecondViewController;
@class UIKit_UIControlEventProxy;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class UIKit_UIView_UIViewAppearance;
@class __NSObject_Disposer;
@protocol YTPlayerViewDelegate;
@class YTPlayerViewDelegate;
@class NativeLibrary_YTPlayerView_YTPlayerViewAppearance;
@class YTPlayerView;

@interface UIApplicationDelegate : NSObject<UIApplicationDelegate> {
}
	-(id) init;
@end

@interface AppDelegate : NSObject<UIApplicationDelegate, UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface FirstViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * PauseButton1;
	@property (nonatomic, assign) UIButton * PlayButton1;
	@property (nonatomic, assign) id Video1;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) PauseButton1;
	-(void) setPauseButton1:(UIButton *)p0;
	-(UIButton *) PlayButton1;
	-(void) setPlayButton1:(UIButton *)p0;
	-(id) Video1;
	-(void) setVideo1:(id)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(void) PauseButton1_TouchUpInside:(UIButton *)p0;
	-(void) PlayButton1_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface SecondViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * SearchButton;
	@property (nonatomic, assign) UITextField * Text1;
	@property (nonatomic, assign) id Video2;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) SearchButton;
	-(void) setSearchButton:(UIButton *)p0;
	-(UITextField *) Text1;
	-(void) setText1:(UITextField *)p0;
	-(id) Video2;
	-(void) setVideo2:(id)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(void) SearchButton_TouchUpInside:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface UIKit_UIView_UIViewAppearance : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@protocol YTPlayerViewDelegate
	@optional -(void) playerViewDidBecomeReady:(id)p0;
	@optional -(void) playerView:(id)p0 didChangeToState:(int)p1;
	@optional -(void) playerView:(id)p0 didChangeToQuality:(int)p1;
	@optional -(void) playerView:(id)p0 receivedError:(int)p1;
	@optional -(void) playerView:(id)p0 didPlayTime:(float)p1;
	@optional -(UIColor *) playerViewPreferredWebViewBackgroundColor:(id)p0;
	@optional -(UIView *) playerViewPreferredInitialLoadingView:(id)p0;
@end

@interface YTPlayerViewDelegate : NSObject<YTPlayerViewDelegate> {
}
	-(id) init;
@end

@interface NativeLibrary_YTPlayerView_YTPlayerViewAppearance : UIKit_UIView_UIViewAppearance {
}
@end

@interface YTPlayerView : UIView {
}
	-(NSArray *) availablePlaybackRates;
	-(NSArray *) availableQualityLevels;
	-(void) cuePlaylistByPlaylistId:(NSString *)p0 index:(int)p1 startSeconds:(float)p2 suggestedQuality:(int)p3;
	-(void) cuePlaylistByVideos:(NSArray *)p0 index:(int)p1 startSeconds:(float)p2 suggestedQuality:(int)p3;
	-(void) cueVideoById:(NSString *)p0 startSeconds:(float)p1 suggestedQuality:(int)p2;
	-(void) cueVideoById:(NSString *)p0 startSeconds:(float)p1 endSeconds:(float)p2 suggestedQuality:(int)p3;
	-(void) cueVideoByURL:(NSString *)p0 startSeconds:(float)p1 suggestedQuality:(int)p2;
	-(void) cueVideoByURL:(NSString *)p0 startSeconds:(float)p1 endSeconds:(float)p2 suggestedQuality:(int)p3;
	-(float) currentTime;
	-(double) duration;
	-(void) loadPlaylistByPlaylistId:(NSString *)p0 index:(int)p1 startSeconds:(float)p2 suggestedQuality:(int)p3;
	-(void) loadPlaylistByVideos:(NSArray *)p0 index:(int)p1 startSeconds:(float)p2 suggestedQuality:(int)p3;
	-(void) loadVideoById:(NSString *)p0 startSeconds:(float)p1 suggestedQuality:(int)p2;
	-(void) loadVideoById:(NSString *)p0 startSeconds:(float)p1 endSeconds:(float)p2 suggestedQuality:(int)p3;
	-(void) loadVideoByURL:(NSString *)p0 startSeconds:(float)p1 suggestedQuality:(int)p2;
	-(void) loadVideoByURL:(NSString *)p0 startSeconds:(float)p1 endSeconds:(float)p2 suggestedQuality:(int)p3;
	-(BOOL) loadWithPlayerParams:(NSDictionary *)p0;
	-(BOOL) loadWithPlaylistId:(NSString *)p0;
	-(BOOL) loadWithPlaylistId:(NSString *)p0 playerVars:(NSDictionary *)p1;
	-(BOOL) loadWithVideoId:(NSString *)p0;
	-(BOOL) loadWithVideoId:(NSString *)p0 playerVars:(NSDictionary *)p1;
	-(void) nextVideo;
	-(void) pauseVideo;
	-(void) playVideo;
	-(void) playVideoAt:(int)p0;
	-(int) playbackQuality;
	-(float) playbackRate;
	-(int) playerState;
	-(NSArray *) playlist;
	-(NSInteger) playlistIndex;
	-(void) previousVideo;
	-(void) removeWebView;
	-(void) seekToSeconds:(float)p0 allowSeekAhead:(BOOL)p1;
	-(void) setLoop:(BOOL)p0;
	-(void) setPlaybackQuality:(int)p0;
	-(void) setPlaybackRate:(float)p0;
	-(void) setShuffle:(BOOL)p0;
	-(void) stopVideo;
	-(NSString *) videoEmbedCode;
	-(float) videoLoadedFraction;
	-(NSURL *) videoUrl;
	-(NSObject *) delegate;
	-(void) setDelegate:(NSObject *)p0;
	-(UIWebView *) webView;
	-(id) init;
	-(id) initWithCoder:(NSCoder *)p0;
@end


