
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		
public static class GLOBAL
{
	public static float NaN;
	public static float Infinity;
	public static ObjectConstructor Object;
		public static FunctionConstructor @Function;
	public static StringConstructor String;
	public static BooleanConstructor Boolean;
	public static NumberConstructor Number;
	public static Math Math;
	public static DateConstructor Date;
	public static RegExpConstructor RegExp;
	public static ErrorConstructor Error;
	public static EvalErrorConstructor EvalError;
	public static RangeErrorConstructor RangeError;
	public static ReferenceErrorConstructor ReferenceError;
	public static SyntaxErrorConstructor SyntaxError;
	public static TypeErrorConstructor TypeError;
	public static URIErrorConstructor URIError;
	public static JSON JSON;
		public static ArrayConstructor @Array;
	public static type ClassDecorator;
	public static Object target;
	public static type PropertyDecorator;
	public static Any<string, symbol> propertyKey;
	public static object void;
	public static type MethodDecorator;
	public static TypedPropertyDescriptor<T> descriptor;
	public static type ParameterDecorator;
	public static float parameterIndex;
	public static type PromiseConstructorLike;
	public static Action<Action<Any<T, PromiseLike<T>>>, Action<object>> executor;
	public static ArrayBufferConstructor ArrayBuffer;
	public static DataViewConstructor DataView;
	public static Int8ArrayConstructor Int8Array;
	public static Uint8ArrayConstructor Uint8Array;
	public static Uint8ClampedArrayConstructor Uint8ClampedArray;
	public static Int16ArrayConstructor Int16Array;
	public static Uint16ArrayConstructor Uint16Array;
	public static Int32ArrayConstructor Int32Array;
	public static Uint32ArrayConstructor Uint32Array;
	public static Float32ArrayConstructor Float32Array;
	public static Float64ArrayConstructor Float64Array;
	public static ANGLE_instanced_arrays_0_ ANGLE_instanced_arrays;
	public static AnalyserNode_0_ AnalyserNode;
	public static AnimationEvent_0_ AnimationEvent;
	public static ApplicationCache_0_ ApplicationCache;
	public static AriaRequestEvent_0_ AriaRequestEvent;
	public static Attr_0_ Attr;
	public static AudioBuffer_0_ AudioBuffer;
	public static AudioBufferSourceNode_0_ AudioBufferSourceNode;
	public static AudioContext_0_ AudioContext;
	public static AudioDestinationNode_0_ AudioDestinationNode;
	public static AudioListener_0_ AudioListener;
	public static AudioNode_0_ AudioNode;
	public static AudioParam_0_ AudioParam;
	public static AudioProcessingEvent_0_ AudioProcessingEvent;
	public static AudioTrack_0_ AudioTrack;
	public static AudioTrackList_0_ AudioTrackList;
	public static BarProp_0_ BarProp;
	public static BeforeUnloadEvent_0_ BeforeUnloadEvent;
	public static BiquadFilterNode_0_ BiquadFilterNode;
	public static Blob_0_ Blob;
	public static CDATASection_0_ CDATASection;
	public static CSS CSS;
	public static CSSConditionRule_0_ CSSConditionRule;
	public static CSSFontFaceRule_0_ CSSFontFaceRule;
	public static CSSGroupingRule_0_ CSSGroupingRule;
	public static CSSImportRule_0_ CSSImportRule;
	public static CSSKeyframeRule_0_ CSSKeyframeRule;
	public static CSSKeyframesRule_0_ CSSKeyframesRule;
	public static CSSMediaRule_0_ CSSMediaRule;
	public static CSSNamespaceRule_0_ CSSNamespaceRule;
	public static CSSPageRule_0_ CSSPageRule;
	public static CSSRule_0_ CSSRule;
	public static CSSRuleList_0_ CSSRuleList;
	public static CSSStyleDeclaration_0_ CSSStyleDeclaration;
	public static CSSStyleRule_0_ CSSStyleRule;
	public static CSSStyleSheet_0_ CSSStyleSheet;
	public static CSSSupportsRule_0_ CSSSupportsRule;
	public static CanvasGradient_0_ CanvasGradient;
	public static CanvasPattern_0_ CanvasPattern;
	public static CanvasRenderingContext2D_0_ CanvasRenderingContext2D;
	public static ChannelMergerNode_0_ ChannelMergerNode;
	public static ChannelSplitterNode_0_ ChannelSplitterNode;
	public static CharacterData_0_ CharacterData;
	public static ClientRect_0_ ClientRect;
	public static ClientRectList_0_ ClientRectList;
	public static ClipboardEvent_0_ ClipboardEvent;
	public static CloseEvent_0_ CloseEvent;
	public static CommandEvent_0_ CommandEvent;
	public static Comment_0_ Comment;
	public static CompositionEvent_0_ CompositionEvent;
	public static Console_0_ Console;
	public static ConvolverNode_0_ ConvolverNode;
	public static Coordinates_0_ Coordinates;
	public static Crypto_0_ Crypto;
	public static CryptoKey_0_ CryptoKey;
	public static CryptoKeyPair_0_ CryptoKeyPair;
	public static CustomEvent_0_ CustomEvent;
	public static DOMError_0_ DOMError;
	public static DOMException_0_ DOMException;
	public static DOMImplementation_0_ DOMImplementation;
	public static DOMParser_0_ DOMParser;
	public static DOMSettableTokenList_0_ DOMSettableTokenList;
	public static DOMStringList_0_ DOMStringList;
	public static DOMStringMap_0_ DOMStringMap;
	public static DOMTokenList_0_ DOMTokenList;
	public static DataCue_0_ DataCue;
	public static DataTransfer_0_ DataTransfer;
	public static DataTransferItem_0_ DataTransferItem;
	public static DataTransferItemList_0_ DataTransferItemList;
	public static DeferredPermissionRequest_0_ DeferredPermissionRequest;
	public static DelayNode_0_ DelayNode;
	public static DeviceAcceleration_0_ DeviceAcceleration;
	public static DeviceLightEvent_0_ DeviceLightEvent;
	public static DeviceMotionEvent_0_ DeviceMotionEvent;
	public static DeviceOrientationEvent_0_ DeviceOrientationEvent;
	public static DeviceRotationRate_0_ DeviceRotationRate;
	public static Document_0_ Document;
	public static DocumentFragment_0_ DocumentFragment;
	public static DocumentType_0_ DocumentType;
	public static DragEvent_0_ DragEvent;
	public static DynamicsCompressorNode_0_ DynamicsCompressorNode;
	public static EXT_frag_depth_0_ EXT_frag_depth;
	public static EXT_texture_filter_anisotropic_0_ EXT_texture_filter_anisotropic;
	public static Element_0_ Element;
	public static ErrorEvent_0_ ErrorEvent;
	public static Event_0_ Event;
	public static EventTarget_0_ EventTarget;
	public static External_0_ External;
	public static File_0_ File;
	public static FileList_0_ FileList;
	public static FileReader_0_ FileReader;
	public static FocusEvent_0_ FocusEvent;
	public static FormData_0_ FormData;
	public static GainNode_0_ GainNode;
	public static Gamepad_0_ Gamepad;
	public static GamepadButton_0_ GamepadButton;
	public static GamepadEvent_0_ GamepadEvent;
	public static Geolocation_0_ Geolocation;
	public static HTMLAllCollection_0_ HTMLAllCollection;
	public static HTMLAnchorElement_0_ HTMLAnchorElement;
	public static HTMLAppletElement_0_ HTMLAppletElement;
	public static HTMLAreaElement_0_ HTMLAreaElement;
	public static HTMLAreasCollection_0_ HTMLAreasCollection;
	public static HTMLAudioElement_0_ HTMLAudioElement;
	public static HTMLBRElement_0_ HTMLBRElement;
	public static HTMLBaseElement_0_ HTMLBaseElement;
	public static HTMLBaseFontElement_0_ HTMLBaseFontElement;
	public static HTMLBodyElement_0_ HTMLBodyElement;
	public static HTMLButtonElement_0_ HTMLButtonElement;
	public static HTMLCanvasElement_0_ HTMLCanvasElement;
	public static HTMLCollection_0_ HTMLCollection;
	public static HTMLDListElement_0_ HTMLDListElement;
	public static HTMLDataListElement_0_ HTMLDataListElement;
	public static HTMLDirectoryElement_0_ HTMLDirectoryElement;
	public static HTMLDivElement_0_ HTMLDivElement;
	public static HTMLDocument_0_ HTMLDocument;
	public static HTMLElement_0_ HTMLElement;
	public static HTMLEmbedElement_0_ HTMLEmbedElement;
	public static HTMLFieldSetElement_0_ HTMLFieldSetElement;
	public static HTMLFontElement_0_ HTMLFontElement;
	public static HTMLFormElement_0_ HTMLFormElement;
	public static HTMLFrameElement_0_ HTMLFrameElement;
	public static HTMLFrameSetElement_0_ HTMLFrameSetElement;
	public static HTMLHRElement_0_ HTMLHRElement;
	public static HTMLHeadElement_0_ HTMLHeadElement;
	public static HTMLHeadingElement_0_ HTMLHeadingElement;
	public static HTMLHtmlElement_0_ HTMLHtmlElement;
	public static HTMLIFrameElement_0_ HTMLIFrameElement;
	public static HTMLImageElement_0_ HTMLImageElement;
	public static HTMLInputElement_0_ HTMLInputElement;
	public static HTMLLIElement_0_ HTMLLIElement;
	public static HTMLLabelElement_0_ HTMLLabelElement;
	public static HTMLLegendElement_0_ HTMLLegendElement;
	public static HTMLLinkElement_0_ HTMLLinkElement;
	public static HTMLMapElement_0_ HTMLMapElement;
	public static HTMLMarqueeElement_0_ HTMLMarqueeElement;
	public static HTMLMediaElement_0_ HTMLMediaElement;
	public static HTMLMenuElement_0_ HTMLMenuElement;
	public static HTMLMetaElement_0_ HTMLMetaElement;
	public static HTMLMeterElement_0_ HTMLMeterElement;
	public static HTMLModElement_0_ HTMLModElement;
	public static HTMLOListElement_0_ HTMLOListElement;
	public static HTMLObjectElement_0_ HTMLObjectElement;
	public static HTMLOptGroupElement_0_ HTMLOptGroupElement;
	public static HTMLOptionElement_0_ HTMLOptionElement;
	public static HTMLOptionsCollection_0_ HTMLOptionsCollection;
	public static HTMLParagraphElement_0_ HTMLParagraphElement;
	public static HTMLParamElement_0_ HTMLParamElement;
	public static HTMLPictureElement_0_ HTMLPictureElement;
	public static HTMLPreElement_0_ HTMLPreElement;
	public static HTMLProgressElement_0_ HTMLProgressElement;
	public static HTMLQuoteElement_0_ HTMLQuoteElement;
	public static HTMLScriptElement_0_ HTMLScriptElement;
	public static HTMLSelectElement_0_ HTMLSelectElement;
	public static HTMLSourceElement_0_ HTMLSourceElement;
	public static HTMLSpanElement_0_ HTMLSpanElement;
	public static HTMLStyleElement_0_ HTMLStyleElement;
	public static HTMLTableCaptionElement_0_ HTMLTableCaptionElement;
	public static HTMLTableCellElement_0_ HTMLTableCellElement;
	public static HTMLTableColElement_0_ HTMLTableColElement;
	public static HTMLTableDataCellElement_0_ HTMLTableDataCellElement;
	public static HTMLTableElement_0_ HTMLTableElement;
	public static HTMLTableHeaderCellElement_0_ HTMLTableHeaderCellElement;
	public static HTMLTableRowElement_0_ HTMLTableRowElement;
	public static HTMLTableSectionElement_0_ HTMLTableSectionElement;
	public static HTMLTemplateElement_0_ HTMLTemplateElement;
	public static HTMLTextAreaElement_0_ HTMLTextAreaElement;
	public static HTMLTitleElement_0_ HTMLTitleElement;
	public static HTMLTrackElement_0_ HTMLTrackElement;
	public static HTMLUListElement_0_ HTMLUListElement;
	public static HTMLUnknownElement_0_ HTMLUnknownElement;
	public static HTMLVideoElement_0_ HTMLVideoElement;
	public static HashChangeEvent_0_ HashChangeEvent;
	public static History_0_ History;
	public static IDBCursor_0_ IDBCursor;
	public static IDBCursorWithValue_0_ IDBCursorWithValue;
	public static IDBDatabase_0_ IDBDatabase;
	public static IDBFactory_0_ IDBFactory;
	public static IDBIndex_0_ IDBIndex;
	public static IDBKeyRange_0_ IDBKeyRange;
	public static IDBObjectStore_0_ IDBObjectStore;
	public static IDBOpenDBRequest_0_ IDBOpenDBRequest;
	public static IDBRequest_0_ IDBRequest;
	public static IDBTransaction_0_ IDBTransaction;
	public static IDBVersionChangeEvent_0_ IDBVersionChangeEvent;
	public static ImageData_0_ ImageData;
	public static KeyboardEvent_0_ KeyboardEvent;
	public static ListeningStateChangedEvent_0_ ListeningStateChangedEvent;
	public static Location_0_ Location;
	public static LongRunningScriptDetectedEvent_0_ LongRunningScriptDetectedEvent;
	public static MSApp MSApp;
	public static MSAppAsyncOperation_0_ MSAppAsyncOperation;
	public static MSAssertion_0_ MSAssertion;
	public static MSBlobBuilder_0_ MSBlobBuilder;
	public static MSCredentials_0_ MSCredentials;
	public static MSFIDOCredentialAssertion_0_ MSFIDOCredentialAssertion;
	public static MSFIDOSignature_0_ MSFIDOSignature;
	public static MSFIDOSignatureAssertion_0_ MSFIDOSignatureAssertion;
	public static MSGesture_0_ MSGesture;
	public static MSGestureEvent_0_ MSGestureEvent;
	public static MSGraphicsTrust_0_ MSGraphicsTrust;
	public static MSHTMLWebViewElement_0_ MSHTMLWebViewElement;
	public static MSInputMethodContext_0_ MSInputMethodContext;
	public static MSManipulationEvent_0_ MSManipulationEvent;
	public static MSMediaKeyError_0_ MSMediaKeyError;
	public static MSMediaKeyMessageEvent_0_ MSMediaKeyMessageEvent;
	public static MSMediaKeyNeededEvent_0_ MSMediaKeyNeededEvent;
	public static MSMediaKeySession_0_ MSMediaKeySession;
	public static MSMediaKeys_0_ MSMediaKeys;
	public static MSPointerEvent_0_ MSPointerEvent;
	public static MSRangeCollection_0_ MSRangeCollection;
	public static MSSiteModeEvent_0_ MSSiteModeEvent;
	public static MSStream_0_ MSStream;
	public static MSStreamReader_0_ MSStreamReader;
	public static MSWebViewAsyncOperation_0_ MSWebViewAsyncOperation;
	public static MSWebViewSettings_0_ MSWebViewSettings;
	public static MediaDeviceInfo_0_ MediaDeviceInfo;
	public static MediaDevices_0_ MediaDevices;
	public static MediaElementAudioSourceNode_0_ MediaElementAudioSourceNode;
	public static MediaEncryptedEvent_0_ MediaEncryptedEvent;
	public static MediaError_0_ MediaError;
	public static MediaKeyMessageEvent_0_ MediaKeyMessageEvent;
	public static MediaKeySession_0_ MediaKeySession;
	public static MediaKeyStatusMap_0_ MediaKeyStatusMap;
	public static MediaKeySystemAccess_0_ MediaKeySystemAccess;
	public static MediaKeys_0_ MediaKeys;
	public static MediaList_0_ MediaList;
	public static MediaQueryList_0_ MediaQueryList;
	public static MediaSource_0_ MediaSource;
	public static MediaStream_0_ MediaStream;
	public static MediaStreamAudioSourceNode_0_ MediaStreamAudioSourceNode;
	public static MediaStreamError_0_ MediaStreamError;
	public static MediaStreamErrorEvent_0_ MediaStreamErrorEvent;
	public static MediaStreamTrack_0_ MediaStreamTrack;
	public static MediaStreamTrackEvent_0_ MediaStreamTrackEvent;
	public static MessageChannel_0_ MessageChannel;
	public static MessageEvent_0_ MessageEvent;
	public static MessagePort_0_ MessagePort;
	public static MimeType_0_ MimeType;
	public static MimeTypeArray_0_ MimeTypeArray;
	public static MouseEvent_0_ MouseEvent;
	public static MutationEvent_0_ MutationEvent;
	public static MutationObserver_0_ MutationObserver;
	public static MutationRecord_0_ MutationRecord;
	public static NamedNodeMap_0_ NamedNodeMap;
	public static NavigationCompletedEvent_0_ NavigationCompletedEvent;
	public static NavigationEvent_0_ NavigationEvent;
	public static NavigationEventWithReferrer_0_ NavigationEventWithReferrer;
	public static Navigator_0_ Navigator;
	public static Node_0_ Node;
	public static NodeFilter_0_ NodeFilter;
	public static NodeIterator_0_ NodeIterator;
	public static NodeList_0_ NodeList;
	public static OES_element_index_uint_0_ OES_element_index_uint;
	public static OES_standard_derivatives_0_ OES_standard_derivatives;
	public static OES_texture_float_0_ OES_texture_float;
	public static OES_texture_float_linear_0_ OES_texture_float_linear;
	public static OfflineAudioCompletionEvent_0_ OfflineAudioCompletionEvent;
	public static OfflineAudioContext_0_ OfflineAudioContext;
	public static OscillatorNode_0_ OscillatorNode;
	public static OverflowEvent_0_ OverflowEvent;
	public static PageTransitionEvent_0_ PageTransitionEvent;
	public static PannerNode_0_ PannerNode;
	public static PerfWidgetExternal_0_ PerfWidgetExternal;
	public static Performance_0_ Performance;
	public static PerformanceEntry_0_ PerformanceEntry;
	public static PerformanceMark_0_ PerformanceMark;
	public static PerformanceMeasure_0_ PerformanceMeasure;
	public static PerformanceNavigation_0_ PerformanceNavigation;
	public static PerformanceNavigationTiming_0_ PerformanceNavigationTiming;
	public static PerformanceResourceTiming_0_ PerformanceResourceTiming;
	public static PerformanceTiming_0_ PerformanceTiming;
	public static PeriodicWave_0_ PeriodicWave;
	public static PermissionRequest_0_ PermissionRequest;
	public static PermissionRequestedEvent_0_ PermissionRequestedEvent;
	public static Plugin_0_ Plugin;
	public static PluginArray_0_ PluginArray;
	public static PointerEvent_0_ PointerEvent;
	public static PopStateEvent_0_ PopStateEvent;
	public static Position_0_ Position;
	public static PositionError_0_ PositionError;
	public static ProcessingInstruction_0_ ProcessingInstruction;
	public static ProgressEvent_0_ ProgressEvent;
	public static RTCDTMFToneChangeEvent_0_ RTCDTMFToneChangeEvent;
	public static RTCDtlsTransport_0_ RTCDtlsTransport;
	public static RTCDtlsTransportStateChangedEvent_0_ RTCDtlsTransportStateChangedEvent;
	public static RTCDtmfSender_0_ RTCDtmfSender;
	public static RTCIceCandidatePairChangedEvent_0_ RTCIceCandidatePairChangedEvent;
	public static RTCIceGatherer_0_ RTCIceGatherer;
	public static RTCIceGathererEvent_0_ RTCIceGathererEvent;
	public static RTCIceTransport_0_ RTCIceTransport;
	public static RTCIceTransportStateChangedEvent_0_ RTCIceTransportStateChangedEvent;
	public static RTCRtpReceiver_0_ RTCRtpReceiver;
	public static RTCRtpSender_0_ RTCRtpSender;
	public static RTCSrtpSdesTransport_0_ RTCSrtpSdesTransport;
	public static RTCSsrcConflictEvent_0_ RTCSsrcConflictEvent;
	public static RTCStatsProvider_0_ RTCStatsProvider;
	public static Range_0_ Range;
	public static SVGAElement_0_ SVGAElement;
	public static SVGAngle_0_ SVGAngle;
	public static SVGAnimatedAngle_0_ SVGAnimatedAngle;
	public static SVGAnimatedBoolean_0_ SVGAnimatedBoolean;
	public static SVGAnimatedEnumeration_0_ SVGAnimatedEnumeration;
	public static SVGAnimatedInteger_0_ SVGAnimatedInteger;
	public static SVGAnimatedLength_0_ SVGAnimatedLength;
	public static SVGAnimatedLengthList_0_ SVGAnimatedLengthList;
	public static SVGAnimatedNumber_0_ SVGAnimatedNumber;
	public static SVGAnimatedNumberList_0_ SVGAnimatedNumberList;
	public static SVGAnimatedPreserveAspectRatio_0_ SVGAnimatedPreserveAspectRatio;
	public static SVGAnimatedRect_0_ SVGAnimatedRect;
	public static SVGAnimatedString_0_ SVGAnimatedString;
	public static SVGAnimatedTransformList_0_ SVGAnimatedTransformList;
	public static SVGCircleElement_0_ SVGCircleElement;
	public static SVGClipPathElement_0_ SVGClipPathElement;
	public static SVGComponentTransferFunctionElement_0_ SVGComponentTransferFunctionElement;
	public static SVGDefsElement_0_ SVGDefsElement;
	public static SVGDescElement_0_ SVGDescElement;
	public static SVGElement_0_ SVGElement;
	public static SVGElementInstance_0_ SVGElementInstance;
	public static SVGElementInstanceList_0_ SVGElementInstanceList;
	public static SVGEllipseElement_0_ SVGEllipseElement;
	public static SVGFEBlendElement_0_ SVGFEBlendElement;
	public static SVGFEColorMatrixElement_0_ SVGFEColorMatrixElement;
	public static SVGFEComponentTransferElement_0_ SVGFEComponentTransferElement;
	public static SVGFECompositeElement_0_ SVGFECompositeElement;
	public static SVGFEConvolveMatrixElement_0_ SVGFEConvolveMatrixElement;
	public static SVGFEDiffuseLightingElement_0_ SVGFEDiffuseLightingElement;
	public static SVGFEDisplacementMapElement_0_ SVGFEDisplacementMapElement;
	public static SVGFEDistantLightElement_0_ SVGFEDistantLightElement;
	public static SVGFEFloodElement_0_ SVGFEFloodElement;
	public static SVGFEFuncAElement_0_ SVGFEFuncAElement;
	public static SVGFEFuncBElement_0_ SVGFEFuncBElement;
	public static SVGFEFuncGElement_0_ SVGFEFuncGElement;
	public static SVGFEFuncRElement_0_ SVGFEFuncRElement;
	public static SVGFEGaussianBlurElement_0_ SVGFEGaussianBlurElement;
	public static SVGFEImageElement_0_ SVGFEImageElement;
	public static SVGFEMergeElement_0_ SVGFEMergeElement;
	public static SVGFEMergeNodeElement_0_ SVGFEMergeNodeElement;
	public static SVGFEMorphologyElement_0_ SVGFEMorphologyElement;
	public static SVGFEOffsetElement_0_ SVGFEOffsetElement;
	public static SVGFEPointLightElement_0_ SVGFEPointLightElement;
	public static SVGFESpecularLightingElement_0_ SVGFESpecularLightingElement;
	public static SVGFESpotLightElement_0_ SVGFESpotLightElement;
	public static SVGFETileElement_0_ SVGFETileElement;
	public static SVGFETurbulenceElement_0_ SVGFETurbulenceElement;
	public static SVGFilterElement_0_ SVGFilterElement;
	public static SVGForeignObjectElement_0_ SVGForeignObjectElement;
	public static SVGGElement_0_ SVGGElement;
	public static SVGGradientElement_0_ SVGGradientElement;
	public static SVGImageElement_0_ SVGImageElement;
	public static SVGLength_0_ SVGLength;
	public static SVGLengthList_0_ SVGLengthList;
	public static SVGLineElement_0_ SVGLineElement;
	public static SVGLinearGradientElement_0_ SVGLinearGradientElement;
	public static SVGMarkerElement_0_ SVGMarkerElement;
	public static SVGMaskElement_0_ SVGMaskElement;
	public static SVGMatrix_0_ SVGMatrix;
	public static SVGMetadataElement_0_ SVGMetadataElement;
	public static SVGNumber_0_ SVGNumber;
	public static SVGNumberList_0_ SVGNumberList;
	public static SVGPathElement_0_ SVGPathElement;
	public static SVGPathSeg_0_ SVGPathSeg;
	public static SVGPathSegArcAbs_0_ SVGPathSegArcAbs;
	public static SVGPathSegArcRel_0_ SVGPathSegArcRel;
	public static SVGPathSegClosePath_0_ SVGPathSegClosePath;
	public static SVGPathSegCurvetoCubicAbs_0_ SVGPathSegCurvetoCubicAbs;
	public static SVGPathSegCurvetoCubicRel_0_ SVGPathSegCurvetoCubicRel;
	public static SVGPathSegCurvetoCubicSmoothAbs_0_ SVGPathSegCurvetoCubicSmoothAbs;
	public static SVGPathSegCurvetoCubicSmoothRel_0_ SVGPathSegCurvetoCubicSmoothRel;
	public static SVGPathSegCurvetoQuadraticAbs_0_ SVGPathSegCurvetoQuadraticAbs;
	public static SVGPathSegCurvetoQuadraticRel_0_ SVGPathSegCurvetoQuadraticRel;
	public static SVGPathSegCurvetoQuadraticSmoothAbs_0_ SVGPathSegCurvetoQuadraticSmoothAbs;
	public static SVGPathSegCurvetoQuadraticSmoothRel_0_ SVGPathSegCurvetoQuadraticSmoothRel;
	public static SVGPathSegLinetoAbs_0_ SVGPathSegLinetoAbs;
	public static SVGPathSegLinetoHorizontalAbs_0_ SVGPathSegLinetoHorizontalAbs;
	public static SVGPathSegLinetoHorizontalRel_0_ SVGPathSegLinetoHorizontalRel;
	public static SVGPathSegLinetoRel_0_ SVGPathSegLinetoRel;
	public static SVGPathSegLinetoVerticalAbs_0_ SVGPathSegLinetoVerticalAbs;
	public static SVGPathSegLinetoVerticalRel_0_ SVGPathSegLinetoVerticalRel;
	public static SVGPathSegList_0_ SVGPathSegList;
	public static SVGPathSegMovetoAbs_0_ SVGPathSegMovetoAbs;
	public static SVGPathSegMovetoRel_0_ SVGPathSegMovetoRel;
	public static SVGPatternElement_0_ SVGPatternElement;
	public static SVGPoint_0_ SVGPoint;
	public static SVGPointList_0_ SVGPointList;
	public static SVGPolygonElement_0_ SVGPolygonElement;
	public static SVGPolylineElement_0_ SVGPolylineElement;
	public static SVGPreserveAspectRatio_0_ SVGPreserveAspectRatio;
	public static SVGRadialGradientElement_0_ SVGRadialGradientElement;
	public static SVGRect_0_ SVGRect;
	public static SVGRectElement_0_ SVGRectElement;
	public static SVGSVGElement_0_ SVGSVGElement;
	public static SVGScriptElement_0_ SVGScriptElement;
	public static SVGStopElement_0_ SVGStopElement;
	public static SVGStringList_0_ SVGStringList;
	public static SVGStyleElement_0_ SVGStyleElement;
	public static SVGSwitchElement_0_ SVGSwitchElement;
	public static SVGSymbolElement_0_ SVGSymbolElement;
	public static SVGTSpanElement_0_ SVGTSpanElement;
	public static SVGTextContentElement_0_ SVGTextContentElement;
	public static SVGTextElement_0_ SVGTextElement;
	public static SVGTextPathElement_0_ SVGTextPathElement;
	public static SVGTextPositioningElement_0_ SVGTextPositioningElement;
	public static SVGTitleElement_0_ SVGTitleElement;
	public static SVGTransform_0_ SVGTransform;
	public static SVGTransformList_0_ SVGTransformList;
	public static SVGUnitTypes SVGUnitTypes;
	public static SVGUseElement_0_ SVGUseElement;
	public static SVGViewElement_0_ SVGViewElement;
	public static SVGZoomAndPan_0_ SVGZoomAndPan;
	public static SVGZoomEvent_0_ SVGZoomEvent;
	public static Screen_0_ Screen;
	public static ScriptNotifyEvent_0_ ScriptNotifyEvent;
	public static ScriptProcessorNode_0_ ScriptProcessorNode;
	public static Selection_0_ Selection;
	public static SourceBuffer_0_ SourceBuffer;
	public static SourceBufferList_0_ SourceBufferList;
	public static StereoPannerNode_0_ StereoPannerNode;
	public static Storage_0_ Storage;
	public static StorageEvent_0_ StorageEvent;
	public static StyleMedia_0_ StyleMedia;
	public static StyleSheet_0_ StyleSheet;
	public static StyleSheetList_0_ StyleSheetList;
	public static StyleSheetPageList_0_ StyleSheetPageList;
	public static SubtleCrypto_0_ SubtleCrypto;
	public static Text_0_ Text;
	public static TextEvent_0_ TextEvent;
	public static TextMetrics_0_ TextMetrics;
	public static TextTrack_0_ TextTrack;
	public static TextTrackCue_0_ TextTrackCue;
	public static TextTrackCueList_0_ TextTrackCueList;
	public static TextTrackList_0_ TextTrackList;
	public static TimeRanges_0_ TimeRanges;
	public static Touch_0_ Touch;
	public static TouchEvent_0_ TouchEvent;
	public static TouchList_0_ TouchList;
	public static TrackEvent_0_ TrackEvent;
	public static TransitionEvent_0_ TransitionEvent;
	public static TreeWalker_0_ TreeWalker;
	public static UIEvent_0_ UIEvent;
	public static URL_0_ URL;
	public static UnviewableContentIdentifiedEvent_0_ UnviewableContentIdentifiedEvent;
	public static ValidityState_0_ ValidityState;
	public static VideoPlaybackQuality_0_ VideoPlaybackQuality;
	public static VideoTrack_0_ VideoTrack;
	public static VideoTrackList_0_ VideoTrackList;
	public static WEBGL_compressed_texture_s3tc_0_ WEBGL_compressed_texture_s3tc;
	public static WEBGL_debug_renderer_info_0_ WEBGL_debug_renderer_info;
	public static WEBGL_depth_texture_0_ WEBGL_depth_texture;
	public static WaveShaperNode_0_ WaveShaperNode;
	public static WebGLActiveInfo_0_ WebGLActiveInfo;
	public static WebGLBuffer_0_ WebGLBuffer;
	public static WebGLContextEvent_0_ WebGLContextEvent;
	public static WebGLFramebuffer_0_ WebGLFramebuffer;
	public static WebGLObject_0_ WebGLObject;
	public static WebGLProgram_0_ WebGLProgram;
	public static WebGLRenderbuffer_0_ WebGLRenderbuffer;
	public static WebGLRenderingContext_0_ WebGLRenderingContext;
	public static WebGLShader_0_ WebGLShader;
	public static WebGLShaderPrecisionFormat_0_ WebGLShaderPrecisionFormat;
	public static WebGLTexture_0_ WebGLTexture;
	public static WebGLUniformLocation_0_ WebGLUniformLocation;
	public static WebKitCSSMatrix_0_ WebKitCSSMatrix;
	public static WebKitPoint_0_ WebKitPoint;
	public static WebSocket_0_ WebSocket;
	public static WheelEvent_0_ WheelEvent;
	public static Worker_0_ Worker;
	public static XMLDocument_0_ XMLDocument;
	public static XMLHttpRequest_0_ XMLHttpRequest;
	public static XMLHttpRequestUpload_0_ XMLHttpRequestUpload;
	public static XMLSerializer_0_ XMLSerializer;
	public static XPathEvaluator_0_ XPathEvaluator;
	public static XPathExpression_0_ XPathExpression;
	public static XPathNSResolver_0_ XPathNSResolver;
	public static XPathResult_0_ XPathResult;
	public static XSLTProcessor_0_ XSLTProcessor;
	public static type EventListenerOrEventListenerObject;
	public static Audio_0_ Audio;
	public static Image_0_ Image;
	public static Option_0_ Option;
	public static ApplicationCache applicationCache;
	public static Navigator clientInformation;
	public static bool closed;
	public static Crypto crypto;
	public static string defaultStatus;
	public static float devicePixelRatio;
	public static string doNotTrack;
	public static Document document;
		public static Event @event;
	public static External external;
	public static Element frameElement;
	public static IWindow frames;
	public static History history;
	public static float innerHeight;
	public static float innerWidth;
	public static float length;
	public static Location location;
	public static BarProp locationbar;
	public static BarProp menubar;
	public static MSCredentials msCredentials;
	public static never name;
	public static Navigator navigator;
	public static Any<string, bool> offscreenBuffering;
	public static Func<, IWindow> onabort;
	public static WheelEvent ev;
	public static object any;
	public static Func<, IWindow> onafterprint;
	public static Func<, IWindow> onbeforeprint;
	public static Func<, IWindow> onbeforeunload;
	public static Func<, IWindow> onblur;
	public static Func<, IWindow> oncanplay;
	public static Func<, IWindow> oncanplaythrough;
	public static Func<, IWindow> onchange;
	public static Func<, IWindow> onclick;
	public static Func<, IWindow> oncompassneedscalibration;
	public static Func<, IWindow> oncontextmenu;
	public static Func<, IWindow> ondblclick;
	public static Func<, IWindow> ondevicelight;
	public static Func<, IWindow> ondevicemotion;
	public static Func<, IWindow> ondeviceorientation;
	public static Func<, IWindow> ondrag;
	public static Func<, IWindow> ondragend;
	public static Func<, IWindow> ondragenter;
	public static Func<, IWindow> ondragleave;
	public static Func<, IWindow> ondragover;
	public static Func<, IWindow> ondragstart;
	public static Func<, IWindow> ondrop;
	public static Func<, IWindow> ondurationchange;
	public static Func<, IWindow> onemptied;
	public static Func<, IWindow> onended;
	public static ErrorEventHandler onerror;
	public static Func<, IWindow> onfocus;
	public static Func<, IWindow> onhashchange;
	public static Func<, IWindow> oninput;
	public static Func<, IWindow> oninvalid;
	public static Func<, IWindow> onkeydown;
	public static Func<, IWindow> onkeypress;
	public static Func<, IWindow> onkeyup;
	public static Func<, IWindow> onload;
	public static Func<, IWindow> onloadeddata;
	public static Func<, IWindow> onloadedmetadata;
	public static Func<, IWindow> onloadstart;
	public static Func<, IWindow> onmessage;
	public static Func<, IWindow> onmousedown;
	public static Func<, IWindow> onmouseenter;
	public static Func<, IWindow> onmouseleave;
	public static Func<, IWindow> onmousemove;
	public static Func<, IWindow> onmouseout;
	public static Func<, IWindow> onmouseover;
	public static Func<, IWindow> onmouseup;
	public static Func<, IWindow> onmousewheel;
	public static Func<, IWindow> onmsgesturechange;
	public static Func<, IWindow> onmsgesturedoubletap;
	public static Func<, IWindow> onmsgestureend;
	public static Func<, IWindow> onmsgesturehold;
	public static Func<, IWindow> onmsgesturestart;
	public static Func<, IWindow> onmsgesturetap;
	public static Func<, IWindow> onmsinertiastart;
	public static Func<, IWindow> onmspointercancel;
	public static Func<, IWindow> onmspointerdown;
	public static Func<, IWindow> onmspointerenter;
	public static Func<, IWindow> onmspointerleave;
	public static Func<, IWindow> onmspointermove;
	public static Func<, IWindow> onmspointerout;
	public static Func<, IWindow> onmspointerover;
	public static Func<, IWindow> onmspointerup;
	public static Func<, IWindow> onoffline;
	public static Func<, IWindow> ononline;
	public static Func<, IWindow> onorientationchange;
	public static Func<, IWindow> onpagehide;
	public static Func<, IWindow> onpageshow;
	public static Func<, IWindow> onpause;
	public static Func<, IWindow> onplay;
	public static Func<, IWindow> onplaying;
	public static Func<, IWindow> onpopstate;
	public static Func<, IWindow> onprogress;
	public static Func<, IWindow> onratechange;
	public static Func<, IWindow> onreadystatechange;
	public static Func<, IWindow> onreset;
	public static Func<, IWindow> onresize;
	public static Func<, IWindow> onscroll;
	public static Func<, IWindow> onseeked;
	public static Func<, IWindow> onseeking;
	public static Func<, IWindow> onselect;
	public static Func<, IWindow> onstalled;
	public static Func<, IWindow> onstorage;
	public static Func<, IWindow> onsubmit;
	public static Func<, IWindow> onsuspend;
	public static Func<, IWindow> ontimeupdate;
	public static Func<TouchEvent, object> ontouchcancel;
	public static Func<TouchEvent, object> ontouchend;
	public static Func<TouchEvent, object> ontouchmove;
	public static Func<TouchEvent, object> ontouchstart;
	public static Func<, IWindow> onunload;
	public static Func<, IWindow> onvolumechange;
	public static Func<, IWindow> onwaiting;
	public static object opener;
	public static Any<string, float> orientation;
	public static float outerHeight;
	public static float outerWidth;
	public static float pageXOffset;
	public static float pageYOffset;
	public static IWindow parent;
	public static Performance performance;
	public static BarProp personalbar;
	public static Screen screen;
	public static float screenLeft;
	public static float screenTop;
	public static float screenX;
	public static float screenY;
	public static float scrollX;
	public static float scrollY;
	public static BarProp scrollbars;
	public static IWindow self;
	public static string status;
	public static BarProp statusbar;
	public static StyleMedia styleMedia;
	public static BarProp toolbar;
	public static IWindow top;
	public static IWindow window;
	public static Storage sessionStorage;
	public static Storage localStorage;
	public static Console console;
	public static Func<, IWindow> onpointercancel;
	public static Func<, IWindow> onpointerdown;
	public static Func<, IWindow> onpointerenter;
	public static Func<, IWindow> onpointerleave;
	public static Func<, IWindow> onpointermove;
	public static Func<, IWindow> onpointerout;
	public static Func<, IWindow> onpointerover;
	public static Func<, IWindow> onpointerup;
	public static Func<, IWindow> onwheel;
	public static IDBFactory indexedDB;
	public static Func<, IWindow> listener;
	public static bool useCapture;
	public static type AAGUID;
	public static type AlgorithmIdentifier;
	public static type ConstrainBoolean;
	public static type ConstrainDOMString;
	public static type ConstrainDouble;
	public static type ConstrainLong;
	public static type CryptoOperationData;
	public static type GLbitfield;
	public static type GLboolean;
	public static type GLbyte;
	public static type GLclampf;
	public static type GLenum;
	public static type GLfloat;
	public static type GLint;
	public static type GLintptr;
	public static type GLshort;
	public static type GLsizei;
	public static type GLsizeiptr;
	public static type GLubyte;
	public static type GLuint;
	public static type GLushort;
	public static type IDBKeyPath;
	public static type KeyFormat;
	public static type KeyType;
	public static type KeyUsage;
	public static type MSInboundPayload;
	public static type MSLocalClientEvent;
	public static type MSOutboundPayload;
	public static type RTCIceGatherCandidate;
	public static type RTCTransport;
	public static type payloadtype;
	public static type ScrollBehavior;
	public static type ScrollLogicalPosition;
	public static type IDBValidKey;
	public static type BufferSource;
	public static type MouseWheelEvent;
	public static ActiveXObject ActiveXObject;
	public static WScript_0_ WScript;
	public static EnumeratorConstructor Enumerator;
	public static VBArrayConstructor VBArray;
	public static object eval(string x)
	{
		throw new System.NotImplementedException();
	}
	public static float parseInt(string s, float radix = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static float parseFloat(string @string)
	{
		throw new System.NotImplementedException();
	}
	public static bool isNaN(float number)
	{
		throw new System.NotImplementedException();
	}
	public static bool isFinite(float number)
	{
		throw new System.NotImplementedException();
	}
	public static string decodeURI(string encodedURI)
	{
		throw new System.NotImplementedException();
	}
	public static string decodeURIComponent(string encodedURIComponent)
	{
		throw new System.NotImplementedException();
	}
	public static string encodeURI(string uri)
	{
		throw new System.NotImplementedException();
	}
	public static string encodeURIComponent(string uriComponent)
	{
		throw new System.NotImplementedException();
	}
	public static void alert(object message = default(object))
	{
		throw new System.NotImplementedException();
	}
	public static void blur()
	{
		throw new System.NotImplementedException();
	}
	public static void cancelAnimationFrame(float handle)
	{
		throw new System.NotImplementedException();
	}
	public static void captureEvents()
	{
		throw new System.NotImplementedException();
	}
	public static void close()
	{
		throw new System.NotImplementedException();
	}
	public static bool confirm(string message = default(string))
	{
		throw new System.NotImplementedException();
	}
	public static void focus()
	{
		throw new System.NotImplementedException();
	}
	public static CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt = default(string))
	{
		throw new System.NotImplementedException();
	}
	public static CSSRuleList getMatchedCSSRules(Element elt, string pseudoElt = default(string))
	{
		throw new System.NotImplementedException();
	}
	public static Selection getSelection()
	{
		throw new System.NotImplementedException();
	}
	public static MediaQueryList matchMedia(string mediaQuery)
	{
		throw new System.NotImplementedException();
	}
	public static void moveBy(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void moveTo(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void msWriteProfilerMark(string profilerMarkName)
	{
		throw new System.NotImplementedException();
	}
	public static IWindow open(string url = default(string), string target = default(string), string features = default(string), bool replace = default(bool))
	{
		throw new System.NotImplementedException();
	}
	public static void postMessage(object message, string targetOrigin, object[] transfer = default(object[]))
	{
		throw new System.NotImplementedException();
	}
	public static void print()
	{
		throw new System.NotImplementedException();
	}
	public static Any<string, null> prompt(string message = default(string), string _default = default(string))
	{
		throw new System.NotImplementedException();
	}
	public static void releaseEvents()
	{
		throw new System.NotImplementedException();
	}
	public static float requestAnimationFrame(FrameRequestCallback callback)
	{
		throw new System.NotImplementedException();
	}
	public static void resizeBy(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void resizeTo(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void scroll(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void scroll(ScrollToOptions options = default(ScrollToOptions))
	{
		throw new System.NotImplementedException();
	}
	public static void scrollBy(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void scrollBy(ScrollToOptions options = default(ScrollToOptions))
	{
		throw new System.NotImplementedException();
	}
	public static void scrollTo(float x = default(float), float y = default(float))
	{
		throw new System.NotImplementedException();
	}
	public static void scrollTo(ScrollToOptions options = default(ScrollToOptions))
	{
		throw new System.NotImplementedException();
	}
	public static void webkitCancelAnimationFrame(float handle)
	{
		throw new System.NotImplementedException();
	}
	public static WebKitPoint webkitConvertPointFromNodeToPage(Node node, WebKitPoint pt)
	{
		throw new System.NotImplementedException();
	}
	public static WebKitPoint webkitConvertPointFromPageToNode(Node node, WebKitPoint pt)
	{
		throw new System.NotImplementedException();
	}
	public static float webkitRequestAnimationFrame(FrameRequestCallback callback)
	{
		throw new System.NotImplementedException();
	}
	public static string toString()
	{
		throw new System.NotImplementedException();
	}
	public static void addEventListener(string type, EventListenerOrEventListenerObject listener = default(EventListenerOrEventListenerObject), bool useCapture = default(bool))
	{
		throw new System.NotImplementedException();
	}
	public static object addEventListener(object type)
	{
		throw new System.NotImplementedException();
	}
	public static bool dispatchEvent(Event evt)
	{
		throw new System.NotImplementedException();
	}
	public static void removeEventListener(string type, EventListenerOrEventListenerObject listener = default(EventListenerOrEventListenerObject), bool useCapture = default(bool))
	{
		throw new System.NotImplementedException();
	}
	public static void clearInterval(float handle)
	{
		throw new System.NotImplementedException();
	}
	public static void clearTimeout(float handle)
	{
		throw new System.NotImplementedException();
	}
	public static float setInterval(Action<object[]> handler, float timeout)
	{
		throw new System.NotImplementedException();
	}
	public static float setInterval(object handler, object timeout = default(object), params object[][] args)
	{
		throw new System.NotImplementedException();
	}
	public static float setTimeout(Action<object[]> handler, float timeout)
	{
		throw new System.NotImplementedException();
	}
	public static float setTimeout(object handler, object timeout = default(object), params object[][] args)
	{
		throw new System.NotImplementedException();
	}
	public static void clearImmediate(float handle)
	{
		throw new System.NotImplementedException();
	}
	public static float setImmediate(Action<object[]> handler)
	{
		throw new System.NotImplementedException();
	}
	public static float setImmediate(object handler, params object[][] args)
	{
		throw new System.NotImplementedException();
	}
	public static string atob(string encodedString)
	{
		throw new System.NotImplementedException();
	}
	public static string btoa(string rawString)
	{
		throw new System.NotImplementedException();
	}
	public static void importScripts(params string[] urls)
	{
		throw new System.NotImplementedException();
	}

		public class PropertyDescriptor
	{
		protected PropertyDescriptor()
		{
			
		}
		public bool configurable;
		public bool enumerable;
		public object value;
		public bool writable;
		public Func<, object> get()
		{
			throw new System.NotImplementedException();
		}
		public Func<object, void> set()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PropertyDescriptorMap
	{
		protected PropertyDescriptorMap()
		{
			
		}
		public string s;
	}

		public class Object
	{
		public Object()
		{
			
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public Object valueOf()
		{
			throw new System.NotImplementedException();
		}
		public bool hasOwnProperty(string v)
		{
			throw new System.NotImplementedException();
		}
		public bool isPrototypeOf(Object v)
		{
			throw new System.NotImplementedException();
		}
		public bool propertyIsEnumerable(string v)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ObjectConstructor
	{
		protected ObjectConstructor()
		{
			
		}
		public object value;
		public readonly prototype;
		public Object new(object value = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object getPrototypeOf(object o)
		{
			throw new System.NotImplementedException();
		}
		public PropertyDescriptor getOwnPropertyDescriptor(object o, string p)
		{
			throw new System.NotImplementedException();
		}
		public string[] getOwnPropertyNames(object o)
		{
			throw new System.NotImplementedException();
		}
		public object create(null o)
		{
			throw new System.NotImplementedException();
		}
		public T create<T>(T o)
		{
			throw new System.NotImplementedException();
		}
		public object create(object o, PropertyDescriptorMap properties)
		{
			throw new System.NotImplementedException();
		}
		public object defineProperty(object o, string p, PropertyDescriptor attributes)
		{
			throw new System.NotImplementedException();
		}
		public object defineProperties(object o, PropertyDescriptorMap properties)
		{
			throw new System.NotImplementedException();
		}
		public T seal<T>(T o)
		{
			throw new System.NotImplementedException();
		}
		public T freeze<T>(T o)
		{
			throw new System.NotImplementedException();
		}
		public T preventExtensions<T>(T o)
		{
			throw new System.NotImplementedException();
		}
		public bool isSealed(object o)
		{
			throw new System.NotImplementedException();
		}
		public bool isFrozen(object o)
		{
			throw new System.NotImplementedException();
		}
		public bool isExtensible(object o)
		{
			throw new System.NotImplementedException();
		}
		public string[] keys(object o)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Function
	{
		protected Function()
		{
			
		}
		public object thisArg;
		public object[] argArray;
		public object prototype;
		public readonly length;
		public object arguments;
		public Function caller;
		public Function apply()
		{
			throw new System.NotImplementedException();
		}
		public Function call()
		{
			throw new System.NotImplementedException();
		}
		public Function bind()
		{
			throw new System.NotImplementedException();
		}
	}

		public class FunctionConstructor
	{
		protected FunctionConstructor()
		{
			
		}
		public string[] args;
		public readonly prototype;
		public Function new(params string[] args)
		{
			throw new System.NotImplementedException();
		}
	}

		public class IArguments
	{
		protected IArguments()
		{
			
		}
		public float index;
		public float length;
		public Function callee;
	}

		public class String
	{
		protected String()
		{
			
		}
		public readonly length;
		public float index;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public string charAt(float pos)
		{
			throw new System.NotImplementedException();
		}
		public float charCodeAt(float index)
		{
			throw new System.NotImplementedException();
		}
		public string concat(params string[] strings)
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(string searchString, float position = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(string searchString, float position = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float localeCompare(string that)
		{
			throw new System.NotImplementedException();
		}
		public Any<RegExpMatchArray, null> match(string regexp)
		{
			throw new System.NotImplementedException();
		}
		public Any<RegExpMatchArray, null> match(RegExp regexp)
		{
			throw new System.NotImplementedException();
		}
		public string replace(string searchValue, string replaceValue)
		{
			throw new System.NotImplementedException();
		}
		public string replace(string searchValue, Func<string, object[], object> replacer)
		{
			throw new System.NotImplementedException();
		}
		public string replace(RegExp searchValue, string replaceValue)
		{
			throw new System.NotImplementedException();
		}
		public string replace(RegExp searchValue, Func<string, object[], object> replacer)
		{
			throw new System.NotImplementedException();
		}
		public float search(string regexp)
		{
			throw new System.NotImplementedException();
		}
		public float search(RegExp regexp)
		{
			throw new System.NotImplementedException();
		}
		public string slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string[] split(string separator, float limit = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string[] split(RegExp separator, float limit = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string substring(float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLowerCase()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleLowerCase()
		{
			throw new System.NotImplementedException();
		}
		public string toUpperCase()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleUpperCase()
		{
			throw new System.NotImplementedException();
		}
		public string trim()
		{
			throw new System.NotImplementedException();
		}
		public string substr(float from, float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string valueOf()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StringConstructor
	{
		protected StringConstructor()
		{
			
		}
		public object value;
		public readonly prototype;
		public String new(object value = default(object))
		{
			throw new System.NotImplementedException();
		}
		public string fromCharCode(params float[] codes)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Boolean
	{
		protected Boolean()
		{
			
		}
		public bool valueOf()
		{
			throw new System.NotImplementedException();
		}
	}

		public class BooleanConstructor
	{
		protected BooleanConstructor()
		{
			
		}
		public object value;
		public readonly prototype;
		public Boolean new(object value = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Number
	{
		protected Number()
		{
			
		}
		public string toString(float radix = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toFixed(float fractionDigits = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toExponential(float fractionDigits = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toPrecision(float precision = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float valueOf()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NumberConstructor
	{
		protected NumberConstructor()
		{
			
		}
		public object value;
		public readonly prototype;
		public readonly MAX_VALUE;
		public readonly MIN_VALUE;
		public readonly NaN;
		public readonly NEGATIVE_INFINITY;
		public readonly POSITIVE_INFINITY;
		public Number new(object value = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class TemplateStringsArray : ReadonlyArray<string>
	{
		protected TemplateStringsArray() : base()
		{
			
		}
		public readonly raw;
	}

		public class Math
	{
		protected Math()
		{
			
		}
		public readonly E;
		public readonly LN10;
		public readonly LN2;
		public readonly LOG2E;
		public readonly LOG10E;
		public readonly PI;
		public readonly SQRT1_2;
		public readonly SQRT2;
		public float abs(float x)
		{
			throw new System.NotImplementedException();
		}
		public float acos(float x)
		{
			throw new System.NotImplementedException();
		}
		public float asin(float x)
		{
			throw new System.NotImplementedException();
		}
		public float atan(float x)
		{
			throw new System.NotImplementedException();
		}
		public float atan2(float y, float x)
		{
			throw new System.NotImplementedException();
		}
		public float ceil(float x)
		{
			throw new System.NotImplementedException();
		}
		public float cos(float x)
		{
			throw new System.NotImplementedException();
		}
		public float exp(float x)
		{
			throw new System.NotImplementedException();
		}
		public float floor(float x)
		{
			throw new System.NotImplementedException();
		}
		public float log(float x)
		{
			throw new System.NotImplementedException();
		}
		public float max(params float[] values)
		{
			throw new System.NotImplementedException();
		}
		public float min(params float[] values)
		{
			throw new System.NotImplementedException();
		}
		public float pow(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float random()
		{
			throw new System.NotImplementedException();
		}
		public float round(float x)
		{
			throw new System.NotImplementedException();
		}
		public float sin(float x)
		{
			throw new System.NotImplementedException();
		}
		public float sqrt(float x)
		{
			throw new System.NotImplementedException();
		}
		public float tan(float x)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Date
	{
		protected Date()
		{
			
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public string toDateString()
		{
			throw new System.NotImplementedException();
		}
		public string toTimeString()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleDateString()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleTimeString()
		{
			throw new System.NotImplementedException();
		}
		public float valueOf()
		{
			throw new System.NotImplementedException();
		}
		public float getTime()
		{
			throw new System.NotImplementedException();
		}
		public float getFullYear()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCFullYear()
		{
			throw new System.NotImplementedException();
		}
		public float getMonth()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCMonth()
		{
			throw new System.NotImplementedException();
		}
		public float getDate()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCDate()
		{
			throw new System.NotImplementedException();
		}
		public float getDay()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCDay()
		{
			throw new System.NotImplementedException();
		}
		public float getHours()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCHours()
		{
			throw new System.NotImplementedException();
		}
		public float getMinutes()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCMinutes()
		{
			throw new System.NotImplementedException();
		}
		public float getSeconds()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCSeconds()
		{
			throw new System.NotImplementedException();
		}
		public float getMilliseconds()
		{
			throw new System.NotImplementedException();
		}
		public float getUTCMilliseconds()
		{
			throw new System.NotImplementedException();
		}
		public float getTimezoneOffset()
		{
			throw new System.NotImplementedException();
		}
		public float setTime(float time)
		{
			throw new System.NotImplementedException();
		}
		public float setMilliseconds(float ms)
		{
			throw new System.NotImplementedException();
		}
		public float setUTCMilliseconds(float ms)
		{
			throw new System.NotImplementedException();
		}
		public float setSeconds(float sec, float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setUTCSeconds(float sec, float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setMinutes(float min, float sec = default(float), float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setUTCMinutes(float min, float sec = default(float), float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setHours(float hours, float min = default(float), float sec = default(float), float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setUTCHours(float hours, float min = default(float), float sec = default(float), float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setDate(float date)
		{
			throw new System.NotImplementedException();
		}
		public float setUTCDate(float date)
		{
			throw new System.NotImplementedException();
		}
		public float setMonth(float month, float date = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setUTCMonth(float month, float date = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setFullYear(float year, float month = default(float), float date = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float setUTCFullYear(float year, float month = default(float), float date = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toUTCString()
		{
			throw new System.NotImplementedException();
		}
		public string toISOString()
		{
			throw new System.NotImplementedException();
		}
		public string toJSON(object key = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DateConstructor
	{
		protected DateConstructor()
		{
			
		}
		public readonly prototype;
		public Date new()
		{
			throw new System.NotImplementedException();
		}
		public Date new(float value)
		{
			throw new System.NotImplementedException();
		}
		public Date new(string value)
		{
			throw new System.NotImplementedException();
		}
		public Date new(float year, float month, float date = default(float), float hours = default(float), float minutes = default(float), float seconds = default(float), float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float parse(string s)
		{
			throw new System.NotImplementedException();
		}
		public float UTC(float year, float month, float date = default(float), float hours = default(float), float minutes = default(float), float seconds = default(float), float ms = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float now()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RegExpMatchArray : string[]
	{
		protected RegExpMatchArray() : base()
		{
			
		}
		public float index;
		public string input;
	}

		public class RegExpExecArray : string[]
	{
		protected RegExpExecArray() : base()
		{
			
		}
		public float index;
		public string input;
	}

		public class RegExp
	{
		protected RegExp()
		{
			
		}
		public readonly source;
		public readonly global;
		public readonly ignoreCase;
		public readonly multiline;
		public float lastIndex;
		public Any<RegExpExecArray, null> exec(string @string)
		{
			throw new System.NotImplementedException();
		}
		public bool test(string @string)
		{
			throw new System.NotImplementedException();
		}
		public object compile()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RegExpConstructor
	{
		protected RegExpConstructor()
		{
			
		}
		public string pattern;
		public string flags;
		public readonly prototype;
		public string $1;
		public string $2;
		public string $3;
		public string $4;
		public string $5;
		public string $6;
		public string $7;
		public string $8;
		public string $9;
		public string lastMatch;
		public RegExp new(RegExp pattern)
		{
			throw new System.NotImplementedException();
		}
		public RegExp new(string pattern, string flags = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Error
	{
		protected Error()
		{
			
		}
		public string name;
		public string message;
		public string stack;
	}

		public class ErrorConstructor
	{
		protected ErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public Error new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class EvalError : Error
	{
		protected EvalError() : base()
		{
			
		}
	}

		public class EvalErrorConstructor
	{
		protected EvalErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public EvalError new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RangeError : Error
	{
		protected RangeError() : base()
		{
			
		}
	}

		public class RangeErrorConstructor
	{
		protected RangeErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public RangeError new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ReferenceError : Error
	{
		protected ReferenceError() : base()
		{
			
		}
	}

		public class ReferenceErrorConstructor
	{
		protected ReferenceErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public ReferenceError new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SyntaxError : Error
	{
		protected SyntaxError() : base()
		{
			
		}
	}

		public class SyntaxErrorConstructor
	{
		protected SyntaxErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public SyntaxError new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class TypeError : Error
	{
		protected TypeError() : base()
		{
			
		}
	}

		public class TypeErrorConstructor
	{
		protected TypeErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public TypeError new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class URIError : Error
	{
		protected URIError() : base()
		{
			
		}
	}

		public class URIErrorConstructor
	{
		protected URIErrorConstructor()
		{
			
		}
		public string message;
		public readonly prototype;
		public URIError new(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class JSON
	{
		protected JSON()
		{
			
		}
		public Any<string, float> space;
		public object parse(string text, Func<object, object, object> reviver = default(Func<object, object, object>))
		{
			throw new System.NotImplementedException();
		}
		public string stringify(object value, Func<string, object, object> replacer = default(Func<string, object, object>), Any<string, float> space = default(Any<string, float>))
		{
			throw new System.NotImplementedException();
		}
		public object stringify(object value, Func<object, string> replacer = default(Func<object, string>))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ReadonlyArray<T>
	{
		protected ReadonlyArray()
		{
			
		}
		public readonly length;
		public float n;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public T[] concat<U>(params U[] items) where U : ReadonlyArray<T>
		{
			throw new System.NotImplementedException();
		}
		public T[] concat(params T[][] items)
		{
			throw new System.NotImplementedException();
		}
		public object concat(params Func<object, T[]> items)
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public T[] slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(T searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(T searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<T, float, ReadonlyArray<T>, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<T, float, ReadonlyArray<T>, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<T, float, ReadonlyArray<T>> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public U[] map<U>(Func<T, float, ReadonlyArray<T>, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public T[] filter(Func<T, float, ReadonlyArray<T>, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public T reduce(Func<T, T, float, ReadonlyArray<T>, object> callbackfn, T initialValue = default(T))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, T, float, ReadonlyArray<T>, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public T reduceRight(Func<T, T, float, ReadonlyArray<T>, object> callbackfn, T initialValue = default(T))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, T, float, ReadonlyArray<T>, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Array<T>
	{
		protected Array()
		{
			
		}
		public float length;
		public float n;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public float push(params T[] items)
		{
			throw new System.NotImplementedException();
		}
		public Any<T, undefined> pop()
		{
			throw new System.NotImplementedException();
		}
		public T[] concat(params T[][] items)
		{
			throw new System.NotImplementedException();
		}
		public object concat(params Func<object, T[]> items)
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public T[] reverse()
		{
			throw new System.NotImplementedException();
		}
		public Any<T, undefined> shift()
		{
			throw new System.NotImplementedException();
		}
		public T[] slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<T, T, object> compareFn = default(Func<T, T, object>))
		{
			throw new System.NotImplementedException();
		}
		public T[] splice(float start)
		{
			throw new System.NotImplementedException();
		}
		public T[] splice(float start, float deleteCount, params T[] items)
		{
			throw new System.NotImplementedException();
		}
		public float unshift(params T[] items)
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(T searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(T searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<T, float, T[], object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<T, float, T[], object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<T, float, T[]> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public U[] map<U>(Func<T, float, T[], object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public T[] filter(Func<T, float, T[], object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public T reduce(Func<T, T, float, T[], object> callbackfn, T initialValue = default(T))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, T, float, T[], object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public T reduceRight(Func<T, T, float, T[], object> callbackfn, T initialValue = default(T))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, T, float, T[], object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ArrayConstructor
	{
		protected ArrayConstructor()
		{
			
		}
		public float arrayLength;
		public T[] items;
		public readonly prototype;
		public object[] new(float arrayLength = default(float))
		{
			throw new System.NotImplementedException();
		}
		public T[] new<T>(params T[] items)
		{
			throw new System.NotImplementedException();
		}
		public arg isArray(object arg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TypedPropertyDescriptor<T>
	{
		protected TypedPropertyDescriptor()
		{
			
		}
		public bool enumerable;
		public bool configurable;
		public bool writable;
		public T value;
		public Func<, object> get;
		public Action<T> set;
	}

		public class PromiseLike<T>
	{
		protected PromiseLike()
		{
			
		}
		public Action<object> onrejected;
		public PromiseLike<TResult> then<TResult>(Func<T, object> onfulfilled = default(Func<T, object>))
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<TResult> then<TResult>(Func<T, object> onfulfilled = default(Func<T, object>))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ArrayLike<T>
	{
		protected ArrayLike()
		{
			
		}
		public readonly length;
		public float n;
	}

		public class ArrayBuffer
	{
		protected ArrayBuffer()
		{
			
		}
		public readonly byteLength;
		public Bridge.Html5.ArrayBuffer slice(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ArrayBufferConstructor
	{
		protected ArrayBufferConstructor()
		{
			
		}
		public readonly prototype;
		public object ArrayBufferView;
		public Bridge.Html5.ArrayBuffer new(float byteLength)
		{
			throw new System.NotImplementedException();
		}
		public arg isView(object arg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ArrayBufferView
	{
		protected ArrayBufferView()
		{
			
		}
		public Bridge.Html5.ArrayBuffer buffer;
		public float byteLength;
		public float byteOffset;
	}

		public class DataView
	{
		protected DataView()
		{
			
		}
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public float getFloat32(float byteOffset, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float getFloat64(float byteOffset, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float getInt8(float byteOffset)
		{
			throw new System.NotImplementedException();
		}
		public float getInt16(float byteOffset, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float getInt32(float byteOffset, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float getUint8(float byteOffset)
		{
			throw new System.NotImplementedException();
		}
		public float getUint16(float byteOffset, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float getUint32(float byteOffset, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void setFloat32(float byteOffset, float value, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void setFloat64(float byteOffset, float value, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void setInt8(float byteOffset, float value)
		{
			throw new System.NotImplementedException();
		}
		public void setInt16(float byteOffset, float value, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void setInt32(float byteOffset, float value, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void setUint8(float byteOffset, float value)
		{
			throw new System.NotImplementedException();
		}
		public void setUint16(float byteOffset, float value, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void setUint32(float byteOffset, float value, bool littleEndian = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataViewConstructor
	{
		protected DataViewConstructor()
		{
			
		}
		public Bridge.Html5.DataView new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float byteLength = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Int8Array
	{
		protected Int8Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Int8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array filter(Func<float, float, Bridge.Html5.Int8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Int8Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array map(Func<float, float, Bridge.Html5.Int8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Int8Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Int8Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Int8Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Int8Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Int8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Int8ArrayConstructor
	{
		protected Int8ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Int8Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int8Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint8Array
	{
		protected Uint8Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Uint8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array filter(Func<float, float, Bridge.Html5.Uint8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Uint8Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array map(Func<float, float, Bridge.Html5.Uint8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Uint8Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Uint8Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Uint8Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Uint8Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Uint8Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint8ArrayConstructor
	{
		protected Uint8ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Uint8Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint8ClampedArray
	{
		protected Uint8ClampedArray()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray filter(Func<float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Uint8ClampedArray> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray map(Func<float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(Bridge.Html5.Uint8ClampedArray array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Uint8ClampedArray, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint8ClampedArrayConstructor
	{
		protected Uint8ClampedArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Uint8ClampedArray new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint8ClampedArray from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Int16Array
	{
		protected Int16Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Int16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array filter(Func<float, float, Bridge.Html5.Int16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Int16Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array map(Func<float, float, Bridge.Html5.Int16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Int16Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Int16Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Int16Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Int16Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Int16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Int16ArrayConstructor
	{
		protected Int16ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Int16Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int16Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint16Array
	{
		protected Uint16Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Uint16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array filter(Func<float, float, Bridge.Html5.Uint16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Uint16Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array map(Func<float, float, Bridge.Html5.Uint16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Uint16Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Uint16Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Uint16Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Uint16Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Uint16Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint16ArrayConstructor
	{
		protected Uint16ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Uint16Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint16Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Int32Array
	{
		protected Int32Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Int32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array filter(Func<float, float, Bridge.Html5.Int32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Int32Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array map(Func<float, float, Bridge.Html5.Int32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Int32Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Int32Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Int32Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Int32Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Int32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Int32ArrayConstructor
	{
		protected Int32ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Int32Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Int32Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint32Array
	{
		protected Uint32Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Uint32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array filter(Func<float, float, Bridge.Html5.Uint32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Uint32Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array map(Func<float, float, Bridge.Html5.Uint32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Uint32Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Uint32Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Uint32Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Uint32Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Uint32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Uint32ArrayConstructor
	{
		protected Uint32ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Uint32Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Uint32Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Float32Array
	{
		protected Float32Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Float32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array filter(Func<float, float, Bridge.Html5.Float32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Float32Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array map(Func<float, float, Bridge.Html5.Float32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Float32Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Float32Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Float32Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Float32Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Float32Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Float32ArrayConstructor
	{
		protected Float32ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Float32Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Float64Array
	{
		protected Float64Array()
		{
			
		}
		public readonly BYTES_PER_ELEMENT;
		public readonly buffer;
		public readonly byteLength;
		public readonly byteOffset;
		public readonly length;
		public float index;
		public object copyWithin(float target, float start, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool every(Func<float, float, Bridge.Html5.Float64Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object fill(float value, float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array filter(Func<float, float, Bridge.Html5.Float64Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public Any<float, undefined> find(Func<float, float, float[], object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float findIndex(Func<float, object> predicate, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forEach(Action<float, float, Bridge.Html5.Float64Array> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float indexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string join(string separator = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float lastIndexOf(float searchElement, float fromIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array map(Func<float, float, Bridge.Html5.Float64Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public float reduce(Func<float, float, float, Bridge.Html5.Float64Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduce<U>(Func<U, float, float, Bridge.Html5.Float64Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public float reduceRight(Func<float, float, float, Bridge.Html5.Float64Array, object> callbackfn, float initialValue = default(float))
		{
			throw new System.NotImplementedException();
		}
		public U reduceRight<U>(Func<U, float, float, Bridge.Html5.Float64Array, object> callbackfn, U initialValue)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array reverse()
		{
			throw new System.NotImplementedException();
		}
		public void set(float index, float value)
		{
			throw new System.NotImplementedException();
		}
		public void set(ArrayLike<float> array, float offset = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array slice(float start = default(float), float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public bool some(Func<float, float, Bridge.Html5.Float64Array, object> callbackfn, object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object sort(Func<float, float, object> compareFn = default(Func<float, float, object>))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array subarray(float begin, float end = default(float))
		{
			throw new System.NotImplementedException();
		}
		public string toLocaleString()
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Float64ArrayConstructor
	{
		protected Float64ArrayConstructor()
		{
			
		}
		public readonly prototype;
		public readonly BYTES_PER_ELEMENT;
		public Bridge.Html5.Float64Array new(float length)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array new(ArrayLike<float> array)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array new(Bridge.Html5.ArrayBuffer buffer, float byteOffset = default(float), float length = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array of(params float[] items)
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float64Array from(ArrayLike<float> arrayLike, Func<float, float, object> mapfn = default(Func<float, float, object>), object thisArg = default(object))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Intl
	{
		protected Intl()
		{
			
		}
		public Collator_0_ Collator;
		public NumberFormat_0_ NumberFormat;
		public DateTimeFormat_0_ DateTimeFormat;

				public class CollatorOptions
		{
			protected CollatorOptions()
			{
				
			}
			public string usage;
			public string localeMatcher;
			public bool numeric;
			public string caseFirst;
			public string sensitivity;
			public bool ignorePunctuation;
		}

				public class ResolvedCollatorOptions
		{
			protected ResolvedCollatorOptions()
			{
				
			}
			public string locale;
			public string usage;
			public string sensitivity;
			public bool ignorePunctuation;
			public string collation;
			public string caseFirst;
			public bool numeric;
		}

				public class Collator
		{
			protected Collator()
			{
				
			}
			public float compare(string x, string y)
			{
				throw new System.NotImplementedException();
			}
			public ResolvedCollatorOptions resolvedOptions()
			{
				throw new System.NotImplementedException();
			}
		}

				public class Collator_0_
		{
			public string[] locales;
			public CollatorOptions options;
			public string locale;
			public Collator new(string[] locales = default(string[]), CollatorOptions options = default(CollatorOptions))
			{
				throw new System.NotImplementedException();
			}
			public Collator new(string locale = default(string), CollatorOptions options = default(CollatorOptions))
			{
				throw new System.NotImplementedException();
			}
			public string[] supportedLocalesOf(string[] locales, CollatorOptions options = default(CollatorOptions))
			{
				throw new System.NotImplementedException();
			}
			public string[] supportedLocalesOf(string locale, CollatorOptions options = default(CollatorOptions))
			{
				throw new System.NotImplementedException();
			}
		}

				public class NumberFormatOptions
		{
			protected NumberFormatOptions()
			{
				
			}
			public string localeMatcher;
			public string style;
			public string currency;
			public string currencyDisplay;
			public bool useGrouping;
			public float minimumIntegerDigits;
			public float minimumFractionDigits;
			public float maximumFractionDigits;
			public float minimumSignificantDigits;
			public float maximumSignificantDigits;
		}

				public class ResolvedNumberFormatOptions
		{
			protected ResolvedNumberFormatOptions()
			{
				
			}
			public string locale;
			public string numberingSystem;
			public string style;
			public string currency;
			public string currencyDisplay;
			public float minimumIntegerDigits;
			public float minimumFractionDigits;
			public float maximumFractionDigits;
			public float minimumSignificantDigits;
			public float maximumSignificantDigits;
			public bool useGrouping;
		}

				public class NumberFormat
		{
			protected NumberFormat()
			{
				
			}
			public string format(float value)
			{
				throw new System.NotImplementedException();
			}
			public ResolvedNumberFormatOptions resolvedOptions()
			{
				throw new System.NotImplementedException();
			}
		}

				public class NumberFormat_0_
		{
			public string[] locales;
			public NumberFormatOptions options;
			public string locale;
			public NumberFormat new(string[] locales = default(string[]), NumberFormatOptions options = default(NumberFormatOptions))
			{
				throw new System.NotImplementedException();
			}
			public NumberFormat new(string locale = default(string), NumberFormatOptions options = default(NumberFormatOptions))
			{
				throw new System.NotImplementedException();
			}
			public string[] supportedLocalesOf(string[] locales, NumberFormatOptions options = default(NumberFormatOptions))
			{
				throw new System.NotImplementedException();
			}
			public string[] supportedLocalesOf(string locale, NumberFormatOptions options = default(NumberFormatOptions))
			{
				throw new System.NotImplementedException();
			}
		}

				public class DateTimeFormatOptions
		{
			protected DateTimeFormatOptions()
			{
				
			}
			public string localeMatcher;
			public string weekday;
			public string era;
			public string year;
			public string month;
			public string day;
			public string hour;
			public string minute;
			public string second;
			public string timeZoneName;
			public string formatMatcher;
			public bool hour12;
			public string timeZone;
		}

				public class ResolvedDateTimeFormatOptions
		{
			protected ResolvedDateTimeFormatOptions()
			{
				
			}
			public string locale;
			public string calendar;
			public string numberingSystem;
			public string timeZone;
			public bool hour12;
			public string weekday;
			public string era;
			public string year;
			public string month;
			public string day;
			public string hour;
			public string minute;
			public string second;
			public string timeZoneName;
		}

				public class DateTimeFormat
		{
			protected DateTimeFormat()
			{
				
			}
			public string format(Any<Date, float> date = default(Any<Date, float>))
			{
				throw new System.NotImplementedException();
			}
			public ResolvedDateTimeFormatOptions resolvedOptions()
			{
				throw new System.NotImplementedException();
			}
		}

				public class DateTimeFormat_0_
		{
			public string[] locales;
			public DateTimeFormatOptions options;
			public string locale;
			public DateTimeFormat new(string[] locales = default(string[]), DateTimeFormatOptions options = default(DateTimeFormatOptions))
			{
				throw new System.NotImplementedException();
			}
			public DateTimeFormat new(string locale = default(string), DateTimeFormatOptions options = default(DateTimeFormatOptions))
			{
				throw new System.NotImplementedException();
			}
			public string[] supportedLocalesOf(string[] locales, DateTimeFormatOptions options = default(DateTimeFormatOptions))
			{
				throw new System.NotImplementedException();
			}
			public string[] supportedLocalesOf(string locale, DateTimeFormatOptions options = default(DateTimeFormatOptions))
			{
				throw new System.NotImplementedException();
			}
		}
	}

		public class Algorithm
	{
		protected Algorithm()
		{
			
		}
		public string name;
	}

		public class AriaRequestEventInit : EventInit
	{
		protected AriaRequestEventInit() : base()
		{
			
		}
		public string attributeName;
		public string attributeValue;
	}

		public class CommandEventInit : EventInit
	{
		protected CommandEventInit() : base()
		{
			
		}
		public string commandName;
		public string detail;
	}

		public class CompositionEventInit : UIEventInit
	{
		protected CompositionEventInit() : base()
		{
			
		}
		public string data;
	}

		public class ConfirmSiteSpecificExceptionsInformation : ExceptionInformation
	{
		protected ConfirmSiteSpecificExceptionsInformation() : base()
		{
			
		}
		public string[] arrayOfDomainStrings;
	}

		public class ConstrainBooleanParameters
	{
		protected ConstrainBooleanParameters()
		{
			
		}
		public bool exact;
		public bool ideal;
	}

		public class ConstrainDOMStringParameters
	{
		protected ConstrainDOMStringParameters()
		{
			
		}
		public Any<string, string[]> exact;
		public Any<string, string[]> ideal;
	}

		public class ConstrainDoubleRange : DoubleRange
	{
		protected ConstrainDoubleRange() : base()
		{
			
		}
		public float exact;
		public float ideal;
	}

		public class ConstrainLongRange : LongRange
	{
		protected ConstrainLongRange() : base()
		{
			
		}
		public float exact;
		public float ideal;
	}

		public class ConstrainVideoFacingModeParameters
	{
		protected ConstrainVideoFacingModeParameters()
		{
			
		}
		public Any<string, string[]> exact;
		public Any<string, string[]> ideal;
	}

		public class CustomEventInit : EventInit
	{
		protected CustomEventInit() : base()
		{
			
		}
		public object detail;
	}

		public class DeviceAccelerationDict
	{
		protected DeviceAccelerationDict()
		{
			
		}
		public float x;
		public float y;
		public float z;
	}

		public class DeviceLightEventInit : EventInit
	{
		protected DeviceLightEventInit() : base()
		{
			
		}
		public float value;
	}

		public class DeviceRotationRateDict
	{
		protected DeviceRotationRateDict()
		{
			
		}
		public float alpha;
		public float beta;
		public float gamma;
	}

		public class DoubleRange
	{
		protected DoubleRange()
		{
			
		}
		public float max;
		public float min;
	}

		public class EventInit
	{
		protected EventInit()
		{
			
		}
		public bool bubbles;
		public bool cancelable;
	}

		public class EventModifierInit : UIEventInit
	{
		protected EventModifierInit() : base()
		{
			
		}
		public bool ctrlKey;
		public bool shiftKey;
		public bool altKey;
		public bool metaKey;
		public bool modifierAltGraph;
		public bool modifierCapsLock;
		public bool modifierFn;
		public bool modifierFnLock;
		public bool modifierHyper;
		public bool modifierNumLock;
		public bool modifierOS;
		public bool modifierScrollLock;
		public bool modifierSuper;
		public bool modifierSymbol;
		public bool modifierSymbolLock;
	}

		public class ExceptionInformation
	{
		protected ExceptionInformation()
		{
			
		}
		public string domain;
	}

		public class FocusEventInit : UIEventInit
	{
		protected FocusEventInit() : base()
		{
			
		}
		public EventTarget relatedTarget;
	}

		public class HashChangeEventInit : EventInit
	{
		protected HashChangeEventInit() : base()
		{
			
		}
		public string newURL;
		public string oldURL;
	}

		public class IDBIndexParameters
	{
		protected IDBIndexParameters()
		{
			
		}
		public bool multiEntry;
		public bool unique;
	}

		public class IDBObjectStoreParameters
	{
		protected IDBObjectStoreParameters()
		{
			
		}
		public bool autoIncrement;
		public IDBKeyPath keyPath;
	}

		public class KeyAlgorithm
	{
		protected KeyAlgorithm()
		{
			
		}
		public string name;
	}

		public class KeyboardEventInit : EventModifierInit
	{
		protected KeyboardEventInit() : base()
		{
			
		}
		public string code;
		public string key;
		public float location;
		public bool repeat;
	}

		public class LongRange
	{
		protected LongRange()
		{
			
		}
		public float max;
		public float min;
	}

		public class MSAccountInfo
	{
		protected MSAccountInfo()
		{
			
		}
		public string rpDisplayName;
		public string userDisplayName;
		public string accountName;
		public string userId;
		public string accountImageUri;
	}

		public class MSAudioLocalClientEvent : MSLocalClientEventBase
	{
		protected MSAudioLocalClientEvent() : base()
		{
			
		}
		public float networkSendQualityEventRatio;
		public float networkDelayEventRatio;
		public float cpuInsufficientEventRatio;
		public float deviceHalfDuplexAECEventRatio;
		public float deviceRenderNotFunctioningEventRatio;
		public float deviceCaptureNotFunctioningEventRatio;
		public float deviceGlitchesEventRatio;
		public float deviceLowSNREventRatio;
		public float deviceLowSpeechLevelEventRatio;
		public float deviceClippingEventRatio;
		public float deviceEchoEventRatio;
		public float deviceNearEndToEchoRatioEventRatio;
		public float deviceRenderZeroVolumeEventRatio;
		public float deviceRenderMuteEventRatio;
		public float deviceMultipleEndpointsEventCount;
		public float deviceHowlingEventCount;
	}

		public class MSAudioRecvPayload : MSPayloadBase
	{
		protected MSAudioRecvPayload() : base()
		{
			
		}
		public float samplingRate;
		public MSAudioRecvSignal signal;
		public float packetReorderRatio;
		public float packetReorderDepthAvg;
		public float packetReorderDepthMax;
		public float burstLossLength1;
		public float burstLossLength2;
		public float burstLossLength3;
		public float burstLossLength4;
		public float burstLossLength5;
		public float burstLossLength6;
		public float burstLossLength7;
		public float burstLossLength8OrHigher;
		public float fecRecvDistance1;
		public float fecRecvDistance2;
		public float fecRecvDistance3;
		public float ratioConcealedSamplesAvg;
		public float ratioStretchedSamplesAvg;
		public float ratioCompressedSamplesAvg;
	}

		public class MSAudioRecvSignal
	{
		protected MSAudioRecvSignal()
		{
			
		}
		public float initialSignalLevelRMS;
		public float recvSignalLevelCh1;
		public float recvNoiseLevelCh1;
		public float renderSignalLevel;
		public float renderNoiseLevel;
		public float renderLoopbackSignalLevel;
	}

		public class MSAudioSendPayload : MSPayloadBase
	{
		protected MSAudioSendPayload() : base()
		{
			
		}
		public float samplingRate;
		public MSAudioSendSignal signal;
		public bool audioFECUsed;
		public float sendMutePercent;
	}

		public class MSAudioSendSignal
	{
		protected MSAudioSendSignal()
		{
			
		}
		public float noiseLevel;
		public float sendSignalLevelCh1;
		public float sendNoiseLevelCh1;
	}

		public class MSConnectivity
	{
		protected MSConnectivity()
		{
			
		}
		public string iceType;
		public MSIceWarningFlags iceWarningFlags;
		public MSRelayAddress relayAddress;
	}

		public class MSCredentialFilter
	{
		protected MSCredentialFilter()
		{
			
		}
		public MSCredentialSpec[] accept;
	}

		public class MSCredentialParameters
	{
		protected MSCredentialParameters()
		{
			
		}
		public string type;
	}

		public class MSCredentialSpec
	{
		protected MSCredentialSpec()
		{
			
		}
		public string type;
		public string id;
	}

		public class MSDelay
	{
		protected MSDelay()
		{
			
		}
		public float roundTrip;
		public float roundTripMax;
	}

		public class MSDescription : RTCStats
	{
		protected MSDescription() : base()
		{
			
		}
		public MSConnectivity connectivity;
		public string transport;
		public MSNetworkConnectivityInfo networkconnectivity;
		public MSIPAddressInfo localAddr;
		public MSIPAddressInfo remoteAddr;
		public string deviceDevName;
		public MSIPAddressInfo reflexiveLocalIPAddr;
	}

		public class MSFIDOCredentialParameters : MSCredentialParameters
	{
		protected MSFIDOCredentialParameters() : base()
		{
			
		}
		public Any<string, Algorithm> algorithm;
		public AAGUID[] authenticators;
	}

		public class MSIPAddressInfo
	{
		protected MSIPAddressInfo()
		{
			
		}
		public string ipAddr;
		public float port;
		public string manufacturerMacAddrMask;
	}

		public class MSIceWarningFlags
	{
		protected MSIceWarningFlags()
		{
			
		}
		public bool turnTcpTimedOut;
		public bool turnUdpAllocateFailed;
		public bool turnUdpSendFailed;
		public bool turnTcpAllocateFailed;
		public bool turnTcpSendFailed;
		public bool udpLocalConnectivityFailed;
		public bool udpNatConnectivityFailed;
		public bool udpRelayConnectivityFailed;
		public bool tcpNatConnectivityFailed;
		public bool tcpRelayConnectivityFailed;
		public bool connCheckMessageIntegrityFailed;
		public bool allocationMessageIntegrityFailed;
		public bool connCheckOtherError;
		public bool turnAuthUnknownUsernameError;
		public bool noRelayServersConfigured;
		public bool multipleRelayServersAttempted;
		public bool portRangeExhausted;
		public bool alternateServerReceived;
		public bool pseudoTLSFailure;
		public bool turnTurnTcpConnectivityFailed;
		public bool useCandidateChecksFailed;
		public bool fipsAllocationFailure;
	}

		public class MSJitter
	{
		protected MSJitter()
		{
			
		}
		public float interArrival;
		public float interArrivalMax;
		public float interArrivalSD;
	}

		public class MSLocalClientEventBase : RTCStats
	{
		protected MSLocalClientEventBase() : base()
		{
			
		}
		public float networkReceiveQualityEventRatio;
		public float networkBandwidthLowEventRatio;
	}

		public class MSNetwork : RTCStats
	{
		protected MSNetwork() : base()
		{
			
		}
		public MSJitter jitter;
		public MSDelay delay;
		public MSPacketLoss packetLoss;
		public MSUtilization utilization;
	}

		public class MSNetworkConnectivityInfo
	{
		protected MSNetworkConnectivityInfo()
		{
			
		}
		public bool vpn;
		public float linkspeed;
		public string networkConnectionDetails;
	}

		public class MSNetworkInterfaceType
	{
		protected MSNetworkInterfaceType()
		{
			
		}
		public bool interfaceTypeEthernet;
		public bool interfaceTypeWireless;
		public bool interfaceTypePPP;
		public bool interfaceTypeTunnel;
		public bool interfaceTypeWWAN;
	}

		public class MSOutboundNetwork : MSNetwork
	{
		protected MSOutboundNetwork() : base()
		{
			
		}
		public float appliedBandwidthLimit;
	}

		public class MSPacketLoss
	{
		protected MSPacketLoss()
		{
			
		}
		public float lossRate;
		public float lossRateMax;
	}

		public class MSPayloadBase : RTCStats
	{
		protected MSPayloadBase() : base()
		{
			
		}
		public string payloadDescription;
	}

		public class MSRelayAddress
	{
		protected MSRelayAddress()
		{
			
		}
		public string relayAddress;
		public float port;
	}

		public class MSSignatureParameters
	{
		protected MSSignatureParameters()
		{
			
		}
		public string userPrompt;
	}

		public class MSTransportDiagnosticsStats : RTCStats
	{
		protected MSTransportDiagnosticsStats() : base()
		{
			
		}
		public string baseAddress;
		public string localAddress;
		public string localSite;
		public string networkName;
		public string remoteAddress;
		public string remoteSite;
		public string localMR;
		public string remoteMR;
		public MSIceWarningFlags iceWarningFlags;
		public float portRangeMin;
		public float portRangeMax;
		public float localMRTCPPort;
		public float remoteMRTCPPort;
		public float stunVer;
		public float numConsentReqSent;
		public float numConsentReqReceived;
		public float numConsentRespSent;
		public float numConsentRespReceived;
		public MSNetworkInterfaceType interfaces;
		public MSNetworkInterfaceType baseInterface;
		public string protocol;
		public MSNetworkInterfaceType localInterface;
		public string localAddrType;
		public string remoteAddrType;
		public string iceRole;
		public bool rtpRtcpMux;
		public float allocationTimeInMs;
		public string msRtcEngineVersion;
	}

		public class MSUtilization
	{
		protected MSUtilization()
		{
			
		}
		public float packets;
		public float bandwidthEstimation;
		public float bandwidthEstimationMin;
		public float bandwidthEstimationMax;
		public float bandwidthEstimationStdDev;
		public float bandwidthEstimationAvg;
	}

		public class MSVideoPayload : MSPayloadBase
	{
		protected MSVideoPayload() : base()
		{
			
		}
		public string resoluton;
		public float videoBitRateAvg;
		public float videoBitRateMax;
		public float videoFrameRateAvg;
		public float videoPacketLossRate;
		public float durationSeconds;
	}

		public class MSVideoRecvPayload : MSVideoPayload
	{
		protected MSVideoRecvPayload() : base()
		{
			
		}
		public float videoFrameLossRate;
		public string recvCodecType;
		public float recvResolutionWidth;
		public float recvResolutionHeight;
		public MSVideoResolutionDistribution videoResolutions;
		public float recvFrameRateAverage;
		public float recvBitRateMaximum;
		public float recvBitRateAverage;
		public float recvVideoStreamsMax;
		public float recvVideoStreamsMin;
		public float recvVideoStreamsMode;
		public float videoPostFECPLR;
		public float lowBitRateCallPercent;
		public float lowFrameRateCallPercent;
		public float reorderBufferTotalPackets;
		public float recvReorderBufferReorderedPackets;
		public float recvReorderBufferPacketsDroppedDueToBufferExhaustion;
		public float recvReorderBufferMaxSuccessfullyOrderedExtent;
		public float recvReorderBufferMaxSuccessfullyOrderedLateTime;
		public float recvReorderBufferPacketsDroppedDueToTimeout;
		public float recvFpsHarmonicAverage;
		public float recvNumResSwitches;
	}

		public class MSVideoResolutionDistribution
	{
		protected MSVideoResolutionDistribution()
		{
			
		}
		public float cifQuality;
		public float vgaQuality;
		public float h720Quality;
		public float h1080Quality;
		public float h1440Quality;
		public float h2160Quality;
	}

		public class MSVideoSendPayload : MSVideoPayload
	{
		protected MSVideoSendPayload() : base()
		{
			
		}
		public float sendFrameRateAverage;
		public float sendBitRateMaximum;
		public float sendBitRateAverage;
		public float sendVideoStreamsMax;
		public float sendResolutionWidth;
		public float sendResolutionHeight;
	}

		public class MediaEncryptedEventInit : EventInit
	{
		protected MediaEncryptedEventInit() : base()
		{
			
		}
		public string initDataType;
		public Bridge.Html5.ArrayBuffer initData;
	}

		public class MediaKeyMessageEventInit : EventInit
	{
		protected MediaKeyMessageEventInit() : base()
		{
			
		}
		public string messageType;
		public Bridge.Html5.ArrayBuffer message;
	}

		public class MediaKeySystemConfiguration
	{
		protected MediaKeySystemConfiguration()
		{
			
		}
		public string[] initDataTypes;
		public MediaKeySystemMediaCapability[] audioCapabilities;
		public MediaKeySystemMediaCapability[] videoCapabilities;
		public string distinctiveIdentifier;
		public string persistentState;
	}

		public class MediaKeySystemMediaCapability
	{
		protected MediaKeySystemMediaCapability()
		{
			
		}
		public string contentType;
		public string robustness;
	}

		public class MediaStreamConstraints
	{
		protected MediaStreamConstraints()
		{
			
		}
		public Any<bool, MediaTrackConstraints> video;
		public Any<bool, MediaTrackConstraints> audio;
	}

		public class MediaStreamErrorEventInit : EventInit
	{
		protected MediaStreamErrorEventInit() : base()
		{
			
		}
		public MediaStreamError error;
	}

		public class MediaStreamTrackEventInit : EventInit
	{
		protected MediaStreamTrackEventInit() : base()
		{
			
		}
		public MediaStreamTrack track;
	}

		public class MediaTrackCapabilities
	{
		protected MediaTrackCapabilities()
		{
			
		}
		public Any<float, LongRange> width;
		public Any<float, LongRange> height;
		public Any<float, DoubleRange> aspectRatio;
		public Any<float, DoubleRange> frameRate;
		public string facingMode;
		public Any<float, DoubleRange> volume;
		public Any<float, LongRange> sampleRate;
		public Any<float, LongRange> sampleSize;
		public bool[] echoCancellation;
		public string deviceId;
		public string groupId;
	}

		public class MediaTrackConstraintSet
	{
		protected MediaTrackConstraintSet()
		{
			
		}
		public Any<float, ConstrainLongRange> width;
		public Any<float, ConstrainLongRange> height;
		public Any<float, ConstrainDoubleRange> aspectRatio;
		public Any<float, ConstrainDoubleRange> frameRate;
		public Any<string, string[], ConstrainDOMStringParameters> facingMode;
		public Any<float, ConstrainDoubleRange> volume;
		public Any<float, ConstrainLongRange> sampleRate;
		public Any<float, ConstrainLongRange> sampleSize;
		public Any<bool, ConstrainBooleanParameters> echoCancelation;
		public Any<string, string[], ConstrainDOMStringParameters> deviceId;
		public Any<string, string[], ConstrainDOMStringParameters> groupId;
	}

		public class MediaTrackConstraints : MediaTrackConstraintSet
	{
		protected MediaTrackConstraints() : base()
		{
			
		}
		public MediaTrackConstraintSet[] advanced;
	}

		public class MediaTrackSettings
	{
		protected MediaTrackSettings()
		{
			
		}
		public float width;
		public float height;
		public float aspectRatio;
		public float frameRate;
		public string facingMode;
		public float volume;
		public float sampleRate;
		public float sampleSize;
		public bool echoCancellation;
		public string deviceId;
		public string groupId;
	}

		public class MediaTrackSupportedConstraints
	{
		protected MediaTrackSupportedConstraints()
		{
			
		}
		public bool width;
		public bool height;
		public bool aspectRatio;
		public bool frameRate;
		public bool facingMode;
		public bool volume;
		public bool sampleRate;
		public bool sampleSize;
		public bool echoCancellation;
		public bool deviceId;
		public bool groupId;
	}

		public class MouseEventInit : EventModifierInit
	{
		protected MouseEventInit() : base()
		{
			
		}
		public float screenX;
		public float screenY;
		public float clientX;
		public float clientY;
		public float button;
		public float buttons;
		public EventTarget relatedTarget;
	}

		public class MsZoomToOptions
	{
		protected MsZoomToOptions()
		{
			
		}
		public float contentX;
		public float contentY;
		public string viewportX;
		public string viewportY;
		public float scaleFactor;
		public string animate;
	}

		public class MutationObserverInit
	{
		protected MutationObserverInit()
		{
			
		}
		public bool childList;
		public bool attributes;
		public bool characterData;
		public bool subtree;
		public bool attributeOldValue;
		public bool characterDataOldValue;
		public string[] attributeFilter;
	}

		public class ObjectURLOptions
	{
		protected ObjectURLOptions()
		{
			
		}
		public bool oneTimeOnly;
	}

		public class PeriodicWaveConstraints
	{
		protected PeriodicWaveConstraints()
		{
			
		}
		public bool disableNormalization;
	}

		public class PointerEventInit : MouseEventInit
	{
		protected PointerEventInit() : base()
		{
			
		}
		public float pointerId;
		public float width;
		public float height;
		public float pressure;
		public float tiltX;
		public float tiltY;
		public string pointerType;
		public bool isPrimary;
	}

		public class PositionOptions
	{
		protected PositionOptions()
		{
			
		}
		public bool enableHighAccuracy;
		public float timeout;
		public float maximumAge;
	}

		public class RTCDTMFToneChangeEventInit : EventInit
	{
		protected RTCDTMFToneChangeEventInit() : base()
		{
			
		}
		public string tone;
	}

		public class RTCDtlsFingerprint
	{
		protected RTCDtlsFingerprint()
		{
			
		}
		public string algorithm;
		public string value;
	}

		public class RTCDtlsParameters
	{
		protected RTCDtlsParameters()
		{
			
		}
		public string role;
		public RTCDtlsFingerprint[] fingerprints;
	}

		public class RTCIceCandidate
	{
		protected RTCIceCandidate()
		{
			
		}
		public string foundation;
		public float priority;
		public string ip;
		public string protocol;
		public float port;
		public string type;
		public string tcpType;
		public string relatedAddress;
		public float relatedPort;
	}

		public class RTCIceCandidateAttributes : RTCStats
	{
		protected RTCIceCandidateAttributes() : base()
		{
			
		}
		public string ipAddress;
		public float portNumber;
		public string transport;
		public string candidateType;
		public float priority;
		public string addressSourceUrl;
	}

		public class RTCIceCandidateComplete
	{
		protected RTCIceCandidateComplete()
		{
			
		}
	}

		public class RTCIceCandidatePair
	{
		protected RTCIceCandidatePair()
		{
			
		}
		public RTCIceCandidate local;
		public RTCIceCandidate remote;
	}

		public class RTCIceCandidatePairStats : RTCStats
	{
		protected RTCIceCandidatePairStats() : base()
		{
			
		}
		public string transportId;
		public string localCandidateId;
		public string remoteCandidateId;
		public string state;
		public float priority;
		public bool nominated;
		public bool writable;
		public bool readable;
		public float bytesSent;
		public float bytesReceived;
		public float roundTripTime;
		public float availableOutgoingBitrate;
		public float availableIncomingBitrate;
	}

		public class RTCIceGatherOptions
	{
		protected RTCIceGatherOptions()
		{
			
		}
		public string gatherPolicy;
		public RTCIceServer[] iceservers;
	}

		public class RTCIceParameters
	{
		protected RTCIceParameters()
		{
			
		}
		public string usernameFragment;
		public string password;
	}

		public class RTCIceServer
	{
		protected RTCIceServer()
		{
			
		}
		public object urls;
		public string username;
		public string credential;
	}

		public class RTCInboundRTPStreamStats : RTCRTPStreamStats
	{
		protected RTCInboundRTPStreamStats() : base()
		{
			
		}
		public float packetsReceived;
		public float bytesReceived;
		public float packetsLost;
		public float jitter;
		public float fractionLost;
	}

		public class RTCMediaStreamTrackStats : RTCStats
	{
		protected RTCMediaStreamTrackStats() : base()
		{
			
		}
		public string trackIdentifier;
		public bool remoteSource;
		public string[] ssrcIds;
		public float frameWidth;
		public float frameHeight;
		public float framesPerSecond;
		public float framesSent;
		public float framesReceived;
		public float framesDecoded;
		public float framesDropped;
		public float framesCorrupted;
		public float audioLevel;
		public float echoReturnLoss;
		public float echoReturnLossEnhancement;
	}

		public class RTCOutboundRTPStreamStats : RTCRTPStreamStats
	{
		protected RTCOutboundRTPStreamStats() : base()
		{
			
		}
		public float packetsSent;
		public float bytesSent;
		public float targetBitrate;
		public float roundTripTime;
	}

		public class RTCRTPStreamStats : RTCStats
	{
		protected RTCRTPStreamStats() : base()
		{
			
		}
		public string ssrc;
		public string associateStatsId;
		public bool isRemote;
		public string mediaTrackId;
		public string transportId;
		public string codecId;
		public float firCount;
		public float pliCount;
		public float nackCount;
		public float sliCount;
	}

		public class RTCRtcpFeedback
	{
		protected RTCRtcpFeedback()
		{
			
		}
		public string type;
		public string parameter;
	}

		public class RTCRtcpParameters
	{
		protected RTCRtcpParameters()
		{
			
		}
		public float ssrc;
		public string cname;
		public bool reducedSize;
		public bool mux;
	}

		public class RTCRtpCapabilities
	{
		protected RTCRtpCapabilities()
		{
			
		}
		public RTCRtpCodecCapability[] codecs;
		public RTCRtpHeaderExtension[] headerExtensions;
		public string[] fecMechanisms;
	}

		public class RTCRtpCodecCapability
	{
		protected RTCRtpCodecCapability()
		{
			
		}
		public string name;
		public string kind;
		public float clockRate;
		public float preferredPayloadType;
		public float maxptime;
		public float numChannels;
		public RTCRtcpFeedback[] rtcpFeedback;
		public object parameters;
		public object options;
		public float maxTemporalLayers;
		public float maxSpatialLayers;
		public bool svcMultiStreamSupport;
	}

		public class RTCRtpCodecParameters
	{
		protected RTCRtpCodecParameters()
		{
			
		}
		public string name;
		public object payloadType;
		public float clockRate;
		public float maxptime;
		public float numChannels;
		public RTCRtcpFeedback[] rtcpFeedback;
		public object parameters;
	}

		public class RTCRtpContributingSource
	{
		protected RTCRtpContributingSource()
		{
			
		}
		public float timestamp;
		public float csrc;
		public float audioLevel;
	}

		public class RTCRtpEncodingParameters
	{
		protected RTCRtpEncodingParameters()
		{
			
		}
		public float ssrc;
		public float codecPayloadType;
		public RTCRtpFecParameters fec;
		public RTCRtpRtxParameters rtx;
		public float priority;
		public float maxBitrate;
		public float minQuality;
		public float framerateBias;
		public float resolutionScale;
		public float framerateScale;
		public bool active;
		public string encodingId;
		public string[] dependencyEncodingIds;
		public RTCSsrcRange ssrcRange;
	}

		public class RTCRtpFecParameters
	{
		protected RTCRtpFecParameters()
		{
			
		}
		public float ssrc;
		public string mechanism;
	}

		public class RTCRtpHeaderExtension
	{
		protected RTCRtpHeaderExtension()
		{
			
		}
		public string kind;
		public string uri;
		public float preferredId;
		public bool preferredEncrypt;
	}

		public class RTCRtpHeaderExtensionParameters
	{
		protected RTCRtpHeaderExtensionParameters()
		{
			
		}
		public string uri;
		public float id;
		public bool encrypt;
	}

		public class RTCRtpParameters
	{
		protected RTCRtpParameters()
		{
			
		}
		public string muxId;
		public RTCRtpCodecParameters[] codecs;
		public RTCRtpHeaderExtensionParameters[] headerExtensions;
		public RTCRtpEncodingParameters[] encodings;
		public RTCRtcpParameters rtcp;
	}

		public class RTCRtpRtxParameters
	{
		protected RTCRtpRtxParameters()
		{
			
		}
		public float ssrc;
	}

		public class RTCRtpUnhandled
	{
		protected RTCRtpUnhandled()
		{
			
		}
		public float ssrc;
		public float payloadType;
		public string muxId;
	}

		public class RTCSrtpKeyParam
	{
		protected RTCSrtpKeyParam()
		{
			
		}
		public string keyMethod;
		public string keySalt;
		public string lifetime;
		public float mkiValue;
		public float mkiLength;
	}

		public class RTCSrtpSdesParameters
	{
		protected RTCSrtpSdesParameters()
		{
			
		}
		public float tag;
		public string cryptoSuite;
		public RTCSrtpKeyParam[] keyParams;
		public string[] sessionParams;
	}

		public class RTCSsrcRange
	{
		protected RTCSsrcRange()
		{
			
		}
		public float min;
		public float max;
	}

		public class RTCStats
	{
		protected RTCStats()
		{
			
		}
		public float timestamp;
		public string type;
		public string id;
		public string msType;
	}

		public class RTCStatsReport
	{
		protected RTCStatsReport()
		{
			
		}
	}

		public class RTCTransportStats : RTCStats
	{
		protected RTCTransportStats() : base()
		{
			
		}
		public float bytesSent;
		public float bytesReceived;
		public string rtcpTransportStatsId;
		public bool activeConnection;
		public string selectedCandidatePairId;
		public string localCertificateId;
		public string remoteCertificateId;
	}

		public class StoreExceptionsInformation : ExceptionInformation
	{
		protected StoreExceptionsInformation() : base()
		{
			
		}
		public string siteName;
		public string explanationString;
		public string detailURI;
	}

		public class StoreSiteSpecificExceptionsInformation : StoreExceptionsInformation
	{
		protected StoreSiteSpecificExceptionsInformation() : base()
		{
			
		}
		public string[] arrayOfDomainStrings;
	}

		public class UIEventInit : EventInit
	{
		protected UIEventInit() : base()
		{
			
		}
		public IWindow view;
		public float detail;
	}

		public class WebGLContextAttributes
	{
		protected WebGLContextAttributes()
		{
			
		}
		public bool failIfMajorPerformanceCaveat;
		public bool alpha;
		public bool depth;
		public bool stencil;
		public bool antialias;
		public bool premultipliedAlpha;
		public bool preserveDrawingBuffer;
	}

		public class WebGLContextEventInit : EventInit
	{
		protected WebGLContextEventInit() : base()
		{
			
		}
		public string statusMessage;
	}

		public class WheelEventInit : MouseEventInit
	{
		protected WheelEventInit() : base()
		{
			
		}
		public float deltaX;
		public float deltaY;
		public float deltaZ;
		public float deltaMode;
	}

		public class EventListener
	{
		protected EventListener()
		{
			
		}
		public Event evt;
	}

		public class ANGLE_instanced_arrays
	{
		protected ANGLE_instanced_arrays()
		{
			
		}
		public readonly VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE;
		public void drawArraysInstancedANGLE(float mode, float first, float count, float primcount)
		{
			throw new System.NotImplementedException();
		}
		public void drawElementsInstancedANGLE(float mode, float count, float type, float offset, float primcount)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttribDivisorANGLE(float index, float divisor)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ANGLE_instanced_arrays_0_
	{
		public ANGLE_instanced_arrays prototype;
		public float VERTEX_ATTRIB_ARRAY_DIVISOR_ANGLE;
		public ANGLE_instanced_arrays new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AnalyserNode : AudioNode
	{
		protected AnalyserNode() : base()
		{
			
		}
		public float fftSize;
		public readonly frequencyBinCount;
		public float maxDecibels;
		public float minDecibels;
		public float smoothingTimeConstant;
		public void getByteFrequencyData(Bridge.Html5.Uint8Array array)
		{
			throw new System.NotImplementedException();
		}
		public void getByteTimeDomainData(Bridge.Html5.Uint8Array array)
		{
			throw new System.NotImplementedException();
		}
		public void getFloatFrequencyData(Bridge.Html5.Float32Array array)
		{
			throw new System.NotImplementedException();
		}
		public void getFloatTimeDomainData(Bridge.Html5.Float32Array array)
		{
			throw new System.NotImplementedException();
		}
	}

		public class AnalyserNode_0_
	{
		public AnalyserNode prototype;
		public AnalyserNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AnimationEvent : Event
	{
		protected AnimationEvent() : base()
		{
			
		}
		public readonly animationName;
		public readonly elapsedTime;
		public void initAnimationEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string animationNameArg, float elapsedTimeArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class AnimationEvent_0_
	{
		public AnimationEvent prototype;
		public AnimationEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ApplicationCache : EventTarget
	{
		protected ApplicationCache() : base()
		{
			
		}
		public Func<, object> oncached;
		public Event ev;
		public object any;
		public Func<, object> onchecking;
		public Func<, object> ondownloading;
		public Func<, object> onerror;
		public Func<, object> onnoupdate;
		public Func<, object> onobsolete;
		public Func<, object> onprogress;
		public Func<, object> onupdateready;
		public readonly status;
		public readonly CHECKING;
		public readonly DOWNLOADING;
		public readonly IDLE;
		public readonly OBSOLETE;
		public readonly UNCACHED;
		public readonly UPDATEREADY;
		public Func<, object> listener;
		public bool useCapture;
		public void abort()
		{
			throw new System.NotImplementedException();
		}
		public void swapCache()
		{
			throw new System.NotImplementedException();
		}
		public void update()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ApplicationCache_0_
	{
		public ApplicationCache prototype;
		public float CHECKING;
		public float DOWNLOADING;
		public float IDLE;
		public float OBSOLETE;
		public float UNCACHED;
		public float UPDATEREADY;
		public ApplicationCache new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AriaRequestEvent : Event
	{
		protected AriaRequestEvent() : base()
		{
			
		}
		public readonly attributeName;
		public Any<string, null> attributeValue;
	}

		public class AriaRequestEvent_0_
	{
		public AriaRequestEvent prototype;
		public AriaRequestEvent new(string type, AriaRequestEventInit eventInitDict = default(AriaRequestEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Attr : Node
	{
		protected Attr() : base()
		{
			
		}
		public readonly name;
		public readonly ownerElement;
		public readonly prefix;
		public readonly specified;
		public string value;
	}

		public class Attr_0_
	{
		public Attr prototype;
		public Attr new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioBuffer
	{
		protected AudioBuffer()
		{
			
		}
		public readonly duration;
		public readonly length;
		public readonly numberOfChannels;
		public readonly sampleRate;
		public void copyFromChannel(Bridge.Html5.Float32Array destination, float channelNumber, float startInChannel = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void copyToChannel(Bridge.Html5.Float32Array source, float channelNumber, float startInChannel = default(float))
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.Float32Array getChannelData(float channel)
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioBuffer_0_
	{
		public AudioBuffer prototype;
		public AudioBuffer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioBufferSourceNode : AudioNode
	{
		protected AudioBufferSourceNode() : base()
		{
			
		}
		public Any<AudioBuffer, null> buffer;
		public readonly detune;
		public bool loop;
		public float loopEnd;
		public float loopStart;
		public Func<, object> onended;
		public MediaStreamErrorEvent ev;
		public object any;
		public readonly playbackRate;
		public Func<, object> listener;
		public bool useCapture;
		public void start(float when = default(float), float offset = default(float), float duration = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void stop(float when = default(float))
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioBufferSourceNode_0_
	{
		public AudioBufferSourceNode prototype;
		public AudioBufferSourceNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioContext : EventTarget
	{
		protected AudioContext() : base()
		{
			
		}
		public readonly currentTime;
		public readonly destination;
		public readonly listener;
		public readonly sampleRate;
		public string state;
		public AnalyserNode createAnalyser()
		{
			throw new System.NotImplementedException();
		}
		public BiquadFilterNode createBiquadFilter()
		{
			throw new System.NotImplementedException();
		}
		public AudioBuffer createBuffer(float numberOfChannels, float length, float sampleRate)
		{
			throw new System.NotImplementedException();
		}
		public AudioBufferSourceNode createBufferSource()
		{
			throw new System.NotImplementedException();
		}
		public ChannelMergerNode createChannelMerger(float numberOfInputs = default(float))
		{
			throw new System.NotImplementedException();
		}
		public ChannelSplitterNode createChannelSplitter(float numberOfOutputs = default(float))
		{
			throw new System.NotImplementedException();
		}
		public ConvolverNode createConvolver()
		{
			throw new System.NotImplementedException();
		}
		public DelayNode createDelay(float maxDelayTime = default(float))
		{
			throw new System.NotImplementedException();
		}
		public DynamicsCompressorNode createDynamicsCompressor()
		{
			throw new System.NotImplementedException();
		}
		public GainNode createGain()
		{
			throw new System.NotImplementedException();
		}
		public MediaElementAudioSourceNode createMediaElementSource(HTMLMediaElement mediaElement)
		{
			throw new System.NotImplementedException();
		}
		public MediaStreamAudioSourceNode createMediaStreamSource(MediaStream mediaStream)
		{
			throw new System.NotImplementedException();
		}
		public OscillatorNode createOscillator()
		{
			throw new System.NotImplementedException();
		}
		public PannerNode createPanner()
		{
			throw new System.NotImplementedException();
		}
		public PeriodicWave createPeriodicWave(Bridge.Html5.Float32Array real, Bridge.Html5.Float32Array imag, PeriodicWaveConstraints constraints = default(PeriodicWaveConstraints))
		{
			throw new System.NotImplementedException();
		}
		public ScriptProcessorNode createScriptProcessor(float bufferSize = default(float), float numberOfInputChannels = default(float), float numberOfOutputChannels = default(float))
		{
			throw new System.NotImplementedException();
		}
		public StereoPannerNode createStereoPanner()
		{
			throw new System.NotImplementedException();
		}
		public WaveShaperNode createWaveShaper()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<AudioBuffer> decodeAudioData(Bridge.Html5.ArrayBuffer audioData, DecodeSuccessCallback successCallback = default(DecodeSuccessCallback), DecodeErrorCallback errorCallback = default(DecodeErrorCallback))
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioContext_0_
	{
		public AudioContext prototype;
		public AudioContext new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioDestinationNode : AudioNode
	{
		protected AudioDestinationNode() : base()
		{
			
		}
		public readonly maxChannelCount;
	}

		public class AudioDestinationNode_0_
	{
		public AudioDestinationNode prototype;
		public AudioDestinationNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioListener
	{
		protected AudioListener()
		{
			
		}
		public float dopplerFactor;
		public float speedOfSound;
		public void setOrientation(float x, float y, float z, float xUp, float yUp, float zUp)
		{
			throw new System.NotImplementedException();
		}
		public void setPosition(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public void setVelocity(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioListener_0_
	{
		public AudioListener prototype;
		public AudioListener new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioNode : EventTarget
	{
		protected AudioNode() : base()
		{
			
		}
		public float channelCount;
		public string channelCountMode;
		public string channelInterpretation;
		public readonly context;
		public readonly numberOfInputs;
		public readonly numberOfOutputs;
		public void connect(AudioNode destination, float output = default(float), float input = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void disconnect(float output = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void disconnect(AudioNode destination, float output = default(float), float input = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void disconnect(AudioParam destination, float output = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioNode_0_
	{
		public AudioNode prototype;
		public AudioNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioParam
	{
		protected AudioParam()
		{
			
		}
		public readonly defaultValue;
		public float value;
		public void cancelScheduledValues(float startTime)
		{
			throw new System.NotImplementedException();
		}
		public void exponentialRampToValueAtTime(float value, float endTime)
		{
			throw new System.NotImplementedException();
		}
		public void linearRampToValueAtTime(float value, float endTime)
		{
			throw new System.NotImplementedException();
		}
		public void setTargetAtTime(float target, float startTime, float timeConstant)
		{
			throw new System.NotImplementedException();
		}
		public void setValueAtTime(float value, float startTime)
		{
			throw new System.NotImplementedException();
		}
		public void setValueCurveAtTime(Bridge.Html5.Float32Array values, float startTime, float duration)
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioParam_0_
	{
		public AudioParam prototype;
		public AudioParam new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioProcessingEvent : Event
	{
		protected AudioProcessingEvent() : base()
		{
			
		}
		public readonly inputBuffer;
		public readonly outputBuffer;
		public readonly playbackTime;
	}

		public class AudioProcessingEvent_0_
	{
		public AudioProcessingEvent prototype;
		public AudioProcessingEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioTrack
	{
		protected AudioTrack()
		{
			
		}
		public bool enabled;
		public readonly id;
		public string kind;
		public readonly label;
		public string language;
		public readonly sourceBuffer;
	}

		public class AudioTrack_0_
	{
		public AudioTrack prototype;
		public AudioTrack new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioTrackList : EventTarget
	{
		protected AudioTrackList() : base()
		{
			
		}
		public readonly length;
		public Func<, object> onaddtrack;
		public TrackEvent ev;
		public object any;
		public Func<, object> onchange;
		public Func<, object> onremovetrack;
		public Func<, object> listener;
		public bool useCapture;
		public float index;
		public Any<AudioTrack, null> getTrackById(string id)
		{
			throw new System.NotImplementedException();
		}
		public AudioTrack item(float index)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class AudioTrackList_0_
	{
		public AudioTrackList prototype;
		public AudioTrackList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class BarProp
	{
		protected BarProp()
		{
			
		}
		public readonly visible;
	}

		public class BarProp_0_
	{
		public BarProp prototype;
		public BarProp new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class BeforeUnloadEvent : Event
	{
		protected BeforeUnloadEvent() : base()
		{
			
		}
		public object returnValue;
	}

		public class BeforeUnloadEvent_0_
	{
		public BeforeUnloadEvent prototype;
		public BeforeUnloadEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class BiquadFilterNode : AudioNode
	{
		protected BiquadFilterNode() : base()
		{
			
		}
		public readonly Q;
		public readonly detune;
		public readonly frequency;
		public readonly gain;
		public string type;
		public void getFrequencyResponse(Bridge.Html5.Float32Array frequencyHz, Bridge.Html5.Float32Array magResponse, Bridge.Html5.Float32Array phaseResponse)
		{
			throw new System.NotImplementedException();
		}
	}

		public class BiquadFilterNode_0_
	{
		public BiquadFilterNode prototype;
		public BiquadFilterNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Blob
	{
		protected Blob()
		{
			
		}
		public readonly size;
		public readonly type;
		public void msClose()
		{
			throw new System.NotImplementedException();
		}
		public object msDetachStream()
		{
			throw new System.NotImplementedException();
		}
		public Blob slice(float start = default(float), float end = default(float), string contentType = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Blob_0_
	{
		public Blob prototype;
		public Blob new(object[] blobParts = default(object[]), BlobPropertyBag options = default(BlobPropertyBag))
		{
			throw new System.NotImplementedException();
		}
	}

		public class CDATASection : Text
	{
		protected CDATASection() : base()
		{
			
		}
	}

		public class CDATASection_0_
	{
		public CDATASection prototype;
		public CDATASection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSS
	{
		protected CSS()
		{
			
		}
		public bool supports(string property, string value = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSConditionRule : CSSGroupingRule
	{
		protected CSSConditionRule() : base()
		{
			
		}
		public string conditionText;
	}

		public class CSSConditionRule_0_
	{
		public CSSConditionRule prototype;
		public CSSConditionRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSFontFaceRule : CSSRule
	{
		protected CSSFontFaceRule() : base()
		{
			
		}
		public readonly style;
	}

		public class CSSFontFaceRule_0_
	{
		public CSSFontFaceRule prototype;
		public CSSFontFaceRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSGroupingRule : CSSRule
	{
		protected CSSGroupingRule() : base()
		{
			
		}
		public readonly cssRules;
		public void deleteRule(float index)
		{
			throw new System.NotImplementedException();
		}
		public float insertRule(string rule, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSGroupingRule_0_
	{
		public CSSGroupingRule prototype;
		public CSSGroupingRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSImportRule : CSSRule
	{
		protected CSSImportRule() : base()
		{
			
		}
		public readonly href;
		public readonly media;
		public readonly styleSheet;
	}

		public class CSSImportRule_0_
	{
		public CSSImportRule prototype;
		public CSSImportRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSKeyframeRule : CSSRule
	{
		protected CSSKeyframeRule() : base()
		{
			
		}
		public string keyText;
		public readonly style;
	}

		public class CSSKeyframeRule_0_
	{
		public CSSKeyframeRule prototype;
		public CSSKeyframeRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSKeyframesRule : CSSRule
	{
		protected CSSKeyframesRule() : base()
		{
			
		}
		public readonly cssRules;
		public string name;
		public void appendRule(string rule)
		{
			throw new System.NotImplementedException();
		}
		public void deleteRule(string rule)
		{
			throw new System.NotImplementedException();
		}
		public CSSKeyframeRule findRule(string rule)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSKeyframesRule_0_
	{
		public CSSKeyframesRule prototype;
		public CSSKeyframesRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSMediaRule : CSSConditionRule
	{
		protected CSSMediaRule() : base()
		{
			
		}
		public readonly media;
	}

		public class CSSMediaRule_0_
	{
		public CSSMediaRule prototype;
		public CSSMediaRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSNamespaceRule : CSSRule
	{
		protected CSSNamespaceRule() : base()
		{
			
		}
		public readonly namespaceURI;
		public readonly prefix;
	}

		public class CSSNamespaceRule_0_
	{
		public CSSNamespaceRule prototype;
		public CSSNamespaceRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSPageRule : CSSRule
	{
		protected CSSPageRule() : base()
		{
			
		}
		public readonly pseudoClass;
		public readonly selector;
		public string selectorText;
		public readonly style;
	}

		public class CSSPageRule_0_
	{
		public CSSPageRule prototype;
		public CSSPageRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSRule
	{
		protected CSSRule()
		{
			
		}
		public string cssText;
		public readonly parentRule;
		public readonly parentStyleSheet;
		public readonly type;
		public readonly CHARSET_RULE;
		public readonly FONT_FACE_RULE;
		public readonly IMPORT_RULE;
		public readonly KEYFRAMES_RULE;
		public readonly KEYFRAME_RULE;
		public readonly MEDIA_RULE;
		public readonly NAMESPACE_RULE;
		public readonly PAGE_RULE;
		public readonly STYLE_RULE;
		public readonly SUPPORTS_RULE;
		public readonly UNKNOWN_RULE;
		public readonly VIEWPORT_RULE;
	}

		public class CSSRule_0_
	{
		public CSSRule prototype;
		public float CHARSET_RULE;
		public float FONT_FACE_RULE;
		public float IMPORT_RULE;
		public float KEYFRAMES_RULE;
		public float KEYFRAME_RULE;
		public float MEDIA_RULE;
		public float NAMESPACE_RULE;
		public float PAGE_RULE;
		public float STYLE_RULE;
		public float SUPPORTS_RULE;
		public float UNKNOWN_RULE;
		public float VIEWPORT_RULE;
		public CSSRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSRuleList
	{
		protected CSSRuleList()
		{
			
		}
		public readonly length;
		public float index;
		public CSSRule item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSRuleList_0_
	{
		public CSSRuleList prototype;
		public CSSRuleList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSStyleDeclaration
	{
		protected CSSStyleDeclaration()
		{
			
		}
		public Any<string, null> alignContent;
		public Any<string, null> alignItems;
		public Any<string, null> alignSelf;
		public Any<string, null> alignmentBaseline;
		public Any<string, null> animation;
		public Any<string, null> animationDelay;
		public Any<string, null> animationDirection;
		public Any<string, null> animationDuration;
		public Any<string, null> animationFillMode;
		public Any<string, null> animationIterationCount;
		public Any<string, null> animationName;
		public Any<string, null> animationPlayState;
		public Any<string, null> animationTimingFunction;
		public Any<string, null> backfaceVisibility;
		public Any<string, null> background;
		public Any<string, null> backgroundAttachment;
		public Any<string, null> backgroundClip;
		public Any<string, null> backgroundColor;
		public Any<string, null> backgroundImage;
		public Any<string, null> backgroundOrigin;
		public Any<string, null> backgroundPosition;
		public Any<string, null> backgroundPositionX;
		public Any<string, null> backgroundPositionY;
		public Any<string, null> backgroundRepeat;
		public Any<string, null> backgroundSize;
		public Any<string, null> baselineShift;
		public Any<string, null> border;
		public Any<string, null> borderBottom;
		public Any<string, null> borderBottomColor;
		public Any<string, null> borderBottomLeftRadius;
		public Any<string, null> borderBottomRightRadius;
		public Any<string, null> borderBottomStyle;
		public Any<string, null> borderBottomWidth;
		public Any<string, null> borderCollapse;
		public Any<string, null> borderColor;
		public Any<string, null> borderImage;
		public Any<string, null> borderImageOutset;
		public Any<string, null> borderImageRepeat;
		public Any<string, null> borderImageSlice;
		public Any<string, null> borderImageSource;
		public Any<string, null> borderImageWidth;
		public Any<string, null> borderLeft;
		public Any<string, null> borderLeftColor;
		public Any<string, null> borderLeftStyle;
		public Any<string, null> borderLeftWidth;
		public Any<string, null> borderRadius;
		public Any<string, null> borderRight;
		public Any<string, null> borderRightColor;
		public Any<string, null> borderRightStyle;
		public Any<string, null> borderRightWidth;
		public Any<string, null> borderSpacing;
		public Any<string, null> borderStyle;
		public Any<string, null> borderTop;
		public Any<string, null> borderTopColor;
		public Any<string, null> borderTopLeftRadius;
		public Any<string, null> borderTopRightRadius;
		public Any<string, null> borderTopStyle;
		public Any<string, null> borderTopWidth;
		public Any<string, null> borderWidth;
		public Any<string, null> bottom;
		public Any<string, null> boxShadow;
		public Any<string, null> boxSizing;
		public Any<string, null> breakAfter;
		public Any<string, null> breakBefore;
		public Any<string, null> breakInside;
		public Any<string, null> captionSide;
		public Any<string, null> clear;
		public Any<string, null> clip;
		public Any<string, null> clipPath;
		public Any<string, null> clipRule;
		public Any<string, null> color;
		public Any<string, null> colorInterpolationFilters;
		public object columnCount;
		public Any<string, null> columnFill;
		public object columnGap;
		public Any<string, null> columnRule;
		public object columnRuleColor;
		public Any<string, null> columnRuleStyle;
		public object columnRuleWidth;
		public Any<string, null> columnSpan;
		public object columnWidth;
		public Any<string, null> columns;
		public Any<string, null> content;
		public Any<string, null> counterIncrement;
		public Any<string, null> counterReset;
		public Any<string, null> cssFloat;
		public string cssText;
		public Any<string, null> cursor;
		public Any<string, null> direction;
		public Any<string, null> display;
		public Any<string, null> dominantBaseline;
		public Any<string, null> emptyCells;
		public Any<string, null> enableBackground;
		public Any<string, null> fill;
		public Any<string, null> fillOpacity;
		public Any<string, null> fillRule;
		public Any<string, null> filter;
		public Any<string, null> flex;
		public Any<string, null> flexBasis;
		public Any<string, null> flexDirection;
		public Any<string, null> flexFlow;
		public Any<string, null> flexGrow;
		public Any<string, null> flexShrink;
		public Any<string, null> flexWrap;
		public Any<string, null> floodColor;
		public Any<string, null> floodOpacity;
		public Any<string, null> font;
		public Any<string, null> fontFamily;
		public Any<string, null> fontFeatureSettings;
		public Any<string, null> fontSize;
		public Any<string, null> fontSizeAdjust;
		public Any<string, null> fontStretch;
		public Any<string, null> fontStyle;
		public Any<string, null> fontVariant;
		public Any<string, null> fontWeight;
		public Any<string, null> glyphOrientationHorizontal;
		public Any<string, null> glyphOrientationVertical;
		public Any<string, null> height;
		public Any<string, null> imeMode;
		public Any<string, null> justifyContent;
		public Any<string, null> kerning;
		public Any<string, null> left;
		public readonly length;
		public Any<string, null> letterSpacing;
		public Any<string, null> lightingColor;
		public Any<string, null> lineHeight;
		public Any<string, null> listStyle;
		public Any<string, null> listStyleImage;
		public Any<string, null> listStylePosition;
		public Any<string, null> listStyleType;
		public Any<string, null> margin;
		public Any<string, null> marginBottom;
		public Any<string, null> marginLeft;
		public Any<string, null> marginRight;
		public Any<string, null> marginTop;
		public Any<string, null> marker;
		public Any<string, null> markerEnd;
		public Any<string, null> markerMid;
		public Any<string, null> markerStart;
		public Any<string, null> mask;
		public Any<string, null> maxHeight;
		public Any<string, null> maxWidth;
		public Any<string, null> minHeight;
		public Any<string, null> minWidth;
		public Any<string, null> msContentZoomChaining;
		public Any<string, null> msContentZoomLimit;
		public object msContentZoomLimitMax;
		public object msContentZoomLimitMin;
		public Any<string, null> msContentZoomSnap;
		public Any<string, null> msContentZoomSnapPoints;
		public Any<string, null> msContentZoomSnapType;
		public Any<string, null> msContentZooming;
		public Any<string, null> msFlowFrom;
		public Any<string, null> msFlowInto;
		public Any<string, null> msFontFeatureSettings;
		public object msGridColumn;
		public Any<string, null> msGridColumnAlign;
		public object msGridColumnSpan;
		public Any<string, null> msGridColumns;
		public object msGridRow;
		public Any<string, null> msGridRowAlign;
		public object msGridRowSpan;
		public Any<string, null> msGridRows;
		public Any<string, null> msHighContrastAdjust;
		public Any<string, null> msHyphenateLimitChars;
		public object msHyphenateLimitLines;
		public object msHyphenateLimitZone;
		public Any<string, null> msHyphens;
		public Any<string, null> msImeAlign;
		public Any<string, null> msOverflowStyle;
		public Any<string, null> msScrollChaining;
		public Any<string, null> msScrollLimit;
		public object msScrollLimitXMax;
		public object msScrollLimitXMin;
		public object msScrollLimitYMax;
		public object msScrollLimitYMin;
		public Any<string, null> msScrollRails;
		public Any<string, null> msScrollSnapPointsX;
		public Any<string, null> msScrollSnapPointsY;
		public Any<string, null> msScrollSnapType;
		public Any<string, null> msScrollSnapX;
		public Any<string, null> msScrollSnapY;
		public Any<string, null> msScrollTranslation;
		public Any<string, null> msTextCombineHorizontal;
		public object msTextSizeAdjust;
		public Any<string, null> msTouchAction;
		public Any<string, null> msTouchSelect;
		public Any<string, null> msUserSelect;
		public string msWrapFlow;
		public object msWrapMargin;
		public string msWrapThrough;
		public Any<string, null> opacity;
		public Any<string, null> order;
		public Any<string, null> orphans;
		public Any<string, null> outline;
		public Any<string, null> outlineColor;
		public Any<string, null> outlineStyle;
		public Any<string, null> outlineWidth;
		public Any<string, null> overflow;
		public Any<string, null> overflowX;
		public Any<string, null> overflowY;
		public Any<string, null> padding;
		public Any<string, null> paddingBottom;
		public Any<string, null> paddingLeft;
		public Any<string, null> paddingRight;
		public Any<string, null> paddingTop;
		public Any<string, null> pageBreakAfter;
		public Any<string, null> pageBreakBefore;
		public Any<string, null> pageBreakInside;
		public readonly parentRule;
		public Any<string, null> perspective;
		public Any<string, null> perspectiveOrigin;
		public Any<string, null> pointerEvents;
		public Any<string, null> position;
		public Any<string, null> quotes;
		public Any<string, null> right;
		public Any<string, null> rubyAlign;
		public Any<string, null> rubyOverhang;
		public Any<string, null> rubyPosition;
		public Any<string, null> stopColor;
		public Any<string, null> stopOpacity;
		public Any<string, null> stroke;
		public Any<string, null> strokeDasharray;
		public Any<string, null> strokeDashoffset;
		public Any<string, null> strokeLinecap;
		public Any<string, null> strokeLinejoin;
		public Any<string, null> strokeMiterlimit;
		public Any<string, null> strokeOpacity;
		public Any<string, null> strokeWidth;
		public Any<string, null> tableLayout;
		public Any<string, null> textAlign;
		public Any<string, null> textAlignLast;
		public Any<string, null> textAnchor;
		public Any<string, null> textDecoration;
		public Any<string, null> textIndent;
		public Any<string, null> textJustify;
		public Any<string, null> textKashida;
		public Any<string, null> textKashidaSpace;
		public Any<string, null> textOverflow;
		public Any<string, null> textShadow;
		public Any<string, null> textTransform;
		public Any<string, null> textUnderlinePosition;
		public Any<string, null> top;
		public Any<string, null> touchAction;
		public Any<string, null> transform;
		public Any<string, null> transformOrigin;
		public Any<string, null> transformStyle;
		public Any<string, null> transition;
		public Any<string, null> transitionDelay;
		public Any<string, null> transitionDuration;
		public Any<string, null> transitionProperty;
		public Any<string, null> transitionTimingFunction;
		public Any<string, null> unicodeBidi;
		public Any<string, null> verticalAlign;
		public Any<string, null> visibility;
		public Any<string, null> webkitAlignContent;
		public Any<string, null> webkitAlignItems;
		public Any<string, null> webkitAlignSelf;
		public Any<string, null> webkitAnimation;
		public Any<string, null> webkitAnimationDelay;
		public Any<string, null> webkitAnimationDirection;
		public Any<string, null> webkitAnimationDuration;
		public Any<string, null> webkitAnimationFillMode;
		public Any<string, null> webkitAnimationIterationCount;
		public Any<string, null> webkitAnimationName;
		public Any<string, null> webkitAnimationPlayState;
		public Any<string, null> webkitAnimationTimingFunction;
		public Any<string, null> webkitAppearance;
		public Any<string, null> webkitBackfaceVisibility;
		public Any<string, null> webkitBackgroundClip;
		public Any<string, null> webkitBackgroundOrigin;
		public Any<string, null> webkitBackgroundSize;
		public Any<string, null> webkitBorderBottomLeftRadius;
		public Any<string, null> webkitBorderBottomRightRadius;
		public Any<string, null> webkitBorderImage;
		public Any<string, null> webkitBorderRadius;
		public Any<string, null> webkitBorderTopLeftRadius;
		public Any<string, null> webkitBorderTopRightRadius;
		public Any<string, null> webkitBoxAlign;
		public Any<string, null> webkitBoxDirection;
		public Any<string, null> webkitBoxFlex;
		public Any<string, null> webkitBoxOrdinalGroup;
		public Any<string, null> webkitBoxOrient;
		public Any<string, null> webkitBoxPack;
		public Any<string, null> webkitBoxSizing;
		public Any<string, null> webkitColumnBreakAfter;
		public Any<string, null> webkitColumnBreakBefore;
		public Any<string, null> webkitColumnBreakInside;
		public object webkitColumnCount;
		public object webkitColumnGap;
		public Any<string, null> webkitColumnRule;
		public object webkitColumnRuleColor;
		public Any<string, null> webkitColumnRuleStyle;
		public object webkitColumnRuleWidth;
		public Any<string, null> webkitColumnSpan;
		public object webkitColumnWidth;
		public Any<string, null> webkitColumns;
		public Any<string, null> webkitFilter;
		public Any<string, null> webkitFlex;
		public Any<string, null> webkitFlexBasis;
		public Any<string, null> webkitFlexDirection;
		public Any<string, null> webkitFlexFlow;
		public Any<string, null> webkitFlexGrow;
		public Any<string, null> webkitFlexShrink;
		public Any<string, null> webkitFlexWrap;
		public Any<string, null> webkitJustifyContent;
		public Any<string, null> webkitOrder;
		public Any<string, null> webkitPerspective;
		public Any<string, null> webkitPerspectiveOrigin;
		public Any<string, null> webkitTapHighlightColor;
		public Any<string, null> webkitTextFillColor;
		public object webkitTextSizeAdjust;
		public Any<string, null> webkitTransform;
		public Any<string, null> webkitTransformOrigin;
		public Any<string, null> webkitTransformStyle;
		public Any<string, null> webkitTransition;
		public Any<string, null> webkitTransitionDelay;
		public Any<string, null> webkitTransitionDuration;
		public Any<string, null> webkitTransitionProperty;
		public Any<string, null> webkitTransitionTimingFunction;
		public Any<string, null> webkitUserModify;
		public Any<string, null> webkitUserSelect;
		public Any<string, null> webkitWritingMode;
		public Any<string, null> whiteSpace;
		public Any<string, null> widows;
		public Any<string, null> width;
		public Any<string, null> wordBreak;
		public Any<string, null> wordSpacing;
		public Any<string, null> wordWrap;
		public Any<string, null> writingMode;
		public Any<string, null> zIndex;
		public Any<string, null> zoom;
		public float index;
		public string getPropertyPriority(string propertyName)
		{
			throw new System.NotImplementedException();
		}
		public string getPropertyValue(string propertyName)
		{
			throw new System.NotImplementedException();
		}
		public string item(float index)
		{
			throw new System.NotImplementedException();
		}
		public string removeProperty(string propertyName)
		{
			throw new System.NotImplementedException();
		}
		public void setProperty(string propertyName, Any<string, null> value, string priority = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSStyleDeclaration_0_
	{
		public CSSStyleDeclaration prototype;
		public CSSStyleDeclaration new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSStyleRule : CSSRule
	{
		protected CSSStyleRule() : base()
		{
			
		}
		public readonly readOnly;
		public string selectorText;
		public readonly style;
	}

		public class CSSStyleRule_0_
	{
		public CSSStyleRule prototype;
		public CSSStyleRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSStyleSheet : StyleSheet
	{
		protected CSSStyleSheet() : base()
		{
			
		}
		public readonly cssRules;
		public string cssText;
		public readonly href;
		public readonly id;
		public readonly imports;
		public readonly isAlternate;
		public readonly isPrefAlternate;
		public readonly ownerRule;
		public readonly owningElement;
		public readonly pages;
		public readonly readOnly;
		public readonly rules;
		public float addImport(string bstrURL, float lIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float addPageRule(string bstrSelector, string bstrStyle, float lIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float addRule(string bstrSelector, string bstrStyle = default(string), float lIndex = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void deleteRule(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float insertRule(string rule, float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void removeImport(float lIndex)
		{
			throw new System.NotImplementedException();
		}
		public void removeRule(float lIndex)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSStyleSheet_0_
	{
		public CSSStyleSheet prototype;
		public CSSStyleSheet new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CSSSupportsRule : CSSConditionRule
	{
		protected CSSSupportsRule() : base()
		{
			
		}
	}

		public class CSSSupportsRule_0_
	{
		public CSSSupportsRule prototype;
		public CSSSupportsRule new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasGradient
	{
		protected CanvasGradient()
		{
			
		}
		public void addColorStop(float offset, string color)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasGradient_0_
	{
		public CanvasGradient prototype;
		public CanvasGradient new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasPattern
	{
		protected CanvasPattern()
		{
			
		}
	}

		public class CanvasPattern_0_
	{
		public CanvasPattern prototype;
		public CanvasPattern new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasRenderingContext2D : Object, CanvasPathMethods
	{
		protected CanvasRenderingContext2D() : base()
		{
			
		}
		public readonly canvas;
		public Any<string, CanvasGradient, CanvasPattern> fillStyle;
		public string font;
		public float globalAlpha;
		public string globalCompositeOperation;
		public string lineCap;
		public float lineDashOffset;
		public string lineJoin;
		public float lineWidth;
		public float miterLimit;
		public string msFillRule;
		public bool msImageSmoothingEnabled;
		public float shadowBlur;
		public string shadowColor;
		public float shadowOffsetX;
		public float shadowOffsetY;
		public Any<string, CanvasGradient, CanvasPattern> strokeStyle;
		public string textAlign;
		public string textBaseline;
		public bool mozImageSmoothingEnabled;
		public bool webkitImageSmoothingEnabled;
		public bool oImageSmoothingEnabled;
		public void beginPath()
		{
			throw new System.NotImplementedException();
		}
		public void clearRect(float x, float y, float w, float h)
		{
			throw new System.NotImplementedException();
		}
		public void clip(string fillRule = default(string))
		{
			throw new System.NotImplementedException();
		}
		public ImageData createImageData(Any<float, ImageData> imageDataOrSw, float sh = default(float))
		{
			throw new System.NotImplementedException();
		}
		public CanvasGradient createLinearGradient(float x0, float y0, float x1, float y1)
		{
			throw new System.NotImplementedException();
		}
		public CanvasPattern createPattern(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> image, string repetition)
		{
			throw new System.NotImplementedException();
		}
		public CanvasGradient createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1)
		{
			throw new System.NotImplementedException();
		}
		public void drawImage(Any<HTMLImageElement, HTMLCanvasElement, HTMLVideoElement> image, float offsetX, float offsetY, float width = default(float), float height = default(float), float canvasOffsetX = default(float), float canvasOffsetY = default(float), float canvasImageWidth = default(float), float canvasImageHeight = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void fill(string fillRule = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void fillRect(float x, float y, float w, float h)
		{
			throw new System.NotImplementedException();
		}
		public void fillText(string text, float x, float y, float maxWidth = default(float))
		{
			throw new System.NotImplementedException();
		}
		public ImageData getImageData(float sx, float sy, float sw, float sh)
		{
			throw new System.NotImplementedException();
		}
		public float[] getLineDash()
		{
			throw new System.NotImplementedException();
		}
		public bool isPointInPath(float x, float y, string fillRule = default(string))
		{
			throw new System.NotImplementedException();
		}
		public TextMetrics measureText(string text)
		{
			throw new System.NotImplementedException();
		}
		public void putImageData(ImageData imagedata, float dx, float dy, float dirtyX = default(float), float dirtyY = default(float), float dirtyWidth = default(float), float dirtyHeight = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void restore()
		{
			throw new System.NotImplementedException();
		}
		public void rotate(float angle)
		{
			throw new System.NotImplementedException();
		}
		public void save()
		{
			throw new System.NotImplementedException();
		}
		public void scale(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void setLineDash(float[] segments)
		{
			throw new System.NotImplementedException();
		}
		public void setTransform(float m11, float m12, float m21, float m22, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public void stroke()
		{
			throw new System.NotImplementedException();
		}
		public void strokeRect(float x, float y, float w, float h)
		{
			throw new System.NotImplementedException();
		}
		public void strokeText(string text, float x, float y, float maxWidth = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void transform(float m11, float m12, float m21, float m22, float dx, float dy)
		{
			throw new System.NotImplementedException();
		}
		public void translate(float x, float y)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasRenderingContext2D_0_
	{
		public CanvasRenderingContext2D prototype;
		public CanvasRenderingContext2D new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ChannelMergerNode : AudioNode
	{
		protected ChannelMergerNode() : base()
		{
			
		}
	}

		public class ChannelMergerNode_0_
	{
		public ChannelMergerNode prototype;
		public ChannelMergerNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ChannelSplitterNode : AudioNode
	{
		protected ChannelSplitterNode() : base()
		{
			
		}
	}

		public class ChannelSplitterNode_0_
	{
		public ChannelSplitterNode prototype;
		public ChannelSplitterNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CharacterData : Node, ChildNode
	{
		protected CharacterData() : base()
		{
			
		}
		public string data;
		public readonly length;
		public void appendData(string arg)
		{
			throw new System.NotImplementedException();
		}
		public void deleteData(float offset, float count)
		{
			throw new System.NotImplementedException();
		}
		public void insertData(float offset, string arg)
		{
			throw new System.NotImplementedException();
		}
		public void replaceData(float offset, float count, string arg)
		{
			throw new System.NotImplementedException();
		}
		public string substringData(float offset, float count)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class CharacterData_0_
	{
		public CharacterData prototype;
		public CharacterData new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ClientRect
	{
		protected ClientRect()
		{
			
		}
		public float bottom;
		public readonly height;
		public float left;
		public float right;
		public float top;
		public readonly width;
	}

		public class ClientRect_0_
	{
		public ClientRect prototype;
		public ClientRect new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ClientRectList
	{
		protected ClientRectList()
		{
			
		}
		public readonly length;
		public float index;
		public ClientRect item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ClientRectList_0_
	{
		public ClientRectList prototype;
		public ClientRectList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ClipboardEvent : Event
	{
		protected ClipboardEvent() : base()
		{
			
		}
		public readonly clipboardData;
	}

		public class ClipboardEvent_0_
	{
		public ClipboardEvent prototype;
		public ClipboardEvent new(string type, ClipboardEventInit eventInitDict = default(ClipboardEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class CloseEvent : Event
	{
		protected CloseEvent() : base()
		{
			
		}
		public readonly code;
		public readonly reason;
		public readonly wasClean;
		public void initCloseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, bool wasCleanArg, float codeArg, string reasonArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CloseEvent_0_
	{
		public CloseEvent prototype;
		public CloseEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CommandEvent : Event
	{
		protected CommandEvent() : base()
		{
			
		}
		public readonly commandName;
		public readonly detail;
	}

		public class CommandEvent_0_
	{
		public CommandEvent prototype;
		public CommandEvent new(string type, CommandEventInit eventInitDict = default(CommandEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Comment : CharacterData
	{
		protected Comment() : base()
		{
			
		}
		public string text;
	}

		public class Comment_0_
	{
		public Comment prototype;
		public Comment new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CompositionEvent : UIEvent
	{
		protected CompositionEvent() : base()
		{
			
		}
		public readonly data;
		public readonly locale;
		public void initCompositionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, string dataArg, string locale)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CompositionEvent_0_
	{
		public CompositionEvent prototype;
		public CompositionEvent new(string typeArg, CompositionEventInit eventInitDict = default(CompositionEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Console
	{
		protected Console()
		{
			
		}
		public void assert(bool test = default(bool), string message = default(string), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void count(string countTitle = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void debug(string message = default(string), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void dir(object value = default(object), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void dirxml(object value)
		{
			throw new System.NotImplementedException();
		}
		public void error(object message = default(object), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void exception(string message = default(string), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void group(string groupTitle = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void groupCollapsed(string groupTitle = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void groupEnd()
		{
			throw new System.NotImplementedException();
		}
		public void info(object message = default(object), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void log(object message = default(object), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public bool msIsIndependentlyComposed(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void profile(string reportName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void profileEnd()
		{
			throw new System.NotImplementedException();
		}
		public void select(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void table(params object[][] data)
		{
			throw new System.NotImplementedException();
		}
		public void time(string timerName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void timeEnd(string timerName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void trace(object message = default(object), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
		public void warn(object message = default(object), params object[][] optionalParams)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Console_0_
	{
		public Console prototype;
		public Console new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ConvolverNode : AudioNode
	{
		protected ConvolverNode() : base()
		{
			
		}
		public Any<AudioBuffer, null> buffer;
		public bool normalize;
	}

		public class ConvolverNode_0_
	{
		public ConvolverNode prototype;
		public ConvolverNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Coordinates
	{
		protected Coordinates()
		{
			
		}
		public readonly accuracy;
		public readonly altitude;
		public readonly altitudeAccuracy;
		public readonly heading;
		public readonly latitude;
		public readonly longitude;
		public readonly speed;
	}

		public class Coordinates_0_
	{
		public Coordinates prototype;
		public Coordinates new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Crypto : Object, RandomSource
	{
		protected Crypto() : base()
		{
			
		}
		public readonly subtle;
	}

		public class Crypto_0_
	{
		public Crypto prototype;
		public Crypto new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CryptoKey
	{
		protected CryptoKey()
		{
			
		}
		public readonly algorithm;
		public readonly extractable;
		public readonly type;
		public readonly usages;
	}

		public class CryptoKey_0_
	{
		public CryptoKey prototype;
		public CryptoKey new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CryptoKeyPair
	{
		protected CryptoKeyPair()
		{
			
		}
		public CryptoKey privateKey;
		public CryptoKey publicKey;
	}

		public class CryptoKeyPair_0_
	{
		public CryptoKeyPair prototype;
		public CryptoKeyPair new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class CustomEvent : Event
	{
		protected CustomEvent() : base()
		{
			
		}
		public readonly detail;
		public void initCustomEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object detailArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class CustomEvent_0_
	{
		public CustomEvent prototype;
		public CustomEvent new(string typeArg, CustomEventInit eventInitDict = default(CustomEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMError
	{
		protected DOMError()
		{
			
		}
		public readonly name;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMError_0_
	{
		public DOMError prototype;
		public DOMError new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMException
	{
		protected DOMException()
		{
			
		}
		public readonly code;
		public readonly message;
		public readonly name;
		public readonly ABORT_ERR;
		public readonly DATA_CLONE_ERR;
		public readonly DOMSTRING_SIZE_ERR;
		public readonly HIERARCHY_REQUEST_ERR;
		public readonly INDEX_SIZE_ERR;
		public readonly INUSE_ATTRIBUTE_ERR;
		public readonly INVALID_ACCESS_ERR;
		public readonly INVALID_CHARACTER_ERR;
		public readonly INVALID_MODIFICATION_ERR;
		public readonly INVALID_NODE_TYPE_ERR;
		public readonly INVALID_STATE_ERR;
		public readonly NAMESPACE_ERR;
		public readonly NETWORK_ERR;
		public readonly NOT_FOUND_ERR;
		public readonly NOT_SUPPORTED_ERR;
		public readonly NO_DATA_ALLOWED_ERR;
		public readonly NO_MODIFICATION_ALLOWED_ERR;
		public readonly PARSE_ERR;
		public readonly QUOTA_EXCEEDED_ERR;
		public readonly SECURITY_ERR;
		public readonly SERIALIZE_ERR;
		public readonly SYNTAX_ERR;
		public readonly TIMEOUT_ERR;
		public readonly TYPE_MISMATCH_ERR;
		public readonly URL_MISMATCH_ERR;
		public readonly VALIDATION_ERR;
		public readonly WRONG_DOCUMENT_ERR;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMException_0_
	{
		public DOMException prototype;
		public float ABORT_ERR;
		public float DATA_CLONE_ERR;
		public float DOMSTRING_SIZE_ERR;
		public float HIERARCHY_REQUEST_ERR;
		public float INDEX_SIZE_ERR;
		public float INUSE_ATTRIBUTE_ERR;
		public float INVALID_ACCESS_ERR;
		public float INVALID_CHARACTER_ERR;
		public float INVALID_MODIFICATION_ERR;
		public float INVALID_NODE_TYPE_ERR;
		public float INVALID_STATE_ERR;
		public float NAMESPACE_ERR;
		public float NETWORK_ERR;
		public float NOT_FOUND_ERR;
		public float NOT_SUPPORTED_ERR;
		public float NO_DATA_ALLOWED_ERR;
		public float NO_MODIFICATION_ALLOWED_ERR;
		public float PARSE_ERR;
		public float QUOTA_EXCEEDED_ERR;
		public float SECURITY_ERR;
		public float SERIALIZE_ERR;
		public float SYNTAX_ERR;
		public float TIMEOUT_ERR;
		public float TYPE_MISMATCH_ERR;
		public float URL_MISMATCH_ERR;
		public float VALIDATION_ERR;
		public float WRONG_DOCUMENT_ERR;
		public DOMException new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMImplementation
	{
		protected DOMImplementation()
		{
			
		}
		public Document createDocument(Any<string, null> namespaceURI, Any<string, null> qualifiedName, DocumentType doctype)
		{
			throw new System.NotImplementedException();
		}
		public DocumentType createDocumentType(string qualifiedName, Any<string, null> publicId, Any<string, null> systemId)
		{
			throw new System.NotImplementedException();
		}
		public Document createHTMLDocument(string title)
		{
			throw new System.NotImplementedException();
		}
		public bool hasFeature(Any<string, null> feature, Any<string, null> version)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMImplementation_0_
	{
		public DOMImplementation prototype;
		public DOMImplementation new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMParser
	{
		protected DOMParser()
		{
			
		}
		public Document parseFromString(string source, string mimeType)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMParser_0_
	{
		public DOMParser prototype;
		public DOMParser new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMSettableTokenList : DOMTokenList
	{
		protected DOMSettableTokenList() : base()
		{
			
		}
		public string value;
	}

		public class DOMSettableTokenList_0_
	{
		public DOMSettableTokenList prototype;
		public DOMSettableTokenList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMStringList
	{
		protected DOMStringList()
		{
			
		}
		public readonly length;
		public float index;
		public bool contains(string str)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMStringList_0_
	{
		public DOMStringList prototype;
		public DOMStringList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMStringMap
	{
		protected DOMStringMap()
		{
			
		}
		public string name;
	}

		public class DOMStringMap_0_
	{
		public DOMStringMap prototype;
		public DOMStringMap new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMTokenList
	{
		protected DOMTokenList()
		{
			
		}
		public readonly length;
		public float index;
		public void add(params string[] token)
		{
			throw new System.NotImplementedException();
		}
		public bool contains(string token)
		{
			throw new System.NotImplementedException();
		}
		public string item(float index)
		{
			throw new System.NotImplementedException();
		}
		public void remove(params string[] token)
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public bool toggle(string token, bool force = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOMTokenList_0_
	{
		public DOMTokenList prototype;
		public DOMTokenList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataCue : TextTrackCue
	{
		protected DataCue() : base()
		{
			
		}
		public Bridge.Html5.ArrayBuffer data;
	}

		public class DataCue_0_
	{
		public DataCue prototype;
		public DataCue new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataTransfer
	{
		protected DataTransfer()
		{
			
		}
		public string dropEffect;
		public string effectAllowed;
		public readonly files;
		public readonly items;
		public readonly types;
		public bool clearData(string format = default(string))
		{
			throw new System.NotImplementedException();
		}
		public string getData(string format)
		{
			throw new System.NotImplementedException();
		}
		public bool setData(string format, string data)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataTransfer_0_
	{
		public DataTransfer prototype;
		public DataTransfer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataTransferItem
	{
		protected DataTransferItem()
		{
			
		}
		public readonly kind;
		public readonly type;
		public Any<File, null> getAsFile()
		{
			throw new System.NotImplementedException();
		}
		public void getAsString(Any<FunctionStringCallback, null> _callback)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataTransferItem_0_
	{
		public DataTransferItem prototype;
		public DataTransferItem new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataTransferItemList
	{
		protected DataTransferItemList()
		{
			
		}
		public readonly length;
		public float index;
		public Any<DataTransferItem, null> add(File data)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public DataTransferItem item(float index)
		{
			throw new System.NotImplementedException();
		}
		public void remove(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DataTransferItemList_0_
	{
		public DataTransferItemList prototype;
		public DataTransferItemList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeferredPermissionRequest
	{
		protected DeferredPermissionRequest()
		{
			
		}
		public readonly id;
		public readonly type;
		public readonly uri;
		public void allow()
		{
			throw new System.NotImplementedException();
		}
		public void deny()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeferredPermissionRequest_0_
	{
		public DeferredPermissionRequest prototype;
		public DeferredPermissionRequest new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DelayNode : AudioNode
	{
		protected DelayNode() : base()
		{
			
		}
		public readonly delayTime;
	}

		public class DelayNode_0_
	{
		public DelayNode prototype;
		public DelayNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceAcceleration
	{
		protected DeviceAcceleration()
		{
			
		}
		public readonly x;
		public readonly y;
		public readonly z;
	}

		public class DeviceAcceleration_0_
	{
		public DeviceAcceleration prototype;
		public DeviceAcceleration new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceLightEvent : Event
	{
		protected DeviceLightEvent() : base()
		{
			
		}
		public readonly value;
	}

		public class DeviceLightEvent_0_
	{
		public DeviceLightEvent prototype;
		public DeviceLightEvent new(string type, DeviceLightEventInit eventInitDict = default(DeviceLightEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceMotionEvent : Event
	{
		protected DeviceMotionEvent() : base()
		{
			
		}
		public readonly acceleration;
		public readonly accelerationIncludingGravity;
		public readonly interval;
		public readonly rotationRate;
		public void initDeviceMotionEvent(string type, bool bubbles, bool cancelable, Any<DeviceAccelerationDict, null> acceleration, Any<DeviceAccelerationDict, null> accelerationIncludingGravity, Any<DeviceRotationRateDict, null> rotationRate, Any<float, null> interval)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceMotionEvent_0_
	{
		public DeviceMotionEvent prototype;
		public DeviceMotionEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceOrientationEvent : Event
	{
		protected DeviceOrientationEvent() : base()
		{
			
		}
		public readonly absolute;
		public readonly alpha;
		public readonly beta;
		public readonly gamma;
		public void initDeviceOrientationEvent(string type, bool bubbles, bool cancelable, Any<float, null> alpha, Any<float, null> beta, Any<float, null> gamma, bool absolute)
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceOrientationEvent_0_
	{
		public DeviceOrientationEvent prototype;
		public DeviceOrientationEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DeviceRotationRate
	{
		protected DeviceRotationRate()
		{
			
		}
		public readonly alpha;
		public readonly beta;
		public readonly gamma;
	}

		public class DeviceRotationRate_0_
	{
		public DeviceRotationRate prototype;
		public DeviceRotationRate new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Document : Node, GlobalEventHandlers, NodeSelector, DocumentEvent, ParentNode
	{
		protected Document() : base()
		{
			
		}
		public readonly URL;
		public readonly URLUnencoded;
		public readonly activeElement;
		public string alinkColor;
		public readonly all;
		public HTMLCollectionOf<HTMLAnchorElement> anchors;
		public HTMLCollectionOf<HTMLAppletElement> applets;
		public string bgColor;
		public HTMLElement body;
		public readonly characterSet;
		public string charset;
		public readonly compatMode;
		public string cookie;
		public readonly currentScript;
		public readonly defaultCharset;
		public readonly defaultView;
		public string designMode;
		public string dir;
		public readonly doctype;
		public HTMLElement documentElement;
		public string domain;
		public HTMLCollectionOf<HTMLEmbedElement> embeds;
		public string fgColor;
		public HTMLCollectionOf<HTMLFormElement> forms;
		public readonly fullscreenElement;
		public readonly fullscreenEnabled;
		public readonly head;
		public readonly hidden;
		public HTMLCollectionOf<HTMLImageElement> images;
		public readonly implementation;
		public readonly inputEncoding;
		public readonly lastModified;
		public string linkColor;
		public HTMLCollectionOf<> links;
		public readonly location;
		public bool msCSSOMElementFloatMetrics;
		public bool msCapsLockWarningOff;
		public Func<, object> onabort;
		public WheelEvent ev;
		public object any;
		public Func<, object> onactivate;
		public Func<, object> onbeforeactivate;
		public Func<, object> onbeforedeactivate;
		public Func<, object> onblur;
		public Func<, object> oncanplay;
		public Func<, object> oncanplaythrough;
		public Func<, object> onchange;
		public Func<, object> onclick;
		public Func<, object> oncontextmenu;
		public Func<, object> ondblclick;
		public Func<, object> ondeactivate;
		public Func<, object> ondrag;
		public Func<, object> ondragend;
		public Func<, object> ondragenter;
		public Func<, object> ondragleave;
		public Func<, object> ondragover;
		public Func<, object> ondragstart;
		public Func<, object> ondrop;
		public Func<, object> ondurationchange;
		public Func<, object> onemptied;
		public Func<, object> onended;
		public Func<, object> onerror;
		public Func<, object> onfocus;
		public Func<, object> onfullscreenchange;
		public Func<, object> onfullscreenerror;
		public Func<, object> oninput;
		public Func<, object> oninvalid;
		public Func<, object> onkeydown;
		public Func<, object> onkeypress;
		public Func<, object> onkeyup;
		public Func<, object> onload;
		public Func<, object> onloadeddata;
		public Func<, object> onloadedmetadata;
		public Func<, object> onloadstart;
		public Func<, object> onmousedown;
		public Func<, object> onmousemove;
		public Func<, object> onmouseout;
		public Func<, object> onmouseover;
		public Func<, object> onmouseup;
		public Func<, object> onmousewheel;
		public Func<, object> onmscontentzoom;
		public Func<, object> onmsgesturechange;
		public Func<, object> onmsgesturedoubletap;
		public Func<, object> onmsgestureend;
		public Func<, object> onmsgesturehold;
		public Func<, object> onmsgesturestart;
		public Func<, object> onmsgesturetap;
		public Func<, object> onmsinertiastart;
		public Func<, object> onmsmanipulationstatechanged;
		public Func<, object> onmspointercancel;
		public Func<, object> onmspointerdown;
		public Func<, object> onmspointerenter;
		public Func<, object> onmspointerleave;
		public Func<, object> onmspointermove;
		public Func<, object> onmspointerout;
		public Func<, object> onmspointerover;
		public Func<, object> onmspointerup;
		public Func<, object> onmssitemodejumplistitemremoved;
		public Func<, object> onmsthumbnailclick;
		public Func<, object> onpause;
		public Func<, object> onplay;
		public Func<, object> onplaying;
		public Func<, object> onpointerlockchange;
		public Func<, object> onpointerlockerror;
		public Func<, object> onprogress;
		public Func<, object> onratechange;
		public Func<, object> onreadystatechange;
		public Func<, object> onreset;
		public Func<, object> onscroll;
		public Func<, object> onseeked;
		public Func<, object> onseeking;
		public Func<, object> onselect;
		public Func<, object> onselectionchange;
		public Func<, object> onselectstart;
		public Func<, object> onstalled;
		public Func<, object> onstop;
		public Func<, object> onsubmit;
		public Func<, object> onsuspend;
		public Func<, object> ontimeupdate;
		public Func<TouchEvent, object> ontouchcancel;
		public Func<TouchEvent, object> ontouchend;
		public Func<TouchEvent, object> ontouchmove;
		public Func<TouchEvent, object> ontouchstart;
		public Func<, object> onvolumechange;
		public Func<, object> onwaiting;
		public Func<, object> onwebkitfullscreenchange;
		public Func<, object> onwebkitfullscreenerror;
		public HTMLCollectionOf<HTMLEmbedElement> plugins;
		public readonly pointerLockElement;
		public readonly readyState;
		public readonly referrer;
		public readonly rootElement;
		public HTMLCollectionOf<HTMLScriptElement> scripts;
		public readonly scrollingElement;
		public readonly styleSheets;
		public string title;
		public readonly visibilityState;
		public string vlinkColor;
		public readonly webkitCurrentFullScreenElement;
		public readonly webkitFullscreenElement;
		public readonly webkitFullscreenEnabled;
		public readonly webkitIsFullScreen;
		public readonly xmlEncoding;
		public bool xmlStandalone;
		public Any<string, null> xmlVersion;
		public Func<, object> listener;
		public bool useCapture;
		public Node adoptNode(Node source)
		{
			throw new System.NotImplementedException();
		}
		public void captureEvents()
		{
			throw new System.NotImplementedException();
		}
		public Range caretRangeFromPoint(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public Attr createAttribute(string name)
		{
			throw new System.NotImplementedException();
		}
		public Attr createAttributeNS(Any<string, null> namespaceURI, string qualifiedName)
		{
			throw new System.NotImplementedException();
		}
		public CDATASection createCDATASection(string data)
		{
			throw new System.NotImplementedException();
		}
		public Comment createComment(string data)
		{
			throw new System.NotImplementedException();
		}
		public DocumentFragment createDocumentFragment()
		{
			throw new System.NotImplementedException();
		}
		public object createElement(object tagName)
		{
			throw new System.NotImplementedException();
		}
		public HTMLElement createElement(string tagName)
		{
			throw new System.NotImplementedException();
		}
		public object createElementNS(object namespaceURI)
		{
			throw new System.NotImplementedException();
		}
		public Element createElementNS(Any<string, null> namespaceURI, string qualifiedName)
		{
			throw new System.NotImplementedException();
		}
		public XPathExpression createExpression(string expression, XPathNSResolver resolver)
		{
			throw new System.NotImplementedException();
		}
		public XPathNSResolver createNSResolver(Node nodeResolver)
		{
			throw new System.NotImplementedException();
		}
		public NodeIterator createNodeIterator(Node root, float whatToShow = default(float), NodeFilter filter = default(NodeFilter), bool entityReferenceExpansion = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public ProcessingInstruction createProcessingInstruction(string target, string data)
		{
			throw new System.NotImplementedException();
		}
		public Range createRange()
		{
			throw new System.NotImplementedException();
		}
		public Text createTextNode(string data)
		{
			throw new System.NotImplementedException();
		}
		public Touch createTouch(IWindow view, EventTarget target, float identifier, float pageX, float pageY, float screenX, float screenY)
		{
			throw new System.NotImplementedException();
		}
		public TouchList createTouchList(params Touch[] touches)
		{
			throw new System.NotImplementedException();
		}
		public TreeWalker createTreeWalker(Node root, float whatToShow = default(float), NodeFilter filter = default(NodeFilter), bool entityReferenceExpansion = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public Element elementFromPoint(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public XPathResult evaluate(string expression, Node contextNode, XPathNSResolver resolver, float type, XPathResult result)
		{
			throw new System.NotImplementedException();
		}
		public bool execCommand(string commandId, bool showUI = default(bool), object value = default(object))
		{
			throw new System.NotImplementedException();
		}
		public bool execCommandShowHelp(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public void exitFullscreen()
		{
			throw new System.NotImplementedException();
		}
		public void exitPointerLock()
		{
			throw new System.NotImplementedException();
		}
		public void focus()
		{
			throw new System.NotImplementedException();
		}
		public Any<HTMLElement, null> getElementById(string elementId)
		{
			throw new System.NotImplementedException();
		}
		public HTMLCollectionOf<Element> getElementsByClassName(string classNames)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<HTMLElement> getElementsByName(string elementName)
		{
			throw new System.NotImplementedException();
		}
		public object getElementsByTagName(object tagname)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<Element> getElementsByTagName(string tagname)
		{
			throw new System.NotImplementedException();
		}
		public object getElementsByTagNameNS(object namespaceURI)
		{
			throw new System.NotImplementedException();
		}
		public HTMLCollectionOf<Element> getElementsByTagNameNS(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public Selection getSelection()
		{
			throw new System.NotImplementedException();
		}
		public bool hasFocus()
		{
			throw new System.NotImplementedException();
		}
		public Node importNode(Node importedNode, bool deep)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<Element> msElementsFromPoint(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<Element> msElementsFromRect(float left, float top, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public Document open(string url = default(string), string name = default(string), string features = default(string), bool replace = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public bool queryCommandEnabled(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public bool queryCommandIndeterm(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public bool queryCommandState(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public bool queryCommandSupported(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public string queryCommandText(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public string queryCommandValue(string commandId)
		{
			throw new System.NotImplementedException();
		}
		public void releaseEvents()
		{
			throw new System.NotImplementedException();
		}
		public void updateSettings()
		{
			throw new System.NotImplementedException();
		}
		public void webkitCancelFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public void webkitExitFullscreen()
		{
			throw new System.NotImplementedException();
		}
		public void write(params string[] content)
		{
			throw new System.NotImplementedException();
		}
		public void writeln(params string[] content)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Document_0_
	{
		public Document prototype;
		public Document new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DocumentFragment : Node, NodeSelector, ParentNode
	{
		protected DocumentFragment() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DocumentFragment_0_
	{
		public DocumentFragment prototype;
		public DocumentFragment new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DocumentType : Node, ChildNode
	{
		protected DocumentType() : base()
		{
			
		}
		public readonly entities;
		public readonly internalSubset;
		public readonly name;
		public readonly notations;
		public readonly publicId;
		public readonly systemId;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DocumentType_0_
	{
		public DocumentType prototype;
		public DocumentType new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DragEvent : MouseEvent
	{
		protected DragEvent() : base()
		{
			
		}
		public readonly dataTransfer;
		public void initDragEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg, DataTransfer dataTransferArg)
		{
			throw new System.NotImplementedException();
		}
		public void msConvertURL(File file, string targetType, string targetURL = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class DragEvent_0_
	{
		public DragEvent prototype;
		public DragEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DynamicsCompressorNode : AudioNode
	{
		protected DynamicsCompressorNode() : base()
		{
			
		}
		public readonly attack;
		public readonly knee;
		public readonly ratio;
		public readonly reduction;
		public readonly release;
		public readonly threshold;
	}

		public class DynamicsCompressorNode_0_
	{
		public DynamicsCompressorNode prototype;
		public DynamicsCompressorNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class EXT_frag_depth
	{
		protected EXT_frag_depth()
		{
			
		}
	}

		public class EXT_frag_depth_0_
	{
		public EXT_frag_depth prototype;
		public EXT_frag_depth new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class EXT_texture_filter_anisotropic
	{
		protected EXT_texture_filter_anisotropic()
		{
			
		}
		public readonly MAX_TEXTURE_MAX_ANISOTROPY_EXT;
		public readonly TEXTURE_MAX_ANISOTROPY_EXT;
	}

		public class EXT_texture_filter_anisotropic_0_
	{
		public EXT_texture_filter_anisotropic prototype;
		public float MAX_TEXTURE_MAX_ANISOTROPY_EXT;
		public float TEXTURE_MAX_ANISOTROPY_EXT;
		public EXT_texture_filter_anisotropic new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Element : Node, GlobalEventHandlers, ElementTraversal, NodeSelector, ChildNode, ParentNode
	{
		protected Element() : base()
		{
			
		}
		public readonly classList;
		public string className;
		public readonly clientHeight;
		public readonly clientLeft;
		public readonly clientTop;
		public readonly clientWidth;
		public string id;
		public float msContentZoomFactor;
		public readonly msRegionOverflow;
		public Func<, object> onariarequest;
		public WheelEvent ev;
		public object any;
		public Func<, object> oncommand;
		public Func<, object> ongotpointercapture;
		public Func<, object> onlostpointercapture;
		public Func<, object> onmsgesturechange;
		public Func<, object> onmsgesturedoubletap;
		public Func<, object> onmsgestureend;
		public Func<, object> onmsgesturehold;
		public Func<, object> onmsgesturestart;
		public Func<, object> onmsgesturetap;
		public Func<, object> onmsgotpointercapture;
		public Func<, object> onmsinertiastart;
		public Func<, object> onmslostpointercapture;
		public Func<, object> onmspointercancel;
		public Func<, object> onmspointerdown;
		public Func<, object> onmspointerenter;
		public Func<, object> onmspointerleave;
		public Func<, object> onmspointermove;
		public Func<, object> onmspointerout;
		public Func<, object> onmspointerover;
		public Func<, object> onmspointerup;
		public Func<TouchEvent, object> ontouchcancel;
		public Func<TouchEvent, object> ontouchend;
		public Func<TouchEvent, object> ontouchmove;
		public Func<TouchEvent, object> ontouchstart;
		public Func<, object> onwebkitfullscreenchange;
		public Func<, object> onwebkitfullscreenerror;
		public readonly prefix;
		public readonly scrollHeight;
		public float scrollLeft;
		public float scrollTop;
		public readonly scrollWidth;
		public readonly tagName;
		public string innerHTML;
		public Func<, object> listener;
		public bool useCapture;
		public Any<string, null> getAttribute(string name)
		{
			throw new System.NotImplementedException();
		}
		public string getAttributeNS(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public Attr getAttributeNode(string name)
		{
			throw new System.NotImplementedException();
		}
		public Attr getAttributeNodeNS(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public ClientRect getBoundingClientRect()
		{
			throw new System.NotImplementedException();
		}
		public ClientRectList getClientRects()
		{
			throw new System.NotImplementedException();
		}
		public object getElementsByTagName(object name)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<Element> getElementsByTagName(string name)
		{
			throw new System.NotImplementedException();
		}
		public object getElementsByTagNameNS(object namespaceURI)
		{
			throw new System.NotImplementedException();
		}
		public HTMLCollectionOf<Element> getElementsByTagNameNS(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public bool hasAttribute(string name)
		{
			throw new System.NotImplementedException();
		}
		public bool hasAttributeNS(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public MSRangeCollection msGetRegionContent()
		{
			throw new System.NotImplementedException();
		}
		public ClientRect msGetUntransformedBounds()
		{
			throw new System.NotImplementedException();
		}
		public bool msMatchesSelector(string selectors)
		{
			throw new System.NotImplementedException();
		}
		public void msReleasePointerCapture(float pointerId)
		{
			throw new System.NotImplementedException();
		}
		public void msSetPointerCapture(float pointerId)
		{
			throw new System.NotImplementedException();
		}
		public void msZoomTo(MsZoomToOptions args)
		{
			throw new System.NotImplementedException();
		}
		public void releasePointerCapture(float pointerId)
		{
			throw new System.NotImplementedException();
		}
		public void removeAttribute(string name = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void removeAttributeNS(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public Attr removeAttributeNode(Attr oldAttr)
		{
			throw new System.NotImplementedException();
		}
		public void requestFullscreen()
		{
			throw new System.NotImplementedException();
		}
		public void requestPointerLock()
		{
			throw new System.NotImplementedException();
		}
		public void setAttribute(string name, string value)
		{
			throw new System.NotImplementedException();
		}
		public void setAttributeNS(string namespaceURI, string qualifiedName, string value)
		{
			throw new System.NotImplementedException();
		}
		public Attr setAttributeNode(Attr newAttr)
		{
			throw new System.NotImplementedException();
		}
		public Attr setAttributeNodeNS(Attr newAttr)
		{
			throw new System.NotImplementedException();
		}
		public void setPointerCapture(float pointerId)
		{
			throw new System.NotImplementedException();
		}
		public bool webkitMatchesSelector(string selectors)
		{
			throw new System.NotImplementedException();
		}
		public void webkitRequestFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public void webkitRequestFullscreen()
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<Element> getElementsByClassName(string classNames)
		{
			throw new System.NotImplementedException();
		}
		public bool matches(string selector)
		{
			throw new System.NotImplementedException();
		}
		public Any<Element, null> closest(string selector)
		{
			throw new System.NotImplementedException();
		}
		public void scrollIntoView(Any<bool, ScrollIntoViewOptions> arg = default(Any<bool, ScrollIntoViewOptions>))
		{
			throw new System.NotImplementedException();
		}
		public void scroll(ScrollToOptions options = default(ScrollToOptions))
		{
			throw new System.NotImplementedException();
		}
		public void scroll(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void scrollTo(ScrollToOptions options = default(ScrollToOptions))
		{
			throw new System.NotImplementedException();
		}
		public void scrollTo(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void scrollBy(ScrollToOptions options = default(ScrollToOptions))
		{
			throw new System.NotImplementedException();
		}
		public void scrollBy(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public Any<Element, null> insertAdjacentElement(string position, Element insertedElement)
		{
			throw new System.NotImplementedException();
		}
		public void insertAdjacentHTML(string where, string html)
		{
			throw new System.NotImplementedException();
		}
		public void insertAdjacentText(string where, string text)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Element_0_
	{
		public Element prototype;
		public Element new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ErrorEvent : Event
	{
		protected ErrorEvent() : base()
		{
			
		}
		public readonly colno;
		public readonly error;
		public readonly filename;
		public readonly lineno;
		public readonly message;
		public void initErrorEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string messageArg, string filenameArg, float linenoArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ErrorEvent_0_
	{
		public ErrorEvent prototype;
		public ErrorEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Event
	{
		protected Event()
		{
			
		}
		public readonly bubbles;
		public bool cancelBubble;
		public readonly cancelable;
		public readonly currentTarget;
		public readonly defaultPrevented;
		public readonly eventPhase;
		public readonly isTrusted;
		public bool returnValue;
		public readonly srcElement;
		public readonly target;
		public readonly timeStamp;
		public readonly type;
		public readonly AT_TARGET;
		public readonly BUBBLING_PHASE;
		public readonly CAPTURING_PHASE;
		public void initEvent(string eventTypeArg, bool canBubbleArg, bool cancelableArg)
		{
			throw new System.NotImplementedException();
		}
		public void preventDefault()
		{
			throw new System.NotImplementedException();
		}
		public void stopImmediatePropagation()
		{
			throw new System.NotImplementedException();
		}
		public void stopPropagation()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Event_0_
	{
		public Event prototype;
		public float AT_TARGET;
		public float BUBBLING_PHASE;
		public float CAPTURING_PHASE;
		public Event new(string type, EventInit eventInitDict = default(EventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class EventTarget
	{
		protected EventTarget()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener = default(EventListenerOrEventListenerObject), bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public bool dispatchEvent(Event evt)
		{
			throw new System.NotImplementedException();
		}
		public void removeEventListener(string type, EventListenerOrEventListenerObject listener = default(EventListenerOrEventListenerObject), bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class EventTarget_0_
	{
		public EventTarget prototype;
		public EventTarget new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class External
	{
		protected External()
		{
			
		}
	}

		public class External_0_
	{
		public External prototype;
		public External new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class File : Blob
	{
		protected File() : base()
		{
			
		}
		public readonly lastModifiedDate;
		public readonly name;
		public readonly webkitRelativePath;
	}

		public class File_0_
	{
		public File prototype;
		public string filename;
		public FilePropertyBag properties;
		public object new(Func<object, Any<Bridge.Html5.ArrayBufferView, Blob, string>> parts)
		{
			throw new System.NotImplementedException();
		}
	}

		public class FileList
	{
		protected FileList()
		{
			
		}
		public readonly length;
		public float index;
		public File item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class FileList_0_
	{
		public FileList prototype;
		public FileList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class FileReader : EventTarget, MSBaseReader
	{
		protected FileReader() : base()
		{
			
		}
		public readonly error;
		public void readAsArrayBuffer(Blob blob)
		{
			throw new System.NotImplementedException();
		}
		public void readAsBinaryString(Blob blob)
		{
			throw new System.NotImplementedException();
		}
		public void readAsDataURL(Blob blob)
		{
			throw new System.NotImplementedException();
		}
		public void readAsText(Blob blob, string encoding = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class FileReader_0_
	{
		public FileReader prototype;
		public FileReader new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class FocusEvent : UIEvent
	{
		protected FocusEvent() : base()
		{
			
		}
		public readonly relatedTarget;
		public void initFocusEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, EventTarget relatedTargetArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class FocusEvent_0_
	{
		public FocusEvent prototype;
		public FocusEvent new(string typeArg, FocusEventInit eventInitDict = default(FocusEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class FormData
	{
		protected FormData()
		{
			
		}
		public void append(object name, object value, string blobName = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class FormData_0_
	{
		public FormData prototype;
		public FormData new(HTMLFormElement form = default(HTMLFormElement))
		{
			throw new System.NotImplementedException();
		}
	}

		public class GainNode : AudioNode
	{
		protected GainNode() : base()
		{
			
		}
		public readonly gain;
	}

		public class GainNode_0_
	{
		public GainNode prototype;
		public GainNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Gamepad
	{
		protected Gamepad()
		{
			
		}
		public readonly axes;
		public readonly buttons;
		public readonly connected;
		public readonly id;
		public readonly index;
		public readonly mapping;
		public readonly timestamp;
	}

		public class Gamepad_0_
	{
		public Gamepad prototype;
		public Gamepad new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class GamepadButton
	{
		protected GamepadButton()
		{
			
		}
		public readonly pressed;
		public readonly value;
	}

		public class GamepadButton_0_
	{
		public GamepadButton prototype;
		public GamepadButton new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class GamepadEvent : Event
	{
		protected GamepadEvent() : base()
		{
			
		}
		public readonly gamepad;
	}

		public class GamepadEvent_0_
	{
		public GamepadEvent prototype;
		public GamepadEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Geolocation
	{
		protected Geolocation()
		{
			
		}
		public void clearWatch(float watchId)
		{
			throw new System.NotImplementedException();
		}
		public void getCurrentPosition(PositionCallback successCallback, PositionErrorCallback errorCallback = default(PositionErrorCallback), PositionOptions options = default(PositionOptions))
		{
			throw new System.NotImplementedException();
		}
		public float watchPosition(PositionCallback successCallback, PositionErrorCallback errorCallback = default(PositionErrorCallback), PositionOptions options = default(PositionOptions))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Geolocation_0_
	{
		public Geolocation prototype;
		public Geolocation new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAllCollection : HTMLCollection
	{
		protected HTMLAllCollection() : base()
		{
			
		}
		public Element namedItem(string name)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAllCollection_0_
	{
		public HTMLAllCollection prototype;
		public HTMLAllCollection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAnchorElement : HTMLElement
	{
		protected HTMLAnchorElement() : base()
		{
			
		}
		public string Methods;
		public string charset;
		public string coords;
		public string download;
		public string hash;
		public string host;
		public string hostname;
		public string href;
		public string hreflang;
		public readonly mimeType;
		public string name;
		public readonly nameProp;
		public string pathname;
		public string port;
		public string protocol;
		public readonly protocolLong;
		public string rel;
		public string rev;
		public string search;
		public string shape;
		public string target;
		public string text;
		public string type;
		public string urn;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAnchorElement_0_
	{
		public HTMLAnchorElement prototype;
		public HTMLAnchorElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAppletElement : HTMLElement
	{
		protected HTMLAppletElement() : base()
		{
			
		}
		public readonly BaseHref;
		public string align;
		public string alt;
		public string altHtml;
		public string archive;
		public string border;
		public string code;
		public string codeBase;
		public string codeType;
		public readonly contentDocument;
		public string data;
		public readonly form;
		public string height;
		public float hspace;
		public string name;
				public Any<string, null> @object;
		public string standby;
		public string type;
		public string useMap;
		public float vspace;
		public float width;
	}

		public class HTMLAppletElement_0_
	{
		public HTMLAppletElement prototype;
		public HTMLAppletElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAreaElement : HTMLElement
	{
		protected HTMLAreaElement() : base()
		{
			
		}
		public string alt;
		public string coords;
		public string download;
		public string hash;
		public string host;
		public string hostname;
		public string href;
		public bool noHref;
		public string pathname;
		public string port;
		public string protocol;
		public string rel;
		public string search;
		public string shape;
		public string target;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAreaElement_0_
	{
		public HTMLAreaElement prototype;
		public HTMLAreaElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAreasCollection : HTMLCollection
	{
		protected HTMLAreasCollection() : base()
		{
			
		}
		public void add(HTMLElement element, Any<HTMLElement, float> before = default(Any<HTMLElement, float>))
		{
			throw new System.NotImplementedException();
		}
		public void remove(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAreasCollection_0_
	{
		public HTMLAreasCollection prototype;
		public HTMLAreasCollection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLAudioElement : HTMLMediaElement
	{
		protected HTMLAudioElement() : base()
		{
			
		}
	}

		public class HTMLAudioElement_0_
	{
		public HTMLAudioElement prototype;
		public HTMLAudioElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLBRElement : HTMLElement
	{
		protected HTMLBRElement() : base()
		{
			
		}
		public string clear;
	}

		public class HTMLBRElement_0_
	{
		public HTMLBRElement prototype;
		public HTMLBRElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLBaseElement : HTMLElement
	{
		protected HTMLBaseElement() : base()
		{
			
		}
		public string href;
		public string target;
	}

		public class HTMLBaseElement_0_
	{
		public HTMLBaseElement prototype;
		public HTMLBaseElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLBaseFontElement : HTMLElement, DOML2DeprecatedColorProperty
	{
		protected HTMLBaseFontElement() : base()
		{
			
		}
		public string face;
		public float size;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLBaseFontElement_0_
	{
		public HTMLBaseFontElement prototype;
		public HTMLBaseFontElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLBodyElement : HTMLElement
	{
		protected HTMLBodyElement() : base()
		{
			
		}
		public object aLink;
		public string background;
		public object bgColor;
		public string bgProperties;
		public object link;
		public bool noWrap;
		public Func<, object> onafterprint;
		public WheelEvent ev;
		public object any;
		public Func<, object> onbeforeprint;
		public Func<, object> onbeforeunload;
		public Func<, object> onblur;
		public Func<, object> onerror;
		public Func<, object> onfocus;
		public Func<, object> onhashchange;
		public Func<, object> onload;
		public Func<, object> onmessage;
		public Func<, object> onoffline;
		public Func<, object> ononline;
		public Func<, object> onorientationchange;
		public Func<, object> onpagehide;
		public Func<, object> onpageshow;
		public Func<, object> onpopstate;
		public Func<, object> onresize;
		public Func<, object> onstorage;
		public Func<, object> onunload;
		public object text;
		public object vLink;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLBodyElement_0_
	{
		public HTMLBodyElement prototype;
		public HTMLBodyElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLButtonElement : HTMLElement
	{
		protected HTMLButtonElement() : base()
		{
			
		}
		public bool autofocus;
		public bool disabled;
		public readonly form;
		public string formAction;
		public string formEnctype;
		public string formMethod;
		public string formNoValidate;
		public string formTarget;
		public string name;
		public object status;
		public string type;
		public readonly validationMessage;
		public readonly validity;
		public string value;
		public readonly willValidate;
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public void setCustomValidity(string error)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLButtonElement_0_
	{
		public HTMLButtonElement prototype;
		public HTMLButtonElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLCanvasElement : HTMLElement
	{
		protected HTMLCanvasElement() : base()
		{
			
		}
		public float height;
		public float width;
		public WebGLContextAttributes contextAttributes;
		public object getContext(object contextId)
		{
			throw new System.NotImplementedException();
		}
		public Any<CanvasRenderingContext2D, IWebGLRenderingContext, null> getContext(string contextId, ContextAttributes_1_ contextAttributes = default(ContextAttributes_1_))
		{
			throw new System.NotImplementedException();
		}
		public Blob msToBlob()
		{
			throw new System.NotImplementedException();
		}
		public string toDataURL(string type = default(string), params object[][] args)
		{
			throw new System.NotImplementedException();
		}
		public void toBlob(Action<Any<Blob, null>> callback, string type = default(string), params object[][] arguments)
		{
			throw new System.NotImplementedException();
		}

				public class ContextAttributes_0_
		{
		}

				public class ContextAttributes_1_
		{
		}
	}

		public class HTMLCanvasElement_0_
	{
		public HTMLCanvasElement prototype;
		public HTMLCanvasElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLCollection
	{
		protected HTMLCollection()
		{
			
		}
		public readonly length;
		public float index;
		public Element item(float index)
		{
			throw new System.NotImplementedException();
		}
		public Element namedItem(string name)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLCollection_0_
	{
		public HTMLCollection prototype;
		public HTMLCollection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLDListElement : HTMLElement
	{
		protected HTMLDListElement() : base()
		{
			
		}
		public bool compact;
	}

		public class HTMLDListElement_0_
	{
		public HTMLDListElement prototype;
		public HTMLDListElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLDataListElement : HTMLElement
	{
		protected HTMLDataListElement() : base()
		{
			
		}
		public HTMLCollectionOf<HTMLOptionElement> options;
	}

		public class HTMLDataListElement_0_
	{
		public HTMLDataListElement prototype;
		public HTMLDataListElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLDirectoryElement : HTMLElement
	{
		protected HTMLDirectoryElement() : base()
		{
			
		}
		public bool compact;
	}

		public class HTMLDirectoryElement_0_
	{
		public HTMLDirectoryElement prototype;
		public HTMLDirectoryElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLDivElement : HTMLElement
	{
		protected HTMLDivElement() : base()
		{
			
		}
		public string align;
		public bool noWrap;
	}

		public class HTMLDivElement_0_
	{
		public HTMLDivElement prototype;
		public HTMLDivElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLDocument : Document
	{
		protected HTMLDocument() : base()
		{
			
		}
	}

		public class HTMLDocument_0_
	{
		public HTMLDocument prototype;
		public HTMLDocument new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLElement : Element
	{
		protected HTMLElement() : base()
		{
			
		}
		public string accessKey;
		public readonly children;
		public string contentEditable;
		public readonly dataset;
		public string dir;
		public bool draggable;
		public bool hidden;
		public bool hideFocus;
		public string innerHTML;
		public string innerText;
		public readonly isContentEditable;
		public string lang;
		public readonly offsetHeight;
		public readonly offsetLeft;
		public readonly offsetParent;
		public readonly offsetTop;
		public readonly offsetWidth;
		public Func<, object> onabort;
		public WheelEvent ev;
		public object any;
		public Func<, object> onactivate;
		public Func<, object> onbeforeactivate;
		public Func<, object> onbeforecopy;
		public Func<, object> onbeforecut;
		public Func<, object> onbeforedeactivate;
		public Func<, object> onbeforepaste;
		public Func<, object> onblur;
		public Func<, object> oncanplay;
		public Func<, object> oncanplaythrough;
		public Func<, object> onchange;
		public Func<, object> onclick;
		public Func<, object> oncontextmenu;
		public Func<, object> oncopy;
		public Func<, object> oncuechange;
		public Func<, object> oncut;
		public Func<, object> ondblclick;
		public Func<, object> ondeactivate;
		public Func<, object> ondrag;
		public Func<, object> ondragend;
		public Func<, object> ondragenter;
		public Func<, object> ondragleave;
		public Func<, object> ondragover;
		public Func<, object> ondragstart;
		public Func<, object> ondrop;
		public Func<, object> ondurationchange;
		public Func<, object> onemptied;
		public Func<, object> onended;
		public Func<, object> onerror;
		public Func<, object> onfocus;
		public Func<, object> oninput;
		public Func<, object> oninvalid;
		public Func<, object> onkeydown;
		public Func<, object> onkeypress;
		public Func<, object> onkeyup;
		public Func<, object> onload;
		public Func<, object> onloadeddata;
		public Func<, object> onloadedmetadata;
		public Func<, object> onloadstart;
		public Func<, object> onmousedown;
		public Func<, object> onmouseenter;
		public Func<, object> onmouseleave;
		public Func<, object> onmousemove;
		public Func<, object> onmouseout;
		public Func<, object> onmouseover;
		public Func<, object> onmouseup;
		public Func<, object> onmousewheel;
		public Func<, object> onmscontentzoom;
		public Func<, object> onmsmanipulationstatechanged;
		public Func<, object> onpaste;
		public Func<, object> onpause;
		public Func<, object> onplay;
		public Func<, object> onplaying;
		public Func<, object> onprogress;
		public Func<, object> onratechange;
		public Func<, object> onreset;
		public Func<, object> onscroll;
		public Func<, object> onseeked;
		public Func<, object> onseeking;
		public Func<, object> onselect;
		public Func<, object> onselectstart;
		public Func<, object> onstalled;
		public Func<, object> onsubmit;
		public Func<, object> onsuspend;
		public Func<, object> ontimeupdate;
		public Func<, object> onvolumechange;
		public Func<, object> onwaiting;
		public string outerHTML;
		public string outerText;
		public bool spellcheck;
		public readonly style;
		public float tabIndex;
		public string title;
		public Func<, object> listener;
		public bool useCapture;
		public void blur()
		{
			throw new System.NotImplementedException();
		}
		public void click()
		{
			throw new System.NotImplementedException();
		}
		public bool dragDrop()
		{
			throw new System.NotImplementedException();
		}
		public void focus()
		{
			throw new System.NotImplementedException();
		}
		public MSInputMethodContext msGetInputContext()
		{
			throw new System.NotImplementedException();
		}
		public void setActive()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLElement_0_
	{
		public HTMLElement prototype;
		public HTMLElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLEmbedElement : HTMLElement, GetSVGDocument
	{
		protected HTMLEmbedElement() : base()
		{
			
		}
		public string height;
		public object hidden;
		public bool msPlayToDisabled;
		public string msPlayToPreferredSourceUri;
		public bool msPlayToPrimary;
		public readonly msPlayToSource;
		public string name;
		public readonly palette;
		public readonly pluginspage;
		public readonly readyState;
		public string src;
		public string units;
		public string width;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLEmbedElement_0_
	{
		public HTMLEmbedElement prototype;
		public HTMLEmbedElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFieldSetElement : HTMLElement
	{
		protected HTMLFieldSetElement() : base()
		{
			
		}
		public string align;
		public bool disabled;
		public readonly form;
		public readonly validationMessage;
		public readonly validity;
		public readonly willValidate;
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public void setCustomValidity(string error)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFieldSetElement_0_
	{
		public HTMLFieldSetElement prototype;
		public HTMLFieldSetElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFontElement : HTMLElement, DOML2DeprecatedColorProperty, DOML2DeprecatedSizeProperty
	{
		protected HTMLFontElement() : base()
		{
			
		}
		public string face;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFontElement_0_
	{
		public HTMLFontElement prototype;
		public HTMLFontElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFormElement : HTMLElement
	{
		protected HTMLFormElement() : base()
		{
			
		}
		public string acceptCharset;
		public string action;
		public string autocomplete;
		public readonly elements;
		public string encoding;
		public string enctype;
		public readonly length;
		public string method;
		public string name;
		public bool noValidate;
		public string target;
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public object item(object name = default(object), object index = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object namedItem(string name)
		{
			throw new System.NotImplementedException();
		}
		public void reset()
		{
			throw new System.NotImplementedException();
		}
		public void submit()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFormElement_0_
	{
		public HTMLFormElement prototype;
		public HTMLFormElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFrameElement : HTMLElement, GetSVGDocument
	{
		protected HTMLFrameElement() : base()
		{
			
		}
		public string border;
		public object borderColor;
		public readonly contentDocument;
		public readonly contentWindow;
		public string frameBorder;
		public object frameSpacing;
		public Any<string, float> height;
		public string longDesc;
		public string marginHeight;
		public string marginWidth;
		public string name;
		public bool noResize;
		public Func<, object> onload;
		public WheelEvent ev;
		public object any;
		public string scrolling;
		public string src;
		public Any<string, float> width;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFrameElement_0_
	{
		public HTMLFrameElement prototype;
		public HTMLFrameElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFrameSetElement : HTMLElement
	{
		protected HTMLFrameSetElement() : base()
		{
			
		}
		public string border;
		public object borderColor;
		public string cols;
		public string frameBorder;
		public object frameSpacing;
		public string name;
		public Func<, object> onafterprint;
		public WheelEvent ev;
		public object any;
		public Func<, object> onbeforeprint;
		public Func<, object> onbeforeunload;
		public Func<, object> onblur;
		public Func<, object> onerror;
		public Func<, object> onfocus;
		public Func<, object> onhashchange;
		public Func<, object> onload;
		public Func<, object> onmessage;
		public Func<, object> onoffline;
		public Func<, object> ononline;
		public Func<, object> onorientationchange;
		public Func<, object> onpagehide;
		public Func<, object> onpageshow;
		public Func<, object> onresize;
		public Func<, object> onstorage;
		public Func<, object> onunload;
		public string rows;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLFrameSetElement_0_
	{
		public HTMLFrameSetElement prototype;
		public HTMLFrameSetElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLHRElement : HTMLElement, DOML2DeprecatedColorProperty, DOML2DeprecatedSizeProperty
	{
		protected HTMLHRElement() : base()
		{
			
		}
		public string align;
		public bool noShade;
		public float width;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLHRElement_0_
	{
		public HTMLHRElement prototype;
		public HTMLHRElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLHeadElement : HTMLElement
	{
		protected HTMLHeadElement() : base()
		{
			
		}
		public string profile;
	}

		public class HTMLHeadElement_0_
	{
		public HTMLHeadElement prototype;
		public HTMLHeadElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLHeadingElement : HTMLElement
	{
		protected HTMLHeadingElement() : base()
		{
			
		}
		public string align;
	}

		public class HTMLHeadingElement_0_
	{
		public HTMLHeadingElement prototype;
		public HTMLHeadingElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLHtmlElement : HTMLElement
	{
		protected HTMLHtmlElement() : base()
		{
			
		}
		public string version;
	}

		public class HTMLHtmlElement_0_
	{
		public HTMLHtmlElement prototype;
		public HTMLHtmlElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLIFrameElement : HTMLElement, GetSVGDocument
	{
		protected HTMLIFrameElement() : base()
		{
			
		}
		public string align;
		public bool allowFullscreen;
		public string border;
		public readonly contentDocument;
		public readonly contentWindow;
		public string frameBorder;
		public object frameSpacing;
		public string height;
		public float hspace;
		public string longDesc;
		public string marginHeight;
		public string marginWidth;
		public string name;
		public bool noResize;
		public Func<, object> onload;
		public WheelEvent ev;
		public object any;
		public readonly sandbox;
		public string scrolling;
		public string src;
		public float vspace;
		public string width;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLIFrameElement_0_
	{
		public HTMLIFrameElement prototype;
		public HTMLIFrameElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLImageElement : HTMLElement
	{
		protected HTMLImageElement() : base()
		{
			
		}
		public string align;
		public string alt;
		public string border;
		public readonly complete;
		public string crossOrigin;
		public readonly currentSrc;
		public float height;
		public float hspace;
		public bool isMap;
		public string longDesc;
		public string lowsrc;
		public bool msPlayToDisabled;
		public string msPlayToPreferredSourceUri;
		public bool msPlayToPrimary;
		public readonly msPlayToSource;
		public string name;
		public readonly naturalHeight;
		public readonly naturalWidth;
		public string sizes;
		public string src;
		public string srcset;
		public string useMap;
		public float vspace;
		public float width;
		public readonly x;
		public readonly y;
		public object msGetAsCastingSource()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLImageElement_0_
	{
		public HTMLImageElement prototype;
		public HTMLImageElement new()
		{
			throw new System.NotImplementedException();
		}
		public HTMLImageElement create()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLInputElement : HTMLElement
	{
		protected HTMLInputElement() : base()
		{
			
		}
		public string accept;
		public string align;
		public string alt;
		public string autocomplete;
		public bool autofocus;
		public string border;
		public bool checked;
		public readonly complete;
		public bool defaultChecked;
		public string defaultValue;
		public bool disabled;
		public readonly files;
		public readonly form;
		public string formAction;
		public string formEnctype;
		public string formMethod;
		public string formNoValidate;
		public string formTarget;
		public string height;
		public float hspace;
		public bool indeterminate;
		public readonly list;
		public string max;
		public float maxLength;
		public string min;
		public bool multiple;
		public string name;
		public string pattern;
		public string placeholder;
		public bool readOnly;
		public bool required;
		public string selectionDirection;
		public float selectionEnd;
		public float selectionStart;
		public float size;
		public string src;
		public bool status;
		public string step;
		public string type;
		public string useMap;
		public readonly validationMessage;
		public readonly validity;
		public string value;
		public Date valueAsDate;
		public float valueAsNumber;
		public float vspace;
		public bool webkitdirectory;
		public string width;
		public readonly willValidate;
		public float minLength;
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public void select()
		{
			throw new System.NotImplementedException();
		}
		public void setCustomValidity(string error)
		{
			throw new System.NotImplementedException();
		}
		public void setSelectionRange(float start = default(float), float end = default(float), string direction = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void stepDown(float n = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void stepUp(float n = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLInputElement_0_
	{
		public HTMLInputElement prototype;
		public HTMLInputElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLLIElement : HTMLElement
	{
		protected HTMLLIElement() : base()
		{
			
		}
		public string type;
		public float value;
	}

		public class HTMLLIElement_0_
	{
		public HTMLLIElement prototype;
		public HTMLLIElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLLabelElement : HTMLElement
	{
		protected HTMLLabelElement() : base()
		{
			
		}
		public readonly form;
		public string htmlFor;
	}

		public class HTMLLabelElement_0_
	{
		public HTMLLabelElement prototype;
		public HTMLLabelElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLLegendElement : HTMLElement
	{
		protected HTMLLegendElement() : base()
		{
			
		}
		public string align;
		public readonly form;
	}

		public class HTMLLegendElement_0_
	{
		public HTMLLegendElement prototype;
		public HTMLLegendElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLLinkElement : HTMLElement, LinkStyle
	{
		protected HTMLLinkElement() : base()
		{
			
		}
		public string charset;
		public bool disabled;
		public string href;
		public string hreflang;
		public string media;
		public string rel;
		public string rev;
		public string target;
		public string type;
		public string integrity;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLLinkElement_0_
	{
		public HTMLLinkElement prototype;
		public HTMLLinkElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMapElement : HTMLElement
	{
		protected HTMLMapElement() : base()
		{
			
		}
		public readonly areas;
		public string name;
	}

		public class HTMLMapElement_0_
	{
		public HTMLMapElement prototype;
		public HTMLMapElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMarqueeElement : HTMLElement
	{
		protected HTMLMarqueeElement() : base()
		{
			
		}
		public string behavior;
		public object bgColor;
		public string direction;
		public string height;
		public float hspace;
		public float loop;
		public Func<, object> onbounce;
		public WheelEvent ev;
		public object any;
		public Func<, object> onfinish;
		public Func<, object> onstart;
		public float scrollAmount;
		public float scrollDelay;
		public bool trueSpeed;
		public float vspace;
		public string width;
		public Func<, object> listener;
		public bool useCapture;
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMarqueeElement_0_
	{
		public HTMLMarqueeElement prototype;
		public HTMLMarqueeElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMediaElement : HTMLElement
	{
		protected HTMLMediaElement() : base()
		{
			
		}
		public readonly audioTracks;
		public bool autoplay;
		public readonly buffered;
		public bool controls;
		public string crossOrigin;
		public readonly currentSrc;
		public float currentTime;
		public bool defaultMuted;
		public float defaultPlaybackRate;
		public readonly duration;
		public readonly ended;
		public readonly error;
		public bool loop;
		public readonly mediaKeys;
		public string msAudioCategory;
		public string msAudioDeviceType;
		public readonly msGraphicsTrustStatus;
		public readonly msKeys;
		public bool msPlayToDisabled;
		public string msPlayToPreferredSourceUri;
		public bool msPlayToPrimary;
		public readonly msPlayToSource;
		public bool msRealTime;
		public bool muted;
		public readonly networkState;
		public Func<, object> onencrypted;
		public WheelEvent ev;
		public object any;
		public Func<, object> onmsneedkey;
		public readonly paused;
		public float playbackRate;
		public readonly played;
		public string preload;
		public float readyState;
		public readonly seekable;
		public readonly seeking;
		public string src;
		public Any<MediaStream, null> srcObject;
		public readonly textTracks;
		public readonly videoTracks;
		public float volume;
		public readonly HAVE_CURRENT_DATA;
		public readonly HAVE_ENOUGH_DATA;
		public readonly HAVE_FUTURE_DATA;
		public readonly HAVE_METADATA;
		public readonly HAVE_NOTHING;
		public readonly NETWORK_EMPTY;
		public readonly NETWORK_IDLE;
		public readonly NETWORK_LOADING;
		public readonly NETWORK_NO_SOURCE;
		public Func<, object> listener;
		public bool useCapture;
		public TextTrack addTextTrack(string kind, string label = default(string), string language = default(string))
		{
			throw new System.NotImplementedException();
		}
		public string canPlayType(string type)
		{
			throw new System.NotImplementedException();
		}
		public void load()
		{
			throw new System.NotImplementedException();
		}
		public void msClearEffects()
		{
			throw new System.NotImplementedException();
		}
		public object msGetAsCastingSource()
		{
			throw new System.NotImplementedException();
		}
		public void msInsertAudioEffect(string activatableClassId, bool effectRequired, object config = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void msSetMediaKeys(MSMediaKeys mediaKeys)
		{
			throw new System.NotImplementedException();
		}
		public void msSetMediaProtectionManager(object mediaProtectionManager = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void pause()
		{
			throw new System.NotImplementedException();
		}
		public void play()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<void> setMediaKeys(Any<MediaKeys, null> mediaKeys)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMediaElement_0_
	{
		public HTMLMediaElement prototype;
		public float HAVE_CURRENT_DATA;
		public float HAVE_ENOUGH_DATA;
		public float HAVE_FUTURE_DATA;
		public float HAVE_METADATA;
		public float HAVE_NOTHING;
		public float NETWORK_EMPTY;
		public float NETWORK_IDLE;
		public float NETWORK_LOADING;
		public float NETWORK_NO_SOURCE;
		public HTMLMediaElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMenuElement : HTMLElement
	{
		protected HTMLMenuElement() : base()
		{
			
		}
		public bool compact;
		public string type;
	}

		public class HTMLMenuElement_0_
	{
		public HTMLMenuElement prototype;
		public HTMLMenuElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMetaElement : HTMLElement
	{
		protected HTMLMetaElement() : base()
		{
			
		}
		public string charset;
		public string content;
		public string httpEquiv;
		public string name;
		public string scheme;
		public string url;
	}

		public class HTMLMetaElement_0_
	{
		public HTMLMetaElement prototype;
		public HTMLMetaElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLMeterElement : HTMLElement
	{
		protected HTMLMeterElement() : base()
		{
			
		}
		public float high;
		public float low;
		public float max;
		public float min;
		public float optimum;
		public float value;
	}

		public class HTMLMeterElement_0_
	{
		public HTMLMeterElement prototype;
		public HTMLMeterElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLModElement : HTMLElement
	{
		protected HTMLModElement() : base()
		{
			
		}
		public string cite;
		public string dateTime;
	}

		public class HTMLModElement_0_
	{
		public HTMLModElement prototype;
		public HTMLModElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLOListElement : HTMLElement
	{
		protected HTMLOListElement() : base()
		{
			
		}
		public bool compact;
		public float start;
		public string type;
	}

		public class HTMLOListElement_0_
	{
		public HTMLOListElement prototype;
		public HTMLOListElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLObjectElement : HTMLElement, GetSVGDocument
	{
		protected HTMLObjectElement() : base()
		{
			
		}
		public readonly BaseHref;
		public string align;
		public string alt;
		public string altHtml;
		public string archive;
		public string border;
		public string code;
		public string codeBase;
		public string codeType;
		public readonly contentDocument;
		public string data;
		public readonly form;
		public string height;
		public float hspace;
		public bool msPlayToDisabled;
		public string msPlayToPreferredSourceUri;
		public bool msPlayToPrimary;
		public readonly msPlayToSource;
		public string name;
		public readonly object;
		public readonly readyState;
		public string standby;
		public string type;
		public string useMap;
		public readonly validationMessage;
		public readonly validity;
		public float vspace;
		public string width;
		public readonly willValidate;
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public void setCustomValidity(string error)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLObjectElement_0_
	{
		public HTMLObjectElement prototype;
		public HTMLObjectElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLOptGroupElement : HTMLElement
	{
		protected HTMLOptGroupElement() : base()
		{
			
		}
		public bool defaultSelected;
		public bool disabled;
		public readonly form;
		public readonly index;
		public string label;
		public bool selected;
		public readonly text;
		public string value;
	}

		public class HTMLOptGroupElement_0_
	{
		public HTMLOptGroupElement prototype;
		public HTMLOptGroupElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLOptionElement : HTMLElement
	{
		protected HTMLOptionElement() : base()
		{
			
		}
		public bool defaultSelected;
		public bool disabled;
		public readonly form;
		public readonly index;
		public string label;
		public bool selected;
		public string text;
		public string value;
	}

		public class HTMLOptionElement_0_
	{
		public HTMLOptionElement prototype;
		public HTMLOptionElement new()
		{
			throw new System.NotImplementedException();
		}
		public HTMLOptionElement create()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLOptionsCollection : HTMLCollectionOf<HTMLOptionElement>
	{
		protected HTMLOptionsCollection() : base()
		{
			
		}
		public float length;
		public float selectedIndex;
		public void add(Any<HTMLOptionElement, HTMLOptGroupElement> element, Any<HTMLElement, float> before = default(Any<HTMLElement, float>))
		{
			throw new System.NotImplementedException();
		}
		public void remove(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLOptionsCollection_0_
	{
		public HTMLOptionsCollection prototype;
		public HTMLOptionsCollection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLParagraphElement : HTMLElement
	{
		protected HTMLParagraphElement() : base()
		{
			
		}
		public string align;
		public string clear;
	}

		public class HTMLParagraphElement_0_
	{
		public HTMLParagraphElement prototype;
		public HTMLParagraphElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLParamElement : HTMLElement
	{
		protected HTMLParamElement() : base()
		{
			
		}
		public string name;
		public string type;
		public string value;
		public string valueType;
	}

		public class HTMLParamElement_0_
	{
		public HTMLParamElement prototype;
		public HTMLParamElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLPictureElement : HTMLElement
	{
		protected HTMLPictureElement() : base()
		{
			
		}
	}

		public class HTMLPictureElement_0_
	{
		public HTMLPictureElement prototype;
		public HTMLPictureElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLPreElement : HTMLElement
	{
		protected HTMLPreElement() : base()
		{
			
		}
		public float width;
	}

		public class HTMLPreElement_0_
	{
		public HTMLPreElement prototype;
		public HTMLPreElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLProgressElement : HTMLElement
	{
		protected HTMLProgressElement() : base()
		{
			
		}
		public readonly form;
		public float max;
		public readonly position;
		public float value;
	}

		public class HTMLProgressElement_0_
	{
		public HTMLProgressElement prototype;
		public HTMLProgressElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLQuoteElement : HTMLElement
	{
		protected HTMLQuoteElement() : base()
		{
			
		}
		public string cite;
	}

		public class HTMLQuoteElement_0_
	{
		public HTMLQuoteElement prototype;
		public HTMLQuoteElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLScriptElement : HTMLElement
	{
		protected HTMLScriptElement() : base()
		{
			
		}
		public bool async;
		public string charset;
		public bool defer;
				public string @event;
		public string htmlFor;
		public string src;
		public string text;
		public string type;
		public string integrity;
	}

		public class HTMLScriptElement_0_
	{
		public HTMLScriptElement prototype;
		public HTMLScriptElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLSelectElement : HTMLElement
	{
		protected HTMLSelectElement() : base()
		{
			
		}
		public bool autofocus;
		public bool disabled;
		public readonly form;
		public float length;
		public bool multiple;
		public string name;
		public readonly options;
		public bool required;
		public float selectedIndex;
		public HTMLCollectionOf<HTMLOptionElement> selectedOptions;
		public float size;
		public readonly type;
		public readonly validationMessage;
		public readonly validity;
		public string value;
		public readonly willValidate;
		public void add(HTMLElement element, Any<HTMLElement, float> before = default(Any<HTMLElement, float>))
		{
			throw new System.NotImplementedException();
		}
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public object item(object name = default(object), object index = default(object))
		{
			throw new System.NotImplementedException();
		}
		public object namedItem(string name)
		{
			throw new System.NotImplementedException();
		}
		public void remove(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setCustomValidity(string error)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLSelectElement_0_
	{
		public HTMLSelectElement prototype;
		public HTMLSelectElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLSourceElement : HTMLElement
	{
		protected HTMLSourceElement() : base()
		{
			
		}
		public string media;
		public string msKeySystem;
		public string sizes;
		public string src;
		public string srcset;
		public string type;
	}

		public class HTMLSourceElement_0_
	{
		public HTMLSourceElement prototype;
		public HTMLSourceElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLSpanElement : HTMLElement
	{
		protected HTMLSpanElement() : base()
		{
			
		}
	}

		public class HTMLSpanElement_0_
	{
		public HTMLSpanElement prototype;
		public HTMLSpanElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLStyleElement : HTMLElement, LinkStyle
	{
		protected HTMLStyleElement() : base()
		{
			
		}
		public bool disabled;
		public string media;
		public string type;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLStyleElement_0_
	{
		public HTMLStyleElement prototype;
		public HTMLStyleElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableCaptionElement : HTMLElement
	{
		protected HTMLTableCaptionElement() : base()
		{
			
		}
		public string align;
		public string vAlign;
	}

		public class HTMLTableCaptionElement_0_
	{
		public HTMLTableCaptionElement prototype;
		public HTMLTableCaptionElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableCellElement : HTMLElement, HTMLTableAlignment
	{
		protected HTMLTableCellElement() : base()
		{
			
		}
		public string abbr;
		public string align;
		public string axis;
		public object bgColor;
		public readonly cellIndex;
		public float colSpan;
		public string headers;
		public object height;
		public bool noWrap;
		public float rowSpan;
		public string scope;
		public string width;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableCellElement_0_
	{
		public HTMLTableCellElement prototype;
		public HTMLTableCellElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableColElement : HTMLElement, HTMLTableAlignment
	{
		protected HTMLTableColElement() : base()
		{
			
		}
		public string align;
		public float span;
		public object width;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableColElement_0_
	{
		public HTMLTableColElement prototype;
		public HTMLTableColElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableDataCellElement : HTMLTableCellElement
	{
		protected HTMLTableDataCellElement() : base()
		{
			
		}
	}

		public class HTMLTableDataCellElement_0_
	{
		public HTMLTableDataCellElement prototype;
		public HTMLTableDataCellElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableElement : HTMLElement
	{
		protected HTMLTableElement() : base()
		{
			
		}
		public string align;
		public object bgColor;
		public string border;
		public object borderColor;
		public HTMLTableCaptionElement caption;
		public string cellPadding;
		public string cellSpacing;
		public float cols;
		public string frame;
		public object height;
		public HTMLCollectionOf<HTMLTableRowElement> rows;
		public string rules;
		public string summary;
		public HTMLCollectionOf<HTMLTableSectionElement> tBodies;
		public HTMLTableSectionElement tFoot;
		public HTMLTableSectionElement tHead;
		public string width;
		public HTMLTableCaptionElement createCaption()
		{
			throw new System.NotImplementedException();
		}
		public HTMLTableSectionElement createTBody()
		{
			throw new System.NotImplementedException();
		}
		public HTMLTableSectionElement createTFoot()
		{
			throw new System.NotImplementedException();
		}
		public HTMLTableSectionElement createTHead()
		{
			throw new System.NotImplementedException();
		}
		public void deleteCaption()
		{
			throw new System.NotImplementedException();
		}
		public void deleteRow(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void deleteTFoot()
		{
			throw new System.NotImplementedException();
		}
		public void deleteTHead()
		{
			throw new System.NotImplementedException();
		}
		public HTMLTableRowElement insertRow(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableElement_0_
	{
		public HTMLTableElement prototype;
		public HTMLTableElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableHeaderCellElement : HTMLTableCellElement
	{
		protected HTMLTableHeaderCellElement() : base()
		{
			
		}
		public string scope;
	}

		public class HTMLTableHeaderCellElement_0_
	{
		public HTMLTableHeaderCellElement prototype;
		public HTMLTableHeaderCellElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableRowElement : HTMLElement, HTMLTableAlignment
	{
		protected HTMLTableRowElement() : base()
		{
			
		}
		public string align;
		public object bgColor;
		public HTMLCollectionOf<> cells;
		public object height;
		public readonly rowIndex;
		public readonly sectionRowIndex;
		public void deleteCell(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public HTMLTableDataCellElement insertCell(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableRowElement_0_
	{
		public HTMLTableRowElement prototype;
		public HTMLTableRowElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableSectionElement : HTMLElement, HTMLTableAlignment
	{
		protected HTMLTableSectionElement() : base()
		{
			
		}
		public string align;
		public HTMLCollectionOf<HTMLTableRowElement> rows;
		public void deleteRow(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public HTMLTableRowElement insertRow(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableSectionElement_0_
	{
		public HTMLTableSectionElement prototype;
		public HTMLTableSectionElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTemplateElement : HTMLElement
	{
		protected HTMLTemplateElement() : base()
		{
			
		}
		public readonly content;
	}

		public class HTMLTemplateElement_0_
	{
		public HTMLTemplateElement prototype;
		public HTMLTemplateElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTextAreaElement : HTMLElement
	{
		protected HTMLTextAreaElement() : base()
		{
			
		}
		public bool autofocus;
		public float cols;
		public string defaultValue;
		public bool disabled;
		public readonly form;
		public float maxLength;
		public string name;
		public string placeholder;
		public bool readOnly;
		public bool required;
		public float rows;
		public float selectionEnd;
		public float selectionStart;
		public object status;
		public readonly type;
		public readonly validationMessage;
		public readonly validity;
		public string value;
		public readonly willValidate;
		public string wrap;
		public float minLength;
		public bool checkValidity()
		{
			throw new System.NotImplementedException();
		}
		public void select()
		{
			throw new System.NotImplementedException();
		}
		public void setCustomValidity(string error)
		{
			throw new System.NotImplementedException();
		}
		public void setSelectionRange(float start, float end)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTextAreaElement_0_
	{
		public HTMLTextAreaElement prototype;
		public HTMLTextAreaElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTitleElement : HTMLElement
	{
		protected HTMLTitleElement() : base()
		{
			
		}
		public string text;
	}

		public class HTMLTitleElement_0_
	{
		public HTMLTitleElement prototype;
		public HTMLTitleElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTrackElement : HTMLElement
	{
		protected HTMLTrackElement() : base()
		{
			
		}
		public bool default;
		public string kind;
		public string label;
		public readonly readyState;
		public string src;
		public string srclang;
		public readonly track;
		public readonly ERROR;
		public readonly LOADED;
		public readonly LOADING;
		public readonly NONE;
	}

		public class HTMLTrackElement_0_
	{
		public HTMLTrackElement prototype;
		public float ERROR;
		public float LOADED;
		public float LOADING;
		public float NONE;
		public HTMLTrackElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLUListElement : HTMLElement
	{
		protected HTMLUListElement() : base()
		{
			
		}
		public bool compact;
		public string type;
	}

		public class HTMLUListElement_0_
	{
		public HTMLUListElement prototype;
		public HTMLUListElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLUnknownElement : HTMLElement
	{
		protected HTMLUnknownElement() : base()
		{
			
		}
	}

		public class HTMLUnknownElement_0_
	{
		public HTMLUnknownElement prototype;
		public HTMLUnknownElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLVideoElement : HTMLMediaElement
	{
		protected HTMLVideoElement() : base()
		{
			
		}
		public float height;
		public bool msHorizontalMirror;
		public readonly msIsLayoutOptimalForPlayback;
		public readonly msIsStereo3D;
		public string msStereo3DPackingMode;
		public string msStereo3DRenderMode;
		public bool msZoom;
		public Func<, object> onMSVideoFormatChanged;
		public WheelEvent ev;
		public object any;
		public Func<, object> onMSVideoFrameStepCompleted;
		public Func<, object> onMSVideoOptimalLayoutChanged;
		public string poster;
		public readonly videoHeight;
		public readonly videoWidth;
		public readonly webkitDisplayingFullscreen;
		public readonly webkitSupportsFullscreen;
		public float width;
		public Func<, object> listener;
		public bool useCapture;
		public VideoPlaybackQuality getVideoPlaybackQuality()
		{
			throw new System.NotImplementedException();
		}
		public void msFrameStep(bool forward)
		{
			throw new System.NotImplementedException();
		}
		public void msInsertVideoEffect(string activatableClassId, bool effectRequired, object config = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void msSetVideoRectangle(float left, float top, float right, float bottom)
		{
			throw new System.NotImplementedException();
		}
		public void webkitEnterFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public void webkitEnterFullscreen()
		{
			throw new System.NotImplementedException();
		}
		public void webkitExitFullScreen()
		{
			throw new System.NotImplementedException();
		}
		public void webkitExitFullscreen()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLVideoElement_0_
	{
		public HTMLVideoElement prototype;
		public HTMLVideoElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class HashChangeEvent : Event
	{
		protected HashChangeEvent() : base()
		{
			
		}
		public readonly newURL;
		public readonly oldURL;
	}

		public class HashChangeEvent_0_
	{
		public HashChangeEvent prototype;
		public HashChangeEvent new(string type, HashChangeEventInit eventInitDict = default(HashChangeEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class History
	{
		protected History()
		{
			
		}
		public readonly length;
		public readonly state;
		public void back(object distance = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void forward(object distance = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void go(object delta = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void pushState(object statedata, string title = default(string), string url = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void replaceState(object statedata, string title = default(string), string url = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class History_0_
	{
		public History prototype;
		public History new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBCursor
	{
		protected IDBCursor()
		{
			
		}
		public readonly direction;
		public Any<IDBKeyRange, IDBValidKey> key;
		public readonly primaryKey;
		public Any<IDBObjectStore, IDBIndex> source;
		public readonly NEXT;
		public readonly NEXT_NO_DUPLICATE;
		public readonly PREV;
		public readonly PREV_NO_DUPLICATE;
		public void advance(float count)
		{
			throw new System.NotImplementedException();
		}
		public void continue(Any<IDBKeyRange, IDBValidKey> key = default(Any<IDBKeyRange, IDBValidKey>))
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest delete()
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest update(object value)
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBCursor_0_
	{
		public IDBCursor prototype;
		public string NEXT;
		public string NEXT_NO_DUPLICATE;
		public string PREV;
		public string PREV_NO_DUPLICATE;
		public IDBCursor new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBCursorWithValue : IDBCursor
	{
		protected IDBCursorWithValue() : base()
		{
			
		}
		public readonly value;
	}

		public class IDBCursorWithValue_0_
	{
		public IDBCursorWithValue prototype;
		public IDBCursorWithValue new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBDatabase : EventTarget
	{
		protected IDBDatabase() : base()
		{
			
		}
		public readonly name;
		public readonly objectStoreNames;
		public Func<, object> onabort;
		public ErrorEvent ev;
		public object any;
		public Func<, object> onerror;
		public float version;
		public Func<IDBVersionChangeEvent, object> onversionchange;
		public Func<, object> listener;
		public bool useCapture;
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public IDBObjectStore createObjectStore(string name, IDBObjectStoreParameters optionalParameters = default(IDBObjectStoreParameters))
		{
			throw new System.NotImplementedException();
		}
		public void deleteObjectStore(string name)
		{
			throw new System.NotImplementedException();
		}
		public IDBTransaction transaction(Any<string, string[]> storeNames, string mode = default(string))
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBDatabase_0_
	{
		public IDBDatabase prototype;
		public IDBDatabase new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBFactory
	{
		protected IDBFactory()
		{
			
		}
		public float cmp(object first, object second)
		{
			throw new System.NotImplementedException();
		}
		public IDBOpenDBRequest deleteDatabase(string name)
		{
			throw new System.NotImplementedException();
		}
		public IDBOpenDBRequest open(string name, float version = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBFactory_0_
	{
		public IDBFactory prototype;
		public IDBFactory new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBIndex
	{
		protected IDBIndex()
		{
			
		}
		public Any<string, string[]> keyPath;
		public readonly name;
		public readonly objectStore;
		public readonly unique;
		public bool multiEntry;
		public IDBRequest count(Any<IDBKeyRange, IDBValidKey> key = default(Any<IDBKeyRange, IDBValidKey>))
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest get(Any<IDBKeyRange, IDBValidKey> key)
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest getKey(Any<IDBKeyRange, IDBValidKey> key)
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest openCursor(Any<IDBKeyRange, IDBValidKey> range = default(Any<IDBKeyRange, IDBValidKey>), string direction = default(string))
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest openKeyCursor(Any<IDBKeyRange, IDBValidKey> range = default(Any<IDBKeyRange, IDBValidKey>), string direction = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBIndex_0_
	{
		public IDBIndex prototype;
		public IDBIndex new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBKeyRange
	{
		protected IDBKeyRange()
		{
			
		}
		public readonly lower;
		public readonly lowerOpen;
		public readonly upper;
		public readonly upperOpen;
	}

		public class IDBKeyRange_0_
	{
		public IDBKeyRange prototype;
		public IDBKeyRange new()
		{
			throw new System.NotImplementedException();
		}
		public IDBKeyRange bound(object lower, object upper, bool lowerOpen = default(bool), bool upperOpen = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public IDBKeyRange lowerBound(object lower, bool open = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public IDBKeyRange only(object value)
		{
			throw new System.NotImplementedException();
		}
		public IDBKeyRange upperBound(object upper, bool open = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBObjectStore
	{
		protected IDBObjectStore()
		{
			
		}
		public readonly indexNames;
		public Any<string, string[]> keyPath;
		public readonly name;
		public readonly transaction;
		public bool autoIncrement;
		public IDBRequest add(object value, Any<IDBKeyRange, IDBValidKey> key = default(Any<IDBKeyRange, IDBValidKey>))
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest clear()
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest count(Any<IDBKeyRange, IDBValidKey> key = default(Any<IDBKeyRange, IDBValidKey>))
		{
			throw new System.NotImplementedException();
		}
		public IDBIndex createIndex(string name, Any<string, string[]> keyPath, IDBIndexParameters optionalParameters = default(IDBIndexParameters))
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest delete(Any<IDBKeyRange, IDBValidKey> key)
		{
			throw new System.NotImplementedException();
		}
		public void deleteIndex(string indexName)
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest get(object key)
		{
			throw new System.NotImplementedException();
		}
		public IDBIndex index(string name)
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest openCursor(Any<IDBKeyRange, IDBValidKey> range = default(Any<IDBKeyRange, IDBValidKey>), string direction = default(string))
		{
			throw new System.NotImplementedException();
		}
		public IDBRequest put(object value, Any<IDBKeyRange, IDBValidKey> key = default(Any<IDBKeyRange, IDBValidKey>))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBObjectStore_0_
	{
		public IDBObjectStore prototype;
		public IDBObjectStore new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBOpenDBRequest : IDBRequest
	{
		protected IDBOpenDBRequest() : base()
		{
			
		}
		public Func<, object> onblocked;
		public IDBVersionChangeEvent ev;
		public object any;
		public Func<, object> onupgradeneeded;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBOpenDBRequest_0_
	{
		public IDBOpenDBRequest prototype;
		public IDBOpenDBRequest new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBRequest : EventTarget
	{
		protected IDBRequest() : base()
		{
			
		}
		public readonly error;
		public Func<, object> onerror;
		public Event ev;
		public object any;
		public Func<, object> onsuccess;
		public readonly readyState;
		public readonly result;
		public Any<IDBObjectStore, IDBIndex, IDBCursor> source;
		public readonly transaction;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBRequest_0_
	{
		public IDBRequest prototype;
		public IDBRequest new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBTransaction : EventTarget
	{
		protected IDBTransaction() : base()
		{
			
		}
		public readonly db;
		public readonly error;
		public readonly mode;
		public Func<, object> onabort;
		public ErrorEvent ev;
		public object any;
		public Func<, object> oncomplete;
		public Func<, object> onerror;
		public readonly READ_ONLY;
		public readonly READ_WRITE;
		public readonly VERSION_CHANGE;
		public Func<, object> listener;
		public bool useCapture;
		public void abort()
		{
			throw new System.NotImplementedException();
		}
		public IDBObjectStore objectStore(string name)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBTransaction_0_
	{
		public IDBTransaction prototype;
		public string READ_ONLY;
		public string READ_WRITE;
		public string VERSION_CHANGE;
		public IDBTransaction new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class IDBVersionChangeEvent : Event
	{
		protected IDBVersionChangeEvent() : base()
		{
			
		}
		public readonly newVersion;
		public readonly oldVersion;
	}

		public class IDBVersionChangeEvent_0_
	{
		public IDBVersionChangeEvent prototype;
		public IDBVersionChangeEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ImageData
	{
		protected ImageData()
		{
			
		}
		public Bridge.Html5.Uint8ClampedArray data;
		public readonly height;
		public readonly width;
	}

		public class ImageData_0_
	{
		public ImageData prototype;
		public ImageData new(float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public ImageData new(Bridge.Html5.Uint8ClampedArray array, float width, float height)
		{
			throw new System.NotImplementedException();
		}
	}

		public class KeyboardEvent : UIEvent
	{
		protected KeyboardEvent() : base()
		{
			
		}
		public readonly altKey;
		public readonly char;
		public readonly charCode;
		public readonly ctrlKey;
		public readonly key;
		public readonly keyCode;
		public readonly locale;
		public readonly location;
		public readonly metaKey;
		public readonly repeat;
		public readonly shiftKey;
		public readonly which;
		public readonly code;
		public readonly DOM_KEY_LOCATION_JOYSTICK;
		public readonly DOM_KEY_LOCATION_LEFT;
		public readonly DOM_KEY_LOCATION_MOBILE;
		public readonly DOM_KEY_LOCATION_NUMPAD;
		public readonly DOM_KEY_LOCATION_RIGHT;
		public readonly DOM_KEY_LOCATION_STANDARD;
		public bool getModifierState(string keyArg)
		{
			throw new System.NotImplementedException();
		}
		public void initKeyboardEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, string keyArg, float locationArg, string modifiersListArg, bool repeat, string locale)
		{
			throw new System.NotImplementedException();
		}
	}

		public class KeyboardEvent_0_
	{
		public KeyboardEvent prototype;
		public float DOM_KEY_LOCATION_JOYSTICK;
		public float DOM_KEY_LOCATION_LEFT;
		public float DOM_KEY_LOCATION_MOBILE;
		public float DOM_KEY_LOCATION_NUMPAD;
		public float DOM_KEY_LOCATION_RIGHT;
		public float DOM_KEY_LOCATION_STANDARD;
		public KeyboardEvent new(string typeArg, KeyboardEventInit eventInitDict = default(KeyboardEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ListeningStateChangedEvent : Event
	{
		protected ListeningStateChangedEvent() : base()
		{
			
		}
		public readonly label;
		public readonly state;
	}

		public class ListeningStateChangedEvent_0_
	{
		public ListeningStateChangedEvent prototype;
		public ListeningStateChangedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Location
	{
		protected Location()
		{
			
		}
		public string hash;
		public string host;
		public string hostname;
		public string href;
		public readonly origin;
		public string pathname;
		public string port;
		public string protocol;
		public string search;
		public void assign(string url)
		{
			throw new System.NotImplementedException();
		}
		public void reload(bool forcedReload = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void replace(string url)
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Location_0_
	{
		public Location prototype;
		public Location new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class LongRunningScriptDetectedEvent : Event
	{
		protected LongRunningScriptDetectedEvent() : base()
		{
			
		}
		public readonly executionTime;
		public bool stopPageScriptExecution;
	}

		public class LongRunningScriptDetectedEvent_0_
	{
		public LongRunningScriptDetectedEvent prototype;
		public LongRunningScriptDetectedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSApp
	{
		protected MSApp()
		{
			
		}
		public readonly CURRENT;
		public readonly HIGH;
		public readonly IDLE;
		public readonly NORMAL;
		public MSAppAsyncOperation clearTemporaryWebDataAsync()
		{
			throw new System.NotImplementedException();
		}
		public Blob createBlobFromRandomAccessStream(string type, object seeker)
		{
			throw new System.NotImplementedException();
		}
		public object createDataPackage(object @object)
		{
			throw new System.NotImplementedException();
		}
		public object createDataPackageFromSelection()
		{
			throw new System.NotImplementedException();
		}
		public File createFileFromStorageFile(object storageFile)
		{
			throw new System.NotImplementedException();
		}
		public MSStream createStreamFromInputStream(string type, object inputStream)
		{
			throw new System.NotImplementedException();
		}
		public void execAsyncAtPriority(MSExecAtPriorityFunctionCallback asynchronousCallback, string priority, params object[][] args)
		{
			throw new System.NotImplementedException();
		}
		public object execAtPriority(MSExecAtPriorityFunctionCallback synchronousCallback, string priority, params object[][] args)
		{
			throw new System.NotImplementedException();
		}
		public string getCurrentPriority()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<object> getHtmlPrintDocumentSourceAsync(object htmlDoc)
		{
			throw new System.NotImplementedException();
		}
		public object getViewId(object view)
		{
			throw new System.NotImplementedException();
		}
		public bool isTaskScheduledAtPriorityOrHigher(string priority)
		{
			throw new System.NotImplementedException();
		}
		public void pageHandlesAllApplicationActivations(bool enabled)
		{
			throw new System.NotImplementedException();
		}
		public void suppressSubdownloadCredentialPrompts(bool suppress)
		{
			throw new System.NotImplementedException();
		}
		public void terminateApp(object exceptionObject)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSAppAsyncOperation : EventTarget
	{
		protected MSAppAsyncOperation() : base()
		{
			
		}
		public readonly error;
		public Func<, object> oncomplete;
		public ErrorEvent ev;
		public object any;
		public Func<, object> onerror;
		public readonly readyState;
		public readonly result;
		public readonly COMPLETED;
		public readonly ERROR;
		public readonly STARTED;
		public Func<, object> listener;
		public bool useCapture;
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSAppAsyncOperation_0_
	{
		public MSAppAsyncOperation prototype;
		public float COMPLETED;
		public float ERROR;
		public float STARTED;
		public MSAppAsyncOperation new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSAssertion
	{
		protected MSAssertion()
		{
			
		}
		public readonly id;
		public readonly type;
	}

		public class MSAssertion_0_
	{
		public MSAssertion prototype;
		public MSAssertion new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSBlobBuilder
	{
		protected MSBlobBuilder()
		{
			
		}
		public void append(object data, string endings = default(string))
		{
			throw new System.NotImplementedException();
		}
		public Blob getBlob(string contentType = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSBlobBuilder_0_
	{
		public MSBlobBuilder prototype;
		public MSBlobBuilder new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSCredentials
	{
		protected MSCredentials()
		{
			
		}
		public PromiseLike<MSAssertion> getAssertion(string challenge, MSCredentialFilter filter = default(MSCredentialFilter), MSSignatureParameters @params = default(MSSignatureParameters))
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<MSAssertion> makeCredential(MSAccountInfo accountInfo, MSCredentialParameters[] @params, string challenge = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSCredentials_0_
	{
		public MSCredentials prototype;
		public MSCredentials new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSFIDOCredentialAssertion : MSAssertion
	{
		protected MSFIDOCredentialAssertion() : base()
		{
			
		}
		public readonly algorithm;
		public readonly attestation;
		public readonly publicKey;
		public readonly transportHints;
	}

		public class MSFIDOCredentialAssertion_0_
	{
		public MSFIDOCredentialAssertion prototype;
		public MSFIDOCredentialAssertion new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSFIDOSignature
	{
		protected MSFIDOSignature()
		{
			
		}
		public readonly authnrData;
		public readonly clientData;
		public readonly signature;
	}

		public class MSFIDOSignature_0_
	{
		public MSFIDOSignature prototype;
		public MSFIDOSignature new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSFIDOSignatureAssertion : MSAssertion
	{
		protected MSFIDOSignatureAssertion() : base()
		{
			
		}
		public readonly signature;
	}

		public class MSFIDOSignatureAssertion_0_
	{
		public MSFIDOSignatureAssertion prototype;
		public MSFIDOSignatureAssertion new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSGesture
	{
		protected MSGesture()
		{
			
		}
		public Element target;
		public void addPointer(float pointerId)
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSGesture_0_
	{
		public MSGesture prototype;
		public MSGesture new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSGestureEvent : UIEvent
	{
		protected MSGestureEvent() : base()
		{
			
		}
		public readonly clientX;
		public readonly clientY;
		public readonly expansion;
		public readonly gestureObject;
		public readonly hwTimestamp;
		public readonly offsetX;
		public readonly offsetY;
		public readonly rotation;
		public readonly scale;
		public readonly screenX;
		public readonly screenY;
		public readonly translationX;
		public readonly translationY;
		public readonly velocityAngular;
		public readonly velocityExpansion;
		public readonly velocityX;
		public readonly velocityY;
		public readonly MSGESTURE_FLAG_BEGIN;
		public readonly MSGESTURE_FLAG_CANCEL;
		public readonly MSGESTURE_FLAG_END;
		public readonly MSGESTURE_FLAG_INERTIA;
		public readonly MSGESTURE_FLAG_NONE;
		public void initGestureEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, float offsetXArg, float offsetYArg, float translationXArg, float translationYArg, float scaleArg, float expansionArg, float rotationArg, float velocityXArg, float velocityYArg, float velocityExpansionArg, float velocityAngularArg, float hwTimestampArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSGestureEvent_0_
	{
		public MSGestureEvent prototype;
		public float MSGESTURE_FLAG_BEGIN;
		public float MSGESTURE_FLAG_CANCEL;
		public float MSGESTURE_FLAG_END;
		public float MSGESTURE_FLAG_INERTIA;
		public float MSGESTURE_FLAG_NONE;
		public MSGestureEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSGraphicsTrust
	{
		protected MSGraphicsTrust()
		{
			
		}
		public readonly constrictionActive;
		public readonly status;
	}

		public class MSGraphicsTrust_0_
	{
		public MSGraphicsTrust prototype;
		public MSGraphicsTrust new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSHTMLWebViewElement : HTMLElement
	{
		protected MSHTMLWebViewElement() : base()
		{
			
		}
		public readonly canGoBack;
		public readonly canGoForward;
		public readonly containsFullScreenElement;
		public readonly documentTitle;
		public float height;
		public readonly settings;
		public string src;
		public float width;
		public void addWebAllowedObject(string name, object applicationObject)
		{
			throw new System.NotImplementedException();
		}
		public string buildLocalStreamUri(string contentIdentifier, string relativePath)
		{
			throw new System.NotImplementedException();
		}
		public MSWebViewAsyncOperation capturePreviewToBlobAsync()
		{
			throw new System.NotImplementedException();
		}
		public MSWebViewAsyncOperation captureSelectedContentToDataPackageAsync()
		{
			throw new System.NotImplementedException();
		}
		public DeferredPermissionRequest getDeferredPermissionRequestById(float id)
		{
			throw new System.NotImplementedException();
		}
		public DeferredPermissionRequest[] getDeferredPermissionRequests()
		{
			throw new System.NotImplementedException();
		}
		public void goBack()
		{
			throw new System.NotImplementedException();
		}
		public void goForward()
		{
			throw new System.NotImplementedException();
		}
		public MSWebViewAsyncOperation invokeScriptAsync(string scriptName, params object[][] args)
		{
			throw new System.NotImplementedException();
		}
		public void navigate(string uri)
		{
			throw new System.NotImplementedException();
		}
		public void navigateToLocalStreamUri(string source, object streamResolver)
		{
			throw new System.NotImplementedException();
		}
		public void navigateToString(string contents)
		{
			throw new System.NotImplementedException();
		}
		public void navigateWithHttpRequestMessage(object requestMessage)
		{
			throw new System.NotImplementedException();
		}
		public void refresh()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSHTMLWebViewElement_0_
	{
		public MSHTMLWebViewElement prototype;
		public MSHTMLWebViewElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSInputMethodContext : EventTarget
	{
		protected MSInputMethodContext() : base()
		{
			
		}
		public readonly compositionEndOffset;
		public readonly compositionStartOffset;
		public Func<, object> oncandidatewindowhide;
		public Event ev;
		public object any;
		public Func<, object> oncandidatewindowshow;
		public Func<, object> oncandidatewindowupdate;
		public readonly target;
		public Func<, object> listener;
		public bool useCapture;
		public ClientRect getCandidateWindowClientRect()
		{
			throw new System.NotImplementedException();
		}
		public string[] getCompositionAlternatives()
		{
			throw new System.NotImplementedException();
		}
		public bool hasComposition()
		{
			throw new System.NotImplementedException();
		}
		public bool isCandidateWindowVisible()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSInputMethodContext_0_
	{
		public MSInputMethodContext prototype;
		public MSInputMethodContext new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSManipulationEvent : UIEvent
	{
		protected MSManipulationEvent() : base()
		{
			
		}
		public readonly currentState;
		public readonly inertiaDestinationX;
		public readonly inertiaDestinationY;
		public readonly lastState;
		public readonly MS_MANIPULATION_STATE_ACTIVE;
		public readonly MS_MANIPULATION_STATE_CANCELLED;
		public readonly MS_MANIPULATION_STATE_COMMITTED;
		public readonly MS_MANIPULATION_STATE_DRAGGING;
		public readonly MS_MANIPULATION_STATE_INERTIA;
		public readonly MS_MANIPULATION_STATE_PRESELECT;
		public readonly MS_MANIPULATION_STATE_SELECTING;
		public readonly MS_MANIPULATION_STATE_STOPPED;
		public void initMSManipulationEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float lastState, float currentState)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSManipulationEvent_0_
	{
		public MSManipulationEvent prototype;
		public float MS_MANIPULATION_STATE_ACTIVE;
		public float MS_MANIPULATION_STATE_CANCELLED;
		public float MS_MANIPULATION_STATE_COMMITTED;
		public float MS_MANIPULATION_STATE_DRAGGING;
		public float MS_MANIPULATION_STATE_INERTIA;
		public float MS_MANIPULATION_STATE_PRESELECT;
		public float MS_MANIPULATION_STATE_SELECTING;
		public float MS_MANIPULATION_STATE_STOPPED;
		public MSManipulationEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeyError
	{
		protected MSMediaKeyError()
		{
			
		}
		public readonly code;
		public readonly systemCode;
		public readonly MS_MEDIA_KEYERR_CLIENT;
		public readonly MS_MEDIA_KEYERR_DOMAIN;
		public readonly MS_MEDIA_KEYERR_HARDWARECHANGE;
		public readonly MS_MEDIA_KEYERR_OUTPUT;
		public readonly MS_MEDIA_KEYERR_SERVICE;
		public readonly MS_MEDIA_KEYERR_UNKNOWN;
	}

		public class MSMediaKeyError_0_
	{
		public MSMediaKeyError prototype;
		public float MS_MEDIA_KEYERR_CLIENT;
		public float MS_MEDIA_KEYERR_DOMAIN;
		public float MS_MEDIA_KEYERR_HARDWARECHANGE;
		public float MS_MEDIA_KEYERR_OUTPUT;
		public float MS_MEDIA_KEYERR_SERVICE;
		public float MS_MEDIA_KEYERR_UNKNOWN;
		public MSMediaKeyError new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeyMessageEvent : Event
	{
		protected MSMediaKeyMessageEvent() : base()
		{
			
		}
		public readonly destinationURL;
		public readonly message;
	}

		public class MSMediaKeyMessageEvent_0_
	{
		public MSMediaKeyMessageEvent prototype;
		public MSMediaKeyMessageEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeyNeededEvent : Event
	{
		protected MSMediaKeyNeededEvent() : base()
		{
			
		}
		public readonly initData;
	}

		public class MSMediaKeyNeededEvent_0_
	{
		public MSMediaKeyNeededEvent prototype;
		public MSMediaKeyNeededEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeySession : EventTarget
	{
		protected MSMediaKeySession() : base()
		{
			
		}
		public readonly error;
		public readonly keySystem;
		public readonly sessionId;
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public void update(Bridge.Html5.Uint8Array key)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeySession_0_
	{
		public MSMediaKeySession prototype;
		public MSMediaKeySession new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeys
	{
		protected MSMediaKeys()
		{
			
		}
		public readonly keySystem;
		public MSMediaKeySession createSession(string type, Bridge.Html5.Uint8Array initData, Bridge.Html5.Uint8Array cdmData = default(Bridge.Html5.Uint8Array))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSMediaKeys_0_
	{
		public MSMediaKeys prototype;
		public MSMediaKeys new(string keySystem)
		{
			throw new System.NotImplementedException();
		}
		public bool isTypeSupported(string keySystem, string type = default(string))
		{
			throw new System.NotImplementedException();
		}
		public string isTypeSupportedWithFeatures(string keySystem, string type = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSPointerEvent : MouseEvent
	{
		protected MSPointerEvent() : base()
		{
			
		}
		public readonly currentPoint;
		public readonly height;
		public readonly hwTimestamp;
		public readonly intermediatePoints;
		public readonly isPrimary;
		public readonly pointerId;
		public readonly pointerType;
		public readonly pressure;
		public readonly rotation;
		public readonly tiltX;
		public readonly tiltY;
		public readonly width;
		public void getCurrentPoint(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void getIntermediatePoints(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void initPointerEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg, float offsetXArg, float offsetYArg, float widthArg, float heightArg, float pressure, float rotation, float tiltX, float tiltY, float pointerIdArg, object pointerType, float hwTimestampArg, bool isPrimary)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSPointerEvent_0_
	{
		public MSPointerEvent prototype;
		public MSPointerEvent new(string typeArg, PointerEventInit eventInitDict = default(PointerEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSRangeCollection
	{
		protected MSRangeCollection()
		{
			
		}
		public readonly length;
		public float index;
		public Range item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSRangeCollection_0_
	{
		public MSRangeCollection prototype;
		public MSRangeCollection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSSiteModeEvent : Event
	{
		protected MSSiteModeEvent() : base()
		{
			
		}
		public readonly actionURL;
		public readonly buttonID;
	}

		public class MSSiteModeEvent_0_
	{
		public MSSiteModeEvent prototype;
		public MSSiteModeEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSStream
	{
		protected MSStream()
		{
			
		}
		public readonly type;
		public void msClose()
		{
			throw new System.NotImplementedException();
		}
		public object msDetachStream()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSStream_0_
	{
		public MSStream prototype;
		public MSStream new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSStreamReader : EventTarget, MSBaseReader
	{
		protected MSStreamReader() : base()
		{
			
		}
		public readonly error;
		public void readAsArrayBuffer(MSStream stream, float size = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void readAsBinaryString(MSStream stream, float size = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void readAsBlob(MSStream stream, float size = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void readAsDataURL(MSStream stream, float size = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void readAsText(MSStream stream, string encoding = default(string), float size = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSStreamReader_0_
	{
		public MSStreamReader prototype;
		public MSStreamReader new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSWebViewAsyncOperation : EventTarget
	{
		protected MSWebViewAsyncOperation() : base()
		{
			
		}
		public readonly error;
		public Func<, object> oncomplete;
		public ErrorEvent ev;
		public object any;
		public Func<, object> onerror;
		public readonly readyState;
		public readonly result;
		public readonly target;
		public readonly type;
		public readonly COMPLETED;
		public readonly ERROR;
		public readonly STARTED;
		public readonly TYPE_CAPTURE_PREVIEW_TO_RANDOM_ACCESS_STREAM;
		public readonly TYPE_CREATE_DATA_PACKAGE_FROM_SELECTION;
		public readonly TYPE_INVOKE_SCRIPT;
		public Func<, object> listener;
		public bool useCapture;
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSWebViewAsyncOperation_0_
	{
		public MSWebViewAsyncOperation prototype;
		public float COMPLETED;
		public float ERROR;
		public float STARTED;
		public float TYPE_CAPTURE_PREVIEW_TO_RANDOM_ACCESS_STREAM;
		public float TYPE_CREATE_DATA_PACKAGE_FROM_SELECTION;
		public float TYPE_INVOKE_SCRIPT;
		public MSWebViewAsyncOperation new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSWebViewSettings
	{
		protected MSWebViewSettings()
		{
			
		}
		public bool isIndexedDBEnabled;
		public bool isJavaScriptEnabled;
	}

		public class MSWebViewSettings_0_
	{
		public MSWebViewSettings prototype;
		public MSWebViewSettings new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaDeviceInfo
	{
		protected MediaDeviceInfo()
		{
			
		}
		public readonly deviceId;
		public readonly groupId;
		public readonly kind;
		public readonly label;
	}

		public class MediaDeviceInfo_0_
	{
		public MediaDeviceInfo prototype;
		public MediaDeviceInfo new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaDevices : EventTarget
	{
		protected MediaDevices() : base()
		{
			
		}
		public Func<, object> ondevicechange;
		public Event ev;
		public object any;
		public Func<, object> listener;
		public bool useCapture;
		public object enumerateDevices()
		{
			throw new System.NotImplementedException();
		}
		public MediaTrackSupportedConstraints getSupportedConstraints()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<MediaStream> getUserMedia(MediaStreamConstraints constraints)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaDevices_0_
	{
		public MediaDevices prototype;
		public MediaDevices new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaElementAudioSourceNode : AudioNode
	{
		protected MediaElementAudioSourceNode() : base()
		{
			
		}
	}

		public class MediaElementAudioSourceNode_0_
	{
		public MediaElementAudioSourceNode prototype;
		public MediaElementAudioSourceNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaEncryptedEvent : Event
	{
		protected MediaEncryptedEvent() : base()
		{
			
		}
		public readonly initData;
		public readonly initDataType;
	}

		public class MediaEncryptedEvent_0_
	{
		public MediaEncryptedEvent prototype;
		public MediaEncryptedEvent new(string type, MediaEncryptedEventInit eventInitDict = default(MediaEncryptedEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaError
	{
		protected MediaError()
		{
			
		}
		public readonly code;
		public readonly msExtendedCode;
		public readonly MEDIA_ERR_ABORTED;
		public readonly MEDIA_ERR_DECODE;
		public readonly MEDIA_ERR_NETWORK;
		public readonly MEDIA_ERR_SRC_NOT_SUPPORTED;
		public readonly MS_MEDIA_ERR_ENCRYPTED;
	}

		public class MediaError_0_
	{
		public MediaError prototype;
		public float MEDIA_ERR_ABORTED;
		public float MEDIA_ERR_DECODE;
		public float MEDIA_ERR_NETWORK;
		public float MEDIA_ERR_SRC_NOT_SUPPORTED;
		public float MS_MEDIA_ERR_ENCRYPTED;
		public MediaError new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeyMessageEvent : Event
	{
		protected MediaKeyMessageEvent() : base()
		{
			
		}
		public readonly message;
		public readonly messageType;
	}

		public class MediaKeyMessageEvent_0_
	{
		public MediaKeyMessageEvent prototype;
		public MediaKeyMessageEvent new(string type, MediaKeyMessageEventInit eventInitDict = default(MediaKeyMessageEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeySession : EventTarget
	{
		protected MediaKeySession() : base()
		{
			
		}
		public readonly closed;
		public readonly expiration;
		public readonly keyStatuses;
		public readonly sessionId;
		public PromiseLike<void> close()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<void> generateRequest(string initDataType, object initData)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<bool> load(string sessionId)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<void> remove()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<void> update(object response)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeySession_0_
	{
		public MediaKeySession prototype;
		public MediaKeySession new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeyStatusMap
	{
		protected MediaKeyStatusMap()
		{
			
		}
		public readonly size;
		public void forEach(ForEachCallback callback)
		{
			throw new System.NotImplementedException();
		}
		public string get(object keyId)
		{
			throw new System.NotImplementedException();
		}
		public bool has(object keyId)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeyStatusMap_0_
	{
		public MediaKeyStatusMap prototype;
		public MediaKeyStatusMap new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeySystemAccess
	{
		protected MediaKeySystemAccess()
		{
			
		}
		public readonly keySystem;
		public PromiseLike<MediaKeys> createMediaKeys()
		{
			throw new System.NotImplementedException();
		}
		public MediaKeySystemConfiguration getConfiguration()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeySystemAccess_0_
	{
		public MediaKeySystemAccess prototype;
		public MediaKeySystemAccess new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeys
	{
		protected MediaKeys()
		{
			
		}
		public MediaKeySession createSession(string sessionType = default(string))
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<void> setServerCertificate(object serverCertificate)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaKeys_0_
	{
		public MediaKeys prototype;
		public MediaKeys new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaList
	{
		protected MediaList()
		{
			
		}
		public readonly length;
		public string mediaText;
		public float index;
		public void appendMedium(string newMedium)
		{
			throw new System.NotImplementedException();
		}
		public void deleteMedium(string oldMedium)
		{
			throw new System.NotImplementedException();
		}
		public string item(float index)
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaList_0_
	{
		public MediaList prototype;
		public MediaList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaQueryList
	{
		protected MediaQueryList()
		{
			
		}
		public readonly matches;
		public readonly media;
		public void addListener(MediaQueryListListener listener)
		{
			throw new System.NotImplementedException();
		}
		public void removeListener(MediaQueryListListener listener)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaQueryList_0_
	{
		public MediaQueryList prototype;
		public MediaQueryList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaSource : EventTarget
	{
		protected MediaSource() : base()
		{
			
		}
		public readonly activeSourceBuffers;
		public float duration;
		public readonly readyState;
		public readonly sourceBuffers;
		public SourceBuffer addSourceBuffer(string type)
		{
			throw new System.NotImplementedException();
		}
		public void endOfStream(float error = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void removeSourceBuffer(SourceBuffer sourceBuffer)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaSource_0_
	{
		public MediaSource prototype;
		public MediaSource new()
		{
			throw new System.NotImplementedException();
		}
		public bool isTypeSupported(string type)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStream : EventTarget
	{
		protected MediaStream() : base()
		{
			
		}
		public readonly active;
		public readonly id;
		public Func<, object> onactive;
		public TrackEvent ev;
		public object any;
		public Func<, object> onaddtrack;
		public Func<, object> oninactive;
		public Func<, object> onremovetrack;
		public Func<, object> listener;
		public bool useCapture;
		public void addTrack(MediaStreamTrack track)
		{
			throw new System.NotImplementedException();
		}
		public MediaStream clone()
		{
			throw new System.NotImplementedException();
		}
		public MediaStreamTrack[] getAudioTracks()
		{
			throw new System.NotImplementedException();
		}
		public Any<MediaStreamTrack, null> getTrackById(string trackId)
		{
			throw new System.NotImplementedException();
		}
		public MediaStreamTrack[] getTracks()
		{
			throw new System.NotImplementedException();
		}
		public MediaStreamTrack[] getVideoTracks()
		{
			throw new System.NotImplementedException();
		}
		public void removeTrack(MediaStreamTrack track)
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStream_0_
	{
		public MediaStream prototype;
		public MediaStream new(Any<MediaStream, MediaStreamTrack[]> streamOrTracks = default(Any<MediaStream, MediaStreamTrack[]>))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStreamAudioSourceNode : AudioNode
	{
		protected MediaStreamAudioSourceNode() : base()
		{
			
		}
	}

		public class MediaStreamAudioSourceNode_0_
	{
		public MediaStreamAudioSourceNode prototype;
		public MediaStreamAudioSourceNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStreamError
	{
		protected MediaStreamError()
		{
			
		}
		public readonly constraintName;
		public readonly message;
		public readonly name;
	}

		public class MediaStreamError_0_
	{
		public MediaStreamError prototype;
		public MediaStreamError new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStreamErrorEvent : Event
	{
		protected MediaStreamErrorEvent() : base()
		{
			
		}
		public readonly error;
	}

		public class MediaStreamErrorEvent_0_
	{
		public MediaStreamErrorEvent prototype;
		public MediaStreamErrorEvent new(string type, MediaStreamErrorEventInit eventInitDict = default(MediaStreamErrorEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStreamTrack : EventTarget
	{
		protected MediaStreamTrack() : base()
		{
			
		}
		public bool enabled;
		public readonly id;
		public readonly kind;
		public readonly label;
		public readonly muted;
		public Func<, object> onended;
		public Event ev;
		public object any;
		public Func<, object> onmute;
		public Func<, object> onoverconstrained;
		public Func<, object> onunmute;
		public readonly readonly;
		public readonly readyState;
		public readonly remote;
		public Func<, object> listener;
		public bool useCapture;
		public PromiseLike<void> applyConstraints(MediaTrackConstraints constraints)
		{
			throw new System.NotImplementedException();
		}
		public MediaStreamTrack clone()
		{
			throw new System.NotImplementedException();
		}
		public MediaTrackCapabilities getCapabilities()
		{
			throw new System.NotImplementedException();
		}
		public MediaTrackConstraints getConstraints()
		{
			throw new System.NotImplementedException();
		}
		public MediaTrackSettings getSettings()
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStreamTrack_0_
	{
		public MediaStreamTrack prototype;
		public MediaStreamTrack new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MediaStreamTrackEvent : Event
	{
		protected MediaStreamTrackEvent() : base()
		{
			
		}
		public readonly track;
	}

		public class MediaStreamTrackEvent_0_
	{
		public MediaStreamTrackEvent prototype;
		public MediaStreamTrackEvent new(string type, MediaStreamTrackEventInit eventInitDict = default(MediaStreamTrackEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MessageChannel
	{
		protected MessageChannel()
		{
			
		}
		public readonly port1;
		public readonly port2;
	}

		public class MessageChannel_0_
	{
		public MessageChannel prototype;
		public MessageChannel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MessageEvent : Event
	{
		protected MessageEvent() : base()
		{
			
		}
		public readonly data;
		public readonly origin;
		public readonly ports;
		public readonly source;
		public void initMessageEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object dataArg, string originArg, string lastEventIdArg, IWindow sourceArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MessageEvent_0_
	{
		public MessageEvent prototype;
		public MessageEvent new(string type, MessageEventInit eventInitDict = default(MessageEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MessagePort : EventTarget
	{
		protected MessagePort() : base()
		{
			
		}
		public Func<, object> onmessage;
		public MessageEvent ev;
		public object any;
		public Func<, object> listener;
		public bool useCapture;
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public void postMessage(object message = default(object), object ports = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void start()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MessagePort_0_
	{
		public MessagePort prototype;
		public MessagePort new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MimeType
	{
		protected MimeType()
		{
			
		}
		public readonly description;
		public readonly enabledPlugin;
		public readonly suffixes;
		public readonly type;
	}

		public class MimeType_0_
	{
		public MimeType prototype;
		public MimeType new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MimeTypeArray
	{
		protected MimeTypeArray()
		{
			
		}
		public readonly length;
		public float index;
		public Plugin item(float index)
		{
			throw new System.NotImplementedException();
		}
		public Plugin namedItem(string type)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MimeTypeArray_0_
	{
		public MimeTypeArray prototype;
		public MimeTypeArray new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MouseEvent : UIEvent
	{
		protected MouseEvent() : base()
		{
			
		}
		public readonly altKey;
		public readonly button;
		public readonly buttons;
		public readonly clientX;
		public readonly clientY;
		public readonly ctrlKey;
		public readonly fromElement;
		public readonly layerX;
		public readonly layerY;
		public readonly metaKey;
		public readonly movementX;
		public readonly movementY;
		public readonly offsetX;
		public readonly offsetY;
		public readonly pageX;
		public readonly pageY;
		public readonly relatedTarget;
		public readonly screenX;
		public readonly screenY;
		public readonly shiftKey;
		public readonly toElement;
		public readonly which;
		public readonly x;
		public readonly y;
		public bool getModifierState(string keyArg)
		{
			throw new System.NotImplementedException();
		}
		public void initMouseEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MouseEvent_0_
	{
		public MouseEvent prototype;
		public MouseEvent new(string typeArg, MouseEventInit eventInitDict = default(MouseEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MutationEvent : Event
	{
		protected MutationEvent() : base()
		{
			
		}
		public readonly attrChange;
		public readonly attrName;
		public readonly newValue;
		public readonly prevValue;
		public readonly relatedNode;
		public readonly ADDITION;
		public readonly MODIFICATION;
		public readonly REMOVAL;
		public void initMutationEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Node relatedNodeArg, string prevValueArg, string newValueArg, string attrNameArg, float attrChangeArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MutationEvent_0_
	{
		public MutationEvent prototype;
		public float ADDITION;
		public float MODIFICATION;
		public float REMOVAL;
		public MutationEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MutationObserver
	{
		protected MutationObserver()
		{
			
		}
		public void disconnect()
		{
			throw new System.NotImplementedException();
		}
		public void observe(Node target, MutationObserverInit options)
		{
			throw new System.NotImplementedException();
		}
		public MutationRecord[] takeRecords()
		{
			throw new System.NotImplementedException();
		}
	}

		public class MutationObserver_0_
	{
		public MutationObserver prototype;
		public MutationObserver new(MutationCallback callback)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MutationRecord
	{
		protected MutationRecord()
		{
			
		}
		public readonly addedNodes;
		public readonly attributeName;
		public readonly attributeNamespace;
		public readonly nextSibling;
		public readonly oldValue;
		public readonly previousSibling;
		public readonly removedNodes;
		public readonly target;
		public readonly type;
	}

		public class MutationRecord_0_
	{
		public MutationRecord prototype;
		public MutationRecord new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NamedNodeMap
	{
		protected NamedNodeMap()
		{
			
		}
		public readonly length;
		public float index;
		public Attr getNamedItem(string name)
		{
			throw new System.NotImplementedException();
		}
		public Attr getNamedItemNS(Any<string, null> namespaceURI, Any<string, null> localName)
		{
			throw new System.NotImplementedException();
		}
		public Attr item(float index)
		{
			throw new System.NotImplementedException();
		}
		public Attr removeNamedItem(string name)
		{
			throw new System.NotImplementedException();
		}
		public Attr removeNamedItemNS(Any<string, null> namespaceURI, Any<string, null> localName)
		{
			throw new System.NotImplementedException();
		}
		public Attr setNamedItem(Attr arg)
		{
			throw new System.NotImplementedException();
		}
		public Attr setNamedItemNS(Attr arg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class NamedNodeMap_0_
	{
		public NamedNodeMap prototype;
		public NamedNodeMap new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NavigationCompletedEvent : NavigationEvent
	{
		protected NavigationCompletedEvent() : base()
		{
			
		}
		public readonly isSuccess;
		public readonly webErrorStatus;
	}

		public class NavigationCompletedEvent_0_
	{
		public NavigationCompletedEvent prototype;
		public NavigationCompletedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NavigationEvent : Event
	{
		protected NavigationEvent() : base()
		{
			
		}
		public readonly uri;
	}

		public class NavigationEvent_0_
	{
		public NavigationEvent prototype;
		public NavigationEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NavigationEventWithReferrer : NavigationEvent
	{
		protected NavigationEventWithReferrer() : base()
		{
			
		}
		public readonly referer;
	}

		public class NavigationEventWithReferrer_0_
	{
		public NavigationEventWithReferrer prototype;
		public NavigationEventWithReferrer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Navigator : Object, NavigatorID, NavigatorOnLine, NavigatorContentUtils, NavigatorStorageUtils, NavigatorGeolocation, MSNavigatorDoNotTrack, MSFileSaver, NavigatorUserMedia
	{
		protected Navigator() : base()
		{
			
		}
		public readonly appCodeName;
		public readonly cookieEnabled;
		public readonly language;
		public readonly maxTouchPoints;
		public readonly mimeTypes;
		public readonly msManipulationViewsEnabled;
		public readonly msMaxTouchPoints;
		public readonly msPointerEnabled;
		public readonly plugins;
		public readonly pointerEnabled;
		public readonly webdriver;
		public Gamepad[] getGamepads()
		{
			throw new System.NotImplementedException();
		}
		public bool javaEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void msLaunchUri(string uri, MSLaunchUriCallback successCallback = default(MSLaunchUriCallback), MSLaunchUriCallback noHandlerCallback = default(MSLaunchUriCallback))
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<MediaKeySystemAccess> requestMediaKeySystemAccess(string keySystem, MediaKeySystemConfiguration[] supportedConfigurations)
		{
			throw new System.NotImplementedException();
		}
		public bool vibrate(Any<float, float[]> pattern)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Navigator_0_
	{
		public Navigator prototype;
		public Navigator new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Node : EventTarget
	{
		protected Node() : base()
		{
			
		}
		public readonly attributes;
		public readonly baseURI;
		public readonly childNodes;
		public readonly firstChild;
		public readonly lastChild;
		public readonly localName;
		public readonly namespaceURI;
		public readonly nextSibling;
		public readonly nodeName;
		public readonly nodeType;
		public Any<string, null> nodeValue;
		public readonly ownerDocument;
		public readonly parentElement;
		public readonly parentNode;
		public readonly previousSibling;
		public Any<string, null> textContent;
		public readonly ATTRIBUTE_NODE;
		public readonly CDATA_SECTION_NODE;
		public readonly COMMENT_NODE;
		public readonly DOCUMENT_FRAGMENT_NODE;
		public readonly DOCUMENT_NODE;
		public readonly DOCUMENT_POSITION_CONTAINED_BY;
		public readonly DOCUMENT_POSITION_CONTAINS;
		public readonly DOCUMENT_POSITION_DISCONNECTED;
		public readonly DOCUMENT_POSITION_FOLLOWING;
		public readonly DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC;
		public readonly DOCUMENT_POSITION_PRECEDING;
		public readonly DOCUMENT_TYPE_NODE;
		public readonly ELEMENT_NODE;
		public readonly ENTITY_NODE;
		public readonly ENTITY_REFERENCE_NODE;
		public readonly NOTATION_NODE;
		public readonly PROCESSING_INSTRUCTION_NODE;
		public readonly TEXT_NODE;
		public Node appendChild(Node newChild)
		{
			throw new System.NotImplementedException();
		}
		public Node cloneNode(bool deep = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public float compareDocumentPosition(Node other)
		{
			throw new System.NotImplementedException();
		}
		public bool contains(Node child)
		{
			throw new System.NotImplementedException();
		}
		public bool hasAttributes()
		{
			throw new System.NotImplementedException();
		}
		public bool hasChildNodes()
		{
			throw new System.NotImplementedException();
		}
		public Node insertBefore(Node newChild, Any<Node, null> refChild)
		{
			throw new System.NotImplementedException();
		}
		public bool isDefaultNamespace(Any<string, null> namespaceURI)
		{
			throw new System.NotImplementedException();
		}
		public bool isEqualNode(Node arg)
		{
			throw new System.NotImplementedException();
		}
		public bool isSameNode(Node other)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> lookupNamespaceURI(Any<string, null> prefix)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> lookupPrefix(Any<string, null> namespaceURI)
		{
			throw new System.NotImplementedException();
		}
		public void normalize()
		{
			throw new System.NotImplementedException();
		}
		public Node removeChild(Node oldChild)
		{
			throw new System.NotImplementedException();
		}
		public Node replaceChild(Node newChild, Node oldChild)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Node_0_
	{
		public Node prototype;
		public float ATTRIBUTE_NODE;
		public float CDATA_SECTION_NODE;
		public float COMMENT_NODE;
		public float DOCUMENT_FRAGMENT_NODE;
		public float DOCUMENT_NODE;
		public float DOCUMENT_POSITION_CONTAINED_BY;
		public float DOCUMENT_POSITION_CONTAINS;
		public float DOCUMENT_POSITION_DISCONNECTED;
		public float DOCUMENT_POSITION_FOLLOWING;
		public float DOCUMENT_POSITION_IMPLEMENTATION_SPECIFIC;
		public float DOCUMENT_POSITION_PRECEDING;
		public float DOCUMENT_TYPE_NODE;
		public float ELEMENT_NODE;
		public float ENTITY_NODE;
		public float ENTITY_REFERENCE_NODE;
		public float NOTATION_NODE;
		public float PROCESSING_INSTRUCTION_NODE;
		public float TEXT_NODE;
		public Node new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NodeFilter
	{
		protected NodeFilter()
		{
			
		}
		public float acceptNode(Node n)
		{
			throw new System.NotImplementedException();
		}
	}

		public class NodeFilter_0_
	{
		public float FILTER_ACCEPT;
		public float FILTER_REJECT;
		public float FILTER_SKIP;
		public float SHOW_ALL;
		public float SHOW_ATTRIBUTE;
		public float SHOW_CDATA_SECTION;
		public float SHOW_COMMENT;
		public float SHOW_DOCUMENT;
		public float SHOW_DOCUMENT_FRAGMENT;
		public float SHOW_DOCUMENT_TYPE;
		public float SHOW_ELEMENT;
		public float SHOW_ENTITY;
		public float SHOW_ENTITY_REFERENCE;
		public float SHOW_NOTATION;
		public float SHOW_PROCESSING_INSTRUCTION;
		public float SHOW_TEXT;
	}

		public class NodeIterator
	{
		protected NodeIterator()
		{
			
		}
		public readonly expandEntityReferences;
		public readonly filter;
		public readonly root;
		public readonly whatToShow;
		public void detach()
		{
			throw new System.NotImplementedException();
		}
		public Node nextNode()
		{
			throw new System.NotImplementedException();
		}
		public Node previousNode()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NodeIterator_0_
	{
		public NodeIterator prototype;
		public NodeIterator new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class NodeList
	{
		protected NodeList()
		{
			
		}
		public readonly length;
		public float index;
		public Node item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class NodeList_0_
	{
		public NodeList prototype;
		public NodeList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OES_element_index_uint
	{
		protected OES_element_index_uint()
		{
			
		}
	}

		public class OES_element_index_uint_0_
	{
		public OES_element_index_uint prototype;
		public OES_element_index_uint new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OES_standard_derivatives
	{
		protected OES_standard_derivatives()
		{
			
		}
		public readonly FRAGMENT_SHADER_DERIVATIVE_HINT_OES;
	}

		public class OES_standard_derivatives_0_
	{
		public OES_standard_derivatives prototype;
		public float FRAGMENT_SHADER_DERIVATIVE_HINT_OES;
		public OES_standard_derivatives new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OES_texture_float
	{
		protected OES_texture_float()
		{
			
		}
	}

		public class OES_texture_float_0_
	{
		public OES_texture_float prototype;
		public OES_texture_float new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OES_texture_float_linear
	{
		protected OES_texture_float_linear()
		{
			
		}
	}

		public class OES_texture_float_linear_0_
	{
		public OES_texture_float_linear prototype;
		public OES_texture_float_linear new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OfflineAudioCompletionEvent : Event
	{
		protected OfflineAudioCompletionEvent() : base()
		{
			
		}
		public readonly renderedBuffer;
	}

		public class OfflineAudioCompletionEvent_0_
	{
		public OfflineAudioCompletionEvent prototype;
		public OfflineAudioCompletionEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OfflineAudioContext : AudioContext
	{
		protected OfflineAudioContext() : base()
		{
			
		}
		public Func<, object> oncomplete;
		public Event ev;
		public object any;
		public Func<, object> listener;
		public bool useCapture;
		public PromiseLike<AudioBuffer> startRendering()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class OfflineAudioContext_0_
	{
		public OfflineAudioContext prototype;
		public OfflineAudioContext new(float numberOfChannels, float length, float sampleRate)
		{
			throw new System.NotImplementedException();
		}
	}

		public class OscillatorNode : AudioNode
	{
		protected OscillatorNode() : base()
		{
			
		}
		public readonly detune;
		public readonly frequency;
		public Func<, object> onended;
		public MediaStreamErrorEvent ev;
		public object any;
		public string type;
		public Func<, object> listener;
		public bool useCapture;
		public void setPeriodicWave(PeriodicWave periodicWave)
		{
			throw new System.NotImplementedException();
		}
		public void start(float when = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void stop(float when = default(float))
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class OscillatorNode_0_
	{
		public OscillatorNode prototype;
		public OscillatorNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class OverflowEvent : UIEvent
	{
		protected OverflowEvent() : base()
		{
			
		}
		public readonly horizontalOverflow;
		public readonly orient;
		public readonly verticalOverflow;
		public readonly BOTH;
		public readonly HORIZONTAL;
		public readonly VERTICAL;
	}

		public class OverflowEvent_0_
	{
		public OverflowEvent prototype;
		public float BOTH;
		public float HORIZONTAL;
		public float VERTICAL;
		public OverflowEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PageTransitionEvent : Event
	{
		protected PageTransitionEvent() : base()
		{
			
		}
		public readonly persisted;
	}

		public class PageTransitionEvent_0_
	{
		public PageTransitionEvent prototype;
		public PageTransitionEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PannerNode : AudioNode
	{
		protected PannerNode() : base()
		{
			
		}
		public float coneInnerAngle;
		public float coneOuterAngle;
		public float coneOuterGain;
		public string distanceModel;
		public float maxDistance;
		public string panningModel;
		public float refDistance;
		public float rolloffFactor;
		public void setOrientation(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public void setPosition(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public void setVelocity(float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
	}

		public class PannerNode_0_
	{
		public PannerNode prototype;
		public PannerNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerfWidgetExternal
	{
		protected PerfWidgetExternal()
		{
			
		}
		public readonly activeNetworkRequestCount;
		public readonly averageFrameTime;
		public readonly averagePaintTime;
		public readonly extraInformationEnabled;
		public readonly independentRenderingEnabled;
		public readonly irDisablingContentString;
		public readonly irStatusAvailable;
		public readonly maxCpuSpeed;
		public readonly paintRequestsPerSecond;
		public readonly performanceCounter;
		public readonly performanceCounterFrequency;
		public void addEventListener(string eventType, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public float getMemoryUsage()
		{
			throw new System.NotImplementedException();
		}
		public float getProcessCpuUsage()
		{
			throw new System.NotImplementedException();
		}
		public object getRecentCpuUsage(Any<float, null> last)
		{
			throw new System.NotImplementedException();
		}
		public object getRecentFrames(Any<float, null> last)
		{
			throw new System.NotImplementedException();
		}
		public object getRecentMemoryUsage(Any<float, null> last)
		{
			throw new System.NotImplementedException();
		}
		public object getRecentPaintRequests(Any<float, null> last)
		{
			throw new System.NotImplementedException();
		}
		public void removeEventListener(string eventType, Function callback)
		{
			throw new System.NotImplementedException();
		}
		public void repositionWindow(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void resizeWindow(float width, float height)
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerfWidgetExternal_0_
	{
		public PerfWidgetExternal prototype;
		public PerfWidgetExternal new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Performance
	{
		protected Performance()
		{
			
		}
		public readonly navigation;
		public readonly timing;
		public void clearMarks(string markName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void clearMeasures(string measureName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void clearResourceTimings()
		{
			throw new System.NotImplementedException();
		}
		public object getEntries()
		{
			throw new System.NotImplementedException();
		}
		public object getEntriesByName(string name, string entryType = default(string))
		{
			throw new System.NotImplementedException();
		}
		public object getEntriesByType(string entryType)
		{
			throw new System.NotImplementedException();
		}
		public object getMarks(string markName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public object getMeasures(string measureName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void mark(string markName)
		{
			throw new System.NotImplementedException();
		}
		public void measure(string measureName, string startMarkName = default(string), string endMarkName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float now()
		{
			throw new System.NotImplementedException();
		}
		public void setResourceTimingBufferSize(float maxSize)
		{
			throw new System.NotImplementedException();
		}
		public object toJSON()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Performance_0_
	{
		public Performance prototype;
		public Performance new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceEntry
	{
		protected PerformanceEntry()
		{
			
		}
		public readonly duration;
		public readonly entryType;
		public readonly name;
		public readonly startTime;
	}

		public class PerformanceEntry_0_
	{
		public PerformanceEntry prototype;
		public PerformanceEntry new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceMark : PerformanceEntry
	{
		protected PerformanceMark() : base()
		{
			
		}
	}

		public class PerformanceMark_0_
	{
		public PerformanceMark prototype;
		public PerformanceMark new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceMeasure : PerformanceEntry
	{
		protected PerformanceMeasure() : base()
		{
			
		}
	}

		public class PerformanceMeasure_0_
	{
		public PerformanceMeasure prototype;
		public PerformanceMeasure new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceNavigation
	{
		protected PerformanceNavigation()
		{
			
		}
		public readonly redirectCount;
		public readonly type;
		public readonly TYPE_BACK_FORWARD;
		public readonly TYPE_NAVIGATE;
		public readonly TYPE_RELOAD;
		public readonly TYPE_RESERVED;
		public object toJSON()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceNavigation_0_
	{
		public PerformanceNavigation prototype;
		public float TYPE_BACK_FORWARD;
		public float TYPE_NAVIGATE;
		public float TYPE_RELOAD;
		public float TYPE_RESERVED;
		public PerformanceNavigation new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceNavigationTiming : PerformanceEntry
	{
		protected PerformanceNavigationTiming() : base()
		{
			
		}
		public readonly connectEnd;
		public readonly connectStart;
		public readonly domComplete;
		public readonly domContentLoadedEventEnd;
		public readonly domContentLoadedEventStart;
		public readonly domInteractive;
		public readonly domLoading;
		public readonly domainLookupEnd;
		public readonly domainLookupStart;
		public readonly fetchStart;
		public readonly loadEventEnd;
		public readonly loadEventStart;
		public readonly navigationStart;
		public readonly redirectCount;
		public readonly redirectEnd;
		public readonly redirectStart;
		public readonly requestStart;
		public readonly responseEnd;
		public readonly responseStart;
		public readonly type;
		public readonly unloadEventEnd;
		public readonly unloadEventStart;
	}

		public class PerformanceNavigationTiming_0_
	{
		public PerformanceNavigationTiming prototype;
		public PerformanceNavigationTiming new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceResourceTiming : PerformanceEntry
	{
		protected PerformanceResourceTiming() : base()
		{
			
		}
		public readonly connectEnd;
		public readonly connectStart;
		public readonly domainLookupEnd;
		public readonly domainLookupStart;
		public readonly fetchStart;
		public readonly initiatorType;
		public readonly redirectEnd;
		public readonly redirectStart;
		public readonly requestStart;
		public readonly responseEnd;
		public readonly responseStart;
	}

		public class PerformanceResourceTiming_0_
	{
		public PerformanceResourceTiming prototype;
		public PerformanceResourceTiming new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceTiming
	{
		protected PerformanceTiming()
		{
			
		}
		public readonly connectEnd;
		public readonly connectStart;
		public readonly domComplete;
		public readonly domContentLoadedEventEnd;
		public readonly domContentLoadedEventStart;
		public readonly domInteractive;
		public readonly domLoading;
		public readonly domainLookupEnd;
		public readonly domainLookupStart;
		public readonly fetchStart;
		public readonly loadEventEnd;
		public readonly loadEventStart;
		public readonly msFirstPaint;
		public readonly navigationStart;
		public readonly redirectEnd;
		public readonly redirectStart;
		public readonly requestStart;
		public readonly responseEnd;
		public readonly responseStart;
		public readonly unloadEventEnd;
		public readonly unloadEventStart;
		public readonly secureConnectionStart;
		public object toJSON()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PerformanceTiming_0_
	{
		public PerformanceTiming prototype;
		public PerformanceTiming new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PeriodicWave
	{
		protected PeriodicWave()
		{
			
		}
	}

		public class PeriodicWave_0_
	{
		public PeriodicWave prototype;
		public PeriodicWave new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PermissionRequest : DeferredPermissionRequest
	{
		protected PermissionRequest() : base()
		{
			
		}
		public readonly state;
		public void defer()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PermissionRequest_0_
	{
		public PermissionRequest prototype;
		public PermissionRequest new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PermissionRequestedEvent : Event
	{
		protected PermissionRequestedEvent() : base()
		{
			
		}
		public readonly permissionRequest;
	}

		public class PermissionRequestedEvent_0_
	{
		public PermissionRequestedEvent prototype;
		public PermissionRequestedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Plugin
	{
		protected Plugin()
		{
			
		}
		public readonly description;
		public readonly filename;
		public readonly length;
		public readonly name;
		public readonly version;
		public float index;
		public MimeType item(float index)
		{
			throw new System.NotImplementedException();
		}
		public MimeType namedItem(string type)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Plugin_0_
	{
		public Plugin prototype;
		public Plugin new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PluginArray
	{
		protected PluginArray()
		{
			
		}
		public readonly length;
		public float index;
		public Plugin item(float index)
		{
			throw new System.NotImplementedException();
		}
		public Plugin namedItem(string name)
		{
			throw new System.NotImplementedException();
		}
		public void refresh(bool reload = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class PluginArray_0_
	{
		public PluginArray prototype;
		public PluginArray new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PointerEvent : MouseEvent
	{
		protected PointerEvent() : base()
		{
			
		}
		public readonly currentPoint;
		public readonly height;
		public readonly hwTimestamp;
		public readonly intermediatePoints;
		public readonly isPrimary;
		public readonly pointerId;
		public readonly pointerType;
		public readonly pressure;
		public readonly rotation;
		public readonly tiltX;
		public readonly tiltY;
		public readonly width;
		public void getCurrentPoint(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void getIntermediatePoints(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void initPointerEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, float buttonArg, EventTarget relatedTargetArg, float offsetXArg, float offsetYArg, float widthArg, float heightArg, float pressure, float rotation, float tiltX, float tiltY, float pointerIdArg, object pointerType, float hwTimestampArg, bool isPrimary)
		{
			throw new System.NotImplementedException();
		}
	}

		public class PointerEvent_0_
	{
		public PointerEvent prototype;
		public PointerEvent new(string typeArg, PointerEventInit eventInitDict = default(PointerEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class PopStateEvent : Event
	{
		protected PopStateEvent() : base()
		{
			
		}
		public readonly state;
		public void initPopStateEvent(string typeArg, bool canBubbleArg, bool cancelableArg, object stateArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class PopStateEvent_0_
	{
		public PopStateEvent prototype;
		public PopStateEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Position
	{
		protected Position()
		{
			
		}
		public readonly coords;
		public readonly timestamp;
	}

		public class Position_0_
	{
		public Position prototype;
		public Position new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PositionError
	{
		protected PositionError()
		{
			
		}
		public readonly code;
		public readonly message;
		public readonly PERMISSION_DENIED;
		public readonly POSITION_UNAVAILABLE;
		public readonly TIMEOUT;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class PositionError_0_
	{
		public PositionError prototype;
		public float PERMISSION_DENIED;
		public float POSITION_UNAVAILABLE;
		public float TIMEOUT;
		public PositionError new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ProcessingInstruction : CharacterData
	{
		protected ProcessingInstruction() : base()
		{
			
		}
		public readonly target;
	}

		public class ProcessingInstruction_0_
	{
		public ProcessingInstruction prototype;
		public ProcessingInstruction new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ProgressEvent : Event
	{
		protected ProgressEvent() : base()
		{
			
		}
		public readonly lengthComputable;
		public readonly loaded;
		public readonly total;
		public void initProgressEvent(string typeArg, bool canBubbleArg, bool cancelableArg, bool lengthComputableArg, float loadedArg, float totalArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ProgressEvent_0_
	{
		public ProgressEvent prototype;
		public ProgressEvent new(string type, ProgressEventInit eventInitDict = default(ProgressEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCDTMFToneChangeEvent : Event
	{
		protected RTCDTMFToneChangeEvent() : base()
		{
			
		}
		public readonly tone;
	}

		public class RTCDTMFToneChangeEvent_0_
	{
		public RTCDTMFToneChangeEvent prototype;
		public RTCDTMFToneChangeEvent new(string type, RTCDTMFToneChangeEventInit eventInitDict)
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCDtlsTransport : RTCStatsProvider
	{
		protected RTCDtlsTransport() : base()
		{
			
		}
		public Func<, object> ondtlsstatechange;
		public ErrorEvent ev;
		public Func<, object> onerror;
		public readonly state;
		public readonly transport;
		public Func<, object> listener;
		public bool useCapture;
		public RTCDtlsParameters getLocalParameters()
		{
			throw new System.NotImplementedException();
		}
		public Bridge.Html5.ArrayBuffer[] getRemoteCertificates()
		{
			throw new System.NotImplementedException();
		}
		public Any<RTCDtlsParameters, null> getRemoteParameters()
		{
			throw new System.NotImplementedException();
		}
		public void start(RTCDtlsParameters remoteParameters)
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCDtlsTransport_0_
	{
		public RTCDtlsTransport prototype;
		public RTCDtlsTransport new(RTCIceTransport transport)
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCDtlsTransportStateChangedEvent : Event
	{
		protected RTCDtlsTransportStateChangedEvent() : base()
		{
			
		}
		public readonly state;
	}

		public class RTCDtlsTransportStateChangedEvent_0_
	{
		public RTCDtlsTransportStateChangedEvent prototype;
		public RTCDtlsTransportStateChangedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCDtmfSender : EventTarget
	{
		protected RTCDtmfSender() : base()
		{
			
		}
		public readonly canInsertDTMF;
		public readonly duration;
		public readonly interToneGap;
		public Func<, object> ontonechange;
		public RTCDTMFToneChangeEvent ev;
		public object any;
		public readonly sender;
		public readonly toneBuffer;
		public Func<, object> listener;
		public bool useCapture;
		public void insertDTMF(string tones, float duration = default(float), float interToneGap = default(float))
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCDtmfSender_0_
	{
		public RTCDtmfSender prototype;
		public RTCDtmfSender new(RTCRtpSender sender)
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceCandidatePairChangedEvent : Event
	{
		protected RTCIceCandidatePairChangedEvent() : base()
		{
			
		}
		public readonly pair;
	}

		public class RTCIceCandidatePairChangedEvent_0_
	{
		public RTCIceCandidatePairChangedEvent prototype;
		public RTCIceCandidatePairChangedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceGatherer : RTCStatsProvider
	{
		protected RTCIceGatherer() : base()
		{
			
		}
		public readonly component;
		public Func<, object> onerror;
		public RTCIceGathererEvent ev;
		public Func<, object> onlocalcandidate;
		public Func<, object> listener;
		public bool useCapture;
		public RTCIceGatherer createAssociatedGatherer()
		{
			throw new System.NotImplementedException();
		}
		public RTCIceCandidate[] getLocalCandidates()
		{
			throw new System.NotImplementedException();
		}
		public RTCIceParameters getLocalParameters()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceGatherer_0_
	{
		public RTCIceGatherer prototype;
		public RTCIceGatherer new(RTCIceGatherOptions options)
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceGathererEvent : Event
	{
		protected RTCIceGathererEvent() : base()
		{
			
		}
		public readonly candidate;
	}

		public class RTCIceGathererEvent_0_
	{
		public RTCIceGathererEvent prototype;
		public RTCIceGathererEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceTransport : RTCStatsProvider
	{
		protected RTCIceTransport() : base()
		{
			
		}
		public readonly component;
		public readonly iceGatherer;
		public Func<, object> oncandidatepairchange;
		public RTCIceTransportStateChangedEvent ev;
		public Func<, object> onicestatechange;
		public readonly role;
		public readonly state;
		public Func<, object> listener;
		public bool useCapture;
		public void addRemoteCandidate(Any<RTCIceCandidate, RTCIceCandidateComplete> remoteCandidate)
		{
			throw new System.NotImplementedException();
		}
		public RTCIceTransport createAssociatedTransport()
		{
			throw new System.NotImplementedException();
		}
		public Any<RTCIceCandidatePair, null> getNominatedCandidatePair()
		{
			throw new System.NotImplementedException();
		}
		public RTCIceCandidate[] getRemoteCandidates()
		{
			throw new System.NotImplementedException();
		}
		public Any<RTCIceParameters, null> getRemoteParameters()
		{
			throw new System.NotImplementedException();
		}
		public void setRemoteCandidates(RTCIceCandidate[] remoteCandidates)
		{
			throw new System.NotImplementedException();
		}
		public void start(RTCIceGatherer gatherer, RTCIceParameters remoteParameters, string role = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceTransport_0_
	{
		public RTCIceTransport prototype;
		public RTCIceTransport new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCIceTransportStateChangedEvent : Event
	{
		protected RTCIceTransportStateChangedEvent() : base()
		{
			
		}
		public readonly state;
	}

		public class RTCIceTransportStateChangedEvent_0_
	{
		public RTCIceTransportStateChangedEvent prototype;
		public RTCIceTransportStateChangedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCRtpReceiver : RTCStatsProvider
	{
		protected RTCRtpReceiver() : base()
		{
			
		}
		public Func<, object> onerror;
		public ErrorEvent ev;
		public readonly rtcpTransport;
		public readonly track;
		public readonly transport;
		public Func<, object> listener;
		public bool useCapture;
		public RTCRtpContributingSource[] getContributingSources()
		{
			throw new System.NotImplementedException();
		}
		public void receive(RTCRtpParameters parameters)
		{
			throw new System.NotImplementedException();
		}
		public void requestSendCSRC(float csrc)
		{
			throw new System.NotImplementedException();
		}
		public void setTransport(Any<RTCDtlsTransport, RTCSrtpSdesTransport> transport, RTCDtlsTransport rtcpTransport = default(RTCDtlsTransport))
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCRtpReceiver_0_
	{
		public RTCRtpReceiver prototype;
		public RTCRtpReceiver new(Any<RTCDtlsTransport, RTCSrtpSdesTransport> transport, string kind, RTCDtlsTransport rtcpTransport = default(RTCDtlsTransport))
		{
			throw new System.NotImplementedException();
		}
		public RTCRtpCapabilities getCapabilities(string kind = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCRtpSender : RTCStatsProvider
	{
		protected RTCRtpSender() : base()
		{
			
		}
		public Func<, object> onerror;
		public RTCSsrcConflictEvent ev;
		public Func<, object> onssrcconflict;
		public readonly rtcpTransport;
		public readonly track;
		public readonly transport;
		public Func<, object> listener;
		public bool useCapture;
		public void send(RTCRtpParameters parameters)
		{
			throw new System.NotImplementedException();
		}
		public void setTrack(MediaStreamTrack track)
		{
			throw new System.NotImplementedException();
		}
		public void setTransport(Any<RTCDtlsTransport, RTCSrtpSdesTransport> transport, RTCDtlsTransport rtcpTransport = default(RTCDtlsTransport))
		{
			throw new System.NotImplementedException();
		}
		public void stop()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCRtpSender_0_
	{
		public RTCRtpSender prototype;
		public RTCRtpSender new(MediaStreamTrack track, Any<RTCDtlsTransport, RTCSrtpSdesTransport> transport, RTCDtlsTransport rtcpTransport = default(RTCDtlsTransport))
		{
			throw new System.NotImplementedException();
		}
		public RTCRtpCapabilities getCapabilities(string kind = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCSrtpSdesTransport : EventTarget
	{
		protected RTCSrtpSdesTransport() : base()
		{
			
		}
		public Func<, object> onerror;
		public ErrorEvent ev;
		public readonly transport;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCSrtpSdesTransport_0_
	{
		public RTCSrtpSdesTransport prototype;
		public RTCSrtpSdesTransport new(RTCIceTransport transport, RTCSrtpSdesParameters encryptParameters, RTCSrtpSdesParameters decryptParameters)
		{
			throw new System.NotImplementedException();
		}
		public RTCSrtpSdesParameters[] getLocalParameters()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCSsrcConflictEvent : Event
	{
		protected RTCSsrcConflictEvent() : base()
		{
			
		}
		public readonly ssrc;
	}

		public class RTCSsrcConflictEvent_0_
	{
		public RTCSsrcConflictEvent prototype;
		public RTCSsrcConflictEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCStatsProvider : EventTarget
	{
		protected RTCStatsProvider() : base()
		{
			
		}
		public PromiseLike<RTCStatsReport> getStats()
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<RTCStatsReport> msGetStats()
		{
			throw new System.NotImplementedException();
		}
	}

		public class RTCStatsProvider_0_
	{
		public RTCStatsProvider prototype;
		public RTCStatsProvider new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Range
	{
		protected Range()
		{
			
		}
		public readonly collapsed;
		public readonly commonAncestorContainer;
		public readonly endContainer;
		public readonly endOffset;
		public readonly startContainer;
		public readonly startOffset;
		public readonly END_TO_END;
		public readonly END_TO_START;
		public readonly START_TO_END;
		public readonly START_TO_START;
		public DocumentFragment cloneContents()
		{
			throw new System.NotImplementedException();
		}
		public Range cloneRange()
		{
			throw new System.NotImplementedException();
		}
		public void collapse(bool toStart)
		{
			throw new System.NotImplementedException();
		}
		public float compareBoundaryPoints(float how, Range sourceRange)
		{
			throw new System.NotImplementedException();
		}
		public DocumentFragment createContextualFragment(string fragment)
		{
			throw new System.NotImplementedException();
		}
		public void deleteContents()
		{
			throw new System.NotImplementedException();
		}
		public void detach()
		{
			throw new System.NotImplementedException();
		}
		public bool expand(string Unit)
		{
			throw new System.NotImplementedException();
		}
		public DocumentFragment extractContents()
		{
			throw new System.NotImplementedException();
		}
		public ClientRect getBoundingClientRect()
		{
			throw new System.NotImplementedException();
		}
		public ClientRectList getClientRects()
		{
			throw new System.NotImplementedException();
		}
		public void insertNode(Node newNode)
		{
			throw new System.NotImplementedException();
		}
		public void selectNode(Node refNode)
		{
			throw new System.NotImplementedException();
		}
		public void selectNodeContents(Node refNode)
		{
			throw new System.NotImplementedException();
		}
		public void setEnd(Node refNode, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void setEndAfter(Node refNode)
		{
			throw new System.NotImplementedException();
		}
		public void setEndBefore(Node refNode)
		{
			throw new System.NotImplementedException();
		}
		public void setStart(Node refNode, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void setStartAfter(Node refNode)
		{
			throw new System.NotImplementedException();
		}
		public void setStartBefore(Node refNode)
		{
			throw new System.NotImplementedException();
		}
		public void surroundContents(Node newParent)
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Range_0_
	{
		public Range prototype;
		public float END_TO_END;
		public float END_TO_START;
		public float START_TO_END;
		public float START_TO_START;
		public Range new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGURIReference
	{
		protected SVGAElement() : base()
		{
			
		}
		public readonly target;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAElement_0_
	{
		public SVGAElement prototype;
		public SVGAElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAngle
	{
		protected SVGAngle()
		{
			
		}
		public readonly unitType;
		public float value;
		public string valueAsString;
		public float valueInSpecifiedUnits;
		public readonly SVG_ANGLETYPE_DEG;
		public readonly SVG_ANGLETYPE_GRAD;
		public readonly SVG_ANGLETYPE_RAD;
		public readonly SVG_ANGLETYPE_UNKNOWN;
		public readonly SVG_ANGLETYPE_UNSPECIFIED;
		public void convertToSpecifiedUnits(float unitType)
		{
			throw new System.NotImplementedException();
		}
		public void newValueSpecifiedUnits(float unitType, float valueInSpecifiedUnits)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAngle_0_
	{
		public SVGAngle prototype;
		public float SVG_ANGLETYPE_DEG;
		public float SVG_ANGLETYPE_GRAD;
		public float SVG_ANGLETYPE_RAD;
		public float SVG_ANGLETYPE_UNKNOWN;
		public float SVG_ANGLETYPE_UNSPECIFIED;
		public SVGAngle new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedAngle
	{
		protected SVGAnimatedAngle()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedAngle_0_
	{
		public SVGAnimatedAngle prototype;
		public SVGAnimatedAngle new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedBoolean
	{
		protected SVGAnimatedBoolean()
		{
			
		}
		public readonly animVal;
		public bool baseVal;
	}

		public class SVGAnimatedBoolean_0_
	{
		public SVGAnimatedBoolean prototype;
		public SVGAnimatedBoolean new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedEnumeration
	{
		protected SVGAnimatedEnumeration()
		{
			
		}
		public readonly animVal;
		public float baseVal;
	}

		public class SVGAnimatedEnumeration_0_
	{
		public SVGAnimatedEnumeration prototype;
		public SVGAnimatedEnumeration new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedInteger
	{
		protected SVGAnimatedInteger()
		{
			
		}
		public readonly animVal;
		public float baseVal;
	}

		public class SVGAnimatedInteger_0_
	{
		public SVGAnimatedInteger prototype;
		public SVGAnimatedInteger new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedLength
	{
		protected SVGAnimatedLength()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedLength_0_
	{
		public SVGAnimatedLength prototype;
		public SVGAnimatedLength new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedLengthList
	{
		protected SVGAnimatedLengthList()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedLengthList_0_
	{
		public SVGAnimatedLengthList prototype;
		public SVGAnimatedLengthList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedNumber
	{
		protected SVGAnimatedNumber()
		{
			
		}
		public readonly animVal;
		public float baseVal;
	}

		public class SVGAnimatedNumber_0_
	{
		public SVGAnimatedNumber prototype;
		public SVGAnimatedNumber new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedNumberList
	{
		protected SVGAnimatedNumberList()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedNumberList_0_
	{
		public SVGAnimatedNumberList prototype;
		public SVGAnimatedNumberList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedPreserveAspectRatio
	{
		protected SVGAnimatedPreserveAspectRatio()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedPreserveAspectRatio_0_
	{
		public SVGAnimatedPreserveAspectRatio prototype;
		public SVGAnimatedPreserveAspectRatio new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedRect
	{
		protected SVGAnimatedRect()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedRect_0_
	{
		public SVGAnimatedRect prototype;
		public SVGAnimatedRect new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedString
	{
		protected SVGAnimatedString()
		{
			
		}
		public readonly animVal;
		public string baseVal;
	}

		public class SVGAnimatedString_0_
	{
		public SVGAnimatedString prototype;
		public SVGAnimatedString new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedTransformList
	{
		protected SVGAnimatedTransformList()
		{
			
		}
		public readonly animVal;
		public readonly baseVal;
	}

		public class SVGAnimatedTransformList_0_
	{
		public SVGAnimatedTransformList prototype;
		public SVGAnimatedTransformList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGCircleElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGCircleElement() : base()
		{
			
		}
		public readonly cx;
		public readonly cy;
		public readonly r;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGCircleElement_0_
	{
		public SVGCircleElement prototype;
		public SVGCircleElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGClipPathElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGUnitTypes
	{
		protected SVGClipPathElement() : base()
		{
			
		}
		public readonly clipPathUnits;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGClipPathElement_0_
	{
		public SVGClipPathElement prototype;
		public SVGClipPathElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGComponentTransferFunctionElement : SVGElement
	{
		protected SVGComponentTransferFunctionElement() : base()
		{
			
		}
		public readonly amplitude;
		public readonly exponent;
		public readonly intercept;
		public readonly offset;
		public readonly slope;
		public readonly tableValues;
		public readonly type;
		public readonly SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE;
		public readonly SVG_FECOMPONENTTRANSFER_TYPE_GAMMA;
		public readonly SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY;
		public readonly SVG_FECOMPONENTTRANSFER_TYPE_LINEAR;
		public readonly SVG_FECOMPONENTTRANSFER_TYPE_TABLE;
		public readonly SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN;
	}

		public class SVGComponentTransferFunctionElement_0_
	{
		public SVGComponentTransferFunctionElement prototype;
		public float SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE;
		public float SVG_FECOMPONENTTRANSFER_TYPE_GAMMA;
		public float SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY;
		public float SVG_FECOMPONENTTRANSFER_TYPE_LINEAR;
		public float SVG_FECOMPONENTTRANSFER_TYPE_TABLE;
		public float SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN;
		public SVGComponentTransferFunctionElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGDefsElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGDefsElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGDefsElement_0_
	{
		public SVGDefsElement prototype;
		public SVGDefsElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGDescElement : SVGElement, SVGStylable, SVGLangSpace
	{
		protected SVGDescElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGDescElement_0_
	{
		public SVGDescElement prototype;
		public SVGDescElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGElement : Element
	{
		protected SVGElement() : base()
		{
			
		}
		public Func<, object> onclick;
		public WheelEvent ev;
		public object any;
		public Func<, object> ondblclick;
		public Func<, object> onfocusin;
		public Func<, object> onfocusout;
		public Func<, object> onload;
		public Func<, object> onmousedown;
		public Func<, object> onmousemove;
		public Func<, object> onmouseout;
		public Func<, object> onmouseover;
		public Func<, object> onmouseup;
		public readonly ownerSVGElement;
		public readonly viewportElement;
		public string xmlbase;
		public object className;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGElement_0_
	{
		public SVGElement prototype;
		public SVGElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGElementInstance : EventTarget
	{
		protected SVGElementInstance() : base()
		{
			
		}
		public readonly childNodes;
		public readonly correspondingElement;
		public readonly correspondingUseElement;
		public readonly firstChild;
		public readonly lastChild;
		public readonly nextSibling;
		public readonly parentNode;
		public readonly previousSibling;
	}

		public class SVGElementInstance_0_
	{
		public SVGElementInstance prototype;
		public SVGElementInstance new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGElementInstanceList
	{
		protected SVGElementInstanceList()
		{
			
		}
		public readonly length;
		public SVGElementInstance item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGElementInstanceList_0_
	{
		public SVGElementInstanceList prototype;
		public SVGElementInstanceList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGEllipseElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGEllipseElement() : base()
		{
			
		}
		public readonly cx;
		public readonly cy;
		public readonly rx;
		public readonly ry;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGEllipseElement_0_
	{
		public SVGEllipseElement prototype;
		public SVGEllipseElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEBlendElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEBlendElement() : base()
		{
			
		}
		public readonly in1;
		public readonly in2;
		public readonly mode;
		public readonly SVG_FEBLEND_MODE_COLOR;
		public readonly SVG_FEBLEND_MODE_COLOR_BURN;
		public readonly SVG_FEBLEND_MODE_COLOR_DODGE;
		public readonly SVG_FEBLEND_MODE_DARKEN;
		public readonly SVG_FEBLEND_MODE_DIFFERENCE;
		public readonly SVG_FEBLEND_MODE_EXCLUSION;
		public readonly SVG_FEBLEND_MODE_HARD_LIGHT;
		public readonly SVG_FEBLEND_MODE_HUE;
		public readonly SVG_FEBLEND_MODE_LIGHTEN;
		public readonly SVG_FEBLEND_MODE_LUMINOSITY;
		public readonly SVG_FEBLEND_MODE_MULTIPLY;
		public readonly SVG_FEBLEND_MODE_NORMAL;
		public readonly SVG_FEBLEND_MODE_OVERLAY;
		public readonly SVG_FEBLEND_MODE_SATURATION;
		public readonly SVG_FEBLEND_MODE_SCREEN;
		public readonly SVG_FEBLEND_MODE_SOFT_LIGHT;
		public readonly SVG_FEBLEND_MODE_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEBlendElement_0_
	{
		public SVGFEBlendElement prototype;
		public float SVG_FEBLEND_MODE_COLOR;
		public float SVG_FEBLEND_MODE_COLOR_BURN;
		public float SVG_FEBLEND_MODE_COLOR_DODGE;
		public float SVG_FEBLEND_MODE_DARKEN;
		public float SVG_FEBLEND_MODE_DIFFERENCE;
		public float SVG_FEBLEND_MODE_EXCLUSION;
		public float SVG_FEBLEND_MODE_HARD_LIGHT;
		public float SVG_FEBLEND_MODE_HUE;
		public float SVG_FEBLEND_MODE_LIGHTEN;
		public float SVG_FEBLEND_MODE_LUMINOSITY;
		public float SVG_FEBLEND_MODE_MULTIPLY;
		public float SVG_FEBLEND_MODE_NORMAL;
		public float SVG_FEBLEND_MODE_OVERLAY;
		public float SVG_FEBLEND_MODE_SATURATION;
		public float SVG_FEBLEND_MODE_SCREEN;
		public float SVG_FEBLEND_MODE_SOFT_LIGHT;
		public float SVG_FEBLEND_MODE_UNKNOWN;
		public SVGFEBlendElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEColorMatrixElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEColorMatrixElement() : base()
		{
			
		}
		public readonly in1;
		public readonly type;
		public readonly values;
		public readonly SVG_FECOLORMATRIX_TYPE_HUEROTATE;
		public readonly SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA;
		public readonly SVG_FECOLORMATRIX_TYPE_MATRIX;
		public readonly SVG_FECOLORMATRIX_TYPE_SATURATE;
		public readonly SVG_FECOLORMATRIX_TYPE_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEColorMatrixElement_0_
	{
		public SVGFEColorMatrixElement prototype;
		public float SVG_FECOLORMATRIX_TYPE_HUEROTATE;
		public float SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA;
		public float SVG_FECOLORMATRIX_TYPE_MATRIX;
		public float SVG_FECOLORMATRIX_TYPE_SATURATE;
		public float SVG_FECOLORMATRIX_TYPE_UNKNOWN;
		public SVGFEColorMatrixElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEComponentTransferElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEComponentTransferElement() : base()
		{
			
		}
		public readonly in1;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEComponentTransferElement_0_
	{
		public SVGFEComponentTransferElement prototype;
		public SVGFEComponentTransferElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFECompositeElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFECompositeElement() : base()
		{
			
		}
		public readonly in1;
		public readonly in2;
		public readonly k1;
		public readonly k2;
		public readonly k3;
		public readonly k4;
		public readonly operator;
		public readonly SVG_FECOMPOSITE_OPERATOR_ARITHMETIC;
		public readonly SVG_FECOMPOSITE_OPERATOR_ATOP;
		public readonly SVG_FECOMPOSITE_OPERATOR_IN;
		public readonly SVG_FECOMPOSITE_OPERATOR_OUT;
		public readonly SVG_FECOMPOSITE_OPERATOR_OVER;
		public readonly SVG_FECOMPOSITE_OPERATOR_UNKNOWN;
		public readonly SVG_FECOMPOSITE_OPERATOR_XOR;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFECompositeElement_0_
	{
		public SVGFECompositeElement prototype;
		public float SVG_FECOMPOSITE_OPERATOR_ARITHMETIC;
		public float SVG_FECOMPOSITE_OPERATOR_ATOP;
		public float SVG_FECOMPOSITE_OPERATOR_IN;
		public float SVG_FECOMPOSITE_OPERATOR_OUT;
		public float SVG_FECOMPOSITE_OPERATOR_OVER;
		public float SVG_FECOMPOSITE_OPERATOR_UNKNOWN;
		public float SVG_FECOMPOSITE_OPERATOR_XOR;
		public SVGFECompositeElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEConvolveMatrixElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEConvolveMatrixElement() : base()
		{
			
		}
		public readonly bias;
		public readonly divisor;
		public readonly edgeMode;
		public readonly in1;
		public readonly kernelMatrix;
		public readonly kernelUnitLengthX;
		public readonly kernelUnitLengthY;
		public readonly orderX;
		public readonly orderY;
		public readonly preserveAlpha;
		public readonly targetX;
		public readonly targetY;
		public readonly SVG_EDGEMODE_DUPLICATE;
		public readonly SVG_EDGEMODE_NONE;
		public readonly SVG_EDGEMODE_UNKNOWN;
		public readonly SVG_EDGEMODE_WRAP;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEConvolveMatrixElement_0_
	{
		public SVGFEConvolveMatrixElement prototype;
		public float SVG_EDGEMODE_DUPLICATE;
		public float SVG_EDGEMODE_NONE;
		public float SVG_EDGEMODE_UNKNOWN;
		public float SVG_EDGEMODE_WRAP;
		public SVGFEConvolveMatrixElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEDiffuseLightingElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEDiffuseLightingElement() : base()
		{
			
		}
		public readonly diffuseConstant;
		public readonly in1;
		public readonly kernelUnitLengthX;
		public readonly kernelUnitLengthY;
		public readonly surfaceScale;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEDiffuseLightingElement_0_
	{
		public SVGFEDiffuseLightingElement prototype;
		public SVGFEDiffuseLightingElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEDisplacementMapElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEDisplacementMapElement() : base()
		{
			
		}
		public readonly in1;
		public readonly in2;
		public readonly scale;
		public readonly xChannelSelector;
		public readonly yChannelSelector;
		public readonly SVG_CHANNEL_A;
		public readonly SVG_CHANNEL_B;
		public readonly SVG_CHANNEL_G;
		public readonly SVG_CHANNEL_R;
		public readonly SVG_CHANNEL_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEDisplacementMapElement_0_
	{
		public SVGFEDisplacementMapElement prototype;
		public float SVG_CHANNEL_A;
		public float SVG_CHANNEL_B;
		public float SVG_CHANNEL_G;
		public float SVG_CHANNEL_R;
		public float SVG_CHANNEL_UNKNOWN;
		public SVGFEDisplacementMapElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEDistantLightElement : SVGElement
	{
		protected SVGFEDistantLightElement() : base()
		{
			
		}
		public readonly azimuth;
		public readonly elevation;
	}

		public class SVGFEDistantLightElement_0_
	{
		public SVGFEDistantLightElement prototype;
		public SVGFEDistantLightElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEFloodElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEFloodElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEFloodElement_0_
	{
		public SVGFEFloodElement prototype;
		public SVGFEFloodElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEFuncAElement : SVGComponentTransferFunctionElement
	{
		protected SVGFEFuncAElement() : base()
		{
			
		}
	}

		public class SVGFEFuncAElement_0_
	{
		public SVGFEFuncAElement prototype;
		public SVGFEFuncAElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEFuncBElement : SVGComponentTransferFunctionElement
	{
		protected SVGFEFuncBElement() : base()
		{
			
		}
	}

		public class SVGFEFuncBElement_0_
	{
		public SVGFEFuncBElement prototype;
		public SVGFEFuncBElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEFuncGElement : SVGComponentTransferFunctionElement
	{
		protected SVGFEFuncGElement() : base()
		{
			
		}
	}

		public class SVGFEFuncGElement_0_
	{
		public SVGFEFuncGElement prototype;
		public SVGFEFuncGElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEFuncRElement : SVGComponentTransferFunctionElement
	{
		protected SVGFEFuncRElement() : base()
		{
			
		}
	}

		public class SVGFEFuncRElement_0_
	{
		public SVGFEFuncRElement prototype;
		public SVGFEFuncRElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEGaussianBlurElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEGaussianBlurElement() : base()
		{
			
		}
		public readonly in1;
		public readonly stdDeviationX;
		public readonly stdDeviationY;
		public void setStdDeviation(float stdDeviationX, float stdDeviationY)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEGaussianBlurElement_0_
	{
		public SVGFEGaussianBlurElement prototype;
		public SVGFEGaussianBlurElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEImageElement : SVGElement, SVGFilterPrimitiveStandardAttributes, SVGLangSpace, SVGURIReference, SVGExternalResourcesRequired
	{
		protected SVGFEImageElement() : base()
		{
			
		}
		public readonly preserveAspectRatio;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEImageElement_0_
	{
		public SVGFEImageElement prototype;
		public SVGFEImageElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEMergeElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEMergeElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEMergeElement_0_
	{
		public SVGFEMergeElement prototype;
		public SVGFEMergeElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEMergeNodeElement : SVGElement
	{
		protected SVGFEMergeNodeElement() : base()
		{
			
		}
		public readonly in1;
	}

		public class SVGFEMergeNodeElement_0_
	{
		public SVGFEMergeNodeElement prototype;
		public SVGFEMergeNodeElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEMorphologyElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEMorphologyElement() : base()
		{
			
		}
		public readonly in1;
		public readonly operator;
		public readonly radiusX;
		public readonly radiusY;
		public readonly SVG_MORPHOLOGY_OPERATOR_DILATE;
		public readonly SVG_MORPHOLOGY_OPERATOR_ERODE;
		public readonly SVG_MORPHOLOGY_OPERATOR_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEMorphologyElement_0_
	{
		public SVGFEMorphologyElement prototype;
		public float SVG_MORPHOLOGY_OPERATOR_DILATE;
		public float SVG_MORPHOLOGY_OPERATOR_ERODE;
		public float SVG_MORPHOLOGY_OPERATOR_UNKNOWN;
		public SVGFEMorphologyElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEOffsetElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFEOffsetElement() : base()
		{
			
		}
		public readonly dx;
		public readonly dy;
		public readonly in1;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEOffsetElement_0_
	{
		public SVGFEOffsetElement prototype;
		public SVGFEOffsetElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFEPointLightElement : SVGElement
	{
		protected SVGFEPointLightElement() : base()
		{
			
		}
		public readonly x;
		public readonly y;
		public readonly z;
	}

		public class SVGFEPointLightElement_0_
	{
		public SVGFEPointLightElement prototype;
		public SVGFEPointLightElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFESpecularLightingElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFESpecularLightingElement() : base()
		{
			
		}
		public readonly in1;
		public readonly kernelUnitLengthX;
		public readonly kernelUnitLengthY;
		public readonly specularConstant;
		public readonly specularExponent;
		public readonly surfaceScale;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFESpecularLightingElement_0_
	{
		public SVGFESpecularLightingElement prototype;
		public SVGFESpecularLightingElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFESpotLightElement : SVGElement
	{
		protected SVGFESpotLightElement() : base()
		{
			
		}
		public readonly limitingConeAngle;
		public readonly pointsAtX;
		public readonly pointsAtY;
		public readonly pointsAtZ;
		public readonly specularExponent;
		public readonly x;
		public readonly y;
		public readonly z;
	}

		public class SVGFESpotLightElement_0_
	{
		public SVGFESpotLightElement prototype;
		public SVGFESpotLightElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFETileElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFETileElement() : base()
		{
			
		}
		public readonly in1;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFETileElement_0_
	{
		public SVGFETileElement prototype;
		public SVGFETileElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFETurbulenceElement : SVGElement, SVGFilterPrimitiveStandardAttributes
	{
		protected SVGFETurbulenceElement() : base()
		{
			
		}
		public readonly baseFrequencyX;
		public readonly baseFrequencyY;
		public readonly numOctaves;
		public readonly seed;
		public readonly stitchTiles;
		public readonly type;
		public readonly SVG_STITCHTYPE_NOSTITCH;
		public readonly SVG_STITCHTYPE_STITCH;
		public readonly SVG_STITCHTYPE_UNKNOWN;
		public readonly SVG_TURBULENCE_TYPE_FRACTALNOISE;
		public readonly SVG_TURBULENCE_TYPE_TURBULENCE;
		public readonly SVG_TURBULENCE_TYPE_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFETurbulenceElement_0_
	{
		public SVGFETurbulenceElement prototype;
		public float SVG_STITCHTYPE_NOSTITCH;
		public float SVG_STITCHTYPE_STITCH;
		public float SVG_STITCHTYPE_UNKNOWN;
		public float SVG_TURBULENCE_TYPE_FRACTALNOISE;
		public float SVG_TURBULENCE_TYPE_TURBULENCE;
		public float SVG_TURBULENCE_TYPE_UNKNOWN;
		public SVGFETurbulenceElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFilterElement : SVGElement, SVGUnitTypes, SVGStylable, SVGLangSpace, SVGURIReference, SVGExternalResourcesRequired
	{
		protected SVGFilterElement() : base()
		{
			
		}
		public readonly filterResX;
		public readonly filterResY;
		public readonly filterUnits;
		public readonly height;
		public readonly primitiveUnits;
		public readonly width;
		public readonly x;
		public readonly y;
		public void setFilterRes(float filterResX, float filterResY)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGFilterElement_0_
	{
		public SVGFilterElement prototype;
		public SVGFilterElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGForeignObjectElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGForeignObjectElement() : base()
		{
			
		}
		public readonly height;
		public readonly width;
		public readonly x;
		public readonly y;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGForeignObjectElement_0_
	{
		public SVGForeignObjectElement prototype;
		public SVGForeignObjectElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGGElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGGElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGGElement_0_
	{
		public SVGGElement prototype;
		public SVGGElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGGradientElement : SVGElement, SVGStylable, SVGExternalResourcesRequired, SVGURIReference, SVGUnitTypes
	{
		protected SVGGradientElement() : base()
		{
			
		}
		public readonly gradientTransform;
		public readonly gradientUnits;
		public readonly spreadMethod;
		public readonly SVG_SPREADMETHOD_PAD;
		public readonly SVG_SPREADMETHOD_REFLECT;
		public readonly SVG_SPREADMETHOD_REPEAT;
		public readonly SVG_SPREADMETHOD_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGGradientElement_0_
	{
		public SVGGradientElement prototype;
		public float SVG_SPREADMETHOD_PAD;
		public float SVG_SPREADMETHOD_REFLECT;
		public float SVG_SPREADMETHOD_REPEAT;
		public float SVG_SPREADMETHOD_UNKNOWN;
		public SVGGradientElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGImageElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGURIReference
	{
		protected SVGImageElement() : base()
		{
			
		}
		public readonly height;
		public readonly preserveAspectRatio;
		public readonly width;
		public readonly x;
		public readonly y;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGImageElement_0_
	{
		public SVGImageElement prototype;
		public SVGImageElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLength
	{
		protected SVGLength()
		{
			
		}
		public readonly unitType;
		public float value;
		public string valueAsString;
		public float valueInSpecifiedUnits;
		public readonly SVG_LENGTHTYPE_CM;
		public readonly SVG_LENGTHTYPE_EMS;
		public readonly SVG_LENGTHTYPE_EXS;
		public readonly SVG_LENGTHTYPE_IN;
		public readonly SVG_LENGTHTYPE_MM;
		public readonly SVG_LENGTHTYPE_NUMBER;
		public readonly SVG_LENGTHTYPE_PC;
		public readonly SVG_LENGTHTYPE_PERCENTAGE;
		public readonly SVG_LENGTHTYPE_PT;
		public readonly SVG_LENGTHTYPE_PX;
		public readonly SVG_LENGTHTYPE_UNKNOWN;
		public void convertToSpecifiedUnits(float unitType)
		{
			throw new System.NotImplementedException();
		}
		public void newValueSpecifiedUnits(float unitType, float valueInSpecifiedUnits)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLength_0_
	{
		public SVGLength prototype;
		public float SVG_LENGTHTYPE_CM;
		public float SVG_LENGTHTYPE_EMS;
		public float SVG_LENGTHTYPE_EXS;
		public float SVG_LENGTHTYPE_IN;
		public float SVG_LENGTHTYPE_MM;
		public float SVG_LENGTHTYPE_NUMBER;
		public float SVG_LENGTHTYPE_PC;
		public float SVG_LENGTHTYPE_PERCENTAGE;
		public float SVG_LENGTHTYPE_PT;
		public float SVG_LENGTHTYPE_PX;
		public float SVG_LENGTHTYPE_UNKNOWN;
		public SVGLength new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLengthList
	{
		protected SVGLengthList()
		{
			
		}
		public readonly numberOfItems;
		public SVGLength appendItem(SVGLength newItem)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public SVGLength getItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGLength initialize(SVGLength newItem)
		{
			throw new System.NotImplementedException();
		}
		public SVGLength insertItemBefore(SVGLength newItem, float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGLength removeItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGLength replaceItem(SVGLength newItem, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLengthList_0_
	{
		public SVGLengthList prototype;
		public SVGLengthList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLineElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGLineElement() : base()
		{
			
		}
		public readonly x1;
		public readonly x2;
		public readonly y1;
		public readonly y2;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLineElement_0_
	{
		public SVGLineElement prototype;
		public SVGLineElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGLinearGradientElement : SVGGradientElement
	{
		protected SVGLinearGradientElement() : base()
		{
			
		}
		public readonly x1;
		public readonly x2;
		public readonly y1;
		public readonly y2;
	}

		public class SVGLinearGradientElement_0_
	{
		public SVGLinearGradientElement prototype;
		public SVGLinearGradientElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMarkerElement : SVGElement, SVGStylable, SVGLangSpace, SVGExternalResourcesRequired, SVGFitToViewBox
	{
		protected SVGMarkerElement() : base()
		{
			
		}
		public readonly markerHeight;
		public readonly markerUnits;
		public readonly markerWidth;
		public readonly orientAngle;
		public readonly orientType;
		public readonly refX;
		public readonly refY;
		public readonly SVG_MARKERUNITS_STROKEWIDTH;
		public readonly SVG_MARKERUNITS_UNKNOWN;
		public readonly SVG_MARKERUNITS_USERSPACEONUSE;
		public readonly SVG_MARKER_ORIENT_ANGLE;
		public readonly SVG_MARKER_ORIENT_AUTO;
		public readonly SVG_MARKER_ORIENT_UNKNOWN;
		public void setOrientToAngle(SVGAngle angle)
		{
			throw new System.NotImplementedException();
		}
		public void setOrientToAuto()
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMarkerElement_0_
	{
		public SVGMarkerElement prototype;
		public float SVG_MARKERUNITS_STROKEWIDTH;
		public float SVG_MARKERUNITS_UNKNOWN;
		public float SVG_MARKERUNITS_USERSPACEONUSE;
		public float SVG_MARKER_ORIENT_ANGLE;
		public float SVG_MARKER_ORIENT_AUTO;
		public float SVG_MARKER_ORIENT_UNKNOWN;
		public SVGMarkerElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMaskElement : SVGElement, SVGStylable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGUnitTypes
	{
		protected SVGMaskElement() : base()
		{
			
		}
		public readonly height;
		public readonly maskContentUnits;
		public readonly maskUnits;
		public readonly width;
		public readonly x;
		public readonly y;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMaskElement_0_
	{
		public SVGMaskElement prototype;
		public SVGMaskElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMatrix
	{
		protected SVGMatrix()
		{
			
		}
		public float a;
		public float b;
		public float c;
		public float d;
		public float e;
		public float f;
		public SVGMatrix flipX()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix flipY()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix inverse()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix multiply(SVGMatrix secondMatrix)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix rotate(float angle)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix rotateFromVector(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix scale(float scaleFactor)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix scaleNonUniform(float scaleFactorX, float scaleFactorY)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix skewX(float angle)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix skewY(float angle)
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix translate(float x, float y)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMatrix_0_
	{
		public SVGMatrix prototype;
		public SVGMatrix new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGMetadataElement : SVGElement
	{
		protected SVGMetadataElement() : base()
		{
			
		}
	}

		public class SVGMetadataElement_0_
	{
		public SVGMetadataElement prototype;
		public SVGMetadataElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGNumber
	{
		protected SVGNumber()
		{
			
		}
		public float value;
	}

		public class SVGNumber_0_
	{
		public SVGNumber prototype;
		public SVGNumber new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGNumberList
	{
		protected SVGNumberList()
		{
			
		}
		public readonly numberOfItems;
		public SVGNumber appendItem(SVGNumber newItem)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public SVGNumber getItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGNumber initialize(SVGNumber newItem)
		{
			throw new System.NotImplementedException();
		}
		public SVGNumber insertItemBefore(SVGNumber newItem, float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGNumber removeItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGNumber replaceItem(SVGNumber newItem, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGNumberList_0_
	{
		public SVGNumberList prototype;
		public SVGNumberList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGAnimatedPathData
	{
		protected SVGPathElement() : base()
		{
			
		}
		public SVGPathSegArcAbs createSVGPathSegArcAbs(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegArcRel createSVGPathSegArcRel(float x, float y, float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegClosePath createSVGPathSegClosePath()
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoCubicAbs createSVGPathSegCurvetoCubicAbs(float x, float y, float x1, float y1, float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoCubicRel createSVGPathSegCurvetoCubicRel(float x, float y, float x1, float y1, float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoCubicSmoothAbs createSVGPathSegCurvetoCubicSmoothAbs(float x, float y, float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoCubicSmoothRel createSVGPathSegCurvetoCubicSmoothRel(float x, float y, float x2, float y2)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoQuadraticAbs createSVGPathSegCurvetoQuadraticAbs(float x, float y, float x1, float y1)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoQuadraticRel createSVGPathSegCurvetoQuadraticRel(float x, float y, float x1, float y1)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoQuadraticSmoothAbs createSVGPathSegCurvetoQuadraticSmoothAbs(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegCurvetoQuadraticSmoothRel createSVGPathSegCurvetoQuadraticSmoothRel(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegLinetoAbs createSVGPathSegLinetoAbs(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegLinetoHorizontalAbs createSVGPathSegLinetoHorizontalAbs(float x)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegLinetoHorizontalRel createSVGPathSegLinetoHorizontalRel(float x)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegLinetoRel createSVGPathSegLinetoRel(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegLinetoVerticalAbs createSVGPathSegLinetoVerticalAbs(float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegLinetoVerticalRel createSVGPathSegLinetoVerticalRel(float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegMovetoAbs createSVGPathSegMovetoAbs(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSegMovetoRel createSVGPathSegMovetoRel(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public float getPathSegAtLength(float distance)
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint getPointAtLength(float distance)
		{
			throw new System.NotImplementedException();
		}
		public float getTotalLength()
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathElement_0_
	{
		public SVGPathElement prototype;
		public SVGPathElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSeg
	{
		protected SVGPathSeg()
		{
			
		}
		public readonly pathSegType;
		public readonly pathSegTypeAsLetter;
		public readonly PATHSEG_ARC_ABS;
		public readonly PATHSEG_ARC_REL;
		public readonly PATHSEG_CLOSEPATH;
		public readonly PATHSEG_CURVETO_CUBIC_ABS;
		public readonly PATHSEG_CURVETO_CUBIC_REL;
		public readonly PATHSEG_CURVETO_CUBIC_SMOOTH_ABS;
		public readonly PATHSEG_CURVETO_CUBIC_SMOOTH_REL;
		public readonly PATHSEG_CURVETO_QUADRATIC_ABS;
		public readonly PATHSEG_CURVETO_QUADRATIC_REL;
		public readonly PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS;
		public readonly PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL;
		public readonly PATHSEG_LINETO_ABS;
		public readonly PATHSEG_LINETO_HORIZONTAL_ABS;
		public readonly PATHSEG_LINETO_HORIZONTAL_REL;
		public readonly PATHSEG_LINETO_REL;
		public readonly PATHSEG_LINETO_VERTICAL_ABS;
		public readonly PATHSEG_LINETO_VERTICAL_REL;
		public readonly PATHSEG_MOVETO_ABS;
		public readonly PATHSEG_MOVETO_REL;
		public readonly PATHSEG_UNKNOWN;
	}

		public class SVGPathSeg_0_
	{
		public SVGPathSeg prototype;
		public float PATHSEG_ARC_ABS;
		public float PATHSEG_ARC_REL;
		public float PATHSEG_CLOSEPATH;
		public float PATHSEG_CURVETO_CUBIC_ABS;
		public float PATHSEG_CURVETO_CUBIC_REL;
		public float PATHSEG_CURVETO_CUBIC_SMOOTH_ABS;
		public float PATHSEG_CURVETO_CUBIC_SMOOTH_REL;
		public float PATHSEG_CURVETO_QUADRATIC_ABS;
		public float PATHSEG_CURVETO_QUADRATIC_REL;
		public float PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS;
		public float PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL;
		public float PATHSEG_LINETO_ABS;
		public float PATHSEG_LINETO_HORIZONTAL_ABS;
		public float PATHSEG_LINETO_HORIZONTAL_REL;
		public float PATHSEG_LINETO_REL;
		public float PATHSEG_LINETO_VERTICAL_ABS;
		public float PATHSEG_LINETO_VERTICAL_REL;
		public float PATHSEG_MOVETO_ABS;
		public float PATHSEG_MOVETO_REL;
		public float PATHSEG_UNKNOWN;
		public SVGPathSeg new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegArcAbs : SVGPathSeg
	{
		protected SVGPathSegArcAbs() : base()
		{
			
		}
		public float angle;
		public bool largeArcFlag;
		public float r1;
		public float r2;
		public bool sweepFlag;
		public float x;
		public float y;
	}

		public class SVGPathSegArcAbs_0_
	{
		public SVGPathSegArcAbs prototype;
		public SVGPathSegArcAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegArcRel : SVGPathSeg
	{
		protected SVGPathSegArcRel() : base()
		{
			
		}
		public float angle;
		public bool largeArcFlag;
		public float r1;
		public float r2;
		public bool sweepFlag;
		public float x;
		public float y;
	}

		public class SVGPathSegArcRel_0_
	{
		public SVGPathSegArcRel prototype;
		public SVGPathSegArcRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegClosePath : SVGPathSeg
	{
		protected SVGPathSegClosePath() : base()
		{
			
		}
	}

		public class SVGPathSegClosePath_0_
	{
		public SVGPathSegClosePath prototype;
		public SVGPathSegClosePath new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoCubicAbs : SVGPathSeg
	{
		protected SVGPathSegCurvetoCubicAbs() : base()
		{
			
		}
		public float x;
		public float x1;
		public float x2;
		public float y;
		public float y1;
		public float y2;
	}

		public class SVGPathSegCurvetoCubicAbs_0_
	{
		public SVGPathSegCurvetoCubicAbs prototype;
		public SVGPathSegCurvetoCubicAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoCubicRel : SVGPathSeg
	{
		protected SVGPathSegCurvetoCubicRel() : base()
		{
			
		}
		public float x;
		public float x1;
		public float x2;
		public float y;
		public float y1;
		public float y2;
	}

		public class SVGPathSegCurvetoCubicRel_0_
	{
		public SVGPathSegCurvetoCubicRel prototype;
		public SVGPathSegCurvetoCubicRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoCubicSmoothAbs : SVGPathSeg
	{
		protected SVGPathSegCurvetoCubicSmoothAbs() : base()
		{
			
		}
		public float x;
		public float x2;
		public float y;
		public float y2;
	}

		public class SVGPathSegCurvetoCubicSmoothAbs_0_
	{
		public SVGPathSegCurvetoCubicSmoothAbs prototype;
		public SVGPathSegCurvetoCubicSmoothAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoCubicSmoothRel : SVGPathSeg
	{
		protected SVGPathSegCurvetoCubicSmoothRel() : base()
		{
			
		}
		public float x;
		public float x2;
		public float y;
		public float y2;
	}

		public class SVGPathSegCurvetoCubicSmoothRel_0_
	{
		public SVGPathSegCurvetoCubicSmoothRel prototype;
		public SVGPathSegCurvetoCubicSmoothRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoQuadraticAbs : SVGPathSeg
	{
		protected SVGPathSegCurvetoQuadraticAbs() : base()
		{
			
		}
		public float x;
		public float x1;
		public float y;
		public float y1;
	}

		public class SVGPathSegCurvetoQuadraticAbs_0_
	{
		public SVGPathSegCurvetoQuadraticAbs prototype;
		public SVGPathSegCurvetoQuadraticAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoQuadraticRel : SVGPathSeg
	{
		protected SVGPathSegCurvetoQuadraticRel() : base()
		{
			
		}
		public float x;
		public float x1;
		public float y;
		public float y1;
	}

		public class SVGPathSegCurvetoQuadraticRel_0_
	{
		public SVGPathSegCurvetoQuadraticRel prototype;
		public SVGPathSegCurvetoQuadraticRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoQuadraticSmoothAbs : SVGPathSeg
	{
		protected SVGPathSegCurvetoQuadraticSmoothAbs() : base()
		{
			
		}
		public float x;
		public float y;
	}

		public class SVGPathSegCurvetoQuadraticSmoothAbs_0_
	{
		public SVGPathSegCurvetoQuadraticSmoothAbs prototype;
		public SVGPathSegCurvetoQuadraticSmoothAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegCurvetoQuadraticSmoothRel : SVGPathSeg
	{
		protected SVGPathSegCurvetoQuadraticSmoothRel() : base()
		{
			
		}
		public float x;
		public float y;
	}

		public class SVGPathSegCurvetoQuadraticSmoothRel_0_
	{
		public SVGPathSegCurvetoQuadraticSmoothRel prototype;
		public SVGPathSegCurvetoQuadraticSmoothRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegLinetoAbs : SVGPathSeg
	{
		protected SVGPathSegLinetoAbs() : base()
		{
			
		}
		public float x;
		public float y;
	}

		public class SVGPathSegLinetoAbs_0_
	{
		public SVGPathSegLinetoAbs prototype;
		public SVGPathSegLinetoAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegLinetoHorizontalAbs : SVGPathSeg
	{
		protected SVGPathSegLinetoHorizontalAbs() : base()
		{
			
		}
		public float x;
	}

		public class SVGPathSegLinetoHorizontalAbs_0_
	{
		public SVGPathSegLinetoHorizontalAbs prototype;
		public SVGPathSegLinetoHorizontalAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegLinetoHorizontalRel : SVGPathSeg
	{
		protected SVGPathSegLinetoHorizontalRel() : base()
		{
			
		}
		public float x;
	}

		public class SVGPathSegLinetoHorizontalRel_0_
	{
		public SVGPathSegLinetoHorizontalRel prototype;
		public SVGPathSegLinetoHorizontalRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegLinetoRel : SVGPathSeg
	{
		protected SVGPathSegLinetoRel() : base()
		{
			
		}
		public float x;
		public float y;
	}

		public class SVGPathSegLinetoRel_0_
	{
		public SVGPathSegLinetoRel prototype;
		public SVGPathSegLinetoRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegLinetoVerticalAbs : SVGPathSeg
	{
		protected SVGPathSegLinetoVerticalAbs() : base()
		{
			
		}
		public float y;
	}

		public class SVGPathSegLinetoVerticalAbs_0_
	{
		public SVGPathSegLinetoVerticalAbs prototype;
		public SVGPathSegLinetoVerticalAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegLinetoVerticalRel : SVGPathSeg
	{
		protected SVGPathSegLinetoVerticalRel() : base()
		{
			
		}
		public float y;
	}

		public class SVGPathSegLinetoVerticalRel_0_
	{
		public SVGPathSegLinetoVerticalRel prototype;
		public SVGPathSegLinetoVerticalRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegList
	{
		protected SVGPathSegList()
		{
			
		}
		public readonly numberOfItems;
		public SVGPathSeg appendItem(SVGPathSeg newItem)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSeg getItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSeg initialize(SVGPathSeg newItem)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSeg insertItemBefore(SVGPathSeg newItem, float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSeg removeItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGPathSeg replaceItem(SVGPathSeg newItem, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegList_0_
	{
		public SVGPathSegList prototype;
		public SVGPathSegList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegMovetoAbs : SVGPathSeg
	{
		protected SVGPathSegMovetoAbs() : base()
		{
			
		}
		public float x;
		public float y;
	}

		public class SVGPathSegMovetoAbs_0_
	{
		public SVGPathSegMovetoAbs prototype;
		public SVGPathSegMovetoAbs new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPathSegMovetoRel : SVGPathSeg
	{
		protected SVGPathSegMovetoRel() : base()
		{
			
		}
		public float x;
		public float y;
	}

		public class SVGPathSegMovetoRel_0_
	{
		public SVGPathSegMovetoRel prototype;
		public SVGPathSegMovetoRel new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPatternElement : SVGElement, SVGStylable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGFitToViewBox, SVGURIReference, SVGUnitTypes
	{
		protected SVGPatternElement() : base()
		{
			
		}
		public readonly height;
		public readonly patternContentUnits;
		public readonly patternTransform;
		public readonly patternUnits;
		public readonly width;
		public readonly x;
		public readonly y;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPatternElement_0_
	{
		public SVGPatternElement prototype;
		public SVGPatternElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPoint
	{
		protected SVGPoint()
		{
			
		}
		public float x;
		public float y;
		public SVGPoint matrixTransform(SVGMatrix matrix)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPoint_0_
	{
		public SVGPoint prototype;
		public SVGPoint new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPointList
	{
		protected SVGPointList()
		{
			
		}
		public readonly numberOfItems;
		public SVGPoint appendItem(SVGPoint newItem)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint getItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint initialize(SVGPoint newItem)
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint insertItemBefore(SVGPoint newItem, float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint removeItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint replaceItem(SVGPoint newItem, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPointList_0_
	{
		public SVGPointList prototype;
		public SVGPointList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPolygonElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGAnimatedPoints
	{
		protected SVGPolygonElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPolygonElement_0_
	{
		public SVGPolygonElement prototype;
		public SVGPolygonElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPolylineElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGAnimatedPoints
	{
		protected SVGPolylineElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPolylineElement_0_
	{
		public SVGPolylineElement prototype;
		public SVGPolylineElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGPreserveAspectRatio
	{
		protected SVGPreserveAspectRatio()
		{
			
		}
		public float align;
		public float meetOrSlice;
		public readonly SVG_MEETORSLICE_MEET;
		public readonly SVG_MEETORSLICE_SLICE;
		public readonly SVG_MEETORSLICE_UNKNOWN;
		public readonly SVG_PRESERVEASPECTRATIO_NONE;
		public readonly SVG_PRESERVEASPECTRATIO_UNKNOWN;
		public readonly SVG_PRESERVEASPECTRATIO_XMAXYMAX;
		public readonly SVG_PRESERVEASPECTRATIO_XMAXYMID;
		public readonly SVG_PRESERVEASPECTRATIO_XMAXYMIN;
		public readonly SVG_PRESERVEASPECTRATIO_XMIDYMAX;
		public readonly SVG_PRESERVEASPECTRATIO_XMIDYMID;
		public readonly SVG_PRESERVEASPECTRATIO_XMIDYMIN;
		public readonly SVG_PRESERVEASPECTRATIO_XMINYMAX;
		public readonly SVG_PRESERVEASPECTRATIO_XMINYMID;
		public readonly SVG_PRESERVEASPECTRATIO_XMINYMIN;
	}

		public class SVGPreserveAspectRatio_0_
	{
		public SVGPreserveAspectRatio prototype;
		public float SVG_MEETORSLICE_MEET;
		public float SVG_MEETORSLICE_SLICE;
		public float SVG_MEETORSLICE_UNKNOWN;
		public float SVG_PRESERVEASPECTRATIO_NONE;
		public float SVG_PRESERVEASPECTRATIO_UNKNOWN;
		public float SVG_PRESERVEASPECTRATIO_XMAXYMAX;
		public float SVG_PRESERVEASPECTRATIO_XMAXYMID;
		public float SVG_PRESERVEASPECTRATIO_XMAXYMIN;
		public float SVG_PRESERVEASPECTRATIO_XMIDYMAX;
		public float SVG_PRESERVEASPECTRATIO_XMIDYMID;
		public float SVG_PRESERVEASPECTRATIO_XMIDYMIN;
		public float SVG_PRESERVEASPECTRATIO_XMINYMAX;
		public float SVG_PRESERVEASPECTRATIO_XMINYMID;
		public float SVG_PRESERVEASPECTRATIO_XMINYMIN;
		public SVGPreserveAspectRatio new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGRadialGradientElement : SVGGradientElement
	{
		protected SVGRadialGradientElement() : base()
		{
			
		}
		public readonly cx;
		public readonly cy;
		public readonly fx;
		public readonly fy;
		public readonly r;
	}

		public class SVGRadialGradientElement_0_
	{
		public SVGRadialGradientElement prototype;
		public SVGRadialGradientElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGRect
	{
		protected SVGRect()
		{
			
		}
		public float height;
		public float width;
		public float x;
		public float y;
	}

		public class SVGRect_0_
	{
		public SVGRect prototype;
		public SVGRect new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGRectElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGRectElement() : base()
		{
			
		}
		public readonly height;
		public readonly rx;
		public readonly ry;
		public readonly width;
		public readonly x;
		public readonly y;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGRectElement_0_
	{
		public SVGRectElement prototype;
		public SVGRectElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGSVGElement : SVGElement, DocumentEvent, SVGLocatable, SVGTests, SVGStylable, SVGLangSpace, SVGExternalResourcesRequired, SVGFitToViewBox, SVGZoomAndPan
	{
		protected SVGSVGElement() : base()
		{
			
		}
		public string contentScriptType;
		public string contentStyleType;
		public float currentScale;
		public readonly currentTranslate;
		public readonly height;
		public Func<, object> onabort;
		public WheelEvent ev;
		public object any;
		public Func<, object> onerror;
		public Func<, object> onresize;
		public Func<, object> onscroll;
		public Func<, object> onunload;
		public Func<, object> onzoom;
		public readonly pixelUnitToMillimeterX;
		public readonly pixelUnitToMillimeterY;
		public readonly screenPixelToMillimeterX;
		public readonly screenPixelToMillimeterY;
		public readonly viewport;
		public readonly width;
		public readonly x;
		public readonly y;
		public Func<, object> listener;
		public bool useCapture;
		public bool checkEnclosure(SVGElement element, SVGRect rect)
		{
			throw new System.NotImplementedException();
		}
		public bool checkIntersection(SVGElement element, SVGRect rect)
		{
			throw new System.NotImplementedException();
		}
		public SVGAngle createSVGAngle()
		{
			throw new System.NotImplementedException();
		}
		public SVGLength createSVGLength()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix createSVGMatrix()
		{
			throw new System.NotImplementedException();
		}
		public SVGNumber createSVGNumber()
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint createSVGPoint()
		{
			throw new System.NotImplementedException();
		}
		public SVGRect createSVGRect()
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform createSVGTransform()
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix)
		{
			throw new System.NotImplementedException();
		}
		public void deselectAll()
		{
			throw new System.NotImplementedException();
		}
		public void forceRedraw()
		{
			throw new System.NotImplementedException();
		}
		public CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt = default(string))
		{
			throw new System.NotImplementedException();
		}
		public float getCurrentTime()
		{
			throw new System.NotImplementedException();
		}
		public Element getElementById(string elementId)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<> getEnclosureList(SVGRect rect, SVGElement referenceElement)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<> getIntersectionList(SVGRect rect, SVGElement referenceElement)
		{
			throw new System.NotImplementedException();
		}
		public void pauseAnimations()
		{
			throw new System.NotImplementedException();
		}
		public void setCurrentTime(float seconds)
		{
			throw new System.NotImplementedException();
		}
		public float suspendRedraw(float maxWaitMilliseconds)
		{
			throw new System.NotImplementedException();
		}
		public void unpauseAnimations()
		{
			throw new System.NotImplementedException();
		}
		public void unsuspendRedraw(float suspendHandleID)
		{
			throw new System.NotImplementedException();
		}
		public void unsuspendRedrawAll()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGSVGElement_0_
	{
		public SVGSVGElement prototype;
		public SVGSVGElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGScriptElement : SVGElement, SVGExternalResourcesRequired, SVGURIReference
	{
		protected SVGScriptElement() : base()
		{
			
		}
		public string type;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGScriptElement_0_
	{
		public SVGScriptElement prototype;
		public SVGScriptElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStopElement : SVGElement, SVGStylable
	{
		protected SVGStopElement() : base()
		{
			
		}
		public readonly offset;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStopElement_0_
	{
		public SVGStopElement prototype;
		public SVGStopElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStringList
	{
		protected SVGStringList()
		{
			
		}
		public readonly numberOfItems;
		public string appendItem(string newItem)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public string getItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public string initialize(string newItem)
		{
			throw new System.NotImplementedException();
		}
		public string insertItemBefore(string newItem, float index)
		{
			throw new System.NotImplementedException();
		}
		public string removeItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public string replaceItem(string newItem, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStringList_0_
	{
		public SVGStringList prototype;
		public SVGStringList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStyleElement : SVGElement, SVGLangSpace
	{
		protected SVGStyleElement() : base()
		{
			
		}
		public bool disabled;
		public string media;
		public string title;
		public string type;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStyleElement_0_
	{
		public SVGStyleElement prototype;
		public SVGStyleElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGSwitchElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGSwitchElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGSwitchElement_0_
	{
		public SVGSwitchElement prototype;
		public SVGSwitchElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGSymbolElement : SVGElement, SVGStylable, SVGLangSpace, SVGExternalResourcesRequired, SVGFitToViewBox
	{
		protected SVGSymbolElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGSymbolElement_0_
	{
		public SVGSymbolElement prototype;
		public SVGSymbolElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTSpanElement : SVGTextPositioningElement
	{
		protected SVGTSpanElement() : base()
		{
			
		}
	}

		public class SVGTSpanElement_0_
	{
		public SVGTSpanElement prototype;
		public SVGTSpanElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextContentElement : SVGElement, SVGStylable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired
	{
		protected SVGTextContentElement() : base()
		{
			
		}
		public readonly lengthAdjust;
		public readonly textLength;
		public readonly LENGTHADJUST_SPACING;
		public readonly LENGTHADJUST_SPACINGANDGLYPHS;
		public readonly LENGTHADJUST_UNKNOWN;
		public float getCharNumAtPosition(SVGPoint point)
		{
			throw new System.NotImplementedException();
		}
		public float getComputedTextLength()
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint getEndPositionOfChar(float charnum)
		{
			throw new System.NotImplementedException();
		}
		public SVGRect getExtentOfChar(float charnum)
		{
			throw new System.NotImplementedException();
		}
		public float getNumberOfChars()
		{
			throw new System.NotImplementedException();
		}
		public float getRotationOfChar(float charnum)
		{
			throw new System.NotImplementedException();
		}
		public SVGPoint getStartPositionOfChar(float charnum)
		{
			throw new System.NotImplementedException();
		}
		public float getSubStringLength(float charnum, float nchars)
		{
			throw new System.NotImplementedException();
		}
		public void selectSubString(float charnum, float nchars)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextContentElement_0_
	{
		public SVGTextContentElement prototype;
		public float LENGTHADJUST_SPACING;
		public float LENGTHADJUST_SPACINGANDGLYPHS;
		public float LENGTHADJUST_UNKNOWN;
		public SVGTextContentElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextElement : SVGTextPositioningElement, SVGTransformable
	{
		protected SVGTextElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextElement_0_
	{
		public SVGTextElement prototype;
		public SVGTextElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextPathElement : SVGTextContentElement, SVGURIReference
	{
		protected SVGTextPathElement() : base()
		{
			
		}
		public readonly method;
		public readonly spacing;
		public readonly startOffset;
		public readonly TEXTPATH_METHODTYPE_ALIGN;
		public readonly TEXTPATH_METHODTYPE_STRETCH;
		public readonly TEXTPATH_METHODTYPE_UNKNOWN;
		public readonly TEXTPATH_SPACINGTYPE_AUTO;
		public readonly TEXTPATH_SPACINGTYPE_EXACT;
		public readonly TEXTPATH_SPACINGTYPE_UNKNOWN;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextPathElement_0_
	{
		public SVGTextPathElement prototype;
		public float TEXTPATH_METHODTYPE_ALIGN;
		public float TEXTPATH_METHODTYPE_STRETCH;
		public float TEXTPATH_METHODTYPE_UNKNOWN;
		public float TEXTPATH_SPACINGTYPE_AUTO;
		public float TEXTPATH_SPACINGTYPE_EXACT;
		public float TEXTPATH_SPACINGTYPE_UNKNOWN;
		public SVGTextPathElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTextPositioningElement : SVGTextContentElement
	{
		protected SVGTextPositioningElement() : base()
		{
			
		}
		public readonly dx;
		public readonly dy;
		public readonly rotate;
		public readonly x;
		public readonly y;
	}

		public class SVGTextPositioningElement_0_
	{
		public SVGTextPositioningElement prototype;
		public SVGTextPositioningElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTitleElement : SVGElement, SVGStylable, SVGLangSpace
	{
		protected SVGTitleElement() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTitleElement_0_
	{
		public SVGTitleElement prototype;
		public SVGTitleElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTransform
	{
		protected SVGTransform()
		{
			
		}
		public readonly angle;
		public readonly matrix;
		public readonly type;
		public readonly SVG_TRANSFORM_MATRIX;
		public readonly SVG_TRANSFORM_ROTATE;
		public readonly SVG_TRANSFORM_SCALE;
		public readonly SVG_TRANSFORM_SKEWX;
		public readonly SVG_TRANSFORM_SKEWY;
		public readonly SVG_TRANSFORM_TRANSLATE;
		public readonly SVG_TRANSFORM_UNKNOWN;
		public void setMatrix(SVGMatrix matrix)
		{
			throw new System.NotImplementedException();
		}
		public void setRotate(float angle, float cx, float cy)
		{
			throw new System.NotImplementedException();
		}
		public void setScale(float sx, float sy)
		{
			throw new System.NotImplementedException();
		}
		public void setSkewX(float angle)
		{
			throw new System.NotImplementedException();
		}
		public void setSkewY(float angle)
		{
			throw new System.NotImplementedException();
		}
		public void setTranslate(float tx, float ty)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTransform_0_
	{
		public SVGTransform prototype;
		public float SVG_TRANSFORM_MATRIX;
		public float SVG_TRANSFORM_ROTATE;
		public float SVG_TRANSFORM_SCALE;
		public float SVG_TRANSFORM_SKEWX;
		public float SVG_TRANSFORM_SKEWY;
		public float SVG_TRANSFORM_TRANSLATE;
		public float SVG_TRANSFORM_UNKNOWN;
		public SVGTransform new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTransformList
	{
		protected SVGTransformList()
		{
			
		}
		public readonly numberOfItems;
		public SVGTransform appendItem(SVGTransform newItem)
		{
			throw new System.NotImplementedException();
		}
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform consolidate()
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform createSVGTransformFromMatrix(SVGMatrix matrix)
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform getItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform initialize(SVGTransform newItem)
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform insertItemBefore(SVGTransform newItem, float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform removeItem(float index)
		{
			throw new System.NotImplementedException();
		}
		public SVGTransform replaceItem(SVGTransform newItem, float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTransformList_0_
	{
		public SVGTransformList prototype;
		public SVGTransformList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGUnitTypes
	{
		protected SVGUnitTypes()
		{
			
		}
		public readonly SVG_UNIT_TYPE_OBJECTBOUNDINGBOX;
		public readonly SVG_UNIT_TYPE_UNKNOWN;
		public readonly SVG_UNIT_TYPE_USERSPACEONUSE;
	}

		public class SVGUseElement : SVGElement, SVGStylable, SVGTransformable, SVGTests, SVGLangSpace, SVGExternalResourcesRequired, SVGURIReference
	{
		protected SVGUseElement() : base()
		{
			
		}
		public readonly animatedInstanceRoot;
		public readonly height;
		public readonly instanceRoot;
		public readonly width;
		public readonly x;
		public readonly y;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGUseElement_0_
	{
		public SVGUseElement prototype;
		public SVGUseElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGViewElement : SVGElement, SVGExternalResourcesRequired, SVGFitToViewBox, SVGZoomAndPan
	{
		protected SVGViewElement() : base()
		{
			
		}
		public readonly viewTarget;
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGViewElement_0_
	{
		public SVGViewElement prototype;
		public SVGViewElement new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGZoomAndPan
	{
		protected SVGZoomAndPan()
		{
			
		}
		public readonly zoomAndPan;
	}

		public class SVGZoomAndPan_0_
	{
		public float SVG_ZOOMANDPAN_DISABLE;
		public float SVG_ZOOMANDPAN_MAGNIFY;
		public float SVG_ZOOMANDPAN_UNKNOWN;
	}

		public class SVGZoomEvent : UIEvent
	{
		protected SVGZoomEvent() : base()
		{
			
		}
		public readonly newScale;
		public readonly newTranslate;
		public readonly previousScale;
		public readonly previousTranslate;
		public readonly zoomRectScreen;
	}

		public class SVGZoomEvent_0_
	{
		public SVGZoomEvent prototype;
		public SVGZoomEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Screen : EventTarget
	{
		protected Screen() : base()
		{
			
		}
		public readonly availHeight;
		public readonly availWidth;
		public float bufferDepth;
		public readonly colorDepth;
		public readonly deviceXDPI;
		public readonly deviceYDPI;
		public readonly fontSmoothingEnabled;
		public readonly height;
		public readonly logicalXDPI;
		public readonly logicalYDPI;
		public readonly msOrientation;
		public Func<, object> onmsorientationchange;
		public Event ev;
		public object any;
		public readonly pixelDepth;
		public readonly systemXDPI;
		public readonly systemYDPI;
		public readonly width;
		public Func<, object> listener;
		public bool useCapture;
		public bool msLockOrientation(Any<string, string[]> orientations)
		{
			throw new System.NotImplementedException();
		}
		public void msUnlockOrientation()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Screen_0_
	{
		public Screen prototype;
		public Screen new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ScriptNotifyEvent : Event
	{
		protected ScriptNotifyEvent() : base()
		{
			
		}
		public readonly callingUri;
		public readonly value;
	}

		public class ScriptNotifyEvent_0_
	{
		public ScriptNotifyEvent prototype;
		public ScriptNotifyEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ScriptProcessorNode : AudioNode
	{
		protected ScriptProcessorNode() : base()
		{
			
		}
		public readonly bufferSize;
		public Func<, object> onaudioprocess;
		public AudioProcessingEvent ev;
		public object any;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ScriptProcessorNode_0_
	{
		public ScriptProcessorNode prototype;
		public ScriptProcessorNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Selection
	{
		protected Selection()
		{
			
		}
		public readonly anchorNode;
		public readonly anchorOffset;
		public readonly focusNode;
		public readonly focusOffset;
		public readonly isCollapsed;
		public readonly rangeCount;
		public readonly type;
		public void addRange(Range range)
		{
			throw new System.NotImplementedException();
		}
		public void collapse(Node parentNode, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void collapseToEnd()
		{
			throw new System.NotImplementedException();
		}
		public void collapseToStart()
		{
			throw new System.NotImplementedException();
		}
		public bool containsNode(Node node, bool partlyContained)
		{
			throw new System.NotImplementedException();
		}
		public void deleteFromDocument()
		{
			throw new System.NotImplementedException();
		}
		public void empty()
		{
			throw new System.NotImplementedException();
		}
		public void extend(Node newNode, float offset)
		{
			throw new System.NotImplementedException();
		}
		public Range getRangeAt(float index)
		{
			throw new System.NotImplementedException();
		}
		public void removeAllRanges()
		{
			throw new System.NotImplementedException();
		}
		public void removeRange(Range range)
		{
			throw new System.NotImplementedException();
		}
		public void selectAllChildren(Node parentNode)
		{
			throw new System.NotImplementedException();
		}
		public void setBaseAndExtent(Node baseNode, float baseOffset, Node extentNode, float extentOffset)
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Selection_0_
	{
		public Selection prototype;
		public Selection new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SourceBuffer : EventTarget
	{
		protected SourceBuffer() : base()
		{
			
		}
		public float appendWindowEnd;
		public float appendWindowStart;
		public readonly audioTracks;
		public readonly buffered;
		public string mode;
		public float timestampOffset;
		public readonly updating;
		public readonly videoTracks;
		public void abort()
		{
			throw new System.NotImplementedException();
		}
		public void appendBuffer(Any<Bridge.Html5.ArrayBuffer, Bridge.Html5.ArrayBufferView> data)
		{
			throw new System.NotImplementedException();
		}
		public void appendStream(MSStream stream, float maxSize = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void remove(float start, float end)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SourceBuffer_0_
	{
		public SourceBuffer prototype;
		public SourceBuffer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SourceBufferList : EventTarget
	{
		protected SourceBufferList() : base()
		{
			
		}
		public readonly length;
		public float index;
		public SourceBuffer item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SourceBufferList_0_
	{
		public SourceBufferList prototype;
		public SourceBufferList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StereoPannerNode : AudioNode
	{
		protected StereoPannerNode() : base()
		{
			
		}
		public readonly pan;
	}

		public class StereoPannerNode_0_
	{
		public StereoPannerNode prototype;
		public StereoPannerNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Storage
	{
		protected Storage()
		{
			
		}
		public readonly length;
		public string key;
		public float index;
		public void clear()
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> getItem(string key)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> key(float index)
		{
			throw new System.NotImplementedException();
		}
		public void removeItem(string key)
		{
			throw new System.NotImplementedException();
		}
		public void setItem(string key, string data)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Storage_0_
	{
		public Storage prototype;
		public Storage new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StorageEvent : Event
	{
		protected StorageEvent() : base()
		{
			
		}
		public readonly url;
		public string key;
		public string oldValue;
		public string newValue;
		public Storage storageArea;
	}

		public class StorageEvent_0_
	{
		public StorageEvent prototype;
		public StorageEvent new(string type, StorageEventInit eventInitDict = default(StorageEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleMedia
	{
		protected StyleMedia()
		{
			
		}
		public readonly type;
		public bool matchMedium(string mediaquery)
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleMedia_0_
	{
		public StyleMedia prototype;
		public StyleMedia new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleSheet
	{
		protected StyleSheet()
		{
			
		}
		public bool disabled;
		public readonly href;
		public readonly media;
		public readonly ownerNode;
		public readonly parentStyleSheet;
		public readonly title;
		public readonly type;
	}

		public class StyleSheet_0_
	{
		public StyleSheet prototype;
		public StyleSheet new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleSheetList
	{
		protected StyleSheetList()
		{
			
		}
		public readonly length;
		public float index;
		public StyleSheet item(float index = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleSheetList_0_
	{
		public StyleSheetList prototype;
		public StyleSheetList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleSheetPageList
	{
		protected StyleSheetPageList()
		{
			
		}
		public readonly length;
		public float index;
		public CSSPageRule item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class StyleSheetPageList_0_
	{
		public StyleSheetPageList prototype;
		public StyleSheetPageList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class SubtleCrypto
	{
		protected SubtleCrypto()
		{
			
		}
		public CryptoKey key;
		public BufferSource keyData;
		public Any<string, RsaHashedImportParams, EcKeyImportParams, HmacImportParams, DhImportKeyParams> algorithm;
		public bool extractable;
		public string[] keyUsages;
		public PromiseLike<Bridge.Html5.ArrayBuffer> decrypt(Any<string, RsaOaepParams, AesCtrParams, AesCbcParams, AesCmacParams, AesGcmParams, AesCfbParams> algorithm, CryptoKey key, BufferSource data)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<Bridge.Html5.ArrayBuffer> deriveBits(Any<string, EcdhKeyDeriveParams, DhKeyDeriveParams, ConcatParams, HkdfCtrParams, Pbkdf2Params> algorithm, CryptoKey baseKey, float length)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<CryptoKey> deriveKey(Any<string, EcdhKeyDeriveParams, DhKeyDeriveParams, ConcatParams, HkdfCtrParams, Pbkdf2Params> algorithm, CryptoKey baseKey, Any<string, AesDerivedKeyParams, HmacImportParams, ConcatParams, HkdfCtrParams, Pbkdf2Params> derivedKeyType, bool extractable, string[] keyUsages)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<Bridge.Html5.ArrayBuffer> digest(AlgorithmIdentifier algorithm, BufferSource data)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<Bridge.Html5.ArrayBuffer> encrypt(Any<string, RsaOaepParams, AesCtrParams, AesCbcParams, AesCmacParams, AesGcmParams, AesCfbParams> algorithm, CryptoKey key, BufferSource data)
		{
			throw new System.NotImplementedException();
		}
		public object exportKey(object format)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<> exportKey(string format, CryptoKey key)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<> generateKey(string algorithm, bool extractable, string[] keyUsages)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<CryptoKeyPair> generateKey(Any<RsaHashedKeyGenParams, EcKeyGenParams, DhKeyGenParams> algorithm, bool extractable, string[] keyUsages)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<CryptoKey> generateKey(Any<AesKeyGenParams, HmacKeyGenParams, Pbkdf2Params> algorithm, bool extractable, string[] keyUsages)
		{
			throw new System.NotImplementedException();
		}
		public object importKey(object format)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<CryptoKey> importKey(string format, Any<JsonWebKey, BufferSource> keyData, Any<string, RsaHashedImportParams, EcKeyImportParams, HmacImportParams, DhImportKeyParams> algorithm, bool extractable, string[] keyUsages)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<Bridge.Html5.ArrayBuffer> sign(Any<string, RsaPssParams, EcdsaParams, AesCmacParams> algorithm, CryptoKey key, BufferSource data)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<CryptoKey> unwrapKey(string format, BufferSource wrappedKey, CryptoKey unwrappingKey, AlgorithmIdentifier unwrapAlgorithm, AlgorithmIdentifier unwrappedKeyAlgorithm, bool extractable, string[] keyUsages)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<bool> verify(Any<string, RsaPssParams, EcdsaParams, AesCmacParams> algorithm, CryptoKey key, BufferSource signature, BufferSource data)
		{
			throw new System.NotImplementedException();
		}
		public PromiseLike<Bridge.Html5.ArrayBuffer> wrapKey(string format, CryptoKey key, CryptoKey wrappingKey, AlgorithmIdentifier wrapAlgorithm)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SubtleCrypto_0_
	{
		public SubtleCrypto prototype;
		public SubtleCrypto new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Text : CharacterData
	{
		protected Text() : base()
		{
			
		}
		public readonly wholeText;
		public Text splitText(float offset)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Text_0_
	{
		public Text prototype;
		public Text new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextEvent : UIEvent
	{
		protected TextEvent() : base()
		{
			
		}
		public readonly data;
		public readonly inputMethod;
		public readonly locale;
		public readonly DOM_INPUT_METHOD_DROP;
		public readonly DOM_INPUT_METHOD_HANDWRITING;
		public readonly DOM_INPUT_METHOD_IME;
		public readonly DOM_INPUT_METHOD_KEYBOARD;
		public readonly DOM_INPUT_METHOD_MULTIMODAL;
		public readonly DOM_INPUT_METHOD_OPTION;
		public readonly DOM_INPUT_METHOD_PASTE;
		public readonly DOM_INPUT_METHOD_SCRIPT;
		public readonly DOM_INPUT_METHOD_UNKNOWN;
		public readonly DOM_INPUT_METHOD_VOICE;
		public void initTextEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, string dataArg, float inputMethod, string locale)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextEvent_0_
	{
		public TextEvent prototype;
		public float DOM_INPUT_METHOD_DROP;
		public float DOM_INPUT_METHOD_HANDWRITING;
		public float DOM_INPUT_METHOD_IME;
		public float DOM_INPUT_METHOD_KEYBOARD;
		public float DOM_INPUT_METHOD_MULTIMODAL;
		public float DOM_INPUT_METHOD_OPTION;
		public float DOM_INPUT_METHOD_PASTE;
		public float DOM_INPUT_METHOD_SCRIPT;
		public float DOM_INPUT_METHOD_UNKNOWN;
		public float DOM_INPUT_METHOD_VOICE;
		public TextEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextMetrics
	{
		protected TextMetrics()
		{
			
		}
		public readonly width;
	}

		public class TextMetrics_0_
	{
		public TextMetrics prototype;
		public TextMetrics new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrack : EventTarget
	{
		protected TextTrack() : base()
		{
			
		}
		public readonly activeCues;
		public readonly cues;
		public readonly inBandMetadataTrackDispatchType;
		public readonly kind;
		public readonly label;
		public readonly language;
		public object mode;
		public Func<, object> oncuechange;
		public Event ev;
		public object any;
		public Func<, object> onerror;
		public Func<, object> onload;
		public readonly readyState;
		public readonly DISABLED;
		public readonly ERROR;
		public readonly HIDDEN;
		public readonly LOADED;
		public readonly LOADING;
		public readonly NONE;
		public readonly SHOWING;
		public Func<, object> listener;
		public bool useCapture;
		public void addCue(TextTrackCue cue)
		{
			throw new System.NotImplementedException();
		}
		public void removeCue(TextTrackCue cue)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrack_0_
	{
		public TextTrack prototype;
		public float DISABLED;
		public float ERROR;
		public float HIDDEN;
		public float LOADED;
		public float LOADING;
		public float NONE;
		public float SHOWING;
		public TextTrack new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrackCue : EventTarget
	{
		protected TextTrackCue() : base()
		{
			
		}
		public float endTime;
		public string id;
		public Func<, object> onenter;
		public Event ev;
		public object any;
		public Func<, object> onexit;
		public bool pauseOnExit;
		public float startTime;
		public string text;
		public readonly track;
		public Func<, object> listener;
		public bool useCapture;
		public DocumentFragment getCueAsHTML()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrackCue_0_
	{
		public TextTrackCue prototype;
		public TextTrackCue new(float startTime, float endTime, string text)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrackCueList
	{
		protected TextTrackCueList()
		{
			
		}
		public readonly length;
		public float index;
		public TextTrackCue getCueById(string id)
		{
			throw new System.NotImplementedException();
		}
		public TextTrackCue item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrackCueList_0_
	{
		public TextTrackCueList prototype;
		public TextTrackCueList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrackList : EventTarget
	{
		protected TextTrackList() : base()
		{
			
		}
		public readonly length;
		public Func<, object> onaddtrack;
		public TrackEvent ev;
		public Func<, object> listener;
		public bool useCapture;
		public float index;
		public TextTrack item(float index)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextTrackList_0_
	{
		public TextTrackList prototype;
		public TextTrackList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TimeRanges
	{
		protected TimeRanges()
		{
			
		}
		public readonly length;
		public float end(float index)
		{
			throw new System.NotImplementedException();
		}
		public float start(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TimeRanges_0_
	{
		public TimeRanges prototype;
		public TimeRanges new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Touch
	{
		protected Touch()
		{
			
		}
		public readonly clientX;
		public readonly clientY;
		public readonly identifier;
		public readonly pageX;
		public readonly pageY;
		public readonly screenX;
		public readonly screenY;
		public readonly target;
	}

		public class Touch_0_
	{
		public Touch prototype;
		public Touch new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TouchEvent : UIEvent
	{
		protected TouchEvent() : base()
		{
			
		}
		public readonly altKey;
		public readonly changedTouches;
		public readonly ctrlKey;
		public readonly metaKey;
		public readonly shiftKey;
		public readonly targetTouches;
		public readonly touches;
	}

		public class TouchEvent_0_
	{
		public TouchEvent prototype;
		public TouchEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TouchList
	{
		protected TouchList()
		{
			
		}
		public readonly length;
		public float index;
		public Any<Touch, null> item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TouchList_0_
	{
		public TouchList prototype;
		public TouchList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TrackEvent : Event
	{
		protected TrackEvent() : base()
		{
			
		}
		public readonly track;
	}

		public class TrackEvent_0_
	{
		public TrackEvent prototype;
		public TrackEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TransitionEvent : Event
	{
		protected TransitionEvent() : base()
		{
			
		}
		public readonly elapsedTime;
		public readonly propertyName;
		public void initTransitionEvent(string typeArg, bool canBubbleArg, bool cancelableArg, string propertyNameArg, float elapsedTimeArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TransitionEvent_0_
	{
		public TransitionEvent prototype;
		public TransitionEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TreeWalker
	{
		protected TreeWalker()
		{
			
		}
		public Node currentNode;
		public readonly expandEntityReferences;
		public readonly filter;
		public readonly root;
		public readonly whatToShow;
		public Node firstChild()
		{
			throw new System.NotImplementedException();
		}
		public Node lastChild()
		{
			throw new System.NotImplementedException();
		}
		public Node nextNode()
		{
			throw new System.NotImplementedException();
		}
		public Node nextSibling()
		{
			throw new System.NotImplementedException();
		}
		public Node parentNode()
		{
			throw new System.NotImplementedException();
		}
		public Node previousNode()
		{
			throw new System.NotImplementedException();
		}
		public Node previousSibling()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TreeWalker_0_
	{
		public TreeWalker prototype;
		public TreeWalker new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class UIEvent : Event
	{
		protected UIEvent() : base()
		{
			
		}
		public readonly detail;
		public readonly view;
		public void initUIEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg)
		{
			throw new System.NotImplementedException();
		}
	}

		public class UIEvent_0_
	{
		public UIEvent prototype;
		public UIEvent new(string type, UIEventInit eventInitDict = default(UIEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class URL
	{
		protected URL()
		{
			
		}
		public string hash;
		public string host;
		public string hostname;
		public string href;
		public readonly origin;
		public string password;
		public string pathname;
		public string port;
		public string protocol;
		public string search;
		public string username;
		public string toString()
		{
			throw new System.NotImplementedException();
		}
	}

		public class URL_0_
	{
		public URL prototype;
		public URL new(string url, string base = default(string))
		{
			throw new System.NotImplementedException();
		}
		public string createObjectURL(object @object, ObjectURLOptions options = default(ObjectURLOptions))
		{
			throw new System.NotImplementedException();
		}
		public void revokeObjectURL(string url)
		{
			throw new System.NotImplementedException();
		}
	}

		public class UnviewableContentIdentifiedEvent : NavigationEventWithReferrer
	{
		protected UnviewableContentIdentifiedEvent() : base()
		{
			
		}
		public readonly mediaType;
	}

		public class UnviewableContentIdentifiedEvent_0_
	{
		public UnviewableContentIdentifiedEvent prototype;
		public UnviewableContentIdentifiedEvent new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class ValidityState
	{
		protected ValidityState()
		{
			
		}
		public readonly badInput;
		public readonly customError;
		public readonly patternMismatch;
		public readonly rangeOverflow;
		public readonly rangeUnderflow;
		public readonly stepMismatch;
		public readonly tooLong;
		public readonly typeMismatch;
		public readonly valid;
		public readonly valueMissing;
	}

		public class ValidityState_0_
	{
		public ValidityState prototype;
		public ValidityState new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class VideoPlaybackQuality
	{
		protected VideoPlaybackQuality()
		{
			
		}
		public readonly corruptedVideoFrames;
		public readonly creationTime;
		public readonly droppedVideoFrames;
		public readonly totalFrameDelay;
		public readonly totalVideoFrames;
	}

		public class VideoPlaybackQuality_0_
	{
		public VideoPlaybackQuality prototype;
		public VideoPlaybackQuality new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class VideoTrack
	{
		protected VideoTrack()
		{
			
		}
		public readonly id;
		public string kind;
		public readonly label;
		public string language;
		public bool selected;
		public readonly sourceBuffer;
	}

		public class VideoTrack_0_
	{
		public VideoTrack prototype;
		public VideoTrack new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class VideoTrackList : EventTarget
	{
		protected VideoTrackList() : base()
		{
			
		}
		public readonly length;
		public Func<, object> onaddtrack;
		public TrackEvent ev;
		public object any;
		public Func<, object> onchange;
		public Func<, object> onremovetrack;
		public readonly selectedIndex;
		public Func<, object> listener;
		public bool useCapture;
		public float index;
		public Any<VideoTrack, null> getTrackById(string id)
		{
			throw new System.NotImplementedException();
		}
		public VideoTrack item(float index)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class VideoTrackList_0_
	{
		public VideoTrackList prototype;
		public VideoTrackList new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WEBGL_compressed_texture_s3tc
	{
		protected WEBGL_compressed_texture_s3tc()
		{
			
		}
		public readonly COMPRESSED_RGBA_S3TC_DXT1_EXT;
		public readonly COMPRESSED_RGBA_S3TC_DXT3_EXT;
		public readonly COMPRESSED_RGBA_S3TC_DXT5_EXT;
		public readonly COMPRESSED_RGB_S3TC_DXT1_EXT;
	}

		public class WEBGL_compressed_texture_s3tc_0_
	{
		public WEBGL_compressed_texture_s3tc prototype;
		public float COMPRESSED_RGBA_S3TC_DXT1_EXT;
		public float COMPRESSED_RGBA_S3TC_DXT3_EXT;
		public float COMPRESSED_RGBA_S3TC_DXT5_EXT;
		public float COMPRESSED_RGB_S3TC_DXT1_EXT;
		public WEBGL_compressed_texture_s3tc new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WEBGL_debug_renderer_info
	{
		protected WEBGL_debug_renderer_info()
		{
			
		}
		public readonly UNMASKED_RENDERER_WEBGL;
		public readonly UNMASKED_VENDOR_WEBGL;
	}

		public class WEBGL_debug_renderer_info_0_
	{
		public WEBGL_debug_renderer_info prototype;
		public float UNMASKED_RENDERER_WEBGL;
		public float UNMASKED_VENDOR_WEBGL;
		public WEBGL_debug_renderer_info new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WEBGL_depth_texture
	{
		protected WEBGL_depth_texture()
		{
			
		}
		public readonly UNSIGNED_INT_24_8_WEBGL;
	}

		public class WEBGL_depth_texture_0_
	{
		public WEBGL_depth_texture prototype;
		public float UNSIGNED_INT_24_8_WEBGL;
		public WEBGL_depth_texture new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WaveShaperNode : AudioNode
	{
		protected WaveShaperNode() : base()
		{
			
		}
		public Any<Bridge.Html5.Float32Array, null> curve;
		public string oversample;
	}

		public class WaveShaperNode_0_
	{
		public WaveShaperNode prototype;
		public WaveShaperNode new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLActiveInfo
	{
		protected WebGLActiveInfo()
		{
			
		}
		public readonly name;
		public readonly size;
		public readonly type;
	}

		public class WebGLActiveInfo_0_
	{
		public WebGLActiveInfo prototype;
		public WebGLActiveInfo new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLBuffer : WebGLObject
	{
		protected WebGLBuffer() : base()
		{
			
		}
	}

		public class WebGLBuffer_0_
	{
		public WebGLBuffer prototype;
		public WebGLBuffer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLContextEvent : Event
	{
		protected WebGLContextEvent() : base()
		{
			
		}
		public readonly statusMessage;
	}

		public class WebGLContextEvent_0_
	{
		public WebGLContextEvent prototype;
		public WebGLContextEvent new(string type, WebGLContextEventInit eventInitDict = default(WebGLContextEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLFramebuffer : WebGLObject
	{
		protected WebGLFramebuffer() : base()
		{
			
		}
	}

		public class WebGLFramebuffer_0_
	{
		public WebGLFramebuffer prototype;
		public WebGLFramebuffer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLObject
	{
		protected WebGLObject()
		{
			
		}
	}

		public class WebGLObject_0_
	{
		public WebGLObject prototype;
		public WebGLObject new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLProgram : WebGLObject
	{
		protected WebGLProgram() : base()
		{
			
		}
	}

		public class WebGLProgram_0_
	{
		public WebGLProgram prototype;
		public WebGLProgram new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLRenderbuffer : WebGLObject
	{
		protected WebGLRenderbuffer() : base()
		{
			
		}
	}

		public class WebGLRenderbuffer_0_
	{
		public WebGLRenderbuffer prototype;
		public WebGLRenderbuffer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLRenderingContext
	{
		protected WebGLRenderingContext()
		{
			
		}
		public readonly canvas;
		public readonly drawingBufferHeight;
		public readonly drawingBufferWidth;
		public readonly ACTIVE_ATTRIBUTES;
		public readonly ACTIVE_TEXTURE;
		public readonly ACTIVE_UNIFORMS;
		public readonly ALIASED_LINE_WIDTH_RANGE;
		public readonly ALIASED_POINT_SIZE_RANGE;
		public readonly ALPHA;
		public readonly ALPHA_BITS;
		public readonly ALWAYS;
		public readonly ARRAY_BUFFER;
		public readonly ARRAY_BUFFER_BINDING;
		public readonly ATTACHED_SHADERS;
		public readonly BACK;
		public readonly BLEND;
		public readonly BLEND_COLOR;
		public readonly BLEND_DST_ALPHA;
		public readonly BLEND_DST_RGB;
		public readonly BLEND_EQUATION;
		public readonly BLEND_EQUATION_ALPHA;
		public readonly BLEND_EQUATION_RGB;
		public readonly BLEND_SRC_ALPHA;
		public readonly BLEND_SRC_RGB;
		public readonly BLUE_BITS;
		public readonly BOOL;
		public readonly BOOL_VEC2;
		public readonly BOOL_VEC3;
		public readonly BOOL_VEC4;
		public readonly BROWSER_DEFAULT_WEBGL;
		public readonly BUFFER_SIZE;
		public readonly BUFFER_USAGE;
		public readonly BYTE;
		public readonly CCW;
		public readonly CLAMP_TO_EDGE;
		public readonly COLOR_ATTACHMENT0;
		public readonly COLOR_BUFFER_BIT;
		public readonly COLOR_CLEAR_VALUE;
		public readonly COLOR_WRITEMASK;
		public readonly COMPILE_STATUS;
		public readonly COMPRESSED_TEXTURE_FORMATS;
		public readonly CONSTANT_ALPHA;
		public readonly CONSTANT_COLOR;
		public readonly CONTEXT_LOST_WEBGL;
		public readonly CULL_FACE;
		public readonly CULL_FACE_MODE;
		public readonly CURRENT_PROGRAM;
		public readonly CURRENT_VERTEX_ATTRIB;
		public readonly CW;
		public readonly DECR;
		public readonly DECR_WRAP;
		public readonly DELETE_STATUS;
		public readonly DEPTH_ATTACHMENT;
		public readonly DEPTH_BITS;
		public readonly DEPTH_BUFFER_BIT;
		public readonly DEPTH_CLEAR_VALUE;
		public readonly DEPTH_COMPONENT;
		public readonly DEPTH_COMPONENT16;
		public readonly DEPTH_FUNC;
		public readonly DEPTH_RANGE;
		public readonly DEPTH_STENCIL;
		public readonly DEPTH_STENCIL_ATTACHMENT;
		public readonly DEPTH_TEST;
		public readonly DEPTH_WRITEMASK;
		public readonly DITHER;
		public readonly DONT_CARE;
		public readonly DST_ALPHA;
		public readonly DST_COLOR;
		public readonly DYNAMIC_DRAW;
		public readonly ELEMENT_ARRAY_BUFFER;
		public readonly ELEMENT_ARRAY_BUFFER_BINDING;
		public readonly EQUAL;
		public readonly FASTEST;
		public readonly FLOAT;
		public readonly FLOAT_MAT2;
		public readonly FLOAT_MAT3;
		public readonly FLOAT_MAT4;
		public readonly FLOAT_VEC2;
		public readonly FLOAT_VEC3;
		public readonly FLOAT_VEC4;
		public readonly FRAGMENT_SHADER;
		public readonly FRAMEBUFFER;
		public readonly FRAMEBUFFER_ATTACHMENT_OBJECT_NAME;
		public readonly FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE;
		public readonly FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE;
		public readonly FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL;
		public readonly FRAMEBUFFER_BINDING;
		public readonly FRAMEBUFFER_COMPLETE;
		public readonly FRAMEBUFFER_INCOMPLETE_ATTACHMENT;
		public readonly FRAMEBUFFER_INCOMPLETE_DIMENSIONS;
		public readonly FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT;
		public readonly FRAMEBUFFER_UNSUPPORTED;
		public readonly FRONT;
		public readonly FRONT_AND_BACK;
		public readonly FRONT_FACE;
		public readonly FUNC_ADD;
		public readonly FUNC_REVERSE_SUBTRACT;
		public readonly FUNC_SUBTRACT;
		public readonly GENERATE_MIPMAP_HINT;
		public readonly GEQUAL;
		public readonly GREATER;
		public readonly GREEN_BITS;
		public readonly HIGH_FLOAT;
		public readonly HIGH_INT;
		public readonly IMPLEMENTATION_COLOR_READ_FORMAT;
		public readonly IMPLEMENTATION_COLOR_READ_TYPE;
		public readonly INCR;
		public readonly INCR_WRAP;
		public readonly INT;
		public readonly INT_VEC2;
		public readonly INT_VEC3;
		public readonly INT_VEC4;
		public readonly INVALID_ENUM;
		public readonly INVALID_FRAMEBUFFER_OPERATION;
		public readonly INVALID_OPERATION;
		public readonly INVALID_VALUE;
		public readonly INVERT;
		public readonly KEEP;
		public readonly LEQUAL;
		public readonly LESS;
		public readonly LINEAR;
		public readonly LINEAR_MIPMAP_LINEAR;
		public readonly LINEAR_MIPMAP_NEAREST;
		public readonly LINES;
		public readonly LINE_LOOP;
		public readonly LINE_STRIP;
		public readonly LINE_WIDTH;
		public readonly LINK_STATUS;
		public readonly LOW_FLOAT;
		public readonly LOW_INT;
		public readonly LUMINANCE;
		public readonly LUMINANCE_ALPHA;
		public readonly MAX_COMBINED_TEXTURE_IMAGE_UNITS;
		public readonly MAX_CUBE_MAP_TEXTURE_SIZE;
		public readonly MAX_FRAGMENT_UNIFORM_VECTORS;
		public readonly MAX_RENDERBUFFER_SIZE;
		public readonly MAX_TEXTURE_IMAGE_UNITS;
		public readonly MAX_TEXTURE_SIZE;
		public readonly MAX_VARYING_VECTORS;
		public readonly MAX_VERTEX_ATTRIBS;
		public readonly MAX_VERTEX_TEXTURE_IMAGE_UNITS;
		public readonly MAX_VERTEX_UNIFORM_VECTORS;
		public readonly MAX_VIEWPORT_DIMS;
		public readonly MEDIUM_FLOAT;
		public readonly MEDIUM_INT;
		public readonly MIRRORED_REPEAT;
		public readonly NEAREST;
		public readonly NEAREST_MIPMAP_LINEAR;
		public readonly NEAREST_MIPMAP_NEAREST;
		public readonly NEVER;
		public readonly NICEST;
		public readonly NONE;
		public readonly NOTEQUAL;
		public readonly NO_ERROR;
		public readonly ONE;
		public readonly ONE_MINUS_CONSTANT_ALPHA;
		public readonly ONE_MINUS_CONSTANT_COLOR;
		public readonly ONE_MINUS_DST_ALPHA;
		public readonly ONE_MINUS_DST_COLOR;
		public readonly ONE_MINUS_SRC_ALPHA;
		public readonly ONE_MINUS_SRC_COLOR;
		public readonly OUT_OF_MEMORY;
		public readonly PACK_ALIGNMENT;
		public readonly POINTS;
		public readonly POLYGON_OFFSET_FACTOR;
		public readonly POLYGON_OFFSET_FILL;
		public readonly POLYGON_OFFSET_UNITS;
		public readonly RED_BITS;
		public readonly RENDERBUFFER;
		public readonly RENDERBUFFER_ALPHA_SIZE;
		public readonly RENDERBUFFER_BINDING;
		public readonly RENDERBUFFER_BLUE_SIZE;
		public readonly RENDERBUFFER_DEPTH_SIZE;
		public readonly RENDERBUFFER_GREEN_SIZE;
		public readonly RENDERBUFFER_HEIGHT;
		public readonly RENDERBUFFER_INTERNAL_FORMAT;
		public readonly RENDERBUFFER_RED_SIZE;
		public readonly RENDERBUFFER_STENCIL_SIZE;
		public readonly RENDERBUFFER_WIDTH;
		public readonly RENDERER;
		public readonly REPEAT;
		public readonly REPLACE;
		public readonly RGB;
		public readonly RGB565;
		public readonly RGB5_A1;
		public readonly RGBA;
		public readonly RGBA4;
		public readonly SAMPLER_2D;
		public readonly SAMPLER_CUBE;
		public readonly SAMPLES;
		public readonly SAMPLE_ALPHA_TO_COVERAGE;
		public readonly SAMPLE_BUFFERS;
		public readonly SAMPLE_COVERAGE;
		public readonly SAMPLE_COVERAGE_INVERT;
		public readonly SAMPLE_COVERAGE_VALUE;
		public readonly SCISSOR_BOX;
		public readonly SCISSOR_TEST;
		public readonly SHADER_TYPE;
		public readonly SHADING_LANGUAGE_VERSION;
		public readonly SHORT;
		public readonly SRC_ALPHA;
		public readonly SRC_ALPHA_SATURATE;
		public readonly SRC_COLOR;
		public readonly STATIC_DRAW;
		public readonly STENCIL_ATTACHMENT;
		public readonly STENCIL_BACK_FAIL;
		public readonly STENCIL_BACK_FUNC;
		public readonly STENCIL_BACK_PASS_DEPTH_FAIL;
		public readonly STENCIL_BACK_PASS_DEPTH_PASS;
		public readonly STENCIL_BACK_REF;
		public readonly STENCIL_BACK_VALUE_MASK;
		public readonly STENCIL_BACK_WRITEMASK;
		public readonly STENCIL_BITS;
		public readonly STENCIL_BUFFER_BIT;
		public readonly STENCIL_CLEAR_VALUE;
		public readonly STENCIL_FAIL;
		public readonly STENCIL_FUNC;
		public readonly STENCIL_INDEX;
		public readonly STENCIL_INDEX8;
		public readonly STENCIL_PASS_DEPTH_FAIL;
		public readonly STENCIL_PASS_DEPTH_PASS;
		public readonly STENCIL_REF;
		public readonly STENCIL_TEST;
		public readonly STENCIL_VALUE_MASK;
		public readonly STENCIL_WRITEMASK;
		public readonly STREAM_DRAW;
		public readonly SUBPIXEL_BITS;
		public readonly TEXTURE;
		public readonly TEXTURE0;
		public readonly TEXTURE1;
		public readonly TEXTURE10;
		public readonly TEXTURE11;
		public readonly TEXTURE12;
		public readonly TEXTURE13;
		public readonly TEXTURE14;
		public readonly TEXTURE15;
		public readonly TEXTURE16;
		public readonly TEXTURE17;
		public readonly TEXTURE18;
		public readonly TEXTURE19;
		public readonly TEXTURE2;
		public readonly TEXTURE20;
		public readonly TEXTURE21;
		public readonly TEXTURE22;
		public readonly TEXTURE23;
		public readonly TEXTURE24;
		public readonly TEXTURE25;
		public readonly TEXTURE26;
		public readonly TEXTURE27;
		public readonly TEXTURE28;
		public readonly TEXTURE29;
		public readonly TEXTURE3;
		public readonly TEXTURE30;
		public readonly TEXTURE31;
		public readonly TEXTURE4;
		public readonly TEXTURE5;
		public readonly TEXTURE6;
		public readonly TEXTURE7;
		public readonly TEXTURE8;
		public readonly TEXTURE9;
		public readonly TEXTURE_2D;
		public readonly TEXTURE_BINDING_2D;
		public readonly TEXTURE_BINDING_CUBE_MAP;
		public readonly TEXTURE_CUBE_MAP;
		public readonly TEXTURE_CUBE_MAP_NEGATIVE_X;
		public readonly TEXTURE_CUBE_MAP_NEGATIVE_Y;
		public readonly TEXTURE_CUBE_MAP_NEGATIVE_Z;
		public readonly TEXTURE_CUBE_MAP_POSITIVE_X;
		public readonly TEXTURE_CUBE_MAP_POSITIVE_Y;
		public readonly TEXTURE_CUBE_MAP_POSITIVE_Z;
		public readonly TEXTURE_MAG_FILTER;
		public readonly TEXTURE_MIN_FILTER;
		public readonly TEXTURE_WRAP_S;
		public readonly TEXTURE_WRAP_T;
		public readonly TRIANGLES;
		public readonly TRIANGLE_FAN;
		public readonly TRIANGLE_STRIP;
		public readonly UNPACK_ALIGNMENT;
		public readonly UNPACK_COLORSPACE_CONVERSION_WEBGL;
		public readonly UNPACK_FLIP_Y_WEBGL;
		public readonly UNPACK_PREMULTIPLY_ALPHA_WEBGL;
		public readonly UNSIGNED_BYTE;
		public readonly UNSIGNED_INT;
		public readonly UNSIGNED_SHORT;
		public readonly UNSIGNED_SHORT_4_4_4_4;
		public readonly UNSIGNED_SHORT_5_5_5_1;
		public readonly UNSIGNED_SHORT_5_6_5;
		public readonly VALIDATE_STATUS;
		public readonly VENDOR;
		public readonly VERSION;
		public readonly VERTEX_ATTRIB_ARRAY_BUFFER_BINDING;
		public readonly VERTEX_ATTRIB_ARRAY_ENABLED;
		public readonly VERTEX_ATTRIB_ARRAY_NORMALIZED;
		public readonly VERTEX_ATTRIB_ARRAY_POINTER;
		public readonly VERTEX_ATTRIB_ARRAY_SIZE;
		public readonly VERTEX_ATTRIB_ARRAY_STRIDE;
		public readonly VERTEX_ATTRIB_ARRAY_TYPE;
		public readonly VERTEX_SHADER;
		public readonly VIEWPORT;
		public readonly ZERO;
		public void activeTexture(float texture)
		{
			throw new System.NotImplementedException();
		}
		public void attachShader(Any<WebGLProgram, null> program, Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public void bindAttribLocation(Any<WebGLProgram, null> program, float index, string name)
		{
			throw new System.NotImplementedException();
		}
		public void bindBuffer(float target, Any<WebGLBuffer, null> buffer)
		{
			throw new System.NotImplementedException();
		}
		public void bindFramebuffer(float target, Any<WebGLFramebuffer, null> framebuffer)
		{
			throw new System.NotImplementedException();
		}
		public void bindRenderbuffer(float target, Any<WebGLRenderbuffer, null> renderbuffer)
		{
			throw new System.NotImplementedException();
		}
		public void bindTexture(float target, Any<WebGLTexture, null> texture)
		{
			throw new System.NotImplementedException();
		}
		public void blendColor(float red, float green, float blue, float alpha)
		{
			throw new System.NotImplementedException();
		}
		public void blendEquation(float mode)
		{
			throw new System.NotImplementedException();
		}
		public void blendEquationSeparate(float modeRGB, float modeAlpha)
		{
			throw new System.NotImplementedException();
		}
		public void blendFunc(float sfactor, float dfactor)
		{
			throw new System.NotImplementedException();
		}
		public void blendFuncSeparate(float srcRGB, float dstRGB, float srcAlpha, float dstAlpha)
		{
			throw new System.NotImplementedException();
		}
		public void bufferData(float target, Any<float, Bridge.Html5.ArrayBufferView, Bridge.Html5.ArrayBuffer> size, float usage)
		{
			throw new System.NotImplementedException();
		}
		public void bufferSubData(float target, float offset, Any<Bridge.Html5.ArrayBufferView, Bridge.Html5.ArrayBuffer> data)
		{
			throw new System.NotImplementedException();
		}
		public float checkFramebufferStatus(float target)
		{
			throw new System.NotImplementedException();
		}
		public void clear(float mask)
		{
			throw new System.NotImplementedException();
		}
		public void clearColor(float red, float green, float blue, float alpha)
		{
			throw new System.NotImplementedException();
		}
		public void clearDepth(float depth)
		{
			throw new System.NotImplementedException();
		}
		public void clearStencil(float s)
		{
			throw new System.NotImplementedException();
		}
		public void colorMask(bool red, bool green, bool blue, bool alpha)
		{
			throw new System.NotImplementedException();
		}
		public void compileShader(Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public void compressedTexImage2D(float target, float level, float internalformat, float width, float height, float border, Bridge.Html5.ArrayBufferView data)
		{
			throw new System.NotImplementedException();
		}
		public void compressedTexSubImage2D(float target, float level, float xoffset, float yoffset, float width, float height, float format, Bridge.Html5.ArrayBufferView data)
		{
			throw new System.NotImplementedException();
		}
		public void copyTexImage2D(float target, float level, float internalformat, float x, float y, float width, float height, float border)
		{
			throw new System.NotImplementedException();
		}
		public void copyTexSubImage2D(float target, float level, float xoffset, float yoffset, float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLBuffer, null> createBuffer()
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLFramebuffer, null> createFramebuffer()
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLProgram, null> createProgram()
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLRenderbuffer, null> createRenderbuffer()
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLShader, null> createShader(float type)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLTexture, null> createTexture()
		{
			throw new System.NotImplementedException();
		}
		public void cullFace(float mode)
		{
			throw new System.NotImplementedException();
		}
		public void deleteBuffer(Any<WebGLBuffer, null> buffer)
		{
			throw new System.NotImplementedException();
		}
		public void deleteFramebuffer(Any<WebGLFramebuffer, null> framebuffer)
		{
			throw new System.NotImplementedException();
		}
		public void deleteProgram(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public void deleteRenderbuffer(Any<WebGLRenderbuffer, null> renderbuffer)
		{
			throw new System.NotImplementedException();
		}
		public void deleteShader(Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public void deleteTexture(Any<WebGLTexture, null> texture)
		{
			throw new System.NotImplementedException();
		}
		public void depthFunc(float func)
		{
			throw new System.NotImplementedException();
		}
		public void depthMask(bool flag)
		{
			throw new System.NotImplementedException();
		}
		public void depthRange(float zNear, float zFar)
		{
			throw new System.NotImplementedException();
		}
		public void detachShader(Any<WebGLProgram, null> program, Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public void disable(float cap)
		{
			throw new System.NotImplementedException();
		}
		public void disableVertexAttribArray(float index)
		{
			throw new System.NotImplementedException();
		}
		public void drawArrays(float mode, float first, float count)
		{
			throw new System.NotImplementedException();
		}
		public void drawElements(float mode, float count, float type, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void enable(float cap)
		{
			throw new System.NotImplementedException();
		}
		public void enableVertexAttribArray(float index)
		{
			throw new System.NotImplementedException();
		}
		public void finish()
		{
			throw new System.NotImplementedException();
		}
		public void flush()
		{
			throw new System.NotImplementedException();
		}
		public void framebufferRenderbuffer(float target, float attachment, float renderbuffertarget, Any<WebGLRenderbuffer, null> renderbuffer)
		{
			throw new System.NotImplementedException();
		}
		public void framebufferTexture2D(float target, float attachment, float textarget, Any<WebGLTexture, null> texture, float level)
		{
			throw new System.NotImplementedException();
		}
		public void frontFace(float mode)
		{
			throw new System.NotImplementedException();
		}
		public void generateMipmap(float target)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLActiveInfo, null> getActiveAttrib(Any<WebGLProgram, null> program, float index)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLActiveInfo, null> getActiveUniform(Any<WebGLProgram, null> program, float index)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLShader[], null> getAttachedShaders(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public float getAttribLocation(Any<WebGLProgram, null> program, string name)
		{
			throw new System.NotImplementedException();
		}
		public object getBufferParameter(float target, float pname)
		{
			throw new System.NotImplementedException();
		}
		public WebGLContextAttributes getContextAttributes()
		{
			throw new System.NotImplementedException();
		}
		public float getError()
		{
			throw new System.NotImplementedException();
		}
		public object getExtension(string name)
		{
			throw new System.NotImplementedException();
		}
		public object getFramebufferAttachmentParameter(float target, float attachment, float pname)
		{
			throw new System.NotImplementedException();
		}
		public object getParameter(float pname)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> getProgramInfoLog(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public object getProgramParameter(Any<WebGLProgram, null> program, float pname)
		{
			throw new System.NotImplementedException();
		}
		public object getRenderbufferParameter(float target, float pname)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> getShaderInfoLog(Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public object getShaderParameter(Any<WebGLShader, null> shader, float pname)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLShaderPrecisionFormat, null> getShaderPrecisionFormat(float shadertype, float precisiontype)
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> getShaderSource(Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public Any<string[], null> getSupportedExtensions()
		{
			throw new System.NotImplementedException();
		}
		public object getTexParameter(float target, float pname)
		{
			throw new System.NotImplementedException();
		}
		public object getUniform(Any<WebGLProgram, null> program, Any<WebGLUniformLocation, null> location)
		{
			throw new System.NotImplementedException();
		}
		public Any<WebGLUniformLocation, null> getUniformLocation(Any<WebGLProgram, null> program, string name)
		{
			throw new System.NotImplementedException();
		}
		public object getVertexAttrib(float index, float pname)
		{
			throw new System.NotImplementedException();
		}
		public float getVertexAttribOffset(float index, float pname)
		{
			throw new System.NotImplementedException();
		}
		public void hint(float target, float mode)
		{
			throw new System.NotImplementedException();
		}
		public bool isBuffer(Any<WebGLBuffer, null> buffer)
		{
			throw new System.NotImplementedException();
		}
		public bool isContextLost()
		{
			throw new System.NotImplementedException();
		}
		public bool isEnabled(float cap)
		{
			throw new System.NotImplementedException();
		}
		public bool isFramebuffer(Any<WebGLFramebuffer, null> framebuffer)
		{
			throw new System.NotImplementedException();
		}
		public bool isProgram(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public bool isRenderbuffer(Any<WebGLRenderbuffer, null> renderbuffer)
		{
			throw new System.NotImplementedException();
		}
		public bool isShader(Any<WebGLShader, null> shader)
		{
			throw new System.NotImplementedException();
		}
		public bool isTexture(Any<WebGLTexture, null> texture)
		{
			throw new System.NotImplementedException();
		}
		public void lineWidth(float width)
		{
			throw new System.NotImplementedException();
		}
		public void linkProgram(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public void pixelStorei(float pname, float param)
		{
			throw new System.NotImplementedException();
		}
		public void polygonOffset(float factor, float units)
		{
			throw new System.NotImplementedException();
		}
		public void readPixels(float x, float y, float width, float height, float format, float type, Any<Bridge.Html5.ArrayBufferView, null> pixels)
		{
			throw new System.NotImplementedException();
		}
		public void renderbufferStorage(float target, float internalformat, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void sampleCoverage(float value, bool invert)
		{
			throw new System.NotImplementedException();
		}
		public void scissor(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
		public void shaderSource(Any<WebGLShader, null> shader, string source)
		{
			throw new System.NotImplementedException();
		}
		public void stencilFunc(float func, float ref, float mask)
		{
			throw new System.NotImplementedException();
		}
		public void stencilFuncSeparate(float face, float func, float ref, float mask)
		{
			throw new System.NotImplementedException();
		}
		public void stencilMask(float mask)
		{
			throw new System.NotImplementedException();
		}
		public void stencilMaskSeparate(float face, float mask)
		{
			throw new System.NotImplementedException();
		}
		public void stencilOp(float fail, float zfail, float zpass)
		{
			throw new System.NotImplementedException();
		}
		public void stencilOpSeparate(float face, float fail, float zfail, float zpass)
		{
			throw new System.NotImplementedException();
		}
		public void texImage2D(float target, float level, float internalformat, float width, float height, float border, float format, float type, Bridge.Html5.ArrayBufferView pixels = default(Bridge.Html5.ArrayBufferView))
		{
			throw new System.NotImplementedException();
		}
		public void texImage2D(float target, float level, float internalformat, float format, float type, Any<ImageData, HTMLVideoElement, HTMLImageElement, HTMLCanvasElement> pixels = default(Any<ImageData, HTMLVideoElement, HTMLImageElement, HTMLCanvasElement>))
		{
			throw new System.NotImplementedException();
		}
		public void texParameterf(float target, float pname, float param)
		{
			throw new System.NotImplementedException();
		}
		public void texParameteri(float target, float pname, float param)
		{
			throw new System.NotImplementedException();
		}
		public void texSubImage2D(float target, float level, float xoffset, float yoffset, float width, float height, float format, float type, Bridge.Html5.ArrayBufferView pixels = default(Bridge.Html5.ArrayBufferView))
		{
			throw new System.NotImplementedException();
		}
		public void texSubImage2D(float target, float level, float xoffset, float yoffset, float format, float type, Any<ImageData, HTMLVideoElement, HTMLImageElement, HTMLCanvasElement> pixels = default(Any<ImageData, HTMLVideoElement, HTMLImageElement, HTMLCanvasElement>))
		{
			throw new System.NotImplementedException();
		}
		public void uniform1f(Any<WebGLUniformLocation, null> location, float x)
		{
			throw new System.NotImplementedException();
		}
		public void uniform1fv(WebGLUniformLocation location, Any<Bridge.Html5.Float32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform1i(Any<WebGLUniformLocation, null> location, float x)
		{
			throw new System.NotImplementedException();
		}
		public void uniform1iv(WebGLUniformLocation location, Any<Bridge.Html5.Int32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform2f(Any<WebGLUniformLocation, null> location, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void uniform2fv(WebGLUniformLocation location, Any<Bridge.Html5.Float32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform2i(Any<WebGLUniformLocation, null> location, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void uniform2iv(WebGLUniformLocation location, Any<Bridge.Html5.Int32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform3f(Any<WebGLUniformLocation, null> location, float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public void uniform3fv(WebGLUniformLocation location, Any<Bridge.Html5.Float32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform3i(Any<WebGLUniformLocation, null> location, float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public void uniform3iv(WebGLUniformLocation location, Any<Bridge.Html5.Int32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform4f(Any<WebGLUniformLocation, null> location, float x, float y, float z, float w)
		{
			throw new System.NotImplementedException();
		}
		public void uniform4fv(WebGLUniformLocation location, Any<Bridge.Html5.Float32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniform4i(Any<WebGLUniformLocation, null> location, float x, float y, float z, float w)
		{
			throw new System.NotImplementedException();
		}
		public void uniform4iv(WebGLUniformLocation location, Any<Bridge.Html5.Int32Array, float[]> v)
		{
			throw new System.NotImplementedException();
		}
		public void uniformMatrix2fv(WebGLUniformLocation location, bool transpose, Any<Bridge.Html5.Float32Array, float[]> value)
		{
			throw new System.NotImplementedException();
		}
		public void uniformMatrix3fv(WebGLUniformLocation location, bool transpose, Any<Bridge.Html5.Float32Array, float[]> value)
		{
			throw new System.NotImplementedException();
		}
		public void uniformMatrix4fv(WebGLUniformLocation location, bool transpose, Any<Bridge.Html5.Float32Array, float[]> value)
		{
			throw new System.NotImplementedException();
		}
		public void useProgram(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public void validateProgram(Any<WebGLProgram, null> program)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib1f(float indx, float x)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib1fv(float indx, Any<Bridge.Html5.Float32Array, float[]> values)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib2f(float indx, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib2fv(float indx, Any<Bridge.Html5.Float32Array, float[]> values)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib3f(float indx, float x, float y, float z)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib3fv(float indx, Any<Bridge.Html5.Float32Array, float[]> values)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib4f(float indx, float x, float y, float z, float w)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttrib4fv(float indx, Any<Bridge.Html5.Float32Array, float[]> values)
		{
			throw new System.NotImplementedException();
		}
		public void vertexAttribPointer(float indx, float size, float type, bool normalized, float stride, float offset)
		{
			throw new System.NotImplementedException();
		}
		public void viewport(float x, float y, float width, float height)
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLRenderingContext_0_
	{
		public IWebGLRenderingContext prototype;
		public float ACTIVE_ATTRIBUTES;
		public float ACTIVE_TEXTURE;
		public float ACTIVE_UNIFORMS;
		public float ALIASED_LINE_WIDTH_RANGE;
		public float ALIASED_POINT_SIZE_RANGE;
		public float ALPHA;
		public float ALPHA_BITS;
		public float ALWAYS;
		public float ARRAY_BUFFER;
		public float ARRAY_BUFFER_BINDING;
		public float ATTACHED_SHADERS;
		public float BACK;
		public float BLEND;
		public float BLEND_COLOR;
		public float BLEND_DST_ALPHA;
		public float BLEND_DST_RGB;
		public float BLEND_EQUATION;
		public float BLEND_EQUATION_ALPHA;
		public float BLEND_EQUATION_RGB;
		public float BLEND_SRC_ALPHA;
		public float BLEND_SRC_RGB;
		public float BLUE_BITS;
		public float BOOL;
		public float BOOL_VEC2;
		public float BOOL_VEC3;
		public float BOOL_VEC4;
		public float BROWSER_DEFAULT_WEBGL;
		public float BUFFER_SIZE;
		public float BUFFER_USAGE;
		public float BYTE;
		public float CCW;
		public float CLAMP_TO_EDGE;
		public float COLOR_ATTACHMENT0;
		public float COLOR_BUFFER_BIT;
		public float COLOR_CLEAR_VALUE;
		public float COLOR_WRITEMASK;
		public float COMPILE_STATUS;
		public float COMPRESSED_TEXTURE_FORMATS;
		public float CONSTANT_ALPHA;
		public float CONSTANT_COLOR;
		public float CONTEXT_LOST_WEBGL;
		public float CULL_FACE;
		public float CULL_FACE_MODE;
		public float CURRENT_PROGRAM;
		public float CURRENT_VERTEX_ATTRIB;
		public float CW;
		public float DECR;
		public float DECR_WRAP;
		public float DELETE_STATUS;
		public float DEPTH_ATTACHMENT;
		public float DEPTH_BITS;
		public float DEPTH_BUFFER_BIT;
		public float DEPTH_CLEAR_VALUE;
		public float DEPTH_COMPONENT;
		public float DEPTH_COMPONENT16;
		public float DEPTH_FUNC;
		public float DEPTH_RANGE;
		public float DEPTH_STENCIL;
		public float DEPTH_STENCIL_ATTACHMENT;
		public float DEPTH_TEST;
		public float DEPTH_WRITEMASK;
		public float DITHER;
		public float DONT_CARE;
		public float DST_ALPHA;
		public float DST_COLOR;
		public float DYNAMIC_DRAW;
		public float ELEMENT_ARRAY_BUFFER;
		public float ELEMENT_ARRAY_BUFFER_BINDING;
		public float EQUAL;
		public float FASTEST;
		public float FLOAT;
		public float FLOAT_MAT2;
		public float FLOAT_MAT3;
		public float FLOAT_MAT4;
		public float FLOAT_VEC2;
		public float FLOAT_VEC3;
		public float FLOAT_VEC4;
		public float FRAGMENT_SHADER;
		public float FRAMEBUFFER;
		public float FRAMEBUFFER_ATTACHMENT_OBJECT_NAME;
		public float FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE;
		public float FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE;
		public float FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL;
		public float FRAMEBUFFER_BINDING;
		public float FRAMEBUFFER_COMPLETE;
		public float FRAMEBUFFER_INCOMPLETE_ATTACHMENT;
		public float FRAMEBUFFER_INCOMPLETE_DIMENSIONS;
		public float FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT;
		public float FRAMEBUFFER_UNSUPPORTED;
		public float FRONT;
		public float FRONT_AND_BACK;
		public float FRONT_FACE;
		public float FUNC_ADD;
		public float FUNC_REVERSE_SUBTRACT;
		public float FUNC_SUBTRACT;
		public float GENERATE_MIPMAP_HINT;
		public float GEQUAL;
		public float GREATER;
		public float GREEN_BITS;
		public float HIGH_FLOAT;
		public float HIGH_INT;
		public float IMPLEMENTATION_COLOR_READ_FORMAT;
		public float IMPLEMENTATION_COLOR_READ_TYPE;
		public float INCR;
		public float INCR_WRAP;
		public float INT;
		public float INT_VEC2;
		public float INT_VEC3;
		public float INT_VEC4;
		public float INVALID_ENUM;
		public float INVALID_FRAMEBUFFER_OPERATION;
		public float INVALID_OPERATION;
		public float INVALID_VALUE;
		public float INVERT;
		public float KEEP;
		public float LEQUAL;
		public float LESS;
		public float LINEAR;
		public float LINEAR_MIPMAP_LINEAR;
		public float LINEAR_MIPMAP_NEAREST;
		public float LINES;
		public float LINE_LOOP;
		public float LINE_STRIP;
		public float LINE_WIDTH;
		public float LINK_STATUS;
		public float LOW_FLOAT;
		public float LOW_INT;
		public float LUMINANCE;
		public float LUMINANCE_ALPHA;
		public float MAX_COMBINED_TEXTURE_IMAGE_UNITS;
		public float MAX_CUBE_MAP_TEXTURE_SIZE;
		public float MAX_FRAGMENT_UNIFORM_VECTORS;
		public float MAX_RENDERBUFFER_SIZE;
		public float MAX_TEXTURE_IMAGE_UNITS;
		public float MAX_TEXTURE_SIZE;
		public float MAX_VARYING_VECTORS;
		public float MAX_VERTEX_ATTRIBS;
		public float MAX_VERTEX_TEXTURE_IMAGE_UNITS;
		public float MAX_VERTEX_UNIFORM_VECTORS;
		public float MAX_VIEWPORT_DIMS;
		public float MEDIUM_FLOAT;
		public float MEDIUM_INT;
		public float MIRRORED_REPEAT;
		public float NEAREST;
		public float NEAREST_MIPMAP_LINEAR;
		public float NEAREST_MIPMAP_NEAREST;
		public float NEVER;
		public float NICEST;
		public float NONE;
		public float NOTEQUAL;
		public float NO_ERROR;
		public float ONE;
		public float ONE_MINUS_CONSTANT_ALPHA;
		public float ONE_MINUS_CONSTANT_COLOR;
		public float ONE_MINUS_DST_ALPHA;
		public float ONE_MINUS_DST_COLOR;
		public float ONE_MINUS_SRC_ALPHA;
		public float ONE_MINUS_SRC_COLOR;
		public float OUT_OF_MEMORY;
		public float PACK_ALIGNMENT;
		public float POINTS;
		public float POLYGON_OFFSET_FACTOR;
		public float POLYGON_OFFSET_FILL;
		public float POLYGON_OFFSET_UNITS;
		public float RED_BITS;
		public float RENDERBUFFER;
		public float RENDERBUFFER_ALPHA_SIZE;
		public float RENDERBUFFER_BINDING;
		public float RENDERBUFFER_BLUE_SIZE;
		public float RENDERBUFFER_DEPTH_SIZE;
		public float RENDERBUFFER_GREEN_SIZE;
		public float RENDERBUFFER_HEIGHT;
		public float RENDERBUFFER_INTERNAL_FORMAT;
		public float RENDERBUFFER_RED_SIZE;
		public float RENDERBUFFER_STENCIL_SIZE;
		public float RENDERBUFFER_WIDTH;
		public float RENDERER;
		public float REPEAT;
		public float REPLACE;
		public float RGB;
		public float RGB565;
		public float RGB5_A1;
		public float RGBA;
		public float RGBA4;
		public float SAMPLER_2D;
		public float SAMPLER_CUBE;
		public float SAMPLES;
		public float SAMPLE_ALPHA_TO_COVERAGE;
		public float SAMPLE_BUFFERS;
		public float SAMPLE_COVERAGE;
		public float SAMPLE_COVERAGE_INVERT;
		public float SAMPLE_COVERAGE_VALUE;
		public float SCISSOR_BOX;
		public float SCISSOR_TEST;
		public float SHADER_TYPE;
		public float SHADING_LANGUAGE_VERSION;
		public float SHORT;
		public float SRC_ALPHA;
		public float SRC_ALPHA_SATURATE;
		public float SRC_COLOR;
		public float STATIC_DRAW;
		public float STENCIL_ATTACHMENT;
		public float STENCIL_BACK_FAIL;
		public float STENCIL_BACK_FUNC;
		public float STENCIL_BACK_PASS_DEPTH_FAIL;
		public float STENCIL_BACK_PASS_DEPTH_PASS;
		public float STENCIL_BACK_REF;
		public float STENCIL_BACK_VALUE_MASK;
		public float STENCIL_BACK_WRITEMASK;
		public float STENCIL_BITS;
		public float STENCIL_BUFFER_BIT;
		public float STENCIL_CLEAR_VALUE;
		public float STENCIL_FAIL;
		public float STENCIL_FUNC;
		public float STENCIL_INDEX;
		public float STENCIL_INDEX8;
		public float STENCIL_PASS_DEPTH_FAIL;
		public float STENCIL_PASS_DEPTH_PASS;
		public float STENCIL_REF;
		public float STENCIL_TEST;
		public float STENCIL_VALUE_MASK;
		public float STENCIL_WRITEMASK;
		public float STREAM_DRAW;
		public float SUBPIXEL_BITS;
		public float TEXTURE;
		public float TEXTURE0;
		public float TEXTURE1;
		public float TEXTURE10;
		public float TEXTURE11;
		public float TEXTURE12;
		public float TEXTURE13;
		public float TEXTURE14;
		public float TEXTURE15;
		public float TEXTURE16;
		public float TEXTURE17;
		public float TEXTURE18;
		public float TEXTURE19;
		public float TEXTURE2;
		public float TEXTURE20;
		public float TEXTURE21;
		public float TEXTURE22;
		public float TEXTURE23;
		public float TEXTURE24;
		public float TEXTURE25;
		public float TEXTURE26;
		public float TEXTURE27;
		public float TEXTURE28;
		public float TEXTURE29;
		public float TEXTURE3;
		public float TEXTURE30;
		public float TEXTURE31;
		public float TEXTURE4;
		public float TEXTURE5;
		public float TEXTURE6;
		public float TEXTURE7;
		public float TEXTURE8;
		public float TEXTURE9;
		public float TEXTURE_2D;
		public float TEXTURE_BINDING_2D;
		public float TEXTURE_BINDING_CUBE_MAP;
		public float TEXTURE_CUBE_MAP;
		public float TEXTURE_CUBE_MAP_NEGATIVE_X;
		public float TEXTURE_CUBE_MAP_NEGATIVE_Y;
		public float TEXTURE_CUBE_MAP_NEGATIVE_Z;
		public float TEXTURE_CUBE_MAP_POSITIVE_X;
		public float TEXTURE_CUBE_MAP_POSITIVE_Y;
		public float TEXTURE_CUBE_MAP_POSITIVE_Z;
		public float TEXTURE_MAG_FILTER;
		public float TEXTURE_MIN_FILTER;
		public float TEXTURE_WRAP_S;
		public float TEXTURE_WRAP_T;
		public float TRIANGLES;
		public float TRIANGLE_FAN;
		public float TRIANGLE_STRIP;
		public float UNPACK_ALIGNMENT;
		public float UNPACK_COLORSPACE_CONVERSION_WEBGL;
		public float UNPACK_FLIP_Y_WEBGL;
		public float UNPACK_PREMULTIPLY_ALPHA_WEBGL;
		public float UNSIGNED_BYTE;
		public float UNSIGNED_INT;
		public float UNSIGNED_SHORT;
		public float UNSIGNED_SHORT_4_4_4_4;
		public float UNSIGNED_SHORT_5_5_5_1;
		public float UNSIGNED_SHORT_5_6_5;
		public float VALIDATE_STATUS;
		public float VENDOR;
		public float VERSION;
		public float VERTEX_ATTRIB_ARRAY_BUFFER_BINDING;
		public float VERTEX_ATTRIB_ARRAY_ENABLED;
		public float VERTEX_ATTRIB_ARRAY_NORMALIZED;
		public float VERTEX_ATTRIB_ARRAY_POINTER;
		public float VERTEX_ATTRIB_ARRAY_SIZE;
		public float VERTEX_ATTRIB_ARRAY_STRIDE;
		public float VERTEX_ATTRIB_ARRAY_TYPE;
		public float VERTEX_SHADER;
		public float VIEWPORT;
		public float ZERO;
		public IWebGLRenderingContext new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLShader : WebGLObject
	{
		protected WebGLShader() : base()
		{
			
		}
	}

		public class WebGLShader_0_
	{
		public WebGLShader prototype;
		public WebGLShader new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLShaderPrecisionFormat
	{
		protected WebGLShaderPrecisionFormat()
		{
			
		}
		public readonly precision;
		public readonly rangeMax;
		public readonly rangeMin;
	}

		public class WebGLShaderPrecisionFormat_0_
	{
		public WebGLShaderPrecisionFormat prototype;
		public WebGLShaderPrecisionFormat new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLTexture : WebGLObject
	{
		protected WebGLTexture() : base()
		{
			
		}
	}

		public class WebGLTexture_0_
	{
		public WebGLTexture prototype;
		public WebGLTexture new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebGLUniformLocation
	{
		protected WebGLUniformLocation()
		{
			
		}
	}

		public class WebGLUniformLocation_0_
	{
		public WebGLUniformLocation prototype;
		public WebGLUniformLocation new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebKitCSSMatrix
	{
		protected WebKitCSSMatrix()
		{
			
		}
		public float a;
		public float b;
		public float c;
		public float d;
		public float e;
		public float f;
		public float m11;
		public float m12;
		public float m13;
		public float m14;
		public float m21;
		public float m22;
		public float m23;
		public float m24;
		public float m31;
		public float m32;
		public float m33;
		public float m34;
		public float m41;
		public float m42;
		public float m43;
		public float m44;
		public WebKitCSSMatrix inverse()
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix multiply(WebKitCSSMatrix secondMatrix)
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix rotate(float angleX, float angleY = default(float), float angleZ = default(float))
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix rotateAxisAngle(float x, float y, float z, float angle)
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix scale(float scaleX, float scaleY = default(float), float scaleZ = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void setMatrixValue(string value)
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix skewX(float angle)
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix skewY(float angle)
		{
			throw new System.NotImplementedException();
		}
		public string toString()
		{
			throw new System.NotImplementedException();
		}
		public WebKitCSSMatrix translate(float x, float y, float z = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebKitCSSMatrix_0_
	{
		public WebKitCSSMatrix prototype;
		public WebKitCSSMatrix new(string text = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebKitPoint
	{
		protected WebKitPoint()
		{
			
		}
		public float x;
		public float y;
	}

		public class WebKitPoint_0_
	{
		public WebKitPoint prototype;
		public WebKitPoint new(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebSocket : EventTarget
	{
		protected WebSocket() : base()
		{
			
		}
		public string binaryType;
		public readonly bufferedAmount;
		public readonly extensions;
		public Func<, object> onclose;
		public Event ev;
		public object any;
		public Func<, object> onerror;
		public Func<, object> onmessage;
		public Func<, object> onopen;
		public readonly protocol;
		public readonly readyState;
		public readonly url;
		public readonly CLOSED;
		public readonly CLOSING;
		public readonly CONNECTING;
		public readonly OPEN;
		public Func<, object> listener;
		public bool useCapture;
		public void close(float code = default(float), string reason = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void send(object data)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class WebSocket_0_
	{
		public WebSocket prototype;
		public float CLOSED;
		public float CLOSING;
		public float CONNECTING;
		public float OPEN;
		public WebSocket new(string url, Any<string, string[]> protocols = default(Any<string, string[]>))
		{
			throw new System.NotImplementedException();
		}
	}

		public class WheelEvent : MouseEvent
	{
		protected WheelEvent() : base()
		{
			
		}
		public readonly deltaMode;
		public readonly deltaX;
		public readonly deltaY;
		public readonly deltaZ;
		public readonly wheelDelta;
		public readonly wheelDeltaX;
		public readonly wheelDeltaY;
		public readonly DOM_DELTA_LINE;
		public readonly DOM_DELTA_PAGE;
		public readonly DOM_DELTA_PIXEL;
		public void getCurrentPoint(Element element)
		{
			throw new System.NotImplementedException();
		}
		public void initWheelEvent(string typeArg, bool canBubbleArg, bool cancelableArg, IWindow viewArg, float detailArg, float screenXArg, float screenYArg, float clientXArg, float clientYArg, float buttonArg, EventTarget relatedTargetArg, string modifiersListArg, float deltaXArg, float deltaYArg, float deltaZArg, float deltaMode)
		{
			throw new System.NotImplementedException();
		}
	}

		public class WheelEvent_0_
	{
		public WheelEvent prototype;
		public float DOM_DELTA_LINE;
		public float DOM_DELTA_PAGE;
		public float DOM_DELTA_PIXEL;
		public WheelEvent new(string typeArg, WheelEventInit eventInitDict = default(WheelEventInit))
		{
			throw new System.NotImplementedException();
		}
	}

		public class IWindow : EventTarget, WindowTimers, WindowSessionStorage, WindowLocalStorage, WindowConsole, GlobalEventHandlers, IDBEnvironment, WindowBase64
	{
		protected IWindow() : base()
		{
			
		}
		public readonly applicationCache;
		public readonly clientInformation;
		public readonly closed;
		public readonly crypto;
		public string defaultStatus;
		public readonly devicePixelRatio;
		public readonly doNotTrack;
		public readonly document;
				public Event @event;
		public readonly external;
		public readonly frameElement;
		public readonly frames;
		public readonly history;
		public readonly innerHeight;
		public readonly innerWidth;
		public readonly length;
		public readonly location;
		public readonly locationbar;
		public readonly menubar;
		public readonly msCredentials;
		public string name;
		public readonly navigator;
		public Any<string, bool> offscreenBuffering;
		public Func<, object> onabort;
		public WheelEvent ev;
		public object any;
		public Func<, object> onafterprint;
		public Func<, object> onbeforeprint;
		public Func<, object> onbeforeunload;
		public Func<, object> onblur;
		public Func<, object> oncanplay;
		public Func<, object> oncanplaythrough;
		public Func<, object> onchange;
		public Func<, object> onclick;
		public Func<, object> oncompassneedscalibration;
		public Func<, object> oncontextmenu;
		public Func<, object> ondblclick;
		public Func<, object> ondevicelight;
		public Func<, object> ondevicemotion;
		public Func<, object> ondeviceorientation;
		public Func<, object> ondrag;
		public Func<, object> ondragend;
		public Func<, object> ondragenter;
		public Func<, object> ondragleave;
		public Func<, object> ondragover;
		public Func<, object> ondragstart;
		public Func<, object> ondrop;
		public Func<, object> ondurationchange;
		public Func<, object> onemptied;
		public Func<, object> onended;
		public ErrorEventHandler onerror;
		public Func<, object> onfocus;
		public Func<, object> onhashchange;
		public Func<, object> oninput;
		public Func<, object> oninvalid;
		public Func<, object> onkeydown;
		public Func<, object> onkeypress;
		public Func<, object> onkeyup;
		public Func<, object> onload;
		public Func<, object> onloadeddata;
		public Func<, object> onloadedmetadata;
		public Func<, object> onloadstart;
		public Func<, object> onmessage;
		public Func<, object> onmousedown;
		public Func<, object> onmouseenter;
		public Func<, object> onmouseleave;
		public Func<, object> onmousemove;
		public Func<, object> onmouseout;
		public Func<, object> onmouseover;
		public Func<, object> onmouseup;
		public Func<, object> onmousewheel;
		public Func<, object> onmsgesturechange;
		public Func<, object> onmsgesturedoubletap;
		public Func<, object> onmsgestureend;
		public Func<, object> onmsgesturehold;
		public Func<, object> onmsgesturestart;
		public Func<, object> onmsgesturetap;
		public Func<, object> onmsinertiastart;
		public Func<, object> onmspointercancel;
		public Func<, object> onmspointerdown;
		public Func<, object> onmspointerenter;
		public Func<, object> onmspointerleave;
		public Func<, object> onmspointermove;
		public Func<, object> onmspointerout;
		public Func<, object> onmspointerover;
		public Func<, object> onmspointerup;
		public Func<, object> onoffline;
		public Func<, object> ononline;
		public Func<, object> onorientationchange;
		public Func<, object> onpagehide;
		public Func<, object> onpageshow;
		public Func<, object> onpause;
		public Func<, object> onplay;
		public Func<, object> onplaying;
		public Func<, object> onpopstate;
		public Func<, object> onprogress;
		public Func<, object> onratechange;
		public Func<, object> onreadystatechange;
		public Func<, object> onreset;
		public Func<, object> onresize;
		public Func<, object> onscroll;
		public Func<, object> onseeked;
		public Func<, object> onseeking;
		public Func<, object> onselect;
		public Func<, object> onstalled;
		public Func<, object> onstorage;
		public Func<, object> onsubmit;
		public Func<, object> onsuspend;
		public Func<, object> ontimeupdate;
		public Func<TouchEvent, object> ontouchcancel;
		public Func<TouchEvent, object> ontouchend;
		public Func<TouchEvent, object> ontouchmove;
		public Func<TouchEvent, object> ontouchstart;
		public Func<, object> onunload;
		public Func<, object> onvolumechange;
		public Func<, object> onwaiting;
		public object opener;
		public Any<string, float> orientation;
		public readonly outerHeight;
		public readonly outerWidth;
		public readonly pageXOffset;
		public readonly pageYOffset;
		public readonly parent;
		public readonly performance;
		public readonly personalbar;
		public readonly screen;
		public readonly screenLeft;
		public readonly screenTop;
		public readonly screenX;
		public readonly screenY;
		public readonly scrollX;
		public readonly scrollY;
		public readonly scrollbars;
		public readonly self;
		public string status;
		public readonly statusbar;
		public readonly styleMedia;
		public readonly toolbar;
		public readonly top;
		public readonly window;
		public object URL;
		public object Blob;
		public Func<, object> listener;
		public bool useCapture;
		public float index;
		public void alert(object message = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void blur()
		{
			throw new System.NotImplementedException();
		}
		public void cancelAnimationFrame(float handle)
		{
			throw new System.NotImplementedException();
		}
		public void captureEvents()
		{
			throw new System.NotImplementedException();
		}
		public void close()
		{
			throw new System.NotImplementedException();
		}
		public bool confirm(string message = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void focus()
		{
			throw new System.NotImplementedException();
		}
		public CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt = default(string))
		{
			throw new System.NotImplementedException();
		}
		public CSSRuleList getMatchedCSSRules(Element elt, string pseudoElt = default(string))
		{
			throw new System.NotImplementedException();
		}
		public Selection getSelection()
		{
			throw new System.NotImplementedException();
		}
		public MediaQueryList matchMedia(string mediaQuery)
		{
			throw new System.NotImplementedException();
		}
		public void moveBy(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void moveTo(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void msWriteProfilerMark(string profilerMarkName)
		{
			throw new System.NotImplementedException();
		}
		public IWindow open(string url = default(string), string target = default(string), string features = default(string), bool replace = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void postMessage(object message, string targetOrigin, object[] transfer = default(object[]))
		{
			throw new System.NotImplementedException();
		}
		public void print()
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> prompt(string message = default(string), string _default = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void releaseEvents()
		{
			throw new System.NotImplementedException();
		}
		public float requestAnimationFrame(FrameRequestCallback callback)
		{
			throw new System.NotImplementedException();
		}
		public void resizeBy(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void resizeTo(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void scroll(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void scroll(ScrollToOptions options = default(ScrollToOptions))
		{
			throw new System.NotImplementedException();
		}
		public void scrollBy(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void scrollBy(ScrollToOptions options = default(ScrollToOptions))
		{
			throw new System.NotImplementedException();
		}
		public void scrollTo(float x = default(float), float y = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void scrollTo(ScrollToOptions options = default(ScrollToOptions))
		{
			throw new System.NotImplementedException();
		}
		public void webkitCancelAnimationFrame(float handle)
		{
			throw new System.NotImplementedException();
		}
		public WebKitPoint webkitConvertPointFromNodeToPage(Node node, WebKitPoint pt)
		{
			throw new System.NotImplementedException();
		}
		public WebKitPoint webkitConvertPointFromPageToNode(Node node, WebKitPoint pt)
		{
			throw new System.NotImplementedException();
		}
		public float webkitRequestAnimationFrame(FrameRequestCallback callback)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Worker : EventTarget, AbstractWorker
	{
		protected Worker() : base()
		{
			
		}
		public Func<, object> onmessage;
		public MessageEvent ev;
		public object any;
		public Func<, object> listener;
		public bool useCapture;
		public void postMessage(object message, object ports = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void terminate()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Worker_0_
	{
		public Worker prototype;
		public Worker new(string stringUrl)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLDocument : Document
	{
		protected XMLDocument() : base()
		{
			
		}
	}

		public class XMLDocument_0_
	{
		public XMLDocument prototype;
		public XMLDocument new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLHttpRequest : EventTarget, XMLHttpRequestEventTarget
	{
		protected XMLHttpRequest() : base()
		{
			
		}
		public Func<, object> onreadystatechange;
		public ProgressEvent ev;
		public object any;
		public readonly readyState;
		public readonly response;
		public readonly responseText;
		public string responseType;
		public readonly responseXML;
		public readonly status;
		public readonly statusText;
		public float timeout;
		public readonly upload;
		public bool withCredentials;
		public string msCaching;
		public readonly DONE;
		public readonly HEADERS_RECEIVED;
		public readonly LOADING;
		public readonly OPENED;
		public readonly UNSENT;
		public Func<, object> listener;
		public bool useCapture;
		public void abort()
		{
			throw new System.NotImplementedException();
		}
		public string getAllResponseHeaders()
		{
			throw new System.NotImplementedException();
		}
		public Any<string, null> getResponseHeader(string header)
		{
			throw new System.NotImplementedException();
		}
		public bool msCachingEnabled()
		{
			throw new System.NotImplementedException();
		}
		public void open(string method, string url, bool async = default(bool), string user = default(string), string password = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void overrideMimeType(string mime)
		{
			throw new System.NotImplementedException();
		}
		public void send(Document data = default(Document))
		{
			throw new System.NotImplementedException();
		}
		public void send(string data = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void send(object data = default(object))
		{
			throw new System.NotImplementedException();
		}
		public void setRequestHeader(string header, string value)
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLHttpRequest_0_
	{
		public XMLHttpRequest prototype;
		public float DONE;
		public float HEADERS_RECEIVED;
		public float LOADING;
		public float OPENED;
		public float UNSENT;
		public XMLHttpRequest new()
		{
			throw new System.NotImplementedException();
		}
		public XMLHttpRequest create()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLHttpRequestUpload : EventTarget, XMLHttpRequestEventTarget
	{
		protected XMLHttpRequestUpload() : base()
		{
			
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLHttpRequestUpload_0_
	{
		public XMLHttpRequestUpload prototype;
		public XMLHttpRequestUpload new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLSerializer
	{
		protected XMLSerializer()
		{
			
		}
		public string serializeToString(Node target)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLSerializer_0_
	{
		public XMLSerializer prototype;
		public XMLSerializer new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathEvaluator
	{
		protected XPathEvaluator()
		{
			
		}
		public XPathExpression createExpression(string expression, XPathNSResolver resolver)
		{
			throw new System.NotImplementedException();
		}
		public XPathNSResolver createNSResolver(Node nodeResolver = default(Node))
		{
			throw new System.NotImplementedException();
		}
		public XPathResult evaluate(string expression, Node contextNode, XPathNSResolver resolver, float type, XPathResult result)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathEvaluator_0_
	{
		public XPathEvaluator prototype;
		public XPathEvaluator new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathExpression
	{
		protected XPathExpression()
		{
			
		}
		public XPathExpression evaluate(Node contextNode, float type, XPathResult result)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathExpression_0_
	{
		public XPathExpression prototype;
		public XPathExpression new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathNSResolver
	{
		protected XPathNSResolver()
		{
			
		}
		public string lookupNamespaceURI(string prefix)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathNSResolver_0_
	{
		public XPathNSResolver prototype;
		public XPathNSResolver new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathResult
	{
		protected XPathResult()
		{
			
		}
		public readonly booleanValue;
		public readonly invalidIteratorState;
		public readonly numberValue;
		public readonly resultType;
		public readonly singleNodeValue;
		public readonly snapshotLength;
		public readonly stringValue;
		public readonly ANY_TYPE;
		public readonly ANY_UNORDERED_NODE_TYPE;
		public readonly BOOLEAN_TYPE;
		public readonly FIRST_ORDERED_NODE_TYPE;
		public readonly NUMBER_TYPE;
		public readonly ORDERED_NODE_ITERATOR_TYPE;
		public readonly ORDERED_NODE_SNAPSHOT_TYPE;
		public readonly STRING_TYPE;
		public readonly UNORDERED_NODE_ITERATOR_TYPE;
		public readonly UNORDERED_NODE_SNAPSHOT_TYPE;
		public Node iterateNext()
		{
			throw new System.NotImplementedException();
		}
		public Node snapshotItem(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XPathResult_0_
	{
		public XPathResult prototype;
		public float ANY_TYPE;
		public float ANY_UNORDERED_NODE_TYPE;
		public float BOOLEAN_TYPE;
		public float FIRST_ORDERED_NODE_TYPE;
		public float NUMBER_TYPE;
		public float ORDERED_NODE_ITERATOR_TYPE;
		public float ORDERED_NODE_SNAPSHOT_TYPE;
		public float STRING_TYPE;
		public float UNORDERED_NODE_ITERATOR_TYPE;
		public float UNORDERED_NODE_SNAPSHOT_TYPE;
		public XPathResult new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class XSLTProcessor
	{
		protected XSLTProcessor()
		{
			
		}
		public void clearParameters()
		{
			throw new System.NotImplementedException();
		}
		public object getParameter(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public void importStylesheet(Node style)
		{
			throw new System.NotImplementedException();
		}
		public void removeParameter(string namespaceURI, string localName)
		{
			throw new System.NotImplementedException();
		}
		public void reset()
		{
			throw new System.NotImplementedException();
		}
		public void setParameter(string namespaceURI, string localName, object value)
		{
			throw new System.NotImplementedException();
		}
		public Document transformToDocument(Node source)
		{
			throw new System.NotImplementedException();
		}
		public DocumentFragment transformToFragment(Node source, Document document)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XSLTProcessor_0_
	{
		public XSLTProcessor prototype;
		public XSLTProcessor new()
		{
			throw new System.NotImplementedException();
		}
	}

		public class AbstractWorker
	{
		protected AbstractWorker()
		{
			
		}
		public Func<, object> onerror;
		public ErrorEvent ev;
		public object any;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class CanvasPathMethods
	{
		protected CanvasPathMethods()
		{
			
		}
		public void arc(float x, float y, float radius, float startAngle, float endAngle, bool anticlockwise = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void arcTo(float x1, float y1, float x2, float y2, float radius)
		{
			throw new System.NotImplementedException();
		}
		public void bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void closePath()
		{
			throw new System.NotImplementedException();
		}
		public void ellipse(float x, float y, float radiusX, float radiusY, float rotation, float startAngle, float endAngle, bool anticlockwise = default(bool))
		{
			throw new System.NotImplementedException();
		}
		public void lineTo(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void moveTo(float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void quadraticCurveTo(float cpx, float cpy, float x, float y)
		{
			throw new System.NotImplementedException();
		}
		public void rect(float x, float y, float w, float h)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ChildNode
	{
		protected ChildNode()
		{
			
		}
		public void remove()
		{
			throw new System.NotImplementedException();
		}
	}

		public class DOML2DeprecatedColorProperty
	{
		protected DOML2DeprecatedColorProperty()
		{
			
		}
		public string color;
	}

		public class DOML2DeprecatedSizeProperty
	{
		protected DOML2DeprecatedSizeProperty()
		{
			
		}
		public float size;
	}

		public class DocumentEvent
	{
		protected DocumentEvent()
		{
			
		}
		public object createEvent(object eventInterface)
		{
			throw new System.NotImplementedException();
		}
		public Event createEvent(string eventInterface)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ElementTraversal
	{
		protected ElementTraversal()
		{
			
		}
		public readonly childElementCount;
		public readonly firstElementChild;
		public readonly lastElementChild;
		public readonly nextElementSibling;
		public readonly previousElementSibling;
	}

		public class GetSVGDocument
	{
		protected GetSVGDocument()
		{
			
		}
		public Document getSVGDocument()
		{
			throw new System.NotImplementedException();
		}
	}

		public class GlobalEventHandlers
	{
		protected GlobalEventHandlers()
		{
			
		}
		public Func<, object> onpointercancel;
		public WheelEvent ev;
		public object any;
		public Func<, object> onpointerdown;
		public Func<, object> onpointerenter;
		public Func<, object> onpointerleave;
		public Func<, object> onpointermove;
		public Func<, object> onpointerout;
		public Func<, object> onpointerover;
		public Func<, object> onpointerup;
		public Func<, object> onwheel;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLTableAlignment
	{
		protected HTMLTableAlignment()
		{
			
		}
		public string ch;
		public string chOff;
		public string vAlign;
	}

		public class IDBEnvironment
	{
		protected IDBEnvironment()
		{
			
		}
		public readonly indexedDB;
	}

		public class LinkStyle
	{
		protected LinkStyle()
		{
			
		}
		public readonly sheet;
	}

		public class MSBaseReader
	{
		protected MSBaseReader()
		{
			
		}
		public Func<, object> onabort;
		public ProgressEvent ev;
		public object any;
		public Func<, object> onerror;
		public Func<, object> onload;
		public Func<, object> onloadend;
		public Func<, object> onloadstart;
		public Func<, object> onprogress;
		public readonly readyState;
		public readonly result;
		public readonly DONE;
		public readonly EMPTY;
		public readonly LOADING;
		public Func<, object> listener;
		public bool useCapture;
		public void abort()
		{
			throw new System.NotImplementedException();
		}
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSFileSaver
	{
		protected MSFileSaver()
		{
			
		}
		public bool msSaveBlob(object blob, string defaultName = default(string))
		{
			throw new System.NotImplementedException();
		}
		public bool msSaveOrOpenBlob(object blob, string defaultName = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class MSNavigatorDoNotTrack
	{
		protected MSNavigatorDoNotTrack()
		{
			
		}
		public bool confirmSiteSpecificTrackingException(ConfirmSiteSpecificExceptionsInformation args)
		{
			throw new System.NotImplementedException();
		}
		public bool confirmWebWideTrackingException(ExceptionInformation args)
		{
			throw new System.NotImplementedException();
		}
		public void removeSiteSpecificTrackingException(ExceptionInformation args)
		{
			throw new System.NotImplementedException();
		}
		public void removeWebWideTrackingException(ExceptionInformation args)
		{
			throw new System.NotImplementedException();
		}
		public void storeSiteSpecificTrackingException(StoreSiteSpecificExceptionsInformation args)
		{
			throw new System.NotImplementedException();
		}
		public void storeWebWideTrackingException(StoreExceptionsInformation args)
		{
			throw new System.NotImplementedException();
		}
	}

		public class NavigatorContentUtils
	{
		protected NavigatorContentUtils()
		{
			
		}
	}

		public class NavigatorGeolocation
	{
		protected NavigatorGeolocation()
		{
			
		}
		public readonly geolocation;
	}

		public class NavigatorID
	{
		protected NavigatorID()
		{
			
		}
		public readonly appName;
		public readonly appVersion;
		public readonly platform;
		public readonly product;
		public readonly productSub;
		public readonly userAgent;
		public readonly vendor;
		public readonly vendorSub;
	}

		public class NavigatorOnLine
	{
		protected NavigatorOnLine()
		{
			
		}
		public readonly onLine;
	}

		public class NavigatorStorageUtils
	{
		protected NavigatorStorageUtils()
		{
			
		}
	}

		public class NavigatorUserMedia
	{
		protected NavigatorUserMedia()
		{
			
		}
		public readonly mediaDevices;
		public void getUserMedia(MediaStreamConstraints constraints, NavigatorUserMediaSuccessCallback successCallback, NavigatorUserMediaErrorCallback errorCallback)
		{
			throw new System.NotImplementedException();
		}
	}

		public class NodeSelector
	{
		protected NodeSelector()
		{
			
		}
		public object querySelector(object selectors)
		{
			throw new System.NotImplementedException();
		}
		public Element querySelector(string selectors)
		{
			throw new System.NotImplementedException();
		}
		public object querySelectorAll(object selectors)
		{
			throw new System.NotImplementedException();
		}
		public NodeListOf<Element> querySelectorAll(string selectors)
		{
			throw new System.NotImplementedException();
		}
	}

		public class RandomSource
	{
		protected RandomSource()
		{
			
		}
		public Bridge.Html5.ArrayBufferView getRandomValues(Bridge.Html5.ArrayBufferView array)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGAnimatedPathData
	{
		protected SVGAnimatedPathData()
		{
			
		}
		public readonly pathSegList;
	}

		public class SVGAnimatedPoints
	{
		protected SVGAnimatedPoints()
		{
			
		}
		public readonly animatedPoints;
		public readonly points;
	}

		public class SVGExternalResourcesRequired
	{
		protected SVGExternalResourcesRequired()
		{
			
		}
		public readonly externalResourcesRequired;
	}

		public class SVGFilterPrimitiveStandardAttributes : SVGStylable
	{
		protected SVGFilterPrimitiveStandardAttributes() : base()
		{
			
		}
		public readonly height;
		public readonly result;
		public readonly width;
		public readonly x;
		public readonly y;
	}

		public class SVGFitToViewBox
	{
		protected SVGFitToViewBox()
		{
			
		}
		public readonly preserveAspectRatio;
		public readonly viewBox;
	}

		public class SVGLangSpace
	{
		protected SVGLangSpace()
		{
			
		}
		public string xmllang;
		public string xmlspace;
	}

		public class SVGLocatable
	{
		protected SVGLocatable()
		{
			
		}
		public readonly farthestViewportElement;
		public readonly nearestViewportElement;
		public SVGRect getBBox()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix getCTM()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix getScreenCTM()
		{
			throw new System.NotImplementedException();
		}
		public SVGMatrix getTransformToElement(SVGElement element)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGStylable
	{
		protected SVGStylable()
		{
			
		}
		public object className;
		public readonly style;
	}

		public class SVGTests
	{
		protected SVGTests()
		{
			
		}
		public readonly requiredExtensions;
		public readonly requiredFeatures;
		public readonly systemLanguage;
		public bool hasExtension(string extension)
		{
			throw new System.NotImplementedException();
		}
	}

		public class SVGTransformable : SVGLocatable
	{
		protected SVGTransformable() : base()
		{
			
		}
		public readonly transform;
	}

		public class SVGURIReference
	{
		protected SVGURIReference()
		{
			
		}
		public readonly href;
	}

		public class WindowBase64
	{
		protected WindowBase64()
		{
			
		}
		public string atob(string encodedString)
		{
			throw new System.NotImplementedException();
		}
		public string btoa(string rawString)
		{
			throw new System.NotImplementedException();
		}
	}

		public class WindowConsole
	{
		protected WindowConsole()
		{
			
		}
		public readonly console;
	}

		public class WindowLocalStorage
	{
		protected WindowLocalStorage()
		{
			
		}
		public readonly localStorage;
	}

		public class WindowSessionStorage
	{
		protected WindowSessionStorage()
		{
			
		}
		public readonly sessionStorage;
	}

		public class WindowTimers : Object, WindowTimersExtension
	{
		protected WindowTimers() : base()
		{
			
		}
		public void clearInterval(float handle)
		{
			throw new System.NotImplementedException();
		}
		public void clearTimeout(float handle)
		{
			throw new System.NotImplementedException();
		}
		public float setInterval(Action<object[]> handler, float timeout)
		{
			throw new System.NotImplementedException();
		}
		public float setInterval(object handler, object timeout = default(object), params object[][] args)
		{
			throw new System.NotImplementedException();
		}
		public float setTimeout(Action<object[]> handler, float timeout)
		{
			throw new System.NotImplementedException();
		}
		public float setTimeout(object handler, object timeout = default(object), params object[][] args)
		{
			throw new System.NotImplementedException();
		}
	}

		public class WindowTimersExtension
	{
		protected WindowTimersExtension()
		{
			
		}
		public void clearImmediate(float handle)
		{
			throw new System.NotImplementedException();
		}
		public float setImmediate(Action<object[]> handler)
		{
			throw new System.NotImplementedException();
		}
		public float setImmediate(object handler, params object[][] args)
		{
			throw new System.NotImplementedException();
		}
	}

		public class XMLHttpRequestEventTarget
	{
		protected XMLHttpRequestEventTarget()
		{
			
		}
		public Func<, object> onabort;
		public ProgressEvent ev;
		public object any;
		public Func<, object> onerror;
		public Func<, object> onload;
		public Func<, object> onloadend;
		public Func<, object> onloadstart;
		public Func<, object> onprogress;
		public Func<, object> ontimeout;
		public Func<, object> listener;
		public bool useCapture;
		public object addEventListener(object type)
		{
			throw new System.NotImplementedException();
		}
		public void addEventListener(string type, EventListenerOrEventListenerObject listener, bool useCapture = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class StorageEventInit : EventInit
	{
		protected StorageEventInit() : base()
		{
			
		}
		public string key;
		public string oldValue;
		public string newValue;
		public string url;
		public Storage storageArea;
	}

		public class Canvas2DContextAttributes
	{
		protected Canvas2DContextAttributes()
		{
			
		}
		public bool alpha;
		public bool willReadFrequently;
		public bool storage;
		public string attribute;
	}

		public class NodeListOf<TNode> : NodeList where TNode : Node
	{
		protected NodeListOf() : base()
		{
			
		}
		public float length;
		public float index;
		public TNode item(float index)
		{
			throw new System.NotImplementedException();
		}
	}

		public class HTMLCollectionOf<T> : HTMLCollection where T : Element
	{
		protected HTMLCollectionOf() : base()
		{
			
		}
		public float index;
		public T item(float index)
		{
			throw new System.NotImplementedException();
		}
		public T namedItem(string name)
		{
			throw new System.NotImplementedException();
		}
	}

		public class BlobPropertyBag
	{
		protected BlobPropertyBag()
		{
			
		}
		public string type;
		public string endings;
	}

		public class FilePropertyBag
	{
		protected FilePropertyBag()
		{
			
		}
		public string type;
		public float lastModified;
	}

		public class EventListenerObject
	{
		protected EventListenerObject()
		{
			
		}
		public void handleEvent(Event evt)
		{
			throw new System.NotImplementedException();
		}
	}

		public class MessageEventInit : EventInit
	{
		protected MessageEventInit() : base()
		{
			
		}
		public object data;
		public string origin;
		public string lastEventId;
		public string channel;
		public object source;
		public MessagePort[] ports;
	}

		public class ProgressEventInit : EventInit
	{
		protected ProgressEventInit() : base()
		{
			
		}
		public bool lengthComputable;
		public float loaded;
		public float total;
	}

		public class ScrollOptions
	{
		protected ScrollOptions()
		{
			
		}
		public ScrollBehavior behavior;
	}

		public class ScrollToOptions : ScrollOptions
	{
		protected ScrollToOptions() : base()
		{
			
		}
		public float left;
		public float top;
	}

		public class ScrollIntoViewOptions : ScrollOptions
	{
		protected ScrollIntoViewOptions() : base()
		{
			
		}
		public ScrollLogicalPosition block;
		public ScrollLogicalPosition inline;
	}

		public class ClipboardEventInit : EventInit
	{
		protected ClipboardEventInit() : base()
		{
			
		}
		public string data;
		public string dataType;
	}

		public class IDBArrayKey : IDBValidKey[]
	{
		protected IDBArrayKey() : base()
		{
			
		}
	}

		public class RsaKeyGenParams : Algorithm
	{
		protected RsaKeyGenParams() : base()
		{
			
		}
		public float modulusLength;
		public Bridge.Html5.Uint8Array publicExponent;
	}

		public class RsaHashedKeyGenParams : RsaKeyGenParams
	{
		protected RsaHashedKeyGenParams() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
	}

		public class RsaKeyAlgorithm : KeyAlgorithm
	{
		protected RsaKeyAlgorithm() : base()
		{
			
		}
		public float modulusLength;
		public Bridge.Html5.Uint8Array publicExponent;
	}

		public class RsaHashedKeyAlgorithm : RsaKeyAlgorithm
	{
		protected RsaHashedKeyAlgorithm() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
	}

		public class RsaHashedImportParams
	{
		protected RsaHashedImportParams()
		{
			
		}
		public AlgorithmIdentifier hash;
	}

		public class RsaPssParams
	{
		protected RsaPssParams()
		{
			
		}
		public float saltLength;
	}

		public class RsaOaepParams : Algorithm
	{
		protected RsaOaepParams() : base()
		{
			
		}
		public BufferSource label;
	}

		public class EcdsaParams : Algorithm
	{
		protected EcdsaParams() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
	}

		public class EcKeyGenParams : Algorithm
	{
		protected EcKeyGenParams() : base()
		{
			
		}
		public string namedCurve;
	}

		public class EcKeyAlgorithm : KeyAlgorithm
	{
		protected EcKeyAlgorithm() : base()
		{
			
		}
		public string typedCurve;
	}

		public class EcKeyImportParams
	{
		protected EcKeyImportParams()
		{
			
		}
		public string namedCurve;
	}

		public class EcdhKeyDeriveParams : Algorithm
	{
		protected EcdhKeyDeriveParams() : base()
		{
			
		}
	}

		public class AesCtrParams : Algorithm
	{
		protected AesCtrParams() : base()
		{
			
		}
		public BufferSource counter;
		public float length;
	}

		public class AesKeyAlgorithm : KeyAlgorithm
	{
		protected AesKeyAlgorithm() : base()
		{
			
		}
		public float length;
	}

		public class AesKeyGenParams : Algorithm
	{
		protected AesKeyGenParams() : base()
		{
			
		}
		public float length;
	}

		public class AesDerivedKeyParams : Algorithm
	{
		protected AesDerivedKeyParams() : base()
		{
			
		}
		public float length;
	}

		public class AesCbcParams : Algorithm
	{
		protected AesCbcParams() : base()
		{
			
		}
		public BufferSource iv;
	}

		public class AesCmacParams : Algorithm
	{
		protected AesCmacParams() : base()
		{
			
		}
		public float length;
	}

		public class AesGcmParams : Algorithm
	{
		protected AesGcmParams() : base()
		{
			
		}
		public BufferSource iv;
		public BufferSource additionalData;
		public float tagLength;
	}

		public class AesCfbParams : Algorithm
	{
		protected AesCfbParams() : base()
		{
			
		}
		public BufferSource iv;
	}

		public class HmacImportParams : Algorithm
	{
		protected HmacImportParams() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
		public float length;
	}

		public class HmacKeyAlgorithm : KeyAlgorithm
	{
		protected HmacKeyAlgorithm() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
		public float length;
	}

		public class HmacKeyGenParams : Algorithm
	{
		protected HmacKeyGenParams() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
		public float length;
	}

		public class DhKeyGenParams : Algorithm
	{
		protected DhKeyGenParams() : base()
		{
			
		}
		public Bridge.Html5.Uint8Array prime;
		public Bridge.Html5.Uint8Array generator;
	}

		public class DhKeyAlgorithm : KeyAlgorithm
	{
		protected DhKeyAlgorithm() : base()
		{
			
		}
		public Bridge.Html5.Uint8Array prime;
		public Bridge.Html5.Uint8Array generator;
	}

		public class DhKeyDeriveParams : Algorithm
	{
		protected DhKeyDeriveParams() : base()
		{
			
		}
	}

		public class DhImportKeyParams : Algorithm
	{
		protected DhImportKeyParams() : base()
		{
			
		}
		public Bridge.Html5.Uint8Array prime;
		public Bridge.Html5.Uint8Array generator;
	}

		public class ConcatParams : Algorithm
	{
		protected ConcatParams() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
		public Bridge.Html5.Uint8Array algorithmId;
		public Bridge.Html5.Uint8Array partyUInfo;
		public Bridge.Html5.Uint8Array partyVInfo;
		public Bridge.Html5.Uint8Array publicInfo;
		public Bridge.Html5.Uint8Array privateInfo;
	}

		public class HkdfCtrParams : Algorithm
	{
		protected HkdfCtrParams() : base()
		{
			
		}
		public AlgorithmIdentifier hash;
		public BufferSource label;
		public BufferSource context;
	}

		public class Pbkdf2Params : Algorithm
	{
		protected Pbkdf2Params() : base()
		{
			
		}
		public BufferSource salt;
		public float iterations;
		public AlgorithmIdentifier hash;
	}

		public class RsaOtherPrimesInfo
	{
		protected RsaOtherPrimesInfo()
		{
			
		}
		public string r;
		public string d;
		public string t;
	}

		public class JsonWebKey
	{
		protected JsonWebKey()
		{
			
		}
		public string kty;
		public string use;
		public string[] key_ops;
		public string alg;
		public string kid;
		public string x5u;
		public string x5c;
		public string x5t;
		public bool ext;
		public string crv;
		public string x;
		public string y;
		public string d;
		public string n;
		public string e;
		public string p;
		public string q;
		public string dp;
		public string dq;
		public string qi;
		public RsaOtherPrimesInfo[] oth;
		public string k;
	}

		public class ParentNode
	{
		protected ParentNode()
		{
			
		}
		public readonly children;
		public readonly firstElementChild;
		public readonly lastElementChild;
		public readonly childElementCount;
	}

		public class ErrorEventHandler
	{
		protected ErrorEventHandler()
		{
			
		}
		public string message;
		public string filename;
		public float lineno;
		public float colno;
		public Error error;
	}

		public class PositionCallback
	{
		protected PositionCallback()
		{
			
		}
		public Position position;
	}

		public class PositionErrorCallback
	{
		protected PositionErrorCallback()
		{
			
		}
		public PositionError error;
	}

		public class MediaQueryListListener
	{
		protected MediaQueryListListener()
		{
			
		}
		public MediaQueryList mql;
	}

		public class MSLaunchUriCallback
	{
		protected MSLaunchUriCallback()
		{
			
		}
	}

		public class FrameRequestCallback
	{
		protected FrameRequestCallback()
		{
			
		}
		public float time;
	}

		public class MSUnsafeFunctionCallback
	{
		protected MSUnsafeFunctionCallback()
		{
			
		}
	}

		public class MSExecAtPriorityFunctionCallback
	{
		protected MSExecAtPriorityFunctionCallback()
		{
			
		}
		public object[] args;
	}

		public class MutationCallback
	{
		protected MutationCallback()
		{
			
		}
		public MutationRecord[] mutations;
		public MutationObserver observer;
	}

		public class DecodeSuccessCallback
	{
		protected DecodeSuccessCallback()
		{
			
		}
		public AudioBuffer decodedData;
	}

		public class DecodeErrorCallback
	{
		protected DecodeErrorCallback()
		{
			
		}
		public DOMException error;
	}

		public class FunctionStringCallback
	{
		protected FunctionStringCallback()
		{
			
		}
		public string data;
	}

		public class NavigatorUserMediaSuccessCallback
	{
		protected NavigatorUserMediaSuccessCallback()
		{
			
		}
		public MediaStream stream;
	}

		public class NavigatorUserMediaErrorCallback
	{
		protected NavigatorUserMediaErrorCallback()
		{
			
		}
		public MediaStreamError error;
	}

		public class ForEachCallback
	{
		protected ForEachCallback()
		{
			
		}
		public object keyId;
		public string status;
	}

		public class Audio_0_
	{
		public HTMLAudioElement new(string src = default(string))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Image_0_
	{
		public HTMLImageElement new(float width = default(float), float height = default(float))
		{
			throw new System.NotImplementedException();
		}
	}

		public class Option_0_
	{
		public HTMLOptionElement new(string text = default(string), string value = default(string), bool defaultSelected = default(bool), bool selected = default(bool))
		{
			throw new System.NotImplementedException();
		}
	}

		public class ActiveXObject
	{
		protected ActiveXObject()
		{
			
		}
		public object new(string s)
		{
			throw new System.NotImplementedException();
		}
	}

		public class ITextWriter
	{
		protected ITextWriter()
		{
			
		}
		public void Write(string s)
		{
			throw new System.NotImplementedException();
		}
		public void WriteLine(string s)
		{
			throw new System.NotImplementedException();
		}
		public void Close()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextStreamBase
	{
		protected TextStreamBase()
		{
			
		}
		public float Column;
		public float Line;
		public void Close()
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextStreamWriter : TextStreamBase
	{
		protected TextStreamWriter() : base()
		{
			
		}
		public void Write(string s)
		{
			throw new System.NotImplementedException();
		}
		public void WriteBlankLines(float intLines)
		{
			throw new System.NotImplementedException();
		}
		public void WriteLine(string s)
		{
			throw new System.NotImplementedException();
		}
	}

		public class TextStreamReader : TextStreamBase
	{
		protected TextStreamReader() : base()
		{
			
		}
		public bool AtEndOfLine;
		public bool AtEndOfStream;
		public string Read(float characters)
		{
			throw new System.NotImplementedException();
		}
		public string ReadAll()
		{
			throw new System.NotImplementedException();
		}
		public string ReadLine()
		{
			throw new System.NotImplementedException();
		}
		public void Skip(float characters)
		{
			throw new System.NotImplementedException();
		}
		public void SkipLine()
		{
			throw new System.NotImplementedException();
		}
	}

		public class Arguments_0_
	{
		public float length;
		public string Item(float n)
		{
			throw new System.NotImplementedException();
		}
	}

		public class WScript_0_
	{
		public TextStreamWriter StdErr;
		public TextStreamWriter StdOut;
		public Arguments_0_ Arguments;
		public string ScriptFullName;
		public float BuildVersion;
		public string FullName;
		public bool Interactive;
		public string Name;
		public string Path;
		public string ScriptName;
		public TextStreamReader StdIn;
		public string Version;
		public void Echo(object s)
		{
			throw new System.NotImplementedException();
		}
		public float Quit(float exitCode = default(float))
		{
			throw new System.NotImplementedException();
		}
		public void ConnectObject(object objEventSource, string strPrefix)
		{
			throw new System.NotImplementedException();
		}
		public object CreateObject(string strProgID, string strPrefix = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void DisconnectObject(object obj)
		{
			throw new System.NotImplementedException();
		}
		public object GetObject(string strPathname, string strProgID = default(string), string strPrefix = default(string))
		{
			throw new System.NotImplementedException();
		}
		public void Sleep(float intTime)
		{
			throw new System.NotImplementedException();
		}
	}

		public class Enumerator<T>
	{
		protected Enumerator()
		{
			
		}
		public bool atEnd()
		{
			throw new System.NotImplementedException();
		}
		public T item()
		{
			throw new System.NotImplementedException();
		}
		public void moveFirst()
		{
			throw new System.NotImplementedException();
		}
		public void moveNext()
		{
			throw new System.NotImplementedException();
		}
	}

		public class EnumeratorConstructor
	{
		protected EnumeratorConstructor()
		{
			
		}
		public Enumerator<T> new<T>(object collection)
		{
			throw new System.NotImplementedException();
		}
		public Enumerator<object> new(object collection)
		{
			throw new System.NotImplementedException();
		}
	}

		public class VBArray<T>
	{
		protected VBArray()
		{
			
		}
		public float dimensions()
		{
			throw new System.NotImplementedException();
		}
		public T getItem(float dimension1Index, params float[] dimensionNIndexes)
		{
			throw new System.NotImplementedException();
		}
		public float lbound(float dimension = default(float))
		{
			throw new System.NotImplementedException();
		}
		public float ubound(float dimension = default(float))
		{
			throw new System.NotImplementedException();
		}
		public T[] toArray()
		{
			throw new System.NotImplementedException();
		}
	}

		public class VBArrayConstructor
	{
		protected VBArrayConstructor()
		{
			
		}
		public VBArray<T> new<T>(object safeArray)
		{
			throw new System.NotImplementedException();
		}
		public VBArray<object> new(object safeArray)
		{
			throw new System.NotImplementedException();
		}
	}

		public class VarDate
	{
		protected VarDate()
		{
			
		}
	}
}
