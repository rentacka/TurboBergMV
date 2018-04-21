
using GLOBAL;
using System;
using System.Collections.Generic;

using static GLOBAL3;

public static class GLOBAL3
{
	public static bool waitForLoading;
	public static bool register;
	public static IDataActor[] sm30790328_dataActors;
	public static IDataClass[] sm30790328_dataClasses;
	public static IDataSkill[] sm30790328_dataSkills;
	public static IDataItem[] sm30790328_dataItems;
	public static IDataWeapon[] sm30790328_dataWeapons;
	public static IDataArmor[] sm30790328_dataArmors;
	public static IDataEnemy[] sm30790328_dataEnemies;
	public static IDataTroop[] sm30790328_dataTroops;
	public static IDataState[] sm30790328_dataStates;
	public static IDataAnimation[] sm30790328_dataAnimations;
	public static IDataTileset[] sm30790328_dataTilesets;
	public static IDataCommonEvent[] sm30790328_dataCommonEvents;
	public static IDataSystem sm30790328_dataSystem;
	public static IDataMapInfo[] sm30790328_dataMapInfos;
	public static IDataMap sm30790328_dataMap;
	public static Game_Temp sm30790328_gameTemp;
	public static Game_System sm30790328_gameSystem;
	public static Game_Screen sm30790328_gameScreen;
	public static Game_Timer sm30790328_gameTimer;
	public static Game_Message sm30790328_gameMessage;
	public static Game_Switches sm30790328_gameSwitches;
	public static Game_Variables sm30790328_gameVariables;
	public static Game_SelfSwitches sm30790328_gameSelfSwitches;
	public static Game_Map sm30790328_gameMap;
	public static Game_Actors sm30790328_gameActors;
	public static Game_Party sm30790328_gameParty;
	public static Game_Troop sm30790328_gameTroop;
	public static Game_Player sm30790328_gamePlayer;
	public static object varsm30790328_testEvent;
	public static string key;

		public class JsExtensions
	{
		public JsExtensions()
		{
			
		}
	}

		public class Number
	{
		protected Number()
		{
			
		}
		public float clamp(float min, float max)
		{
			throw new System.NotImplementedException();
		}
		public float mod(float n)
		{
			throw new System.NotImplementedException();
		}
	}

		public class String
	{
		protected String()
		{
			
		}
		public string format()
		{
			throw new System.NotImplementedException();
		}
		public string padZero(float length)
		{
			throw new System.NotImplementedException();
		}
		public bool contains(string @string)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Array<T>
	{
		protected Array()
		{
			
		}
		public bool equals(T array)
		{
			throw new System.NotImplementedException();
		}
		public T clone()
		{
			throw new System.NotImplementedException();
		}
		public bool contains()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Math
	{
		protected Math()
		{
			
		}
		public float randomInt(float max)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Utils
	{
		public Utils()
		{
			
		}
		public static string RPGMAKER_NAME;
		public static string RPGMAKER_VERSION;
		public static float _id;
		public static bool _supportPassiveEvent;
		public static bool isOptionValid(string name)
		{
			throw new System.NotImplementedException();
		}
		public static bool isNwjs()
		{
			throw new System.NotImplementedException();
		}
		public static bool isMobileDevice()
		{
			throw new System.NotImplementedException();
		}
		public static bool isMobileSafari()
		{
			throw new System.NotImplementedException();
		}
		public static bool isAndroidChrome()
		{
			throw new System.NotImplementedException();
		}
		public static bool canReadGameFiles()
		{
			throw new System.NotImplementedException();
		}
		public static string rgbToCssColor(float r, float g, float b)
		{
			throw new System.NotImplementedException();
		}
		public static float generateRuntimeId()
		{
			throw new System.NotImplementedException();
		}
		public static bool isSupportPassiveEvent()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IImageCacheItem
	{
		protected IImageCacheItem()
		{
			
		}
		public Bitmap bitmap;
		public float touch;
		public string key;
	}

		public class ImageCache
	{
		protected ImageCache()
		{
			
		}
		public static float limit;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void add(string key, Bitmap value)
		{
			throw new System.NotImplementedException();
		}
		public Bitmap get(string key)
		{
			throw new System.NotImplementedException();
		}
		public void reserve(string key, Bitmap value, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public void releaseReservation(float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public Bitmap getErrorBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void _truncateCache()
		{
			throw new System.NotImplementedException();
		}
		public bool _mustBeHeld(IImageCacheItem item)
		{
			throw new System.NotImplementedException();
		}
	}

		public class RequestQueue
	{
		public RequestQueue()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void enqueue(string key, Bitmap value)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void raisePriority(string key)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CacheEntry
	{
		public CacheEntry(CacheMap cache, string key, object item)
		{
			
		}
		protected CacheEntry()
		{
			
		}
		public CacheMap cache;
		public string key;
		public object item;
		public bool cached;
		public float touchTicks;
		public float touchSeconds;
		public float ttlTicks;
		public float ttlSeconds;
		public bool freedByTTL;
		public void free(bool byTTL = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public CacheEntry allocate()
		{
			throw new System.NotImplementedException();
		}
		public CacheEntry setTimeToLive(float ticks = default(float), float seconds = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool isStillAlive()
		{
			throw new System.NotImplementedException();
		}
		public void touch()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CacheMap
	{
		public CacheMap(object manager)
		{
			
		}
		protected CacheMap()
		{
			
		}

		public Dictionary<string,CacheEntry> _inner;
		public CacheEntry[] _lastRemovedEntries;
		public object manager;
		public float updateTicks;
		public float lastCheckTTL;
		public float delayCheckTTL;
		public float updateSeconds;
		public void checkTTL()
		{
			throw new System.NotImplementedException();
		}
		public object getItem(string key)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public CacheEntry setItem(string key, object item)
		{
			throw new System.NotImplementedException();
		}
		public void update(float ticks, float delta)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Point : PIXI.Point
	{
		public Point(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Point() : base()
		{
			
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Rectangle : PIXI.Rectangle
	{
		public Rectangle(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Rectangle() : base()
		{
			
		}
		public static Rectangle emptyRectangle;
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Bitmap
	{
		public Bitmap(float width = default(float), float height = default(float))
		{
			
		}
		protected Bitmap()
		{
			
		}
		public static HTMLImageElement[] _reuseImages;
		public string url;
		public PIXI.BaseTexture baseTexture;
		public HTMLCanvasElement canvas;
		public CanvasRenderingContext2D context;
		public float width;
		public float height;
		public Rectangle rect;
		public bool smooth;
		public float paintOpacity;
		public CacheEntry cacheEntry;
		public string fontFace;
		public float fontSize;
		public bool fontItalic;
		public string textColor;
		public string outlineColor;
		public float outlineWidth;
		public HTMLCanvasElement _canvas;
		public CanvasRenderingContext2D _context;
		public PIXI.BaseTexture _baseTexture;
		public HTMLImageElement _image;
		public string _url;
		public float _paintOpacity;
		public bool _smooth;
		public Function[] _loadListeners;
		public string _loadingState;
		public bool _decodeAfterRequest;
		public static Bitmap load(string url)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap snap(Stage stage)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap request(string url)
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public bool isError()
		{
			throw new System.NotImplementedException();
		}
		public void touch()
		{
			throw new System.NotImplementedException();
		}
		public void resize(float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void blt(Bitmap source, float sx, float sy, float sw, float sh, float dx, float dy, float dw = default(float), float dh = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void bltImage(Bitmap source, float sx, float sy, float sw, float sh, float dx, float dy, float dw = default(float), float dh = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string getPixel(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public string getAlphaPixel(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void clearRect(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void fillRect(float x, float y, float width, float height, String color)
		{
			throw new System.NotImplementedException();
		}
		public void fillAll(string color)
		{
			throw new System.NotImplementedException();
		}
		public void gradientFillRect(float x, float y, float width, float height, String color1, string color2, bool vertical)
		{
			throw new System.NotImplementedException();
		}
		public void drawCircle(float x, float y, float radius, string color)
		{
			throw new System.NotImplementedException();
		}
		public void drawText(string text, float x, float y, float maxWidth = default(float), float lineHeight = default(float), string align = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float measureTextWidth(string text)
		{
			throw new System.NotImplementedException();
		}
		public void adjustTone(float r, float g, float b)
		{
			throw new System.NotImplementedException();
		}
		public void rotateHue(float offset)
		{
			throw new System.NotImplementedException();
		}
		public void blur()
		{
			throw new System.NotImplementedException();
		}
		public void addLoadListener(Function listener)
		{
			throw new System.NotImplementedException();
		}
		public void checkDirty()
		{
			throw new System.NotImplementedException();
		}
		public bool isRequestOnly()
		{
			throw new System.NotImplementedException();
		}
		public bool isRequestReady()
		{
			throw new System.NotImplementedException();
		}
		public void startRequest()
		{
			throw new System.NotImplementedException();
		}
		public string _makeFontNameText()
		{
			throw new System.NotImplementedException();
		}
		public void _drawTextOutline(string text, float tx, float ty, float maxWidth)
		{
			throw new System.NotImplementedException();
		}
		public void _drawTextBody(string text, float tx, float ty, float maxWidth)
		{
			throw new System.NotImplementedException();
		}
		public void _onLoad()
		{
			throw new System.NotImplementedException();
		}
		public void _callLoadListeners()
		{
			throw new System.NotImplementedException();
		}
		public void _onError()
		{
			throw new System.NotImplementedException();
		}
		public void _setDirty()
		{
			throw new System.NotImplementedException();
		}
		public void _createCanvas(float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void _createBaseTexture(object source)
		{
			throw new System.NotImplementedException();
		}
		public void _clearImgInstance()
		{
			throw new System.NotImplementedException();
		}
		public void _renewCanvas()
		{
			throw new System.NotImplementedException();
		}
		public void _requestImage(string url)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Graphics
	{
		public Graphics()
		{
			
		}
		public static float frameCount;
		public static float BLEND_NORMAL;
		public static float BLEND_ADD;
		public static float BLEND_MULTIPLY;
		public static float BLEND_SCREEN;
		public static float width;
		public static float height;
		public static float boxWidth;
		public static float boxHeight;
		public static float scale;
		public static float _width;
		public static float _height;
		public static string _rendererType;
		public static float _boxWidth;
		public static float _boxHeight;
		public static float _scale;
		public static float _realScale;
		public static bool _errorShowed;
		public static HTMLParagraphElement _errorPrinter;
		public static HTMLCanvasElement _canvas;
		public static HTMLVideoElement _video;
		public static bool _videoUnlocked;
		public static bool _videoLoading;
		public static HTMLCanvasElement _upperCanvas;
		public static PIXI.SystemRenderer _renderer;
		public static object _fpsMeter;
		public static HTMLDivElement _modeBox;
		public static float _skipCount;
		public static float _maxSkip;
		public static bool _rendered;
		public static HTMLImageElement _loadingImage;
		public static float _loadingCount;
		public static bool _fpsMeterToggled;
		public static bool _stretchEnabled;
		public static bool _canUseDifferenceBlend;
		public static bool _canUseSaturationBlend;
		public static HTMLCanvasElement _hiddenCanvas;
		public static bool _cssFontLoading;
		public static object _fontLoaded;
		public static float _videoVolume;
		public static void initialize(float width = default(float), float height = default(float), string type = default(string))
		{
			throw new System.NotImplementedException();
		}
		public static void tickStart()
		{
			throw new System.NotImplementedException();
		}
		public static void tickEnd()
		{
			throw new System.NotImplementedException();
		}
		public static void render(Stage stage)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWebGL()
		{
			throw new System.NotImplementedException();
		}
		public static bool hasWebGL()
		{
			throw new System.NotImplementedException();
		}
		public static bool canUseDifferenceBlend()
		{
			throw new System.NotImplementedException();
		}
		public static bool canUseSaturationBlend()
		{
			throw new System.NotImplementedException();
		}
		public static void setLoadingImage(string src)
		{
			throw new System.NotImplementedException();
		}
		public static void startLoading()
		{
			throw new System.NotImplementedException();
		}
		public static void updateLoading()
		{
			throw new System.NotImplementedException();
		}
		public static void printError(string name, string message)
		{
			throw new System.NotImplementedException();
		}
		public static void showFps()
		{
			throw new System.NotImplementedException();
		}
		public static void hideFps()
		{
			throw new System.NotImplementedException();
		}
		public static void loadFont(string name, string url)
		{
			throw new System.NotImplementedException();
		}
		public static bool isFontLoaded(string name)
		{
			throw new System.NotImplementedException();
		}
		public static void playVideo(string src)
		{
			throw new System.NotImplementedException();
		}
		public static bool isVideoPlaying()
		{
			throw new System.NotImplementedException();
		}
		public static bool canPlayVideoType(string type)
		{
			throw new System.NotImplementedException();
		}
		public static float pageToCanvasX(float x)
		{
			throw new System.NotImplementedException();
		}
		public static float pageToCanvasY(float y)
		{
			throw new System.NotImplementedException();
		}
		public static bool isInsideCanvas(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public static void callGC()
		{
			throw new System.NotImplementedException();
		}
		public static bool canUseCssFontLoading()
		{
			throw new System.NotImplementedException();
		}
		public static void printLoadingError(string url)
		{
			throw new System.NotImplementedException();
		}
		public static void eraseLoadingError()
		{
			throw new System.NotImplementedException();
		}
		public static void setVideoVolume(float value)
		{
			throw new System.NotImplementedException();
		}
		public static void _setupCssFontLoading()
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchEnd(TouchEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _createAllElements()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateAllElements()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateRealScale()
		{
			throw new System.NotImplementedException();
		}
		public static string _makeErrorHtml(string name, string message)
		{
			throw new System.NotImplementedException();
		}
		public static bool _defaultStretchMode()
		{
			throw new System.NotImplementedException();
		}
		public static void _testCanvasBlendModes()
		{
			throw new System.NotImplementedException();
		}
		public static void _modifyExistingElements()
		{
			throw new System.NotImplementedException();
		}
		public static void _createErrorPrinter()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateErrorPrinter()
		{
			throw new System.NotImplementedException();
		}
		public static void _createCanvas()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateCanvas()
		{
			throw new System.NotImplementedException();
		}
		public static void _createVideo()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateVideo()
		{
			throw new System.NotImplementedException();
		}
		public static void _createUpperCanvas()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateUpperCanvas()
		{
			throw new System.NotImplementedException();
		}
		public static void _clearUpperCanvas()
		{
			throw new System.NotImplementedException();
		}
		public static void _paintUpperCanvas()
		{
			throw new System.NotImplementedException();
		}
		public static void _createRenderer()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateRenderer()
		{
			throw new System.NotImplementedException();
		}
		public static void _createFPSMeter()
		{
			throw new System.NotImplementedException();
		}
		public static void _createModeBox()
		{
			throw new System.NotImplementedException();
		}
		public static void _createGameFontLoader()
		{
			throw new System.NotImplementedException();
		}
		public static void _createFontLoader(string name)
		{
			throw new System.NotImplementedException();
		}
		public static void _centerElement(HTMLElement element)
		{
			throw new System.NotImplementedException();
		}
		public static void _disableTextSelection()
		{
			throw new System.NotImplementedException();
		}
		public static void _disableContextMenu()
		{
			throw new System.NotImplementedException();
		}
		public static void _applyCanvasFilter()
		{
			throw new System.NotImplementedException();
		}
		public static void _onVideoLoad()
		{
			throw new System.NotImplementedException();
		}
		public static void _onVideoError()
		{
			throw new System.NotImplementedException();
		}
		public static void _onVideoEnd()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateVisibility(bool videoVisible)
		{
			throw new System.NotImplementedException();
		}
		public static bool _isVideoVisible()
		{
			throw new System.NotImplementedException();
		}
		public static void _setupEventHandlers()
		{
			throw new System.NotImplementedException();
		}
		public static void _onWindowResize()
		{
			throw new System.NotImplementedException();
		}
		public static void _onKeyDown(KeyboardEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _switchFPSMeter()
		{
			throw new System.NotImplementedException();
		}
		public static void _switchStretchMode()
		{
			throw new System.NotImplementedException();
		}
		public static void _switchFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public static bool _isFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public static void _requestFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public static void _cancelFullScreen()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Input
	{
		public Input()
		{
			
		}
		public static float keyRepeatWait;
		public static float keyRepeatInterval;
		public static Dictionary<int,string> keyMapper;
		public static Dictionary<int, string> gamepadMapper;
		public static float dir4;
		public static float dir8;
		public static float date;
		public static Dictionary<string, bool> _currentState;
		public static Dictionary<string, bool> _previousState;
		public static bool[][] _gamepadStates;
		public static string _latestButton;
		public static float _pressedTime;
		public static float _dir4;
		public static float _dir8;
		public static string _preferredAxis;
		public static float _date;
		public static void initialize()
		{
			throw new System.NotImplementedException();
		}
		public static void clear()
		{
			throw new System.NotImplementedException();
		}
		public static void update()
		{
			throw new System.NotImplementedException();
		}
		public static bool isPressed(string keyName)
		{
			throw new System.NotImplementedException();
		}
		public static bool isTriggered(string keyName)
		{
			throw new System.NotImplementedException();
		}
		public static bool isRepeated(string keyName)
		{
			throw new System.NotImplementedException();
		}
		public static bool isLongPressed(string keyName)
		{
			throw new System.NotImplementedException();
		}
		public static void _wrapNwjsAlert()
		{
			throw new System.NotImplementedException();
		}
		public static void _setupEventHandlers()
		{
			throw new System.NotImplementedException();
		}
		public static void _onKeyDown(KeyboardEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static bool _shouldPreventDefault(float keyCode)
		{
			throw new System.NotImplementedException();
		}
		public static void _onKeyUp(KeyboardEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onLostFocus()
		{
			throw new System.NotImplementedException();
		}
		public static void _pollGamepads()
		{
			throw new System.NotImplementedException();
		}
		public static void _updateGamepadState(Gamepad gamepad)
		{
			throw new System.NotImplementedException();
		}
		public static void _updateDirection()
		{
			throw new System.NotImplementedException();
		}
		public static float _signX()
		{
			throw new System.NotImplementedException();
		}
		public static float _signY()
		{
			throw new System.NotImplementedException();
		}
		public static float _makeNumpadDirection(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public static bool _isEscapeCompatible(string keyName)
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDataTouchInput
	{
		protected IDataTouchInput()
		{
			
		}
		public bool triggered;
		public bool cancelled;
		public bool moved;
		public bool released;
		public float wheelX;
		public float wheelY;
	}

		public class TouchInput
	{
		public TouchInput()
		{
			
		}
		public static float keyRepeatWait;
		public static float keyRepeatInterval;
		public static float wheelX;
		public static float wheelY;
		public static float x;
		public static float y;
		public static float date;
		public static bool _mousePressed;
		public static bool _screenPressed;
		public static float _pressedTime;
		public static IDataTouchInput _events;
		public static bool _triggered;
		public static bool _cancelled;
		public static bool _moved;
		public static bool _released;
		public static float _wheelX;
		public static float _wheelY;
		public static float _x;
		public static float _y;
		public static float _date;
		public static void initialize()
		{
			throw new System.NotImplementedException();
		}
		public static void clear()
		{
			throw new System.NotImplementedException();
		}
		public static void update()
		{
			throw new System.NotImplementedException();
		}
		public static bool isPressed()
		{
			throw new System.NotImplementedException();
		}
		public static bool isTriggered()
		{
			throw new System.NotImplementedException();
		}
		public static bool isRepeated()
		{
			throw new System.NotImplementedException();
		}
		public static bool isLongPressed()
		{
			throw new System.NotImplementedException();
		}
		public static bool isCancelled()
		{
			throw new System.NotImplementedException();
		}
		public static bool isMoved()
		{
			throw new System.NotImplementedException();
		}
		public static bool isReleased()
		{
			throw new System.NotImplementedException();
		}
		public static void _setupEventHandlers()
		{
			throw new System.NotImplementedException();
		}
		public static void _onMouseDown(MouseEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onLeftButtonDown(MouseEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onMiddleButtonDown(MouseEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onRightButtonDown(MouseEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onMouseMove(MouseEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onMouseUp(MouseEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onWheel(WheelEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchStart(TouchEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchMove(TouchEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchEnd(TouchEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchCancel(TouchEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onPointerDown(PointerEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void _onTrigger(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public static void _onCancel(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public static void _onMove(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public static void _onRelease(float x, float y)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite : PIXI.Sprite
	{
		public Sprite(Bitmap bitmap = default(Bitmap)) : base()
		{
			
		}
		protected Sprite() : base()
		{
			
		}
		public static float _counter;
		public Bitmap bitmap;
		public float width;
		public float height;
		public float opacity;
		public Bitmap _bitmap;
		public Rectangle _frame;
		public Rectangle _realFrame;
		public Point _offset;
		public float[] _blendColor;
		public float[] _colorTone;
		public HTMLCanvasElement _canvas;
		public CanvasRenderingContext2D _context;
		public PIXI.BaseTexture _tintTexture;
		public void initialize(Bitmap bitmap = default(Bitmap))
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void move(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void setFrame(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public float[] getBlendColor()
		{
			throw new System.NotImplementedException();
		}
		public void setBlendColor(float[] color)
		{
			throw new System.NotImplementedException();
		}
		public float[] getColorTone()
		{
			throw new System.NotImplementedException();
		}
		public void setColorTone(float[] tone)
		{
			throw new System.NotImplementedException();
		}
		public void _onBitmapLoad(Bitmap bitmapLoaded)
		{
			throw new System.NotImplementedException();
		}
		public void _refresh()
		{
			throw new System.NotImplementedException();
		}
		public bool _isInBitmapRect(float x, float y, float w, float h)
		{
			throw new System.NotImplementedException();
		}
		public bool _needsTint()
		{
			throw new System.NotImplementedException();
		}
		public void _createTinter(float w, float h)
		{
			throw new System.NotImplementedException();
		}
		public void _executeTint(float x, float y, float w, float h)
		{
			throw new System.NotImplementedException();
		}
		public void _renderCanvas_PIXI(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _renderWebGL_PIXI(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public new void _renderCanvas(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _speedUpCustomBlendModes(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public new void _renderWebGL(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Tilemap : PIXI.Container
	{
		public Tilemap() : base()
		{
			
		}
		public float width;
		public float height;
		public float tileWidth;
		public float tileHeight;
		public Bitmap[] bitmaps;
		public Point origin;
		public Dictionary<float,bool> flags;
		public float animationCount;
		public float animationFrame;
		public bool horizontalWrap;
		public bool verticalWrap;
		public float _margin;
		public float _width;
		public float _height;
		public float _tileWidth;
		public float _tileHeight;
		public float _mapWidth;
		public float _mapHeight;
		public float[] _mapData;
		public float _layerWidth;
		public float _layerHeight;
		public float[][][][] _lastTiles;
		public bool _needsRepaint;
		public float _lastAnimationFrame;
		public float _lastStartX;
		public float _lastStartY;
		public bool _frameUpdated;
		public Bitmap _lowerBitmap;
		public Bitmap _upperBitmap;
		public Sprite _lowerLayer;
		public Sprite _upperLayer;
		public static float TILE_ID_B;
		public static float TILE_ID_C;
		public static float TILE_ID_D;
		public static float TILE_ID_E;
		public static float TILE_ID_A5;
		public static float TILE_ID_A1;
		public static float TILE_ID_A2;
		public static float TILE_ID_A3;
		public static float TILE_ID_A4;
		public static float TILE_ID_MAX;
		public static float[][][] FLOOR_AUTOTILE_TABLE;
		public static float[][][] WALL_AUTOTILE_TABLE;
		public static float[][][] WATERFALL_AUTOTILE_TABLE;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void setData(float width, float height, float[] data)
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void refreshTileset()
		{
			throw new System.NotImplementedException();
		}
		public void updateTransform()
		{
			throw new System.NotImplementedException();
		}
		public void _createLayers()
		{
			throw new System.NotImplementedException();
		}
		public void _updateLayerPositions(float startX, float startY)
		{
			throw new System.NotImplementedException();
		}
		public void _paintAllTiles(float startX, float startY)
		{
			throw new System.NotImplementedException();
		}
		public void _paintTiles(float startX, float startY, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float[] _readLastTiles(float i, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void _writeLastTiles(float i, float x, float y, float[] tiles)
		{
			throw new System.NotImplementedException();
		}
		public void _drawTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public void _drawNormalTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public void _drawAutotile(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public void _drawTableEdge(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public void _drawShadow(Bitmap bitmap, float shadowBits, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public float _readMapData(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public bool _isHigherTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public bool _isTableTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public bool _isOverpassPosition(float mx, float my)
		{
			throw new System.NotImplementedException();
		}
		public void _sortChildren()
		{
			throw new System.NotImplementedException();
		}
		public float _compareChildOrder(Sprite a, Sprite b)
		{
			throw new System.NotImplementedException();
		}
		public static bool isVisibleTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isAutotile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static float getAutotileKind(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static float getAutotileShape(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static float makeAutotileId(float kind, float shape)
		{
			throw new System.NotImplementedException();
		}
		public static bool isSameKindTile(float tileID1, float tileID2)
		{
			throw new System.NotImplementedException();
		}
		public static bool isTileA1(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isTileA2(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isTileA3(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isTileA4(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isTileA5(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWaterTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWaterfallTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isGroundTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isShadowingTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isRoofTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWallTopTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWallSideTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWallTile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isFloorTypeAutotile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWallTypeAutotile(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWaterfallTypeAutotile(float tileId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ShaderTilemap : Tilemap
	{
		public ShaderTilemap() : base()
		{
			
		}
		public bool roundPixels;
		public float animationFrame;
		public PIXI.tilemap.ZLayer lowerZLayer;
		public PIXI.tilemap.ZLayer upperZLayer;
		public float _lastBitmapLength;
		public object renderer;
		public float dx;
		public float dy;
		public void renderCanvas(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void renderWebGL(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void refreshTileset()
		{
			throw new System.NotImplementedException();
		}
		public void updateTransform()
		{
			throw new System.NotImplementedException();
		}
		public object _hackRenderer(object renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _createLayers()
		{
			throw new System.NotImplementedException();
		}
		public void _updateLayerPositions(float startX, float startY)
		{
			throw new System.NotImplementedException();
		}
		public void _paintAllTiles(float startX, float startY)
		{
			throw new System.NotImplementedException();
		}
		public void _paintTiles(float startX, float startY, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void _drawTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public float _drawTile(PIXI.tilemap.RectTileLayer layer)
		{
			throw new System.NotImplementedException();
		}
		public void _drawNormalTile(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public float _drawNormalTile(PIXI.tilemap.RectTileLayer layer)
		{
			throw new System.NotImplementedException();
		}
		public void _drawAutotile(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public float _drawAutotile(PIXI.tilemap.RectTileLayer layer)
		{
			throw new System.NotImplementedException();
		}
		public void _drawTableEdge(Bitmap bitmap, float tileId, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public float _drawTableEdge(PIXI.tilemap.RectTileLayer layer)
		{
			throw new System.NotImplementedException();
		}
		public void _drawShadow(Bitmap bitmap, float shadowBits, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public float _drawShadow(PIXI.tilemap.RectTileLayer layer)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TilingSprite : PIXI.extras.TilingSprite
	{
		public TilingSprite(Bitmap bitmap) : base()
		{
			
		}
		protected TilingSprite() : base()
		{
			
		}
		public Bitmap bitmap;
		public float opacity;
		public float spriteId;
		public Point origin;
		public Bitmap _bitmap;
		public float _width;
		public float _height;
		public Rectangle _frame;
		public void _renderCanvas_PIXI(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _renderWebGL_PIXI(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _renderCanvas(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _renderWebGL(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _onBitmapLoad()
		{
			throw new System.NotImplementedException();
		}
		public void _refresh()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(Bitmap bitmap)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void move(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setFrame(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void updateTransform()
		{
			throw new System.NotImplementedException();
		}
		public void updateTransformTS()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ScreenSprite : PIXI.Container
	{
		public ScreenSprite() : base()
		{
			
		}
		public static bool YEPWarned;
		public PIXI.Graphics _graphics;
		public float _red;
		public float _green;
		public float _blue;
		public string _colorText;
		public float opacity;
		public float anchor;
		public float blendMode;
		public static void warnYep()
		{
			throw new System.NotImplementedException();
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void setBlack()
		{
			throw new System.NotImplementedException();
		}
		public void setWhite()
		{
			throw new System.NotImplementedException();
		}
		public void setColor(float r = default(float), float g = default(float), float b = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window : PIXI.Container
	{
		public Window() : base()
		{
			
		}
		public bool _isWindow;
		public Bitmap _windowskin;
		public float _width;
		public float _height;
		public Rectangle _cursorRect;
		public float _openness;
		public float _animationCount;
		public float _padding;
		public float _margin;
		public float[] _colorTone;
		public PIXI.Container _windowSpriteContainer;
		public Sprite _windowBackSprite;
		public Sprite _windowCursorSprite;
		public Sprite _windowFrameSprite;
		public Sprite _windowContentsSprite;
		public Sprite[] _windowArrowSprites;
		public Sprite _windowPauseSignSprite;
		public bool active;
		public Bitmap windowskin;
		public Bitmap contents;
		public float width;
		public float height;
		public float padding;
		public float margin;
		public float opacity;
		public float backOpacity;
		public float contentsOpacity;
		public float openness;
		public Point origin;
		public bool downArrowVisible;
		public bool upArrowVisible;
		public bool pause;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void move(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool isOpen()
		{
			throw new System.NotImplementedException();
		}
		public bool isClosed()
		{
			throw new System.NotImplementedException();
		}
		public void setCursorRect(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setTone(float r, float g, float b)
		{
			throw new System.NotImplementedException();
		}
		public PIXI.DisplayObject addChildToBack(PIXI.DisplayObject child)
		{
			throw new System.NotImplementedException();
		}
		public void updateTransform()
		{
			throw new System.NotImplementedException();
		}
		public void _createAllParts()
		{
			throw new System.NotImplementedException();
		}
		public void _onWindowskinLoad()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshAllParts()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshBack()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshFrame()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshCursor()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshContents()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshArrows()
		{
			throw new System.NotImplementedException();
		}
		public void _refreshPauseSign()
		{
			throw new System.NotImplementedException();
		}
		public void _updateCursor()
		{
			throw new System.NotImplementedException();
		}
		public void _updateContents()
		{
			throw new System.NotImplementedException();
		}
		public void _updateArrows()
		{
			throw new System.NotImplementedException();
		}
		public void _updatePauseSign()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WindowLayer : PIXI.Container
	{
		public WindowLayer() : base()
		{
			
		}
		public static PIXI.filters.VoidFilter voidFilter;
		public float _width;
		public float _height;
		public HTMLCanvasElement _tempCanvas;
		public float[] _translationMatrix;
		public PIXI.Graphics _windowMask;
		public PIXI.Rectangle _windowRect;
		public Sprite _renderSprite;
		public float width;
		public float height;
		public PIXI.Rectangle filterArea;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void move(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void renderCanvas(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void renderWebGL(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void onRemoveAsAChild()
		{
			throw new System.NotImplementedException();
		}
		public Window _canvasClearWindowRect(PIXI.CanvasRenderer renderSession)
		{
			throw new System.NotImplementedException();
		}
		public void _maskWindow(Window window, PIXI.Point shift)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Weather : PIXI.Container
	{
		public Weather() : base()
		{
			
		}
		public float _width;
		public float _height;
		public Sprite[] _sprites;
		public Bitmap _rainBitmap;
		public Bitmap _stormBitmap;
		public Bitmap _snowBitmap;
		public ScreenSprite _dimmerSprite;
		public string type;
		public float power;
		public Point origin;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void _createBitmaps()
		{
			throw new System.NotImplementedException();
		}
		public void _createDimmer()
		{
			throw new System.NotImplementedException();
		}
		public void _updateDimmer()
		{
			throw new System.NotImplementedException();
		}
		public void _updateAllSprites()
		{
			throw new System.NotImplementedException();
		}
		public void _addSprite()
		{
			throw new System.NotImplementedException();
		}
		public void _removeSprite()
		{
			throw new System.NotImplementedException();
		}
		public void _updateSprite(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void _updateRainSprite(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void _updateStormSprite(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void _updateSnowSprite(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void _rebornSprite(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ToneFilter : PIXI.filters.ColorMatrixFilter
	{
		public ToneFilter() : base()
		{
			
		}
		public void adjustHue(float value)
		{
			throw new System.NotImplementedException();
		}
		public void adjustSaturation(float value = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void adjustTone(float r = default(float), float g = default(float), float b = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ToneSprite : PIXI.Container
	{
		public ToneSprite() : base()
		{
			
		}
		public float _red;
		public float _green;
		public float _blue;
		public float _gray;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void setTone(float r = default(float), float g = default(float), float b = default(float), float gray = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void _renderCanvas(PIXI.CanvasRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
		public void _renderWebGL(PIXI.WebGLRenderer renderer)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Stage : PIXI.Container
	{
		public Stage() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
	}

    public class WebAudio
	{
		public WebAudio(string url)
		{
			
		}
		protected WebAudio()
		{
			
		}
		public static float _masterVolume;
		public static AudioContext _context;
		public static GainNode _masterGainNode;
		public static bool _initialized;
		public static bool _unlocked;
		public static bool _canPlayOgg;
		public static bool _canPlayM4a;
		public static ResourceHandler _standAlone;
		public object ResourceHandler;
		public string url;
		public float volume;
		public float pitch;
		public float pan;
		public string _url;
		public AudioBuffer _buffer;
		public AudioBufferSourceNode _sourceNode;
		public GainNode _gainNode;
		public PannerNode _pannerNode;
		public float _totalTime;
		public float _sampleRate;
		public float _loopStart;
		public float _loopLength;
		public float _startTime;
		public float _volume;
		public float _pitch;
		public float _pan;
		public float _endTimer;
		public Function[] _loadListeners;
		public Function[] _stopListeners;
		public bool _hasError;
		public bool _autoPlay;
		public static bool initialize(bool noAudio)
		{
			throw new System.NotImplementedException();
		}
		public void initialize(string url)
		{
			throw new System.NotImplementedException();
		}
		public static bool canPlayOgg()
		{
			throw new System.NotImplementedException();
		}
		public static bool canPlayM4a()
		{
			throw new System.NotImplementedException();
		}
		public static void setMasterVolume(float value)
		{
			throw new System.NotImplementedException();
		}
		public static void _createContext()
		{
			throw new System.NotImplementedException();
		}
		public static void _detectCodecs()
		{
			throw new System.NotImplementedException();
		}
		public static void _createMasterGainNode()
		{
			throw new System.NotImplementedException();
		}
		public static void _setupEventHandlers()
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchStart()
		{
			throw new System.NotImplementedException();
		}
		public static void _onVisibilityChange()
		{
			throw new System.NotImplementedException();
		}
		public static void _onHide()
		{
			throw new System.NotImplementedException();
		}
		public static void _onShow()
		{
			throw new System.NotImplementedException();
		}
		public static bool _shouldMuteOnHide()
		{
			throw new System.NotImplementedException();
		}
		public static void _fadeIn(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void _fadeOut(float duration)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public bool isError()
		{
			throw new System.NotImplementedException();
		}
		public bool isPlaying()
		{
			throw new System.NotImplementedException();
		}
		public void play(bool loop, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public void fadeIn(float duration)
		{
			throw new System.NotImplementedException();
		}
		public void fadeOut(float duration)
		{
			throw new System.NotImplementedException();
		}
		public float seek()
		{
			throw new System.NotImplementedException();
		}
		public void addLoadListener(Function listener)
		{
			throw new System.NotImplementedException();
		}
		public void addStopListener(Function listener)
		{
			throw new System.NotImplementedException();
		}
		public void _load(string url)
		{
			throw new System.NotImplementedException();
		}
		public void _onXhrLoad(XMLHttpRequest xhr)
		{
			throw new System.NotImplementedException();
		}
		public void _startPlaying(bool loop, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void _createNodes()
		{
			throw new System.NotImplementedException();
		}
		public void _connectNodes()
		{
			throw new System.NotImplementedException();
		}
		public void _removeNodes()
		{
			throw new System.NotImplementedException();
		}
		public void _createEndTimer()
		{
			throw new System.NotImplementedException();
		}
		public void _removeEndTimer()
		{
			throw new System.NotImplementedException();
		}
		public void _updatePanner()
		{
			throw new System.NotImplementedException();
		}
		public void _onLoad()
		{
			throw new System.NotImplementedException();
		}
		public void _readLoopComments(Uint8Array array)
		{
			throw new System.NotImplementedException();
		}
		public void _readOgg(Uint8Array array)
		{
			throw new System.NotImplementedException();
		}
		public void _readMp4(Uint8Array array)
		{
			throw new System.NotImplementedException();
		}
		public void _readMetaData(Uint8Array array, float index, float size)
		{
			throw new System.NotImplementedException();
		}
		public void _readLittleEndian(Uint8Array array, float index)
		{
			throw new System.NotImplementedException();
		}
		public void _readBigEndian(Uint8Array array, float index)
		{
			throw new System.NotImplementedException();
		}
		public void _readFourCharacters(Uint8Array array, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Html5Audio
	{
		public Html5Audio()
		{
			
		}
		public static string _url;
		public static bool _initialized;
		public static bool _unlocked;
		public static HTMLAudioElement _audioElement;
		public static float _gainTweenInterval;
		public static float _tweenGain;
		public static float _tweenTargetGain;
		public static float _tweenGainStep;
		public static string _staticSePath;
		public static bool _buffered;
		public static bool _hasError;
		public static bool _autoPlay;
		public static bool _isLoading;
		public static Function[] _loadListeners;
		public static float _volume;
		public static string url;
		public static string volume;
		public static void setup(string url)
		{
			throw new System.NotImplementedException();
		}
		public static bool initialize()
		{
			throw new System.NotImplementedException();
		}
		public static void clear()
		{
			throw new System.NotImplementedException();
		}
		public static void setStaticSe(string url)
		{
			throw new System.NotImplementedException();
		}
		public static void _setupEventHandlers()
		{
			throw new System.NotImplementedException();
		}
		public static void _onTouchStart()
		{
			throw new System.NotImplementedException();
		}
		public static void _onVisibilityChange()
		{
			throw new System.NotImplementedException();
		}
		public static void _onLoadedData()
		{
			throw new System.NotImplementedException();
		}
		public static void _onError()
		{
			throw new System.NotImplementedException();
		}
		public static void _onEnded()
		{
			throw new System.NotImplementedException();
		}
		public static void _onHide()
		{
			throw new System.NotImplementedException();
		}
		public static void _onShow()
		{
			throw new System.NotImplementedException();
		}
		public static bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public static bool isError()
		{
			throw new System.NotImplementedException();
		}
		public static bool isPlaying()
		{
			throw new System.NotImplementedException();
		}
		public static void play(bool loop, float offset)
		{
			throw new System.NotImplementedException();
		}
		public static void stop()
		{
			throw new System.NotImplementedException();
		}
		public static void fadeIn(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void fadeOut(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static float seek()
		{
			throw new System.NotImplementedException();
		}
		public static void addLoadListener(Function listener)
		{
			throw new System.NotImplementedException();
		}
		public static void _load(string url)
		{
			throw new System.NotImplementedException();
		}
		public static void _startPlaying(bool loop, float offset)
		{
			throw new System.NotImplementedException();
		}
		public static void _onLoad()
		{
			throw new System.NotImplementedException();
		}
		public static void _startGainTween(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void _applyTweenValue(float volume)
		{
			throw new System.NotImplementedException();
		}
	}

		public class JsonEx
	{
		public JsonEx()
		{
			
		}
		public static float maxDepth;
				public object @object;
		public static float _id;
		public object value;
		public object[] circular;
		public float depth;
		public object registry;
		public object prototype;
		public static string stringify(object @object)
		{
			throw new System.NotImplementedException();
		}
		public static object parse(string json)
		{
			throw new System.NotImplementedException();
		}
		public static object makeDeepCopy(object @object)
		{
			throw new System.NotImplementedException();
		}
		public static object _encode(object value, object[] circular, float depth)
		{
			throw new System.NotImplementedException();
		}
		public static object _decode(object value, object[] circular, object registry)
		{
			throw new System.NotImplementedException();
		}
		public static object _getConstructorName(object value)
		{
			throw new System.NotImplementedException();
		}
		public static object _resetPrototype(object value, object prototype)
		{
			throw new System.NotImplementedException();
		}
		public static float _generateId()
		{
			throw new System.NotImplementedException();
		}
		public static void _restoreCircularReference(object[] circulars)
		{
			throw new System.NotImplementedException();
		}
		public static void _linkCircularReference(object contents, object[] circulars, object[] registry)
		{
			throw new System.NotImplementedException();
		}
		public static void _cleanMetadata(object @object)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Decrypter
	{
		public Decrypter()
		{
			
		}
		public static bool hasEncryptedImages;
		public static bool hasEncryptedAudio;
		public static string SIGNATURE;
		public static string VER;
		public static string REMAIN;
		public static object[] _requestImgFile;
		public static float _headerlength;
		public static float _xhrOk;
		public static string _encryptionKey;
		public static string[] _ignoreList;
		public static bool checkImgIgnore(string url)
		{
			throw new System.NotImplementedException();
		}
		public static void decryptImg(string url, Bitmap bitmap)
		{
			throw new System.NotImplementedException();
		}
		public static void decryptHTML5Audio(string url, IAudioObject bgm, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static ArrayBuffer cutArrayHeader(ArrayBuffer arrayBuffer, float length)
		{
			throw new System.NotImplementedException();
		}
		public static ArrayBuffer decryptArrayBuffer(ArrayBuffer arrayBuffer)
		{
			throw new System.NotImplementedException();
		}
		public static string createBlobUrl(ArrayBuffer arrayBuffer)
		{
			throw new System.NotImplementedException();
		}
		public static string extToEncryptExt(string url)
		{
			throw new System.NotImplementedException();
		}
		public static void readEncryptionkey()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ResourceHandler
	{
		public ResourceHandler()
		{
			
		}
		public static Function[] _reloaders;
		public static float[] _defaultRetryInterval;
		public static void createLoader(string url, Function retryMethod, Function resignMethod, float retryInterval)
		{
			throw new System.NotImplementedException();
		}
		public static bool exists()
		{
			throw new System.NotImplementedException();
		}
		public static void retry()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDataSound
	{
		protected IDataSound()
		{
			
		}
		public string name;
		public float pan;
		public float pitch;
		public float volume;
	}

		public class IDataTrait
	{
		protected IDataTrait()
		{
			
		}
		public float code;
		public float dataId;
		public float value;
	}

		public class IDataEffect
	{
		protected IDataEffect()
		{
			
		}
		public float code;
		public float dataId;
		public float value1;
		public float value2;
	}

		public class IDataAction
	{
		protected IDataAction()
		{
			
		}
		public float conditionParam1;
		public float conditionParam2;
		public float conditionType;
		public float rating;
		public float skillId;
	}

		public class IDataList
	{
		protected IDataList()
		{
			
		}
		public float code;
		public float indent;
		public float[] parameters;
	}

		public class IDataMapEventPageList : IDataList
	{
		protected IDataMapEventPageList() : base()
		{
			
		}
		public object[] parameters;
	}

		public class IDataMoveRouteCommand
	{
		protected IDataMoveRouteCommand()
		{
			
		}
		public float code;
		public float[] parameters;
	}

		public class IDataMoveRoute
	{
		protected IDataMoveRoute()
		{
			
		}
		public IDataMoveRouteCommand[] list;
		public bool repeat;
		public bool skippable;
		public bool wait;
	}

		public class IDataActor
	{
		protected IDataActor()
		{
			
		}
		public float id;
		public string battlerName;
		public float characterIndex;
		public string characterName;
		public float classId;
		public float[] equips;
		public float faceIndex;
		public string faceName;
		public IDataTrait[] traits;
		public float initialLevel;
		public float maxLevel;
		public string name;
		public string nickname;
		public string note;
		public string profile;
		public object meta;
	}

		public class IDataClass
	{
		protected IDataClass()
		{
			
		}
		public float id;
		public float[] expParams;
		public IDataTrait[] traits;
		public Learnings_0_[] learnings;
		public string name;
		public string note;
				public float[][] @params;
		public object meta;

				public class Learnings_0_
		{
			public float level;
			public string note;
			public float skillId;
		}
	}

		public class IDataSkill
	{
		protected IDataSkill()
		{
			
		}
		public float id;
		public float animationId;
		public Damage_0_ damage;
		public string description;
		public IDataEffect[] effects;
		public float hitType;
		public float iconIndex;
		public string message1;
		public string message2;
		public float mpCost;
		public string name;
		public string note;
		public float occasion;
		public float repeats;
		public float requiredWtypeId1;
		public float requiredWtypeId2;
		public float scope;
		public float speed;
		public float stypeId;
		public float successRate;
		public float tpCost;
		public float tpGain;
		public object meta;

				public class Damage_0_
		{
			public bool critical;
			public float elementId;
			public string formula;
			public float type;
			public float variance;
		}
	}

		public class IDataAllItem
	{
		protected IDataAllItem()
		{
			
		}
		public float id;
		public string description;
		public string name;
		public string note;
		public float iconIndex;
		public float price;
		public object meta;
	}

		public class IDataItem : IDataAllItem
	{
		protected IDataItem() : base()
		{
			
		}
		public float animationId;
		public bool consumable;
		public Damage_1_ damage;
		public IDataEffect[] effects;
		public float hitType;
		public float itypeId;
		public float occasion;
		public float repeats;
		public float scope;
		public float speed;
		public float successRate;
		public float tpGain;

				public class Damage_1_
		{
			public bool critical;
			public float elementId;
			public string formula;
			public float type;
			public float variance;
		}
	}

		public class IDataEquipItem : IDataAllItem
	{
		protected IDataEquipItem() : base()
		{
			
		}
		public float etypeId;
		public IDataTrait[] traits;
				public float[] @params;
	}

		public class IDataWeapon : IDataEquipItem
	{
		protected IDataWeapon() : base()
		{
			
		}
		public float animationId;
		public float wtypeId;
	}

		public class IDataArmor : IDataEquipItem
	{
		protected IDataArmor() : base()
		{
			
		}
		public float atypeId;
	}

		public class IDataDropItem
	{
		protected IDataDropItem()
		{
			
		}
		public float kind;
		public float dataId;
		public float denominator;
	}

		public class IDataEnemy
	{
		protected IDataEnemy()
		{
			
		}
		public float id;
		public IDataAction[] actions;
		public float battlerHue;
		public string battlerName;
		public IDataDropItem[] dropItems;
		public float exp;
		public IDataTrait[] traits;
		public float gold;
		public string name;
		public string note;
				public float[] @params;
		public object meta;
	}

		public class IDataPage
	{
		protected IDataPage()
		{
			
		}
		public Conditions_0_ conditions;
		public List_0_[] list;
		public float span;

				public class Conditions_0_
		{
			public float actorHP;
			public float actorId;
			public bool actorValid;
			public float enemyHp;
			public float enemyIndex;
			public bool enemyValid;
			public float switchId;
			public bool switchValid;
			public float turnA;
			public float turnB;
			public bool turnEnding;
			public bool turnValid;
		}

				public class List_0_
		{
			public float code;
			public float indent;
			public float[] parameters;
		}
	}

		public class IDataTroop
	{
		protected IDataTroop()
		{
			
		}
		public float id;
		public Members_0_[] members;
		public string name;
		public IDataPage[] pages;
		public object meta;

				public class Members_0_
		{
			public float enemyId;
			public float x;
			public float y;
			public bool hidden;
		}
	}

		public class IDataState
	{
		protected IDataState()
		{
			
		}
		public float id;
		public float autoRemovalTiming;
		public float chanceByDamage;
		public float iconIndex;
		public float maxTurns;
		public string message1;
		public string message2;
		public string message3;
		public string message4;
		public float minTurns;
		public float motion;
		public string name;
		public string note;
		public float overlay;
		public float priority;
		public bool releaseByDamage;
		public bool removeAtBattleEnd;
		public bool removeByDamage;
		public bool removeByRestriction;
		public bool removeByWalking;
		public float restriction;
		public float stepsToRemove;
		public IDataTrait[] traits;
	}

		public class IDataAnimationTiming
	{
		protected IDataAnimationTiming()
		{
			
		}
		public float[] flashColor;
		public float flashDuration;
		public float flashScope;
		public float frame;
		public IDataSound se;
	}

		public class IDataAnimation
	{
		protected IDataAnimation()
		{
			
		}
		public float id;
		public float animation1Hue;
		public string animation1Name;
		public float animation2Hue;
		public string animation2Name;
		public float[][][] frames;
		public string name;
		public float position;
		public IDataAnimationTiming[] timings;
		public object meta;
	}

		public class IDataTileset
	{
		protected IDataTileset()
		{
			
		}
		public float id;
		public float[] flags;
		public float mode;
		public string name;
		public string note;
		public string[] tilesetNames;
		public object meta;
	}

		public class IDataCommonEvent
	{
		protected IDataCommonEvent()
		{
			
		}
		public float id;
		public IDataList[] list;
		public string name;
		public float switchId;
		public float trigger;
		public object meta;
	}

		public class IVehicle
	{
		protected IVehicle()
		{
			
		}
		public IDataSound bgm;
		public float characterIndex;
		public string characterName;
		public float startMapId;
		public float startX;
		public float startY;
	}

		public class IDataSystem
	{
		protected IDataSystem()
		{
			
		}
		public IVehicle airship;
		public string[] armorTypes;
		public Dictionary<string,IMotion>[] attackMotions;
		public IDataSound battleBgm;
		public string battleback1Name;
		public string battleback2Name;
		public float battlerHue;
		public string battlerName;
		public IVehicle boat;
		public string currencyUnit;
		public IDataSound defeatMe;
		public float editMapId;
		public string[] elements;
		public string[] equipTypes;
		public string gameTitle;
		public IDataSound gameoverMe;
		public string locale;
		public float[] magicSkills;
		public bool[] menuCommands;
		public bool optDisplayTp;
		public bool optDrawTitle;
		public bool optExtraExp;
		public bool optFloorDeath;
		public bool optFollowers;
		public bool optSideView;
		public bool optSlipDeath;
		public bool optTransparent;
		public float[] partyMembers;
		public IVehicle ship;
		public string[] skillTypes;
		public IDataSound[] sounds;
		public float startMapId;
		public float startX;
		public float startY;
		public string[] switches;
		public Terms_0_ terms;
		public TestBattlers_0_[] testBattlers;
		public float testTroopId;
		public string title1Name;
		public string title2Name;
		public IDataSound titleBgm;
		public string[] variables;
		public float versionId;
		public IDataSound victoryMe;
		public string weaponTypes;
		public float[] windowTone;
		public object meta;

				public class AttackMotions_0_
		{
			public float type;
			public float weaponImageId;
		}

				public class Messages_0_
		{
			public string possession;
			public string expTotal;
			public string expNext;
			public string saveMessage;
			public string loadMessage;
			public string file;
			public string partyName;
			public string emerge;
			public string preemptive;
			public string surprise;
			public string escapeStart;
			public string escapeFailure;
			public string victory;
			public string defeat;
			public string obtainExp;
			public string obtainGold;
			public string obtainItem;
			public string levelUp;
			public string obtainSkill;
			public string useItem;
			public string criticalToEnemy;
			public string criticalToActor;
			public string actorDamage;
			public string actorRecovery;
			public string actorGain;
			public string actorLoss;
			public string actorDrain;
			public string actorNoDamage;
			public string actorNoHit;
			public string enemyDamage;
			public string enemyRecovery;
			public string enemyGain;
			public string enemyLoss;
			public string enemyDrain;
			public string enemyNoDamage;
			public string enemyNoHit;
			public string evasion;
			public string magicEvasion;
			public string magicReflection;
			public string counterAttack;
			public string substitute;
			public string buffAdd;
			public string debuffAdd;
			public string buffRemove;
			public string actionFailure;
			public string bgmVolume;
			public string bgsVolume;
			public string meVolume;
			public string seVolume;
			public string alwaysDash;
			public string commandRemember;
		}

				public class Terms_0_
		{
			public string[] basic;
			public string[] commands;
			public string[] @params;
			public Messages_0_ messages;
		}

				public class TestBattlers_0_
		{
			public float actorId;
			public float[] equips;
			public float level;
		}
	}

		public class IDataMapInfo
	{
		protected IDataMapInfo()
		{
			
		}
		public float id;
		public bool expanded;
		public string name;
		public float order;
		public float parentId;
		public float scrollX;
		public float scrollY;
		public object meta;
	}

		public class IDataEncounterList
	{
		protected IDataEncounterList()
		{
			
		}
		public float[] regionSet;
		public float troopId;
		public float weight;
	}

		public class IDataMapEventPage
	{
		protected IDataMapEventPage()
		{
			
		}
		public Conditions_1_ conditions;
		public bool directionFix;
		public Image_0_ image;
		public IDataMapEventPageList[] list;
		public float moveFrequency;
		public MoveRoute_0_ moveRoute;
		public float moveSpeed;
		public float moveType;
		public float priorityType;
		public bool stepAnime;
		public bool through;
		public float trigger;
		public bool walkAnime;

				public class Conditions_1_
		{
			public float actorId;
			public bool actorValid;
			public float itemId;
			public bool itemValid;
			public string selfSwitchCh;
			public bool selfSwitchValid;
			public float switch1Id;
			public bool switch1Valid;
			public float switch2Id;
			public bool switch2Valid;
			public float variableId;
			public bool variableValid;
			public float variableValue;
		}

				public class Image_0_
		{
			public float tileId;
			public string characterName;
			public float direction;
			public float pattern;
			public float characterIndex;
		}

				public class List_1_
		{
			public float code;
			public float[] parameters;
		}

				public class MoveRoute_0_
		{
			public List_1_[] list;
			public bool repeat;
			public bool skippable;
			public bool wait;
		}
	}

		public class IDataMapEvent
	{
		protected IDataMapEvent()
		{
			
		}
		public float id;
		public string name;
		public string note;
		public IDataMapEventPage[] pages;
	}

		public class IDataMap
	{
		protected IDataMap()
		{
			
		}
		public bool autoplayBgm;
		public bool autoplayBgs;
		public string battleback1Name;
		public string battleback2Name;
		public IDataSound bgm;
		public IDataSound bgs;
		public bool disableDashing;
		public string displayName;
		public IDataEncounterList[] encounterList;
		public float encounterStep;
		public float height;
		public string note;
		public bool parallaxLoopX;
		public bool parallaxLoopY;
		public string parallaxName;
		public bool parallaxShow;
		public float parallaxSx;
		public float parallaxSy;
		public float scrollType;
		public bool specifyBattleback;
		public float tilesetId;
		public float width;
		public float[] data;
		public IDataMapEvent[] events;
		public object meta;
	}

		public class ISavefileInfo
	{
		protected ISavefileInfo()
		{
			
		}
		public float globalId;
		public string title;
		public object characters;
		public object faces;
		public string playtime;
		public float timestamp;
	}

		public class ISaveContents
	{
		protected ISaveContents()
		{
			
		}
		public Game_System system;
		public Game_Screen screen;
		public Game_Timer timer;
		public Game_Switches switches;
		public Game_Variables variables;
		public Game_SelfSwitches selfSwitches;
		public Game_Actors actors;
		public Game_Party party;
		public Game_Map map;
		public Game_Player player;
	}

		public class DataManager
	{
		public DataManager()
		{
			
		}
		public static float _globalId;
		public static float _lastAccessedId;
		public static string _errorUrl;
		public static _databaseFiles_0_[] _databaseFiles;
		public static void loadDatabase()
		{
			throw new System.NotImplementedException();
		}
		public static void loadDataFile(string name, string src)
		{
			throw new System.NotImplementedException();
		}
		public static bool isDatabaseLoaded()
		{
			throw new System.NotImplementedException();
		}
		public static void loadMapData(float mapId)
		{
			throw new System.NotImplementedException();
		}
		public static void makeEmptyMap()
		{
			throw new System.NotImplementedException();
		}
		public static bool isMapLoaded()
		{
			throw new System.NotImplementedException();
		}
		public static void onLoad(object @object)
		{
			throw new System.NotImplementedException();
		}
		public static void extractMetadata(object data)
		{
			throw new System.NotImplementedException();
		}
		public static void checkError()
		{
			throw new System.NotImplementedException();
		}
		public static bool isBattleTest()
		{
			throw new System.NotImplementedException();
		}
		public static bool isEventTest()
		{
			throw new System.NotImplementedException();
		}
		public static bool isSkill(IDataSkill item)
		{
			throw new System.NotImplementedException();
		}
		public static bool isItem(IDataItem item)
		{
			throw new System.NotImplementedException();
		}
		public static bool isWeapon(IDataWeapon item)
		{
			throw new System.NotImplementedException();
		}
		public static bool isArmor(IDataArmor item)
		{
			throw new System.NotImplementedException();
		}
		public static void createGameObjects()
		{
			throw new System.NotImplementedException();
		}
		public static void setupNewGame()
		{
			throw new System.NotImplementedException();
		}
		public static void setupBattleTest()
		{
			throw new System.NotImplementedException();
		}
		public static void setupEventTest()
		{
			throw new System.NotImplementedException();
		}
		public static void loadGlobalInfo()
		{
			throw new System.NotImplementedException();
		}
		public static void saveGlobalInfo(ISavefileInfo[] info)
		{
			throw new System.NotImplementedException();
		}
		public static bool isThisGameFile(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isAnySavefileExists()
		{
			throw new System.NotImplementedException();
		}
		public static float latestSavefileId()
		{
			throw new System.NotImplementedException();
		}
		public static void loadAllSavefileImages()
		{
			throw new System.NotImplementedException();
		}
		public static void loadSavefileImages(ISavefileInfo info)
		{
			throw new System.NotImplementedException();
		}
		public static float maxSavefiles()
		{
			throw new System.NotImplementedException();
		}
		public static bool saveGame(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool loadGame(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static ISavefileInfo loadSavefileInfo(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static float lastAccessedSavefileId()
		{
			throw new System.NotImplementedException();
		}
		public static bool saveGameWithoutRescue(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool loadGameWithoutRescue(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void selectSavefileForNewGame()
		{
			throw new System.NotImplementedException();
		}
		public static ISavefileInfo makeSavefileInfo()
		{
			throw new System.NotImplementedException();
		}
		public static ISaveContents makeSaveContents()
		{
			throw new System.NotImplementedException();
		}
		public static void extractSaveContents(ISaveContents contents)
		{
			throw new System.NotImplementedException();
		}

				public class _databaseFiles_0_
		{
			public string name;
			public string src;
		}
	}

		public class IConfig
	{
		protected IConfig()
		{
			
		}
		public bool alwaysDash;
		public bool commandRemember;
		public float bgmVolume;
		public float bgsVolume;
		public float meVolume;
		public float seVolume;
	}

		public class ConfigManager
	{
		public ConfigManager()
		{
			
		}
		public static bool alwaysDash;
		public static bool commandRemember;
		public static float bgmVolume;
		public static float bgsVolume;
		public static float meVolume;
		public static float seVolume;
		public static void load()
		{
			throw new System.NotImplementedException();
		}
		public static void save()
		{
			throw new System.NotImplementedException();
		}
		public static IConfig makeData()
		{
			throw new System.NotImplementedException();
		}
		public static void applyData(IConfig config)
		{
			throw new System.NotImplementedException();
		}
		public static bool readFlag(IConfig config, string name)
		{
			throw new System.NotImplementedException();
		}
		public static float readVolume(IConfig config, string name)
		{
			throw new System.NotImplementedException();
		}
	}

		public class StorageManager
	{
		public StorageManager()
		{
			
		}
		public static void save(float savefileId, object json)
		{
			throw new System.NotImplementedException();
		}
		public static object load(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool exists(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void remove(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void backup(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void backupExists(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void cleanBackup(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void restoreBackup(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool isLocalMode()
		{
			throw new System.NotImplementedException();
		}
		public static void saveToLocalFile(float savefileId, object json)
		{
			throw new System.NotImplementedException();
		}
		public static object loadFromLocalFile(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static object loadFromLocalBackupFile(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool localFileBackupExists(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool localFileExists(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void removeLocalFile(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void saveToWebStorage(float savefileId, object json)
		{
			throw new System.NotImplementedException();
		}
		public static object loadFromWebStorage(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static object loadFromWebStorageBackup(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool webStorageBackupExists(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static bool webStorageExists(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static void removeWebStorage(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static string localFileDirectoryPath()
		{
			throw new System.NotImplementedException();
		}
		public static string localFilePath(float savefileId)
		{
			throw new System.NotImplementedException();
		}
		public static string webStorageKey(float savefileId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ImageManager
	{
		public ImageManager()
		{
			
		}
		public static ImageCache _imageCache;
		public static float _systemReservationId;
		public static CacheMap cache;
		public static string _generateCacheKey()
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadAnimation(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadBattleback1(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadBattleback2(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadEnemy(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadCharacter(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadFace(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadParallax(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadPicture(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadSvActor(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadSvEnemy(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadSystem(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadTileset(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadTitle1(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadTitle2(string filename, float hue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadBitmap(string folder, string filename, float hue = default(float), bool smooth = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadEmptyBitmap()
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap loadNormalBitmap(string path, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static void clear()
		{
			throw new System.NotImplementedException();
		}
		public static bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public static bool isObjectCharacter()
		{
			throw new System.NotImplementedException();
		}
		public static bool isBigCharacter()
		{
			throw new System.NotImplementedException();
		}
		public static bool isZeroParallax()
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveAnimation(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveBattleback1(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveBattleback2(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveEnemy(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveCharacter(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveFace(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveParallax(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reservePicture(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveSvActor(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveSvEnemy(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveSystem(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveTileset(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveTitle1(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveTitle2(string filename, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveBitmap(string folder, string filename, float hue, bool smooth, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap reserveNormalBitmap(string path, float hue, float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static void releaseReservation(float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static void setDefaultReservationId(float reservationId)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestAnimation(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestBattleback1(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestBattleback2(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestEnemy(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestCharacter(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestFace(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestParallax(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestPicture(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestSvActor(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestSvEnemy(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestSystem(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestTileset(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestTitle1(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestTitle2(string filename, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestBitmap(string folder, string filename, float hue, bool smooth)
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap requestNormalBitmap(string path, float hue)
		{
			throw new System.NotImplementedException();
		}
		public static void update()
		{
			throw new System.NotImplementedException();
		}
		public static void clearRequest()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IAudioObject
	{
		protected IAudioObject()
		{
			
		}
		public string name;
		public float volume;
		public float pitch;
		public float pan;
		public float pos;
	}

		public class AudioManager
	{
		public AudioManager()
		{
			
		}
		public static float _masterVolume;
		public static float _bgmVolume;
		public static float _bgsVolume;
		public static float _meVolume;
		public static float _seVolume;
		public static IAudioObject _currentBgm;
		public static IAudioObject _currentBgs;
		public static object _bgmBuffer;
		public static WebAudio _bgsBuffer;
		public static WebAudio _meBuffer;
		public static WebAudio[] _seBuffers;
		public static WebAudio[] _staticBuffers;
		public static float _replayFadeTime;
		public static string _path;
		public static string _blobUrl;
		public static float bgmVolume;
		public static float bgsVolume;
		public static float meVolume;
		public static float seVolume;
		public static void playBgm(IAudioObject bgm, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static void playEncryptedBgm(IAudioObject bgm, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static void createDecryptBuffer(string url, IAudioObject bgm, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static void replayBgm(IAudioObject bgm)
		{
			throw new System.NotImplementedException();
		}
		public static bool isCurrentBgm(IAudioObject bgm)
		{
			throw new System.NotImplementedException();
		}
		public static void updateBgmParameters(IAudioObject bgm)
		{
			throw new System.NotImplementedException();
		}
		public static void updateCurrentBgm(IAudioObject bgm, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static void stopBgm()
		{
			throw new System.NotImplementedException();
		}
		public static void fadeOutBgm(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void fadeInBgm(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void playBgs(IAudioObject bgs, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static void replayBgs(IAudioObject bgs)
		{
			throw new System.NotImplementedException();
		}
		public static bool isCurrentBgs(IAudioObject bgs)
		{
			throw new System.NotImplementedException();
		}
		public static void updateBgsParameters(IAudioObject bgs)
		{
			throw new System.NotImplementedException();
		}
		public static void updateCurrentBgs(IAudioObject bgs, float pos)
		{
			throw new System.NotImplementedException();
		}
		public static void stopBgs()
		{
			throw new System.NotImplementedException();
		}
		public static void fadeOutBgs(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void fadeInBgs(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void playMe(IDataSound me)
		{
			throw new System.NotImplementedException();
		}
		public static void updateMeParameters(IDataSound me)
		{
			throw new System.NotImplementedException();
		}
		public static void fadeOutMe(float duration)
		{
			throw new System.NotImplementedException();
		}
		public static void stopMe()
		{
			throw new System.NotImplementedException();
		}
		public static void playSe(IDataSound se)
		{
			throw new System.NotImplementedException();
		}
		public static void updateSeParameters(object buffer, IDataSound se)
		{
			throw new System.NotImplementedException();
		}
		public static void stopSe()
		{
			throw new System.NotImplementedException();
		}
		public static void playStaticSe(IDataSound se)
		{
			throw new System.NotImplementedException();
		}
		public static void loadStaticSe(IDataSound se)
		{
			throw new System.NotImplementedException();
		}
		public static bool isStaticSe(IDataSound se)
		{
			throw new System.NotImplementedException();
		}
		public static void stopAll()
		{
			throw new System.NotImplementedException();
		}
		public static IAudioObject saveBgm()
		{
			throw new System.NotImplementedException();
		}
		public static IAudioObject saveBgs()
		{
			throw new System.NotImplementedException();
		}
		public static IAudioObject makeEmptyAudioObject()
		{
			throw new System.NotImplementedException();
		}
		public static object createBuffer(float folder, string name)
		{
			throw new System.NotImplementedException();
		}
		public static void updateBufferParameters(IAudioObject buffer, float configVolume, IAudioObject audio)
		{
			throw new System.NotImplementedException();
		}
		public static string audioFileExt()
		{
			throw new System.NotImplementedException();
		}
		public static bool shouldUseHtml5Audio()
		{
			throw new System.NotImplementedException();
		}
		public static void checkErrors()
		{
			throw new System.NotImplementedException();
		}
		public static void checkWebAudioError(WebAudio webAudio)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SoundManager
	{
		public SoundManager()
		{
			
		}
		public static void preloadImportantSounds()
		{
			throw new System.NotImplementedException();
		}
		public static void loadSystemSound(float n)
		{
			throw new System.NotImplementedException();
		}
		public static void playSystemSound(float n)
		{
			throw new System.NotImplementedException();
		}
		public static void playCursor()
		{
			throw new System.NotImplementedException();
		}
		public static void playOk()
		{
			throw new System.NotImplementedException();
		}
		public static void playCancel()
		{
			throw new System.NotImplementedException();
		}
		public static void playBuzzer()
		{
			throw new System.NotImplementedException();
		}
		public static void playEquip()
		{
			throw new System.NotImplementedException();
		}
		public static void playSave()
		{
			throw new System.NotImplementedException();
		}
		public static void playLoad()
		{
			throw new System.NotImplementedException();
		}
		public static void playBattleStart()
		{
			throw new System.NotImplementedException();
		}
		public static void playEscapeion()
		{
			throw new System.NotImplementedException();
		}
		public static void playEnemyAttack()
		{
			throw new System.NotImplementedException();
		}
		public static void playEnemyDamage()
		{
			throw new System.NotImplementedException();
		}
		public static void playEnemyCollapse()
		{
			throw new System.NotImplementedException();
		}
		public static void playBossCollapse1()
		{
			throw new System.NotImplementedException();
		}
		public static void playBossCollapse2()
		{
			throw new System.NotImplementedException();
		}
		public static void playActorDamage()
		{
			throw new System.NotImplementedException();
		}
		public static void playActorCollapse()
		{
			throw new System.NotImplementedException();
		}
		public static void playRecoveryion()
		{
			throw new System.NotImplementedException();
		}
		public static void playMiss()
		{
			throw new System.NotImplementedException();
		}
		public static void playEvasionion()
		{
			throw new System.NotImplementedException();
		}
		public static void playMagicEvasion()
		{
			throw new System.NotImplementedException();
		}
		public static void playReflectioni()
		{
			throw new System.NotImplementedException();
		}
		public static void playShop()
		{
			throw new System.NotImplementedException();
		}
		public static void playUseItem()
		{
			throw new System.NotImplementedException();
		}
		public static void playUseSkill()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextManager
	{
		public TextManager()
		{
			
		}
		public static string currencyUnit;
		public static string level;
		public static string levelA;
		public static string hp;
		public static string hpA;
		public static string mp;
		public static string mpA;
		public static string tp;
		public static string tpA;
		public static string exp;
		public static string expA;
		public static string fight;
		public static string escape;
		public static string attack;
		public static string guard;
		public static string item;
		public static string skill;
		public static string equip;
		public static string status;
		public static string formation;
		public static string save;
		public static string gameEnd;
		public static string options;
		public static string weapon;
		public static string armor;
		public static string keyItem;
		public static string equip2;
		public static string optimize;
		public static string clear;
		public static string newGame;
		public static string continue_;
		public static string toTitle;
		public static string cancel;
		public static string buy;
		public static string sell;
		public static string alwaysDash;
		public static string commandRemember;
		public static string bgmVolume;
		public static string bgsVolume;
		public static string meVolume;
		public static string seVolume;
		public static string possession;
		public static string expTotal;
		public static string expNext;
		public static string saveMessage;
		public static string loadMessage;
		public static string file;
		public static string partyName;
		public static string emerge;
		public static string preemptive;
		public static string surprise;
		public static string escapeStart;
		public static string escapeFailure;
		public static string victory;
		public static string defeat;
		public static string obtainExp;
		public static string obtainGold;
		public static string obtainItem;
		public static string levelUp;
		public static string obtainSkill;
		public static string useItem;
		public static string criticalToEnemy;
		public static string criticalToActor;
		public static string actorDamage;
		public static string actorRecovery;
		public static string actorGain;
		public static string actorLoss;
		public static string actorDrain;
		public static string actorNoDamage;
		public static string actorNoHit;
		public static string enemyDamage;
		public static string enemyRecovery;
		public static string enemyGain;
		public static string enemyLoss;
		public static string enemyDrain;
		public static string enemyNoDamage;
		public static string enemyNoHit;
		public static string evasion;
		public static string magicEvasion;
		public static string magicReflection;
		public static string counterAttack;
		public static string substitute;
		public static string buffAdd;
		public static string debuffAdd;
		public static string buffRemove;
		public static string actionFailure;
		public static string basic(float basicId)
		{
			throw new System.NotImplementedException();
		}
		public static string param(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public static string command(float commandId)
		{
			throw new System.NotImplementedException();
		}
		public static string message(float messageId)
		{
			throw new System.NotImplementedException();
		}
		public static Function getter(Function method, float param)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SceneManager
	{
		public SceneManager()
		{
			
		}
		public static float _getTimeInMsWithoutMobileSafari;
		public static Scene_Base _scene;
		public static Scene_Base _nextScene;
		public static object _stack;
		public static bool _stopped;
		public static bool _sceneStarted;
		public static bool _exiting;
		public static object _previousClass;
		public object Scene_Base;
		public static Bitmap _backgroundBitmap;
		public static float _screenWidth;
		public static float _screenHeight;
		public static float _boxWidth;
		public static float _boxHeight;
		public static float _deltaTime;
		public static float _currentTime;
		public static float _accumulator;
		public static void run(object sceneClass)
		{
			throw new System.NotImplementedException();
		}
		public static void initialize()
		{
			throw new System.NotImplementedException();
		}
		public static void initGraphics()
		{
			throw new System.NotImplementedException();
		}
		public static string preferableRendererType()
		{
			throw new System.NotImplementedException();
		}
		public static bool shouldUseCanvasRenderer()
		{
			throw new System.NotImplementedException();
		}
		public static void checkWebGL()
		{
			throw new System.NotImplementedException();
		}
		public static void checkFileAccess()
		{
			throw new System.NotImplementedException();
		}
		public static void initAudio()
		{
			throw new System.NotImplementedException();
		}
		public static void initInput()
		{
			throw new System.NotImplementedException();
		}
		public static void initNwjs()
		{
			throw new System.NotImplementedException();
		}
		public static void checkPluginErrors()
		{
			throw new System.NotImplementedException();
		}
		public static void setupErrorHandlers()
		{
			throw new System.NotImplementedException();
		}
		public static void requestUpdate()
		{
			throw new System.NotImplementedException();
		}
		public static void update()
		{
			throw new System.NotImplementedException();
		}
		public static void terminate()
		{
			throw new System.NotImplementedException();
		}
		public static void onError(ErrorEvent e)
		{
			throw new System.NotImplementedException();
		}
		public static void onKeyDown(KeyboardEvent @event)
		{
			throw new System.NotImplementedException();
		}
		public static void catchException(ErrorEvent e)
		{
			throw new System.NotImplementedException();
		}
		public static void tickStart()
		{
			throw new System.NotImplementedException();
		}
		public static void tickEnd()
		{
			throw new System.NotImplementedException();
		}
		public static void updateInputData()
		{
			throw new System.NotImplementedException();
		}
		public static void updateMain()
		{
			throw new System.NotImplementedException();
		}
		public static void updateManagers()
		{
			throw new System.NotImplementedException();
		}
		public static void changeScene()
		{
			throw new System.NotImplementedException();
		}
		public static void updateScene()
		{
			throw new System.NotImplementedException();
		}
		public static void renderScene()
		{
			throw new System.NotImplementedException();
		}
		public static void onSceneCreate()
		{
			throw new System.NotImplementedException();
		}
		public static void onSceneStart()
		{
			throw new System.NotImplementedException();
		}
		public static void onSceneLoading()
		{
			throw new System.NotImplementedException();
		}
		public static bool isSceneChanging()
		{
			throw new System.NotImplementedException();
		}
		public static bool isCurrentSceneBusy()
		{
			throw new System.NotImplementedException();
		}
		public static bool isCurrentSceneStarted()
		{
			throw new System.NotImplementedException();
		}
		public static bool isNextScene(object sceneClass)
		{
			throw new System.NotImplementedException();
		}
		public static bool isPreviousScene(object sceneClass)
		{
			throw new System.NotImplementedException();
		}
		public static void @goto(object sceneClass)
		{
			throw new System.NotImplementedException();
		}
		public static void push(object sceneClass)
		{
			throw new System.NotImplementedException();
		}
		public static void pop()
		{
			throw new System.NotImplementedException();
		}
		public static void exit()
		{
			throw new System.NotImplementedException();
		}
		public static void clearStack()
		{
			throw new System.NotImplementedException();
		}
		public static void stop()
		{
			throw new System.NotImplementedException();
		}
		public static void prepareNextScene()
		{
			throw new System.NotImplementedException();
		}
		public static void snap()
		{
			throw new System.NotImplementedException();
		}
		public static void snapForBackground()
		{
			throw new System.NotImplementedException();
		}
		public static Bitmap backgroundBitmap()
		{
			throw new System.NotImplementedException();
		}
		public static void resume()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDataRewards
	{
		protected IDataRewards()
		{
			
		}
		public float gold;
		public float exp;
		public IDataAllItem[] items;
	}

		public class BattleManager
	{
		public BattleManager()
		{
			
		}
		public static string _phase;
		public static bool _canEscape;
		public static bool _canLose;
		public static bool _battleTest;
		public static Function _eventCallback;
		public static bool _preemptive;
		public static bool _surprise;
		public static float _actorIndex;
		public static Game_Battler _actionForcedBattler;
		public static IAudioObject _mapBgm;
		public static IAudioObject _mapBgs;
		public static Game_Battler[] _actionBattlers;
		public static Game_Battler _subject;
		public static Game_Action _action;
		public static Game_Battler[] _targets;
		public static Window_BattleLog _logWindow;
		public static Window_BattleStatus _statusWindow;
		public static Spriteset_Battle _spriteset;
		public static float _escapeRatio;
		public static bool _escaped;
		public static IDataRewards _rewards;
		public static void setup(float troopId, bool canEscape, bool canLose)
		{
			throw new System.NotImplementedException();
		}
		public static void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public static bool isBattleTest()
		{
			throw new System.NotImplementedException();
		}
		public static void setBattleTest(bool battleTest)
		{
			throw new System.NotImplementedException();
		}
		public static void setEventCallback(Function callback)
		{
			throw new System.NotImplementedException();
		}
		public static void setLogWindow(Window_BattleLog logWindow)
		{
			throw new System.NotImplementedException();
		}
		public static void setStatusWindow(Window_BattleStatus statusWindow)
		{
			throw new System.NotImplementedException();
		}
		public static void setSpriteset(Spriteset_Battle spriteset)
		{
			throw new System.NotImplementedException();
		}
		public static void onEncounter()
		{
			throw new System.NotImplementedException();
		}
		public static float ratePreemptive()
		{
			throw new System.NotImplementedException();
		}
		public static float rateSurprise()
		{
			throw new System.NotImplementedException();
		}
		public static void saveBgmAndBgs()
		{
			throw new System.NotImplementedException();
		}
		public static void playBattleBgm()
		{
			throw new System.NotImplementedException();
		}
		public static void playVictoryMe()
		{
			throw new System.NotImplementedException();
		}
		public static void playDefeatMe()
		{
			throw new System.NotImplementedException();
		}
		public static void replayBgmAndBgs()
		{
			throw new System.NotImplementedException();
		}
		public static void makeEscapeRatio()
		{
			throw new System.NotImplementedException();
		}
		public static void update()
		{
			throw new System.NotImplementedException();
		}
		public static bool updateEvent()
		{
			throw new System.NotImplementedException();
		}
		public static bool updateEventMain()
		{
			throw new System.NotImplementedException();
		}
		public static bool isBusy()
		{
			throw new System.NotImplementedException();
		}
		public static bool isInputting()
		{
			throw new System.NotImplementedException();
		}
		public static bool isInTurn()
		{
			throw new System.NotImplementedException();
		}
		public static bool isTurnEnd()
		{
			throw new System.NotImplementedException();
		}
		public static bool isAborting()
		{
			throw new System.NotImplementedException();
		}
		public static bool isBattleEnd()
		{
			throw new System.NotImplementedException();
		}
		public static bool canEscape()
		{
			throw new System.NotImplementedException();
		}
		public static bool canLose()
		{
			throw new System.NotImplementedException();
		}
		public static bool isEscaped()
		{
			throw new System.NotImplementedException();
		}
		public static Game_Actor actor()
		{
			throw new System.NotImplementedException();
		}
		public static void clearActor()
		{
			throw new System.NotImplementedException();
		}
		public static void changeActor(float newActorIndex, string lastActorActionState)
		{
			throw new System.NotImplementedException();
		}
		public static void startBattle()
		{
			throw new System.NotImplementedException();
		}
		public static void displayStartMessages()
		{
			throw new System.NotImplementedException();
		}
		public static void startInput()
		{
			throw new System.NotImplementedException();
		}
		public static Game_Action inputtingAction()
		{
			throw new System.NotImplementedException();
		}
		public static void selectNextCommand()
		{
			throw new System.NotImplementedException();
		}
		public static void selectPreviousCommand()
		{
			throw new System.NotImplementedException();
		}
		public static void refreshStatus()
		{
			throw new System.NotImplementedException();
		}
		public static void startTurn()
		{
			throw new System.NotImplementedException();
		}
		public static void updateTurn()
		{
			throw new System.NotImplementedException();
		}
		public static void processTurn()
		{
			throw new System.NotImplementedException();
		}
		public static void endTurn()
		{
			throw new System.NotImplementedException();
		}
		public static void updateTurnEnd()
		{
			throw new System.NotImplementedException();
		}
		public static void getNextSubject()
		{
			throw new System.NotImplementedException();
		}
		public static Game_Battler allBattleMembers()
		{
			throw new System.NotImplementedException();
		}
		public static void makeActionOrders()
		{
			throw new System.NotImplementedException();
		}
		public static void startAction()
		{
			throw new System.NotImplementedException();
		}
		public static void updateAction()
		{
			throw new System.NotImplementedException();
		}
		public static void endAction()
		{
			throw new System.NotImplementedException();
		}
		public static void invokeAction(Game_Battler subject, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public static void invokeNormalAction(Game_Battler subject, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public static void invokeCounterAttack(Game_Battler subject, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public static void invokeMagicReflection(Game_Battler subject, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public static Game_Battler applySubstitute(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public static Game_Battler checkSubstitute(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public static bool isActionForced()
		{
			throw new System.NotImplementedException();
		}
		public static void forceAction(Game_Battler battler)
		{
			throw new System.NotImplementedException();
		}
		public static void processForcedAction()
		{
			throw new System.NotImplementedException();
		}
		public static void abort()
		{
			throw new System.NotImplementedException();
		}
		public static bool checkBattleEnd()
		{
			throw new System.NotImplementedException();
		}
		public static bool checkAbort()
		{
			throw new System.NotImplementedException();
		}
		public static bool checkAbort2()
		{
			throw new System.NotImplementedException();
		}
		public static void processVictory()
		{
			throw new System.NotImplementedException();
		}
		public static bool processEscape()
		{
			throw new System.NotImplementedException();
		}
		public static void processAbort()
		{
			throw new System.NotImplementedException();
		}
		public static void processDefeat()
		{
			throw new System.NotImplementedException();
		}
		public static void endBattle(float result)
		{
			throw new System.NotImplementedException();
		}
		public static void updateBattleEnd()
		{
			throw new System.NotImplementedException();
		}
		public static void makeRewards()
		{
			throw new System.NotImplementedException();
		}
		public static void displayVictoryMessage()
		{
			throw new System.NotImplementedException();
		}
		public static void displayDefeatMessage()
		{
			throw new System.NotImplementedException();
		}
		public static void makeRewadisplayEscapeSuccessMessagerds()
		{
			throw new System.NotImplementedException();
		}
		public static void displayEscapeFailureMessage()
		{
			throw new System.NotImplementedException();
		}
		public static void displayRewards()
		{
			throw new System.NotImplementedException();
		}
		public static void displayExp()
		{
			throw new System.NotImplementedException();
		}
		public static void displayGold()
		{
			throw new System.NotImplementedException();
		}
		public static void displayDropItems()
		{
			throw new System.NotImplementedException();
		}
		public static void gainRewards()
		{
			throw new System.NotImplementedException();
		}
		public static void gainExp()
		{
			throw new System.NotImplementedException();
		}
		public static void gainGold()
		{
			throw new System.NotImplementedException();
		}
		public static void gainDropItems()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDataPlugin
	{
		protected IDataPlugin()
		{
			
		}
		public string name;
		public bool status;
		public string description;
		public string[] parameters;
	}
}

namespace GLOBAL
{

    public class PluginManager
	{
		public PluginManager()
		{
			
		}
		public static string _path;
		public static string[] _scripts;
		public static string[] _errorUrls;
		public static string[] _parameters;
		public static void setup(IDataPlugin[] plugins)
		{
			throw new System.NotImplementedException();
		}
		public static void checkErrors()
		{
			throw new System.NotImplementedException();
		}
		public static string[] parameters(string name)
		{
			throw new System.NotImplementedException();
		}
		public static void setParameters(string name, string[] parameters)
		{
			throw new System.NotImplementedException();
		}
		public static void loadScript(string name)
		{
			throw new System.NotImplementedException();
		}
		public static void onError(ErrorEvent e)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Temp
	{
		public Game_Temp()
		{
			
		}
		public bool _isPlaytest;
		public float _commonEventId;
		public float _destinationX;
		public float _destinationY;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public bool isPlaytest()
		{
			throw new System.NotImplementedException();
		}
		public void reserveCommonEvent(float commonEventId)
		{
			throw new System.NotImplementedException();
		}
		public void clearCommonEvent()
		{
			throw new System.NotImplementedException();
		}
		public bool isCommonEventReserved()
		{
			throw new System.NotImplementedException();
		}
		public IDataCommonEvent reservedCommonEvent()
		{
			throw new System.NotImplementedException();
		}
		public void setDestination(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void clearDestination()
		{
			throw new System.NotImplementedException();
		}
		public void isDestinationValid()
		{
			throw new System.NotImplementedException();
		}
		public float destinationX()
		{
			throw new System.NotImplementedException();
		}
		public float destinationY()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_System
	{
		public Game_System()
		{
			
		}
		public bool _saveEnabled;
		public bool _menuEnabled;
		public bool _encounterEnabled;
		public bool _formationEnabled;
		public float _battleCount;
		public float _winCount;
		public float _escapeCount;
		public float _saveCount;
		public float _versionId;
		public float _framesOnSave;
		public IAudioObject _bgmOnSave;
		public IAudioObject _bgsOnSave;
		public float[] _windowTone;
		public IDataSound _battleBgm;
		public IDataSound _victoryMe;
		public IDataSound _defeatMe;
		public IDataSound _savedBgm;
		public IDataSound _walkingBgm;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public bool isJapanese()
		{
			throw new System.NotImplementedException();
		}
		public bool isChinese()
		{
			throw new System.NotImplementedException();
		}
		public bool isKorean()
		{
			throw new System.NotImplementedException();
		}
		public bool isCJK()
		{
			throw new System.NotImplementedException();
		}
		public bool isRussian()
		{
			throw new System.NotImplementedException();
		}
		public bool isSideView()
		{
			throw new System.NotImplementedException();
		}
		public bool isSaveEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void disableSave()
		{
			throw new System.NotImplementedException();
		}
		public void enableSave()
		{
			throw new System.NotImplementedException();
		}
		public bool isMenuEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void disableMenu()
		{
			throw new System.NotImplementedException();
		}
		public void enableMenu()
		{
			throw new System.NotImplementedException();
		}
		public bool isEncounterEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void disableEncounter()
		{
			throw new System.NotImplementedException();
		}
		public void enableEncounter()
		{
			throw new System.NotImplementedException();
		}
		public bool isFormationEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void disableFormation()
		{
			throw new System.NotImplementedException();
		}
		public void enableFormation()
		{
			throw new System.NotImplementedException();
		}
		public float battleCount()
		{
			throw new System.NotImplementedException();
		}
		public float winCount()
		{
			throw new System.NotImplementedException();
		}
		public float escapeCount()
		{
			throw new System.NotImplementedException();
		}
		public float saveCount()
		{
			throw new System.NotImplementedException();
		}
		public float versionId()
		{
			throw new System.NotImplementedException();
		}
		public float[] windowTone()
		{
			throw new System.NotImplementedException();
		}
		public void setWindowTone(float[] value)
		{
			throw new System.NotImplementedException();
		}
		public IDataSound battleBgm()
		{
			throw new System.NotImplementedException();
		}
		public void setBattleBgm(IDataSound value)
		{
			throw new System.NotImplementedException();
		}
		public IDataSound victoryMe()
		{
			throw new System.NotImplementedException();
		}
		public void setVictoryMe(IDataSound value)
		{
			throw new System.NotImplementedException();
		}
		public IDataSound defeatMe()
		{
			throw new System.NotImplementedException();
		}
		public void setDefeatMe(IDataSound value)
		{
			throw new System.NotImplementedException();
		}
		public void onBattleStart()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleWin()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleEscape()
		{
			throw new System.NotImplementedException();
		}
		public void onBeforeSave()
		{
			throw new System.NotImplementedException();
		}
		public void onAfterLoad()
		{
			throw new System.NotImplementedException();
		}
		public float playtime()
		{
			throw new System.NotImplementedException();
		}
		public string playtimeText()
		{
			throw new System.NotImplementedException();
		}
		public void saveBgm()
		{
			throw new System.NotImplementedException();
		}
		public void replayBgm()
		{
			throw new System.NotImplementedException();
		}
		public void saveWalkingBgm()
		{
			throw new System.NotImplementedException();
		}
		public void replayWalkingBgm()
		{
			throw new System.NotImplementedException();
		}
		public void saveWalkingBgm2()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Timer
	{
		public Game_Timer()
		{
			
		}
		public float _frames;
		public bool _working;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update(bool sceneActive)
		{
			throw new System.NotImplementedException();
		}
		public void start(float count)
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public bool isWorking()
		{
			throw new System.NotImplementedException();
		}
		public float seconds()
		{
			throw new System.NotImplementedException();
		}
		public void onExpire()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Message
	{
		public Game_Message()
		{
			
		}
		public string[] _texts;
		public string[] _choices;
		public string _faceName;
		public float _faceIndex;
		public float _background;
		public float _positionType;
		public float _choiceDefaultType;
		public float _choiceCancelType;
		public float _choiceBackground;
		public float _choicePositionType;
		public float _numInputVariableId;
		public float _numInputMaxDigits;
		public float _itemChoiceVariableId;
		public float _itemChoiceItypeId;
		public bool _scrollMode;
		public float _scrollSpeed;
		public bool _scrollNoFast;
		public Function _choiceCallback;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public string[] choices()
		{
			throw new System.NotImplementedException();
		}
		public string faceName()
		{
			throw new System.NotImplementedException();
		}
		public float faceIndex()
		{
			throw new System.NotImplementedException();
		}
		public float background()
		{
			throw new System.NotImplementedException();
		}
		public float positionType()
		{
			throw new System.NotImplementedException();
		}
		public float choiceDefaultType()
		{
			throw new System.NotImplementedException();
		}
		public float choiceCancelType()
		{
			throw new System.NotImplementedException();
		}
		public float choiceBackground()
		{
			throw new System.NotImplementedException();
		}
		public float choicePositionType()
		{
			throw new System.NotImplementedException();
		}
		public float numInputVariableId()
		{
			throw new System.NotImplementedException();
		}
		public float numInputMaxDigits()
		{
			throw new System.NotImplementedException();
		}
		public float itemChoiceVariableId()
		{
			throw new System.NotImplementedException();
		}
		public float itemChoiceItypeId()
		{
			throw new System.NotImplementedException();
		}
		public bool scrollMode()
		{
			throw new System.NotImplementedException();
		}
		public float scrollSpeed()
		{
			throw new System.NotImplementedException();
		}
		public bool scrollNoFast()
		{
			throw new System.NotImplementedException();
		}
		public void add(string text)
		{
			throw new System.NotImplementedException();
		}
		public void setFaceImage(string faceName, float faceIndex)
		{
			throw new System.NotImplementedException();
		}
		public void setBackground(float background)
		{
			throw new System.NotImplementedException();
		}
		public void setPositionType(float positionType)
		{
			throw new System.NotImplementedException();
		}
		public void setChoices(string[] choices, float defaultType, float cancelType)
		{
			throw new System.NotImplementedException();
		}
		public void setChoiceBackground(float background)
		{
			throw new System.NotImplementedException();
		}
		public void setChoicePositionType(float positionType)
		{
			throw new System.NotImplementedException();
		}
		public void setNumberInput(float variableId, float maxDigits)
		{
			throw new System.NotImplementedException();
		}
		public void setItemChoice(float variableId, float itemType)
		{
			throw new System.NotImplementedException();
		}
		public void setScroll(float speed, bool noFast)
		{
			throw new System.NotImplementedException();
		}
		public void setChoiceCallback(Function callback)
		{
			throw new System.NotImplementedException();
		}
		public void onChoice(float n)
		{
			throw new System.NotImplementedException();
		}
		public bool hasText()
		{
			throw new System.NotImplementedException();
		}
		public bool isChoice()
		{
			throw new System.NotImplementedException();
		}
		public bool isNumberInput()
		{
			throw new System.NotImplementedException();
		}
		public bool isItemChoice()
		{
			throw new System.NotImplementedException();
		}
		public bool isBusy()
		{
			throw new System.NotImplementedException();
		}
		public void newPage()
		{
			throw new System.NotImplementedException();
		}
		public string allText()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Switches
	{
		public Game_Switches()
		{
			
		}
		public bool[] _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public bool value(float switchId)
		{
			throw new System.NotImplementedException();
		}
		public void setValue(float switchId, bool value)
		{
			throw new System.NotImplementedException();
		}
		public void onChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Variables
	{
		public Game_Variables()
		{
			
		}
		public float[] _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public float value(float variableId)
		{
			throw new System.NotImplementedException();
		}
		public float setValue(float variableId, float value)
		{
			throw new System.NotImplementedException();
		}
		public void onChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_SelfSwitches
	{
		public Game_SelfSwitches()
		{
			
		}
		public Dictionary<string,bool> _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public bool value(float[] key)
		{
			throw new System.NotImplementedException();
		}
		public object setValue(Func<object, object> key)
		{
			throw new System.NotImplementedException();
		}
		public void onChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Screen
	{
		public Game_Screen()
		{
			
		}
		public float _brightness;
		public float _zoomX;
		public float _zoomY;
		public float _zoomScale;
		public float _zoomScaleTarget;
		public float _zoomDuration;
		public string _weatherType;
		public float _weatherPower;
		public float _weatherPowerTarget;
		public float _weatherDuration;
		public Game_Picture[] _pictures;
		public float _fadeOutDuration;
		public float _fadeInDuration;
		public float[] _tone;
		public float[] _toneTarget;
		public float _toneDuration;
		public float[] _flashColor;
		public float _flashDuration;
		public float _shake;
		public float _shakePower;
		public float _shakeSpeed;
		public float _shakeDuration;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleStart()
		{
			throw new System.NotImplementedException();
		}
		public float brightness()
		{
			throw new System.NotImplementedException();
		}
		public float[] tone()
		{
			throw new System.NotImplementedException();
		}
		public float[] flashColor()
		{
			throw new System.NotImplementedException();
		}
		public float shake()
		{
			throw new System.NotImplementedException();
		}
		public float zoomX()
		{
			throw new System.NotImplementedException();
		}
		public float zoomY()
		{
			throw new System.NotImplementedException();
		}
		public float zoomScale()
		{
			throw new System.NotImplementedException();
		}
		public string weatherType()
		{
			throw new System.NotImplementedException();
		}
		public float weatherPower()
		{
			throw new System.NotImplementedException();
		}
		public Game_Picture picture(float pictureId)
		{
			throw new System.NotImplementedException();
		}
		public float realPictureId(float pictureId)
		{
			throw new System.NotImplementedException();
		}
		public void clearFade()
		{
			throw new System.NotImplementedException();
		}
		public void clearTone()
		{
			throw new System.NotImplementedException();
		}
		public void clearFlash()
		{
			throw new System.NotImplementedException();
		}
		public void clearShake()
		{
			throw new System.NotImplementedException();
		}
		public void clearZoom()
		{
			throw new System.NotImplementedException();
		}
		public void clearWeather()
		{
			throw new System.NotImplementedException();
		}
		public void clearPictures()
		{
			throw new System.NotImplementedException();
		}
		public void eraseBattlePictures()
		{
			throw new System.NotImplementedException();
		}
		public float maxPictures()
		{
			throw new System.NotImplementedException();
		}
		public void startFadeOut(float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startFadeIn(float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startTint(float[] tone, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startFlash(float[] color, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startShake(float power, float speed, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startZoom(float x, float y, float scale, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void setZoom(float x, float y, float scale)
		{
			throw new System.NotImplementedException();
		}
		public void changeWeather(string type, float power, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateFadeOut()
		{
			throw new System.NotImplementedException();
		}
		public void updateFadeIn()
		{
			throw new System.NotImplementedException();
		}
		public void updateTone()
		{
			throw new System.NotImplementedException();
		}
		public void updateFlash()
		{
			throw new System.NotImplementedException();
		}
		public void updateShake()
		{
			throw new System.NotImplementedException();
		}
		public void updateZoom()
		{
			throw new System.NotImplementedException();
		}
		public void updateWeather()
		{
			throw new System.NotImplementedException();
		}
		public void updatePictures()
		{
			throw new System.NotImplementedException();
		}
		public void startFlashForDamage()
		{
			throw new System.NotImplementedException();
		}
		public void showPicture(float pictureId, string name, float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode)
		{
			throw new System.NotImplementedException();
		}
		public void movePicture(float pictureId, float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void rotatePicture(float pictureId, float speed)
		{
			throw new System.NotImplementedException();
		}
		public void tintPicture(float pictureId, float[] tone, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void erasePicture(float pictureId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Picture
	{
		public Game_Picture()
		{
			
		}
		public string _name;
		public float _origin;
		public float _x;
		public float _y;
		public float _scaleX;
		public float _scaleY;
		public float _opacity;
		public float _blendMode;
		public float[] _tone;
		public float[] _toneTarget;
		public float _toneDuration;
		public float _angle;
		public float _rotationSpeed;
		public float _targetX;
		public float _targetY;
		public float _targetScaleX;
		public float _targetScaleY;
		public float _targetOpacity;
		public float _duration;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public string name()
		{
			throw new System.NotImplementedException();
		}
		public float origin()
		{
			throw new System.NotImplementedException();
		}
		public float x()
		{
			throw new System.NotImplementedException();
		}
		public float y()
		{
			throw new System.NotImplementedException();
		}
		public float scaleX()
		{
			throw new System.NotImplementedException();
		}
		public float scaleY()
		{
			throw new System.NotImplementedException();
		}
		public float opacity()
		{
			throw new System.NotImplementedException();
		}
		public float blendMode()
		{
			throw new System.NotImplementedException();
		}
		public float[] tone()
		{
			throw new System.NotImplementedException();
		}
		public float angle()
		{
			throw new System.NotImplementedException();
		}
		public void initBasic()
		{
			throw new System.NotImplementedException();
		}
		public void initTarget()
		{
			throw new System.NotImplementedException();
		}
		public void initTone()
		{
			throw new System.NotImplementedException();
		}
		public void initRotation()
		{
			throw new System.NotImplementedException();
		}
		public void show(string name, float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode)
		{
			throw new System.NotImplementedException();
		}
		public void move(float origin, float x, float y, float scaleX, float scaleY, float opacity, float blendMode, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void rotate(float speed)
		{
			throw new System.NotImplementedException();
		}
		public void tint(float[] tone, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void erase()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateMove()
		{
			throw new System.NotImplementedException();
		}
		public void updateTone()
		{
			throw new System.NotImplementedException();
		}
		public void updateRotation()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Item
	{
		public Game_Item(IDataItem item = default(IDataItem))
		{
			
		}
		protected Game_Item()
		{
			
		}
		public string _dataClass;
		public float _itemId;
		public void initialize(IDataItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isSkill()
		{
			throw new System.NotImplementedException();
		}
		public bool isItem()
		{
			throw new System.NotImplementedException();
		}
		public bool isUsableItem()
		{
			throw new System.NotImplementedException();
		}
		public bool isWeapon()
		{
			throw new System.NotImplementedException();
		}
		public bool isArmor()
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipItem()
		{
			throw new System.NotImplementedException();
		}
		public bool isNull()
		{
			throw new System.NotImplementedException();
		}
		public float itemId()
		{
			throw new System.NotImplementedException();
		}
		public IDataItem @object()
		{
			throw new System.NotImplementedException();
		}
		public void setObject(IDataItem item)
		{
			throw new System.NotImplementedException();
		}
		public void setEquip(bool isWeapon, float itemId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Action
	{
		public Game_Action(Game_Battler subject, bool forcing = default(bool))
		{
			
		}
		protected Game_Action()
		{
			
		}
		public static float EFFECT_RECOVER_HP;
		public static float EFFECT_RECOVER_MP;
		public static float EFFECT_GAIN_TP;
		public static float EFFECT_ADD_STATE;
		public static float EFFECT_REMOVE_STATE;
		public static float EFFECT_ADD_BUFF;
		public static float EFFECT_ADD_DEBUFF;
		public static float EFFECT_REMOVE_BUFF;
		public static float EFFECT_REMOVE_DEBUFF;
		public static float EFFECT_SPECIAL;
		public static float EFFECT_GROW;
		public static float EFFECT_LEARN_SKILL;
		public static float EFFECT_COMMON_EVENT;
		public static float SPECIAL_EFFECT_ESCAPE;
		public static float HITTYPE_CERTAIN;
		public static float HITTYPE_PHYSICAL;
		public static float HITTYPE_MAGICAL;
		public float _subjectActorId;
		public float _subjectEnemyIndex;
		public bool _forcing;
		public Game_Item _item;
		public float _targetIndex;
		public void initialize(Game_Battler subject, bool forcing)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void setSubject(Game_Battler subject)
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler subject()
		{
			throw new System.NotImplementedException();
		}
		public Game_Unit friendsUnit()
		{
			throw new System.NotImplementedException();
		}
		public Game_Unit opponentsUnit()
		{
			throw new System.NotImplementedException();
		}
		public void setEnemyAction(bool action)
		{
			throw new System.NotImplementedException();
		}
		public void setAttack()
		{
			throw new System.NotImplementedException();
		}
		public void setGuard()
		{
			throw new System.NotImplementedException();
		}
		public void setSkill(float skillId)
		{
			throw new System.NotImplementedException();
		}
		public void setItem(float itemId)
		{
			throw new System.NotImplementedException();
		}
		public void setItemObject(IDataItem @object)
		{
			throw new System.NotImplementedException();
		}
		public void setTarget(float targetIndex)
		{
			throw new System.NotImplementedException();
		}
		public IDataItem item()
		{
			throw new System.NotImplementedException();
		}
		public bool isSkill()
		{
			throw new System.NotImplementedException();
		}
		public bool isItem()
		{
			throw new System.NotImplementedException();
		}
		public float numRepeats()
		{
			throw new System.NotImplementedException();
		}
		public bool checkItemScope(float[] list)
		{
			throw new System.NotImplementedException();
		}
		public bool isForOpponent()
		{
			throw new System.NotImplementedException();
		}
		public bool isForFriend()
		{
			throw new System.NotImplementedException();
		}
		public bool isForDeadFriend()
		{
			throw new System.NotImplementedException();
		}
		public bool isForUser()
		{
			throw new System.NotImplementedException();
		}
		public bool isForOne()
		{
			throw new System.NotImplementedException();
		}
		public bool isForRandom()
		{
			throw new System.NotImplementedException();
		}
		public bool isForAll()
		{
			throw new System.NotImplementedException();
		}
		public bool needsSelection()
		{
			throw new System.NotImplementedException();
		}
		public float numTargets()
		{
			throw new System.NotImplementedException();
		}
		public bool checkDamageType(float[] list)
		{
			throw new System.NotImplementedException();
		}
		public bool isHpEffect()
		{
			throw new System.NotImplementedException();
		}
		public bool isMpEffect()
		{
			throw new System.NotImplementedException();
		}
		public bool isDamage()
		{
			throw new System.NotImplementedException();
		}
		public bool isRecover()
		{
			throw new System.NotImplementedException();
		}
		public bool isDrain()
		{
			throw new System.NotImplementedException();
		}
		public bool isHpRecover()
		{
			throw new System.NotImplementedException();
		}
		public bool isMpRecover()
		{
			throw new System.NotImplementedException();
		}
		public bool isCertainHit()
		{
			throw new System.NotImplementedException();
		}
		public bool isPhysical()
		{
			throw new System.NotImplementedException();
		}
		public bool isMagical()
		{
			throw new System.NotImplementedException();
		}
		public bool isAttack()
		{
			throw new System.NotImplementedException();
		}
		public bool isGuard()
		{
			throw new System.NotImplementedException();
		}
		public bool isMagicSkill()
		{
			throw new System.NotImplementedException();
		}
		public void decideRandomTarget()
		{
			throw new System.NotImplementedException();
		}
		public void setConfusion()
		{
			throw new System.NotImplementedException();
		}
		public void prepare()
		{
			throw new System.NotImplementedException();
		}
		public bool isValid()
		{
			throw new System.NotImplementedException();
		}
		public float speed()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] makeTargets()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] repeatTargets(Game_Battler[] targets)
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler confusionTarget()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] targetsForOpponents()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] targetsForFriends()
		{
			throw new System.NotImplementedException();
		}
		public float evaluate()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] itemTargetCandidates()
		{
			throw new System.NotImplementedException();
		}
		public float evaluateWithTarget(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public bool testApply(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float hasItemAnyValidEffects(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float testItemEffect(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public float itemCnt(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float itemMrf(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float itemHit(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float itemEva(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float itemCri(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void apply(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float makeDamageValue(Game_Battler target, bool critical)
		{
			throw new System.NotImplementedException();
		}
		public float evalDamageFormula(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float calcElementRate(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float elementsMaxRate(Game_Battler target, float[] elements)
		{
			throw new System.NotImplementedException();
		}
		public float applyCritical(float damage)
		{
			throw new System.NotImplementedException();
		}
		public float applyVariance(float damage, float variance)
		{
			throw new System.NotImplementedException();
		}
		public float applyGuard(float damage, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void executeDamage(Game_Battler target, float value)
		{
			throw new System.NotImplementedException();
		}
		public void executeHpDamage(Game_Battler target, float value)
		{
			throw new System.NotImplementedException();
		}
		public void executeMpDamage(Game_Battler target, float value)
		{
			throw new System.NotImplementedException();
		}
		public void gainDrainedHp(float value)
		{
			throw new System.NotImplementedException();
		}
		public void gainDrainedMp(float value)
		{
			throw new System.NotImplementedException();
		}
		public void applyItemEffect(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectRecoverHp(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectRecoverMp(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectGainTp(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectAddState(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectAddAttackState(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectAddNormalState(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectRemoveState(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectAddBuff(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectAddDebuff(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectRemoveBuff(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectRemoveDebuff(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectSpecial(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectGrow(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectLearnSkill(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void itemEffectCommonEvent(Game_Battler target, IDataEffect effect)
		{
			throw new System.NotImplementedException();
		}
		public void makeSuccess(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void applyItemUserEffect(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float lukEffectRate(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void applyGlobal()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_ActionResult
	{
		public Game_ActionResult()
		{
			
		}
		public bool used;
		public bool missed;
		public bool evaded;
		public bool physical;
		public bool drain;
		public bool critical;
		public bool success;
		public bool hpAffected;
		public float hpDamage;
		public float mpDamage;
		public float tpDamage;
		public IDataState[] addedStates;
		public IDataState[] removedStates;
		public float[] addedBuffs;
		public float[] addedDebuffs;
		public float[] removedBuffs;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public IDataState[] addedStateObjects()
		{
			throw new System.NotImplementedException();
		}
		public IDataState[] removedStateObjects()
		{
			throw new System.NotImplementedException();
		}
		public bool isStatusAffected()
		{
			throw new System.NotImplementedException();
		}
		public bool isHit()
		{
			throw new System.NotImplementedException();
		}
		public bool isStateAdded(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void pushAddedState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isStateRemoved(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void pushRemovedState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isBuffAdded(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void pushAddedBuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isDebuffAdded(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void pushAddedDebuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isBuffRemoved(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void pushRemovedBuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_BattlerBase
	{
		public Game_BattlerBase()
		{
			
		}
		public static float TRAIT_ELEMENT_RATE;
		public static float TRAIT_DEBUFF_RATE;
		public static float TRAIT_STATE_RATE;
		public static float TRAIT_STATE_RESIST;
		public static float TRAIT_PARAM;
		public static float TRAIT_XPARAM;
		public static float TRAIT_SPARAM;
		public static float TRAIT_ATTACK_ELEMENT;
		public static float TRAIT_ATTACK_STATE;
		public static float TRAIT_ATTACK_SPEED;
		public static float TRAIT_ATTACK_TIMES;
		public static float TRAIT_STYPE_ADD;
		public static float TRAIT_STYPE_SEAL;
		public static float TRAIT_SKILL_ADD;
		public static float TRAIT_SKILL_SEAL;
		public static float TRAIT_EQUIP_WTYPE;
		public static float TRAIT_EQUIP_ATYPE;
		public static float TRAIT_EQUIP_LOCK;
		public static float TRAIT_EQUIP_SEAL;
		public static float TRAIT_SLOT_TYPE;
		public static float TRAIT_ACTION_PLUS;
		public static float TRAIT_SPECIAL_FLAG;
		public static float TRAIT_COLLAPSE_TYPE;
		public static float TRAIT_PARTY_ABILITY;
		public static float FLAG_ID_AUTO_BATTLE;
		public static float FLAG_ID_GUARD;
		public static float FLAG_ID_SUBSTITUTE;
		public static float FLAG_ID_PRESERVE_TP;
		public static float ICON_BUFF_START;
		public static float ICON_DEBUFF_START;
		public float hp;
		public float mp;
		public float tp;
		public float mhp;
		public float mmp;
		public float atk;
		public float mat;
		public float mdf;
		public float agi;
		public float luk;
		public float hit;
		public float eva;
		public float cri;
		public float cev;
		public float mev;
		public float mrf;
		public float cnt;
		public float hrg;
		public float mrg;
		public float trg;
		public float tgr;
		public float grd;
		public float rec;
		public float pha;
		public float mcr;
		public float tcr;
		public float pdr;
		public float mdr;
		public float fdr;
		public float exr;
		public float _hp;
		public float _mp;
		public float _tp;
		public bool _hidden;
		public float[] _paramPlus;
		public float[] _states;
		public Dictionary<float,float> _stateTurns;
		public float[] _buffs;
		public float[] _buffTurns;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void clearParamPlus()
		{
			throw new System.NotImplementedException();
		}
		public void clearStates()
		{
			throw new System.NotImplementedException();
		}
		public void eraseState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isStateAffected(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isDeathStateAffected()
		{
			throw new System.NotImplementedException();
		}
		public float deathStateId()
		{
			throw new System.NotImplementedException();
		}
		public void deathStateId(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void resetStateCounts(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isStateExpired(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void updateStateTurns()
		{
			throw new System.NotImplementedException();
		}
		public void clearBuffs()
		{
			throw new System.NotImplementedException();
		}
		public void eraseBuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float buffLength()
		{
			throw new System.NotImplementedException();
		}
		public float buff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isBuffAffected(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isDebuffAffected(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isBuffOrDebuffAffected(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isMaxBuffAffected(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public bool isMaxDebuffAffected(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void increaseBuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void decreaseBuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void overwriteBuffTurns(float paramId, float turns)
		{
			throw new System.NotImplementedException();
		}
		public bool isBuffExpired(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void updateBuffTurns()
		{
			throw new System.NotImplementedException();
		}
		public void die()
		{
			throw new System.NotImplementedException();
		}
		public void revive()
		{
			throw new System.NotImplementedException();
		}
		public IDataState[] states()
		{
			throw new System.NotImplementedException();
		}
		public float[] stateIcons()
		{
			throw new System.NotImplementedException();
		}
		public float[] buffIcons()
		{
			throw new System.NotImplementedException();
		}
		public float buffIconIndex(float buffLevel, float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float[] allIcons()
		{
			throw new System.NotImplementedException();
		}
		public IDataState[] traitObjects()
		{
			throw new System.NotImplementedException();
		}
		public IDataTrait[] allTraits()
		{
			throw new System.NotImplementedException();
		}
		public IDataTrait[] traits(float code)
		{
			throw new System.NotImplementedException();
		}
		public IDataTrait[] traitsWithId(float code, float id)
		{
			throw new System.NotImplementedException();
		}
		public float traitsPi(float code, float id)
		{
			throw new System.NotImplementedException();
		}
		public float traitsSum(float code, float id)
		{
			throw new System.NotImplementedException();
		}
		public float traitsSumAll(float code)
		{
			throw new System.NotImplementedException();
		}
		public float[] traitsSet(float code)
		{
			throw new System.NotImplementedException();
		}
		public float paramBase(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramPlus(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramMin(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramMax(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramRate(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramBuffRate(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float param(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float xparam(float xparamId)
		{
			throw new System.NotImplementedException();
		}
		public float sparam(float sparamId)
		{
			throw new System.NotImplementedException();
		}
		public float elementRate(float elementId)
		{
			throw new System.NotImplementedException();
		}
		public float debuffRate(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float stateRate(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public float[] stateResistSet()
		{
			throw new System.NotImplementedException();
		}
		public bool isStateResist(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public float[] attackElements()
		{
			throw new System.NotImplementedException();
		}
		public float[] attackStates()
		{
			throw new System.NotImplementedException();
		}
		public float attackStatesRate(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public float attackSpeed()
		{
			throw new System.NotImplementedException();
		}
		public float attackTimesAdd()
		{
			throw new System.NotImplementedException();
		}
		public float[] addedSkillTypes()
		{
			throw new System.NotImplementedException();
		}
		public bool isSkillTypeSealed(float stypeId)
		{
			throw new System.NotImplementedException();
		}
		public float[] addedSkills()
		{
			throw new System.NotImplementedException();
		}
		public bool isSkillSealed(float skillId)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipWtypeOk(float wtypeId)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipAtypeOk(float atypeId)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipTypeLocked(float etypeId)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipTypeSealed(float etypeId)
		{
			throw new System.NotImplementedException();
		}
		public float slotType()
		{
			throw new System.NotImplementedException();
		}
		public bool isDualWield()
		{
			throw new System.NotImplementedException();
		}
		public float[] actionPlusSet()
		{
			throw new System.NotImplementedException();
		}
		public bool specialFlag(float flagId)
		{
			throw new System.NotImplementedException();
		}
		public float collapseType()
		{
			throw new System.NotImplementedException();
		}
		public bool partyAbility(float abilityId)
		{
			throw new System.NotImplementedException();
		}
		public bool isAutoBattle()
		{
			throw new System.NotImplementedException();
		}
		public bool isGuard()
		{
			throw new System.NotImplementedException();
		}
		public bool isSubstitute()
		{
			throw new System.NotImplementedException();
		}
		public bool isPreserveTp()
		{
			throw new System.NotImplementedException();
		}
		public void addParam(float paramId, float value)
		{
			throw new System.NotImplementedException();
		}
		public void setHp(float hp)
		{
			throw new System.NotImplementedException();
		}
		public void setMp(float mp)
		{
			throw new System.NotImplementedException();
		}
		public void setTp(float tp)
		{
			throw new System.NotImplementedException();
		}
		public float maxTp()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void recoverAll()
		{
			throw new System.NotImplementedException();
		}
		public float hpRate()
		{
			throw new System.NotImplementedException();
		}
		public float mpRate()
		{
			throw new System.NotImplementedException();
		}
		public float tpRate()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
		public void appear()
		{
			throw new System.NotImplementedException();
		}
		public bool isHidden()
		{
			throw new System.NotImplementedException();
		}
		public bool isAppeared()
		{
			throw new System.NotImplementedException();
		}
		public bool isDead()
		{
			throw new System.NotImplementedException();
		}
		public bool isAlive()
		{
			throw new System.NotImplementedException();
		}
		public bool isDying()
		{
			throw new System.NotImplementedException();
		}
		public bool isRestricted()
		{
			throw new System.NotImplementedException();
		}
		public bool canInput()
		{
			throw new System.NotImplementedException();
		}
		public bool canMove()
		{
			throw new System.NotImplementedException();
		}
		public bool isConfused()
		{
			throw new System.NotImplementedException();
		}
		public float confusionLevel()
		{
			throw new System.NotImplementedException();
		}
		public bool isActor()
		{
			throw new System.NotImplementedException();
		}
		public bool isEnemy()
		{
			throw new System.NotImplementedException();
		}
		public void sortStates()
		{
			throw new System.NotImplementedException();
		}
		public float restriction()
		{
			throw new System.NotImplementedException();
		}
		public void addNewState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void onRestrict()
		{
			throw new System.NotImplementedException();
		}
		public string mostImportantStateText()
		{
			throw new System.NotImplementedException();
		}
		public float stateMotionIndex()
		{
			throw new System.NotImplementedException();
		}
		public float stateOverlayIndex()
		{
			throw new System.NotImplementedException();
		}
		public bool isSkillWtypeOk(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public float skillMpCost(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public float skillTpCost(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public bool canPaySkillCost(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public void paySkillCost(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public bool isOccasionOk(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsUsableItemConditions(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsSkillConditions(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsItemConditions(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public bool canUse(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool canEquip(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool canEquipWeapon(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool canEquipArmor(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public float attackSkillId()
		{
			throw new System.NotImplementedException();
		}
		public float guardSkillId()
		{
			throw new System.NotImplementedException();
		}
		public bool canAttack()
		{
			throw new System.NotImplementedException();
		}
		public bool canGuard()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IGame_BattlerAnimation
	{
		protected IGame_BattlerAnimation()
		{
			
		}
		public string animationId;
		public bool mirror;
		public float delay;
	}

		public class Game_Battler : Game_BattlerBase
	{
		public Game_Battler() : base()
		{
			
		}
		public Game_Action[] _actions;
		public float _speed;
		public Game_ActionResult _result;
		public string _actionState;
		public float _lastTargetIndex;
		public IGame_BattlerAnimation[] _animations;
		public bool _damagePopup;
		public string _effectType;
		public string _motionType;
		public float _weaponImageId;
		public bool _motionRefresh;
		public bool _selected;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void clearAnimations()
		{
			throw new System.NotImplementedException();
		}
		public void clearDamagePopup()
		{
			throw new System.NotImplementedException();
		}
		public void clearWeaponAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void clearEffect()
		{
			throw new System.NotImplementedException();
		}
		public void clearMotion()
		{
			throw new System.NotImplementedException();
		}
		public void requestEffect(string effectType)
		{
			throw new System.NotImplementedException();
		}
		public void requestMotion(string motionType)
		{
			throw new System.NotImplementedException();
		}
		public void requestMotionRefresh()
		{
			throw new System.NotImplementedException();
		}
		public void select()
		{
			throw new System.NotImplementedException();
		}
		public void deselect()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnimationRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isDamagePopupRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isEffectRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isMotionRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isWeaponAnimationRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isMotionRefreshRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isSelected()
		{
			throw new System.NotImplementedException();
		}
		public string effectType()
		{
			throw new System.NotImplementedException();
		}
		public string motionType()
		{
			throw new System.NotImplementedException();
		}
		public float weaponImageId()
		{
			throw new System.NotImplementedException();
		}
		public IGame_BattlerAnimation shiftAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void startAnimation(float animationId, bool mirror, float delay)
		{
			throw new System.NotImplementedException();
		}
		public void startDamagePopup()
		{
			throw new System.NotImplementedException();
		}
		public void startWeaponAnimation(float weaponImageId)
		{
			throw new System.NotImplementedException();
		}
		public Game_Action action(float index)
		{
			throw new System.NotImplementedException();
		}
		public void setAction(float index, Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public float numActions()
		{
			throw new System.NotImplementedException();
		}
		public void clearActions()
		{
			throw new System.NotImplementedException();
		}
		public Game_ActionResult result()
		{
			throw new System.NotImplementedException();
		}
		public void clearResult()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void addState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isStateAddable(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public bool isStateRestrict(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void onRestrict()
		{
			throw new System.NotImplementedException();
		}
		public void removeState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void escape()
		{
			throw new System.NotImplementedException();
		}
		public void addBuff(float paramId, float turns)
		{
			throw new System.NotImplementedException();
		}
		public void addDebuff(float paramId, float turns)
		{
			throw new System.NotImplementedException();
		}
		public void removeBuff(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void removeBattleStates()
		{
			throw new System.NotImplementedException();
		}
		public void removeAllBuffs()
		{
			throw new System.NotImplementedException();
		}
		public void removeStatesAuto(float timing)
		{
			throw new System.NotImplementedException();
		}
		public void removeBuffsAuto()
		{
			throw new System.NotImplementedException();
		}
		public void removeStatesByDamage()
		{
			throw new System.NotImplementedException();
		}
		public float makeActionTimes()
		{
			throw new System.NotImplementedException();
		}
		public void makeActions()
		{
			throw new System.NotImplementedException();
		}
		public float speed()
		{
			throw new System.NotImplementedException();
		}
		public void makeSpeed()
		{
			throw new System.NotImplementedException();
		}
		public Game_Action currentAction()
		{
			throw new System.NotImplementedException();
		}
		public void removeCurrentAction()
		{
			throw new System.NotImplementedException();
		}
		public void setLastTarnget(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void forceAction(float skillId, float targetIndex)
		{
			throw new System.NotImplementedException();
		}
		public void useItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void consumeItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void gainHp(float value)
		{
			throw new System.NotImplementedException();
		}
		public void gainMp(float value)
		{
			throw new System.NotImplementedException();
		}
		public void gainTp(float value)
		{
			throw new System.NotImplementedException();
		}
		public void gainSilentTp(float value)
		{
			throw new System.NotImplementedException();
		}
		public void initTp()
		{
			throw new System.NotImplementedException();
		}
		public void clearTp()
		{
			throw new System.NotImplementedException();
		}
		public void chargeTpByDamage(float damageRate)
		{
			throw new System.NotImplementedException();
		}
		public void regenerateHp()
		{
			throw new System.NotImplementedException();
		}
		public float maxSlipDamage()
		{
			throw new System.NotImplementedException();
		}
		public void regenerateMp()
		{
			throw new System.NotImplementedException();
		}
		public void regenerateTp()
		{
			throw new System.NotImplementedException();
		}
		public void regenerateAll()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleStart()
		{
			throw new System.NotImplementedException();
		}
		public void onAllActionsEnd()
		{
			throw new System.NotImplementedException();
		}
		public void onTurnEnd()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleEnd()
		{
			throw new System.NotImplementedException();
		}
		public void onDamage(float value)
		{
			throw new System.NotImplementedException();
		}
		public void setActionState(string actionState)
		{
			throw new System.NotImplementedException();
		}
		public bool isUndecided()
		{
			throw new System.NotImplementedException();
		}
		public bool isInputting()
		{
			throw new System.NotImplementedException();
		}
		public bool isWaiting()
		{
			throw new System.NotImplementedException();
		}
		public bool isActing()
		{
			throw new System.NotImplementedException();
		}
		public bool isChanting()
		{
			throw new System.NotImplementedException();
		}
		public bool isGuardWaiting()
		{
			throw new System.NotImplementedException();
		}
		public void performActionStart(Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public void performAction(Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public void performActionEnd()
		{
			throw new System.NotImplementedException();
		}
		public void performDamage()
		{
			throw new System.NotImplementedException();
		}
		public void performMiss()
		{
			throw new System.NotImplementedException();
		}
		public void performRecovery()
		{
			throw new System.NotImplementedException();
		}
		public void performEvasion()
		{
			throw new System.NotImplementedException();
		}
		public void performMagicEvasion()
		{
			throw new System.NotImplementedException();
		}
		public void performCounter()
		{
			throw new System.NotImplementedException();
		}
		public void performReflection()
		{
			throw new System.NotImplementedException();
		}
		public void performSubstitute(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performCollapse()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Actor : Game_Battler
	{
		public Game_Actor() : base()
		{
			
		}
		public float level;
		public float _actorId;
		public string _name;
		public string _nickname;
		public float _classId;
		public float _level;
		public string _characterName;
		public float _characterIndex;
		public string _faceName;
		public float _faceIndex;
		public string _battlerName;
		public Dictionary<float,float> _exp;
		public float[] _skills;
		public Game_Item[] _equips;
		public float _actionInputIndex;
		public Game_Item _lastMenuSkill;
		public Game_Item _lastBattleSkill;
		public string _lastCommandSymbol;
		public string _profile;
        public Dictionary<float, float> _stateSteps;
		public new void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float actorId)
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setup(float actorId)
		{
			throw new System.NotImplementedException();
		}
		public float actorId()
		{
			throw new System.NotImplementedException();
		}
		public IDataActor actor()
		{
			throw new System.NotImplementedException();
		}
		public string name()
		{
			throw new System.NotImplementedException();
		}
		public void setName(string name)
		{
			throw new System.NotImplementedException();
		}
		public string nickname()
		{
			throw new System.NotImplementedException();
		}
		public void setNickname(string nickname)
		{
			throw new System.NotImplementedException();
		}
		public string profile()
		{
			throw new System.NotImplementedException();
		}
		public void setProfile(string profile)
		{
			throw new System.NotImplementedException();
		}
		public string characterName()
		{
			throw new System.NotImplementedException();
		}
		public float characterIndex()
		{
			throw new System.NotImplementedException();
		}
		public string faceName()
		{
			throw new System.NotImplementedException();
		}
		public float faceIndex()
		{
			throw new System.NotImplementedException();
		}
		public string battlerName()
		{
			throw new System.NotImplementedException();
		}
		public void clearStates()
		{
			throw new System.NotImplementedException();
		}
		public void eraseState(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void resetStateCounts(float stateId)
		{
			throw new System.NotImplementedException();
		}
		public void initImages()
		{
			throw new System.NotImplementedException();
		}
		public float expForLevel(float level)
		{
			throw new System.NotImplementedException();
		}
		public void initExp()
		{
			throw new System.NotImplementedException();
		}
		public float currentExp()
		{
			throw new System.NotImplementedException();
		}
		public float currentLevelExp()
		{
			throw new System.NotImplementedException();
		}
		public float nextLevelExp()
		{
			throw new System.NotImplementedException();
		}
		public float nextRequiredExp()
		{
			throw new System.NotImplementedException();
		}
		public float maxLevel()
		{
			throw new System.NotImplementedException();
		}
		public float isMaxLevel()
		{
			throw new System.NotImplementedException();
		}
		public void initSkills()
		{
			throw new System.NotImplementedException();
		}
		public void initEquips(float[] equips)
		{
			throw new System.NotImplementedException();
		}
		public float[] equipSlots()
		{
			throw new System.NotImplementedException();
		}
		public Game_Item[] equips()
		{
			throw new System.NotImplementedException();
		}
		public IDataWeapon[] weapons()
		{
			throw new System.NotImplementedException();
		}
		public IDataArmor[] armors()
		{
			throw new System.NotImplementedException();
		}
		public bool hasWeapon(IDataWeapon weapon)
		{
			throw new System.NotImplementedException();
		}
		public bool hasArmor(IDataArmor armor)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipChangeOk(float slotId)
		{
			throw new System.NotImplementedException();
		}
		public void changeEquip(float slotId, IDataEquipItem item)
		{
			throw new System.NotImplementedException();
		}
		public void forceChangeEquip(float slotId, IDataEquipItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool tradeItemWithParty(IDataEquipItem newItem, IDataEquipItem oldItem)
		{
			throw new System.NotImplementedException();
		}
		public void changeEquipById(float etypeId, float itemId)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipped(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void discardEquip(IDataEquipItem item)
		{
			throw new System.NotImplementedException();
		}
		public void releaseUnequippableItems(bool forcing)
		{
			throw new System.NotImplementedException();
		}
		public void clearEquipments()
		{
			throw new System.NotImplementedException();
		}
		public void optimizeEquipments()
		{
			throw new System.NotImplementedException();
		}
		public IDataEquipItem bestEquipItem(float slotId)
		{
			throw new System.NotImplementedException();
		}
		public float calcEquipItemPerformance(IDataEquipItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isSkillWtypeOk(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public bool isWtypeEquipped(float wtypeId)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public bool isActor()
		{
			throw new System.NotImplementedException();
		}
		public Game_Party friendsUnit()
		{
			throw new System.NotImplementedException();
		}
		public Game_Troop opponentsUnit()
		{
			throw new System.NotImplementedException();
		}
		public float index()
		{
			throw new System.NotImplementedException();
		}
		public bool isBattleMember()
		{
			throw new System.NotImplementedException();
		}
		public bool isFormationChangeOk()
		{
			throw new System.NotImplementedException();
		}
		public IDataClass currentClass()
		{
			throw new System.NotImplementedException();
		}
		public bool isClass(IDataClass gameClass)
		{
			throw new System.NotImplementedException();
		}
		public IDataSkill[] skills()
		{
			throw new System.NotImplementedException();
		}
		public IDataSkill[] usableSkills()
		{
			throw new System.NotImplementedException();
		}
		public IDataState[] traitObjects()
		{
			throw new System.NotImplementedException();
		}
		public float[] attackElements()
		{
			throw new System.NotImplementedException();
		}
		public bool hasNoWeapons()
		{
			throw new System.NotImplementedException();
		}
		public float bareHandsElementId()
		{
			throw new System.NotImplementedException();
		}
		public float paramMax(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramBase(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float paramPlus(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float attackAnimationId1()
		{
			throw new System.NotImplementedException();
		}
		public float attackAnimationId2()
		{
			throw new System.NotImplementedException();
		}
		public float bareHandsAnimationId()
		{
			throw new System.NotImplementedException();
		}
		public void changeExp(float exp, bool show)
		{
			throw new System.NotImplementedException();
		}
		public void levelUp()
		{
			throw new System.NotImplementedException();
		}
		public void levelDown()
		{
			throw new System.NotImplementedException();
		}
		public IDataSkill[] findNewSkills(IDataSkill[] lastSkills)
		{
			throw new System.NotImplementedException();
		}
		public void displayLevelUp(IDataSkill[] newSkills)
		{
			throw new System.NotImplementedException();
		}
		public void gainExp(float exp)
		{
			throw new System.NotImplementedException();
		}
		public float finalExpRate()
		{
			throw new System.NotImplementedException();
		}
		public float benchMembersExpRate()
		{
			throw new System.NotImplementedException();
		}
		public bool shouldDisplayLevelUp()
		{
			throw new System.NotImplementedException();
		}
		public void changeLevel(float level, bool show)
		{
			throw new System.NotImplementedException();
		}
		public void learnSkill(float skillId)
		{
			throw new System.NotImplementedException();
		}
		public void forgetSkill(float skillId)
		{
			throw new System.NotImplementedException();
		}
		public bool isLearnedSkill(float skillId)
		{
			throw new System.NotImplementedException();
		}
		public bool hasSkill(float skillId)
		{
			throw new System.NotImplementedException();
		}
		public void changeClass(float classId, float keepExp)
		{
			throw new System.NotImplementedException();
		}
		public void setCharacterImage(string characterName, float characterIndex)
		{
			throw new System.NotImplementedException();
		}
		public void setFaceImage(string faceName, float faceIndex)
		{
			throw new System.NotImplementedException();
		}
		public void setBattlerImage(string battlerName)
		{
			throw new System.NotImplementedException();
		}
		public bool isSpriteVisible()
		{
			throw new System.NotImplementedException();
		}
		public void startAnimation(float animationId, bool mirror, float delay)
		{
			throw new System.NotImplementedException();
		}
		public void performActionStart(Game_Action aciton)
		{
			throw new System.NotImplementedException();
		}
		public void performAction(Game_Action aciton)
		{
			throw new System.NotImplementedException();
		}
		public void performActionEnd()
		{
			throw new System.NotImplementedException();
		}
		public void performAttack()
		{
			throw new System.NotImplementedException();
		}
		public void performDamage()
		{
			throw new System.NotImplementedException();
		}
		public void performEvasion()
		{
			throw new System.NotImplementedException();
		}
		public void performMagicEvasion()
		{
			throw new System.NotImplementedException();
		}
		public void performCounter()
		{
			throw new System.NotImplementedException();
		}
		public void performCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void performVictory()
		{
			throw new System.NotImplementedException();
		}
		public void performEscape()
		{
			throw new System.NotImplementedException();
		}
		public Game_Action[] makeActionList()
		{
			throw new System.NotImplementedException();
		}
		public void makeAutoBattleActions()
		{
			throw new System.NotImplementedException();
		}
		public void makeConfusionActions()
		{
			throw new System.NotImplementedException();
		}
		public void makeActions()
		{
			throw new System.NotImplementedException();
		}
		public void onPlayerWalk()
		{
			throw new System.NotImplementedException();
		}
		public void updateStateSteps(IDataState state)
		{
			throw new System.NotImplementedException();
		}
		public void showAddedStates()
		{
			throw new System.NotImplementedException();
		}
		public void showRemovedStates()
		{
			throw new System.NotImplementedException();
		}
		public float stepsForTurn()
		{
			throw new System.NotImplementedException();
		}
		public void turnEndOnMap()
		{
			throw new System.NotImplementedException();
		}
		public void checkFloorEffect()
		{
			throw new System.NotImplementedException();
		}
		public void executeFloorDamage()
		{
			throw new System.NotImplementedException();
		}
		public float basicFloorDamage()
		{
			throw new System.NotImplementedException();
		}
		public float maxFloorDamage()
		{
			throw new System.NotImplementedException();
		}
		public void performMapDamage()
		{
			throw new System.NotImplementedException();
		}
		public void clearActions()
		{
			throw new System.NotImplementedException();
		}
		public Game_Action inputtingAction()
		{
			throw new System.NotImplementedException();
		}
		public bool selectNextCommand()
		{
			throw new System.NotImplementedException();
		}
		public bool selectPreviousCommand()
		{
			throw new System.NotImplementedException();
		}
		public IDataSkill lastMenuSkill()
		{
			throw new System.NotImplementedException();
		}
		public void setLastMenuSkill(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public IDataSkill lastBattleSkill()
		{
			throw new System.NotImplementedException();
		}
		public void setLastBattleSkill(IDataSkill skill)
		{
			throw new System.NotImplementedException();
		}
		public string lastCommandSymbol()
		{
			throw new System.NotImplementedException();
		}
		public void setLastCommandSymbol(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public bool testEscape(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsUsableItemConditions(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Enemy : Game_Battler
	{
		public Game_Enemy() : base()
		{
			
		}
		public float _enemyId;
		public string _letter;
		public bool _plural;
		public float _screenX;
		public float _screenY;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float enemyId, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setup(float enemyId, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isEnemy()
		{
			throw new System.NotImplementedException();
		}
		public Game_Troop friendsUnit()
		{
			throw new System.NotImplementedException();
		}
		public Game_Party opponentsUnit()
		{
			throw new System.NotImplementedException();
		}
		public float index()
		{
			throw new System.NotImplementedException();
		}
		public bool isBattleMember()
		{
			throw new System.NotImplementedException();
		}
		public float enemyId()
		{
			throw new System.NotImplementedException();
		}
		public IDataEnemy enemy()
		{
			throw new System.NotImplementedException();
		}
		public IDataState[] traitObjects()
		{
			throw new System.NotImplementedException();
		}
		public float paramBase(float paramId)
		{
			throw new System.NotImplementedException();
		}
		public float exp()
		{
			throw new System.NotImplementedException();
		}
		public float gold()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem[] makeDropItems()
		{
			throw new System.NotImplementedException();
		}
		public float dropItemRate()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem itemObject(float kind, float dataId)
		{
			throw new System.NotImplementedException();
		}
		public bool isSpriteVisible()
		{
			throw new System.NotImplementedException();
		}
		public float screenX()
		{
			throw new System.NotImplementedException();
		}
		public float screenY()
		{
			throw new System.NotImplementedException();
		}
		public string battlerName()
		{
			throw new System.NotImplementedException();
		}
		public float battlerHue()
		{
			throw new System.NotImplementedException();
		}
		public string originalName()
		{
			throw new System.NotImplementedException();
		}
		public string name()
		{
			throw new System.NotImplementedException();
		}
		public string isLetterEmpty()
		{
			throw new System.NotImplementedException();
		}
		public void setLetter(string letter)
		{
			throw new System.NotImplementedException();
		}
		public void setPlural(string plural)
		{
			throw new System.NotImplementedException();
		}
		public void performActionStart(Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public void performAction(Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public void performActionEnd()
		{
			throw new System.NotImplementedException();
		}
		public void performDamage()
		{
			throw new System.NotImplementedException();
		}
		public void performCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void transform(float enemyId)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsCondition(IDataAction action)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsTurnCondition(float param1, float param2)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsHpCondition(float param1, float param2)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsMpCondition(float param1, float param2)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsStateCondition(float param)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsPartyLevelCondition(float param)
		{
			throw new System.NotImplementedException();
		}
		public bool meetsSwitchCondition(float param)
		{
			throw new System.NotImplementedException();
		}
		public bool isActionValid(IDataAction action)
		{
			throw new System.NotImplementedException();
		}
		public IDataAction selectAction(IDataAction[] actionList, float ratingZero)
		{
			throw new System.NotImplementedException();
		}
		public void selectAllActions(IDataAction[] actionList)
		{
			throw new System.NotImplementedException();
		}
		public void makeActions()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Actors
	{
		public Game_Actors()
		{
			
		}
		public Game_Actor[] _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor actor(float actorId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Unit
	{
		public Game_Unit()
		{
			
		}
		public bool _inBattle;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public bool inBattle()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] members()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] aliveMembers()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] deadMembers()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler[] movableMembers()
		{
			throw new System.NotImplementedException();
		}
		public void clearActions()
		{
			throw new System.NotImplementedException();
		}
		public float agility()
		{
			throw new System.NotImplementedException();
		}
		public float tgrSum()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler randomTarget()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler randomDeadTarget()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler smoothTarget()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler smoothDeadTarget()
		{
			throw new System.NotImplementedException();
		}
		public void clearResults()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleStart()
		{
			throw new System.NotImplementedException();
		}
		public void onBattleEnd()
		{
			throw new System.NotImplementedException();
		}
		public void makeActions()
		{
			throw new System.NotImplementedException();
		}
		public void select()
		{
			throw new System.NotImplementedException();
		}
		public bool isAllDead()
		{
			throw new System.NotImplementedException();
		}
		public Game_Battler substituteBattler()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Party : Game_Unit
	{
		public Game_Party() : base()
		{
			
		}
		public static float ABILITY_ENCOUNTER_HALF;
		public static float ABILITY_ENCOUNTER_NONE;
		public static float ABILITY_CANCEL_SURPRISE;
		public static float ABILITY_RAISE_PREEMPTIVE;
		public static float ABILITY_GOLD_DOUBLE;
		public static float ABILITY_DROP_ITEM_DOUBLE;
		public float _gold;
		public float _steps;
		public Game_Item _lastItem;
		public float _menuActorId;
		public float _targetActorId;
		public float[] _actors;
		public Dictionary<float,float> _items;
		public Dictionary<float, float> _weapons;
		public Dictionary<float, float> _armors;

        public new void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initAllItems()
		{
			throw new System.NotImplementedException();
		}
		public bool exists()
		{
			throw new System.NotImplementedException();
		}
		public float size()
		{
			throw new System.NotImplementedException();
		}
		public bool isEmpty()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor[] members()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor[] allMembers()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor[] battleMembers()
		{
			throw new System.NotImplementedException();
		}
		public float maxBattleMembers()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor leader()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor[] reviveBattleMembers()
		{
			throw new System.NotImplementedException();
		}
		public IDataItem[] items()
		{
			throw new System.NotImplementedException();
		}
		public IDataWeapon[] weapons()
		{
			throw new System.NotImplementedException();
		}
		public IDataArmor[] armors()
		{
			throw new System.NotImplementedException();
		}
		public IDataEquipItem[] equipItems()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem[] allItems()
		{
			throw new System.NotImplementedException();
		}
		public object itemContainer(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void setupStartingMembers()
		{
			throw new System.NotImplementedException();
		}
		public string name()
		{
			throw new System.NotImplementedException();
		}
		public void setupBattleTest()
		{
			throw new System.NotImplementedException();
		}
		public void setupBattleTestMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setupBattleTestItems()
		{
			throw new System.NotImplementedException();
		}
		public float highestLevel()
		{
			throw new System.NotImplementedException();
		}
		public void addActor(float actorId)
		{
			throw new System.NotImplementedException();
		}
		public void removeActor(float actorId)
		{
			throw new System.NotImplementedException();
		}
		public float gold()
		{
			throw new System.NotImplementedException();
		}
		public void gainGold(float amount)
		{
			throw new System.NotImplementedException();
		}
		public void loseGold(float amount)
		{
			throw new System.NotImplementedException();
		}
		public float maxGold()
		{
			throw new System.NotImplementedException();
		}
		public float steps()
		{
			throw new System.NotImplementedException();
		}
		public void increaseSteps()
		{
			throw new System.NotImplementedException();
		}
		public float numItems(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public float maxItems(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool hasMaxItems(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool hasItem(IDataAllItem item, bool includeEquip = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public bool isAnyMemberEquipped(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void gainItem(IDataAllItem item, float amount, bool includeEquip)
		{
			throw new System.NotImplementedException();
		}
		public void discardMembersEquip(IDataAllItem item, float amount)
		{
			throw new System.NotImplementedException();
		}
		public void loseItem(IDataAllItem item, float amount, bool includeEquip)
		{
			throw new System.NotImplementedException();
		}
		public void consumeItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool canUse(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool canInput()
		{
			throw new System.NotImplementedException();
		}
		public bool isAllDead()
		{
			throw new System.NotImplementedException();
		}
		public void onPlayerWalk()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor menuActor()
		{
			throw new System.NotImplementedException();
		}
		public void setMenuActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void makeMenuActorNext()
		{
			throw new System.NotImplementedException();
		}
		public void makeMenuActorPrevious()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor targetActor()
		{
			throw new System.NotImplementedException();
		}
		public void setTargetActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem lastItem()
		{
			throw new System.NotImplementedException();
		}
		public void setLastItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void swapOrder(float index1, float index2)
		{
			throw new System.NotImplementedException();
		}
		public object charactersForSavefile()
		{
			throw new System.NotImplementedException();
		}
		public object facesForSavefile()
		{
			throw new System.NotImplementedException();
		}
		public bool partyAbility(float abilityId)
		{
			throw new System.NotImplementedException();
		}
		public bool hasEncounterHalf()
		{
			throw new System.NotImplementedException();
		}
		public bool hasEncounterNone()
		{
			throw new System.NotImplementedException();
		}
		public bool hasCancelSurprise()
		{
			throw new System.NotImplementedException();
		}
		public bool hasRaisePreemptive()
		{
			throw new System.NotImplementedException();
		}
		public bool hasGoldDouble()
		{
			throw new System.NotImplementedException();
		}
		public bool hasDropItemDouble()
		{
			throw new System.NotImplementedException();
		}
		public float ratePreemptive(float troopAgi)
		{
			throw new System.NotImplementedException();
		}
		public float rateSurprise(float troopAgi)
		{
			throw new System.NotImplementedException();
		}
		public void performVictory()
		{
			throw new System.NotImplementedException();
		}
		public void performEscape()
		{
			throw new System.NotImplementedException();
		}
		public void removeBattleStates()
		{
			throw new System.NotImplementedException();
		}
		public void requestMotionRefresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Troop : Game_Unit
	{
		public Game_Troop() : base()
		{
			
		}
		public static string[] LETTER_TABLE_HALF;
		public static string[] LETTER_TABLE_FULL;
		public Game_Interpreter _interpreter;
		public float _turnCount;
		public Game_Enemy[] _enemies;
		public float _troopId;
		public Dictionary<float,bool> _eventFlags;
		public Dictionary<string,float> _namesCount;

		public new void initialize()
		{
			throw new System.NotImplementedException();
		}
		public bool isEventRunning()
		{
			throw new System.NotImplementedException();
		}
		public void updateInterpreter()
		{
			throw new System.NotImplementedException();
		}
		public float turnCount()
		{
			throw new System.NotImplementedException();
		}
		public Game_Enemy[] members()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public IDataTroop troop()
		{
			throw new System.NotImplementedException();
		}
		public void setup(float troopId)
		{
			throw new System.NotImplementedException();
		}
		public void makeUniqueNames()
		{
			throw new System.NotImplementedException();
		}
		public string[] letterTable()
		{
			throw new System.NotImplementedException();
		}
		public string[] enemyNames()
		{
			throw new System.NotImplementedException();
		}
		public bool meetsConditions(IDataPage page)
		{
			throw new System.NotImplementedException();
		}
		public void setupBattleEvent()
		{
			throw new System.NotImplementedException();
		}
		public void increaseTurn()
		{
			throw new System.NotImplementedException();
		}
		public float expTotal()
		{
			throw new System.NotImplementedException();
		}
		public float goldTotal()
		{
			throw new System.NotImplementedException();
		}
		public float goldRate()
		{
			throw new System.NotImplementedException();
		}
		public IDataItem[] makeDropItems()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Map
	{
		public Game_Map()
		{
			
		}
		public Game_Interpreter _interpreter;
		public float _mapId;
		public float _tilesetId;
		public Game_Event[] _events;
		public Game_CommonEvent[] _commonEvents;
		public Game_Vehicle[] _vehicles;
		public float _displayX;
		public float _displayY;
		public bool _nameDisplay;
		public float _scrollDirection;
		public float _scrollRest;
		public float _scrollSpeed;
		public string _parallaxName;
		public bool _parallaxZero;
		public bool _parallaxLoopX;
		public bool _parallaxLoopY;
		public float _parallaxSx;
		public float _parallaxSy;
		public float _parallaxX;
		public float _parallaxY;
		public string _battleback1Name;
		public string _battleback2Name;
		public bool _needsRefresh;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void setup(float mapId)
		{
			throw new System.NotImplementedException();
		}
		public bool isEventRunning()
		{
			throw new System.NotImplementedException();
		}
		public float tileWidth()
		{
			throw new System.NotImplementedException();
		}
		public float tileHeight()
		{
			throw new System.NotImplementedException();
		}
		public float mapId()
		{
			throw new System.NotImplementedException();
		}
		public float tilesetId()
		{
			throw new System.NotImplementedException();
		}
		public float displayX()
		{
			throw new System.NotImplementedException();
		}
		public float displayY()
		{
			throw new System.NotImplementedException();
		}
		public string parallaxName()
		{
			throw new System.NotImplementedException();
		}
		public string battleback1Name()
		{
			throw new System.NotImplementedException();
		}
		public string battleback2Name()
		{
			throw new System.NotImplementedException();
		}
		public void requestRefresh(float mapId)
		{
			throw new System.NotImplementedException();
		}
		public bool isNameDisplayEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void disableNameDisplay()
		{
			throw new System.NotImplementedException();
		}
		public void enableNameDisplay()
		{
			throw new System.NotImplementedException();
		}
		public void createVehicles()
		{
			throw new System.NotImplementedException();
		}
		public void refereshVehicles()
		{
			throw new System.NotImplementedException();
		}
		public Game_Vehicle[] vehicles()
		{
			throw new System.NotImplementedException();
		}
		public Game_Vehicle vehicle(string type)
		{
			throw new System.NotImplementedException();
		}
		public Game_Vehicle boat()
		{
			throw new System.NotImplementedException();
		}
		public Game_Vehicle ship()
		{
			throw new System.NotImplementedException();
		}
		public Game_Vehicle airship()
		{
			throw new System.NotImplementedException();
		}
		public void setupEvents()
		{
			throw new System.NotImplementedException();
		}
		public Game_Event[] events()
		{
			throw new System.NotImplementedException();
		}
		public Game_Event @event(float eventId)
		{
			throw new System.NotImplementedException();
		}
		public void eraseEvent(float eventId)
		{
			throw new System.NotImplementedException();
		}
		public Game_CommonEvent[] parallelCommonEvents()
		{
			throw new System.NotImplementedException();
		}
		public void setupScroll()
		{
			throw new System.NotImplementedException();
		}
		public void setupParallax()
		{
			throw new System.NotImplementedException();
		}
		public void setupBattleback()
		{
			throw new System.NotImplementedException();
		}
		public void setDisplayPos(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float parallaxOx()
		{
			throw new System.NotImplementedException();
		}
		public float parallaxOy()
		{
			throw new System.NotImplementedException();
		}
		public IDataTileset tileset()
		{
			throw new System.NotImplementedException();
		}
		public float[] tilesetFlags()
		{
			throw new System.NotImplementedException();
		}
		public string displayName()
		{
			throw new System.NotImplementedException();
		}
		public float width()
		{
			throw new System.NotImplementedException();
		}
		public float height()
		{
			throw new System.NotImplementedException();
		}
		public float[] data()
		{
			throw new System.NotImplementedException();
		}
		public bool isLoopHorizontal()
		{
			throw new System.NotImplementedException();
		}
		public bool isLoopVertical()
		{
			throw new System.NotImplementedException();
		}
		public bool isDashDisabled()
		{
			throw new System.NotImplementedException();
		}
		public IDataEncounterList encounterList()
		{
			throw new System.NotImplementedException();
		}
		public float encounterStep()
		{
			throw new System.NotImplementedException();
		}
		public bool isOverworld()
		{
			throw new System.NotImplementedException();
		}
		public float screenTileX()
		{
			throw new System.NotImplementedException();
		}
		public float screenTileY()
		{
			throw new System.NotImplementedException();
		}
		public float adjustX(float x)
		{
			throw new System.NotImplementedException();
		}
		public float adjustY(float y)
		{
			throw new System.NotImplementedException();
		}
		public float roundX(float x)
		{
			throw new System.NotImplementedException();
		}
		public float roundY(float y)
		{
			throw new System.NotImplementedException();
		}
		public float xWithDirection(float x, float d)
		{
			throw new System.NotImplementedException();
		}
		public float yWithDirection(float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public float roundXWithDirection(float x, float d)
		{
			throw new System.NotImplementedException();
		}
		public float roundYWithDirection(float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public float deltaX(float x1, float x2)
		{
			throw new System.NotImplementedException();
		}
		public float deltaY(float y1, float y2)
		{
			throw new System.NotImplementedException();
		}
		public float distance(float x1, float y1, float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public float canvasToMapX(float x)
		{
			throw new System.NotImplementedException();
		}
		public float canvasToMapY(float y)
		{
			throw new System.NotImplementedException();
		}
		public void autoplay()
		{
			throw new System.NotImplementedException();
		}
		public void refreshIfNeeded()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void refreshTileEvents()
		{
			throw new System.NotImplementedException();
		}
		public Game_Event[] eventsXy(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public Game_Event[] eventsXyNt(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public Game_Event[] tileEventsXy(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float eventIdXy(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void scrollDown(float distance)
		{
			throw new System.NotImplementedException();
		}
		public void scrollLeft(float distance)
		{
			throw new System.NotImplementedException();
		}
		public void scrollRight(float distance)
		{
			throw new System.NotImplementedException();
		}
		public void scrollUp(float distance)
		{
			throw new System.NotImplementedException();
		}
		public bool isValid(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool checkPassage(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float tileId(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public float[] layeredTiles(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float[] allTiles(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float autotileType(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public bool isPassable(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public bool isBoatPassable(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isShipPassable(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isAirshipLandOk(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool checkLayeredTilesFlags(float x, float y, float bit)
		{
			throw new System.NotImplementedException();
		}
		public bool isLadder(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isBush(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isCounter(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isDamageFloor(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float terrainTag(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float regionId(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void startScroll(float direction, float distance, float speed)
		{
			throw new System.NotImplementedException();
		}
		public bool isScrolling()
		{
			throw new System.NotImplementedException();
		}
		public void update(bool sceneActive)
		{
			throw new System.NotImplementedException();
		}
		public void updateScroll()
		{
			throw new System.NotImplementedException();
		}
		public float scrollDistance()
		{
			throw new System.NotImplementedException();
		}
		public void doScroll(float direction, float distance)
		{
			throw new System.NotImplementedException();
		}
		public void updateEvents()
		{
			throw new System.NotImplementedException();
		}
		public void updateVehicles()
		{
			throw new System.NotImplementedException();
		}
		public void updateParallax()
		{
			throw new System.NotImplementedException();
		}
		public void changeTileset(float tilesetId)
		{
			throw new System.NotImplementedException();
		}
		public void changeBattleback(string battleback1Name, string battleback2Name)
		{
			throw new System.NotImplementedException();
		}
		public void changeParallax(string name, float loopX, float loopY, float sx, float sy)
		{
			throw new System.NotImplementedException();
		}
		public void updateInterpreter()
		{
			throw new System.NotImplementedException();
		}
		public void unlockEvent(float eventId)
		{
			throw new System.NotImplementedException();
		}
		public bool setupStartingEvent()
		{
			throw new System.NotImplementedException();
		}
		public bool setupTestEvent()
		{
			throw new System.NotImplementedException();
		}
		public bool setupStartingMapEvent()
		{
			throw new System.NotImplementedException();
		}
		public bool setupAutorunCommonEvent()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnyEventStarting()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_CommonEvent
	{
		public Game_CommonEvent(float commonEventId)
		{
			
		}
		protected Game_CommonEvent()
		{
			
		}
		public float _commonEventId;
		public Game_Interpreter _interpreter;
		public void initialize(float commonEventId)
		{
			throw new System.NotImplementedException();
		}
		public IDataCommonEvent @event()
		{
			throw new System.NotImplementedException();
		}
		public IDataList list()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public bool isActive()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_CharacterBase
	{
		public Game_CharacterBase()
		{
			
		}
		public float x;
		public float y;
		public float _x;
		public float _y;
		public float _realX;
		public float _realY;
		public float _moveSpeed;
		public float _moveFrequency;
		public float _opacity;
		public float _blendMode;
		public float _direction;
		public float _pattern;
		public float _priorityType;
		public float _tileId;
		public string _characterName;
		public float _characterIndex;
		public bool _isObjectCharacter;
		public bool _walkAnime;
		public bool _stepAnime;
		public bool _directionFix;
		public bool _through;
		public bool _transparent;
		public float _bushDepth;
		public float _animationId;
		public float _balloonId;
		public bool _animationPlaying;
		public bool _balloonPlaying;
		public float _animationCount;
		public float _stopCount;
		public float _jumpCount;
		public float _jumpPeak;
		public bool _movementSuccess;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public bool pos(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool posNt(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float moveSpeed()
		{
			throw new System.NotImplementedException();
		}
		public void setMoveSpeed(float moveSpeed)
		{
			throw new System.NotImplementedException();
		}
		public float moveFrequency()
		{
			throw new System.NotImplementedException();
		}
		public void setMoveFrequency(float moveFrequency)
		{
			throw new System.NotImplementedException();
		}
		public float opacity()
		{
			throw new System.NotImplementedException();
		}
		public void setOpacity(float opacity)
		{
			throw new System.NotImplementedException();
		}
		public float blendMode()
		{
			throw new System.NotImplementedException();
		}
		public void setBlendMode(float blendMode)
		{
			throw new System.NotImplementedException();
		}
		public bool isNormalPriority()
		{
			throw new System.NotImplementedException();
		}
		public void setPriorityType(float priorityType)
		{
			throw new System.NotImplementedException();
		}
		public bool isMoving()
		{
			throw new System.NotImplementedException();
		}
		public bool isJumping()
		{
			throw new System.NotImplementedException();
		}
		public float jumpHeight()
		{
			throw new System.NotImplementedException();
		}
		public bool isStopping()
		{
			throw new System.NotImplementedException();
		}
		public bool checkStop(float threshold)
		{
			throw new System.NotImplementedException();
		}
		public void resetStopCount()
		{
			throw new System.NotImplementedException();
		}
		public float realMoveSpeed()
		{
			throw new System.NotImplementedException();
		}
		public float distancePerFrame()
		{
			throw new System.NotImplementedException();
		}
		public bool isDashing()
		{
			throw new System.NotImplementedException();
		}
		public bool isDebugThrough()
		{
			throw new System.NotImplementedException();
		}
		public void straighten()
		{
			throw new System.NotImplementedException();
		}
		public float reverseDir(float d)
		{
			throw new System.NotImplementedException();
		}
		public bool canPass(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public bool canPassDiagonally(float x, float y, float horz, float vert)
		{
			throw new System.NotImplementedException();
		}
		public bool isMapPassable(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public bool isCollidedWithCharacters(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isCollidedWithEvents(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isCollidedWithVehicles(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void setPosition(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void copyPosition(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
		public void locate(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float direction()
		{
			throw new System.NotImplementedException();
		}
		public void setDirection(float d)
		{
			throw new System.NotImplementedException();
		}
		public bool isTile()
		{
			throw new System.NotImplementedException();
		}
		public bool isObjectCharacter()
		{
			throw new System.NotImplementedException();
		}
		public float shiftY()
		{
			throw new System.NotImplementedException();
		}
		public float scrolledX()
		{
			throw new System.NotImplementedException();
		}
		public float scrolledY()
		{
			throw new System.NotImplementedException();
		}
		public float screenX()
		{
			throw new System.NotImplementedException();
		}
		public float screenY()
		{
			throw new System.NotImplementedException();
		}
		public float screenZ()
		{
			throw new System.NotImplementedException();
		}
		public bool isNearTheScreen()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateStop()
		{
			throw new System.NotImplementedException();
		}
		public void updateJump()
		{
			throw new System.NotImplementedException();
		}
		public void updateMove()
		{
			throw new System.NotImplementedException();
		}
		public void updateAnimation()
		{
			throw new System.NotImplementedException();
		}
		public float animationWait()
		{
			throw new System.NotImplementedException();
		}
		public void updateAnimationCount()
		{
			throw new System.NotImplementedException();
		}
		public void updatePattern()
		{
			throw new System.NotImplementedException();
		}
		public float maxPattern()
		{
			throw new System.NotImplementedException();
		}
		public float pattern()
		{
			throw new System.NotImplementedException();
		}
		public void setPattern(float pattern)
		{
			throw new System.NotImplementedException();
		}
		public bool isOriginalPattern()
		{
			throw new System.NotImplementedException();
		}
		public void resetPattern()
		{
			throw new System.NotImplementedException();
		}
		public void refreshBushDepth()
		{
			throw new System.NotImplementedException();
		}
		public bool isOnLadder()
		{
			throw new System.NotImplementedException();
		}
		public bool isOnBush()
		{
			throw new System.NotImplementedException();
		}
		public bool terrainTag()
		{
			throw new System.NotImplementedException();
		}
		public bool regionId()
		{
			throw new System.NotImplementedException();
		}
		public void increaseSteps()
		{
			throw new System.NotImplementedException();
		}
		public void tileId()
		{
			throw new System.NotImplementedException();
		}
		public string characterName()
		{
			throw new System.NotImplementedException();
		}
		public float characterIndex()
		{
			throw new System.NotImplementedException();
		}
		public void setImage(string characterName, float characterIndex)
		{
			throw new System.NotImplementedException();
		}
		public void setTileImage(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public void checkEventTriggerTouchFront(float d)
		{
			throw new System.NotImplementedException();
		}
		public bool checkEventTriggerTouch(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isMovementSucceeded(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void setMovementSuccess(bool success)
		{
			throw new System.NotImplementedException();
		}
		public void moveStraight(float d)
		{
			throw new System.NotImplementedException();
		}
		public void moveDiagonally(float horz, float vert)
		{
			throw new System.NotImplementedException();
		}
		public void jump(float xPlus, float yPlus)
		{
			throw new System.NotImplementedException();
		}
		public bool hasWalkAnime()
		{
			throw new System.NotImplementedException();
		}
		public void setWalkAnime(bool walkAnime)
		{
			throw new System.NotImplementedException();
		}
		public bool hasStepAnime()
		{
			throw new System.NotImplementedException();
		}
		public void setStepAnime(bool stepAnime)
		{
			throw new System.NotImplementedException();
		}
		public bool isDirectionFixed()
		{
			throw new System.NotImplementedException();
		}
		public void setDirectionFix(bool directionFix)
		{
			throw new System.NotImplementedException();
		}
		public bool isThrough()
		{
			throw new System.NotImplementedException();
		}
		public void setThrough(bool through)
		{
			throw new System.NotImplementedException();
		}
		public bool isTransparent()
		{
			throw new System.NotImplementedException();
		}
		public float bushDepth()
		{
			throw new System.NotImplementedException();
		}
		public void setTransparent(bool transparent)
		{
			throw new System.NotImplementedException();
		}
		public void requestAnimation(float animationId)
		{
			throw new System.NotImplementedException();
		}
		public void requestBalloon(float balloonId)
		{
			throw new System.NotImplementedException();
		}
		public float animationId()
		{
			throw new System.NotImplementedException();
		}
		public float balloonId()
		{
			throw new System.NotImplementedException();
		}
		public void startAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void startBalloon()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnimationPlaying()
		{
			throw new System.NotImplementedException();
		}
		public bool isBalloonPlaying()
		{
			throw new System.NotImplementedException();
		}
		public void endAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void endBalloon()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Character : Game_CharacterBase
	{
		public Game_Character() : base()
		{
			
		}
		public static float ROUTE_END;
		public static float ROUTE_MOVE_DOWN;
		public static float ROUTE_MOVE_LEFT;
		public static float ROUTE_MOVE_RIGHT;
		public static float ROUTE_MOVE_UP;
		public static float ROUTE_MOVE_LOWER_L;
		public static float ROUTE_MOVE_LOWER_R;
		public static float ROUTE_MOVE_UPPER_L;
		public static float ROUTE_MOVE_UPPER_R;
		public static float ROUTE_MOVE_RANDOM;
		public static float ROUTE_MOVE_TOWARD;
		public static float ROUTE_MOVE_AWAY;
		public static float ROUTE_MOVE_FORWARD;
		public static float ROUTE_MOVE_BACKWARD;
		public static float ROUTE_JUMP;
		public static float ROUTE_WAIT;
		public static float ROUTE_TURN_DOWN;
		public static float ROUTE_TURN_LEFT;
		public static float ROUTE_TURN_RIGHT;
		public static float ROUTE_TURN_UP;
		public static float ROUTE_TURN_90D_R;
		public static float ROUTE_TURN_90D_L;
		public static float ROUTE_TURN_180D;
		public static float ROUTE_TURN_90D_R_L;
		public static float ROUTE_TURN_RANDOM;
		public static float ROUTE_TURN_TOWARD;
		public static float ROUTE_TURN_AWAY;
		public static float ROUTE_SWITCH_ON;
		public static float ROUTE_SWITCH_OFF;
		public static float ROUTE_CHANGE_SPEED;
		public static float ROUTE_CHANGE_FREQ;
		public static float ROUTE_WALK_ANIME_ON;
		public static float ROUTE_WALK_ANIME_OFF;
		public static float ROUTE_STEP_ANIME_ON;
		public static float ROUTE_STEP_ANIME_OFF;
		public static float ROUTE_DIR_FIX_ON;
		public static float ROUTE_DIR_FIX_OFF;
		public static float ROUTE_THROUGH_ON;
		public static float ROUTE_THROUGH_OFF;
		public static float ROUTE_TRANSPARENT_ON;
		public static float ROUTE_TRANSPARENT_OFF;
		public static float ROUTE_CHANGE_IMAGE;
		public static float ROUTE_CHANGE_OPACITY;
		public static float ROUTE_CHANGE_BLEND_MODE;
		public static float ROUTE_PLAY_SE;
		public static float ROUTE_SCRIPT;
		public bool _moveRouteForcing;
		public IDataMoveRoute _moveRoute;
		public float _moveRouteIndex;
		public IDataMoveRoute _originalMoveRoute;
		public float _originalMoveRouteIndex;
		public float _waitCount;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void memorizeMoveRoute()
		{
			throw new System.NotImplementedException();
		}
		public void restoreMoveRoute()
		{
			throw new System.NotImplementedException();
		}
		public bool isMoveRouteForcing()
		{
			throw new System.NotImplementedException();
		}
		public void setMoveRoute(IDataMoveRoute moveRoute)
		{
			throw new System.NotImplementedException();
		}
		public void forceMoveRoute(IDataMoveRoute moveRoute)
		{
			throw new System.NotImplementedException();
		}
		public void updateStop()
		{
			throw new System.NotImplementedException();
		}
		public void updateRoutineMove()
		{
			throw new System.NotImplementedException();
		}
		public void processMoveCommand(IDataMoveRouteCommand command)
		{
			throw new System.NotImplementedException();
		}
		public float deltaXFrom(float x)
		{
			throw new System.NotImplementedException();
		}
		public float deltaYFrom(float y)
		{
			throw new System.NotImplementedException();
		}
		public void moveRandom()
		{
			throw new System.NotImplementedException();
		}
		public void moveTowardCharacter(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
		public void moveAwayFromCharacter(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
		public void turnTowardCharacter(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
		public void turnAwayFromCharacter(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
		public void turnTowardPlayer()
		{
			throw new System.NotImplementedException();
		}
		public void turnAwayFromPlayer()
		{
			throw new System.NotImplementedException();
		}
		public void moveTowardPlayer()
		{
			throw new System.NotImplementedException();
		}
		public void moveAwayFromPlayer()
		{
			throw new System.NotImplementedException();
		}
		public void moveForward()
		{
			throw new System.NotImplementedException();
		}
		public void moveBackward()
		{
			throw new System.NotImplementedException();
		}
		public void processRouteEnd()
		{
			throw new System.NotImplementedException();
		}
		public void advanceMoveRouteIndex()
		{
			throw new System.NotImplementedException();
		}
		public void turnRight90()
		{
			throw new System.NotImplementedException();
		}
		public void turnLeft90()
		{
			throw new System.NotImplementedException();
		}
		public void turn180()
		{
			throw new System.NotImplementedException();
		}
		public void turnRightOrLeft90()
		{
			throw new System.NotImplementedException();
		}
		public void turnRandom()
		{
			throw new System.NotImplementedException();
		}
		public float findDirectionTo(float goalX, float goalY)
		{
			throw new System.NotImplementedException();
		}
		public float searchLimit()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Player : Game_Character
	{
		public Game_Player() : base()
		{
			
		}
		public string _vehicleType;
		public bool _vehicleGettingOn;
		public bool _vehicleGettingOff;
		public bool _dashing;
		public bool _needsMapReload;
		public bool _transferring;
		public float _newMapId;
		public float _newX;
		public float _newY;
		public float _newDirection;
		public float _fadeType;
		public Game_Followers _followers;
		public float _encounterCount;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void clearTransferInfo()
		{
			throw new System.NotImplementedException();
		}
		public Game_Followers followers()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public bool isStopping()
		{
			throw new System.NotImplementedException();
		}
		public void reserveTransfer(float mapId, float x, float y, float d, float fadeType)
		{
			throw new System.NotImplementedException();
		}
		public void requestMapReload()
		{
			throw new System.NotImplementedException();
		}
		public bool isTransferring()
		{
			throw new System.NotImplementedException();
		}
		public float newMapId()
		{
			throw new System.NotImplementedException();
		}
		public float fadeType()
		{
			throw new System.NotImplementedException();
		}
		public void performTransfer()
		{
			throw new System.NotImplementedException();
		}
		public bool isMapPassable(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public IVehicle vehicle()
		{
			throw new System.NotImplementedException();
		}
		public bool isInBoat()
		{
			throw new System.NotImplementedException();
		}
		public bool isInShip()
		{
			throw new System.NotImplementedException();
		}
		public bool isInAirship()
		{
			throw new System.NotImplementedException();
		}
		public bool isInVehicle()
		{
			throw new System.NotImplementedException();
		}
		public bool isNormal()
		{
			throw new System.NotImplementedException();
		}
		public bool isDashing()
		{
			throw new System.NotImplementedException();
		}
		public bool isDebugThrough()
		{
			throw new System.NotImplementedException();
		}
		public bool isCollided(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float centerX()
		{
			throw new System.NotImplementedException();
		}
		public float centerY()
		{
			throw new System.NotImplementedException();
		}
		public void center(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void locate(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void increaseSteps()
		{
			throw new System.NotImplementedException();
		}
		public void makeEncounterCount()
		{
			throw new System.NotImplementedException();
		}
		public float makeEncounterTroopId()
		{
			throw new System.NotImplementedException();
		}
		public bool meetsEncounterConditions(IDataEncounterList encounter)
		{
			throw new System.NotImplementedException();
		}
		public bool executeEncounter()
		{
			throw new System.NotImplementedException();
		}
		public void startMapEvent(float x, float y, float[] triggers, bool normal)
		{
			throw new System.NotImplementedException();
		}
		public void moveByInput()
		{
			throw new System.NotImplementedException();
		}
		public bool canMove()
		{
			throw new System.NotImplementedException();
		}
		public float getInputDirection()
		{
			throw new System.NotImplementedException();
		}
		public void executeMove(float direction)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void update(bool sceneActive)
		{
			throw new System.NotImplementedException();
		}
		public void updateDashing()
		{
			throw new System.NotImplementedException();
		}
		public bool isDashButtonPressed()
		{
			throw new System.NotImplementedException();
		}
		public void updateScroll(float lastScrolledX, float lastScrolledY)
		{
			throw new System.NotImplementedException();
		}
		public void updateVehicle()
		{
			throw new System.NotImplementedException();
		}
		public void updateVehicleGetOn()
		{
			throw new System.NotImplementedException();
		}
		public void updateVehicleGetOff()
		{
			throw new System.NotImplementedException();
		}
		public void updateNonmoving(bool wasMoving)
		{
			throw new System.NotImplementedException();
		}
		public bool triggerAction()
		{
			throw new System.NotImplementedException();
		}
		public bool triggerButtonAction()
		{
			throw new System.NotImplementedException();
		}
		public bool triggerTouchAction()
		{
			throw new System.NotImplementedException();
		}
		public bool triggerTouchActionD1(float x1, float y1)
		{
			throw new System.NotImplementedException();
		}
		public bool triggerTouchActionD2(float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public bool triggerTouchActionD3(float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public void updateEncounterCount()
		{
			throw new System.NotImplementedException();
		}
		public bool canEncounter()
		{
			throw new System.NotImplementedException();
		}
		public float encounterProgressValue()
		{
			throw new System.NotImplementedException();
		}
		public void checkEventTriggerHere(float[] triggers)
		{
			throw new System.NotImplementedException();
		}
		public void checkEventTriggerThere(float[] triggers)
		{
			throw new System.NotImplementedException();
		}
		public bool checkEventTriggerTouch(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool canStartLocalEvents()
		{
			throw new System.NotImplementedException();
		}
		public bool getOnOffVehicle()
		{
			throw new System.NotImplementedException();
		}
		public bool getOnVehicle()
		{
			throw new System.NotImplementedException();
		}
		public bool getOffVehicle()
		{
			throw new System.NotImplementedException();
		}
		public void forceMoveForward()
		{
			throw new System.NotImplementedException();
		}
		public bool isOnDamageFloor()
		{
			throw new System.NotImplementedException();
		}
		public void moveStraight()
		{
			throw new System.NotImplementedException();
		}
		public void moveDiagonally()
		{
			throw new System.NotImplementedException();
		}
		public void jump(float xPlus, float yPlus)
		{
			throw new System.NotImplementedException();
		}
		public void showFollowers()
		{
			throw new System.NotImplementedException();
		}
		public void hideFollowers()
		{
			throw new System.NotImplementedException();
		}
		public void gatherFollowers()
		{
			throw new System.NotImplementedException();
		}
		public bool areFollowersGathering()
		{
			throw new System.NotImplementedException();
		}
		public bool areFollowersGathered()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Follower : Game_Character
	{
		public Game_Follower() : base()
		{
			
		}
		public float _memberIndex;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor actor()
		{
			throw new System.NotImplementedException();
		}
		public bool isVisible()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void chaseCharacter(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Followers : Game_Character
	{
		public Game_Followers() : base()
		{
			
		}
		public bool _visible;
		public bool _gathering;
		public Game_Follower[] _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public bool isVisible()
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
		public Game_Follower follower(float index)
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Function callback, object thisObject)
		{
			throw new System.NotImplementedException();
		}
		public void reverseEach(Function callback, object thisObject)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateMove()
		{
			throw new System.NotImplementedException();
		}
		public void jumpAll()
		{
			throw new System.NotImplementedException();
		}
		public void synchronize(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public void gather()
		{
			throw new System.NotImplementedException();
		}
		public bool areGathering()
		{
			throw new System.NotImplementedException();
		}
		public bool visibleFollowers()
		{
			throw new System.NotImplementedException();
		}
		public bool areMoving()
		{
			throw new System.NotImplementedException();
		}
		public bool areGathered()
		{
			throw new System.NotImplementedException();
		}
		public bool isSomeoneCollided()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Vehicle : Game_Character
	{
		public Game_Vehicle() : base()
		{
			
		}
		public string _type;
		public float _mapId;
		public float _altitude;
		public bool _driving;
		public IAudioObject _bgm;
		public bool isAirship;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public bool isBoat()
		{
			throw new System.NotImplementedException();
		}
		public bool isShip()
		{
			throw new System.NotImplementedException();
		}
		public void resetDirection()
		{
			throw new System.NotImplementedException();
		}
		public void initMoveSpeed()
		{
			throw new System.NotImplementedException();
		}
		public Game_Vehicle vehicle()
		{
			throw new System.NotImplementedException();
		}
		public void loadSystemSettings()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void setLocation(float mapId, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool pos(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isMapPassable(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
		public void getOn()
		{
			throw new System.NotImplementedException();
		}
		public void getOff()
		{
			throw new System.NotImplementedException();
		}
		public void setBgm(IAudioObject bgm)
		{
			throw new System.NotImplementedException();
		}
		public void playBgm()
		{
			throw new System.NotImplementedException();
		}
		public void syncWithPlayer()
		{
			throw new System.NotImplementedException();
		}
		public float screenY()
		{
			throw new System.NotImplementedException();
		}
		public float shadowX()
		{
			throw new System.NotImplementedException();
		}
		public float shadowY()
		{
			throw new System.NotImplementedException();
		}
		public float shadowOpacity()
		{
			throw new System.NotImplementedException();
		}
		public bool canMove()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateAirship()
		{
			throw new System.NotImplementedException();
		}
		public void updateAirshipAltitude()
		{
			throw new System.NotImplementedException();
		}
		public float maxAltitude()
		{
			throw new System.NotImplementedException();
		}
		public bool isLowest()
		{
			throw new System.NotImplementedException();
		}
		public bool isHighest()
		{
			throw new System.NotImplementedException();
		}
		public bool isTakeoffOk()
		{
			throw new System.NotImplementedException();
		}
		public bool isLandOk(float x, float y, float d)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Event : Game_Character
	{
		public Game_Event() : base()
		{
			
		}
		public Game_Event(float mapId, float eventId) : base()
		{
			
		}
		public float _mapId;
		public float _eventId;
		public float _moveType;
		public float _trigger;
		public bool _starting;
		public bool _erased;
		public float _pageIndex;
		public float _originalPattern;
		public float _originalDirection;
		public float _prelockDirection;
		public bool _locked;
		public Game_Interpreter _interpreter;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float mapId, float eventId)
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public float eventId()
		{
			throw new System.NotImplementedException();
		}
		public IDataMapEvent @event()
		{
			throw new System.NotImplementedException();
		}
		public IDataMapEventPage page()
		{
			throw new System.NotImplementedException();
		}
		public IDataMapEventPageList list()
		{
			throw new System.NotImplementedException();
		}
		public bool isCollidedWithCharacters()
		{
			throw new System.NotImplementedException();
		}
		public bool isCollidedWithEvents()
		{
			throw new System.NotImplementedException();
		}
		public bool isCollidedWithPlayerCharacters()
		{
			throw new System.NotImplementedException();
		}
		public void @lock()
		{
			throw new System.NotImplementedException();
		}
		public void unlock()
		{
			throw new System.NotImplementedException();
		}
		public void updateStop()
		{
			throw new System.NotImplementedException();
		}
		public void updateSelfMovement()
		{
			throw new System.NotImplementedException();
		}
		public float stopCountThreshold()
		{
			throw new System.NotImplementedException();
		}
		public void moveTypeRandom()
		{
			throw new System.NotImplementedException();
		}
		public void moveTypeTowardPlayer()
		{
			throw new System.NotImplementedException();
		}
		public float isNearThePlayer()
		{
			throw new System.NotImplementedException();
		}
		public void moveTypeCustom()
		{
			throw new System.NotImplementedException();
		}
		public bool isStarting()
		{
			throw new System.NotImplementedException();
		}
		public void clearStartingFlag()
		{
			throw new System.NotImplementedException();
		}
		public bool isTriggerIn(float[] triggers)
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void erase()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public float findProperPageIndex()
		{
			throw new System.NotImplementedException();
		}
		public bool meetsConditions(IDataMapEventPage page)
		{
			throw new System.NotImplementedException();
		}
		public void setupPage()
		{
			throw new System.NotImplementedException();
		}
		public void clearPageSettings()
		{
			throw new System.NotImplementedException();
		}
		public void setupPageSettings()
		{
			throw new System.NotImplementedException();
		}
		public bool isOriginalPattern()
		{
			throw new System.NotImplementedException();
		}
		public void resetPattern()
		{
			throw new System.NotImplementedException();
		}
		public void checkEventTriggerTouch(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void checkEventTriggerAuto()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateParallel()
		{
			throw new System.NotImplementedException();
		}
		public void locate(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void forceMoveRoute(IDataMoveRoute moveRoute)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Game_Interpreter
	{
		public Game_Interpreter(float depth = default(float))
		{
			
		}
		protected Game_Interpreter()
		{
			
		}
		public float _depth;
		public Dictionary<float,float> _branch;
		public object[] _params;
		public float _indent;
		public float _frameCount;
		public float _freezeChecker;
		public float _mapId;
		public float _eventId;
		public IDataMapEventPageList[] _list;
		public float _index;
		public Game_Interpreter _childInterpreter;
		public Game_Character _character;
		public void initialize(float depth = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void checkOverflow()
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void setup(IDataMapEventPageList[] list, float eventId = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float eventId()
		{
			throw new System.NotImplementedException();
		}
		public bool isOnCurrentMap()
		{
			throw new System.NotImplementedException();
		}
		public bool setupReservedCommonEvent()
		{
			throw new System.NotImplementedException();
		}
		public bool isRunning()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public bool updateChild()
		{
			throw new System.NotImplementedException();
		}
		public bool updateWait()
		{
			throw new System.NotImplementedException();
		}
		public bool updateWaitCount()
		{
			throw new System.NotImplementedException();
		}
		public bool updateWaitMode()
		{
			throw new System.NotImplementedException();
		}
		public void setWaitMode(string waitMode)
		{
			throw new System.NotImplementedException();
		}
		public void wait(float duration)
		{
			throw new System.NotImplementedException();
		}
		public float fadeSpeed()
		{
			throw new System.NotImplementedException();
		}
		public bool executeCommand()
		{
			throw new System.NotImplementedException();
		}
		public bool checkFreeze()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public void skipBranch()
		{
			throw new System.NotImplementedException();
		}
		public IDataMapEventPageList currentCommand()
		{
			throw new System.NotImplementedException();
		}
		public float nextEventCode()
		{
			throw new System.NotImplementedException();
		}
		public void iterateActorId(float param, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public void iterateActorEx(float param1, float param2, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public void iterateActorIndex(float param, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public void iterateEnemyIndex(float param, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public void iterateBattler(float param1, float param2, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public Game_Character character(float param)
		{
			throw new System.NotImplementedException();
		}
		public float operateValue(float operation, float operandType, float operand)
		{
			throw new System.NotImplementedException();
		}
		public void changeHp(Game_Battler target, float value, bool allowDeath)
		{
			throw new System.NotImplementedException();
		}
		public bool command101()
		{
			throw new System.NotImplementedException();
		}
		public bool command102()
		{
			throw new System.NotImplementedException();
		}
		public void setupChoices(Func<object, object> @params)
		{
			throw new System.NotImplementedException();
		}
		public bool command402()
		{
			throw new System.NotImplementedException();
		}
		public bool command403()
		{
			throw new System.NotImplementedException();
		}
		public bool command103()
		{
			throw new System.NotImplementedException();
		}
		public void setupNumInput(Func<object, object> @params)
		{
			throw new System.NotImplementedException();
		}
		public bool command104()
		{
			throw new System.NotImplementedException();
		}
		public void setupItemChoice(Func<object, object> @params)
		{
			throw new System.NotImplementedException();
		}
		public bool command105()
		{
			throw new System.NotImplementedException();
		}
		public bool command108()
		{
			throw new System.NotImplementedException();
		}
		public bool command111()
		{
			throw new System.NotImplementedException();
		}
		public bool command411()
		{
			throw new System.NotImplementedException();
		}
		public bool command112()
		{
			throw new System.NotImplementedException();
		}
		public bool command413()
		{
			throw new System.NotImplementedException();
		}
		public bool command113()
		{
			throw new System.NotImplementedException();
		}
		public bool command115()
		{
			throw new System.NotImplementedException();
		}
		public bool command117()
		{
			throw new System.NotImplementedException();
		}
		public void setupChild(IDataMapEventPageList[] list, float eventId)
		{
			throw new System.NotImplementedException();
		}
		public bool command118()
		{
			throw new System.NotImplementedException();
		}
		public bool command119()
		{
			throw new System.NotImplementedException();
		}
		public void jumpTo(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool command121()
		{
			throw new System.NotImplementedException();
		}
		public bool command122()
		{
			throw new System.NotImplementedException();
		}
		public float gameDataOperand(float type, float param1, float param2)
		{
			throw new System.NotImplementedException();
		}
		public void operateVariable(float variableId, float operationType, float value)
		{
			throw new System.NotImplementedException();
		}
		public bool command123()
		{
			throw new System.NotImplementedException();
		}
		public bool command124()
		{
			throw new System.NotImplementedException();
		}
		public bool command125()
		{
			throw new System.NotImplementedException();
		}
		public bool command126()
		{
			throw new System.NotImplementedException();
		}
		public bool command127()
		{
			throw new System.NotImplementedException();
		}
		public bool command128()
		{
			throw new System.NotImplementedException();
		}
		public bool command129()
		{
			throw new System.NotImplementedException();
		}
		public bool command132()
		{
			throw new System.NotImplementedException();
		}
		public bool command133()
		{
			throw new System.NotImplementedException();
		}
		public bool command134()
		{
			throw new System.NotImplementedException();
		}
		public bool command135()
		{
			throw new System.NotImplementedException();
		}
		public bool command136()
		{
			throw new System.NotImplementedException();
		}
		public bool command137()
		{
			throw new System.NotImplementedException();
		}
		public bool command138()
		{
			throw new System.NotImplementedException();
		}
		public bool command139()
		{
			throw new System.NotImplementedException();
		}
		public bool command140()
		{
			throw new System.NotImplementedException();
		}
		public bool command201()
		{
			throw new System.NotImplementedException();
		}
		public bool command202()
		{
			throw new System.NotImplementedException();
		}
		public bool command203()
		{
			throw new System.NotImplementedException();
		}
		public bool command204()
		{
			throw new System.NotImplementedException();
		}
		public bool command205()
		{
			throw new System.NotImplementedException();
		}
		public bool command206()
		{
			throw new System.NotImplementedException();
		}
		public bool command211()
		{
			throw new System.NotImplementedException();
		}
		public bool command212()
		{
			throw new System.NotImplementedException();
		}
		public bool command213()
		{
			throw new System.NotImplementedException();
		}
		public bool command214()
		{
			throw new System.NotImplementedException();
		}
		public bool command216()
		{
			throw new System.NotImplementedException();
		}
		public bool command217()
		{
			throw new System.NotImplementedException();
		}
		public bool command221()
		{
			throw new System.NotImplementedException();
		}
		public bool command222()
		{
			throw new System.NotImplementedException();
		}
		public bool command223()
		{
			throw new System.NotImplementedException();
		}
		public bool command224()
		{
			throw new System.NotImplementedException();
		}
		public bool command225()
		{
			throw new System.NotImplementedException();
		}
		public bool command230()
		{
			throw new System.NotImplementedException();
		}
		public bool command231()
		{
			throw new System.NotImplementedException();
		}
		public bool command232()
		{
			throw new System.NotImplementedException();
		}
		public bool command233()
		{
			throw new System.NotImplementedException();
		}
		public bool command234()
		{
			throw new System.NotImplementedException();
		}
		public bool command235()
		{
			throw new System.NotImplementedException();
		}
		public bool command236()
		{
			throw new System.NotImplementedException();
		}
		public bool command241()
		{
			throw new System.NotImplementedException();
		}
		public bool command242()
		{
			throw new System.NotImplementedException();
		}
		public bool command243()
		{
			throw new System.NotImplementedException();
		}
		public bool command244()
		{
			throw new System.NotImplementedException();
		}
		public bool command245()
		{
			throw new System.NotImplementedException();
		}
		public bool command246()
		{
			throw new System.NotImplementedException();
		}
		public bool command249()
		{
			throw new System.NotImplementedException();
		}
		public bool command250()
		{
			throw new System.NotImplementedException();
		}
		public bool command251()
		{
			throw new System.NotImplementedException();
		}
		public bool command261()
		{
			throw new System.NotImplementedException();
		}
		public string videoFileExt()
		{
			throw new System.NotImplementedException();
		}
		public bool command281()
		{
			throw new System.NotImplementedException();
		}
		public bool command282()
		{
			throw new System.NotImplementedException();
		}
		public bool command283()
		{
			throw new System.NotImplementedException();
		}
		public bool command284()
		{
			throw new System.NotImplementedException();
		}
		public bool command285()
		{
			throw new System.NotImplementedException();
		}
		public bool command301()
		{
			throw new System.NotImplementedException();
		}
		public bool command601()
		{
			throw new System.NotImplementedException();
		}
		public bool command602()
		{
			throw new System.NotImplementedException();
		}
		public bool command603()
		{
			throw new System.NotImplementedException();
		}
		public bool command302()
		{
			throw new System.NotImplementedException();
		}
		public bool command311()
		{
			throw new System.NotImplementedException();
		}
		public bool command312()
		{
			throw new System.NotImplementedException();
		}
		public bool command326()
		{
			throw new System.NotImplementedException();
		}
		public bool command313()
		{
			throw new System.NotImplementedException();
		}
		public bool command314()
		{
			throw new System.NotImplementedException();
		}
		public bool command315()
		{
			throw new System.NotImplementedException();
		}
		public bool command316()
		{
			throw new System.NotImplementedException();
		}
		public bool command317()
		{
			throw new System.NotImplementedException();
		}
		public bool command318()
		{
			throw new System.NotImplementedException();
		}
		public bool command319()
		{
			throw new System.NotImplementedException();
		}
		public bool command320()
		{
			throw new System.NotImplementedException();
		}
		public bool command321()
		{
			throw new System.NotImplementedException();
		}
		public bool command322()
		{
			throw new System.NotImplementedException();
		}
		public bool command323()
		{
			throw new System.NotImplementedException();
		}
		public bool command324()
		{
			throw new System.NotImplementedException();
		}
		public bool command325()
		{
			throw new System.NotImplementedException();
		}
		public bool command331()
		{
			throw new System.NotImplementedException();
		}
		public bool command332()
		{
			throw new System.NotImplementedException();
		}
		public bool command342()
		{
			throw new System.NotImplementedException();
		}
		public bool command333()
		{
			throw new System.NotImplementedException();
		}
		public bool command334()
		{
			throw new System.NotImplementedException();
		}
		public bool command335()
		{
			throw new System.NotImplementedException();
		}
		public bool command336()
		{
			throw new System.NotImplementedException();
		}
		public bool command337()
		{
			throw new System.NotImplementedException();
		}
		public bool command339()
		{
			throw new System.NotImplementedException();
		}
		public bool command340()
		{
			throw new System.NotImplementedException();
		}
		public bool command351()
		{
			throw new System.NotImplementedException();
		}
		public bool command352()
		{
			throw new System.NotImplementedException();
		}
		public bool command353()
		{
			throw new System.NotImplementedException();
		}
		public bool command354()
		{
			throw new System.NotImplementedException();
		}
		public bool command355()
		{
			throw new System.NotImplementedException();
		}
		public bool command356()
		{
			throw new System.NotImplementedException();
		}
		public void pluginCommand(string command, string[] args)
		{
			throw new System.NotImplementedException();
		}
		public void requestImages(object list, object commonList)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Base : Stage
	{
		public Scene_Base() : base()
		{
			
		}
		public bool _active;
		public float _fadeSign;
		public float _fadeDuration;
		public ScreenSprite _fadeSprite;
		public WindowLayer _windowLayer;
		public Spriteset_Base _spriteset;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public bool isActive()
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public bool isBusy()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public void createWindowLayer()
		{
			throw new System.NotImplementedException();
		}
		public void addWindow(Window_Base window)
		{
			throw new System.NotImplementedException();
		}
		public void startFadeIn(float duration = default(float), bool white = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void startFadeOut(float duration = default(float), bool white = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void createFadeSprite(bool white = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void updateFade()
		{
			throw new System.NotImplementedException();
		}
		public void updateChildren()
		{
			throw new System.NotImplementedException();
		}
		public void popScene()
		{
			throw new System.NotImplementedException();
		}
		public void checkGameover()
		{
			throw new System.NotImplementedException();
		}
		public void fadeOutAll()
		{
			throw new System.NotImplementedException();
		}
		public float fadeSpeed()
		{
			throw new System.NotImplementedException();
		}
		public float slowFadeSpeed()
		{
			throw new System.NotImplementedException();
		}
		public void attachReservation()
		{
			throw new System.NotImplementedException();
		}
		public void detachReservation()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Boot : Scene_Base
	{
		public Scene_Boot() : base()
		{
			
		}
		public float _startDate;
		public static void loadSystemImages()
		{
			throw new System.NotImplementedException();
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void loadSystemWindowImage()
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public bool isGameFontLoaded()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void updateDocumentTitle()
		{
			throw new System.NotImplementedException();
		}
		public void checkPlayerLocation()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Title : Scene_Base
	{
		public Scene_Title() : base()
		{
			
		}
		public Window_TitleCommand _commandWindow;
		public Sprite _backSprite1;
		public Sprite _backSprite2;
		public Sprite _gameTitleSprite;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public bool isBusy()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public void createBackground()
		{
			throw new System.NotImplementedException();
		}
		public void createForeground()
		{
			throw new System.NotImplementedException();
		}
		public void drawGameTitle()
		{
			throw new System.NotImplementedException();
		}
		public void centerSprite(Sprite_Base sprite)
		{
			throw new System.NotImplementedException();
		}
		public void createCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void commandNewGame()
		{
			throw new System.NotImplementedException();
		}
		public void commandContinue()
		{
			throw new System.NotImplementedException();
		}
		public void commandOptions()
		{
			throw new System.NotImplementedException();
		}
		public void playTitleMusic()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Map : Scene_Base
	{
		public Scene_Map() : base()
		{
			
		}
		public float _waitCount;
		public float _encounterEffectDuration;
		public bool _mapLoaded;
		public Window_MapName _mapNameWindow;
		public Window_Message _messageWindow;
		public Window_ScrollText _scrollTextWindow;
		public Spriteset_Map _spriteset;
		public float _touchCount;
		public bool _transfer;
		public bool menuCalling;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public void onMapLoaded()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateMainMultiply()
		{
			throw new System.NotImplementedException();
		}
		public void updateMain()
		{
			throw new System.NotImplementedException();
		}
		public bool isFastForward()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public bool isBusy()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public bool needsFadeIn()
		{
			throw new System.NotImplementedException();
		}
		public bool needsSlowFadeOut()
		{
			throw new System.NotImplementedException();
		}
		public bool updateWaitCount()
		{
			throw new System.NotImplementedException();
		}
		public void updateDestination()
		{
			throw new System.NotImplementedException();
		}
		public bool isMapTouchOk()
		{
			throw new System.NotImplementedException();
		}
		public void processMapTouch()
		{
			throw new System.NotImplementedException();
		}
		public bool isSceneChangeOk()
		{
			throw new System.NotImplementedException();
		}
		public void updateScene()
		{
			throw new System.NotImplementedException();
		}
		public void createDisplayObjects()
		{
			throw new System.NotImplementedException();
		}
		public void createSpriteset()
		{
			throw new System.NotImplementedException();
		}
		public void createAllWindows()
		{
			throw new System.NotImplementedException();
		}
		public void createMapNameWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createMessageWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createScrollTextWindow()
		{
			throw new System.NotImplementedException();
		}
		public void updateTransferPlayer()
		{
			throw new System.NotImplementedException();
		}
		public void updateEncounter()
		{
			throw new System.NotImplementedException();
		}
		public void updateCallMenu()
		{
			throw new System.NotImplementedException();
		}
		public bool isMenuEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isMenuCalled()
		{
			throw new System.NotImplementedException();
		}
		public void callMenu()
		{
			throw new System.NotImplementedException();
		}
		public void updateCallDebug()
		{
			throw new System.NotImplementedException();
		}
		public bool isDebugCalled()
		{
			throw new System.NotImplementedException();
		}
		public void fadeInForTransfer()
		{
			throw new System.NotImplementedException();
		}
		public void fadeOutForTransfer()
		{
			throw new System.NotImplementedException();
		}
		public void launchBattle()
		{
			throw new System.NotImplementedException();
		}
		public void stopAudioOnBattleStart()
		{
			throw new System.NotImplementedException();
		}
		public void startEncounterEffect()
		{
			throw new System.NotImplementedException();
		}
		public void updateEncounterEffect()
		{
			throw new System.NotImplementedException();
		}
		public void snapForBattleBackground()
		{
			throw new System.NotImplementedException();
		}
		public void startFlashForEncounter(float duration)
		{
			throw new System.NotImplementedException();
		}
		public float encounterEffectSpeed()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_MenuBase : Scene_Base
	{
		public Scene_MenuBase() : base()
		{
			
		}
		public Game_Actor _actor;
		public Sprite _backgroundSprite;
		public Window_Help _helpWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor actor()
		{
			throw new System.NotImplementedException();
		}
		public void updateActor()
		{
			throw new System.NotImplementedException();
		}
		public void createBackground()
		{
			throw new System.NotImplementedException();
		}
		public void setBackgroundOpacity(float opacity)
		{
			throw new System.NotImplementedException();
		}
		public void createHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public void nextActor()
		{
			throw new System.NotImplementedException();
		}
		public void previousActor()
		{
			throw new System.NotImplementedException();
		}
		public void onActorChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Menu : Scene_MenuBase
	{
		public Scene_Menu() : base()
		{
			
		}
		public Window_MenuStatus _statusWindow;
		public Window_Gold _goldWindow;
		public Window_MenuCommand _commandWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void createCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createGoldWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createStatusWindow()
		{
			throw new System.NotImplementedException();
		}
		public void commandItem()
		{
			throw new System.NotImplementedException();
		}
		public void commandPersonal()
		{
			throw new System.NotImplementedException();
		}
		public void commandFormation()
		{
			throw new System.NotImplementedException();
		}
		public void commandOptions()
		{
			throw new System.NotImplementedException();
		}
		public void commandSave()
		{
			throw new System.NotImplementedException();
		}
		public void commandGameEnd()
		{
			throw new System.NotImplementedException();
		}
		public void onPersonalOk()
		{
			throw new System.NotImplementedException();
		}
		public void onPersonalCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onFormationOk()
		{
			throw new System.NotImplementedException();
		}
		public void onFormationCancel()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_ItemBase : Scene_MenuBase
	{
		public Scene_ItemBase() : base()
		{
			
		}
		public Window_MenuActor _actorWindow;
		public Window_Selectable _itemWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void createActorWindow()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem item()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor user()
		{
			throw new System.NotImplementedException();
		}
		public bool isCursorLeft()
		{
			throw new System.NotImplementedException();
		}
		public void showSubWindow(Window_Base window)
		{
			throw new System.NotImplementedException();
		}
		public void hideSubWindow(Window_Base window)
		{
			throw new System.NotImplementedException();
		}
		public void onActorOk()
		{
			throw new System.NotImplementedException();
		}
		public void onActorCancel()
		{
			throw new System.NotImplementedException();
		}
		public void determineItem()
		{
			throw new System.NotImplementedException();
		}
		public void useItem()
		{
			throw new System.NotImplementedException();
		}
		public void activateItemWindow()
		{
			throw new System.NotImplementedException();
		}
		public void itemTargetActors()
		{
			throw new System.NotImplementedException();
		}
		public bool canUse()
		{
			throw new System.NotImplementedException();
		}
		public bool isItemEffectsValid()
		{
			throw new System.NotImplementedException();
		}
		public void applyItem()
		{
			throw new System.NotImplementedException();
		}
		public void checkCommonEvent()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Item : Scene_ItemBase
	{
		public Scene_Item() : base()
		{
			
		}
		public Window_ItemCategory _categoryWindow;
		public Window_ItemList _itemWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void createCategoryWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createItemWindow()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor user()
		{
			throw new System.NotImplementedException();
		}
		public void onCategoryOk()
		{
			throw new System.NotImplementedException();
		}
		public void onItemOk()
		{
			throw new System.NotImplementedException();
		}
		public void onItemCancel()
		{
			throw new System.NotImplementedException();
		}
		public void playSeForItem()
		{
			throw new System.NotImplementedException();
		}
		public void useItem()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Skill : Scene_ItemBase
	{
		public Scene_Skill() : base()
		{
			
		}
		public Window_SkillType _skillTypeWindow;
		public Window_SkillStatus _statusWindow;
		public Window_SkillList _itemWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void createSkillTypeWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createStatusWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createItemWindow()
		{
			throw new System.NotImplementedException();
		}
		public void refreshActor()
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor user()
		{
			throw new System.NotImplementedException();
		}
		public void commandSkill()
		{
			throw new System.NotImplementedException();
		}
		public void onItemOk()
		{
			throw new System.NotImplementedException();
		}
		public void onItemCancel()
		{
			throw new System.NotImplementedException();
		}
		public void playSeForItem()
		{
			throw new System.NotImplementedException();
		}
		public void useItem()
		{
			throw new System.NotImplementedException();
		}
		public void onActorChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Equip : Scene_MenuBase
	{
		public Scene_Equip() : base()
		{
			
		}
		public Window_EquipStatus _statusWindow;
		public Window_EquipCommand _commandWindow;
		public Window_EquipSlot _slotWindow;
		public Window_EquipItem _itemWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void createStatusWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createSlotWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createItemWindow()
		{
			throw new System.NotImplementedException();
		}
		public void refreshActor()
		{
			throw new System.NotImplementedException();
		}
		public void commandEquip()
		{
			throw new System.NotImplementedException();
		}
		public void commandOptimize()
		{
			throw new System.NotImplementedException();
		}
		public void commandClear()
		{
			throw new System.NotImplementedException();
		}
		public void onSlotOk()
		{
			throw new System.NotImplementedException();
		}
		public void onSlotCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onItemOk()
		{
			throw new System.NotImplementedException();
		}
		public void onItemCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onActorChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Status : Scene_MenuBase
	{
		public Scene_Status() : base()
		{
			
		}
		public Window_Status _statusWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void refreshActor()
		{
			throw new System.NotImplementedException();
		}
		public void onActorChange()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Options : Scene_MenuBase
	{
		public Scene_Options() : base()
		{
			
		}
		public Window_Options _optionsWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public void createOptionsWindow()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_File : Scene_MenuBase
	{
		public Scene_File() : base()
		{
			
		}
		public Window_SavefileList _listWindow;
		public Window_Help _helpWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public float savefileId()
		{
			throw new System.NotImplementedException();
		}
		public void createHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createListWindow()
		{
			throw new System.NotImplementedException();
		}
		public string mode()
		{
			throw new System.NotImplementedException();
		}
		public void activateListWindow()
		{
			throw new System.NotImplementedException();
		}
		public string helpWindowText()
		{
			throw new System.NotImplementedException();
		}
		public float firstSavefileIndex()
		{
			throw new System.NotImplementedException();
		}
		public void onSavefileOk()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Save : Scene_File
	{
		public Scene_Save() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public string mode()
		{
			throw new System.NotImplementedException();
		}
		public string helpWindowText()
		{
			throw new System.NotImplementedException();
		}
		public float firstSavefileIndex()
		{
			throw new System.NotImplementedException();
		}
		public void onSavefileOk()
		{
			throw new System.NotImplementedException();
		}
		public void onSaveSuccess()
		{
			throw new System.NotImplementedException();
		}
		public void onSaveFailure()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Load : Scene_File
	{
		public Scene_Load() : base()
		{
			
		}
		public bool _loadSuccess;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public string mode()
		{
			throw new System.NotImplementedException();
		}
		public string helpWindowText()
		{
			throw new System.NotImplementedException();
		}
		public float firstSavefileIndex()
		{
			throw new System.NotImplementedException();
		}
		public void onSavefileOk()
		{
			throw new System.NotImplementedException();
		}
		public void onSaveSuccess()
		{
			throw new System.NotImplementedException();
		}
		public void onSaveFailure()
		{
			throw new System.NotImplementedException();
		}
		public void reloadMapIfUpdated()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_GameEnd : Scene_MenuBase
	{
		public Scene_GameEnd() : base()
		{
			
		}
		public Window_GameEnd _commandWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public void createBackground()
		{
			throw new System.NotImplementedException();
		}
		public void createCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void commandToTitle()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Shop : Scene_MenuBase
	{
		public Scene_Shop() : base()
		{
			
		}
		public object[][] _goods;
		public bool _purchaseOnly;
		public IDataAllItem _item;
		public Window_Gold _goldWindow;
		public Window_ShopCommand _commandWindow;
		public Window_Base _dummyWindow;
		public Window_ShopNumber _numberWindow;
		public Window_ShopStatus _statusWindow;
		public Window_ShopBuy _buyWindow;
		public Window_ItemCategory _categoryWindow;
		public Window_ShopSell _sellWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void prepare(object[][] goods, bool purchaseOnly)
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void createGoldWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createDummyWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createNumberWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createStatusWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createBuyWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createCategoryWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createSellWindow()
		{
			throw new System.NotImplementedException();
		}
		public void activateBuyWindow()
		{
			throw new System.NotImplementedException();
		}
		public void activateSellWindow()
		{
			throw new System.NotImplementedException();
		}
		public void commandBuy()
		{
			throw new System.NotImplementedException();
		}
		public void commandSell()
		{
			throw new System.NotImplementedException();
		}
		public void onBuyOk()
		{
			throw new System.NotImplementedException();
		}
		public void onBuyCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onCategoryOk()
		{
			throw new System.NotImplementedException();
		}
		public void onCategoryCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onSellOk()
		{
			throw new System.NotImplementedException();
		}
		public void onSellCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onNumberOk()
		{
			throw new System.NotImplementedException();
		}
		public void onNumberCancel()
		{
			throw new System.NotImplementedException();
		}
		public void doBuy(float number)
		{
			throw new System.NotImplementedException();
		}
		public void doSell(float number)
		{
			throw new System.NotImplementedException();
		}
		public void endNumberInput()
		{
			throw new System.NotImplementedException();
		}
		public float maxBuy()
		{
			throw new System.NotImplementedException();
		}
		public float maxSell()
		{
			throw new System.NotImplementedException();
		}
		public float money()
		{
			throw new System.NotImplementedException();
		}
		public string currencyUnit()
		{
			throw new System.NotImplementedException();
		}
		public float buyingPrice()
		{
			throw new System.NotImplementedException();
		}
		public float sellingPrice()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Name : Scene_MenuBase
	{
		public Scene_Name() : base()
		{
			
		}
		public Game_Actor _actor;
		public float _actorId;
		public float _maxLength;
		public Window_NameEdit _editWindow;
		public Window_NameInput _inputWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void prepare(float actorId, float maxLength)
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void createEditWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createInputWindow()
		{
			throw new System.NotImplementedException();
		}
		public void onInputOk()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Debug : Scene_MenuBase
	{
		public Scene_Debug() : base()
		{
			
		}
		public Window_DebugEdit _editWindow;
		public Window_DebugRange _rangeWindow;
		public Window_Base _debugHelpWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void createRangeWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createEditWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createDebugHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public void onRangeOk()
		{
			throw new System.NotImplementedException();
		}
		public void onEditCancel()
		{
			throw new System.NotImplementedException();
		}
		public void refreshHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public string helpText()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Battle : Scene_Base
	{
		public Scene_Battle() : base()
		{
			
		}
		public Window_PartyCommand _partyCommandWindow;
		public Window_ActorCommand _actorCommandWindow;
		public Window_BattleSkill _skillWindow;
		public Window_BattleItem _itemWindow;
		public Window_BattleActor _actorWindow;
		public Window_BattleEnemy _enemyWindow;
		public Window_Help _helpWindow;
		public Window_BattleStatus _statusWindow;
		public Spriteset_Battle _spriteset;
		public Window_BattleLog _logWindow;
		public Window_Message _messageWindow;
		public Window_ScrollText _scrollTextWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateBattleProcess()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnyInputWindowActive()
		{
			throw new System.NotImplementedException();
		}
		public void changeInputWindow()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public bool needsSlowFadeOut()
		{
			throw new System.NotImplementedException();
		}
		public void updateStatusWindow()
		{
			throw new System.NotImplementedException();
		}
		public void updateWindowPositions()
		{
			throw new System.NotImplementedException();
		}
		public void createDisplayObjects()
		{
			throw new System.NotImplementedException();
		}
		public void createSpriteset()
		{
			throw new System.NotImplementedException();
		}
		public void createAllWindows()
		{
			throw new System.NotImplementedException();
		}
		public void createLogWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createStatusWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createPartyCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createActorCommandWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createSkillWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createItemWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createActorWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createEnemyWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createMessageWindow()
		{
			throw new System.NotImplementedException();
		}
		public void createScrollTextWindow()
		{
			throw new System.NotImplementedException();
		}
		public void refreshStatus()
		{
			throw new System.NotImplementedException();
		}
		public void startPartyCommandSelection()
		{
			throw new System.NotImplementedException();
		}
		public void commandFight()
		{
			throw new System.NotImplementedException();
		}
		public void commandEscape()
		{
			throw new System.NotImplementedException();
		}
		public void startActorCommandSelection()
		{
			throw new System.NotImplementedException();
		}
		public void commandAttack()
		{
			throw new System.NotImplementedException();
		}
		public void commandSkill()
		{
			throw new System.NotImplementedException();
		}
		public void commandGuard()
		{
			throw new System.NotImplementedException();
		}
		public void commandItem()
		{
			throw new System.NotImplementedException();
		}
		public void selectNextCommand()
		{
			throw new System.NotImplementedException();
		}
		public void selectPreviousCommand()
		{
			throw new System.NotImplementedException();
		}
		public void selectActorSelection()
		{
			throw new System.NotImplementedException();
		}
		public void onActorOk()
		{
			throw new System.NotImplementedException();
		}
		public void onActorCancel()
		{
			throw new System.NotImplementedException();
		}
		public void selectEnemySelection()
		{
			throw new System.NotImplementedException();
		}
		public void onEnemyOk()
		{
			throw new System.NotImplementedException();
		}
		public void onEnemyCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onSkillOk()
		{
			throw new System.NotImplementedException();
		}
		public void onSkillCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onItemOk()
		{
			throw new System.NotImplementedException();
		}
		public void onItemCancel()
		{
			throw new System.NotImplementedException();
		}
		public void onSelectAction()
		{
			throw new System.NotImplementedException();
		}
		public void endCommandSelection()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Scene_Gameover : Scene_Base
	{
		public Scene_Gameover() : base()
		{
			
		}
		public Sprite _backSprite;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void create()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public void playGameoverMusic()
		{
			throw new System.NotImplementedException();
		}
		public void createBackground()
		{
			throw new System.NotImplementedException();
		}
		public bool isTriggered()
		{
			throw new System.NotImplementedException();
		}
		public void gotoTitle()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Base : Sprite
	{
		public Sprite_Base() : base()
		{
			
		}
		public Sprite_Animation[] _animationSprites;
		public Sprite_Base _effectTarget;
		public bool _hiding;
		public bool visible;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void updateVisibility()
		{
			throw new System.NotImplementedException();
		}
		public void updateAnimationSprites()
		{
			throw new System.NotImplementedException();
		}
		public void startAnimation(IDataAnimation animation, bool mirror, float delay)
		{
			throw new System.NotImplementedException();
		}
		public bool isAnimationPlaying()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Button : Sprite
	{
		public Sprite_Button() : base()
		{
			
		}
		public bool _touching;
		public Rectangle _coldFrame;
		public Rectangle _hotFrame;
		public Function _clickHandler;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public void setColdFrame(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void setHotFrame(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void setClickHandler(Function method)
		{
			throw new System.NotImplementedException();
		}
		public void callClickHandler()
		{
			throw new System.NotImplementedException();
		}
		public void processTouch()
		{
			throw new System.NotImplementedException();
		}
		public bool isActive()
		{
			throw new System.NotImplementedException();
		}
		public bool isButtonTouched()
		{
			throw new System.NotImplementedException();
		}
		public float canvasToLocalX(float x)
		{
			throw new System.NotImplementedException();
		}
		public float canvasToLocalY(float y)
		{
			throw new System.NotImplementedException();
		}
		public void reserveFaceImages()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Character : Sprite_Base
	{
		public Sprite_Character(Game_CharacterBase character = default(Game_CharacterBase)) : base()
		{
			
		}
		protected Sprite_Character() : base()
		{
			
		}
		public Game_Character _character;
		public Sprite_Balloon _balloonSprite;
		public float _balloonDuration;
		public float _tilesetId;
		public float _tileId;
		public string _characterName;
		public float _characterIndex;
		public Sprite _upperBody;
		public Sprite _lowerBody;
		public bool _isBigCharacter;
		public float _bushDepth;
		public void initialize(Game_CharacterBase character = default(Game_CharacterBase))
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setCharacter(Game_CharacterBase character)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateVisibility()
		{
			throw new System.NotImplementedException();
		}
		public bool isTile()
		{
			throw new System.NotImplementedException();
		}
		public Bitmap tilesetBitmap(float tileId)
		{
			throw new System.NotImplementedException();
		}
		public void updateBitmap()
		{
			throw new System.NotImplementedException();
		}
		public bool isImageChanged()
		{
			throw new System.NotImplementedException();
		}
		public void setTileBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void setCharacterBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public void updateTileFrame()
		{
			throw new System.NotImplementedException();
		}
		public void updateCharacterFrame()
		{
			throw new System.NotImplementedException();
		}
		public float characterBlockX()
		{
			throw new System.NotImplementedException();
		}
		public float characterBlockY()
		{
			throw new System.NotImplementedException();
		}
		public float characterPatternX()
		{
			throw new System.NotImplementedException();
		}
		public float characterPatternY()
		{
			throw new System.NotImplementedException();
		}
		public float patternWidth()
		{
			throw new System.NotImplementedException();
		}
		public float patternHeight()
		{
			throw new System.NotImplementedException();
		}
		public void updateHalfBodySprites()
		{
			throw new System.NotImplementedException();
		}
		public void createHalfBodySprites()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void updateOther()
		{
			throw new System.NotImplementedException();
		}
		public void setupAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void setupBalloon()
		{
			throw new System.NotImplementedException();
		}
		public void startBalloon()
		{
			throw new System.NotImplementedException();
		}
		public void updateBalloon()
		{
			throw new System.NotImplementedException();
		}
		public void endBalloon()
		{
			throw new System.NotImplementedException();
		}
		public bool isBalloonPlaying()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Battler : Sprite_Base
	{
		public Sprite_Battler() : base()
		{
			
		}
		public Game_Battler _battler;
		public Sprite_Damage[] _damages;
		public float _homeX;
		public float _homeY;
		public float _offsetX;
		public float _offsetY;
		public float _targetOffsetX;
		public float _targetOffsetY;
		public float _movementDuration;
		public float _selectionEffectCount;
		public void initialize(Game_Battler battler = default(Game_Battler))
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setBattler(Game_Battler battler)
		{
			throw new System.NotImplementedException();
		}
		public void setHome(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateVisibility()
		{
			throw new System.NotImplementedException();
		}
		public void updateMain()
		{
			throw new System.NotImplementedException();
		}
		public void updateBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public void updateMove()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void updateDamagePopup()
		{
			throw new System.NotImplementedException();
		}
		public void updateSelectionEffect()
		{
			throw new System.NotImplementedException();
		}
		public void setupAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void setupDamagePopup()
		{
			throw new System.NotImplementedException();
		}
		public float damageOffsetX()
		{
			throw new System.NotImplementedException();
		}
		public float damageOffsetY()
		{
			throw new System.NotImplementedException();
		}
		public void startMove(float x, float y, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void onMoveEnd()
		{
			throw new System.NotImplementedException();
		}
		public bool isEffecting()
		{
			throw new System.NotImplementedException();
		}
		public bool isMoving()
		{
			throw new System.NotImplementedException();
		}
		public bool inHomePosition()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IMotion
	{
		protected IMotion()
		{
			
		}
		public float index;
		public bool loop;
	}

		public class Sprite_Actor : Sprite_Battler
	{
		public Sprite_Actor() : base()
		{
			
		}
		public static Dictionary<string,IMotion> MOTIONS;
		public string _battlerName;
		public IMotion _motion;
		public float _motionCount;
		public float _pattern;
		public Sprite_Base _mainSprite;
		public Sprite_Base _effectTarget;
		public Sprite _shadowSprite;
		public Sprite_Weapon _weaponSprite;
		public Sprite_StateOverlay _stateSprite;
		public void initialize(Game_Actor battler = default(Game_Actor))
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void createMainSprite()
		{
			throw new System.NotImplementedException();
		}
		public void createShadowSprite()
		{
			throw new System.NotImplementedException();
		}
		public void createWeaponSprite()
		{
			throw new System.NotImplementedException();
		}
		public void createStateSprite()
		{
			throw new System.NotImplementedException();
		}
		public void setBattler(Game_Actor battler)
		{
			throw new System.NotImplementedException();
		}
		public void moveToStartPosition()
		{
			throw new System.NotImplementedException();
		}
		public void setActorHome(float index)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateShadow()
		{
			throw new System.NotImplementedException();
		}
		public void updateMain()
		{
			throw new System.NotImplementedException();
		}
		public void setupMotion()
		{
			throw new System.NotImplementedException();
		}
		public void setupWeaponAnimation()
		{
			throw new System.NotImplementedException();
		}
		public void startMotion(string motionType)
		{
			throw new System.NotImplementedException();
		}
		public void updateTargetPosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public void updateMove()
		{
			throw new System.NotImplementedException();
		}
		public void updateMotion()
		{
			throw new System.NotImplementedException();
		}
		public void updateMotionCount()
		{
			throw new System.NotImplementedException();
		}
		public float motionSpeed()
		{
			throw new System.NotImplementedException();
		}
		public void refreshMotion()
		{
			throw new System.NotImplementedException();
		}
		public void startEntryMotion()
		{
			throw new System.NotImplementedException();
		}
		public void stepForward()
		{
			throw new System.NotImplementedException();
		}
		public void stepBack()
		{
			throw new System.NotImplementedException();
		}
		public void retreat()
		{
			throw new System.NotImplementedException();
		}
		public void onMoveEnd()
		{
			throw new System.NotImplementedException();
		}
		public float damageOffsetX()
		{
			throw new System.NotImplementedException();
		}
		public float damageOffsetY()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Enemy : Sprite_Battler
	{
		public Sprite_Enemy() : base()
		{
			
		}
		public Game_Enemy _enemy;
		public bool _appeared;
		public string _battlerName;
		public float _battlerHue;
		public string _effectType;
		public float _effectDuration;
		public float _shake;
		public Sprite_StateIcon _stateIconSprite;
		public void initialize(Game_Enemy battler = default(Game_Enemy))
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void createStateIconSprite()
		{
			throw new System.NotImplementedException();
		}
		public void setBattler(Game_Enemy battler)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void loadBitmap(string name, float hue)
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateStateSprite()
		{
			throw new System.NotImplementedException();
		}
		public void initVisibility()
		{
			throw new System.NotImplementedException();
		}
		public void setupEffect()
		{
			throw new System.NotImplementedException();
		}
		public void startEffect(string effectType)
		{
			throw new System.NotImplementedException();
		}
		public void startAppear()
		{
			throw new System.NotImplementedException();
		}
		public void startDisappear()
		{
			throw new System.NotImplementedException();
		}
		public void startWhiten()
		{
			throw new System.NotImplementedException();
		}
		public void startBlink()
		{
			throw new System.NotImplementedException();
		}
		public void startCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void startBossCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void startInstantCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void updateEffect()
		{
			throw new System.NotImplementedException();
		}
		public bool isEffecting()
		{
			throw new System.NotImplementedException();
		}
		public void revertToNormal()
		{
			throw new System.NotImplementedException();
		}
		public void updateWhiten()
		{
			throw new System.NotImplementedException();
		}
		public void updateBlink()
		{
			throw new System.NotImplementedException();
		}
		public void updateAppear()
		{
			throw new System.NotImplementedException();
		}
		public void updateDisappear()
		{
			throw new System.NotImplementedException();
		}
		public void updateCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void updateBossCollapse()
		{
			throw new System.NotImplementedException();
		}
		public void updateInstantCollapse()
		{
			throw new System.NotImplementedException();
		}
		public float damageOffsetX()
		{
			throw new System.NotImplementedException();
		}
		public float damageOffsetY()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Animation : Sprite
	{
		public Sprite_Animation() : base()
		{
			
		}
		public bool _reduceArtifacts;
		public Sprite_Base _target;
		public IDataAnimation _animation;
		public bool _mirror;
		public float _delay;
		public float _rate;
		public float _duration;
		public float[] _flashColor;
		public float _flashDuration;
		public float _screenFlashDuration;
		public float _hidingDuration;
		public Bitmap _bitmap1;
		public Bitmap _bitmap2;
		public Sprite[] _cellSprites;
		public ScreenSprite _screenFlashSprite;
		public bool _duplicated;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setup(Sprite_Base target, IDataAnimation animation, bool mirror, float delay)
		{
			throw new System.NotImplementedException();
		}
		public void remove()
		{
			throw new System.NotImplementedException();
		}
		public void setupRate()
		{
			throw new System.NotImplementedException();
		}
		public void setupDuration()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateFlash()
		{
			throw new System.NotImplementedException();
		}
		public void updateScreenFlash()
		{
			throw new System.NotImplementedException();
		}
		public float absoluteX()
		{
			throw new System.NotImplementedException();
		}
		public float absoluteY()
		{
			throw new System.NotImplementedException();
		}
		public void updateHiding()
		{
			throw new System.NotImplementedException();
		}
		public bool isPlaying()
		{
			throw new System.NotImplementedException();
		}
		public void loadBitmaps()
		{
			throw new System.NotImplementedException();
		}
		public bool isReady()
		{
			throw new System.NotImplementedException();
		}
		public void createSprites()
		{
			throw new System.NotImplementedException();
		}
		public void createCellSprites()
		{
			throw new System.NotImplementedException();
		}
		public void createScreenFlashSprite()
		{
			throw new System.NotImplementedException();
		}
		public void updateMain()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public void currentFrameIndex()
		{
			throw new System.NotImplementedException();
		}
		public void updateAllCellSprites(float[][] frame)
		{
			throw new System.NotImplementedException();
		}
		public void updateCellSprite(Sprite sprite, float[] cell)
		{
			throw new System.NotImplementedException();
		}
		public void processTimingData(IDataAnimationTiming timing)
		{
			throw new System.NotImplementedException();
		}
		public void startFlash(float[] color, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startScreenFlash(float[] color, float duration)
		{
			throw new System.NotImplementedException();
		}
		public void startHiding(float duration)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Damage : Sprite
	{
		public Sprite_Damage() : base()
		{
			
		}
		public float _duration;
		public float[] _flashColor;
		public float _flashDuration;
		public Bitmap _damageBitmap;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void setup(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public float digitWidth()
		{
			throw new System.NotImplementedException();
		}
		public float digitHeight()
		{
			throw new System.NotImplementedException();
		}
		public void createMiss()
		{
			throw new System.NotImplementedException();
		}
		public void createDigits(float baseRow, float value)
		{
			throw new System.NotImplementedException();
		}
		public Sprite createChildSprite()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateChild(Sprite sprite)
		{
			throw new System.NotImplementedException();
		}
		public void updateFlash()
		{
			throw new System.NotImplementedException();
		}
		public void updateOpacity()
		{
			throw new System.NotImplementedException();
		}
		public bool isPlaying()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_StateIcon : Sprite
	{
		public Sprite_StateIcon() : base()
		{
			
		}
		public static float _iconWidth;
		public static float _iconHeight;
		public Game_Battler _battler;
		public float _iconIndex;
		public float _animationCount;
		public float _animationIndex;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setup(Game_Battler battler)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public float animationWait()
		{
			throw new System.NotImplementedException();
		}
		public void updateIcon()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_StateOverlay : Sprite_Base
	{
		public Sprite_StateOverlay() : base()
		{
			
		}
		public Game_Battler _battler;
		public float _overlayIndex;
		public float _animationCount;
		public float _pattern;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void loadBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void setup(Game_Battler battler)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public float animationWait()
		{
			throw new System.NotImplementedException();
		}
		public void updatePattern()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Weapon : Sprite_Base
	{
		public Sprite_Weapon() : base()
		{
			
		}
		public float _weaponImageId;
		public float _animationCount;
		public float _pattern;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void setup(float weaponImageId)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public float animationWait()
		{
			throw new System.NotImplementedException();
		}
		public void updatePattern()
		{
			throw new System.NotImplementedException();
		}
		public void loadBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public bool isPlaying()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Balloon : Sprite_Base
	{
		public Sprite_Balloon() : base()
		{
			
		}
		public float _balloonId;
		public float _duration;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public void loadBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void setup(float balloonId)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateFrame()
		{
			throw new System.NotImplementedException();
		}
		public float speed()
		{
			throw new System.NotImplementedException();
		}
		public float waitTime()
		{
			throw new System.NotImplementedException();
		}
		public float frameIndex()
		{
			throw new System.NotImplementedException();
		}
		public bool isPlaying()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Picture : Sprite
	{
		public Sprite_Picture(float pictureId) : base()
		{
			
		}
		protected Sprite_Picture() : base()
		{
			
		}
		public float _pictureId;
		public string _pictureName;
		public bool _isPicture;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float pictureId)
		{
			throw new System.NotImplementedException();
		}
		public Game_Picture picture()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void updateOrigin()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateScale()
		{
			throw new System.NotImplementedException();
		}
		public void updateTone()
		{
			throw new System.NotImplementedException();
		}
		public void updateOther()
		{
			throw new System.NotImplementedException();
		}
		public void loadBitmap()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Timer : Sprite
	{
		public Sprite_Timer() : base()
		{
			
		}
		public float _seconds;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void createBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void redraw()
		{
			throw new System.NotImplementedException();
		}
		public string timerText()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateVisibility()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Sprite_Destination : Sprite
	{
		public Sprite_Destination() : base()
		{
			
		}
		public float _frameCount;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void createBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
		public void updateAnimation()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Spriteset_Base : Sprite
	{
		public Spriteset_Base() : base()
		{
			
		}
		public float[] _tone;
		public Sprite _baseSprite;
		public ToneSprite _toneSprite;
		public ToneFilter _toneFilter;
		public Sprite _pictureContainer;
		public Sprite_Timer _timerSprite;
		public ScreenSprite _flashSprite;
		public ScreenSprite _fadeSprite;
		public bool opaque;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void createLowerLayer()
		{
			throw new System.NotImplementedException();
		}
		public void createUpperLayer()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void createBaseSprite()
		{
			throw new System.NotImplementedException();
		}
		public void createToneChanger()
		{
			throw new System.NotImplementedException();
		}
		public void createCanvasToneChanger()
		{
			throw new System.NotImplementedException();
		}
		public void createPictures()
		{
			throw new System.NotImplementedException();
		}
		public void createTimer()
		{
			throw new System.NotImplementedException();
		}
		public void createScreenSprites()
		{
			throw new System.NotImplementedException();
		}
		public void updateScreenSprites()
		{
			throw new System.NotImplementedException();
		}
		public void updateToneChanger()
		{
			throw new System.NotImplementedException();
		}
		public void updateWebGLToneChanger()
		{
			throw new System.NotImplementedException();
		}
		public void updateCanvasToneChanger()
		{
			throw new System.NotImplementedException();
		}
		public void updatePosition()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Spriteset_Map : Spriteset_Base
	{
		public Spriteset_Map() : base()
		{
			
		}
		public TilingSprite _parallax;
		public string _parallaxName;
		public Tilemap _tilemap;
		public IDataTileset _tileset;
		public Sprite_Character[] _characterSprites;
		public Sprite _shadowSprite;
		public Sprite_Destination _destinationSprite;
		public Weather _weather;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void createLowerLayer()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void hideCharacters()
		{
			throw new System.NotImplementedException();
		}
		public void createParallax()
		{
			throw new System.NotImplementedException();
		}
		public void createTilemap()
		{
			throw new System.NotImplementedException();
		}
		public void loadTileset()
		{
			throw new System.NotImplementedException();
		}
		public void createCharacters()
		{
			throw new System.NotImplementedException();
		}
		public void createShadow()
		{
			throw new System.NotImplementedException();
		}
		public void createDestination()
		{
			throw new System.NotImplementedException();
		}
		public void createWeather()
		{
			throw new System.NotImplementedException();
		}
		public void updateTileset()
		{
			throw new System.NotImplementedException();
		}
		public void _canvasReAddParallax()
		{
			throw new System.NotImplementedException();
		}
		public void updateParallax()
		{
			throw new System.NotImplementedException();
		}
		public void updateTilemap()
		{
			throw new System.NotImplementedException();
		}
		public void updateShadow()
		{
			throw new System.NotImplementedException();
		}
		public void updateWeather()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Spriteset_Battle : Spriteset_Base
	{
		public Spriteset_Battle() : base()
		{
			
		}
		public bool _battlebackLocated;
		public Sprite _backgroundSprite;
		public Sprite _battleField;
		public TilingSprite _back1Sprite;
		public TilingSprite _back2Sprite;
		public Sprite_Enemy[] _enemySprites;
		public Sprite_Actor[] _actorSprites;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void createLowerLayer()
		{
			throw new System.NotImplementedException();
		}
		public void createBackground()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void createBattleField()
		{
			throw new System.NotImplementedException();
		}
		public void createBattleback()
		{
			throw new System.NotImplementedException();
		}
		public void updateBattleback()
		{
			throw new System.NotImplementedException();
		}
		public void locateBattleback()
		{
			throw new System.NotImplementedException();
		}
		public Bitmap battleback1Bitmap()
		{
			throw new System.NotImplementedException();
		}
		public Bitmap battleback2Bitmap()
		{
			throw new System.NotImplementedException();
		}
		public string battleback1Name()
		{
			throw new System.NotImplementedException();
		}
		public string battleback2Name()
		{
			throw new System.NotImplementedException();
		}
		public string overworldBattleback1Name()
		{
			throw new System.NotImplementedException();
		}
		public string overworldBattleback2Name()
		{
			throw new System.NotImplementedException();
		}
		public string normalBattleback1Name()
		{
			throw new System.NotImplementedException();
		}
		public string normalBattleback2Name()
		{
			throw new System.NotImplementedException();
		}
		public string terrainBattleback1Name(float type)
		{
			throw new System.NotImplementedException();
		}
		public string terrainBattleback2Name(float type)
		{
			throw new System.NotImplementedException();
		}
		public string defaultBattleback1Name()
		{
			throw new System.NotImplementedException();
		}
		public string defaultBattleback2Name()
		{
			throw new System.NotImplementedException();
		}
		public string shipBattleback1Name()
		{
			throw new System.NotImplementedException();
		}
		public string shipBattleback2Name()
		{
			throw new System.NotImplementedException();
		}
		public float autotileType(float z)
		{
			throw new System.NotImplementedException();
		}
		public void createEnemies()
		{
			throw new System.NotImplementedException();
		}
		public float compareEnemySprite(Sprite_Enemy a, Sprite_Enemy b)
		{
			throw new System.NotImplementedException();
		}
		public void createActors()
		{
			throw new System.NotImplementedException();
		}
		public void updateActors()
		{
			throw new System.NotImplementedException();
		}
		public Sprite_Battler[] battlerSprites()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnimationPlaying()
		{
			throw new System.NotImplementedException();
		}
		public bool isEffecting()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnyoneMoving()
		{
			throw new System.NotImplementedException();
		}
		public bool isBusy()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ITextState
	{
		protected ITextState()
		{
			
		}
		public float index;
		public float x;
		public float y;
		public float left;
		public string text;
		public float height;
	}

		public class Window_Base : Window
	{
		public Window_Base(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_Base() : base()
		{
			
		}
		public static float _iconWidth;
		public static float _iconHeight;
		public static float _faceWidth;
		public static float _faceHeight;
		public bool _opening;
		public bool _closing;
		public Sprite _dimmerSprite;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float lineHeight()
		{
			throw new System.NotImplementedException();
		}
		public string standardFontFace()
		{
			throw new System.NotImplementedException();
		}
		public float standardFontSize()
		{
			throw new System.NotImplementedException();
		}
		public float standardPadding()
		{
			throw new System.NotImplementedException();
		}
		public float textPadding()
		{
			throw new System.NotImplementedException();
		}
		public float standardBackOpacity()
		{
			throw new System.NotImplementedException();
		}
		public void loadWindowskin()
		{
			throw new System.NotImplementedException();
		}
		public void updatePadding()
		{
			throw new System.NotImplementedException();
		}
		public void updateBackOpacity()
		{
			throw new System.NotImplementedException();
		}
		public float contentsWidth()
		{
			throw new System.NotImplementedException();
		}
		public float contentsHeight()
		{
			throw new System.NotImplementedException();
		}
		public float fittingHeight(float numLines)
		{
			throw new System.NotImplementedException();
		}
		public void updateTone()
		{
			throw new System.NotImplementedException();
		}
		public void createContents()
		{
			throw new System.NotImplementedException();
		}
		public void resetFontSettings()
		{
			throw new System.NotImplementedException();
		}
		public void resetTextColor()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateOpen()
		{
			throw new System.NotImplementedException();
		}
		public void updateClose()
		{
			throw new System.NotImplementedException();
		}
		public void open()
		{
			throw new System.NotImplementedException();
		}
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public bool isOpening()
		{
			throw new System.NotImplementedException();
		}
		public bool isClosing()
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
		public void activate()
		{
			throw new System.NotImplementedException();
		}
		public void deactivate()
		{
			throw new System.NotImplementedException();
		}
		public string textColor(float n)
		{
			throw new System.NotImplementedException();
		}
		public string normalColor()
		{
			throw new System.NotImplementedException();
		}
		public string systemColor()
		{
			throw new System.NotImplementedException();
		}
		public string crisisColor()
		{
			throw new System.NotImplementedException();
		}
		public string deathColor()
		{
			throw new System.NotImplementedException();
		}
		public string gaugeBackColor()
		{
			throw new System.NotImplementedException();
		}
		public string hpGaugeColor1()
		{
			throw new System.NotImplementedException();
		}
		public string hpGaugeColor2()
		{
			throw new System.NotImplementedException();
		}
		public string mpGaugeColor1()
		{
			throw new System.NotImplementedException();
		}
		public string mpGaugeColor2()
		{
			throw new System.NotImplementedException();
		}
		public string mpCostColor()
		{
			throw new System.NotImplementedException();
		}
		public string powerUpColor()
		{
			throw new System.NotImplementedException();
		}
		public string powerDownColor()
		{
			throw new System.NotImplementedException();
		}
		public string tpGaugeColor1()
		{
			throw new System.NotImplementedException();
		}
		public string tpGaugeColor2()
		{
			throw new System.NotImplementedException();
		}
		public string tpCostColor()
		{
			throw new System.NotImplementedException();
		}
		public string pendingColor()
		{
			throw new System.NotImplementedException();
		}
		public float translucentOpacity()
		{
			throw new System.NotImplementedException();
		}
		public void changeTextColor(string color)
		{
			throw new System.NotImplementedException();
		}
		public void changePaintOpacity(bool enabled)
		{
			throw new System.NotImplementedException();
		}
		public void drawText(string text, float x, float y, float maxWidth = default(float), string align = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float textWidth(string text)
		{
			throw new System.NotImplementedException();
		}
		public float drawTextEx(string text, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public string convertEscapeCharacters(string text)
		{
			throw new System.NotImplementedException();
		}
		public string actorName(float n)
		{
			throw new System.NotImplementedException();
		}
		public string partyMemberName(float n)
		{
			throw new System.NotImplementedException();
		}
		public void processCharacter(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processNormalCharacter(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processNewLine(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processNewPage(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public string obtainEscapeCode(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public string obtainEscapeParam(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processEscapeCharacter(string code, ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processDrawIcon(float iconIndex, ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void makeFontBigger()
		{
			throw new System.NotImplementedException();
		}
		public void makeFontSmaller()
		{
			throw new System.NotImplementedException();
		}
		public float calcTextHeight(ITextState textState, bool all)
		{
			throw new System.NotImplementedException();
		}
		public void drawIcon(float iconIndex, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawFace(string faceName, float faceIndex, float x, float y, float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawCharacter(string characterName, float characterIndex, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawGauge(float x, float y, float width, float rate, string color1, string color2)
		{
			throw new System.NotImplementedException();
		}
		public string hpColor(Game_Battler actor)
		{
			throw new System.NotImplementedException();
		}
		public string mpColor(Game_Battler actor)
		{
			throw new System.NotImplementedException();
		}
		public string tpColor(Game_Battler actor)
		{
			throw new System.NotImplementedException();
		}
		public void drawActorCharacter(Game_Actor actor, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawActorFace(Game_Actor actor, float x, float y, float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorName(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorClass(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorNickname(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorLevel(Game_Actor actor, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawActorIcons(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawCurrentAndMax(float current, float max, float x, float y, float width, string color1, string color2)
		{
			throw new System.NotImplementedException();
		}
		public void drawActorHp(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorMp(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorTp(Game_Actor actor, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawActorSimpleStatus(Game_Actor actor, float x, float y, float width)
		{
			throw new System.NotImplementedException();
		}
		public void drawItemName(IDataAllItem item, float x, float y, float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void drawCurrencyValue(float value, string unit, float x, float y, float width)
		{
			throw new System.NotImplementedException();
		}
		public string paramchangeTextColor(float change)
		{
			throw new System.NotImplementedException();
		}
		public void setBackgroundType(float type)
		{
			throw new System.NotImplementedException();
		}
		public void showBackgroundDimmer()
		{
			throw new System.NotImplementedException();
		}
		public void hideBackgroundDimmer()
		{
			throw new System.NotImplementedException();
		}
		public void updateBackgroundDimmer()
		{
			throw new System.NotImplementedException();
		}
		public void refreshDimmerBitmap()
		{
			throw new System.NotImplementedException();
		}
		public string dimColor1()
		{
			throw new System.NotImplementedException();
		}
		public string dimColor2()
		{
			throw new System.NotImplementedException();
		}
		public float canvasToLocalX(float x)
		{
			throw new System.NotImplementedException();
		}
		public float canvasToLocalY(float y)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_Selectable : Window_Base
	{
		public Window_Selectable(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_Selectable() : base()
		{
			
		}
		public float _index;
		public bool _cursorFixed;
		public bool _cursorAll;
		public float _stayCount;
		public Window_Help _helpWindow;
		public Dictionary<string,Function> _handlers;
		public bool _touching;
		public float _scrollX;
		public float _scrollY;
		public bool downArrowVisible;
		public bool upArrowVisible;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float index()
		{
			throw new System.NotImplementedException();
		}
		public bool cursorFixed()
		{
			throw new System.NotImplementedException();
		}
		public void setCursorFixed(bool cursorFixed)
		{
			throw new System.NotImplementedException();
		}
		public bool cursorAll()
		{
			throw new System.NotImplementedException();
		}
		public void setCursorAll(bool cursorAll)
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public float spacing()
		{
			throw new System.NotImplementedException();
		}
		public float itemWidth()
		{
			throw new System.NotImplementedException();
		}
		public float itemHeight()
		{
			throw new System.NotImplementedException();
		}
		public float maxRows()
		{
			throw new System.NotImplementedException();
		}
		public void activate()
		{
			throw new System.NotImplementedException();
		}
		public void deactivate()
		{
			throw new System.NotImplementedException();
		}
		public void select(float index)
		{
			throw new System.NotImplementedException();
		}
		public void deselect()
		{
			throw new System.NotImplementedException();
		}
		public void reselect()
		{
			throw new System.NotImplementedException();
		}
		public float row()
		{
			throw new System.NotImplementedException();
		}
		public float topRow()
		{
			throw new System.NotImplementedException();
		}
		public float maxTopRow()
		{
			throw new System.NotImplementedException();
		}
		public void setTopRow(float row)
		{
			throw new System.NotImplementedException();
		}
		public void resetScroll()
		{
			throw new System.NotImplementedException();
		}
		public float maxPageRows()
		{
			throw new System.NotImplementedException();
		}
		public float maxPageItems()
		{
			throw new System.NotImplementedException();
		}
		public bool isHorizontal()
		{
			throw new System.NotImplementedException();
		}
		public float bottomRow()
		{
			throw new System.NotImplementedException();
		}
		public void setBottomRow(float row)
		{
			throw new System.NotImplementedException();
		}
		public float topIndex()
		{
			throw new System.NotImplementedException();
		}
		public Rectangle itemRect(float index)
		{
			throw new System.NotImplementedException();
		}
		public Rectangle itemRectForText(float index)
		{
			throw new System.NotImplementedException();
		}
		public void setHelpWindow(Window_Help helpWindow)
		{
			throw new System.NotImplementedException();
		}
		public void showHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public void hideHelpWindow()
		{
			throw new System.NotImplementedException();
		}
		public void setHandler(string symbol, Function method)
		{
			throw new System.NotImplementedException();
		}
		public bool isHandled(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public void callHandler(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public bool isOpenAndActive()
		{
			throw new System.NotImplementedException();
		}
		public bool isCursorMovable()
		{
			throw new System.NotImplementedException();
		}
		public void cursorDown(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorUp(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorRight(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorLeft(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorPagedown()
		{
			throw new System.NotImplementedException();
		}
		public void cursorPageup()
		{
			throw new System.NotImplementedException();
		}
		public void scrollDown()
		{
			throw new System.NotImplementedException();
		}
		public void scrollUp()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateArrows()
		{
			throw new System.NotImplementedException();
		}
		public void processCursorMove()
		{
			throw new System.NotImplementedException();
		}
		public void processHandling()
		{
			throw new System.NotImplementedException();
		}
		public void processWheel()
		{
			throw new System.NotImplementedException();
		}
		public void processTouch()
		{
			throw new System.NotImplementedException();
		}
		public bool isTouchedInsideFrame()
		{
			throw new System.NotImplementedException();
		}
		public void onTouch(bool triggered)
		{
			throw new System.NotImplementedException();
		}
		public float hitTest(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isContentsArea(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public bool isTouchOkEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isCancelEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkTriggered()
		{
			throw new System.NotImplementedException();
		}
		public bool isCancelTriggered()
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void playOkSound()
		{
			throw new System.NotImplementedException();
		}
		public void playBuzzerSound()
		{
			throw new System.NotImplementedException();
		}
		public void callOkHandler()
		{
			throw new System.NotImplementedException();
		}
		public void processCancel()
		{
			throw new System.NotImplementedException();
		}
		public void callCancelHandler()
		{
			throw new System.NotImplementedException();
		}
		public void processPageup()
		{
			throw new System.NotImplementedException();
		}
		public void processPagedown()
		{
			throw new System.NotImplementedException();
		}
		public void updateInputData()
		{
			throw new System.NotImplementedException();
		}
		public void updateCursor()
		{
			throw new System.NotImplementedException();
		}
		public bool isCursorVisible()
		{
			throw new System.NotImplementedException();
		}
		public void ensureCursorVisible()
		{
			throw new System.NotImplementedException();
		}
		public void callUpdateHelp()
		{
			throw new System.NotImplementedException();
		}
		public void updateHelp()
		{
			throw new System.NotImplementedException();
		}
		public void setHelpWindowItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void drawAllItems()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void clearItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void redrawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void redrawCurrentItem()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDataCommandList
	{
		protected IDataCommandList()
		{
			
		}
		public string name;
		public string symbol;
		public bool enabled;
		public float ext;
	}

		public class Window_Command : Window_Selectable
	{
		public Window_Command(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_Command() : base()
		{
			
		}
		public IDataCommandList[] _list;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public void clearCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void addCommand(string name, string symbol, bool enabled = default(bool), float ext = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string commandName(float index)
		{
			throw new System.NotImplementedException();
		}
		public string commandSymbol(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool isCommandEnabled(float index)
		{
			throw new System.NotImplementedException();
		}
		public IDataCommandList currentData()
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public string currentSymbol()
		{
			throw new System.NotImplementedException();
		}
		public float currentExt()
		{
			throw new System.NotImplementedException();
		}
		public float findSymbol(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public void selectSymbol(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public float findExt(float ext)
		{
			throw new System.NotImplementedException();
		}
		public void selectExt(float ext)
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public string itemTextAlign()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void callOkHandler()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_HorzCommand : Window_Command
	{
		public Window_HorzCommand(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_HorzCommand() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public string itemTextAlign()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_Help : Window_Base
	{
		public Window_Help(float numLines = default(float)) : base()
		{
			
		}
		protected Window_Help() : base()
		{
			
		}
		public string _text;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float numLines = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setText(string text)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void setItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_Gold : Window_Base
	{
		public Window_Gold(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_Gold() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public float value()
		{
			throw new System.NotImplementedException();
		}
		public string currencyUnit()
		{
			throw new System.NotImplementedException();
		}
		public void open()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_MenuCommand : Window_Command
	{
		public Window_MenuCommand(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_MenuCommand() : base()
		{
			
		}
		public static string _lastCommandSymbol;
		public static void initCommandPosition()
		{
			throw new System.NotImplementedException();
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void addMainCommands()
		{
			throw new System.NotImplementedException();
		}
		public void addFormationCommand()
		{
			throw new System.NotImplementedException();
		}
		public void addOriginalCommands()
		{
			throw new System.NotImplementedException();
		}
		public void addOptionsCommand()
		{
			throw new System.NotImplementedException();
		}
		public void addSaveCommand()
		{
			throw new System.NotImplementedException();
		}
		public void addGameEndCommand()
		{
			throw new System.NotImplementedException();
		}
		public bool needsCommand(string name)
		{
			throw new System.NotImplementedException();
		}
		public bool areMainCommandsEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isFormationEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isOptionsEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isSaveEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isGameEndEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_MenuStatus : Window_Selectable
	{
		public Window_MenuStatus(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_MenuStatus() : base()
		{
			
		}
		public bool _formationMode;
		public float _pendingIndex;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public float itemHeight()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void loadImages()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void drawItemBackground(float index)
		{
			throw new System.NotImplementedException();
		}
		public void drawItemImage(float index)
		{
			throw new System.NotImplementedException();
		}
		public void drawItemStatus(float index)
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
		public bool formationMode()
		{
			throw new System.NotImplementedException();
		}
		public void setFormationMode(bool formationMode)
		{
			throw new System.NotImplementedException();
		}
		public float pendingIndex()
		{
			throw new System.NotImplementedException();
		}
		public void setPendingIndex(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_MenuActor : Window_MenuStatus
	{
		public Window_MenuActor() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
		public void selectForItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ItemCategory : Window_HorzCommand
	{
		public Window_ItemCategory() : base()
		{
			
		}
		public Window_ItemList _itemWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void setItemWindow(Window_ItemList itemWindow)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ItemList : Window_Selectable
	{
		public Window_ItemList(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ItemList() : base()
		{
			
		}
		public string _category;
		public IDataAllItem[] _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setCategory(string category)
		{
			throw new System.NotImplementedException();
		}
		public float spacing()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem item()
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool includes(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public float needsNumber()
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void makeItemList()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public float numberWidth()
		{
			throw new System.NotImplementedException();
		}
		public void drawItemNumber(IDataAllItem item, float x, float y, float width)
		{
			throw new System.NotImplementedException();
		}
		public void updateHelp()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_SkillType : Window_Command
	{
		public Window_SkillType(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_SkillType() : base()
		{
			
		}
		public Game_Actor _actor;
		public Window_SkillList _skillWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void setSkillWindow(Window_SkillList skillWindow)
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_SkillStatus : Window_Base
	{
		public Window_SkillStatus(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_SkillStatus() : base()
		{
			
		}
		public Game_Actor _actor;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_SkillList : Window_Selectable
	{
		public Window_SkillList(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_SkillList() : base()
		{
			
		}
		public Game_Actor _actor;
		public float _stypeId;
		public IDataAllItem[] _data;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void setStypeId(float stypeId)
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public float spacing()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem item()
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool includes(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void makeItemList()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public float costWidth()
		{
			throw new System.NotImplementedException();
		}
		public void drawSkillCost(IDataSkill skill, float x, float y, float width)
		{
			throw new System.NotImplementedException();
		}
		public void updateHelp()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_EquipStatus : Window_Base
	{
		public Window_EquipStatus(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_EquipStatus() : base()
		{
			
		}
		public Game_Actor _actor;
		public Game_Actor _tempActor;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void setTempActor(Game_Actor tempActor)
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float x, float y, float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void drawParamName(float x, float y, float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void drawCurrentParam(float x, float y, float paramId)
		{
			throw new System.NotImplementedException();
		}
		public void drawRightArrow(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawNewParam(float x, float y, float paramId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_EquipCommand : Window_HorzCommand
	{
		public Window_EquipCommand(float x = default(float), float y = default(float), float width = default(float)) : base()
		{
			
		}
		protected Window_EquipCommand() : base()
		{
			
		}
		public float _windowWidth;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_EquipSlot : Window_Selectable
	{
		public Window_EquipSlot(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_EquipSlot() : base()
		{
			
		}
		public Game_Actor _actor;
		public Window_EquipItem _itemWindow;
		public Window_EquipStatus _statusWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem item()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public string slotName(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void setStatusWindow(Window_EquipStatus statusWindow)
		{
			throw new System.NotImplementedException();
		}
		public void setItemWindow(Window_EquipItem itemWindow)
		{
			throw new System.NotImplementedException();
		}
		public void updateHelp()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_EquipItem : Window_ItemList
	{
		public Window_EquipItem(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_EquipItem() : base()
		{
			
		}
		public Game_Actor _actor;
		public float _slotId;
		public Window_EquipStatus _statusWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void setSlotId(float slotId)
		{
			throw new System.NotImplementedException();
		}
		public bool includes(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
		public void setStatusWindow(Window_EquipStatus statusWindow)
		{
			throw new System.NotImplementedException();
		}
		public void updateHelp()
		{
			throw new System.NotImplementedException();
		}
		public void playOkSound()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_Status : Window_Selectable
	{
		public Window_Status() : base()
		{
			
		}
		public Game_Actor _actor;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void setActor(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawBlock1(float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawBlock2(float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawBlock3(float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawBlock4(float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawHorzLine(float y)
		{
			throw new System.NotImplementedException();
		}
		public string lineColor()
		{
			throw new System.NotImplementedException();
		}
		public void drawBasicInfo(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawParameters(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawExpInfo(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawEquipments(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawProfile(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float maxEquipmentLines()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_Options : Window_Command
	{
		public Window_Options() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void addGeneralOptions()
		{
			throw new System.NotImplementedException();
		}
		public void addVolumeOptions()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public float statusWidth()
		{
			throw new System.NotImplementedException();
		}
		public string statusText(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool isVolumeSymbol(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public string booleanStatusText(float value)
		{
			throw new System.NotImplementedException();
		}
		public string volumeStatusText(float value)
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void cursorRight(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorLeft(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public float volumeOffset()
		{
			throw new System.NotImplementedException();
		}
		public void changeValue(string symbol, float value)
		{
			throw new System.NotImplementedException();
		}
		public object getConfigValue(string symbol)
		{
			throw new System.NotImplementedException();
		}
		public void setConfigValue(string symbol, object volume)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_SavefileList : Window_Selectable
	{
		public Window_SavefileList(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_SavefileList() : base()
		{
			
		}
		public string _mode;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setMode(string mode)
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public float maxVisibleItems()
		{
			throw new System.NotImplementedException();
		}
		public float itemHeight()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void drawFileId(float id, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawContents(ISavefileInfo info, Rectangle rect, bool valid)
		{
			throw new System.NotImplementedException();
		}
		public void drawGameTitle(ISavefileInfo info, float x, float y, float width)
		{
			throw new System.NotImplementedException();
		}
		public void drawPartyCharacters(ISavefileInfo info, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawPlaytime(ISavefileInfo info, float x, float y, float width)
		{
			throw new System.NotImplementedException();
		}
		public void playOkSound()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ShopCommand : Window_HorzCommand
	{
		public Window_ShopCommand(float width = default(float), bool purchaseOnly = default(bool)) : base()
		{
			
		}
		protected Window_ShopCommand() : base()
		{
			
		}
		public float _windowWidth;
		public bool _purchaseOnly;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float width = default(float), bool purchaseOnly = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ShopBuy : Window_Selectable
	{
		public Window_ShopBuy(float x = default(float), float y = default(float), float height = default(float), object[][] shopGoods = default(object[][])) : base()
		{
			
		}
		protected Window_ShopBuy() : base()
		{
			
		}
		public object[][] _shopGoods;
		public float _money;
		public IDataAllItem[] _data;
		public float[] _price;
		public Window_EquipStatus _statusWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float height = default(float), object[][] shopGoods = default(object[][]))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem item()
		{
			throw new System.NotImplementedException();
		}
		public void setMoney(float money)
		{
			throw new System.NotImplementedException();
		}
		public bool isCurrentItemEnabled()
		{
			throw new System.NotImplementedException();
		}
		public float price(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void makeItemList()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void setStatusWindow(Window_EquipStatus statusWindow)
		{
			throw new System.NotImplementedException();
		}
		public void updateHelp()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ShopSell : Window_ItemList
	{
		public Window_ShopSell(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ShopSell() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ShopNumber : Window_Selectable
	{
		public Window_ShopNumber(float x = default(float), float y = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ShopNumber() : base()
		{
			
		}
		public IDataAllItem _item;
		public float _max;
		public float _price;
		public float _number;
		public string _currencyUnit;
		public Sprite_Button[] _buttons;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float number()
		{
			throw new System.NotImplementedException();
		}
		public void setup(IDataAllItem item, float max, float price)
		{
			throw new System.NotImplementedException();
		}
		public void setCurrencyUnit(string currencyUnit)
		{
			throw new System.NotImplementedException();
		}
		public void createButtons()
		{
			throw new System.NotImplementedException();
		}
		public void placeButtons()
		{
			throw new System.NotImplementedException();
		}
		public void updateButtonsVisiblity()
		{
			throw new System.NotImplementedException();
		}
		public void showButtons()
		{
			throw new System.NotImplementedException();
		}
		public void hideButtons()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawMultiplicationSign()
		{
			throw new System.NotImplementedException();
		}
		public void drawNumber()
		{
			throw new System.NotImplementedException();
		}
		public void drawTotalPrice()
		{
			throw new System.NotImplementedException();
		}
		public float itemY()
		{
			throw new System.NotImplementedException();
		}
		public float priceY()
		{
			throw new System.NotImplementedException();
		}
		public float buttonY()
		{
			throw new System.NotImplementedException();
		}
		public float cursorWidth()
		{
			throw new System.NotImplementedException();
		}
		public float cursorX()
		{
			throw new System.NotImplementedException();
		}
		public float maxDigits()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkTriggered()
		{
			throw new System.NotImplementedException();
		}
		public void playOkSound()
		{
			throw new System.NotImplementedException();
		}
		public void processNumberChange()
		{
			throw new System.NotImplementedException();
		}
		public void changeNumber(float amount)
		{
			throw new System.NotImplementedException();
		}
		public void updateCursor()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonUp()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonUp2()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonDown()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonDown2()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonOk()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ShopStatus : Window_Base
	{
		public Window_ShopStatus(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_ShopStatus() : base()
		{
			
		}
		public IDataAllItem _item;
		public float _pageIndex;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void setItem(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isEquipItem()
		{
			throw new System.NotImplementedException();
		}
		public void drawPossession(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void drawEquipInfo(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor[] statusMembers()
		{
			throw new System.NotImplementedException();
		}
		public float pageSize()
		{
			throw new System.NotImplementedException();
		}
		public float maxPages()
		{
			throw new System.NotImplementedException();
		}
		public void drawActorEquipInfo(float x, float y, Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void drawActorParamChange(float x, float y, Game_Actor actor, IDataAllItem item1)
		{
			throw new System.NotImplementedException();
		}
		public IDataAllItem currentEquippedItem(Game_Actor actor, float etypeId)
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updatePage()
		{
			throw new System.NotImplementedException();
		}
		public bool isPageChangeEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isPageChangeRequested()
		{
			throw new System.NotImplementedException();
		}
		public bool isTouchedInsideFrame()
		{
			throw new System.NotImplementedException();
		}
		public void changePage()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_NameEdit : Window_Base
	{
		public Window_NameEdit(Game_Actor actor = default(Game_Actor), float maxLength = default(float)) : base()
		{
			
		}
		protected Window_NameEdit() : base()
		{
			
		}
		public Game_Actor _actor;
		public string _name;
		public float _index;
		public float _maxLength;
		public string _defaultName;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(Game_Actor actor = default(Game_Actor), float maxLength = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public bool restoreDefault()
		{
			throw new System.NotImplementedException();
		}
		public bool add(string ch)
		{
			throw new System.NotImplementedException();
		}
		public bool back()
		{
			throw new System.NotImplementedException();
		}
		public float faceWidth()
		{
			throw new System.NotImplementedException();
		}
		public float charWidth()
		{
			throw new System.NotImplementedException();
		}
		public float left()
		{
			throw new System.NotImplementedException();
		}
		public ItemRect_0_ itemRect(float index)
		{
			throw new System.NotImplementedException();
		}
		public UnderlineRect_0_ underlineRect(float index)
		{
			throw new System.NotImplementedException();
		}
		public void underlineColor()
		{
			throw new System.NotImplementedException();
		}
		public void drawUnderline(float index)
		{
			throw new System.NotImplementedException();
		}
		public void drawChar(float index)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}

				public class ItemRect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class UnderlineRect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_NameInput : Window_Selectable
	{
		public Window_NameInput(Window_NameEdit editWindow = default(Window_NameEdit)) : base()
		{
			
		}
		protected Window_NameInput() : base()
		{
			
		}
		public static string[] LATIN1;
		public static string[] LATIN2;
		public static string[] RUSSIA;
		public static string[] JAPAN1;
		public static string[] JAPAN2;
		public static string[] JAPAN3;
		public Window_NameEdit _editWindow;
		public float _page;
		public float _index;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(Window_NameEdit editWindow = default(Window_NameEdit))
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public string[][] table()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public string character()
		{
			throw new System.NotImplementedException();
		}
		public bool isPageChange()
		{
			throw new System.NotImplementedException();
		}
		public bool isOk()
		{
			throw new System.NotImplementedException();
		}
		public Rectangle itemRect(float index)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void updateCursor()
		{
			throw new System.NotImplementedException();
		}
		public bool isCursorMovable()
		{
			throw new System.NotImplementedException();
		}
		public void cursorDown(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorUp(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorRight(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorLeft(bool wrap)
		{
			throw new System.NotImplementedException();
		}
		public void cursorPagedown()
		{
			throw new System.NotImplementedException();
		}
		public void cursorPageup()
		{
			throw new System.NotImplementedException();
		}
		public void processCursorMove()
		{
			throw new System.NotImplementedException();
		}
		public void processHandling()
		{
			throw new System.NotImplementedException();
		}
		public bool isCancelEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void processCancel()
		{
			throw new System.NotImplementedException();
		}
		public void processJump()
		{
			throw new System.NotImplementedException();
		}
		public void processBack()
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void onNameAdd()
		{
			throw new System.NotImplementedException();
		}
		public void onNameOk()
		{
			throw new System.NotImplementedException();
		}

				public class ItemRect_1_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_ChoiceList : Window_Command
	{
		public Window_ChoiceList(Window_Message messageWindow = default(Window_Message)) : base()
		{
			
		}
		protected Window_ChoiceList() : base()
		{
			
		}
		public Window_Message _messageWindow;
		public float _background;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(Window_Message messageWindow = default(Window_Message))
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void selectDefault()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public void updateBackground()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public float maxChoiceWidth()
		{
			throw new System.NotImplementedException();
		}
		public float textWidthEx(string text)
		{
			throw new System.NotImplementedException();
		}
		public float contentsHeight()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool isCancelEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkTriggered()
		{
			throw new System.NotImplementedException();
		}
		public void callOkHandler()
		{
			throw new System.NotImplementedException();
		}
		public void callCancelHandler()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_NumberInput : Window_Selectable
	{
		public Window_NumberInput(Window_Message messageWindow = default(Window_Message)) : base()
		{
			
		}
		protected Window_NumberInput() : base()
		{
			
		}
		public Window_Message _messageWindow;
		public float _number;
		public float _maxDigits;
		public Sprite_Button[] _buttons;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(Window_Message messageWindow = default(Window_Message))
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public float spacing()
		{
			throw new System.NotImplementedException();
		}
		public float itemWidth()
		{
			throw new System.NotImplementedException();
		}
		public void createButtons()
		{
			throw new System.NotImplementedException();
		}
		public void placeButtons()
		{
			throw new System.NotImplementedException();
		}
		public void updateButtonsVisiblity()
		{
			throw new System.NotImplementedException();
		}
		public void showButtons()
		{
			throw new System.NotImplementedException();
		}
		public void hideButtons()
		{
			throw new System.NotImplementedException();
		}
		public float buttonY()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void processDigitChange()
		{
			throw new System.NotImplementedException();
		}
		public void changeDigit(bool up)
		{
			throw new System.NotImplementedException();
		}
		public bool isTouchOkEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isCancelEnabled()
		{
			throw new System.NotImplementedException();
		}
		public bool isOkTriggered()
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void onButtonUp()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonDown()
		{
			throw new System.NotImplementedException();
		}
		public void onButtonOk()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_EventItem : Window_ItemList
	{
		public Window_EventItem(Window_Message messageWindow = default(Window_Message)) : base()
		{
			
		}
		protected Window_EventItem() : base()
		{
			
		}
		public Window_Message _messageWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(Window_Message messageWindow = default(Window_Message))
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public bool includes(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void onOk()
		{
			throw new System.NotImplementedException();
		}
		public void onCancel()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_Message : Window_Base
	{
		public Window_Message() : base()
		{
			
		}
		public float _background;
		public float _positionType;
		public float _waitCount;
		public Bitmap _faceBitmap;
		public ITextState _textState;
		public Window_Gold _goldWindow;
		public Window_ChoiceList _choiceWindow;
		public Window_NumberInput _numberWindow;
		public Window_EventItem _itemWindow;
		public bool _showFast;
		public bool _lineShowFast;
		public bool _pauseSkip;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initMembers()
		{
			throw new System.NotImplementedException();
		}
		public Window_Base[] subWindows()
		{
			throw new System.NotImplementedException();
		}
		public void createSubWindows()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public void clearFlags()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void checkToNotClose()
		{
			throw new System.NotImplementedException();
		}
		public bool canStart()
		{
			throw new System.NotImplementedException();
		}
		public void startMessage()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public void updateBackground()
		{
			throw new System.NotImplementedException();
		}
		public void terminateMessage()
		{
			throw new System.NotImplementedException();
		}
		public void updateWait()
		{
			throw new System.NotImplementedException();
		}
		public void updateLoading()
		{
			throw new System.NotImplementedException();
		}
		public void updateInput()
		{
			throw new System.NotImplementedException();
		}
		public bool isAnySubWindowActive()
		{
			throw new System.NotImplementedException();
		}
		public bool updateMessage()
		{
			throw new System.NotImplementedException();
		}
		public void onEndOfText()
		{
			throw new System.NotImplementedException();
		}
		public bool startInput()
		{
			throw new System.NotImplementedException();
		}
		public bool isTriggered()
		{
			throw new System.NotImplementedException();
		}
		public bool doesContinue()
		{
			throw new System.NotImplementedException();
		}
		public bool areSettingsChanged()
		{
			throw new System.NotImplementedException();
		}
		public void updateShowFast()
		{
			throw new System.NotImplementedException();
		}
		public void newPage(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void loadMessageFace()
		{
			throw new System.NotImplementedException();
		}
		public void drawMessageFace()
		{
			throw new System.NotImplementedException();
		}
		public float newLineX()
		{
			throw new System.NotImplementedException();
		}
		public void processNewLine(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processNewPage(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public bool isEndOfText(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public bool needsNewPage(ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void processEscapeCharacter(string code, ITextState textState)
		{
			throw new System.NotImplementedException();
		}
		public void startWait(float count)
		{
			throw new System.NotImplementedException();
		}
		public void startPause()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ScrollText : Window_Base
	{
		public Window_ScrollText() : base()
		{
			
		}
		public string _text;
		public float _allTextHeight;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void startMessage()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public float contentsHeight()
		{
			throw new System.NotImplementedException();
		}
		public void updateMessage()
		{
			throw new System.NotImplementedException();
		}
		public float scrollSpeed()
		{
			throw new System.NotImplementedException();
		}
		public bool isFastForward()
		{
			throw new System.NotImplementedException();
		}
		public float fastForwardRate()
		{
			throw new System.NotImplementedException();
		}
		public void terminateMessage()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_MapName : Window_Base
	{
		public Window_MapName() : base()
		{
			
		}
		public float _showCount;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateFadeIn()
		{
			throw new System.NotImplementedException();
		}
		public void updateFadeOut()
		{
			throw new System.NotImplementedException();
		}
		public void open()
		{
			throw new System.NotImplementedException();
		}
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawBackground(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_BattleLog : Window_Selectable
	{
		public Window_BattleLog() : base()
		{
			
		}
		public string[] _lines;
		public _methods_0_[] _methods;
		public float _waitCount;
		public string _waitMode;
		public float[] _baseLineStack;
		public Spriteset_Battle _spriteset;
		public Bitmap _backBitmap;
		public Sprite _backSprite;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void setSpriteset(Spriteset_Battle spriteset)
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float maxLines()
		{
			throw new System.NotImplementedException();
		}
		public void createBackBitmap()
		{
			throw new System.NotImplementedException();
		}
		public void createBackSprite()
		{
			throw new System.NotImplementedException();
		}
		public float numLines()
		{
			throw new System.NotImplementedException();
		}
		public float messageSpeed()
		{
			throw new System.NotImplementedException();
		}
		public bool isBusy()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public float updateWait()
		{
			throw new System.NotImplementedException();
		}
		public float updateWaitCount()
		{
			throw new System.NotImplementedException();
		}
		public float updateWaitMode()
		{
			throw new System.NotImplementedException();
		}
		public void setWaitMode(string waitMode)
		{
			throw new System.NotImplementedException();
		}
		public void callNextMethod()
		{
			throw new System.NotImplementedException();
		}
		public bool isFastForward()
		{
			throw new System.NotImplementedException();
		}
		public void push(string methodName, params object[][] args)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void wait()
		{
			throw new System.NotImplementedException();
		}
		public void waitForEffect()
		{
			throw new System.NotImplementedException();
		}
		public void waitForMovement()
		{
			throw new System.NotImplementedException();
		}
		public void addText(string text)
		{
			throw new System.NotImplementedException();
		}
		public void pushBaseLine()
		{
			throw new System.NotImplementedException();
		}
		public void popBaseLine()
		{
			throw new System.NotImplementedException();
		}
		public void waitForNewLine()
		{
			throw new System.NotImplementedException();
		}
		public void popupDamage(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performActionStart(Game_Battler subject, Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public void performAction(Game_Battler subject, Game_Action action)
		{
			throw new System.NotImplementedException();
		}
		public void performActionEnd(Game_Battler subject)
		{
			throw new System.NotImplementedException();
		}
		public void performDamage(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performMiss(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performRecovery(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performEvasion(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performMagicEvasion(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performCounter(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performReflection(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performSubstitute(Game_Battler substitute, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void performCollapse(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void showAnimation(Game_Battler subject, Game_Battler[] targets, float animationId)
		{
			throw new System.NotImplementedException();
		}
		public void showAttackAnimation(Game_Battler subject, Game_Battler[] targets)
		{
			throw new System.NotImplementedException();
		}
		public void showActorAttackAnimation(Game_Battler subject, Game_Battler[] targets)
		{
			throw new System.NotImplementedException();
		}
		public void showEnemyAttackAnimation(Game_Battler subject, Game_Battler[] targets)
		{
			throw new System.NotImplementedException();
		}
		public void showNormalAnimation(Game_Battler[] targets, float animationId, bool mirror)
		{
			throw new System.NotImplementedException();
		}
		public float animationBaseDelay()
		{
			throw new System.NotImplementedException();
		}
		public float animationNextDelay()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawBackground()
		{
			throw new System.NotImplementedException();
		}
		public BackRect_0_ backRect()
		{
			throw new System.NotImplementedException();
		}
		public string backColor()
		{
			throw new System.NotImplementedException();
		}
		public float backPaintOpacity()
		{
			throw new System.NotImplementedException();
		}
		public void drawLineText(float index)
		{
			throw new System.NotImplementedException();
		}
		public void startTurn()
		{
			throw new System.NotImplementedException();
		}
		public void startAction(Game_Battler subject, Game_Action action, Game_Battler[] targets)
		{
			throw new System.NotImplementedException();
		}
		public void endAction(Game_Battler subject)
		{
			throw new System.NotImplementedException();
		}
		public void displayCurrentState(Game_Battler subject)
		{
			throw new System.NotImplementedException();
		}
		public void displayRegeneration(Game_Battler subject)
		{
			throw new System.NotImplementedException();
		}
		public void displayAction(Game_Battler subject, IDataItem item)
		{
			throw new System.NotImplementedException();
		}
		public void displayCounter(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayReflection(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displaySubstitute(Game_Battler substitute, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayActionResults(Game_Battler substitute, Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayFailure(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayCritical(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayDamage(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayMiss(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayEvasion(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayHpDamage(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayMpDamage(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayTpDamage(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayAffectedStatus(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayAutoAffectedStatus(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayChangedStates(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayAddedStates(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayRemovedStates(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayChangedBuffs(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void displayBuffs(Game_Battler target, float[] buffs, string fmt)
		{
			throw new System.NotImplementedException();
		}
		public void makeHpDamageText(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void makeMpDamageText(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}
		public void makeTpDamageText(Game_Battler target)
		{
			throw new System.NotImplementedException();
		}

				public class _methods_0_
		{
			public string name;
			public object[] @params;
		}

				public class BackRect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_PartyCommand : Window_Command
	{
		public Window_PartyCommand() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void setup()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_ActorCommand : Window_Command
	{
		public Window_ActorCommand() : base()
		{
			
		}
		public Game_Actor _actor;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public void addAttackCommand()
		{
			throw new System.NotImplementedException();
		}
		public void addSkillCommands()
		{
			throw new System.NotImplementedException();
		}
		public void addGuardCommand()
		{
			throw new System.NotImplementedException();
		}
		public void addItemCommand()
		{
			throw new System.NotImplementedException();
		}
		public void setup(Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_BattleStatus : Window_Selectable
	{
		public Window_BattleStatus() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void basicAreaRect(float index)
		{
			throw new System.NotImplementedException();
		}
		public void gaugeAreaRect(float index)
		{
			throw new System.NotImplementedException();
		}
		public float gaugeAreaWidth()
		{
			throw new System.NotImplementedException();
		}
		public void drawBasicArea(Rect_1_ rect, Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void drawGaugeArea(Rect_3_ rect, Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void drawGaugeAreaWithTp(Rect_5_ rect, Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}
		public void drawGaugeAreaWithoutTp(Rect_7_ rect, Game_Actor actor)
		{
			throw new System.NotImplementedException();
		}

				public class Rect_0_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_1_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_2_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_3_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_4_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_5_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_6_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}

				public class Rect_7_
		{
			public float x;
			public float y;
			public float width;
			public float height;
		}
	}

		public class Window_BattleActor : Window_BattleStatus
	{
		public Window_BattleActor(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_BattleActor() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
		public void select(float index)
		{
			throw new System.NotImplementedException();
		}
		public Game_Actor actor()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_BattleEnemy : Window_Selectable
	{
		public Window_BattleEnemy(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_BattleEnemy() : base()
		{
			
		}
		public Game_Enemy[] _enemies;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float numVisibleRows()
		{
			throw new System.NotImplementedException();
		}
		public float maxCols()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public Game_Enemy enemy()
		{
			throw new System.NotImplementedException();
		}
		public float enemyIndex()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void select(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_BattleSkill : Window_SkillList
	{
		public Window_BattleSkill(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_BattleSkill() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_BattleItem : Window_ItemList
	{
		public Window_BattleItem(float x = default(float), float y = default(float), float width = default(float), float height = default(float)) : base()
		{
			
		}
		protected Window_BattleItem() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool includes(IDataAllItem item)
		{
			throw new System.NotImplementedException();
		}
		public void show()
		{
			throw new System.NotImplementedException();
		}
		public void hide()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_TitleCommand : Window_Command
	{
		public Window_TitleCommand() : base()
		{
			
		}
		public static string _lastCommandSymbol;
		public static void initCommandPosition()
		{
			throw new System.NotImplementedException();
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
		public bool isContinueEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void processOk()
		{
			throw new System.NotImplementedException();
		}
		public void selectLast()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_GameEnd : Window_Command
	{
		public Window_GameEnd() : base()
		{
			
		}
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public void updatePlacement()
		{
			throw new System.NotImplementedException();
		}
		public void makeCommandList()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_DebugRange : Window_Selectable
	{
		public Window_DebugRange(float x = default(float), float y = default(float)) : base()
		{
			
		}
		protected Window_DebugRange() : base()
		{
			
		}
		public float _maxSwitches;
		public float _maxVariables;
		public Window_DebugEdit _editWindow;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float windowWidth()
		{
			throw new System.NotImplementedException();
		}
		public float windowHeight()
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public string mode()
		{
			throw new System.NotImplementedException();
		}
		public float topId()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public bool isCancelTriggered()
		{
			throw new System.NotImplementedException();
		}
		public void processCancel()
		{
			throw new System.NotImplementedException();
		}
		public void setEditWindow(Window_DebugEdit editWindow)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Window_DebugEdit : Window_Selectable
	{
		public Window_DebugEdit(float x = default(float), float y = default(float), float width = default(float)) : base()
		{
			
		}
		protected Window_DebugEdit() : base()
		{
			
		}
		public string _mode;
		public float _topId;
		public void initialize()
		{
			throw new System.NotImplementedException();
		}
		public void initialize(float x = default(float), float y = default(float), float width = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float maxItems()
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void drawItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public string itemName(float dataId)
		{
			throw new System.NotImplementedException();
		}
		public void itemStatus(float dataId)
		{
			throw new System.NotImplementedException();
		}
		public void setMode(string mode)
		{
			throw new System.NotImplementedException();
		}
		public void setTopId(float id)
		{
			throw new System.NotImplementedException();
		}
		public float currentId()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public void updateSwitch()
		{
			throw new System.NotImplementedException();
		}
		public void updateVariable()
		{
			throw new System.NotImplementedException();
		}
	}
}
