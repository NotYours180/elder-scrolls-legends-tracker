﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESLTracker.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00000000-0000-0000-0000-000000000000")]
        public global::System.Nullable<System.Guid> LastActiveDeckId {
            get {
                return ((global::System.Nullable<System.Guid>)(this["LastActiveDeckId"]));
            }
            set {
                this["LastActiveDeckId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowDeckStats {
            get {
                return ((bool)(this["ShowDeckStats"]));
            }
            set {
                this["ShowDeckStats"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimiseOnClose {
            get {
                return ((bool)(this["MinimiseOnClose"]));
            }
            set {
                this["MinimiseOnClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public double MainWindowPositionX {
            get {
                return ((double)(this["MainWindowPositionX"]));
            }
            set {
                this["MainWindowPositionX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public double MainWindowPositionY {
            get {
                return ((double)(this["MainWindowPositionY"]));
            }
            set {
                this["MainWindowPositionY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public double OverlayWindowPositionX {
            get {
                return ((double)(this["OverlayWindowPositionX"]));
            }
            set {
                this["OverlayWindowPositionX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public double OverlayWindowPositionY {
            get {
                return ((double)(this["OverlayWindowPositionY"]));
            }
            set {
                this["OverlayWindowPositionY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TheRitual")]
        public global::ESLTracker.DataModel.Enums.PlayerRank PlayerRank {
            get {
                return ((global::ESLTracker.DataModel.Enums.PlayerRank)(this["PlayerRank"]));
            }
            set {
                this["PlayerRank"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DataPath {
            get {
                return ((string)(this["DataPath"]));
            }
            set {
                this["DataPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Vs arena {0:yy/MM/dd HH:mm}")]
        public string NewDeck_VersusArenaName {
            get {
                return ((string)(this["NewDeck_VersusArenaName"]));
            }
            set {
                this["NewDeck_VersusArenaName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Solo arena {0:yy/MM/dd HH:mm}")]
        public string NewDeck_SoloArenaName {
            get {
                return ((string)(this["NewDeck_SoloArenaName"]));
            }
            set {
                this["NewDeck_SoloArenaName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("All")]
        public global::ESLTracker.ViewModels.Game.PredefinedDateFilter GamesFilter_SelectedPredefinedDateFilter {
            get {
                return ((global::ESLTracker.ViewModels.Game.PredefinedDateFilter)(this["GamesFilter_SelectedPredefinedDateFilter"]));
            }
            set {
                this["GamesFilter_SelectedPredefinedDateFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00")]
        public global::System.TimeSpan GamesFilter_DayCutoffTime {
            get {
                return ((global::System.TimeSpan)(this["GamesFilter_DayCutoffTime"]));
            }
            set {
                this["GamesFilter_DayCutoffTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool Packs_ScreenshotAfterAdded {
            get {
                return ((bool)(this["Packs_ScreenshotAfterAdded"]));
            }
            set {
                this["Packs_ScreenshotAfterAdded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pack_{n:0000}_{d:yyyy_MM_dd_HH_mm}")]
        public string Packs_ScreenshotNameTemplate {
            get {
                return ((string)(this["Packs_ScreenshotNameTemplate"]));
            }
            set {
                this["Packs_ScreenshotNameTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Screenshot_{0:yyyy_MM_dd_HH_mm_ss}")]
        public string General_ScreenshotNameTemplate {
            get {
                return ((string)(this["General_ScreenshotNameTemplate"]));
            }
            set {
                this["General_ScreenshotNameTemplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public double OverlayDeck_WindowPositionX {
            get {
                return ((double)(this["OverlayDeck_WindowPositionX"]));
            }
            set {
                this["OverlayDeck_WindowPositionX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public double OverlayDeck_WindowPositionY {
            get {
                return ((double)(this["OverlayDeck_WindowPositionY"]));
            }
            set {
                this["OverlayDeck_WindowPositionY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double OverlayDeck_Scale {
            get {
                return ((double)(this["OverlayDeck_Scale"]));
            }
            set {
                this["OverlayDeck_Scale"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OverlayDeck_ShowOnStart {
            get {
                return ((bool)(this["OverlayDeck_ShowOnStart"]));
            }
            set {
                this["OverlayDeck_ShowOnStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OverlayWindow_ShowOnStart {
            get {
                return ((bool)(this["OverlayWindow_ShowOnStart"]));
            }
            set {
                this["OverlayWindow_ShowOnStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Forbidden")]
        public global::ESLTracker.ViewModels.Decks.DeckDeleteMode DeckDeleteMode {
            get {
                return ((global::ESLTracker.ViewModels.Decks.DeckDeleteMode)(this["DeckDeleteMode"]));
            }
            set {
                this["DeckDeleteMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Name")]
        public global::ESLTracker.ViewModels.Decks.DeckViewSortOrder DeckViewSortOrder {
            get {
                return ((global::ESLTracker.ViewModels.Decks.DeckViewSortOrder)(this["DeckViewSortOrder"]));
            }
            set {
                this["DeckViewSortOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DeckViewLastGamesIndicatorShow {
            get {
                return ((bool)(this["DeckViewLastGamesIndicatorShow"]));
            }
            set {
                this["DeckViewLastGamesIndicatorShow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int DeckViewLastGamesIndicatorCount {
            get {
                return ((int)(this["DeckViewLastGamesIndicatorCount"]));
            }
            set {
                this["DeckViewLastGamesIndicatorCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/MarioZG/elder-scrolls-legends-tracker/master/Bu" +
            "ild/versions.json")]
        public string VersionCheck_VersionsUrl {
            get {
                return ((string)(this["VersionCheck_VersionsUrl"]));
            }
            set {
                this["VersionCheck_VersionsUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://api.github.com/repos/MarioZG/elder-scrolls-legends-tracker/releases/lates" +
            "t")]
        public string VersionCheck_LatestBuildUrl {
            get {
                return ((string)(this["VersionCheck_LatestBuildUrl"]));
            }
            set {
                this["VersionCheck_LatestBuildUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://raw.githubusercontent.com/MarioZG/elder-scrolls-legends-tracker/master/ES" +
            "LTracker/Resources/cards.json")]
        public string VersionCheck_CardsDBUrl {
            get {
                return ((string)(this["VersionCheck_CardsDBUrl"]));
            }
            set {
                this["VersionCheck_CardsDBUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/MarioZG/elder-scrolls-legends-tracker/releases/latest")]
        public string VersionCheck_LatestBuildUserUrl {
            get {
                return ((string)(this["VersionCheck_LatestBuildUserUrl"]));
            }
            set {
                this["VersionCheck_LatestBuildUserUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00000000-0000-0000-0000-000000000000")]
        public global::System.Nullable<System.Guid> Packs_LastOpenedPackSetId {
            get {
                return ((global::System.Nullable<System.Guid>)(this["Packs_LastOpenedPackSetId"]));
            }
            set {
                this["Packs_LastOpenedPackSetId"] = value;
            }
        }
    }
}
