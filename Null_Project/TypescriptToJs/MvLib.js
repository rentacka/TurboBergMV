///<reference path='mscorlib.ts'/>
///<reference path='TkoolCore/rpgmakermv.d.ts'/>
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var MvLib_SceneManager = (function (_super) {
    __extends(MvLib_SceneManager, _super);
    function MvLib_SceneManager() {
        return _super.call(this) || this;
    }
    MvLib_SceneManager.prototype.getActorObj = function () {
        // �I�𒆂̃A�N�^�[�I�u�W�F�N�g�擾
        return $gameParty.menuActor();
    };
    // https://raw.githubusercontent.com/triacontane/RPGMakerMV/master/MenuCommonEvent.js
    // �E�B���h�E�I�u�W�F�N�g��擾���܂��B
    MvLib_SceneManager.prototype.getSceneWindow = function (windowName) {
        var sceneWindow = SceneManager._scene[windowName];
        return sceneWindow instanceof Window ? sceneWindow : null;
    };
    // �e�X�g
    MvLib_SceneManager.prototype.getSceneWindow_Base = function (windowName) {
        var sceneWindow = SceneManager._scene[windowName];
        return sceneWindow instanceof Window_Base ? sceneWindow : null;
    };
    // �e�X�g2
    MvLib_SceneManager.prototype.getSceneWindow_T = function (windowName, constructor) {
        var sceneWindow = SceneManager._scene[windowName];
        return (sceneWindow instanceof constructor) ? sceneWindow : null;
    };
    MvLib_SceneManager.prototype.getSceneWindowList = function () {
        var windowList = [];
        for (var sceneWindow in SceneManager._scene) {
            if (SceneManager._scene.hasOwnProperty(sceneWindow) && SceneManager._scene[sceneWindow] instanceof Window) {
                windowList.push(SceneManager._scene[sceneWindow]);
            }
        }
        return windowList;
    };
    return MvLib_SceneManager;
}(NObject));
//# sourceMappingURL=MvLib.js.map