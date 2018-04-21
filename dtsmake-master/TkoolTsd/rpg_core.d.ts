// Type definitions for rpg_core.js
// Project: [LIBRARY_URL_HERE] 
// Definitions by: [YOUR_NAME_HERE] <[YOUR_URL_HERE]> 
// Definitions: https://github.com/borisyankov/DefinitelyTyped
declare namespace Array.prototype{
	// Array.prototype.equals.!ret
	type EqualsRet = boolean;
}
declare namespace Array.prototype{
	// Array.prototype.clone.!ret
	type CloneRet = Array<any>;
}
declare namespace Array.prototype{
	// Array.prototype.contains.!ret
	type ContainsRet = boolean;
}
declare namespace String.prototype{
	// String.prototype.format.!ret
	type FormatRet = string;
}
declare namespace String.prototype{
	// String.prototype.padZero.!0
	type PadZero0 = number;
}
declare namespace String.prototype{
	// String.prototype.padZero.!ret
	type PadZeroRet = string;
}
declare namespace String.prototype{
	// String.prototype.contains.!0
	type Contains0 = string;
}
declare namespace String.prototype{
	// String.prototype.contains.!ret
	type ContainsRet = boolean;
}
declare namespace Number.prototype{
	// Number.prototype.clamp.!0
	type Clamp0 = number;
}
declare namespace Number.prototype{
	// Number.prototype.clamp.!1
	type Clamp1 = number;
}
declare namespace Number.prototype{
	// Number.prototype.clamp.!ret
	type ClampRet = number;
}
declare namespace Number.prototype{
	// Number.prototype.mod.!0
	type Mod0 = number;
}
declare namespace Number.prototype{
	// Number.prototype.mod.!ret
	type ModRet = number;
}
declare namespace Number.prototype{
	// Number.prototype.padZero.!0
	type PadZero0 = number;
}
declare namespace Number.prototype{
	// Number.prototype.padZero.!ret
	type PadZeroRet = string;
}
declare namespace Math{
	// Math.randomInt.!0
	type RandomInt0 = number;
}
declare namespace Math{
	// Math.randomInt.!ret
	type RandomIntRet = number;
}
declare namespace Utils{
	// Utils.isOptionValid.!0
	type IsOptionValid0 = string;
}
declare namespace Utils{
	// Utils.isOptionValid.!ret
	type IsOptionValidRet = boolean;
}
declare namespace Utils{
	// Utils.isNwjs.!ret
	type IsNwjsRet = boolean;
}
declare namespace Utils{
	// Utils.isMobileDevice.!ret
	type IsMobileDeviceRet = boolean;
}
declare namespace Utils{
	// Utils.isMobileSafari.!ret
	type IsMobileSafariRet = boolean;
}
declare namespace Utils{
	// Utils.isAndroidChrome.!ret
	type IsAndroidChromeRet = boolean;
}
declare namespace Utils{
	// Utils.canReadGameFiles.!ret
	type CanReadGameFilesRet = boolean;
}
declare namespace Utils{
	// Utils.rgbToCssColor.!0
	type RgbToCssColor0 = number;
}
declare namespace Utils{
	// Utils.rgbToCssColor.!1
	type RgbToCssColor1 = number;
}
declare namespace Utils{
	// Utils.rgbToCssColor.!2
	type RgbToCssColor2 = number;
}
declare namespace Utils{
	// Utils.rgbToCssColor.!ret
	type RgbToCssColorRet = string;
}
declare namespace Utils{
	// Utils.generateRuntimeId.!ret
	type GenerateRuntimeIdRet = number;
}
declare namespace Utils{
	// Utils.isSupportPassiveEvent.!ret
	type IsSupportPassiveEventRet = boolean;
}
declare namespace CacheEntry.prototype{
	// CacheEntry.prototype.free.!0
	type Free0 = boolean;
}
declare namespace CacheEntry.prototype{
	// CacheEntry.prototype.setTimeToLive.!0
	type SetTimeToLive0 = number;
}
declare namespace CacheEntry.prototype{
	// CacheEntry.prototype.setTimeToLive.!1
	type SetTimeToLive1 = number;
}
declare namespace CacheEntry.prototype{
	// CacheEntry.prototype.isStillAlive.!ret
	type IsStillAliveRet = boolean;
}
// CacheEntry.!2
declare namespace CacheMap.prototype{
	// CacheMap.prototype.getItem.!ret
	type GetItemRet = string;
}
declare namespace CacheMap.prototype{
	// CacheMap.prototype.setItem.!1
	type SetItem1 = string;
}
declare namespace CacheMap.prototype{
	// CacheMap.prototype.update.!0
	type Update0 = number;
}
declare namespace CacheMap.prototype{
	// CacheMap.prototype.update.!1
	type Update1 = number;
}
declare namespace ImageCache.prototype{
	// ImageCache.prototype._mustBeHeld.!0
	
	/**
	 * 
	 */
	interface _mustBeHeld0 {
				
		/**
		 * 
		 */
		touch : number;
	}
}
declare namespace ImageCache.prototype{
	// ImageCache.prototype._mustBeHeld.!ret
	type _mustBeHeldRet = boolean;
}
declare namespace ImageCache.prototype{
	// ImageCache.prototype.isReady.!ret
	type IsReadyRet = boolean;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._createCanvas.!0
	type _createCanvas0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._createCanvas.!1
	type _createCanvas1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.initialize.!0
	type Initialize0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.initialize.!1
	type Initialize1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.isReady.!ret
	type IsReadyRet = boolean;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.isError.!ret
	type IsErrorRet = boolean;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.resize.!0
	type Resize0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.resize.!1
	type Resize1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!1
	type Blt1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!2
	type Blt2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!3
	type Blt3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!4
	type Blt4 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!5
	type Blt5 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!6
	type Blt6 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!7
	type Blt7 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.blt.!8
	type Blt8 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!1
	type BltImage1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!2
	type BltImage2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!3
	type BltImage3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!4
	type BltImage4 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!5
	type BltImage5 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!6
	type BltImage6 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!7
	type BltImage7 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.bltImage.!8
	type BltImage8 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.getPixel.!0
	type GetPixel0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.getPixel.!1
	type GetPixel1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.getPixel.!ret
	type GetPixelRet = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.getAlphaPixel.!0
	type GetAlphaPixel0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.getAlphaPixel.!1
	type GetAlphaPixel1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.getAlphaPixel.!ret
	type GetAlphaPixelRet = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.clearRect.!0
	type ClearRect0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.clearRect.!1
	type ClearRect1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.clearRect.!2
	type ClearRect2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.clearRect.!3
	type ClearRect3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.fillRect.!0
	type FillRect0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.fillRect.!1
	type FillRect1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.fillRect.!2
	type FillRect2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.fillRect.!3
	type FillRect3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.fillRect.!4
	type FillRect4 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.fillAll.!0
	type FillAll0 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!0
	type GradientFillRect0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!1
	type GradientFillRect1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!2
	type GradientFillRect2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!3
	type GradientFillRect3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!4
	type GradientFillRect4 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!5
	type GradientFillRect5 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.gradientFillRect.!6
	type GradientFillRect6 = boolean;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawCircle.!0
	type DrawCircle0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawCircle.!1
	type DrawCircle1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawCircle.!2
	type DrawCircle2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawCircle.!3
	type DrawCircle3 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawText.!0
	type DrawText0 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawText.!1
	type DrawText1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawText.!2
	type DrawText2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawText.!3
	type DrawText3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawText.!4
	type DrawText4 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.drawText.!5
	type DrawText5 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.measureTextWidth.!0
	type MeasureTextWidth0 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.measureTextWidth.!ret
	type MeasureTextWidthRet = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.adjustTone.!0
	type AdjustTone0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.adjustTone.!1
	type AdjustTone1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.adjustTone.!2
	type AdjustTone2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.rotateHue.!0
	type RotateHue0 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._makeFontNameText.!ret
	type _makeFontNameTextRet = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextOutline.!0
	type _drawTextOutline0 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextOutline.!1
	type _drawTextOutline1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextOutline.!2
	type _drawTextOutline2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextOutline.!3
	type _drawTextOutline3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextBody.!0
	type _drawTextBody0 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextBody.!1
	type _drawTextBody1 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextBody.!2
	type _drawTextBody2 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._drawTextBody.!3
	type _drawTextBody3 = number;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype._requestImage.!0
	type _requestImage0 = string;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.isRequestOnly.!ret
	type IsRequestOnlyRet = boolean;
}
declare namespace Bitmap.prototype{
	// Bitmap.prototype.isRequestReady.!ret
	type IsRequestReadyRet = boolean;
}
declare namespace Bitmap{
	// Bitmap.load.!0
	type Load0 = string;
}
declare namespace Bitmap{
	// Bitmap.request.!0
	type Request0 = string;
}
declare namespace Graphics{
	// Graphics.initialize.!0
	type Initialize0 = number;
}
declare namespace Graphics{
	// Graphics.initialize.!1
	type Initialize1 = number;
}
declare namespace Graphics{
	// Graphics.initialize.!2
	type Initialize2 = string;
}
declare namespace Graphics{
	// Graphics.canUseCssFontLoading.!ret
	type CanUseCssFontLoadingRet = boolean;
}
declare namespace Graphics{
	// Graphics.isWebGL.!ret
	type IsWebGLRet = boolean;
}
declare namespace Graphics{
	// Graphics.hasWebGL.!ret
	type HasWebGLRet = boolean;
}
declare namespace Graphics{
	// Graphics.canUseDifferenceBlend.!ret
	type CanUseDifferenceBlendRet = boolean;
}
declare namespace Graphics{
	// Graphics.canUseSaturationBlend.!ret
	type CanUseSaturationBlendRet = boolean;
}
declare namespace Graphics{
	// Graphics.printLoadingError.!0
	type PrintLoadingError0 = string;
}
declare namespace Graphics{
	// Graphics.printError.!0
	type PrintError0 = string;
}
declare namespace Graphics{
	// Graphics.printError.!1
	type PrintError1 = string;
}
declare namespace Graphics{
	// Graphics.loadFont.!0
	type LoadFont0 = string;
}
declare namespace Graphics{
	// Graphics.loadFont.!1
	type LoadFont1 = string;
}
declare namespace Graphics{
	// Graphics.isFontLoaded.!0
	type IsFontLoaded0 = string;
}
declare namespace Graphics{
	// Graphics.isFontLoaded.!ret
	type IsFontLoadedRet = boolean;
}
declare namespace Graphics{
	// Graphics.playVideo.!0
	type PlayVideo0 = string;
}
declare namespace Graphics{
	// Graphics._playVideo.!0
	type _playVideo0 = string;
}
declare namespace Graphics{
	// Graphics.isVideoPlaying.!ret
	type IsVideoPlayingRet = boolean;
}
declare namespace Graphics{
	// Graphics.canPlayVideoType.!0
	type CanPlayVideoType0 = string;
}
declare namespace Graphics{
	// Graphics.canPlayVideoType.!ret
	type CanPlayVideoTypeRet = boolean;
}
declare namespace Graphics{
	// Graphics.setVideoVolume.!0
	type SetVideoVolume0 = number;
}
declare namespace Graphics{
	// Graphics.pageToCanvasX.!0
	type PageToCanvasX0 = number;
}
declare namespace Graphics{
	// Graphics.pageToCanvasX.!ret
	type PageToCanvasXRet = number;
}
declare namespace Graphics{
	// Graphics.pageToCanvasY.!0
	type PageToCanvasY0 = number;
}
declare namespace Graphics{
	// Graphics.pageToCanvasY.!ret
	type PageToCanvasYRet = number;
}
declare namespace Graphics{
	// Graphics.isInsideCanvas.!0
	type IsInsideCanvas0 = number;
}
declare namespace Graphics{
	// Graphics.isInsideCanvas.!1
	type IsInsideCanvas1 = number;
}
declare namespace Graphics{
	// Graphics.isInsideCanvas.!ret
	type IsInsideCanvasRet = boolean;
}
declare namespace Graphics{
	// Graphics._makeErrorHtml.!0
	type _makeErrorHtml0 = string;
}
declare namespace Graphics{
	// Graphics._makeErrorHtml.!1
	type _makeErrorHtml1 = string;
}
declare namespace Graphics{
	// Graphics._makeErrorHtml.!ret
	type _makeErrorHtmlRet = string;
}
declare namespace Graphics{
	// Graphics._defaultStretchMode.!ret
	type _defaultStretchModeRet = boolean;
}
declare namespace Graphics{
	// Graphics._createFontLoader.!0
	type _createFontLoader0 = string;
}
declare namespace Graphics{
	// Graphics._updateVisibility.!0
	type _updateVisibility0 = boolean;
}
declare namespace Graphics{
	// Graphics._isVideoVisible.!ret
	type _isVideoVisibleRet = boolean;
}
declare namespace Graphics{
	// Graphics._switchStretchMode.!ret
	type _switchStretchModeRet = boolean;
}
declare namespace Graphics{
	// Graphics._isFullScreen.!ret
	type _isFullScreenRet = boolean;
}
declare namespace Input{
	// Input._gamepadStates.<i>
	type _gamepadStatesI = Array</* Input._gamepadStates._gamepadStatesII */ any>;
}
declare namespace Input._gamepadStates{
	// Input._gamepadStates.<i>.<i>
	type _gamepadStatesII = boolean;
}
declare namespace Input{
	// Input.isPressed.!0
	type IsPressed0 = string;
}
declare namespace Input{
	// Input.isPressed.!ret
	type IsPressedRet = boolean;
}
declare namespace Input{
	// Input.isTriggered.!0
	type IsTriggered0 = string;
}
declare namespace Input{
	// Input.isTriggered.!ret
	type IsTriggeredRet = boolean;
}
declare namespace Input{
	// Input.isRepeated.!0
	type IsRepeated0 = string;
}
declare namespace Input{
	// Input.isRepeated.!ret
	type IsRepeatedRet = boolean;
}
declare namespace Input{
	// Input.isLongPressed.!0
	type IsLongPressed0 = string;
}
declare namespace Input{
	// Input.isLongPressed.!ret
	type IsLongPressedRet = boolean;
}
declare namespace Input{
	// Input._shouldPreventDefault.!0
	type _shouldPreventDefault0 = number;
}
declare namespace Input{
	// Input._shouldPreventDefault.!ret
	type _shouldPreventDefaultRet = boolean;
}
declare namespace Input{
	// Input._signX.!ret
	type _signXRet = number;
}
declare namespace Input{
	// Input._signY.!ret
	type _signYRet = number;
}
declare namespace Input{
	// Input._makeNumpadDirection.!0
	type _makeNumpadDirection0 = number;
}
declare namespace Input{
	// Input._makeNumpadDirection.!1
	type _makeNumpadDirection1 = number;
}
declare namespace Input{
	// Input._makeNumpadDirection.!ret
	type _makeNumpadDirectionRet = number;
}
declare namespace Input{
	// Input._isEscapeCompatible.!0
	type _isEscapeCompatible0 = string;
}
declare namespace Input{
	// Input._isEscapeCompatible.!ret
	type _isEscapeCompatibleRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isPressed.!ret
	type IsPressedRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isTriggered.!ret
	type IsTriggeredRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isRepeated.!ret
	type IsRepeatedRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isLongPressed.!ret
	type IsLongPressedRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isCancelled.!ret
	type IsCancelledRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isMoved.!ret
	type IsMovedRet = boolean;
}
declare namespace TouchInput{
	// TouchInput.isReleased.!ret
	type IsReleasedRet = boolean;
}
declare namespace TouchInput{
	// TouchInput._onTrigger.!0
	type _onTrigger0 = number;
}
declare namespace TouchInput{
	// TouchInput._onTrigger.!1
	type _onTrigger1 = number;
}
declare namespace TouchInput{
	// TouchInput._onCancel.!0
	type _onCancel0 = number;
}
declare namespace TouchInput{
	// TouchInput._onCancel.!1
	type _onCancel1 = number;
}
declare namespace TouchInput{
	// TouchInput._onMove.!0
	type _onMove0 = number;
}
declare namespace TouchInput{
	// TouchInput._onMove.!1
	type _onMove1 = number;
}
declare namespace TouchInput{
	// TouchInput._onRelease.!0
	type _onRelease0 = number;
}
declare namespace TouchInput{
	// TouchInput._onRelease.!1
	type _onRelease1 = number;
}
declare namespace Tilemap{
	// Tilemap.isVisibleTile.!0
	type IsVisibleTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isVisibleTile.!ret
	type IsVisibleTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isAutotile.!0
	type IsAutotile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isAutotile.!ret
	type IsAutotileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.getAutotileKind.!0
	type GetAutotileKind0 = number;
}
declare namespace Tilemap{
	// Tilemap.getAutotileKind.!ret
	type GetAutotileKindRet = number;
}
declare namespace Tilemap{
	// Tilemap.getAutotileShape.!0
	type GetAutotileShape0 = number;
}
declare namespace Tilemap{
	// Tilemap.getAutotileShape.!ret
	type GetAutotileShapeRet = number;
}
declare namespace Tilemap{
	// Tilemap.makeAutotileId.!1
	type MakeAutotileId1 = number;
}
declare namespace Tilemap{
	// Tilemap.isSameKindTile.!0
	type IsSameKindTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isSameKindTile.!1
	type IsSameKindTile1 = number;
}
declare namespace Tilemap{
	// Tilemap.isSameKindTile.!ret
	type IsSameKindTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isTileA1.!0
	type IsTileA10 = number;
}
declare namespace Tilemap{
	// Tilemap.isTileA1.!ret
	type IsTileA1Ret = boolean;
}
declare namespace Tilemap{
	// Tilemap.isTileA2.!0
	type IsTileA20 = number;
}
declare namespace Tilemap{
	// Tilemap.isTileA2.!ret
	type IsTileA2Ret = boolean;
}
declare namespace Tilemap{
	// Tilemap.isTileA3.!0
	type IsTileA30 = number;
}
declare namespace Tilemap{
	// Tilemap.isTileA3.!ret
	type IsTileA3Ret = boolean;
}
declare namespace Tilemap{
	// Tilemap.isTileA4.!0
	type IsTileA40 = number;
}
declare namespace Tilemap{
	// Tilemap.isTileA4.!ret
	type IsTileA4Ret = boolean;
}
declare namespace Tilemap{
	// Tilemap.isTileA5.!0
	type IsTileA50 = number;
}
declare namespace Tilemap{
	// Tilemap.isTileA5.!ret
	type IsTileA5Ret = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWaterTile.!0
	type IsWaterTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isWaterTile.!ret
	type IsWaterTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWaterfallTile.!0
	type IsWaterfallTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isWaterfallTile.!ret
	type IsWaterfallTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isGroundTile.!0
	type IsGroundTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isGroundTile.!ret
	type IsGroundTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isShadowingTile.!0
	type IsShadowingTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isShadowingTile.!ret
	type IsShadowingTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isRoofTile.!0
	type IsRoofTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isRoofTile.!ret
	type IsRoofTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWallTopTile.!0
	type IsWallTopTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isWallTopTile.!ret
	type IsWallTopTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWallSideTile.!0
	type IsWallSideTile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isWallSideTile.!ret
	type IsWallSideTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWallTile.!ret
	type IsWallTileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isFloorTypeAutotile.!0
	type IsFloorTypeAutotile0 = number;
}
declare namespace Tilemap{
	// Tilemap.isFloorTypeAutotile.!ret
	type IsFloorTypeAutotileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWallTypeAutotile.!ret
	type IsWallTypeAutotileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.isWaterfallTypeAutotile.!ret
	type IsWaterfallTypeAutotileRet = boolean;
}
declare namespace Tilemap{
	// Tilemap.FLOOR_AUTOTILE_TABLE.<i>
	type FLOOR_AUTOTILE_TABLEI = Array<Array</* number],[number],[number],[number */ any>>;
}
declare namespace Tilemap{
	// Tilemap.WALL_AUTOTILE_TABLE.<i>
	type WALL_AUTOTILE_TABLEI = Array<Array</* number],[number],[number],[number */ any>>;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.initialize.!0
	type Initialize0 = string;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.isReady.!ret
	type IsReadyRet = boolean;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.isError.!ret
	type IsErrorRet = boolean;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.isPlaying.!ret
	type IsPlayingRet = boolean;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.play.!0
	type Play0 = boolean;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.play.!1
	type Play1 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.fadeIn.!0
	type FadeIn0 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.fadeOut.!0
	type FadeOut0 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype.seek.!ret
	type SeekRet = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._load.!0
	type _load0 = string;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._onXhrLoad.!0
	
	/**
	 * 
	 */
	interface _onXhrLoad0 {
				
		/**
		 * 
		 */
		responseType : string;
				
		/**
		 * 
		 */
		onload(): void;
				
		/**
		 * 
		 */
		onerror(): void;
	}
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._startPlaying.!0
	type _startPlaying0 = boolean;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._startPlaying.!1
	type _startPlaying1 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readMetaData.!1
	type _readMetaData1 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readMetaData.!2
	type _readMetaData2 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readLittleEndian.!1
	type _readLittleEndian1 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readLittleEndian.!ret
	type _readLittleEndianRet = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readBigEndian.!1
	type _readBigEndian1 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readBigEndian.!ret
	type _readBigEndianRet = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readFourCharacters.!1
	type _readFourCharacters1 = number;
}
declare namespace WebAudio.prototype{
	// WebAudio.prototype._readFourCharacters.!ret
	type _readFourCharactersRet = string;
}
declare namespace WebAudio{
	// WebAudio.initialize.!0
	type Initialize0 = boolean;
}
declare namespace WebAudio{
	// WebAudio.initialize.!ret
	type InitializeRet = boolean;
}
declare namespace WebAudio{
	// WebAudio.canPlayOgg.!ret
	type CanPlayOggRet = boolean;
}
declare namespace WebAudio{
	// WebAudio.canPlayM4a.!ret
	type CanPlayM4aRet = boolean;
}
declare namespace WebAudio{
	// WebAudio.setMasterVolume.!0
	type SetMasterVolume0 = number;
}
declare namespace WebAudio{
	// WebAudio._shouldMuteOnHide.!ret
	type _shouldMuteOnHideRet = boolean;
}
declare namespace WebAudio{
	// WebAudio._fadeIn.!0
	type _fadeIn0 = number;
}
declare namespace WebAudio{
	// WebAudio._fadeOut.!0
	type _fadeOut0 = number;
}
declare namespace Html5Audio{
	// Html5Audio.setup.!0
	type Setup0 = string;
}
declare namespace Html5Audio{
	// Html5Audio.initialize.!ret
	type InitializeRet = boolean;
}
declare namespace Html5Audio{
	// Html5Audio.setStaticSe.!0
	type SetStaticSe0 = string;
}
declare namespace Html5Audio{
	// Html5Audio.isReady.!ret
	type IsReadyRet = boolean;
}
declare namespace Html5Audio{
	// Html5Audio.isError.!ret
	type IsErrorRet = boolean;
}
declare namespace Html5Audio{
	// Html5Audio.isPlaying.!ret
	type IsPlayingRet = boolean;
}
declare namespace Html5Audio{
	// Html5Audio.play.!0
	type Play0 = boolean;
}
declare namespace Html5Audio{
	// Html5Audio.play.!1
	type Play1 = number;
}
declare namespace Html5Audio{
	// Html5Audio.fadeIn.!0
	type FadeIn0 = number;
}
declare namespace Html5Audio{
	// Html5Audio.fadeOut.!0
	type FadeOut0 = number;
}
declare namespace Html5Audio{
	// Html5Audio.seek.!ret
	type SeekRet = number;
}
declare namespace Html5Audio{
	// Html5Audio._load.!0
	type _load0 = string;
}
declare namespace Html5Audio{
	// Html5Audio._startPlaying.!0
	type _startPlaying0 = boolean;
}
declare namespace Html5Audio{
	// Html5Audio._startPlaying.!1
	type _startPlaying1 = number;
}
declare namespace Html5Audio{
	// Html5Audio._startGainTween.!0
	type _startGainTween0 = number;
}
declare namespace Html5Audio{
	// Html5Audio._applyTweenValue.!0
	type _applyTweenValue0 = number;
}
declare namespace JsonEx{
	// JsonEx._generateId.!ret
	type _generateIdRet = number;
}
declare namespace JsonEx{
	// JsonEx.stringify.!0
	
	/**
	 * 
	 */
	interface Stringify0 {
				
		/**
		 * 
		 */
		c : number;
				
		/**
		 * 
		 */
		str : string;
	}
}
declare namespace JsonEx{
	// JsonEx.stringify.!ret
	type StringifyRet = string;
}
declare namespace JsonEx{
	// JsonEx._restoreCircularReference.!0
	type _restoreCircularReference0 = Array</* JsonEx._restoreCircularReference._restoreCircularReference0I */ any>;
}
declare namespace JsonEx._restoreCircularReference{
	// JsonEx._restoreCircularReference.!0.<i>
	type _restoreCircularReference0I = Array</* ?,?,? */ any>;
}
declare namespace JsonEx{
	// JsonEx.parse.!0
	type Parse0 = string;
}
declare namespace JsonEx{
	// JsonEx._linkCircularReference.!0
	
	/**
	 * 
	 */
	interface _linkCircularReference0 {
	}
}
declare namespace JsonEx{
	// JsonEx._linkCircularReference.!1
	type _linkCircularReference1 = Array</* JsonEx._linkCircularReference._linkCircularReference1I */ any>;
}
declare namespace JsonEx._linkCircularReference{
	// JsonEx._linkCircularReference.!1.<i>
	type _linkCircularReference1I = Array</* ?,?,? */ any>;
}
declare namespace JsonEx{
	// JsonEx._linkCircularReference.!2
	
	/**
	 * 
	 */
	interface _linkCircularReference2 {
	}
}
declare namespace JsonEx{
	// JsonEx._encode.!2
	type _encode2 = number;
}
declare namespace JsonEx{
	// JsonEx._encode.!ret
	
	/**
	 * 
	 */
	interface _encodeRet {
				
		/**
		 * 
		 */
		c : number;
	}
}
declare namespace JsonEx{
	// JsonEx._getConstructorName.!ret
	type _getConstructorNameRet = string;
}
declare namespace Decrypter{
	// Decrypter._ignoreList.<i>
	type _ignoreListI = string;
}
declare namespace Decrypter{
	// Decrypter.checkImgIgnore.!0
	type CheckImgIgnore0 = string;
}
declare namespace Decrypter{
	// Decrypter.checkImgIgnore.!ret
	type CheckImgIgnoreRet = boolean;
}
declare namespace Decrypter{
	// Decrypter.decryptImg.!0
	type DecryptImg0 = string;
}
declare namespace Decrypter{
	// Decrypter.cutArrayHeader.!1
	type CutArrayHeader1 = number;
}
declare namespace Decrypter{
	// Decrypter.decryptArrayBuffer.!0
	type DecryptArrayBuffer0 = number;
}
declare namespace Decrypter{
	// Decrypter.extToEncryptExt.!0
	type ExtToEncryptExt0 = string;
}
declare namespace Decrypter{
	// Decrypter.extToEncryptExt.!ret
	type ExtToEncryptExtRet = string;
}
declare namespace ResourceHandler{
	// ResourceHandler._reloaders.<i>
	type _reloadersI = (() => void);
}
declare namespace ResourceHandler{
	// ResourceHandler._defaultRetryInterval.<i>
	type _defaultRetryIntervalI = number;
}
declare namespace ResourceHandler{
	// ResourceHandler.createLoader.!0
	type CreateLoader0 = string;
}
declare namespace ResourceHandler{
	// ResourceHandler.createLoader.!1
	type CreateLoader1 = (() => void);
}
declare namespace ResourceHandler{
	// ResourceHandler.createLoader.!2
	type CreateLoader2 = (() => void);
}
declare namespace ResourceHandler{
	// ResourceHandler.exists.!ret
	type ExistsRet = boolean;
}

/**
 * This is not a class, but contains some methods that will be added to the
 * standard Javascript objects.
 * 
 * @class JsExtensions
 */
declare interface JsExtensions {
		
	/**
	 * 
	 * @return  
	 */
	new (): JsExtensions;
}


/**
 * The static class that defines utility methods.
 * 
 * @class Utils
 */
declare interface Utils {
		
	/**
	 * 
	 * @return  
	 */
	new (): Utils;
}


/**
 * 
 */
declare namespace Utils{
		
	/**
	 * The name of the RPG Maker. 'MV' in the current version.
	 * 
	 * @static
	 * @property RPGMAKER_NAME
	 * @type String
	 * @final
	 */
	export var RPGMAKER_NAME : string;
		
	/**
	 * The version of the RPG Maker.
	 * 
	 * @static
	 * @property RPGMAKER_VERSION
	 * @type String
	 * @final
	 */
	export var RPGMAKER_VERSION : string;
		
	/**
	 * Checks whether the option is in the query string.
	 * 
	 * @static
	 * @method isOptionValid
	 * @param {String} name The option name
	 * @return {Boolean} True if the option is in the query string
	 * @param name 
	 * @return  
	 */
	function isOptionValid(name : Utils.IsOptionValid0): Utils.IsOptionValidRet;
		
	/**
	 * Checks whether the platform is NW.js.
	 * 
	 * @static
	 * @method isNwjs
	 * @return {Boolean} True if the platform is NW.js
	 * @return  
	 */
	function isNwjs(): Utils.IsNwjsRet;
		
	/**
	 * Checks whether the platform is a mobile device.
	 * 
	 * @static
	 * @method isMobileDevice
	 * @return {Boolean} True if the platform is a mobile device
	 * @return  
	 */
	function isMobileDevice(): Utils.IsMobileDeviceRet;
		
	/**
	 * Checks whether the browser is Mobile Safari.
	 * 
	 * @static
	 * @method isMobileSafari
	 * @return {Boolean} True if the browser is Mobile Safari
	 * @return  
	 */
	function isMobileSafari(): Utils.IsMobileSafariRet;
		
	/**
	 * Checks whether the browser is Android Chrome.
	 * 
	 * @static
	 * @method isAndroidChrome
	 * @return {Boolean} True if the browser is Android Chrome
	 * @return  
	 */
	function isAndroidChrome(): Utils.IsAndroidChromeRet;
		
	/**
	 * Checks whether the browser can read files in the game folder.
	 * 
	 * @static
	 * @method canReadGameFiles
	 * @return {Boolean} True if the browser can read files in the game folder
	 * @return  
	 */
	function canReadGameFiles(): Utils.CanReadGameFilesRet;
		
	/**
	 * Makes a CSS color string from RGB values.
	 * 
	 * @static
	 * @method rgbToCssColor
	 * @param {Number} r The red value in the range (0, 255)
	 * @param {Number} g The green value in the range (0, 255)
	 * @param {Number} b The blue value in the range (0, 255)
	 * @return {String} CSS color string
	 * @param r 
	 * @param g 
	 * @param b 
	 * @return  
	 */
	function rgbToCssColor(r : Utils.RgbToCssColor0, g : Utils.RgbToCssColor1, b : Utils.RgbToCssColor2): Utils.RgbToCssColorRet;
		
	/**
	 * 
	 */
	export var _id : number;
		
	/**
	 * 
	 * @return  
	 */
	function generateRuntimeId(): Utils.GenerateRuntimeIdRet;
		
	/**
	 * 
	 */
	export var _supportPassiveEvent : boolean;
		
	/**
	 * Test this browser support passive event feature
	 * 
	 * @static
	 * @method isSupportPassiveEvent
	 * @return {Boolean} this browser support passive event or not
	 * @return  
	 */
	function isSupportPassiveEvent(): Utils.IsSupportPassiveEventRet;
}

/**
 * The resource class. Allows to be collected as a garbage if not use for some time or ticks
 * 
 * @class CacheEntry
 * @constructor
 * @param {ResourceManager} resource manager
 * @param {string} key, url of the resource
 * @param {string} item - Bitmap, HTML5Audio, WebAudio - whatever you want to store in the cache
 */
declare interface CacheEntry {
		
	/**
	 * 
	 * @param cache 
	 * @param key 
	 * @param item 
	 */
	new (cache : CacheMap, key : any, item : string);
		
	/**
	 * frees the resource
	 * @param byTTL 
	 */
	free(byTTL : CacheEntry.prototype.Free0): void;
		
	/**
	 * Allocates the resource
	 * @returns {CacheEntry}
	 * @return  
	 */
	allocate(): /* !this */ any;
		
	/**
	 * Sets the time to live
	 * @param {number} ticks TTL in ticks, 0 if not set
	 * @param {number} time TTL in seconds, 0 if not set
	 * @returns {CacheEntry}
	 * @param ticks 
	 * @param seconds 
	 * @return  
	 */
	setTimeToLive(ticks : CacheEntry.prototype.SetTimeToLive0, seconds : CacheEntry.prototype.SetTimeToLive1): /* !this */ any;
		
	/**
	 * 
	 * @return  
	 */
	isStillAlive(): CacheEntry.prototype.IsStillAliveRet;
		
	/**
	 * makes sure that resource wont freed by Time To Live
	 * if resource was already freed by TTL, put it in cache again
	 */
	touch(): void;
		
	/**
	 * 
	 */
	cache : CacheMap;
		
	/**
	 * 
	 */
	item : string;
		
	/**
	 * 
	 */
	cached : boolean;
		
	/**
	 * 
	 */
	touchTicks : number;
		
	/**
	 * 
	 */
	touchSeconds : number;
		
	/**
	 * 
	 */
	ttlTicks : number;
		
	/**
	 * 
	 */
	ttlSeconds : number;
		
	/**
	 * 
	 */
	freedByTTL : boolean;
}

/**
 * Cache for images, audio, or any other kind of resource
 * @param manager
 * @constructor
 */
declare interface CacheMap {
		
	/**
	 * 
	 * @param manager 
	 */
	new (manager : any);
		
	/**
	 * checks ttl of all elements and removes dead ones
	 */
	checkTTL(): void;
		
	/**
	 * cache item
	 * @param key url of cache element
	 * @returns {*|null}
	 * @param key 
	 * @return  
	 */
	getItem(key : any): CacheMap.prototype.GetItemRet;
		
	/**
	 * 
	 */
	clear(): void;
		
	/**
	 * 
	 * @param key 
	 * @param item 
	 * @return  
	 */
	setItem(key : any, item : CacheMap.prototype.SetItem1): CacheEntry;
		
	/**
	 * Updates the weather for each frame.
	 * 
	 * @method update
	 * @param ticks 
	 * @param delta 
	 */
	update(ticks : CacheMap.prototype.Update0, delta : CacheMap.prototype.Update1): void;
	
	/**
	 * 
	 */
	_inner : {
	}
		
	/**
	 * 
	 */
	updateTicks : number;
		
	/**
	 * 
	 */
	lastCheckTTL : number;
		
	/**
	 * 
	 */
	delayCheckTTL : number;
		
	/**
	 * 
	 */
	updateSeconds : number;
}

/**
 * 
 */
declare interface ImageCache {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @param key 
	 * @param value 
	 */
	add(key : any, value : any): void;
		
	/**
	 * 
	 * @param key 
	 */
	get(key : any): void;
		
	/**
	 * 
	 * @param key 
	 * @param value 
	 * @param reservationId 
	 */
	reserve(key : any, value : any, reservationId : any): void;
		
	/**
	 * 
	 * @param reservationId 
	 */
	releaseReservation(reservationId : any): void;
		
	/**
	 * 
	 */
	_truncateCache(): void;
		
	/**
	 * 
	 * @param item 
	 * @return  
	 */
	_mustBeHeld(item : /* ImageCache.prototype._mustBeHeld0 */ any): /* ImageCache.prototype._mustBeHeldRet */ any;
		
	/**
	 * Checks whether the tileset is ready to render.
	 * 
	 * @method isReady
	 * @type Boolean
	 * @return {Boolean} True if the tilemap is ready
	 * @return  
	 */
	isReady(): ImageCache.prototype.IsReadyRet;
		
	/**
	 * 
	 */
	getErrorBitmap(): void;
		
	/**
	 * 
	 */
	limit : number;
}

/**
 * 
 */
declare interface RequestQueue {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 */
	initialize(): void;
		
	/**
	 * 
	 * @param key 
	 * @param value 
	 */
	enqueue(key : any, value : any): void;
		
	/**
	 * 
	 */
	update(): void;
		
	/**
	 * 
	 * @param key 
	 */
	raisePriority(key : any): void;
		
	/**
	 * 
	 */
	clear(): void;
}

/**
 * The point class.
 * 
 * @class Point
 * @constructor
 * @param {Number} x The x coordinate
 * @param {Number} y The y coordinate
 */
declare interface Point {
		
	/**
	 * 
	 * @return  
	 */
	new (): Point;
}


/**
 * The rectangle class.
 * 
 * @class Rectangle
 * @constructor
 * @param {Number} x The x coordinate for the upper-left corner
 * @param {Number} y The y coordinate for the upper-left corner
 * @param {Number} width The width of the rectangle
 * @param {Number} height The height of the rectangle
 */
declare interface Rectangle {
		
	/**
	 * 
	 * @return  
	 */
	new (): Rectangle;
}


/**
 * The basic object that represents an image.
 * 
 * @class Bitmap
 * @constructor
 * @param {Number} width The width of the bitmap
 * @param {Number} height The height of the bitmap
 */
declare interface Bitmap {
		
	/**
	 * 
	 */
	new ();
		
	/**
	 * 
	 * @param width 
	 * @param height 
	 */
	_createCanvas(width : /* Bitmap.prototype._createCanvas0 */ any, height : /* Bitmap.prototype._createCanvas1 */ any): void;
		
	/**
	 * 
	 * @param source 
	 */
	_createBaseTexture(source : any): void;
		
	/**
	 * 
	 */
	_clearImgInstance(): void;
		
	/**
	 * 
	 */
	_renewCanvas(): void;
		
	/**
	 * 
	 * @param width 
	 * @param height 
	 */
	initialize(width : Bitmap.prototype.Initialize0, height : Bitmap.prototype.Initialize1): void;
		
	/**
	 * Checks whether the bitmap is ready to render.
	 * 
	 * @method isReady
	 * @return {Boolean} True if the bitmap is ready to render
	 * @return  
	 */
	isReady(): Bitmap.prototype.IsReadyRet;
		
	/**
	 * Checks whether a loading error has occurred.
	 * 
	 * @method isError
	 * @return {Boolean} True if a loading error has occurred
	 * @return  
	 */
	isError(): Bitmap.prototype.IsErrorRet;
		
	/**
	 * touch the resource
	 * @method touch
	 */
	touch(): void;
		
	/**
	 * Resizes the bitmap.
	 * 
	 * @method resize
	 * @param {Number} width The new width of the bitmap
	 * @param {Number} height The new height of the bitmap
	 * @param width 
	 * @param height 
	 */
	resize(width : Bitmap.prototype.Resize0, height : Bitmap.prototype.Resize1): void;
		
	/**
	 * Performs a block transfer.
	 * 
	 * @method blt
	 * @param {Bitmap} source The bitmap to draw
	 * @param {Number} sx The x coordinate in the source
	 * @param {Number} sy The y coordinate in the source
	 * @param {Number} sw The width of the source image
	 * @param {Number} sh The height of the source image
	 * @param {Number} dx The x coordinate in the destination
	 * @param {Number} dy The y coordinate in the destination
	 * @param {Number} [dw=sw] The width to draw the image in the destination
	 * @param {Number} [dh=sh] The height to draw the image in the destination
	 * @param source 
	 * @param sx 
	 * @param sy 
	 * @param sw 
	 * @param sh 
	 * @param dx 
	 * @param dy 
	 * @param dw? 
	 * @param dh? 
	 */
	blt(source : Bitmap, sx : Bitmap.prototype.Blt1, sy : Bitmap.prototype.Blt2, sw : Bitmap.prototype.Blt3, sh : Bitmap.prototype.Blt4, dx : Bitmap.prototype.Blt5, dy : Bitmap.prototype.Blt6, dw? : Bitmap.prototype.Blt7, dh? : Bitmap.prototype.Blt8): void;
		
	/**
	 * Performs a block transfer, using assumption that original image was not modified (no hue)
	 * 
	 * @method blt
	 * @param {Bitmap} source The bitmap to draw
	 * @param {Number} sx The x coordinate in the source
	 * @param {Number} sy The y coordinate in the source
	 * @param {Number} sw The width of the source image
	 * @param {Number} sh The height of the source image
	 * @param {Number} dx The x coordinate in the destination
	 * @param {Number} dy The y coordinate in the destination
	 * @param {Number} [dw=sw] The width to draw the image in the destination
	 * @param {Number} [dh=sh] The height to draw the image in the destination
	 * @param source 
	 * @param sx 
	 * @param sy 
	 * @param sw 
	 * @param sh 
	 * @param dx 
	 * @param dy 
	 * @param dw? 
	 * @param dh? 
	 */
	bltImage(source : Bitmap, sx : Bitmap.prototype.BltImage1, sy : Bitmap.prototype.BltImage2, sw : Bitmap.prototype.BltImage3, sh : Bitmap.prototype.BltImage4, dx : Bitmap.prototype.BltImage5, dy : Bitmap.prototype.BltImage6, dw? : Bitmap.prototype.BltImage7, dh? : Bitmap.prototype.BltImage8): void;
		
	/**
	 * Returns pixel color at the specified point.
	 * 
	 * @method getPixel
	 * @param {Number} x The x coordinate of the pixel in the bitmap
	 * @param {Number} y The y coordinate of the pixel in the bitmap
	 * @return {String} The pixel color (hex format)
	 * @param x 
	 * @param y 
	 * @return  
	 */
	getPixel(x : Bitmap.prototype.GetPixel0, y : Bitmap.prototype.GetPixel1): Bitmap.prototype.GetPixelRet;
		
	/**
	 * Returns alpha pixel value at the specified point.
	 * 
	 * @method getAlphaPixel
	 * @param {Number} x The x coordinate of the pixel in the bitmap
	 * @param {Number} y The y coordinate of the pixel in the bitmap
	 * @return {String} The alpha value
	 * @param x 
	 * @param y 
	 * @return  
	 */
	getAlphaPixel(x : Bitmap.prototype.GetAlphaPixel0, y : Bitmap.prototype.GetAlphaPixel1): Bitmap.prototype.GetAlphaPixelRet;
		
	/**
	 * Clears the specified rectangle.
	 * 
	 * @method clearRect
	 * @param {Number} x The x coordinate for the upper-left corner
	 * @param {Number} y The y coordinate for the upper-left corner
	 * @param {Number} width The width of the rectangle to clear
	 * @param {Number} height The height of the rectangle to clear
	 * @param x 
	 * @param y 
	 * @param width 
	 * @param height 
	 */
	clearRect(x : Bitmap.prototype.ClearRect0, y : Bitmap.prototype.ClearRect1, width : Bitmap.prototype.ClearRect2, height : Bitmap.prototype.ClearRect3): void;
		
	/**
	 * Clears the entire bitmap.
	 * 
	 * @method clear
	 */
	clear(): void;
		
	/**
	 * Fills the specified rectangle.
	 * 
	 * @method fillRect
	 * @param {Number} x The x coordinate for the upper-left corner
	 * @param {Number} y The y coordinate for the upper-left corner
	 * @param {Number} width The width of the rectangle to fill
	 * @param {Number} height The height of the rectangle to fill
	 * @param {String} color The color of the rectangle in CSS format
	 * @param x 
	 * @param y 
	 * @param width 
	 * @param height 
	 * @param color 
	 */
	fillRect(x : Bitmap.prototype.FillRect0, y : Bitmap.prototype.FillRect1, width : Bitmap.prototype.FillRect2, height : Bitmap.prototype.FillRect3, color : Bitmap.prototype.FillRect4): void;
		
	/**
	 * Fills the entire bitmap.
	 * 
	 * @method fillAll
	 * @param {String} color The color of the rectangle in CSS format
	 * @param color 
	 */
	fillAll(color : Bitmap.prototype.FillAll0): void;
		
	/**
	 * Draws the rectangle with a gradation.
	 * 
	 * @method gradientFillRect
	 * @param {Number} x The x coordinate for the upper-left corner
	 * @param {Number} y The y coordinate for the upper-left corner
	 * @param {Number} width The width of the rectangle to fill
	 * @param {Number} height The height of the rectangle to fill
	 * @param {String} color1 The gradient starting color
	 * @param {String} color2 The gradient ending color
	 * @param {Boolean} vertical Wether the gradient should be draw as vertical or not
	 * @param x 
	 * @param y 
	 * @param width 
	 * @param height 
	 * @param color1 
	 * @param color2 
	 * @param vertical 
	 */
	gradientFillRect(x : Bitmap.prototype.GradientFillRect0, y : Bitmap.prototype.GradientFillRect1, width : Bitmap.prototype.GradientFillRect2, height : Bitmap.prototype.GradientFillRect3, color1 : Bitmap.prototype.GradientFillRect4, color2 : Bitmap.prototype.GradientFillRect5, vertical : Bitmap.prototype.GradientFillRect6): void;
		
	/**
	 * Draw a bitmap in the shape of a circle
	 * 
	 * @method drawCircle
	 * @param {Number} x The x coordinate based on the circle center
	 * @param {Number} y The y coordinate based on the circle center
	 * @param {Number} radius The radius of the circle
	 * @param {String} color The color of the circle in CSS format
	 * @param x 
	 * @param y 
	 * @param radius 
	 * @param color 
	 */
	drawCircle(x : Bitmap.prototype.DrawCircle0, y : Bitmap.prototype.DrawCircle1, radius : Bitmap.prototype.DrawCircle2, color : Bitmap.prototype.DrawCircle3): void;
		
	/**
	 * Draws the outline text to the bitmap.
	 * 
	 * @method drawText
	 * @param {String} text The text that will be drawn
	 * @param {Number} x The x coordinate for the left of the text
	 * @param {Number} y The y coordinate for the top of the text
	 * @param {Number} maxWidth The maximum allowed width of the text
	 * @param {Number} lineHeight The height of the text line
	 * @param {String} align The alignment of the text
	 * @param text 
	 * @param x 
	 * @param y 
	 * @param maxWidth 
	 * @param lineHeight 
	 * @param align 
	 */
	drawText(text : Bitmap.prototype.DrawText0, x : Bitmap.prototype.DrawText1, y : Bitmap.prototype.DrawText2, maxWidth : Bitmap.prototype.DrawText3, lineHeight : Bitmap.prototype.DrawText4, align : Bitmap.prototype.DrawText5): void;
		
	/**
	 * Returns the width of the specified text.
	 * 
	 * @method measureTextWidth
	 * @param {String} text The text to be measured
	 * @return {Number} The width of the text in pixels
	 * @param text 
	 * @return  
	 */
	measureTextWidth(text : Bitmap.prototype.MeasureTextWidth0): Bitmap.prototype.MeasureTextWidthRet;
		
	/**
	 * Changes the tone.
	 * 
	 * @method adjustTone
	 * @param {Number} r The red strength in the range (-255, 255)
	 * @param {Number} g The green strength in the range (-255, 255)
	 * @param {Number} b The blue strength in the range (-255, 255)
	 * @param r 
	 * @param g 
	 * @param b 
	 */
	adjustTone(r : Bitmap.prototype.AdjustTone0, g : Bitmap.prototype.AdjustTone1, b : Bitmap.prototype.AdjustTone2): void;
		
	/**
	 * Rotates the hue of the entire bitmap.
	 * 
	 * @method rotateHue
	 * @param {Number} offset The hue offset in 360 degrees
	 * @param offset 
	 */
	rotateHue(offset : Bitmap.prototype.RotateHue0): void;
		
	/**
	 * Applies a blur effect to the bitmap.
	 * 
	 * @method blur
	 */
	blur(): void;
		
	/**
	 * Add a callback function that will be called when the bitmap is loaded.
	 * 
	 * @method addLoadListener
	 * @param {Function} listner The callback function
	 * @param listner 
	 */
	addLoadListener(listner : Function): void;
		
	/**
	 * @method _makeFontNameText
	 * @private
	 * @return  
	 */
	_makeFontNameText(): /* Bitmap.prototype._makeFontNameTextRet */ any;
		
	/**
	 * @method _drawTextOutline
	 * @param {String} text
	 * @param {Number} tx
	 * @param {Number} ty
	 * @param {Number} maxWidth
	 * @private
	 * @param text 
	 * @param tx 
	 * @param ty 
	 * @param maxWidth 
	 */
	_drawTextOutline(text : /* Bitmap.prototype._drawTextOutline0 */ any, tx : /* Bitmap.prototype._drawTextOutline1 */ any, ty : /* Bitmap.prototype._drawTextOutline2 */ any, maxWidth : /* Bitmap.prototype._drawTextOutline3 */ any): void;
		
	/**
	 * @method _drawTextBody
	 * @param {String} text
	 * @param {Number} tx
	 * @param {Number} ty
	 * @param {Number} maxWidth
	 * @private
	 * @param text 
	 * @param tx 
	 * @param ty 
	 * @param maxWidth 
	 */
	_drawTextBody(text : /* Bitmap.prototype._drawTextBody0 */ any, tx : /* Bitmap.prototype._drawTextBody1 */ any, ty : /* Bitmap.prototype._drawTextBody2 */ any, maxWidth : /* Bitmap.prototype._drawTextBody3 */ any): void;
		
	/**
	 * @method _onLoad
	 * @private
	 */
	_onLoad(): void;
		
	/**
	 * 
	 */
	decode(): void;
		
	/**
	 * @method _callLoadListeners
	 * @private
	 */
	_callLoadListeners(): void;
		
	/**
	 * @method _onError
	 * @private
	 */
	_onError(): void;
		
	/**
	 * @method _setDirty
	 * @private
	 */
	_setDirty(): void;
		
	/**
	 * updates texture is bitmap was dirty
	 * @method checkDirty
	 */
	checkDirty(): void;
		
	/**
	 * 
	 * @param url 
	 */
	_requestImage(url : /* Bitmap.prototype._requestImage0 */ any): void;
		
	/**
	 * 
	 * @return  
	 */
	isRequestOnly(): Bitmap.prototype.IsRequestOnlyRet;
		
	/**
	 * 
	 * @return  
	 */
	isRequestReady(): Bitmap.prototype.IsRequestReadyRet;
		
	/**
	 * 
	 */
	startRequest(): void;
		
	/**
	 * for iOS. img consumes memory. so reuse it.
	 */
	_reuseImages : Array<any>;
		
	/**
	 * Loads a image file and returns a new bitmap object.
	 * 
	 * @static
	 * @method load
	 * @param {String} url The image url of the texture
	 * @return Bitmap
	 * @param url 
	 * @return  
	 */
	load(url : Bitmap.Load0): /* Bitmap.+Bitmap */ any;
		
	/**
	 * Takes a snapshot of the game screen and returns a new bitmap object.
	 * 
	 * @static
	 * @method snap
	 * @param {Stage} stage The stage object
	 * @return Bitmap
	 * @param stage 
	 * @return  
	 */
	snap(stage : () => void): /* Bitmap.+Bitmap */ any;
		
	/**
	 * 
	 * @param url 
	 * @return  
	 */
	request(url : Bitmap.Request0): /* Bitmap.+Bitmap */ any;
		
	/**
	 * 
	 */
	_errorListener(): void;
		
	/**
	 * 
	 */
	_loadListener(): void;
		
	/**
	 * 
	 */
	_url : string;
		
	/**
	 * 
	 */
	_paintOpacity : number;
		
	/**
	 * 
	 */
	_smooth : boolean;
		
	/**
	 * 
	 */
	_loadListeners : Array<any>;
		
	/**
	 * 
	 */
	_loadingState : string;
		
	/**
	 * 
	 */
	_decodeAfterRequest : boolean;
		
	/**
	 * The face name of the font.
	 * 
	 * @property fontFace
	 * @type String
	 */
	fontFace : string;
		
	/**
	 * The size of the font in pixels.
	 * 
	 * @property fontSize
	 * @type Number
	 */
	fontSize : number;
		
	/**
	 * Whether the font is italic.
	 * 
	 * @property fontItalic
	 * @type Boolean
	 */
	fontItalic : boolean;
		
	/**
	 * The color of the text in CSS format.
	 * 
	 * @property textColor
	 * @type String
	 */
	textColor : string;
		
	/**
	 * The color of the outline of the text in CSS format.
	 * 
	 * @property outlineColor
	 * @type String
	 */
	outlineColor : string;
		
	/**
	 * The width of the outline of the text.
	 * 
	 * @property outlineWidth
	 * @type Number
	 */
	outlineWidth : number;
		
	/**
	 * 
	 */
	_dirty : boolean;
		
	/**
	 * 
	 */
	_defer : boolean;
}

/**
 * The static class that carries out graphics processing.
 * 
 * @class Graphics
 */
declare interface Graphics {
		
	/**
	 * 
	 * @return  
	 */
	new (): Graphics;
}


/**
 * 
 */
declare namespace Graphics{
		
	/**
	 * 
	 */
	export var _videoVolume : number;
		
	/**
	 * Initializes the graphics system.
	 * 
	 * @static
	 * @method initialize
	 * @param {Number} width The width of the game screen
	 * @param {Number} height The height of the game screen
	 * @param {String} type The type of the renderer.
	 *                 'canvas', 'webgl', or 'auto'.
	 * @param width 
	 * @param height 
	 * @param type 
	 */
	function initialize(width : Graphics.Initialize0, height : Graphics.Initialize1, type : Graphics.Initialize2): void;
		
	/**
	 * 
	 */
	export var _width : number;
		
	/**
	 * 
	 */
	export var _height : number;
		
	/**
	 * 
	 */
	export var _rendererType : string;
		
	/**
	 * 
	 */
	export var _boxWidth : number;
		
	/**
	 * 
	 */
	export var _boxHeight : number;
		
	/**
	 * 
	 */
	export var _scale : number;
		
	/**
	 * 
	 */
	export var _realScale : number;
		
	/**
	 * 
	 */
	export var _errorShowed : boolean;
		
	/**
	 * 
	 */
	export var _videoUnlocked : boolean;
		
	/**
	 * 
	 */
	export var _videoLoading : boolean;
	
	/**
	 * 
	 */
	var _modeBox : {
				
		/**
		 * 
		 */
		id : string;
	}
		
	/**
	 * 
	 */
	export var _skipCount : number;
		
	/**
	 * 
	 */
	export var _maxSkip : number;
		
	/**
	 * 
	 */
	export var _rendered : boolean;
		
	/**
	 * 
	 */
	export var _loadingCount : number;
		
	/**
	 * 
	 */
	export var _fpsMeterToggled : boolean;
		
	/**
	 * 
	 */
	export var _stretchEnabled : boolean;
		
	/**
	 * 
	 */
	export var _canUseDifferenceBlend : boolean;
		
	/**
	 * 
	 */
	export var _canUseSaturationBlend : boolean;
		
	/**
	 * 
	 */
	function _setupCssFontLoading(): void;
		
	/**
	 * 
	 * @return  
	 */
	function canUseCssFontLoading(): Graphics.CanUseCssFontLoadingRet;
		
	/**
	 * The total frame count of the game screen.
	 * 
	 * @static
	 * @property frameCount
	 * @type Number
	 */
	export var frameCount : number;
		
	/**
	 * The alias of PIXI.blendModes.NORMAL.
	 * 
	 * @static
	 * @property BLEND_NORMAL
	 * @type Number
	 * @final
	 */
	export var BLEND_NORMAL : number;
		
	/**
	 * The alias of PIXI.blendModes.ADD.
	 * 
	 * @static
	 * @property BLEND_ADD
	 * @type Number
	 * @final
	 */
	export var BLEND_ADD : number;
		
	/**
	 * The alias of PIXI.blendModes.MULTIPLY.
	 * 
	 * @static
	 * @property BLEND_MULTIPLY
	 * @type Number
	 * @final
	 */
	export var BLEND_MULTIPLY : number;
		
	/**
	 * The alias of PIXI.blendModes.SCREEN.
	 * 
	 * @static
	 * @property BLEND_SCREEN
	 * @type Number
	 * @final
	 */
	export var BLEND_SCREEN : number;
		
	/**
	 * Marks the beginning of each frame for FPSMeter.
	 * 
	 * @static
	 * @method tickStart
	 */
	function tickStart(): void;
		
	/**
	 * Marks the end of each frame for FPSMeter.
	 * 
	 * @static
	 * @method tickEnd
	 */
	function tickEnd(): void;
		
	/**
	 * Renders the stage to the game screen.
	 * 
	 * @static
	 * @method render
	 * @param {Stage} stage The stage object to be rendered
	 * @param stage 
	 */
	function render(stage : () => void): void;
		
	/**
	 * Checks whether the renderer type is WebGL.
	 * 
	 * @static
	 * @method isWebGL
	 * @return {Boolean} True if the renderer type is WebGL
	 * @return  
	 */
	function isWebGL(): Graphics.IsWebGLRet;
		
	/**
	 * Checks whether the current browser supports WebGL.
	 * 
	 * @static
	 * @method hasWebGL
	 * @return {Boolean} True if the current browser supports WebGL.
	 * @return  
	 */
	function hasWebGL(): Graphics.HasWebGLRet;
		
	/**
	 * Checks whether the canvas blend mode 'difference' is supported.
	 * 
	 * @static
	 * @method canUseDifferenceBlend
	 * @return {Boolean} True if the canvas blend mode 'difference' is supported
	 * @return  
	 */
	function canUseDifferenceBlend(): Graphics.CanUseDifferenceBlendRet;
		
	/**
	 * Checks whether the canvas blend mode 'saturation' is supported.
	 * 
	 * @static
	 * @method canUseSaturationBlend
	 * @return {Boolean} True if the canvas blend mode 'saturation' is supported
	 * @return  
	 */
	function canUseSaturationBlend(): Graphics.CanUseSaturationBlendRet;
		
	/**
	 * Sets the source of the "Now Loading" image.
	 * 
	 * @static
	 * @method setLoadingImage
	 * @param src 
	 */
	function setLoadingImage(src : any): void;
		
	/**
	 * Initializes the counter for displaying the "Now Loading" image.
	 * 
	 * @static
	 * @method startLoading
	 */
	function startLoading(): void;
		
	/**
	 * Increments the loading counter and displays the "Now Loading" image if necessary.
	 * 
	 * @static
	 * @method updateLoading
	 */
	function updateLoading(): void;
		
	/**
	 * Erases the "Now Loading" image.
	 * 
	 * @static
	 * @method endLoading
	 */
	function endLoading(): void;
		
	/**
	 * Displays the loading error text to the screen.
	 * 
	 * @static
	 * @method printLoadingError
	 * @param {String} url The url of the resource failed to load
	 * @param url 
	 */
	function printLoadingError(url : Graphics.PrintLoadingError0): void;
		
	/**
	 * Erases the loading error text.
	 * 
	 * @static
	 * @method eraseLoadingError
	 */
	function eraseLoadingError(): void;
		
	/**
	 * Displays the error text to the screen.
	 * 
	 * @static
	 * @method printError
	 * @param {String} name The name of the error
	 * @param {String} message The message of the error
	 * @param name 
	 * @param message 
	 */
	function printError(name : Graphics.PrintError0, message : Graphics.PrintError1): void;
		
	/**
	 * Shows the FPSMeter element.
	 * 
	 * @static
	 * @method showFps
	 */
	function showFps(): void;
		
	/**
	 * Hides the FPSMeter element.
	 * 
	 * @static
	 * @method hideFps
	 */
	function hideFps(): void;
		
	/**
	 * Loads a font file.
	 * 
	 * @static
	 * @method loadFont
	 * @param {String} name The face name of the font
	 * @param {String} url The url of the font file
	 * @param name 
	 * @param url 
	 */
	function loadFont(name : Graphics.LoadFont0, url : Graphics.LoadFont1): void;
		
	/**
	 * Checks whether the font file is loaded.
	 * 
	 * @static
	 * @method isFontLoaded
	 * @param {String} name The face name of the font
	 * @return {Boolean} True if the font file is loaded
	 * @param name 
	 * @return  
	 */
	function isFontLoaded(name : Graphics.IsFontLoaded0): Graphics.IsFontLoadedRet;
		
	/**
	 * Starts playback of a video.
	 * 
	 * @static
	 * @method playVideo
	 * @param {String} src
	 * @param src 
	 */
	function playVideo(src : Graphics.PlayVideo0): void;
		
	/**
	 * 
	 */
	function _videoLoader(): void;
		
	/**
	 * @static
	 * @method _playVideo
	 * @param {String} src
	 * @private
	 * @param src 
	 */
	function _playVideo(src : /* Graphics._playVideo0 */ any): void;
		
	/**
	 * Checks whether the video is playing.
	 * 
	 * @static
	 * @method isVideoPlaying
	 * @return {Boolean} True if the video is playing
	 * @return  
	 */
	function isVideoPlaying(): Graphics.IsVideoPlayingRet;
		
	/**
	 * Checks whether the browser can play the specified video type.
	 * 
	 * @static
	 * @method canPlayVideoType
	 * @param {String} type The video type to test support for
	 * @return {Boolean} True if the browser can play the specified video type
	 * @param type 
	 * @return  
	 */
	function canPlayVideoType(type : Graphics.CanPlayVideoType0): Graphics.CanPlayVideoTypeRet;
		
	/**
	 * Sets volume of a video.
	 * 
	 * @static
	 * @method setVideoVolume
	 * @param {Number} value
	 * @param value 
	 */
	function setVideoVolume(value : Graphics.SetVideoVolume0): void;
		
	/**
	 * Converts an x coordinate on the page to the corresponding
	 * x coordinate on the canvas area.
	 * 
	 * @static
	 * @method pageToCanvasX
	 * @param {Number} x The x coordinate on the page to be converted
	 * @return {Number} The x coordinate on the canvas area
	 * @param x 
	 * @return  
	 */
	function pageToCanvasX(x : Graphics.PageToCanvasX0): Graphics.PageToCanvasXRet;
		
	/**
	 * Converts a y coordinate on the page to the corresponding
	 * y coordinate on the canvas area.
	 * 
	 * @static
	 * @method pageToCanvasY
	 * @param {Number} y The y coordinate on the page to be converted
	 * @return {Number} The y coordinate on the canvas area
	 * @param y 
	 * @return  
	 */
	function pageToCanvasY(y : Graphics.PageToCanvasY0): Graphics.PageToCanvasYRet;
		
	/**
	 * Checks whether the specified point is inside the game canvas area.
	 * 
	 * @static
	 * @method isInsideCanvas
	 * @param {Number} x The x coordinate on the canvas area
	 * @param {Number} y The y coordinate on the canvas area
	 * @return {Boolean} True if the specified point is inside the game canvas area
	 * @param x 
	 * @param y 
	 * @return  
	 */
	function isInsideCanvas(x : Graphics.IsInsideCanvas0, y : Graphics.IsInsideCanvas1): Graphics.IsInsideCanvasRet;
		
	/**
	 * Calls pixi.js garbage collector
	 */
	function callGC(): void;
		
	/**
	 * @static
	 * @method _createAllElements
	 * @private
	 */
	function _createAllElements(): void;
		
	/**
	 * @static
	 * @method _updateAllElements
	 * @private
	 */
	function _updateAllElements(): void;
		
	/**
	 * @static
	 * @method _updateRealScale
	 * @private
	 */
	function _updateRealScale(): void;
		
	/**
	 * @static
	 * @method _makeErrorHtml
	 * @param {String} name
	 * @param {String} message
	 * @return {String}
	 * @private
	 * @param name 
	 * @param message 
	 * @return  
	 */
	function _makeErrorHtml(name : /* Graphics._makeErrorHtml0 */ any, message : /* Graphics._makeErrorHtml1 */ any): /* Graphics._makeErrorHtmlRet */ any;
		
	/**
	 * @static
	 * @method _defaultStretchMode
	 * @private
	 * @return  
	 */
	function _defaultStretchMode(): /* Graphics._defaultStretchModeRet */ any;
		
	/**
	 * @static
	 * @method _testCanvasBlendModes
	 * @private
	 */
	function _testCanvasBlendModes(): void;
		
	/**
	 * @static
	 * @method _modifyExistingElements
	 * @private
	 */
	function _modifyExistingElements(): void;
		
	/**
	 * @static
	 * @method _createErrorPrinter
	 * @private
	 */
	function _createErrorPrinter(): void;
		
	/**
	 * @static
	 * @method _updateErrorPrinter
	 * @private
	 */
	function _updateErrorPrinter(): void;
		
	/**
	 * @static
	 * @method _createCanvas
	 * @private
	 */
	function _createCanvas(): void;
		
	/**
	 * @static
	 * @method _updateCanvas
	 * @private
	 */
	function _updateCanvas(): void;
		
	/**
	 * @static
	 * @method _createVideo
	 * @private
	 */
	function _createVideo(): void;
		
	/**
	 * @static
	 * @method _updateVideo
	 * @private
	 */
	function _updateVideo(): void;
		
	/**
	 * @static
	 * @method _createUpperCanvas
	 * @private
	 */
	function _createUpperCanvas(): void;
		
	/**
	 * @static
	 * @method _updateUpperCanvas
	 * @private
	 */
	function _updateUpperCanvas(): void;
		
	/**
	 * @static
	 * @method _clearUpperCanvas
	 * @private
	 */
	function _clearUpperCanvas(): void;
		
	/**
	 * @static
	 * @method _paintUpperCanvas
	 * @private
	 */
	function _paintUpperCanvas(): void;
		
	/**
	 * @static
	 * @method _createRenderer
	 * @private
	 */
	function _createRenderer(): void;
		
	/**
	 * @static
	 * @method _updateRenderer
	 * @private
	 */
	function _updateRenderer(): void;
		
	/**
	 * @static
	 * @method _createFPSMeter
	 * @private
	 */
	function _createFPSMeter(): void;
		
	/**
	 * @static
	 * @method _createModeBox
	 * @private
	 */
	function _createModeBox(): void;
		
	/**
	 * @static
	 * @method _createGameFontLoader
	 * @private
	 */
	function _createGameFontLoader(): void;
		
	/**
	 * @static
	 * @method _createFontLoader
	 * @param {String} name
	 * @private
	 * @param name 
	 */
	function _createFontLoader(name : /* Graphics._createFontLoader0 */ any): void;
		
	/**
	 * @static
	 * @method _centerElement
	 * @param {HTMLElement} element
	 * @private
	 * @param element 
	 */
	function _centerElement(element : any): void;
		
	/**
	 * @static
	 * @method _disableTextSelection
	 * @private
	 */
	function _disableTextSelection(): void;
		
	/**
	 * @static
	 * @method _disableContextMenu
	 * @private
	 */
	function _disableContextMenu(): void;
		
	/**
	 * @static
	 * @method _applyCanvasFilter
	 * @private
	 */
	function _applyCanvasFilter(): void;
		
	/**
	 * @static
	 * @method _onVideoLoad
	 * @private
	 */
	function _onVideoLoad(): void;
		
	/**
	 * @static
	 * @method _onVideoError
	 * @private
	 */
	function _onVideoError(): void;
		
	/**
	 * @static
	 * @method _onVideoEnd
	 * @private
	 */
	function _onVideoEnd(): void;
		
	/**
	 * @static
	 * @method _updateVisibility
	 * @param {Boolean} videoVisible
	 * @private
	 * @param videoVisible 
	 */
	function _updateVisibility(videoVisible : /* Graphics._updateVisibility0 */ any): void;
		
	/**
	 * @static
	 * @method _isVideoVisible
	 * @return {Boolean}
	 * @private
	 * @return  
	 */
	function _isVideoVisible(): /* Graphics._isVideoVisibleRet */ any;
		
	/**
	 * @static
	 * @method _setupEventHandlers
	 * @private
	 */
	function _setupEventHandlers(): void;
		
	/**
	 * @static
	 * @method _onWindowResize
	 * @private
	 */
	function _onWindowResize(): void;
		
	/**
	 * @static
	 * @method _onKeyDown
	 * @param {KeyboardEvent} event
	 * @private
	 * @param event 
	 */
	function _onKeyDown(event : any): void;
		
	/**
	 * @static
	 * @method _onTouchEnd
	 * @param {TouchEvent} event
	 * @private
	 * @param event 
	 */
	function _onTouchEnd(event : any): void;
		
	/**
	 * @static
	 * @method _switchFPSMeter
	 * @private
	 */
	function _switchFPSMeter(): void;
		
	/**
	 * @static
	 * @method _switchStretchMode
	 * @return {Boolean}
	 * @private
	 * @return  
	 */
	function _switchStretchMode(): /* Graphics._switchStretchModeRet */ any;
		
	/**
	 * @static
	 * @method _switchFullScreen
	 * @private
	 */
	function _switchFullScreen(): void;
		
	/**
	 * @static
	 * @method _isFullScreen
	 * @return {Boolean}
	 * @private
	 * @return  
	 */
	function _isFullScreen(): /* Graphics._isFullScreenRet */ any;
		
	/**
	 * @static
	 * @method _requestFullScreen
	 * @private
	 */
	function _requestFullScreen(): void;
		
	/**
	 * @static
	 * @method _cancelFullScreen
	 * @private
	 */
	function _cancelFullScreen(): void;
}

/**
 * The static class that handles input data from the keyboard and gamepads.
 * 
 * @class Input
 */
declare interface Input {
		
	/**
	 * 
	 * @return  
	 */
	new (): Input;
}


/**
 * 
 */
declare namespace Input{
		
	/**
	 * Initializes the input system.
	 * 
	 * @static
	 * @method initialize
	 */
	function initialize(): void;
		
	/**
	 * The wait time of the key repeat in frames.
	 * 
	 * @static
	 * @property keyRepeatWait
	 * @type Number
	 */
	export var keyRepeatWait : number;
		
	/**
	 * The interval of the key repeat in frames.
	 * 
	 * @static
	 * @property keyRepeatInterval
	 * @type Number
	 */
	export var keyRepeatInterval : number;
	
	/**
	 * A hash table to convert from a virtual key code to a mapped key name.
	 * 
	 * @static
	 * @property keyMapper
	 * @type Object
	 */
	var keyMapper : {
	}
	
	/**
	 * A hash table to convert from a gamepad button to a mapped key name.
	 * 
	 * @static
	 * @property gamepadMapper
	 * @type Object
	 */
	var gamepadMapper : {
	}
		
	/**
	 * Clears all the input data.
	 * 
	 * @static
	 * @method clear
	 */
	function clear(): void;
	
	/**
	 * 
	 */
	namespace _currentState{
	}
	
	/**
	 * 
	 */
	namespace _previousState{
	}
		
	/**
	 * 
	 */
	export var _gamepadStates : Array</* Input._gamepadStatesI */ any>;
		
	/**
	 * 
	 */
	export var _pressedTime : number;
		
	/**
	 * 
	 */
	export var _dir4 : number;
		
	/**
	 * 
	 */
	export var _dir8 : number;
		
	/**
	 * 
	 */
	export var _preferredAxis : string;
		
	/**
	 * 
	 */
	export var _date : number;
		
	/**
	 * Updates the input data.
	 * 
	 * @static
	 * @method update
	 */
	function update(): void;
		
	/**
	 * Checks whether a key is currently pressed down.
	 * 
	 * @static
	 * @method isPressed
	 * @param {String} keyName The mapped name of the key
	 * @return {Boolean} True if the key is pressed
	 * @param keyName 
	 * @return  
	 */
	function isPressed(keyName : Input.IsPressed0): Input.IsPressedRet;
		
	/**
	 * Checks whether a key is just pressed.
	 * 
	 * @static
	 * @method isTriggered
	 * @param {String} keyName The mapped name of the key
	 * @return {Boolean} True if the key is triggered
	 * @param keyName 
	 * @return  
	 */
	function isTriggered(keyName : Input.IsTriggered0): Input.IsTriggeredRet;
		
	/**
	 * Checks whether a key is just pressed or a key repeat occurred.
	 * 
	 * @static
	 * @method isRepeated
	 * @param {String} keyName The mapped name of the key
	 * @return {Boolean} True if the key is repeated
	 * @param keyName 
	 * @return  
	 */
	function isRepeated(keyName : Input.IsRepeated0): Input.IsRepeatedRet;
		
	/**
	 * Checks whether a key is kept depressed.
	 * 
	 * @static
	 * @method isLongPressed
	 * @param {String} keyName The mapped name of the key
	 * @return {Boolean} True if the key is long-pressed
	 * @param keyName 
	 * @return  
	 */
	function isLongPressed(keyName : Input.IsLongPressed0): Input.IsLongPressedRet;
		
	/**
	 * @static
	 * @method _wrapNwjsAlert
	 * @private
	 */
	function _wrapNwjsAlert(): void;
		
	/**
	 * @static
	 * @method _setupEventHandlers
	 * @private
	 */
	function _setupEventHandlers(): void;
		
	/**
	 * @static
	 * @method _onKeyDown
	 * @param {KeyboardEvent} event
	 * @private
	 * @param event 
	 */
	function _onKeyDown(event : any): void;
		
	/**
	 * @static
	 * @method _shouldPreventDefault
	 * @param {Number} keyCode
	 * @private
	 * @param keyCode 
	 * @return  
	 */
	function _shouldPreventDefault(keyCode : /* Input._shouldPreventDefault0 */ any): /* Input._shouldPreventDefaultRet */ any;
		
	/**
	 * @static
	 * @method _onKeyUp
	 * @param {KeyboardEvent} event
	 * @private
	 * @param event 
	 */
	function _onKeyUp(event : any): void;
		
	/**
	 * @static
	 * @method _onLostFocus
	 * @private
	 */
	function _onLostFocus(): void;
		
	/**
	 * @static
	 * @method _pollGamepads
	 * @private
	 */
	function _pollGamepads(): void;
		
	/**
	 * @static
	 * @method _updateGamepadState
	 * @param {Gamepad} gamepad
	 * @param {Number} index
	 * @private
	 * @param gamepad 
	 */
	function _updateGamepadState(gamepad : any): void;
		
	/**
	 * @static
	 * @method _updateDirection
	 * @private
	 */
	function _updateDirection(): void;
		
	/**
	 * @static
	 * @method _signX
	 * @private
	 * @return  
	 */
	function _signX(): /* Input._signXRet */ any;
		
	/**
	 * @static
	 * @method _signY
	 * @private
	 * @return  
	 */
	function _signY(): /* Input._signYRet */ any;
		
	/**
	 * @static
	 * @method _makeNumpadDirection
	 * @param {Number} x
	 * @param {Number} y
	 * @return {Number}
	 * @private
	 * @param x 
	 * @param y 
	 * @return  
	 */
	function _makeNumpadDirection(x : /* Input._makeNumpadDirection0 */ any, y : /* Input._makeNumpadDirection1 */ any): /* Input._makeNumpadDirectionRet */ any;
		
	/**
	 * @static
	 * @method _isEscapeCompatible
	 * @param {String} keyName
	 * @return {Boolean}
	 * @private
	 * @param keyName 
	 * @return  
	 */
	function _isEscapeCompatible(keyName : /* Input._isEscapeCompatible0 */ any): /* Input._isEscapeCompatibleRet */ any;
}

/**
 * The static class that handles input data from the mouse and touchscreen.
 * 
 * @class TouchInput
 */
declare interface TouchInput {
		
	/**
	 * 
	 * @return  
	 */
	new (): TouchInput;
}


/**
 * 
 */
declare namespace TouchInput{
		
	/**
	 * Initializes the touch system.
	 * 
	 * @static
	 * @method initialize
	 */
	function initialize(): void;
		
	/**
	 * The wait time of the pseudo key repeat in frames.
	 * 
	 * @static
	 * @property keyRepeatWait
	 * @type Number
	 */
	export var keyRepeatWait : number;
		
	/**
	 * The interval of the pseudo key repeat in frames.
	 * 
	 * @static
	 * @property keyRepeatInterval
	 * @type Number
	 */
	export var keyRepeatInterval : number;
		
	/**
	 * Clears all the touch data.
	 * 
	 * @static
	 * @method clear
	 */
	function clear(): void;
		
	/**
	 * 
	 */
	export var _mousePressed : boolean;
		
	/**
	 * 
	 */
	export var _screenPressed : boolean;
		
	/**
	 * 
	 */
	export var _pressedTime : number;
	
	/**
	 * 
	 */
	namespace _events{
				
		/**
		 * 
		 */
		export var triggered : boolean;
				
		/**
		 * 
		 */
		export var cancelled : boolean;
				
		/**
		 * 
		 */
		export var moved : boolean;
				
		/**
		 * 
		 */
		export var released : boolean;
				
		/**
		 * 
		 */
		export var wheelX : number;
				
		/**
		 * 
		 */
		export var wheelY : number;
	}
		
	/**
	 * 
	 */
	export var _triggered : boolean;
		
	/**
	 * 
	 */
	export var _cancelled : boolean;
		
	/**
	 * 
	 */
	export var _moved : boolean;
		
	/**
	 * 
	 */
	export var _released : boolean;
		
	/**
	 * 
	 */
	export var _wheelX : number;
		
	/**
	 * 
	 */
	export var _wheelY : number;
		
	/**
	 * 
	 */
	export var _x : number;
		
	/**
	 * 
	 */
	export var _y : number;
		
	/**
	 * 
	 */
	export var _date : number;
		
	/**
	 * Updates the touch data.
	 * 
	 * @static
	 * @method update
	 */
	function update(): void;
		
	/**
	 * Checks whether the mouse button or touchscreen is currently pressed down.
	 * 
	 * @static
	 * @method isPressed
	 * @return {Boolean} True if the mouse button or touchscreen is pressed
	 * @return  
	 */
	function isPressed(): TouchInput.IsPressedRet;
		
	/**
	 * Checks whether the left mouse button or touchscreen is just pressed.
	 * 
	 * @static
	 * @method isTriggered
	 * @return {Boolean} True if the mouse button or touchscreen is triggered
	 * @return  
	 */
	function isTriggered(): TouchInput.IsTriggeredRet;
		
	/**
	 * Checks whether the left mouse button or touchscreen is just pressed
	 * or a pseudo key repeat occurred.
	 * 
	 * @static
	 * @method isRepeated
	 * @return {Boolean} True if the mouse button or touchscreen is repeated
	 * @return  
	 */
	function isRepeated(): TouchInput.IsRepeatedRet;
		
	/**
	 * Checks whether the left mouse button or touchscreen is kept depressed.
	 * 
	 * @static
	 * @method isLongPressed
	 * @return {Boolean} True if the left mouse button or touchscreen is long-pressed
	 * @return  
	 */
	function isLongPressed(): TouchInput.IsLongPressedRet;
		
	/**
	 * Checks whether the right mouse button is just pressed.
	 * 
	 * @static
	 * @method isCancelled
	 * @return {Boolean} True if the right mouse button is just pressed
	 * @return  
	 */
	function isCancelled(): TouchInput.IsCancelledRet;
		
	/**
	 * Checks whether the mouse or a finger on the touchscreen is moved.
	 * 
	 * @static
	 * @method isMoved
	 * @return {Boolean} True if the mouse or a finger on the touchscreen is moved
	 * @return  
	 */
	function isMoved(): TouchInput.IsMovedRet;
		
	/**
	 * Checks whether the left mouse button or touchscreen is released.
	 * 
	 * @static
	 * @method isReleased
	 * @return {Boolean} True if the mouse button or touchscreen is released
	 * @return  
	 */
	function isReleased(): TouchInput.IsReleasedRet;
		
	/**
	 * @static
	 * @method _setupEventHandlers
	 * @private
	 */
	function _setupEventHandlers(): void;
		
	/**
	 * @static
	 * @method _onMouseDown
	 * @param {MouseEvent} event
	 * @private
	 * @param event 
	 */
	function _onMouseDown(event : any): void;
		
	/**
	 * @static
	 * @method _onLeftButtonDown
	 * @param {MouseEvent} event
	 * @private
	 * @param event 
	 */
	function _onLeftButtonDown(event : any): void;
		
	/**
	 * @static
	 * @method _onMiddleButtonDown
	 * @param {MouseEvent} event
	 * @private
	 * @param event 
	 */
	function _onMiddleButtonDown(event : any): void;
		
	/**
	 * @static
	 * @method _onRightButtonDown
	 * @param {MouseEvent} event
	 * @private
	 * @param event 
	 */
	function _onRightButtonDown(event : any): void;
		
	/**
	 * @static
	 * @method _onMouseMove
	 * @param {MouseEvent} event
	 * @private
	 * @param event 
	 */
	function _onMouseMove(event : any): void;
		
	/**
	 * @static
	 * @method _onMouseUp
	 * @param {MouseEvent} event
	 * @private
	 * @param event 
	 */
	function _onMouseUp(event : any): void;
		
	/**
	 * @static
	 * @method _onWheel
	 * @param {WheelEvent} event
	 * @private
	 * @param event 
	 */
	function _onWheel(event : any): void;
		
	/**
	 * @static
	 * @method _onTouchStart
	 * @param {TouchEvent} event
	 * @private
	 * @param event 
	 */
	function _onTouchStart(event : any): void;
		
	/**
	 * @static
	 * @method _onTouchMove
	 * @param {TouchEvent} event
	 * @private
	 * @param event 
	 */
	function _onTouchMove(event : any): void;
		
	/**
	 * @static
	 * @method _onTouchEnd
	 * @param {TouchEvent} event
	 * @private
	 * @param event 
	 */
	function _onTouchEnd(event : any): void;
		
	/**
	 * @static
	 * @method _onTouchCancel
	 * @param {TouchEvent} event
	 * @private
	 * @param event 
	 */
	function _onTouchCancel(event : any): void;
		
	/**
	 * @static
	 * @method _onPointerDown
	 * @param {PointerEvent} event
	 * @private
	 * @param event 
	 */
	function _onPointerDown(event : any): void;
		
	/**
	 * @static
	 * @method _onTrigger
	 * @param {Number} x
	 * @param {Number} y
	 * @private
	 * @param x 
	 * @param y 
	 */
	function _onTrigger(x : /* TouchInput._onTrigger0 */ any, y : /* TouchInput._onTrigger1 */ any): void;
		
	/**
	 * @static
	 * @method _onCancel
	 * @param {Number} x
	 * @param {Number} y
	 * @private
	 * @param x 
	 * @param y 
	 */
	function _onCancel(x : /* TouchInput._onCancel0 */ any, y : /* TouchInput._onCancel1 */ any): void;
		
	/**
	 * @static
	 * @method _onMove
	 * @param {Number} x
	 * @param {Number} y
	 * @private
	 * @param x 
	 * @param y 
	 */
	function _onMove(x : /* TouchInput._onMove0 */ any, y : /* TouchInput._onMove1 */ any): void;
		
	/**
	 * @static
	 * @method _onRelease
	 * @param {Number} x
	 * @param {Number} y
	 * @private
	 * @param x 
	 * @param y 
	 */
	function _onRelease(x : /* TouchInput._onRelease0 */ any, y : /* TouchInput._onRelease1 */ any): void;
}

/**
 * The basic object that is rendered to the game screen.
 * 
 * @class Sprite
 * @constructor
 * @param {Bitmap} bitmap The image for the sprite
 */
declare interface Sprite {
		
	/**
	 * 
	 * @return  
	 */
	new (): Sprite;
}


/**
 * 
 */
declare namespace Sprite{
		
	/**
	 * Number of the created objects.
	 */
	export var _counter : number;
		
	/**
	 * 
	 */
	export var rotation : number;
		
	/**
	 * 
	 */
	export var ax : number;
		
	/**
	 * 
	 */
	export var ay : number;
		
	/**
	 * 
	 */
	export var opacity : number;
}

/**
 * The tilemap which displays 2D tile-based game map.
 * 
 * @class Tilemap
 * @constructor
 */
declare interface Tilemap {
		
	/**
	 * 
	 * @return  
	 */
	new (): any;
}


/**
 * 
 */
declare namespace Tilemap{
		
	/**
	 * Tile type checkers
	 */
	export var TILE_ID_B : number;
		
	/**
	 * 
	 */
	export var TILE_ID_C : number;
		
	/**
	 * 
	 */
	export var TILE_ID_D : number;
		
	/**
	 * 
	 */
	export var TILE_ID_E : number;
		
	/**
	 * 
	 */
	export var TILE_ID_A5 : number;
		
	/**
	 * 
	 */
	export var TILE_ID_A1 : number;
		
	/**
	 * 
	 */
	export var TILE_ID_A2 : number;
		
	/**
	 * 
	 */
	export var TILE_ID_A3 : number;
		
	/**
	 * 
	 */
	export var TILE_ID_A4 : number;
		
	/**
	 * 
	 */
	export var TILE_ID_MAX : number;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isVisibleTile(tileId : Tilemap.IsVisibleTile0): Tilemap.IsVisibleTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isAutotile(tileId : Tilemap.IsAutotile0): Tilemap.IsAutotileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function getAutotileKind(tileId : Tilemap.GetAutotileKind0): Tilemap.GetAutotileKindRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function getAutotileShape(tileId : Tilemap.GetAutotileShape0): Tilemap.GetAutotileShapeRet;
		
	/**
	 * 
	 * @param kind 
	 * @param shape 
	 */
	function makeAutotileId(kind : any, shape : Tilemap.MakeAutotileId1): void;
		
	/**
	 * 
	 * @param tileID1 
	 * @param tileID2 
	 * @return  
	 */
	function isSameKindTile(tileID1 : Tilemap.IsSameKindTile0, tileID2 : Tilemap.IsSameKindTile1): Tilemap.IsSameKindTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isTileA1(tileId : Tilemap.IsTileA10): Tilemap.IsTileA1Ret;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isTileA2(tileId : Tilemap.IsTileA20): Tilemap.IsTileA2Ret;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isTileA3(tileId : Tilemap.IsTileA30): Tilemap.IsTileA3Ret;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isTileA4(tileId : Tilemap.IsTileA40): Tilemap.IsTileA4Ret;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isTileA5(tileId : Tilemap.IsTileA50): Tilemap.IsTileA5Ret;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWaterTile(tileId : Tilemap.IsWaterTile0): Tilemap.IsWaterTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWaterfallTile(tileId : Tilemap.IsWaterfallTile0): Tilemap.IsWaterfallTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isGroundTile(tileId : Tilemap.IsGroundTile0): Tilemap.IsGroundTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isShadowingTile(tileId : Tilemap.IsShadowingTile0): Tilemap.IsShadowingTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isRoofTile(tileId : Tilemap.IsRoofTile0): Tilemap.IsRoofTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWallTopTile(tileId : Tilemap.IsWallTopTile0): Tilemap.IsWallTopTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWallSideTile(tileId : Tilemap.IsWallSideTile0): Tilemap.IsWallSideTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWallTile(tileId : any): Tilemap.IsWallTileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isFloorTypeAutotile(tileId : Tilemap.IsFloorTypeAutotile0): Tilemap.IsFloorTypeAutotileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWallTypeAutotile(tileId : any): Tilemap.IsWallTypeAutotileRet;
		
	/**
	 * 
	 * @param tileId 
	 * @return  
	 */
	function isWaterfallTypeAutotile(tileId : any): Tilemap.IsWaterfallTypeAutotileRet;
		
	/**
	 * Autotile shape number to coordinates of tileset images
	 */
	export var FLOOR_AUTOTILE_TABLE : Array<Tilemap.FLOOR_AUTOTILE_TABLEI>;
		
	/**
	 * 
	 */
	export var WALL_AUTOTILE_TABLE : Array<Tilemap.WALL_AUTOTILE_TABLEI>;
		
	/**
	 * 
	 */
	export var WATERFALL_AUTOTILE_TABLE : Array<Array<Array</* number],[number],[number],[number]],[[number],[number],[number],[number]],[[number],[number],[number],[number]],[[number],[number],[number],[number */ any>>>;
}

/**
 * The tilemap which displays 2D tile-based game map using shaders
 * 
 * @class Tilemap
 * @constructor
 */
declare interface ShaderTilemap {
		
	/**
	 * 
	 * @return  
	 */
	new (): any;
}


/**
 * The sprite object for a tiling image.
 * 
 * @class TilingSprite
 * @constructor
 * @param {Bitmap} bitmap The image for the tiling sprite
 */
declare interface TilingSprite {
		
	/**
	 * 
	 * @return  
	 */
	new (): TilingSprite;
}


/**
 * The sprite which covers the entire game screen.
 * 
 * @class ScreenSprite
 * @constructor
 */
declare interface ScreenSprite {
		
	/**
	 * 
	 * @return  
	 */
	new (): ScreenSprite;
}


/**
 * 
 */
declare namespace ScreenSprite{
		
	/**
	 * 
	 */
	export var YEPWarned : boolean;
		
	/**
	 * 
	 */
	function warnYep(): void;
}

/**
 * The window in the game.
 * 
 * @class Window
 * @constructor
 */
declare interface Window {
		
	/**
	 * 
	 * @return  
	 */
	new (): Window;
}


/**
 * The layer which contains game windows.
 * 
 * @class WindowLayer
 * @constructor
 */
declare interface WindowLayer {
		
	/**
	 * 
	 * @return  
	 */
	new (): any;
}


/**
 * The weather effect which displays rain, storm, or snow.
 * 
 * @class Weather
 * @constructor
 */
declare interface Weather {
		
	/**
	 * 
	 * @return  
	 */
	new (): any;
}


/**
 * The color matrix filter for WebGL.
 * 
 * @class ToneFilter
 * @extends PIXI.Filter
 * @constructor
 */
declare interface ToneFilter {
		
	/**
	 * 
	 * @return  
	 */
	new (): ToneFilter;
}


/**
 * The sprite which changes the screen color in 2D canvas mode.
 * 
 * @class ToneSprite
 * @constructor
 */
declare interface ToneSprite {
		
	/**
	 * 
	 * @return  
	 */
	new (): ToneSprite;
}


/**
 * The root object of the display tree.
 * 
 * @class Stage
 * @constructor
 */
declare interface Stage {
		
	/**
	 * 
	 * @return  
	 */
	new (): Stage;
}


/**
 * The audio object of Web Audio API.
 * 
 * @class WebAudio
 * @constructor
 * @param {String} url The url of the audio file
 */
declare interface WebAudio {
		
	/**
	 * 
	 * @return  
	 */
	new (): any;
		
	/**
	 * Initializes the audio system.
	 * 
	 * @static
	 * @method initialize
	 * @param {Boolean} noAudio Flag for the no-audio mode
	 * @return {Boolean} True if the audio system is available
	 * @param noAudio 
	 * @return  
	 */
	initialize(noAudio : WebAudio.Initialize0): WebAudio.InitializeRet;
		
	/**
	 * Clears the audio data.
	 * 
	 * @method clear
	 */
	clear(): void;
		
	/**
	 * Checks whether the audio data is ready to play.
	 * 
	 * @method isReady
	 * @return {Boolean} True if the audio data is ready to play
	 * @return  
	 */
	isReady(): WebAudio.prototype.IsReadyRet;
		
	/**
	 * Checks whether a loading error has occurred.
	 * 
	 * @method isError
	 * @return {Boolean} True if a loading error has occurred
	 * @return  
	 */
	isError(): WebAudio.prototype.IsErrorRet;
		
	/**
	 * Checks whether the audio is playing.
	 * 
	 * @method isPlaying
	 * @return {Boolean} True if the audio is playing
	 * @return  
	 */
	isPlaying(): WebAudio.prototype.IsPlayingRet;
		
	/**
	 * Plays the audio.
	 * 
	 * @method play
	 * @param {Boolean} loop Whether the audio data play in a loop
	 * @param {Number} offset The start position to play in seconds
	 * @param loop 
	 * @param offset 
	 */
	play(loop : WebAudio.prototype.Play0, offset : WebAudio.prototype.Play1): void;
		
	/**
	 * Stops the audio.
	 * 
	 * @method stop
	 */
	stop(): void;
		
	/**
	 * Performs the audio fade-in.
	 * 
	 * @method fadeIn
	 * @param {Number} duration Fade-in time in seconds
	 * @param duration 
	 */
	fadeIn(duration : WebAudio.prototype.FadeIn0): void;
		
	/**
	 * Performs the audio fade-out.
	 * 
	 * @method fadeOut
	 * @param {Number} duration Fade-out time in seconds
	 * @param duration 
	 */
	fadeOut(duration : WebAudio.prototype.FadeOut0): void;
		
	/**
	 * Gets the seek position of the audio.
	 * 
	 * @method seek
	 * @return  
	 */
	seek(): WebAudio.prototype.SeekRet;
		
	/**
	 * Add a callback function that will be called when the audio data is loaded.
	 * 
	 * @method addLoadListener
	 * @param {Function} listner The callback function
	 * @param listner 
	 */
	addLoadListener(listner : Function): void;
		
	/**
	 * Add a callback function that will be called when the playback is stopped.
	 * 
	 * @method addStopListener
	 * @param {Function} listner The callback function
	 * @param listner 
	 */
	addStopListener(listner : Function): void;
		
	/**
	 * @method _load
	 * @param {String} url
	 * @private
	 * @param url 
	 */
	_load(url : /* WebAudio.prototype._load0 */ any): void;
		
	/**
	 * @method _onXhrLoad
	 * @param {XMLHttpRequest} xhr
	 * @private
	 * @param xhr 
	 */
	_onXhrLoad(xhr : /* WebAudio.prototype._onXhrLoad0 */ any): void;
		
	/**
	 * @method _startPlaying
	 * @param {Boolean} loop
	 * @param {Number} offset
	 * @private
	 * @param loop 
	 * @param offset 
	 */
	_startPlaying(loop : /* WebAudio.prototype._startPlaying0 */ any, offset : /* WebAudio.prototype._startPlaying1 */ any): void;
		
	/**
	 * @method _createNodes
	 * @private
	 */
	_createNodes(): void;
		
	/**
	 * @method _connectNodes
	 * @private
	 */
	_connectNodes(): void;
		
	/**
	 * @method _removeNodes
	 * @private
	 */
	_removeNodes(): void;
		
	/**
	 * @method _createEndTimer
	 * @private
	 */
	_createEndTimer(): void;
		
	/**
	 * @method _removeEndTimer
	 * @private
	 */
	_removeEndTimer(): void;
		
	/**
	 * @method _updatePanner
	 * @private
	 */
	_updatePanner(): void;
		
	/**
	 * @method _onLoad
	 * @private
	 */
	_onLoad(): void;
		
	/**
	 * @method _readLoopComments
	 * @param {Uint8Array} array
	 * @private
	 * @param array 
	 */
	_readLoopComments(array : Float32Array): void;
		
	/**
	 * @method _readOgg
	 * @param {Uint8Array} array
	 * @private
	 * @param array 
	 */
	_readOgg(array : Float32Array): void;
		
	/**
	 * @method _readMp4
	 * @param {Uint8Array} array
	 * @private
	 * @param array 
	 */
	_readMp4(array : Float32Array): void;
		
	/**
	 * @method _readMetaData
	 * @param {Uint8Array} array
	 * @param {Number} index
	 * @param {Number} size
	 * @private
	 * @param array 
	 * @param index 
	 * @param size 
	 */
	_readMetaData(array : Float32Array, index : /* WebAudio.prototype._readMetaData1 */ any, size : /* WebAudio.prototype._readMetaData2 */ any): void;
		
	/**
	 * @method _readLittleEndian
	 * @param {Uint8Array} array
	 * @param {Number} index
	 * @private
	 * @param array 
	 * @param index 
	 * @return  
	 */
	_readLittleEndian(array : Float32Array, index : /* WebAudio.prototype._readLittleEndian1 */ any): /* WebAudio.prototype._readLittleEndianRet */ any;
		
	/**
	 * @method _readBigEndian
	 * @param {Uint8Array} array
	 * @param {Number} index
	 * @private
	 * @param array 
	 * @param index 
	 * @return  
	 */
	_readBigEndian(array : Float32Array, index : /* WebAudio.prototype._readBigEndian1 */ any): /* WebAudio.prototype._readBigEndianRet */ any;
		
	/**
	 * @method _readFourCharacters
	 * @param {Uint8Array} array
	 * @param {Number} index
	 * @private
	 * @param array 
	 * @param index 
	 * @return  
	 */
	_readFourCharacters(array : Float32Array, index : /* WebAudio.prototype._readFourCharacters1 */ any): /* WebAudio.prototype._readFourCharactersRet */ any;
		
	/**
	 * 
	 */
	_standAlone : boolean;
		
	/**
	 * 
	 */
	_masterVolume : number;
		
	/**
	 * 
	 */
	_initialized : boolean;
		
	/**
	 * 
	 */
	_unlocked : boolean;
		
	/**
	 * Checks whether the browser can play ogg files.
	 * 
	 * @static
	 * @method canPlayOgg
	 * @return {Boolean} True if the browser can play ogg files
	 * @return  
	 */
	canPlayOgg(): WebAudio.CanPlayOggRet;
		
	/**
	 * Checks whether the browser can play m4a files.
	 * 
	 * @static
	 * @method canPlayM4a
	 * @return {Boolean} True if the browser can play m4a files
	 * @return  
	 */
	canPlayM4a(): WebAudio.CanPlayM4aRet;
		
	/**
	 * Sets the master volume of the all audio.
	 * 
	 * @static
	 * @method setMasterVolume
	 * @param {Number} value Master volume (min: 0, max: 1)
	 * @param value 
	 */
	setMasterVolume(value : WebAudio.SetMasterVolume0): void;
		
	/**
	 * @static
	 * @method _createContext
	 * @private
	 */
	_createContext(): void;
		
	/**
	 * @static
	 * @method _detectCodecs
	 * @private
	 */
	_detectCodecs(): void;
		
	/**
	 * @static
	 * @method _createMasterGainNode
	 * @private
	 */
	_createMasterGainNode(): void;
		
	/**
	 * @static
	 * @method _setupEventHandlers
	 * @private
	 */
	_setupEventHandlers(): void;
		
	/**
	 * @static
	 * @method _onTouchStart
	 * @private
	 */
	_onTouchStart(): void;
		
	/**
	 * @static
	 * @method _onVisibilityChange
	 * @private
	 */
	_onVisibilityChange(): void;
		
	/**
	 * @static
	 * @method _onHide
	 * @private
	 */
	_onHide(): void;
		
	/**
	 * @static
	 * @method _onShow
	 * @private
	 */
	_onShow(): void;
		
	/**
	 * @static
	 * @method _shouldMuteOnHide
	 * @private
	 * @return  
	 */
	_shouldMuteOnHide(): /* WebAudio._shouldMuteOnHideRet */ any;
		
	/**
	 * @static
	 * @method _fadeIn
	 * @param {Number} duration
	 * @private
	 * @param duration 
	 */
	_fadeIn(duration : /* WebAudio._fadeIn0 */ any): void;
		
	/**
	 * @static
	 * @method _fadeOut
	 * @param {Number} duration
	 * @private
	 * @param duration 
	 */
	_fadeOut(duration : /* WebAudio._fadeOut0 */ any): void;
}

/**
 * The static class that handles HTML5 Audio.
 * 
 * @class Html5Audio
 * @constructor
 */
declare interface Html5Audio {
		
	/**
	 * 
	 * @return  
	 */
	new (): Html5Audio;
}


/**
 * 
 */
declare namespace Html5Audio{
		
	/**
	 * 
	 */
	export var _initialized : boolean;
		
	/**
	 * 
	 */
	export var _unlocked : boolean;
		
	/**
	 * 
	 */
	export var _tweenGain : number;
		
	/**
	 * 
	 */
	export var _tweenTargetGain : number;
		
	/**
	 * 
	 */
	export var _tweenGainStep : number;
		
	/**
	 * 
	 */
	export var _staticSePath : string;
		
	/**
	 * Sets up the Html5 Audio.
	 * 
	 * @static
	 * @method setup
	 * @param {String} url The url of the audio file
	 * @param url 
	 */
	function setup(url : Html5Audio.Setup0): void;
		
	/**
	 * 
	 */
	export var _url : string;
		
	/**
	 * Initializes the audio system.
	 * 
	 * @static
	 * @method initialize
	 * @return {Boolean} True if the audio system is available
	 * @return  
	 */
	function initialize(): Html5Audio.InitializeRet;
		
	/**
	 * @static
	 * @method _setupEventHandlers
	 * @private
	 */
	function _setupEventHandlers(): void;
		
	/**
	 * @static
	 * @method _onTouchStart
	 * @private
	 */
	function _onTouchStart(): void;
		
	/**
	 * @static
	 * @method _onVisibilityChange
	 * @private
	 */
	function _onVisibilityChange(): void;
		
	/**
	 * @static
	 * @method _onLoadedData
	 * @private
	 */
	function _onLoadedData(): void;
		
	/**
	 * 
	 */
	export var _buffered : boolean;
		
	/**
	 * @static
	 * @method _onError
	 * @private
	 */
	function _onError(): void;
		
	/**
	 * 
	 */
	export var _hasError : boolean;
		
	/**
	 * @static
	 * @method _onEnded
	 * @private
	 */
	function _onEnded(): void;
		
	/**
	 * @static
	 * @method _onHide
	 * @private
	 */
	function _onHide(): void;
		
	/**
	 * @static
	 * @method _onShow
	 * @private
	 */
	function _onShow(): void;
		
	/**
	 * Clears the audio data.
	 * 
	 * @static
	 * @method clear
	 */
	function clear(): void;
		
	/**
	 * 
	 */
	export var _volume : number;
		
	/**
	 * 
	 */
	export var _loadListeners : /* [fn() */ any | Function;
		
	/**
	 * 
	 */
	export var _autoPlay : boolean;
		
	/**
	 * 
	 */
	export var _isLoading : boolean;
		
	/**
	 * Set the URL of static se.
	 * 
	 * @static
	 * @param {String} url
	 * @param url 
	 */
	function setStaticSe(url : Html5Audio.SetStaticSe0): void;
		
	/**
	 * [read-only] The url of the audio file.
	 * 
	 * @property url
	 * @type String
	 */
	export var url : string;
		
	/**
	 * The volume of the audio.
	 * 
	 * @property volume
	 * @type Number
	 */
	export var volume : number;
		
	/**
	 * Checks whether the audio data is ready to play.
	 * 
	 * @static
	 * @method isReady
	 * @return {Boolean} True if the audio data is ready to play
	 * @return  
	 */
	function isReady(): Html5Audio.IsReadyRet;
		
	/**
	 * Checks whether a loading error has occurred.
	 * 
	 * @static
	 * @method isError
	 * @return {Boolean} True if a loading error has occurred
	 * @return  
	 */
	function isError(): Html5Audio.IsErrorRet;
		
	/**
	 * Checks whether the audio is playing.
	 * 
	 * @static
	 * @method isPlaying
	 * @return {Boolean} True if the audio is playing
	 * @return  
	 */
	function isPlaying(): Html5Audio.IsPlayingRet;
		
	/**
	 * Plays the audio.
	 * 
	 * @static
	 * @method play
	 * @param {Boolean} loop Whether the audio data play in a loop
	 * @param {Number} offset The start position to play in seconds
	 * @param loop 
	 * @param offset 
	 */
	function play(loop : Html5Audio.Play0, offset : Html5Audio.Play1): void;
		
	/**
	 * Stops the audio.
	 * 
	 * @static
	 * @method stop
	 */
	function stop(): void;
		
	/**
	 * Performs the audio fade-in.
	 * 
	 * @static
	 * @method fadeIn
	 * @param {Number} duration Fade-in time in seconds
	 * @param duration 
	 */
	function fadeIn(duration : Html5Audio.FadeIn0): void;
		
	/**
	 * Performs the audio fade-out.
	 * 
	 * @static
	 * @method fadeOut
	 * @param {Number} duration Fade-out time in seconds
	 * @param duration 
	 */
	function fadeOut(duration : Html5Audio.FadeOut0): void;
		
	/**
	 * Gets the seek position of the audio.
	 * 
	 * @static
	 * @method seek
	 * @return  
	 */
	function seek(): Html5Audio.SeekRet;
		
	/**
	 * Add a callback function that will be called when the audio data is loaded.
	 * 
	 * @static
	 * @method addLoadListener
	 * @param {Function} listner The callback function
	 * @param listner 
	 */
	function addLoadListener(listner : (() => void) | Function): void;
		
	/**
	 * @static
	 * @method _load
	 * @param {String} url
	 * @private
	 * @param url 
	 */
	function _load(url : /* Html5Audio._load0 */ any): void;
		
	/**
	 * @static
	 * @method _startPlaying
	 * @param {Boolean} loop
	 * @param {Number} offset
	 * @private
	 * @param loop 
	 * @param offset 
	 */
	function _startPlaying(loop : /* Html5Audio._startPlaying0 */ any, offset : /* Html5Audio._startPlaying1 */ any): void;
		
	/**
	 * @static
	 * @method _onLoad
	 * @private
	 */
	function _onLoad(): void;
		
	/**
	 * @static
	 * @method _startGainTween
	 * @params {Number} duration
	 * @private
	 * @param duration 
	 */
	function _startGainTween(duration : /* Html5Audio._startGainTween0 */ any): void;
		
	/**
	 * @static
	 * @method _applyTweenValue
	 * @param {Number} volume
	 * @private
	 * @param volume 
	 */
	function _applyTweenValue(volume : /* Html5Audio._applyTweenValue0 */ any): void;
}

/**
 * The static class that handles JSON with object information.
 * 
 * @class JsonEx
 */
declare interface JsonEx {
		
	/**
	 * 
	 * @return  
	 */
	new (): JsonEx;
}


/**
 * 
 */
declare namespace JsonEx{
		
	/**
	 * The maximum depth of objects.
	 * 
	 * @static
	 * @property maxDepth
	 * @type Number
	 * @default 100
	 */
	export var maxDepth : number;
		
	/**
	 * 
	 */
	export var _id : number;
		
	/**
	 * 
	 * @return  
	 */
	function _generateId(): /* JsonEx._generateIdRet */ any;
		
	/**
	 * Converts an object to a JSON string with object information.
	 * 
	 * @static
	 * @method stringify
	 * @param {Object} object The object to be converted
	 * @return {String} The JSON string
	 * @param object 
	 * @return  
	 */
	function stringify(object : JsonEx.Stringify0): JsonEx.StringifyRet;
		
	/**
	 * 
	 * @param circulars 
	 * @param undefined 
	 * @param undefined 
	 */
	function _restoreCircularReference(circulars : /* JsonEx._restoreCircularReference0 */ any, param2 : any, param3 : /* ?]] */ any): void;
		
	/**
	 * Parses a JSON string and reconstructs the corresponding object.
	 * 
	 * @static
	 * @method parse
	 * @param {String} json The JSON string
	 * @return {Object} The reconstructed object
	 * @param json 
	 * @return  
	 */
	function parse(json : JsonEx.Parse0): any;
		
	/**
	 * 
	 * @param contents 
	 * @param circulars 
	 * @param undefined 
	 * @param undefined 
	 * @param registry 
	 */
	function _linkCircularReference(contents : /* JsonEx._linkCircularReference0 */ any, circulars : /* JsonEx._linkCircularReference1 */ any, param3 : /* JsonEx._linkCircularReference2 */ any, param4 : /* ?]] */ any, registry : /* JsonEx._linkCircularReference.!2 */ any): void;
		
	/**
	 * 
	 * @param object 
	 */
	function _cleanMetadata(object : any): void;
		
	/**
	 * Makes a deep copy of the specified object.
	 * 
	 * @static
	 * @method makeDeepCopy
	 * @param {Object} object The object to be copied
	 * @return {Object} The copied object
	 * @param object 
	 * @return  
	 */
	function makeDeepCopy(object : any): any;
		
	/**
	 * @static
	 * @method _encode
	 * @param {Object} value
	 * @param {Array} circular
	 * @param {Number} depth
	 * @return {Object}
	 * @private
	 * @param value 
	 * @param circular 
	 * @param undefined 
	 * @param undefined 
	 * @param depth 
	 * @return  
	 */
	function _encode(value : any, circular : /* [[? */ any, param3 : /* JsonEx._encode2 */ any, param4 : /* ?]] */ any, depth : number): /* JsonEx._encodeRet */ any;
		
	/**
	 * @static
	 * @method _decode
	 * @param {Object} value
	 * @param {Array} circular
	 * @param {Object} registry
	 * @return {Object}
	 * @private
	 * @param value 
	 * @param circular 
	 * @param undefined 
	 * @param undefined 
	 * @param registry 
	 */
	function _decode(value : any, circular : /* [[? */ any, param3 : any, param4 : /* ?]] */ any, registry : /* JsonEx._linkCircularReference.!2 */ any): void;
		
	/**
	 * @static
	 * @method _getConstructorName
	 * @param {Object} value
	 * @return {String}
	 * @private
	 * @param value 
	 * @return  
	 */
	function _getConstructorName(value : any): /* JsonEx._getConstructorNameRet */ any;
		
	/**
	 * @static
	 * @method _resetPrototype
	 * @param {Object} value
	 * @param {Object} prototype
	 * @return {Object}
	 * @private
	 * @param value 
	 * @param prototype 
	 * @return  
	 */
	function _resetPrototype(value : any, prototype : any): any;
}

/**
 * 
 */
declare interface Decrypter {
		
	/**
	 * 
	 * @return  
	 */
	new (): Decrypter;
}


/**
 * 
 */
declare namespace Decrypter{
		
	/**
	 * 
	 */
	export var hasEncryptedImages : boolean;
		
	/**
	 * 
	 */
	export var hasEncryptedAudio : boolean;
		
	/**
	 * 
	 */
	export var _requestImgFile : Array<any>;
		
	/**
	 * 
	 */
	export var _headerlength : number;
		
	/**
	 * 
	 */
	export var _xhrOk : number;
		
	/**
	 * 
	 */
	export var _encryptionKey : string;
		
	/**
	 * 
	 */
	export var _ignoreList : Array</* Decrypter._ignoreListI */ any>;
		
	/**
	 * 
	 */
	export var SIGNATURE : string;
		
	/**
	 * 
	 */
	export var VER : string;
		
	/**
	 * 
	 */
	export var REMAIN : string;
		
	/**
	 * 
	 * @param url 
	 * @return  
	 */
	function checkImgIgnore(url : Decrypter.CheckImgIgnore0): Decrypter.CheckImgIgnoreRet;
		
	/**
	 * 
	 * @param url 
	 * @param bitmap 
	 */
	function decryptImg(url : Decrypter.DecryptImg0, bitmap : Bitmap): void;
		
	/**
	 * 
	 * @param url 
	 * @param bgm 
	 * @param pos 
	 */
	function decryptHTML5Audio(url : any, bgm : any, pos : any): void;
		
	/**
	 * 
	 * @param arrayBuffer 
	 * @param length 
	 */
	function cutArrayHeader(arrayBuffer : any, length : Decrypter.CutArrayHeader1): void;
		
	/**
	 * 
	 * @param arrayBuffer 
	 * @return  
	 */
	function decryptArrayBuffer(arrayBuffer : Decrypter.DecryptArrayBuffer0): Decrypter.DecryptArrayBuffer0;
		
	/**
	 * 
	 * @param arrayBuffer 
	 */
	function createBlobUrl(arrayBuffer : any): void;
		
	/**
	 * 
	 * @param url 
	 * @return  
	 */
	function extToEncryptExt(url : Decrypter.ExtToEncryptExt0): Decrypter.ExtToEncryptExtRet;
		
	/**
	 * 
	 */
	function readEncryptionkey(): void;
}

/**
 * The static class that handles resource loading.
 * 
 * @class ResourceHandler
 */
declare interface ResourceHandler {
		
	/**
	 * 
	 * @return  
	 */
	new (): ResourceHandler;
}


/**
 * 
 */
declare namespace ResourceHandler{
		
	/**
	 * 
	 */
	export var _reloaders : Array</* ResourceHandler._reloadersI */ any>;
		
	/**
	 * 
	 */
	export var _defaultRetryInterval : Array</* ResourceHandler._defaultRetryIntervalI */ any>;
		
	/**
	 * 
	 * @param url 
	 * @param retryMethod 
	 * @param resignMethod 
	 * @param retryInterval 
	 * @return  
	 */
	function createLoader(url : ResourceHandler.CreateLoader0, retryMethod : ResourceHandler.CreateLoader1, resignMethod : ResourceHandler.CreateLoader2, retryInterval : Array<number>): () => void;
		
	/**
	 * 
	 * @return  
	 */
	function exists(): ResourceHandler.ExistsRet;
		
	/**
	 * 
	 */
	function retry(): void;
}

/**
 * 
 */
declare namespace rpg_core.js{
	
	/**
	 * 
	 */
	interface Array {
		
		/**
		 * 
		 */
		prototype : {
						
			/**
			 * 
			 * @param array 
			 * @return  
			 */
			equals(array : any): Array.prototype.EqualsRet;
						
			/**
			 * 
			 * @return  
			 */
			clone(): Array.prototype.CloneRet;
						
			/**
			 * 
			 * @param element 
			 * @return  
			 */
			contains(element : any): Array.prototype.ContainsRet;
		}
	}
	
	/**
	 * 
	 */
	interface String {
		
		/**
		 * 
		 */
		prototype : {
						
			/**
			 * Replaces %1, %2 and so on in the string to the arguments.
			 * 
			 * @method String.prototype.format
			 * @param {Any} ...args The objects to format
			 * @return {String} A formatted string
			 * @return  
			 */
			format(): String.prototype.FormatRet;
						
			/**
			 * Makes a number string with leading zeros.
			 * 
			 * @method String.prototype.padZero
			 * @param {Number} length The length of the output string
			 * @return {String} A string with leading zeros
			 * @param length 
			 * @return  
			 */
			padZero(length : String.prototype.PadZero0): String.prototype.PadZeroRet;
						
			/**
			 * Checks whether the string contains a given string.
			 * 
			 * @method String.prototype.contains
			 * @param {String} string The string to search for
			 * @return {Boolean} True if the string contains a given string
			 * @param string 
			 * @return  
			 */
			contains(string : String.prototype.Contains0): String.prototype.ContainsRet;
		}
	}
	
	/**
	 * 
	 */
	interface Number {
		
		/**
		 * 
		 */
		prototype : {
						
			/**
			 * Returns a number whose value is limited to the given range.
			 * 
			 * @method Number.prototype.clamp
			 * @param {Number} min The lower boundary
			 * @param {Number} max The upper boundary
			 * @return {Number} A number in the range (min, max)
			 * @param min 
			 * @param max 
			 * @return  
			 */
			clamp(min : Number.prototype.Clamp0, max : Number.prototype.Clamp1): Number.prototype.ClampRet;
						
			/**
			 * Returns a modulo value which is always positive.
			 * 
			 * @method Number.prototype.mod
			 * @param {Number} n The divisor
			 * @return {Number} A modulo value
			 * @param n 
			 * @return  
			 */
			mod(n : Number.prototype.Mod0): Number.prototype.ModRet;
						
			/**
			 * Makes a number string with leading zeros.
			 * 
			 * @method Number.prototype.padZero
			 * @param {Number} length The length of the output string
			 * @return {String} A string with leading zeros
			 * @param length 
			 * @return  
			 */
			padZero(length : Number.prototype.PadZero0): Number.prototype.PadZeroRet;
		}
	}
	
	/**
	 * 
	 */
	interface Math {
				
		/**
		 * Generates a random integer in the range (0, max-1).
		 * 
		 * @static
		 * @method Math.randomInt
		 * @param {Number} max The upper boundary (excluded)
		 * @return {Number} A random integer
		 * @param max 
		 * @return  
		 */
		randomInt(max : Math.RandomInt0): Math.RandomIntRet;
	}
	
	/**
	 * 
	 */
	interface Float32Array {
	}
}
